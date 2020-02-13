using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.trktemp.Scroll += new System.EventHandler(this.HouseConditionsChanged);
        }

        private void label2_Click(object sender, EventArgs e)
        {
           if (lblSuggestion.Text == "Plant suggestion here")
            {
                ShowWebPage(); //plant name is optional
            }
           else
            {
                ShowWebPage(lblSuggestion.Text);
            }

           

        }

        private void trktemp_Scroll(object sender, EventArgs e)
        {
            lblTemp.Text = trktemp.Value.ToString("# °F");
        }

        private void HouseConditionsChanged(object sender, EventArgs e)
        {
            int homeTemp = trktemp.Value;
            bool southFacingWindowAvailable = chkSouthfacing.Checked;

            if( homeTemp == 50)
            {
                MessageBox.Show(text: "Your home may be too cold for most houseplants", caption: "Information");
            }

            if (homeTemp == 90)
            {
                MessageBox.Show(text: "Your home may be too warm for most houseplants", caption: "Information");
            }
            
                // call our method, using return value
                string suggestedPlant = GenerateSuggestion(homeTemp, southFacingWindowAvailable);

            lblSuggestion.Text = suggestedPlant;
        }

        private string GenerateSuggestion(int temp, bool southFacing)
        {
          if(southFacing)
            {
                if (temp > 65)
                {
                    return "Peace lily"; // warm with lights
             
                }
                else
                {
                    return "Spider plant"; // cool with light
                }

            }

            else
            {
              if (temp > 65)
                {
                    return "Dragon Tree"; //warm with low light
                }
                else
                {
                    return "ivy"; //cool with low light
                }








            }
             
            
           
        }
        private void lblTemp_Click(object sender, EventArgs e)
        {
            
        }

        private void lnkHousePlantInfo(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowWebPage(lblSuggestion.Text);
        }
        private void ShowWebPage(string plantName= null) // creating new method
        {
            string url = "https://www.houseplant411.com/";

            if (plantName != null)
            {
                // link to a specific plant should be in form " "https://www.houseplant411.com/houseplant?hbq=ivy"
                url = url + "houseplant?hpq=" + plantName;
            }

            System.Diagnostics.Process.Start(url); // for launching web brower, navigating it to the url given
        }
    }
}
