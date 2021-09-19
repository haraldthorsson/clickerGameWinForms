
namespace ClickerGame
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_money = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.lbl_one = new System.Windows.Forms.Label();
            this.lbl_two = new System.Windows.Forms.Label();
            this.lbl_three = new System.Windows.Forms.Label();
            this.lbl_four = new System.Windows.Forms.Label();
            this.btn_clickUpgrade = new System.Windows.Forms.Button();
            this.lbl_clickMultiplyer = new System.Windows.Forms.Label();
            this.lbl_perSec = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(334, 365);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 73);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_money
            // 
            this.lbl_money.AutoSize = true;
            this.lbl_money.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_money.Cursor = System.Windows.Forms.Cursors.Cross;
            this.lbl_money.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_money.Location = new System.Drawing.Point(343, 321);
            this.lbl_money.Name = "lbl_money";
            this.lbl_money.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_money.Size = new System.Drawing.Size(57, 41);
            this.lbl_money.TabIndex = 1;
            this.lbl_money.Text = "$0";
            this.lbl_money.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_money.Click += new System.EventHandler(this.lbl_money_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 75);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(159, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "0.1 $/s - $10";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 104);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(159, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "1 $/s - $100";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 133);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(159, 23);
            this.button4.TabIndex = 2;
            this.button4.Text = "5 $/s - $500";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(12, 162);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(159, 23);
            this.button5.TabIndex = 2;
            this.button5.Text = "25 $/s - $2000";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // lbl_one
            // 
            this.lbl_one.AutoSize = true;
            this.lbl_one.Location = new System.Drawing.Point(177, 80);
            this.lbl_one.Name = "lbl_one";
            this.lbl_one.Size = new System.Drawing.Size(18, 13);
            this.lbl_one.TabIndex = 3;
            this.lbl_one.Text = "0x";
            // 
            // lbl_two
            // 
            this.lbl_two.AutoSize = true;
            this.lbl_two.Location = new System.Drawing.Point(177, 109);
            this.lbl_two.Name = "lbl_two";
            this.lbl_two.Size = new System.Drawing.Size(18, 13);
            this.lbl_two.TabIndex = 3;
            this.lbl_two.Text = "0x";
            // 
            // lbl_three
            // 
            this.lbl_three.AutoSize = true;
            this.lbl_three.Location = new System.Drawing.Point(177, 138);
            this.lbl_three.Name = "lbl_three";
            this.lbl_three.Size = new System.Drawing.Size(18, 13);
            this.lbl_three.TabIndex = 3;
            this.lbl_three.Text = "0x";
            // 
            // lbl_four
            // 
            this.lbl_four.AutoSize = true;
            this.lbl_four.Location = new System.Drawing.Point(177, 167);
            this.lbl_four.Name = "lbl_four";
            this.lbl_four.Size = new System.Drawing.Size(18, 13);
            this.lbl_four.TabIndex = 3;
            this.lbl_four.Text = "0x";
            // 
            // btn_clickUpgrade
            // 
            this.btn_clickUpgrade.Location = new System.Drawing.Point(151, 409);
            this.btn_clickUpgrade.Name = "btn_clickUpgrade";
            this.btn_clickUpgrade.Size = new System.Drawing.Size(151, 29);
            this.btn_clickUpgrade.TabIndex = 4;
            this.btn_clickUpgrade.Text = "Upgrade click $10";
            this.btn_clickUpgrade.UseVisualStyleBackColor = true;
            this.btn_clickUpgrade.Click += new System.EventHandler(this.button6_Click);
            // 
            // lbl_clickMultiplyer
            // 
            this.lbl_clickMultiplyer.AutoSize = true;
            this.lbl_clickMultiplyer.Location = new System.Drawing.Point(205, 393);
            this.lbl_clickMultiplyer.Name = "lbl_clickMultiplyer";
            this.lbl_clickMultiplyer.Size = new System.Drawing.Size(53, 13);
            this.lbl_clickMultiplyer.TabIndex = 5;
            this.lbl_clickMultiplyer.Text = "click = $1";
            // 
            // lbl_perSec
            // 
            this.lbl_perSec.AutoSize = true;
            this.lbl_perSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_perSec.Location = new System.Drawing.Point(365, 296);
            this.lbl_perSec.Name = "lbl_perSec";
            this.lbl_perSec.Size = new System.Drawing.Size(61, 25);
            this.lbl_perSec.TabIndex = 6;
            this.lbl_perSec.Text = "$10/s";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_perSec);
            this.Controls.Add(this.lbl_clickMultiplyer);
            this.Controls.Add(this.btn_clickUpgrade);
            this.Controls.Add(this.lbl_four);
            this.Controls.Add(this.lbl_three);
            this.Controls.Add(this.lbl_two);
            this.Controls.Add(this.lbl_one);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lbl_money);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_money;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label lbl_one;
        private System.Windows.Forms.Label lbl_two;
        private System.Windows.Forms.Label lbl_three;
        private System.Windows.Forms.Label lbl_four;
        private System.Windows.Forms.Button btn_clickUpgrade;
        private System.Windows.Forms.Label lbl_clickMultiplyer;
        private System.Windows.Forms.Label lbl_perSec;
    }
}

