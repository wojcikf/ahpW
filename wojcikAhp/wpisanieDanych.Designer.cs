namespace wojcikAhp
{
    partial class wpisanieDanych
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
            this.zapiszKryteria = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // zapiszKryteria
            // 
            this.zapiszKryteria.Location = new System.Drawing.Point(443, 51);
            this.zapiszKryteria.Name = "zapiszKryteria";
            this.zapiszKryteria.Size = new System.Drawing.Size(75, 23);
            this.zapiszKryteria.TabIndex = 0;
            this.zapiszKryteria.Text = "Zapisz";
            this.zapiszKryteria.UseVisualStyleBackColor = true;
            this.zapiszKryteria.Click += new System.EventHandler(this.zapiszKryteria_Click);
            // 
            // wpisanieDanych
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 324);
            this.Controls.Add(this.zapiszKryteria);
            this.Name = "wpisanieDanych";
            this.Text = "wpisanieDanych";
            this.Load += new System.EventHandler(this.wpisanieDanych_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button zapiszKryteria;
    }
}