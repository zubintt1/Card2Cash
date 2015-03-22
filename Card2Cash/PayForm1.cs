using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Json;
using System.Web;
using System.Net;
using System.IO;
using System.Runtime.Serialization;
using System.Diagnostics;

namespace Card2Cash
{
    public partial class PayForm1 : Form
    {
        public PayForm1(string numver)
        {
            InitializeComponent();
            result_txtbx1.Clear();
            if (numver.ToString() != null)
            {
                numver2_txtbx.Text = numver;
            }
        }

        public PayForm1()
        {
            InitializeComponent();
            result_txtbx1.Clear();
        }

        private void back_btn1_Click(object sender, EventArgs e)
        {
            ActivateForm af = new ActivateForm(numver2_txtbx.Text);
            result_txtbx1.Clear();
            this.Hide();
            af.ShowDialog();
        }

        private void pay_btn1_Click(object sender, EventArgs e)
        {
            result_txtbx1.Clear();
            string Number2 = numver2_txtbx.Text.Trim();
            float amount = float.Parse(amount_txtbx1.Text.Trim());
            
            //jUST FOR CHECKING numver2_txtbx.Text = amount.ToString();

            string ApiReq1 = "https://api.urbanpiper.com/api/v1/card/balanceupdate/?format=json&customer_phone=91#number#&username=zubin_urbanpiper&api_key=12345&amount=-#amount#";
            string ApiReq2 = ApiReq1.Replace("#number#", Number2);
            string ApiReq3 = ApiReq2.Replace("#amount#",amount.ToString());

            WebRequest request = WebRequest.Create(ApiReq3);
            WebResponse response = request.GetResponse();
            Stream dataStream = response.GetResponseStream();
            
            /*
            StreamReader reader = new StreamReader(dataStream);
            string responseFromServer = reader.ReadToEnd();
            result_txtbx1.Text = responseFromServer;
            */

       
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(ResponseData2));
            ResponseData2 datagot = (ResponseData2)serializer.ReadObject(dataStream);

            PayForm2 pf2 = new PayForm2(numver2_txtbx.Text);

            string status = datagot.success;
            string message = datagot.message;

            if (status == "False")
            {
                result_txtbx1.Text = message;
                Failure_lbl1.Visible = true;
                this.Enabled = false;
                WaitSomeTime();
                this.Hide();
                pf2.ShowDialog();
            }
            else
            {
                result_txtbx1.Text = message;
                Success_lbl1.Visible = true;
                this.Enabled = false;
                WaitSomeTime();
                this.Hide();
                pf2.ShowDialog();
            }
                      
        }

        public class ResponseData2
        {
            public string success { get; set; }
            public string message { get; set; }

        }
        public async void WaitSomeTime()
        {
            await Task.Delay(5000);
            this.Enabled = true;
        }
    }
}
