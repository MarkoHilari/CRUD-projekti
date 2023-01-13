namespace CRUD_projekti
{
    public partial class Harjoitus1 : Form
    {
        public Harjoitus1()
        {
            InitializeComponent();
        }

        private void OtsikkoLB_Click(object sender, EventArgs e)
        {

        }

        private void VaihdaBT_Click(object sender, EventArgs e)
        {
            OtsikkoLB.Text = "Heippa maailma!";
        }
    }
}