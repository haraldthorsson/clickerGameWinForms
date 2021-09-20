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

        int upg1, upg2, upg3 , upg4;

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
                upg1++;
                lbl_one.Text = upg1.ToString() + "x";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (money >= 100)
            {
                money -= 100;
                upg2++;
                lbl_two.Text = upg2.ToString() + "x";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (money >= 500)
            {
                money -= 500;
                upg3++;
                lbl_three.Text = upg3.ToString() + "x";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (money >= 2000)
            {
                money -= 2000;
                upg4++;
                lbl_four.Text = upg4.ToString() + "x";
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

            

            money += 0.1f * deltaTime * upg1;

            money += 1 * deltaTime * upg2;

            money += 5 * deltaTime * upg3;

            money += 25 * deltaTime * upg4;


            lbl_money.Text = "$" + money.ToString("F2");

            lbl_perSec.Text = "$" + ((money - lastTickMoney) / deltaTime).ToString("F2") + "/s";
        }

        private void lbl_money_Click(object sender, EventArgs e)
        {

        }
    }
}
