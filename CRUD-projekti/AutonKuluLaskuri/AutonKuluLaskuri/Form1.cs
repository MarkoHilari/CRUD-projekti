namespace AutonKuluLaskuri
{
    public partial class autoKululaskinFM : Form
    {
        public autoKululaskinFM()
        {
            InitializeComponent();
        }
        double laina, neste, vakuutus, muut, polttoaine, pesu, huolto, renkaat, kilometrit, yhteensa;
        private void kilometritCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            alku:
            try
            {
                laina = Convert.ToDouble(lainaTB.Text);
                neste = Convert.ToDouble(nesteTB.Text);
                vakuutus = Convert.ToDouble(vakuutusTB.Text);
                muut = Convert.ToDouble(muutTB.Text);
                polttoaine = Convert.ToDouble(polttoaineTB.Text);
                pesu = Convert.ToDouble(pesuTB.Text);
                huolto = Convert.ToDouble(huoltoTB.Text);
                renkaat = Convert.ToDouble(renkaatTB.Text);
                kilometrit = Convert.ToDouble(kilometritCB.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Kaikki kentät täytettävä");
                //goto alku;
            }
            yhteensa = (laina + neste + vakuutus + muut + polttoaine + pesu + huolto + renkaat) / (kilometrit / 12);
            vastausLB.Text = "Kustannukset ovat kilometriä kohden: " + yhteensa + "€";
            vastausLB.Visible= true;
        }

        private void tyhjaaBT_Click(object sender, EventArgs e)
        {
            lainaTB.Text = "";
            nesteTB.Text = "";
            vakuutusTB.Text = "";
            muutTB.Text = "";
            polttoaineTB.Text = "";
            pesuTB.Text = "";
            huoltoTB.Text = "";
            renkaatTB.Text = "";
            kilometritCB.Text = "";
            vastausLB.Text = "";
        }
    }
}