namespace DoAnCuoiKy
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.chk_show = new System.Windows.Forms.CheckBox();
            this.lbl_TTlogin = new System.Windows.Forms.Label();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Log = new System.Windows.Forms.Button();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.txt_user = new System.Windows.Forms.TextBox();
            this.lbl_pass = new System.Windows.Forms.Label();
            this.lbl_User = new System.Windows.Forms.Label();
            this.lbl_TT = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // chk_show
            // 
            resources.ApplyResources(this.chk_show, "chk_show");
            this.chk_show.Name = "chk_show";
            this.chk_show.UseVisualStyleBackColor = true;
            // 
            // lbl_TTlogin
            // 
            resources.ApplyResources(this.lbl_TTlogin, "lbl_TTlogin");
            this.lbl_TTlogin.ForeColor = System.Drawing.Color.Red;
            this.lbl_TTlogin.Name = "lbl_TTlogin";
            // 
            // btn_Cancel
            // 
            resources.ApplyResources(this.btn_Cancel, "btn_Cancel");
            this.btn_Cancel.ForeColor = System.Drawing.Color.Red;
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            // 
            // btn_Log
            // 
            resources.ApplyResources(this.btn_Log, "btn_Log");
            this.btn_Log.ForeColor = System.Drawing.Color.Red;
            this.btn_Log.Name = "btn_Log";
            this.btn_Log.UseVisualStyleBackColor = true;
            this.btn_Log.Click += new System.EventHandler(this.btn_Log_Click);
            // 
            // txt_pass
            // 
            resources.ApplyResources(this.txt_pass, "txt_pass");
            this.txt_pass.Name = "txt_pass";
            // 
            // txt_user
            // 
            resources.ApplyResources(this.txt_user, "txt_user");
            this.txt_user.Name = "txt_user";
            // 
            // lbl_pass
            // 
            resources.ApplyResources(this.lbl_pass, "lbl_pass");
            this.lbl_pass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.lbl_pass.Name = "lbl_pass";
            // 
            // lbl_User
            // 
            resources.ApplyResources(this.lbl_User, "lbl_User");
            this.lbl_User.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.lbl_User.Name = "lbl_User";
            // 
            // lbl_TT
            // 
            resources.ApplyResources(this.lbl_TT, "lbl_TT");
            this.lbl_TT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.lbl_TT.ForeColor = System.Drawing.Color.Red;
            this.lbl_TT.Name = "lbl_TT";
            // 
            // LoginForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.None;
            this.BackgroundImageStore = global::DoAnCuoiKy.Properties.Resources.Login_Manager;
            this.Controls.Add(this.chk_show);
            this.Controls.Add(this.lbl_TTlogin);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Log);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.txt_user);
            this.Controls.Add(this.lbl_pass);
            this.Controls.Add(this.lbl_User);
            this.Controls.Add(this.lbl_TT);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "LoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chk_show;
        public System.Windows.Forms.Label lbl_TTlogin;
        public System.Windows.Forms.Button btn_Cancel;
        public System.Windows.Forms.Button btn_Log;
        public System.Windows.Forms.TextBox txt_pass;
        public System.Windows.Forms.TextBox txt_user;
        private System.Windows.Forms.Label lbl_pass;
        private System.Windows.Forms.Label lbl_User;
        private System.Windows.Forms.Label lbl_TT;
    }
}