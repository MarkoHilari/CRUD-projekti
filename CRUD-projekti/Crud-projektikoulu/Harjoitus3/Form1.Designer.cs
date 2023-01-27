namespace Harjoitus3
{
    partial class harjoitus3FM
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
            this.luku1TB = new System.Windows.Forms.TextBox();
            this.luku2TB = new System.Windows.Forms.TextBox();
            this.laskeCB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.laskeBT = new System.Windows.Forms.Button();
            this.vastausLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // luku1TB
            // 
            this.luku1TB.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.luku1TB.Location = new System.Drawing.Point(34, 53);
            this.luku1TB.Name = "luku1TB";
            this.luku1TB.Size = new System.Drawing.Size(156, 37);
            this.luku1TB.TabIndex = 0;
            // 
            // luku2TB
            // 
            this.luku2TB.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.luku2TB.Location = new System.Drawing.Point(308, 54);
            this.luku2TB.Name = "luku2TB";
            this.luku2TB.Size = new System.Drawing.Size(156, 37);
            this.luku2TB.TabIndex = 1;
            this.luku2TB.TextChanged += new System.EventHandler(this.luku2TB_TextChanged);
            // 
            // laskeCB
            // 
            this.laskeCB.FormattingEnabled = true;
            this.laskeCB.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.laskeCB.Location = new System.Drawing.Point(213, 54);
            this.laskeCB.Name = "laskeCB";
            this.laskeCB.Size = new System.Drawing.Size(74, 33);
            this.laskeCB.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(485, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "=";
            // 
            // laskeBT
            // 
            this.laskeBT.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.laskeBT.Location = new System.Drawing.Point(652, 43);
            this.laskeBT.Name = "laskeBT";
            this.laskeBT.Size = new System.Drawing.Size(117, 55);
            this.laskeBT.TabIndex = 4;
            this.laskeBT.Text = "Laske";
            this.laskeBT.UseVisualStyleBackColor = true;
            this.laskeBT.Click += new System.EventHandler(this.laskeBT_Click);
            // 
            // vastausLB
            // 
            this.vastausLB.AutoSize = true;
            this.vastausLB.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.vastausLB.Location = new System.Drawing.Point(560, 45);
            this.vastausLB.Name = "vastausLB";
            this.vastausLB.Size = new System.Drawing.Size(39, 45);
            this.vastausLB.TabIndex = 5;
            this.vastausLB.Text = "X";
            this.vastausLB.Visible = false;
            // 
            // harjoitus3FM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1260, 431);
            this.Controls.Add(this.vastausLB);
            this.Controls.Add(this.laskeBT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.laskeCB);
            this.Controls.Add(this.luku2TB);
            this.Controls.Add(this.luku1TB);
            this.Name = "harjoitus3FM";
            this.Text = "Harjoitus3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox luku1TB;
        private TextBox luku2TB;
        private ComboBox laskeCB;
        private Label label1;
        private Button laskeBT;
        public Label vastausLB;
    }
}