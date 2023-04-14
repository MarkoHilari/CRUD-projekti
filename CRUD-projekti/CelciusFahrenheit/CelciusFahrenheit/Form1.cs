namespace CelciusFahrenheit
{
    public partial class LaskinFM : Form
    {
        public LaskinFM()
        {
            InitializeComponent();
        }

        private void muunnaBT_Click(object sender, EventArgs e)
        {
            double vastaus;
            double asteet = Convert.ToDouble(asteTB.Text);
            if(celsiusRB.Checked)
            {
                vastaus = asteet * 1.8 + 32;
                vastausLB.Text = asteet + " Fahrenheitia on " + Math.Round(vastaus, 2) + " Celsius astetta";
                vastausLB.Visible= true;
            }
            else if (fahrenheitRB.Checked) 
            {
                vastaus = (asteet - 32) / 1.8;
                vastausLB.Text = asteet + " Celsiusta on " + Math.Round(vastaus,2) + " Fahrenheit astetta";
                vastausLB.Visible= true;
            }
            else
            {
                vastausLB.Text = " Et valinnut muunnetavaa astetta tai eit antanut oikeaa lukua";
                vastausLB.Visible= true;
            }
        }
    }
}