namespace BMI_Laskuri
{
    public partial class bmiFM : Form
    {
        public bmiFM()
        {
            InitializeComponent();
        }

     

        private void indexBT_Click(object sender, EventArgs e)
        {
            double paino = 0;
            double pituus = 0;
            paino = Convert.ToDouble(painoTB.Text);
            pituus = Convert.ToDouble(pituusTB.Text);
            double bmi = Math.Round(paino / ((pituus /100)  * (pituus / 100)), 2);

            if (bmi < 0)
            {
                bmiLB.Text = "Painoindexisi on " + bmi + " Sairaalloinen alipaino";
                bmiLB.ForeColor = Color.Red;
                /*kuvausLB.Text = "alipaino";
                kuvausLB.ForeColor = Color.LightBlue;
                kuvausLB.Visible= true;*/
                bmiLB.Visible= true;
            }
            else if(bmi < 18)
            {
                bmiLB.Text = "Painoidexisi on " + bmi + " Merkittävävä alipaino";
                bmiLB.ForeColor= Color.OrangeRed;
                /*kuvausLB.Text = "Normaalipaino";
                kuvausLB.ForeColor = Color.LightGreen;
                kuvausLB.Visible= true;*/
                bmiLB.Visible= true;
            }
            else if(bmi < 19)
            {
                bmiLB.Text = "Painoindexisi on " + bmi + " Lievä alipaino";
                bmiLB.ForeColor = Color.LightSalmon;
                /*kuvausLB.Text = "Ylipaino";
                kuvausLB.ForeColor= Color.LightSalmon;
                kuvausLB.Visible= true;*/
                bmiLB.Visible= true;
            }
            else if (bmi < 25)
            {
                bmiLB.Text = "Painoindexisi on " + bmi + " Normaalipaino";
                bmiLB.ForeColor = Color.Green;
                /*kuvausLB.Text = "Ylipaino";
                kuvausLB.ForeColor= Color.LightSalmon;
                kuvausLB.Visible= true;*/
                bmiLB.Visible = true;
            }
            else if (bmi < 30)
            {
                bmiLB.Text = "Painoindexisi on " + bmi + " Lievä ylipaino";
                bmiLB.ForeColor = Color.DarkSalmon;
                /*kuvausLB.Text = "Ylipaino";
                kuvausLB.ForeColor= Color.LightSalmon;
                kuvausLB.Visible= true;*/
                bmiLB.Visible = true;
            }
            else if (bmi < 35)
            {
                bmiLB.Text = "Painoindexisi on " + bmi + " Merkittävä ylipaino";
                bmiLB.ForeColor = Color.Red;
                /*kuvausLB.Text = "Ylipaino";
                kuvausLB.ForeColor= Color.LightSalmon;
                kuvausLB.Visible= true;*/
                bmiLB.Visible = true;
            }
            else if (bmi < 40)
            {
                bmiLB.Text = "Painoindexisi on " + bmi + " Vaikea ylipaino";
                bmiLB.ForeColor = Color.DarkRed;
                /*kuvausLB.Text = "Ylipaino";
                kuvausLB.ForeColor= Color.LightSalmon;
                kuvausLB.Visible= true;*/
                bmiLB.Visible = true;
            }
            else
            {
                bmiLB.Text = "Painoindexisi on " + bmi + " Sairaalloinen ylipaino";
                bmiLB.ForeColor = Color.Red;
                /*kuvausLB.Text = "Huomattava ylipaino";
                kuvausLB.ForeColor = Color.Red;
                kuvausLB.Visible = true;*/
                bmiLB.Visible= true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random ran = new Random();
            int col1 = ran.Next(64, 192);
            int col2 = ran.Next(0, 1);
            int col3 = ran.Next(0, 1);
            //int col4 = ran.Next(0, 255);
            bmiLB.ForeColor = Color.FromArgb(col1, col2, col3);
        }

        private void bmiFM_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer1.Enabled = true;
        }
    }
}