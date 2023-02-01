namespace Crud_projektikoulu
{
    public partial class Harjoitus : Form
    {
        public Harjoitus()
        {
            InitializeComponent();
        }

        private void VaihdaBT_Click(object sender, EventArgs e)
        {
            if(OtsikkoLB.Text == "Otsikko")
            {
                OtsikkoLB.Text = "Heippa maailma";
            }
            else
            {
                OtsikkoLB.Text = "Otsikko  ";
            }
                       
        }
    }
}