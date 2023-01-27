namespace Harjoitus3
{
    public partial class harjoitus3FM : Form
    {
        public harjoitus3FM()
        {
            InitializeComponent();
        }

        private void laskeBT_Click(object sender, EventArgs e)
        {
            double luku1 = 0;
            double luku2 = 0;
            alku:
            try
            {
                 luku1 = double.Parse(luku1TB.Text);
                 luku2 = double.Parse(luku2TB.Text);
            }
            catch (Exception ex)
            {
                //vastausLB.Text = ex.Message;
                luku2TB.Text = string.Empty;
                luku1TB.Text = string.Empty;
                luku1TB.Focus();
                goto alku;
            }
            string merkki = laskeCB.Text;
            double vastaus = 0;
            switch(merkki)
            {
                case "+":
                    vastaus = luku1 + luku2; 
                    break;
                case "-":
                    vastaus= luku1 - luku2;
                    break;
                case "*":
                    vastaus= luku1 * luku2;
                    break;
                case "/":
                    vastaus = luku1 / luku2;
                    break;
                default:
                    break;
            }
            vastausLB.Text = Convert.ToString(vastaus);
            vastausLB.Visible = true;
        }

        private void luku2TB_TextChanged(object sender, EventArgs e)
        {

        }
    }
}