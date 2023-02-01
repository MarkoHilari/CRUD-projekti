namespace SalaSananTarkistus
{
    public partial class SalasanaForm : Form
    {
        public SalasanaForm()
        {
            InitializeComponent();
        }

        private void TarkistaBT_Click(object sender, EventArgs e)
        {
            if(KayttajaTB.Text =="MarkoH" && SalasanaTB.Text == "H1lar1")
            {
                SalasanaPanel.Visible = false;
                SalasanaOikeinPanel.Visible = true;
            }
            else
            {
                VirheviestiLB.Visible = true;
                
            }
        }

        private void SalasanaTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void SalasanaTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                if (KayttajaTB.Text == "MarkoH" && SalasanaTB.Text == "H1lar1")
                {
                    SalasanaPanel.Visible = false;
                    SalasanaOikeinPanel.Visible = true;
                }
                else
                {
                    VirheviestiLB.Visible = true;

                }
            }
        }

        private void chkBX_CheckedChanged(object sender, EventArgs e)
        {
            if(chkBX.Checked)
            {
                SalasanaTB.UseSystemPasswordChar = false;
                var checkBox = (CheckBox)sender;
                checkBox.Text = "Näytä";
            }
            else
            {
                SalasanaTB.UseSystemPasswordChar = true;
                var checkBox = (CheckBox)sender;
                checkBox.Text = "Piilota";
            }
        }
    }
}