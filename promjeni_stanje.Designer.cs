namespace Nabava
{
    partial class promjeni_stanje
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
            this.stanje_zahtjeva = new System.Windows.Forms.ComboBox();
            this.id_za_promjenu = new System.Windows.Forms.NumericUpDown();
            this.nnnn = new System.Windows.Forms.Label();
            this.spremi_btn = new System.Windows.Forms.Button();
            this.Nazad = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.id_za_promjenu)).BeginInit();
            this.SuspendLayout();
            // 
            // stanje_zahtjeva
            // 
            this.stanje_zahtjeva.FormattingEnabled = true;
            this.stanje_zahtjeva.Location = new System.Drawing.Point(169, 61);
            this.stanje_zahtjeva.Name = "stanje_zahtjeva";
            this.stanje_zahtjeva.Size = new System.Drawing.Size(121, 24);
            this.stanje_zahtjeva.TabIndex = 0;
            // 
            // id_za_promjenu
            // 
            this.id_za_promjenu.Location = new System.Drawing.Point(169, 22);
            this.id_za_promjenu.Name = "id_za_promjenu";
            this.id_za_promjenu.Size = new System.Drawing.Size(120, 22);
            this.id_za_promjenu.TabIndex = 1;
            // 
            // nnnn
            // 
            this.nnnn.AutoSize = true;
            this.nnnn.Location = new System.Drawing.Point(65, 64);
            this.nnnn.Name = "nnnn";
            this.nnnn.Size = new System.Drawing.Size(98, 16);
            this.nnnn.TabIndex = 2;
            this.nnnn.Text = "Odaberi stanje:";
            // 
            // spremi_btn
            // 
            this.spremi_btn.Location = new System.Drawing.Point(215, 107);
            this.spremi_btn.Name = "spremi_btn";
            this.spremi_btn.Size = new System.Drawing.Size(75, 23);
            this.spremi_btn.TabIndex = 3;
            this.spremi_btn.Text = "Spremi";
            this.spremi_btn.UseVisualStyleBackColor = true;
            this.spremi_btn.Click += new System.EventHandler(this.spremi_btn_Click);
            // 
            // Nazad
            // 
            this.Nazad.Location = new System.Drawing.Point(97, 107);
            this.Nazad.Name = "Nazad";
            this.Nazad.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Nazad.Size = new System.Drawing.Size(75, 23);
            this.Nazad.TabIndex = 4;
            this.Nazad.Text = "Odustani";
            this.Nazad.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Odaberi ID za promjenu:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // promjeni_stanje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 160);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Nazad);
            this.Controls.Add(this.spremi_btn);
            this.Controls.Add(this.nnnn);
            this.Controls.Add(this.id_za_promjenu);
            this.Controls.Add(this.stanje_zahtjeva);
            this.Name = "promjeni_stanje";
            this.Text = "Promjeni stanje";
            ((System.ComponentModel.ISupportInitialize)(this.id_za_promjenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox stanje_zahtjeva;
        private System.Windows.Forms.NumericUpDown id_za_promjenu;
        private System.Windows.Forms.Label nnnn;
        private System.Windows.Forms.Button spremi_btn;
        private System.Windows.Forms.Button Nazad;
        private System.Windows.Forms.Label label2;
    }
}