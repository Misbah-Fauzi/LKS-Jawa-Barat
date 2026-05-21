namespace asek.Kasir
{
    partial class InputJumlah
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
            this.ini = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ini
            // 
            this.ini.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ini.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ini.Location = new System.Drawing.Point(0, 0);
            this.ini.Name = "ini";
            this.ini.Size = new System.Drawing.Size(124, 28);
            this.ini.TabIndex = 0;
            this.ini.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ini_KeyPress);
            // 
            // InputJumlah
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(124, 22);
            this.Controls.Add(this.ini);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "InputJumlah";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "InputJumlah";
            this.Load += new System.EventHandler(this.InputJumlah_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ini;
    }
}