namespace Card2Cash
{
    partial class PayForm1
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
            this.numver2_txtbx = new System.Windows.Forms.TextBox();
            this.request_lbl2 = new System.Windows.Forms.Label();
            this.request_label3 = new System.Windows.Forms.Label();
            this.amount_txtbx1 = new System.Windows.Forms.TextBox();
            this.pay_btn1 = new System.Windows.Forms.Button();
            this.back_btn1 = new System.Windows.Forms.Button();
            this.result_txtbx1 = new System.Windows.Forms.RichTextBox();
            this.Failure_lbl1 = new System.Windows.Forms.Label();
            this.Success_lbl1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // numver2_txtbx
            // 
            this.numver2_txtbx.Location = new System.Drawing.Point(221, 12);
            this.numver2_txtbx.Name = "numver2_txtbx";
            this.numver2_txtbx.Size = new System.Drawing.Size(100, 20);
            this.numver2_txtbx.TabIndex = 0;
            // 
            // request_lbl2
            // 
            this.request_lbl2.AutoSize = true;
            this.request_lbl2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.request_lbl2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.request_lbl2.Location = new System.Drawing.Point(12, 12);
            this.request_lbl2.Name = "request_lbl2";
            this.request_lbl2.Size = new System.Drawing.Size(175, 15);
            this.request_lbl2.TabIndex = 1;
            this.request_lbl2.Text = "Please provide your phone number";
            // 
            // request_label3
            // 
            this.request_label3.AutoSize = true;
            this.request_label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.request_label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.request_label3.Location = new System.Drawing.Point(12, 57);
            this.request_label3.Name = "request_label3";
            this.request_label3.Size = new System.Drawing.Size(171, 15);
            this.request_label3.TabIndex = 3;
            this.request_label3.Text = "Please enter the amount to be paid";
            // 
            // amount_txtbx1
            // 
            this.amount_txtbx1.Location = new System.Drawing.Point(221, 57);
            this.amount_txtbx1.Name = "amount_txtbx1";
            this.amount_txtbx1.Size = new System.Drawing.Size(100, 20);
            this.amount_txtbx1.TabIndex = 4;
            // 
            // pay_btn1
            // 
            this.pay_btn1.Location = new System.Drawing.Point(246, 117);
            this.pay_btn1.Name = "pay_btn1";
            this.pay_btn1.Size = new System.Drawing.Size(75, 43);
            this.pay_btn1.TabIndex = 5;
            this.pay_btn1.Text = "Pay";
            this.pay_btn1.UseVisualStyleBackColor = true;
            this.pay_btn1.Click += new System.EventHandler(this.pay_btn1_Click);
            // 
            // back_btn1
            // 
            this.back_btn1.Location = new System.Drawing.Point(15, 117);
            this.back_btn1.Name = "back_btn1";
            this.back_btn1.Size = new System.Drawing.Size(75, 43);
            this.back_btn1.TabIndex = 6;
            this.back_btn1.Text = "Back";
            this.back_btn1.UseVisualStyleBackColor = true;
            this.back_btn1.Click += new System.EventHandler(this.back_btn1_Click);
            // 
            // result_txtbx1
            // 
            this.result_txtbx1.Location = new System.Drawing.Point(12, 166);
            this.result_txtbx1.Name = "result_txtbx1";
            this.result_txtbx1.Size = new System.Drawing.Size(309, 108);
            this.result_txtbx1.TabIndex = 7;
            this.result_txtbx1.Text = "";
            // 
            // Failure_lbl1
            // 
            this.Failure_lbl1.AutoSize = true;
            this.Failure_lbl1.BackColor = System.Drawing.SystemColors.ControlText;
            this.Failure_lbl1.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.Failure_lbl1.ForeColor = System.Drawing.Color.Red;
            this.Failure_lbl1.Location = new System.Drawing.Point(12, 297);
            this.Failure_lbl1.Name = "Failure_lbl1";
            this.Failure_lbl1.Size = new System.Drawing.Size(56, 19);
            this.Failure_lbl1.TabIndex = 8;
            this.Failure_lbl1.Text = "Failure";
            this.Failure_lbl1.Visible = false;
            // 
            // Success_lbl1
            // 
            this.Success_lbl1.AutoSize = true;
            this.Success_lbl1.BackColor = System.Drawing.SystemColors.ControlText;
            this.Success_lbl1.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.Success_lbl1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Success_lbl1.Location = new System.Drawing.Point(259, 297);
            this.Success_lbl1.Name = "Success_lbl1";
            this.Success_lbl1.Size = new System.Drawing.Size(62, 19);
            this.Success_lbl1.TabIndex = 9;
            this.Success_lbl1.Text = "Success";
            this.Success_lbl1.Visible = false;
            // 
            // PayForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 322);
            this.Controls.Add(this.Success_lbl1);
            this.Controls.Add(this.Failure_lbl1);
            this.Controls.Add(this.result_txtbx1);
            this.Controls.Add(this.back_btn1);
            this.Controls.Add(this.pay_btn1);
            this.Controls.Add(this.amount_txtbx1);
            this.Controls.Add(this.request_label3);
            this.Controls.Add(this.request_lbl2);
            this.Controls.Add(this.numver2_txtbx);
            this.Name = "PayForm1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox numver2_txtbx;
        private System.Windows.Forms.Label request_lbl2;
        private System.Windows.Forms.Label request_label3;
        private System.Windows.Forms.TextBox amount_txtbx1;
        private System.Windows.Forms.Button pay_btn1;
        private System.Windows.Forms.Button back_btn1;
        private System.Windows.Forms.RichTextBox result_txtbx1;
        private System.Windows.Forms.Label Failure_lbl1;
        private System.Windows.Forms.Label Success_lbl1;
    }
}