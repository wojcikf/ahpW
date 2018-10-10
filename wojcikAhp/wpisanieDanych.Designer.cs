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
            this.button1 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // zapiszKryteria
            // 
            this.zapiszKryteria.Location = new System.Drawing.Point(462, 289);
            this.zapiszKryteria.Name = "zapiszKryteria";
            this.zapiszKryteria.Size = new System.Drawing.Size(75, 23);
            this.zapiszKryteria.TabIndex = 0;
            this.zapiszKryteria.Text = "Zapisz";
            this.zapiszKryteria.UseVisualStyleBackColor = true;
            this.zapiszKryteria.Click += new System.EventHandler(this.zapiszKryteria_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(436, 260);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Dodaj kryterium";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(436, 13);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(121, 97);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // wpisanieDanych
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 324);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.zapiszKryteria);
            this.Name = "wpisanieDanych";
            this.Text = "wpisanieDanych";
            this.Load += new System.EventHandler(this.wpisanieDanych_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button zapiszKryteria;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView listView1;
    }
}