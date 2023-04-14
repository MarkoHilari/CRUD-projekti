namespace BMI_Laskuri
{
    partial class bmiFM
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bmiFM));
            this.painoLB = new System.Windows.Forms.Label();
            this.pituusLB = new System.Windows.Forms.Label();
            this.painoTB = new System.Windows.Forms.TextBox();
            this.pituusTB = new System.Windows.Forms.TextBox();
            this.indexBT = new System.Windows.Forms.Button();
            this.bmiLB = new System.Windows.Forms.Label();
            this.kuvausLB = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // painoLB
            // 
            this.painoLB.AutoSize = true;
            this.painoLB.BackColor = System.Drawing.Color.SeaShell;
            this.painoLB.Font = new System.Drawing.Font("Copperplate Gothic Light", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.painoLB.Location = new System.Drawing.Point(34, 117);
            this.painoLB.Name = "painoLB";
            this.painoLB.Size = new System.Drawing.Size(497, 38);
            this.painoLB.TabIndex = 0;
            this.painoLB.Text = "Anna painosi(tai kaverin):";
            // 
            // pituusLB
            // 
            this.pituusLB.AutoSize = true;
            this.pituusLB.BackColor = System.Drawing.Color.SeaShell;
            this.pituusLB.Font = new System.Drawing.Font("Copperplate Gothic Light", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.pituusLB.Location = new System.Drawing.Point(275, 190);
            this.pituusLB.Name = "pituusLB";
            this.pituusLB.Size = new System.Drawing.Size(256, 38);
            this.pituusLB.TabIndex = 1;
            this.pituusLB.Text = "Anna pituus:";
            // 
            // painoTB
            // 
            this.painoTB.BackColor = System.Drawing.Color.SeaShell;
            this.painoTB.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.painoTB.Location = new System.Drawing.Point(606, 117);
            this.painoTB.Name = "painoTB";
            this.painoTB.Size = new System.Drawing.Size(185, 45);
            this.painoTB.TabIndex = 2;
            this.painoTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pituusTB
            // 
            this.pituusTB.BackColor = System.Drawing.Color.SeaShell;
            this.pituusTB.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pituusTB.Location = new System.Drawing.Point(606, 190);
            this.pituusTB.Name = "pituusTB";
            this.pituusTB.Size = new System.Drawing.Size(185, 45);
            this.pituusTB.TabIndex = 3;
            this.pituusTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // indexBT
            // 
            this.indexBT.BackColor = System.Drawing.Color.SeaShell;
            this.indexBT.Font = new System.Drawing.Font("Segoe Script", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.indexBT.Location = new System.Drawing.Point(258, 311);
            this.indexBT.Name = "indexBT";
            this.indexBT.Size = new System.Drawing.Size(622, 65);
            this.indexBT.TabIndex = 4;
            this.indexBT.Text = "Laske painoindexi";
            this.indexBT.UseVisualStyleBackColor = false;
            this.indexBT.Click += new System.EventHandler(this.indexBT_Click);
            // 
            // bmiLB
            // 
            this.bmiLB.AutoSize = true;
            this.bmiLB.Font = new System.Drawing.Font("Segoe Print", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.bmiLB.Location = new System.Drawing.Point(261, 418);
            this.bmiLB.Name = "bmiLB";
            this.bmiLB.Size = new System.Drawing.Size(109, 56);
            this.bmiLB.TabIndex = 5;
            this.bmiLB.Text = "xxxxx";
            this.bmiLB.Visible = false;
            // 
            // kuvausLB
            // 
            this.kuvausLB.AutoSize = true;
            this.kuvausLB.Font = new System.Drawing.Font("Segoe Print", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.kuvausLB.Location = new System.Drawing.Point(261, 494);
            this.kuvausLB.Name = "kuvausLB";
            this.kuvausLB.Size = new System.Drawing.Size(109, 56);
            this.kuvausLB.TabIndex = 6;
            this.kuvausLB.Text = "xxxxx";
            this.kuvausLB.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(737, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 38);
            this.label1.TabIndex = 7;
            this.label1.Text = "cm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(744, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 38);
            this.label2.TabIndex = 8;
            this.label2.Text = "kg";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // bmiFM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1361, 899);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kuvausLB);
            this.Controls.Add(this.bmiLB);
            this.Controls.Add(this.indexBT);
            this.Controls.Add(this.pituusTB);
            this.Controls.Add(this.painoTB);
            this.Controls.Add(this.pituusLB);
            this.Controls.Add(this.painoLB);
            this.Name = "bmiFM";
            this.Text = "BMI Laskuri";
            this.Load += new System.EventHandler(this.bmiFM_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label painoLB;
        private Label pituusLB;
        private TextBox painoTB;
        private TextBox pituusTB;
        private Button indexBT;
        private Label bmiLB;
        private Label kuvausLB;
        private Label label1;
        private Label label2;
        private System.Windows.Forms.Timer timer1;
    }
}