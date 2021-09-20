using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClickerGame
{
    public partial class Form1 : Form
    {

        float money = 0;

        float clickMoney = 1;
        float upgradePercent = 1.05f;
        int clickUpgrade = 1;
        float price = 10;

        float lastTickMoney = 0;

        int upgradeOne, upgradeTwo, upgradeThree , upgradeFour;

        public Form1()
        {
            InitializeComponent();

            Timer tmr = new Timer();
            tmr.Interval = 10;
            tmr.Tick += tmr_Tick;
            tmr.Start();        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(money >= 10)
            {
                money -= 10;
                upgradeOne++;
                lbl_one.Text = upgradeOne.ToString() + "x";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (money >= 100)
            {
                money -= 100;
                upgradeTwo++;
                lbl_two.Text = upgradeTwo.ToString() + "x";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (money >= 500)
            {
                money -= 500;
                upgradeThree++;
                lbl_three.Text = upgradeThree.ToString() + "x";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (money >= 2000)
            {
                money -= 2000;
                upgradeFour++;
                lbl_four.Text = upgradeFour.ToString() + "x";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if(money >= price)
            {
                money -= price;
                price *= (upgradePercent * 2) - 1;

                btn_clickUpgrade.Text = "Upgrade click $" + price.ToString("F1");

                clickMoney *= upgradePercent;
                lbl_clickMultiplyer.Text = clickMoney.ToString("F1");
            }
        }

        private void lbl_perSec_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            money += clickMoney;
            lbl_clickMultiplyer.Text = clickMoney.ToString("F1");
        }

        private void tmr_Tick(object sender, EventArgs e)
        {
            

            float deltaTime = 0.01f;

            lastTickMoney = money;

            

            money += 0.1f * deltaTime * upgradeOne;

            money += 1 * deltaTime * upgradeTwo;

            money += 5 * deltaTime * upgradeThree;

            money += 25 * deltaTime * upgradeFour;


            lbl_money.Text = "$" + money.ToString("F2");

            lbl_perSec.Text = "$" + ((money - lastTickMoney) / deltaTime).ToString("F2") + "/s";
        }

        private void lbl_money_Click(object sender, EventArgs e)
        {

        }
    }
}
