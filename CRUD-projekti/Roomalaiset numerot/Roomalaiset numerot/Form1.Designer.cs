namespace Roomalaiset_numerot
{
    partial class RoomalainenFM
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.numeroTB = new System.Windows.Forms.TextBox();
            this.arvoTB = new System.Windows.Forms.TextBox();
            this.vastausLB = new System.Windows.Forms.Label();
            this.muutaBT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Papyrus", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(226, 56);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1015, 64);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Roomalaiset numerot";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numeroTB
            // 
            this.numeroTB.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.numeroTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numeroTB.Font = new System.Drawing.Font("Papyrus", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.numeroTB.Location = new System.Drawing.Point(90, 174);
            this.numeroTB.Name = "numeroTB";
            this.numeroTB.Size = new System.Drawing.Size(523, 42);
            this.numeroTB.TabIndex = 1;
            this.numeroTB.Text = "Anna numero niin muutan sen roomalaiseksi";
            this.numeroTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // arvoTB
            // 
            this.arvoTB.BackColor = System.Drawing.SystemColors.MenuBar;
            this.arvoTB.Location = new System.Drawing.Point(717, 176);
            this.arvoTB.Name = "arvoTB";
            this.arvoTB.Size = new System.Drawing.Size(150, 31);
            this.arvoTB.TabIndex = 2;
            // 
            // vastausLB
            // 
            this.vastausLB.AutoSize = true;
            this.vastausLB.Font = new System.Drawing.Font("Gentium Book Basic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.vastausLB.Location = new System.Drawing.Point(160, 336);
            this.vastausLB.Name = "vastausLB";
            this.vastausLB.Size = new System.Drawing.Size(108, 41);
            this.vastausLB.TabIndex = 3;
            this.vastausLB.Text = "xxxxx";
            this.vastausLB.Visible = false;
            // 
            // muutaBT
            // 
            this.muutaBT.Location = new System.Drawing.Point(749, 348);
            this.muutaBT.Name = "muutaBT";
            this.muutaBT.Size = new System.Drawing.Size(112, 34);
            this.muutaBT.TabIndex = 4;
            this.muutaBT.Text = "Muunna";
            this.muutaBT.UseVisualStyleBackColor = true;
            this.muutaBT.Click += new System.EventHandler(this.muutaBT_Click);
            // 
            // RoomalainenFM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1377, 887);
            this.Controls.Add(this.muutaBT);
            this.Controls.Add(this.vastausLB);
            this.Controls.Add(this.arvoTB);
            this.Controls.Add(this.numeroTB);
            this.Controls.Add(this.textBox1);
            this.Name = "RoomalainenFM";
            this.Text = "Roomalaiset numerot";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox1;
        private TextBox numeroTB;
        private TextBox arvoTB;
        private Label vastausLB;
        private Button muutaBT;
    }
}