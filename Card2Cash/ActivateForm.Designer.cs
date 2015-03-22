namespace Card2Cash
{
    partial class ActivateForm
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
            this.numver_txtbx = new System.Windows.Forms.TextBox();
            this.request_lbl1 = new System.Windows.Forms.Label();
            this.activate_btn = new System.Windows.Forms.Button();
            this.congrats_lbl1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // numver_txtbx
            // 
            this.numver_txtbx.Location = new System.Drawing.Point(95, 102);
            this.numver_txtbx.Name = "numver_txtbx";
            this.numver_txtbx.Size = new System.Drawing.Size(99, 20);
            this.numver_txtbx.TabIndex = 0;
            // 
            // request_lbl1
            // 
            this.request_lbl1.AutoSize = true;
            this.request_lbl1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.request_lbl1.Location = new System.Drawing.Point(10, 29);
            this.request_lbl1.Name = "request_lbl1";
            this.request_lbl1.Size = new System.Drawing.Size(271, 21);
            this.request_lbl1.TabIndex = 1;
            this.request_lbl1.Text = "Please Enter Your Mobile Number";
            this.request_lbl1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // activate_btn
            // 
            this.activate_btn.AutoEllipsis = true;
            this.activate_btn.Location = new System.Drawing.Point(95, 170);
            this.activate_btn.Name = "activate_btn";
            this.activate_btn.Size = new System.Drawing.Size(99, 54);
            this.activate_btn.TabIndex = 2;
            this.activate_btn.Text = "Activate";
            this.activate_btn.UseVisualStyleBackColor = true;
            this.activate_btn.Click += new System.EventHandler(this.activate_btn_Click);
            // 
            // congrats_lbl1
            // 
            this.congrats_lbl1.AutoSize = true;
            this.congrats_lbl1.Font = new System.Drawing.Font("Times New Roman", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.congrats_lbl1.Location = new System.Drawing.Point(11, 262);
            this.congrats_lbl1.MaximumSize = new System.Drawing.Size(0, 50);
            this.congrats_lbl1.MinimumSize = new System.Drawing.Size(0, 50);
            this.congrats_lbl1.Name = "congrats_lbl1";
            this.congrats_lbl1.Size = new System.Drawing.Size(287, 50);
            this.congrats_lbl1.TabIndex = 3;
            this.congrats_lbl1.Text = "Congratulations your number has been activated succeffully.";
            this.congrats_lbl1.Visible = false;
            // 
            // ActivateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 326);
            this.Controls.Add(this.congrats_lbl1);
            this.Controls.Add(this.activate_btn);
            this.Controls.Add(this.request_lbl1);
            this.Controls.Add(this.numver_txtbx);
            this.Name = "ActivateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox numver_txtbx;
        private System.Windows.Forms.Label request_lbl1;
        private System.Windows.Forms.Button activate_btn;
        private System.Windows.Forms.Label congrats_lbl1;
    }
}