namespace CelciusFahrenheit
{
    partial class LaskinFM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LaskinFM));
            this.asteLB = new System.Windows.Forms.Label();
            this.asteTB = new System.Windows.Forms.TextBox();
            this.muunninGB = new System.Windows.Forms.GroupBox();
            this.fahrenheitRB = new System.Windows.Forms.RadioButton();
            this.celsiusRB = new System.Windows.Forms.RadioButton();
            this.muunnaBT = new System.Windows.Forms.Button();
            this.vastausLB = new System.Windows.Forms.Label();
            this.muunninGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // asteLB
            // 
            this.asteLB.AutoSize = true;
            this.asteLB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.asteLB.Location = new System.Drawing.Point(181, 86);
            this.asteLB.Name = "asteLB";
            this.asteLB.Size = new System.Drawing.Size(145, 32);
            this.asteLB.TabIndex = 0;
            this.asteLB.Text = "Anna asteet:";
            // 
            // asteTB
            // 
            this.asteTB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.asteTB.Location = new System.Drawing.Point(376, 83);
            this.asteTB.Name = "asteTB";
            this.asteTB.Size = new System.Drawing.Size(150, 39);
            this.asteTB.TabIndex = 1;
            // 
            // muunninGB
            // 
            this.muunninGB.Controls.Add(this.fahrenheitRB);
            this.muunninGB.Controls.Add(this.celsiusRB);
            this.muunninGB.Location = new System.Drawing.Point(561, 28);
            this.muunninGB.Name = "muunninGB";
            this.muunninGB.Size = new System.Drawing.Size(300, 150);
            this.muunninGB.TabIndex = 2;
            this.muunninGB.TabStop = false;
            this.muunninGB.Text = "Miten muunnat?";
            // 
            // fahrenheitRB
            // 
            this.fahrenheitRB.AutoSize = true;
            this.fahrenheitRB.Location = new System.Drawing.Point(16, 85);
            this.fahrenheitRB.Name = "fahrenheitRB";
            this.fahrenheitRB.Size = new System.Drawing.Size(118, 29);
            this.fahrenheitRB.TabIndex = 1;
            this.fahrenheitRB.TabStop = true;
            this.fahrenheitRB.Text = "Fahrenheit";
            this.fahrenheitRB.UseVisualStyleBackColor = true;
            // 
            // celsiusRB
            // 
            this.celsiusRB.AutoSize = true;
            this.celsiusRB.Location = new System.Drawing.Point(16, 38);
            this.celsiusRB.Name = "celsiusRB";
            this.celsiusRB.Size = new System.Drawing.Size(91, 29);
            this.celsiusRB.TabIndex = 0;
            this.celsiusRB.TabStop = true;
            this.celsiusRB.Text = "Celsius";
            this.celsiusRB.UseVisualStyleBackColor = true;
            // 
            // muunnaBT
            // 
            this.muunnaBT.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.muunnaBT.Location = new System.Drawing.Point(932, 71);
            this.muunnaBT.Name = "muunnaBT";
            this.muunnaBT.Size = new System.Drawing.Size(139, 62);
            this.muunnaBT.TabIndex = 3;
            this.muunnaBT.Text = "Muunna";
            this.muunnaBT.UseVisualStyleBackColor = true;
            this.muunnaBT.Click += new System.EventHandler(this.muunnaBT_Click);
            // 
            // vastausLB
            // 
            this.vastausLB.AutoSize = true;
            this.vastausLB.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.vastausLB.Location = new System.Drawing.Point(304, 292);
            this.vastausLB.Name = "vastausLB";
            this.vastausLB.Size = new System.Drawing.Size(110, 45);
            this.vastausLB.TabIndex = 4;
            this.vastausLB.Text = "xxxxxx";
            this.vastausLB.Visible = false;
            // 
            // LaskinFM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1256, 895);
            this.Controls.Add(this.vastausLB);
            this.Controls.Add(this.muunnaBT);
            this.Controls.Add(this.muunninGB);
            this.Controls.Add(this.asteTB);
            this.Controls.Add(this.asteLB);
            this.Name = "LaskinFM";
            this.Text = "Muuta Celsius Fahrenheit";
            this.muunninGB.ResumeLayout(false);
            this.muunninGB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label asteLB;
        private TextBox asteTB;
        private GroupBox muunninGB;
        private RadioButton fahrenheitRB;
        private RadioButton celsiusRB;
        private Button muunnaBT;
        private Label vastausLB;
    }
}