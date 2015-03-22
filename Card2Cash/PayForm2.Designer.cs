namespace Card2Cash
{
    partial class PayForm2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.request_lbl4 = new System.Windows.Forms.Label();
            this.numver_txtbx3 = new System.Windows.Forms.TextBox();
            this.otpver_txtbx1 = new System.Windows.Forms.TextBox();
            this.amount_txtbx1 = new System.Windows.Forms.TextBox();
            this.request_lbl5 = new System.Windows.Forms.Label();
            this.request_lbl6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.result_txtbx2 = new System.Windows.Forms.RichTextBox();
            this.Failure_lbl2 = new System.Windows.Forms.Label();
            this.Success_lbl2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // request_lbl4
            // 
            this.request_lbl4.AutoSize = true;
            this.request_lbl4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.request_lbl4.Location = new System.Drawing.Point(13, 13);
            this.request_lbl4.Name = "request_lbl4";
            this.request_lbl4.Size = new System.Drawing.Size(175, 15);
            this.request_lbl4.TabIndex = 0;
            this.request_lbl4.Text = "Please provide your phone number";
            // 
            // numver_txtbx3
            // 
            this.numver_txtbx3.Location = new System.Drawing.Point(221, 6);
            this.numver_txtbx3.Name = "numver_txtbx3";
            this.numver_txtbx3.Size = new System.Drawing.Size(100, 20);
            this.numver_txtbx3.TabIndex = 1;
            // 
            // otpver_txtbx1
            // 
            this.otpver_txtbx1.Location = new System.Drawing.Point(220, 46);
            this.otpver_txtbx1.Name = "otpver_txtbx1";
            this.otpver_txtbx1.Size = new System.Drawing.Size(100, 20);
            this.otpver_txtbx1.TabIndex = 2;
            // 
            // amount_txtbx1
            // 
            this.amount_txtbx1.Location = new System.Drawing.Point(219, 87);
            this.amount_txtbx1.Name = "amount_txtbx1";
            this.amount_txtbx1.Size = new System.Drawing.Size(100, 20);
            this.amount_txtbx1.TabIndex = 3;
            // 
            // request_lbl5
            // 
            this.request_lbl5.AutoSize = true;
            this.request_lbl5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.request_lbl5.Location = new System.Drawing.Point(13, 53);
            this.request_lbl5.Name = "request_lbl5";
            this.request_lbl5.Size = new System.Drawing.Size(150, 15);
            this.request_lbl5.TabIndex = 4;
            this.request_lbl5.Text = "Please Enter the OTP number";
            // 
            // request_lbl6
            // 
            this.request_lbl6.AutoSize = true;
            this.request_lbl6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.request_lbl6.Location = new System.Drawing.Point(13, 94);
            this.request_lbl6.Name = "request_lbl6";
            this.request_lbl6.Size = new System.Drawing.Size(173, 15);
            this.request_lbl6.TabIndex = 5;
            this.request_lbl6.Text = "Please Enter the amount to be paid";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 137);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(243, 136);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Pay";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // result_txtbx2
            // 
            this.result_txtbx2.Location = new System.Drawing.Point(12, 182);
            this.result_txtbx2.Name = "result_txtbx2";
            this.result_txtbx2.Size = new System.Drawing.Size(309, 105);
            this.result_txtbx2.TabIndex = 8;
            this.result_txtbx2.Text = "";
            // 
            // Failure_lbl2
            // 
            this.Failure_lbl2.AutoSize = true;
            this.Failure_lbl2.BackColor = System.Drawing.SystemColors.ControlText;
            this.Failure_lbl2.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.Failure_lbl2.ForeColor = System.Drawing.Color.Red;
            this.Failure_lbl2.Location = new System.Drawing.Point(12, 306);
            this.Failure_lbl2.Name = "Failure_lbl2";
            this.Failure_lbl2.Size = new System.Drawing.Size(56, 19);
            this.Failure_lbl2.TabIndex = 9;
            this.Failure_lbl2.Text = "Failure";
            this.Failure_lbl2.Visible = false;
            // 
            // Success_lbl2
            // 
            this.Success_lbl2.AutoSize = true;
            this.Success_lbl2.BackColor = System.Drawing.SystemColors.ControlText;
            this.Success_lbl2.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.Success_lbl2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Success_lbl2.Location = new System.Drawing.Point(263, 306);
            this.Success_lbl2.Name = "Success_lbl2";
            this.Success_lbl2.Size = new System.Drawing.Size(62, 19);
            this.Success_lbl2.TabIndex = 10;
            this.Success_lbl2.Text = "Success";
            this.Success_lbl2.Visible = false;
            // 
            // PayForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 331);
            this.Controls.Add(this.Success_lbl2);
            this.Controls.Add(this.Failure_lbl2);
            this.Controls.Add(this.result_txtbx2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.request_lbl6);
            this.Controls.Add(this.request_lbl5);
            this.Controls.Add(this.amount_txtbx1);
            this.Controls.Add(this.otpver_txtbx1);
            this.Controls.Add(this.numver_txtbx3);
            this.Controls.Add(this.request_lbl4);
            this.Name = "PayForm2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label request_lbl4;
        private System.Windows.Forms.TextBox numver_txtbx3;
        private System.Windows.Forms.TextBox otpver_txtbx1;
        private System.Windows.Forms.TextBox amount_txtbx1;
        private System.Windows.Forms.Label request_lbl5;
        private System.Windows.Forms.Label request_lbl6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RichTextBox result_txtbx2;
        private System.Windows.Forms.Label Failure_lbl2;
        private System.Windows.Forms.Label Success_lbl2;
    }
}