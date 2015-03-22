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
    public partial class PayForm2 : Form
    {
        public PayForm2(string numver3)
        {
            InitializeComponent();
            result_txtbx2.Clear();
            Success_lbl2.Visible = false;
            Failure_lbl2.Visible = false;
            if (numver3.ToString() != null)
            {
                numver_txtbx3.Text = numver3;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Success_lbl2.Visible = false;
            Failure_lbl2.Visible = false;
            this.Hide();
            result_txtbx2.Clear();
            PayForm1 pf2 = new PayForm1(numver_txtbx3.Text);
            pf2.ShowDialog();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            result_txtbx2.Clear();
            Success_lbl2.Visible = false;
            Failure_lbl2.Visible = false;
            string Number3 = numver_txtbx3.Text.Trim();
            float amount3 = float.Parse(amount_txtbx1.Text.ToString());
            string OTPNum = otpver_txtbx1.Text.Trim();

            string ApiReq1 = "https://api.urbanpiper.com/api/v1/card/balanceupdate/?format=json&customer_phone=91#number#&username=zubin_urbanpiper&api_key=12345&amount=-#amount#&pin=#Otp#";
            string ApiReq2 = ApiReq1.Replace("#number#", Number3);
            string ApiReq3 = ApiReq2.Replace("#amount#", amount3.ToString());
            string ApiReq4 = ApiReq3.Replace("#Otp#", OTPNum);

            WebRequest request = WebRequest.Create(ApiReq4);
            WebResponse response = request.GetResponse();
            Stream dataStream = response.GetResponseStream();
            
            /*
            StreamReader reader = new StreamReader(dataStream);
            string responseFromServer = reader.ReadToEnd();
            result_txtbx2.Text = responseFromServer+ApiReq4;
            */
            
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(ResponseData3));
            ResponseData3 datagot = (ResponseData3)serializer.ReadObject(dataStream);

            string status = datagot.success;
            string message = datagot.message;

            if (status == "False")
            {
                Success_lbl2.Visible = false;
                Failure_lbl2.Visible = true;
                result_txtbx2.Text = message;
                //result_txtbx2.Text = ApiReq4;
                
            }
            else
            {
                Failure_lbl2.Visible = false;
                Success_lbl2.Visible = true;
                result_txtbx2.Text = message;
                //result_txtbx2.Text = ApiReq4;
              
            }
            
        }
        
        public class ResponseData3
        {
            public string success { get; set; }
            public string message { get; set; }

        }
       
    }
}
