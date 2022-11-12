namespace _3_PL.Views
{
    partial class FrmLogin
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
            this.tbx_tk = new System.Windows.Forms.TextBox();
            this.cb_save = new System.Windows.Forms.CheckBox();
            this.lb_quenmk = new System.Windows.Forms.Label();
            this.pb_logo = new System.Windows.Forms.PictureBox();
            this.tbx_mk = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // tbx_tk
            // 
            this.tbx_tk.Location = new System.Drawing.Point(213, 256);
            this.tbx_tk.Name = "tbx_tk";
            this.tbx_tk.Size = new System.Drawing.Size(402, 31);
            this.tbx_tk.TabIndex = 0;
            // 
            // cb_save
            // 
            this.cb_save.AutoSize = true;
            this.cb_save.Location = new System.Drawing.Point(347, 400);
            this.cb_save.Name = "cb_save";
            this.cb_save.Size = new System.Drawing.Size(146, 29);
            this.cb_save.TabIndex = 1;
            this.cb_save.Text = "Lưu mật khẩu";
            this.cb_save.UseVisualStyleBackColor = true;
            // 
            // lb_quenmk
            // 
            this.lb_quenmk.AutoSize = true;
            this.lb_quenmk.Location = new System.Drawing.Point(339, 453);
            this.lb_quenmk.Name = "lb_quenmk";
            this.lb_quenmk.Size = new System.Drawing.Size(147, 25);
            this.lb_quenmk.TabIndex = 2;
            this.lb_quenmk.Text = "Quên mật khẩu ?";
            // 
            // pb_logo
            // 
            this.pb_logo.Location = new System.Drawing.Point(328, 46);
            this.pb_logo.Name = "pb_logo";
            this.pb_logo.Size = new System.Drawing.Size(213, 169);
            this.pb_logo.TabIndex = 3;
            this.pb_logo.TabStop = false;
            // 
            // tbx_mk
            // 
            this.tbx_mk.Location = new System.Drawing.Point(213, 332);
            this.tbx_mk.Name = "tbx_mk";
            this.tbx_mk.Size = new System.Drawing.Size(402, 31);
            this.tbx_mk.TabIndex = 4;
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(347, 507);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(139, 53);
            this.btn_login.TabIndex = 5;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = true;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 652);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.tbx_mk);
            this.Controls.Add(this.pb_logo);
            this.Controls.Add(this.lb_quenmk);
            this.Controls.Add(this.cb_save);
            this.Controls.Add(this.tbx_tk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmLogin";
            this.Text = "FrmLogin";
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbx_tk;
        private System.Windows.Forms.CheckBox cb_save;
        private System.Windows.Forms.Label lb_quenmk;
        private System.Windows.Forms.PictureBox pb_logo;
        private System.Windows.Forms.TextBox tbx_mk;
        private System.Windows.Forms.Button btn_login;
    }
}