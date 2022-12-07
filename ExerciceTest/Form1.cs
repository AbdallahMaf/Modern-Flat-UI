using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExerciceTest
{
    public partial class Form1 : Form
    {
        //Fields
        private Button currentButton;
        private Random random;
        private int tempIndex;

        //Constructor
         public Form1()
        {
            InitializeComponent();
            random = new Random(); 
        }

        private Color SelectThemeColor()
        {
             int index = random.Next(ThemeColor.ColorList.Count);
            while(tempIndex == index){
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }

        private void ActivateButton(object btnSender)
        {
            if(btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = this.buttonProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }


        }

        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = this.buttonProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }


        private void buttonProducts_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void buttonCustomers_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void buttonReporting_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void buttonNotifications_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }
    }




    

        
    
}
