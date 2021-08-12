
namespace BugTracker
{
    partial class frmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblnUser = new System.Windows.Forms.Label();
            this.lblnPass = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.btn_Login = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblnUser
            // 
            this.lblnUser.AutoSize = true;
            this.lblnUser.Location = new System.Drawing.Point(30, 55);
            this.lblnUser.Name = "lblnUser";
            this.lblnUser.Size = new System.Drawing.Size(53, 15);
            this.lblnUser.TabIndex = 0;
            this.lblnUser.Text = "Usuario :";
            this.lblnUser.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblnPass
            // 
            this.lblnPass.AutoSize = true;
            this.lblnPass.Location = new System.Drawing.Point(30, 93);
            this.lblnPass.Name = "lblnPass";
            this.lblnPass.Size = new System.Drawing.Size(73, 15);
            this.lblnPass.TabIndex = 1;
            this.lblnPass.Text = "Contraseña :";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(125, 52);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(257, 23);
            this.txtUser.TabIndex = 2;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(125, 93);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(257, 23);
            this.txtPass.TabIndex = 3;
            // 
            // btn_Login
            // 
            this.btn_Login.Location = new System.Drawing.Point(229, 141);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(110, 23);
            this.btn_Login.TabIndex = 4;
            this.btn_Login.Text = "Ingresar";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(378, 141);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(91, 23);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Salir";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 180);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.lblnPass);
            this.Controls.Add(this.lblnUser);
            this.Name = "frmLogin";
            this.Text = "frmLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnUser;
        private System.Windows.Forms.Label lblnPass;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Button btnExit;
    }
}

