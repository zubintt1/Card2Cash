using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;
using System.Net;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Diagnostics;

namespace Card2Cash
{
    public partial class ActivateForm : Form
    {
        public ActivateForm()
        {
            InitializeComponent();
            
        }

        public ActivateForm(string prevnum)
        {
            InitializeComponent();
            if (prevnum.ToString() != null)
            {
                numver_txtbx.Text = prevnum;
            }

        }

        private void activate_btn_Click(object sender, EventArgs e)
        {
            string Number1 = numver_txtbx.Text.Trim();
            string ApiReq1 = "https://api.urbanpiper.com/api/v1/card/activate/?format=json&customer_phone=91#replace#&username=zubin_urbanpiper&api_key=12345";
            string ApiReq2 = ApiReq1.Replace("#replace#", Number1);
            WebRequest request = WebRequest.Create(ApiReq2);
            
            //Stopwatch timer = new Stopwatch();
            //timer.Start();

            WebResponse response = request.GetResponse();
            Stream dataStream = response.GetResponseStream();

            //timer.Stop();
            //TimeSpan timetaken = timer.Elapsed;

            //numver_txtbx.Text = timetaken.TotalSeconds.ToString();

            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(ResposeData));
            ResposeData datagot = (ResposeData)serializer.ReadObject(dataStream);

            PayForm1 pf = new PayForm1(numver_txtbx.Text);

            string status = datagot.success;
            
            if(status == "False")
            {
                this.Hide();
                pf.ShowDialog();
            }
            else
            {
                
                congrats_lbl1.Visible = true;
                this.Enabled = false;
                WaitSomeTime();
                this.Hide();
                pf.ShowDialog();
            }
            
            /*
            // Open the stream using a StreamReader for easy access.
            StreamReader reader = new StreamReader(dataStream);
            // Read the content.
            string responseFromServer = reader.ReadToEnd();
            // Display the content.
            experi_txtbx.Text = responseFromServer;
            */

        }

        public class ResposeData
        {
            public string success { get; set; }
        }

        
        public async void WaitSomeTime()
        {
            await Task.Delay(5000);
            this.Enabled = true;
        }
        
    }
}
