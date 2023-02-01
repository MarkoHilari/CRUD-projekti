namespace LukujenJarjestys
{
    public partial class LukujenJarjestys : Form
    {
        List<int> jono = new List<int>();
        public LukujenJarjestys()
        {
            InitializeComponent();
        }

        private void uusiLukuTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                if(uusiLukuTB.Text == "lopetus")
                {
                    VastausLB.Text = "";
                    int[] taulukko = jono.ToArray();
                    Array.Sort(taulukko);
                    foreach(var arvo in taulukko)
                    {
                        VastausLB.Text += arvo + " ";
                    }
                    VastausLB.Visible = true;
                }
                else
                {
                    jono.Add(Int32.Parse(uusiLukuTB.Text));
                    uusiLukuTB.Text = "";
                }
            }
            if(e.KeyChar == (char)Keys.Escape) 
            {
                TyhjaaLomake();
            }
        }
        private void TyhjaaLomake()
        {
            uusiLukuTB.Text = "";
        }
    }
}