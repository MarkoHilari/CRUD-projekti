namespace SalaSananTarkistus
{
    partial class SalasanaForm
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
            this.SalasanaPanel = new System.Windows.Forms.Panel();
            this.chkBX = new System.Windows.Forms.CheckBox();
            this.VirheviestiLB = new System.Windows.Forms.Label();
            this.TarkistaBT = new System.Windows.Forms.Button();
            this.SalasanaTB = new System.Windows.Forms.TextBox();
            this.KayttajaTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SalasanaOikeinPanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.SalasanaPanel.SuspendLayout();
            this.SalasanaOikeinPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // SalasanaPanel
            // 
            this.SalasanaPanel.BackColor = System.Drawing.Color.MidnightBlue;
            this.SalasanaPanel.Controls.Add(this.chkBX);
            this.SalasanaPanel.Controls.Add(this.VirheviestiLB);
            this.SalasanaPanel.Controls.Add(this.TarkistaBT);
            this.SalasanaPanel.Controls.Add(this.SalasanaTB);
            this.SalasanaPanel.Controls.Add(this.KayttajaTB);
            this.SalasanaPanel.Controls.Add(this.label2);
            this.SalasanaPanel.Controls.Add(this.label1);
            this.SalasanaPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SalasanaPanel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SalasanaPanel.ForeColor = System.Drawing.Color.Gold;
            this.SalasanaPanel.Location = new System.Drawing.Point(0, 0);
            this.SalasanaPanel.Name = "SalasanaPanel";
            this.SalasanaPanel.Size = new System.Drawing.Size(1404, 865);
            this.SalasanaPanel.TabIndex = 0;
            // 
            // chkBX
            // 
            this.chkBX.AutoSize = true;
            this.chkBX.Location = new System.Drawing.Point(817, 272);
            this.chkBX.Name = "chkBX";
            this.chkBX.Size = new System.Drawing.Size(138, 52);
            this.chkBX.TabIndex = 6;
            this.chkBX.Text = "Näytä";
            this.chkBX.UseVisualStyleBackColor = true;
            this.chkBX.CheckedChanged += new System.EventHandler(this.chkBX_CheckedChanged);
            // 
            // VirheviestiLB
            // 
            this.VirheviestiLB.AutoSize = true;
            this.VirheviestiLB.BackColor = System.Drawing.Color.LightBlue;
            this.VirheviestiLB.Font = new System.Drawing.Font("Harrington", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VirheviestiLB.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.VirheviestiLB.Location = new System.Drawing.Point(330, 375);
            this.VirheviestiLB.Name = "VirheviestiLB";
            this.VirheviestiLB.Size = new System.Drawing.Size(635, 37);
            this.VirheviestiLB.TabIndex = 5;
            this.VirheviestiLB.Text = "Virhe, annoit väärän käyttäjän tai salasanan";
            this.VirheviestiLB.Visible = false;
            // 
            // TarkistaBT
            // 
            this.TarkistaBT.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.TarkistaBT.Location = new System.Drawing.Point(1051, 269);
            this.TarkistaBT.Name = "TarkistaBT";
            this.TarkistaBT.Size = new System.Drawing.Size(178, 55);
            this.TarkistaBT.TabIndex = 4;
            this.TarkistaBT.Text = "Tarkista";
            this.TarkistaBT.UseVisualStyleBackColor = false;
            this.TarkistaBT.Click += new System.EventHandler(this.TarkistaBT_Click);
            // 
            // SalasanaTB
            // 
            this.SalasanaTB.Location = new System.Drawing.Point(511, 266);
            this.SalasanaTB.Name = "SalasanaTB";
            this.SalasanaTB.PasswordChar = '*';
            this.SalasanaTB.Size = new System.Drawing.Size(275, 55);
            this.SalasanaTB.TabIndex = 3;
            this.SalasanaTB.TextChanged += new System.EventHandler(this.SalasanaTB_TextChanged);
            this.SalasanaTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SalasanaTB_KeyPress);
            // 
            // KayttajaTB
            // 
            this.KayttajaTB.Location = new System.Drawing.Point(511, 182);
            this.KayttajaTB.Name = "KayttajaTB";
            this.KayttajaTB.Size = new System.Drawing.Size(275, 55);
            this.KayttajaTB.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(273, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 48);
            this.label2.TabIndex = 1;
            this.label2.Text = "Salasana:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(176, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Käyttäjätunnus:";
            // 
            // SalasanaOikeinPanel
            // 
            this.SalasanaOikeinPanel.BackColor = System.Drawing.Color.DarkRed;
            this.SalasanaOikeinPanel.Controls.Add(this.label3);
            this.SalasanaOikeinPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SalasanaOikeinPanel.Font = new System.Drawing.Font("Segoe Script", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.SalasanaOikeinPanel.ForeColor = System.Drawing.Color.Snow;
            this.SalasanaOikeinPanel.Location = new System.Drawing.Point(0, 0);
            this.SalasanaOikeinPanel.Name = "SalasanaOikeinPanel";
            this.SalasanaOikeinPanel.Size = new System.Drawing.Size(1404, 865);
            this.SalasanaOikeinPanel.TabIndex = 1;
            this.SalasanaOikeinPanel.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(241, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(883, 114);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tervetuloa sivuilleni!";
            // 
            // SalasanaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1404, 865);
            this.Controls.Add(this.SalasanaPanel);
            this.Controls.Add(this.SalasanaOikeinPanel);
            this.Name = "SalasanaForm";
            this.Text = "Salasanan tarkistus";
            this.SalasanaPanel.ResumeLayout(false);
            this.SalasanaPanel.PerformLayout();
            this.SalasanaOikeinPanel.ResumeLayout(false);
            this.SalasanaOikeinPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel SalasanaPanel;
        private Label VirheviestiLB;
        private Button TarkistaBT;
        private TextBox SalasanaTB;
        private TextBox KayttajaTB;
        private Label label2;
        private Label label1;
        private Panel SalasanaOikeinPanel;
        private Label label3;
        private CheckBox chkBX;
    }
}