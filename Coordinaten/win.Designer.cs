namespace Coordinaten
{
    partial class win_form
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblCoorinates = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCoorinates
            // 
            this.lblCoorinates.AutoSize = true;
            this.lblCoorinates.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblCoorinates.ForeColor = System.Drawing.Color.Black;
            this.lblCoorinates.Location = new System.Drawing.Point(114, 120);
            this.lblCoorinates.Name = "lblCoorinates";
            this.lblCoorinates.Size = new System.Drawing.Size(222, 31);
            this.lblCoorinates.TabIndex = 0;
            this.lblCoorinates.Text = "X: 1920 / Y: 1080";
            // 
            // win_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.lblCoorinates);
            this.ForeColor = System.Drawing.Color.Silver;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "win_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.Silver;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.win_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.win_form_MouseClick);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.win_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.win_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCoorinates;
    }
}

