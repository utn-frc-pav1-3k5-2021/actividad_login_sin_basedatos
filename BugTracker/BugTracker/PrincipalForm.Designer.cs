
namespace BugTracker
{
    partial class PrincipalForm
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
            this.lblBienvenido = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblBienvenido
            // 
            this.lblBienvenido.AutoSize = true;
            this.lblBienvenido.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblBienvenido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblBienvenido.Location = new System.Drawing.Point(119, 89);
            this.lblBienvenido.Name = "lblBienvenido";
            this.lblBienvenido.Size = new System.Drawing.Size(62, 30);
            this.lblBienvenido.TabIndex = 0;
            this.lblBienvenido.Text = "Hola!";
            this.lblBienvenido.Visible = false;
            // 
            // PrincipalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 234);
            this.Controls.Add(this.lblBienvenido);
            this.MaximumSize = new System.Drawing.Size(479, 273);
            this.MinimumSize = new System.Drawing.Size(479, 273);
            this.Name = "PrincipalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.PrincipalForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBienvenido;
    }
}