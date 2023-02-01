namespace LukujenJarjestys
{
    partial class LukujenJarjestys
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
            this.arvo1 = new System.Windows.Forms.Label();
            this.uusiLukuTB = new System.Windows.Forms.TextBox();
            this.VastausLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // arvo1
            // 
            this.arvo1.AutoSize = true;
            this.arvo1.Location = new System.Drawing.Point(172, 164);
            this.arvo1.Name = "arvo1";
            this.arvo1.Size = new System.Drawing.Size(326, 25);
            this.arvo1.TabIndex = 0;
            this.arvo1.Text = "Anna luku(kirjoita lopetus lopettaaksesi)";
            // 
            // uusiLukuTB
            // 
            this.uusiLukuTB.Location = new System.Drawing.Point(523, 164);
            this.uusiLukuTB.Name = "uusiLukuTB";
            this.uusiLukuTB.Size = new System.Drawing.Size(150, 31);
            this.uusiLukuTB.TabIndex = 1;
            this.uusiLukuTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.uusiLukuTB_KeyPress);
            // 
            // VastausLB
            // 
            this.VastausLB.AutoSize = true;
            this.VastausLB.Location = new System.Drawing.Point(253, 234);
            this.VastausLB.Name = "VastausLB";
            this.VastausLB.Size = new System.Drawing.Size(72, 25);
            this.VastausLB.TabIndex = 2;
            this.VastausLB.Text = "Vastaus";
            this.VastausLB.Visible = false;
            // 
            // LukujenJarjestys
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1373, 798);
            this.Controls.Add(this.VastausLB);
            this.Controls.Add(this.uusiLukuTB);
            this.Controls.Add(this.arvo1);
            this.Name = "LukujenJarjestys";
            this.Text = "LukujenJärjestys";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label arvo1;
        private TextBox uusiLukuTB;
        private Label VastausLB;
    }
}