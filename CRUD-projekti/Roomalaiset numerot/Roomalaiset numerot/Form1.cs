namespace Roomalaiset_numerot
{
    public partial class RoomalainenFM : Form
    {
        public RoomalainenFM()
        {
            InitializeComponent();
        }

        private void muutaBT_Click(object sender, EventArgs e)
        {
            int luku1, luku2, luku3, luku4;
            string vastaus = "";
            if(arvoTB.Text.Length > 3 )//tuhatlukua k�sitell��n
            {
                luku1 = Convert.ToInt32(arvoTB.Text.Substring(0,1));//Tuhat
                luku2 = Convert.ToInt32(arvoTB.Text.Substring(1,1));//Sata
                luku3 = Convert.ToInt32(arvoTB.Text.Substring(2,1));//Kymmenen
                luku4 = Convert.ToInt32(arvoTB.Text.Substring(3,1));//Ykk�nen
                if (luku1 % 3 == 0)
                {
                    vastaus += "MMM";
                }
                else if (luku1 % 2 == 0)
                {
                    vastaus += "MM";
                }
                else if (luku1 % 1 == 0)
                {
                    vastaus += "M";
                }
                else
                {
                    vastaus += "";
                }
                vastaus += sataset(luku2, vastaus);
                vastaus += kymmenet(luku3, vastaus);
                vastaus += ykkoset(luku4, vastaus);
            }
            else if(arvoTB.Text.Length > 2) //Satalukua k�sitell��n
            {
                luku2 = Convert.ToInt32(arvoTB.Text.Substring(0, 1));//Sadat
                luku3 = Convert.ToInt32(arvoTB.Text.Substring(1,1));//Kymmenet
                luku4 = Convert.ToInt32(arvoTB.Text.Substring(2, 1));//Ykkoset
                vastaus += sataset(luku2, vastaus);
                vastaus += kymmenet(luku3, vastaus);
                vastaus += ykkoset(luku4, vastaus);
            }
            else if(arvoTB.Text.Length >1)
            {
                luku3 = Convert.ToInt32(arvoTB.Text.Substring(0,1));
                luku4 = Convert.ToInt32(arvoTB.Text.Substring(1,1));
                vastaus += kymmenet(luku3, vastaus);
                vastaus += ykkoset(luku4, vastaus);
            }
            else if(arvoTB.Text.Length > 0)
            {
                luku4 = Convert.ToInt32(arvoTB.Text.Substring(0,1));
                vastaus += ykkoset(luku4 + vastaus);
            }
            vastausLB.Text = vastaus;
            vastausLB.Visible= true;
        }
        private string sataset(int luku2, string vastaus)
        {
            if(luku2 % 9 == 0 && luku2 != 0) 
            {
                return "CM";
            }
            else if(luku2 % 8 == 0 && luku2 != 0)
            {
                return "DCCC";
            }
            else if(luku2 % 7 == 0 && luku2 != 0)
            {
                return "DCC";
            }
            else if(luku2 % 6 == 0 && luku2 !=0)
            {
                return "DC";
            }
            else if(luku2 % 5 == 0 && luku2 != 0)
            {
                return "D";
            }
            else if(luku2 % 4 == 0 && luku2 != 0)
            {
                return "CD";
            }
            else if(luku2 % 3 == 0 && luku2 != 0)
            {
                return "CCC";
            }
            else if(luku2 % 2 == 0 && luku2 != 0)
            {
                return "CC";
            }
            else if(luku2 % 1 == 0 && luku2 != 0)
            {
                return "C";
            }
            else
            {
                return "";
            }
        }
        private string kymmenet(int luku3, string vastaus)
        {
            if(luku3 % 9 == 0 && luku3 != 0)
            {
                return "XC";
            }
            else if(luku3 % 8 == 0 && luku3 != 0)
            {
                return "LXXX";
            }
            else if(luku3 % 7 == 0 && luku3 != 0)
            {
                return "LXX";
            }
            else if(luku3 % 6 == 0 && luku3 != 0)
            {
                return "LX";
            }
            else if(luku3 % 5 == 0 && luku3 != 0)
            {
                return "L";
            }
            else if(luku3 % 4 == 0 && luku3 != 0)
            {
                return "XL";
            }
            else if(luku3 % 3 == 0 && luku3 != 0)
            {
                return "XXX";
            }
            else if(luku3 % 2 == 0 && luku3 != 0)
            {
                return "XX";
            }
            else if(luku3 % 1 == 0 && luku3 != 0)
            {
                return "X";
            }
            else
            {
                return "";
            }
        }
        private string ykkoset(int luku4, string vastaus)
        {
            if(luku4 % 9 == 0 && luku4 != 0)
            {
                return "IX";
            }
            else if(luku4 % 8 == 0 && luku4 != 0)
            {
                return "VIII";
            }
        }
    }
}