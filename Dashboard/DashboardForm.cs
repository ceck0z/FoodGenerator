using System;
using System.Drawing;
using System.Windows.Forms;

namespace Dashboard
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
        }

        #region Button1 Events and Actions

        private void button1_Click(object sender, EventArgs e)
        {
            CheckBulbColor(button1, bulb1);            
        }
        private void Button1_MouseEnter(object sender, EventArgs e)
        {
            buttonMouseEnter(button1);
        }
        private void Button1_MouseHover(object sender, EventArgs e)
        {
            buttonMouseOver(button1);
        }

        private void Button1_MouseLeave(object sender, EventArgs e)
        {
            buttonMouseLeave(button1);
        }

        #endregion

        #region Button2 Events and Actions

        private void button2_Click(object sender, EventArgs e)
        {
            CheckBulbColor(button2, bulb2);
        }

        private void Button2_MouseEnter(object sender, EventArgs e)
        {
            buttonMouseEnter(button2);
        }
        private void Button2_MouseHover(object sender, EventArgs e)
        {
            buttonMouseOver(button2);
        }

        private void Button2_MouseLeave(object sender, EventArgs e)
        {
            buttonMouseLeave(button2);
        }
        #endregion

        #region Button3 Events and Actions

        private void button3_Click(object sender, EventArgs e)
        {
            CheckBulbColor(button3, bulb3);
        }

        private void Button3_MouseEnter(object sender, EventArgs e)
        {
            buttonMouseEnter(button3);
        }
        private void Button3_MouseHover(object sender, EventArgs e)
        {
            buttonMouseOver(button3);
        }

        private void Button3_MouseLeave(object sender, EventArgs e)
        {
            buttonMouseLeave(button3);
        }

        #endregion

        #region Button4 Events and Actions

        private void button4_Click(object sender, EventArgs e)
        {
            CheckBulbColor(button4, bulb4);
        }

        private void Button4_MouseEnter(object sender, EventArgs e)
        {
            buttonMouseEnter(button4);
        }
        private void Button4_MouseHover(object sender, EventArgs e)
        {
            buttonMouseOver(button4);
        }

        private void Button4_MouseLeave(object sender, EventArgs e)
        {
            buttonMouseLeave(button4);
        }
        #endregion

        #region Button5 Events and Actions
        private void button5_Click(object sender, EventArgs e)
        {
            CheckBulbColor(button5, bulb5);
        }
        private void Button5_MouseEnter(object sender, EventArgs e)
        {
            buttonMouseEnter(button5);
        }
        private void Button5_MouseHover(object sender, EventArgs e)
        {
            buttonMouseOver(button5);
        }

        private void Button5_MouseLeave(object sender, EventArgs e)
        {
            buttonMouseLeave(button5);
        }

        #endregion

        #region Button6 Events and Actions
        private void button6_Click(object sender, EventArgs e)
        {
            CheckBulbColor(button6, bulb6);
        }

        private void Button6_MouseEnter(object sender, EventArgs e)
        {
            buttonMouseEnter(button6);
        }
        private void Button6_MouseHover(object sender, EventArgs e)
        {
            buttonMouseOver(button6);
        }

        private void Button6_MouseLeave(object sender, EventArgs e)
        {
            buttonMouseLeave(button6);
        }

        #endregion

        #region Button7 Events and Actions
        private void button7_Click(object sender, EventArgs e)
        {
            CheckBulbColor(button7, bulb7);
        }
        private void Button7_MouseEnter(object sender, EventArgs e)
        {
            buttonMouseEnter(button7);
        }
        private void Button7_MouseHover(object sender, EventArgs e)
        {
            buttonMouseOver(button7);
        }

        private void Button7_MouseLeave(object sender, EventArgs e)
        {
            buttonMouseLeave(button7);
        }

        #endregion

        #region Button8 Events and Actions

        private void button8_Click(object sender, EventArgs e)
        {
            CheckBulbColor(button8, bulb8);
        }

        private void Button8_MouseEnter(object sender, EventArgs e)
        {
            buttonMouseEnter(button8);
        }
        private void Button8_MouseHover(object sender, EventArgs e)
        {
            buttonMouseOver(button8);
        }

        private void Button8_MouseLeave(object sender, EventArgs e)
        {
            buttonMouseLeave(button8);
        }

        #endregion

        #region Button9 Events and Actions
        private void button9_Click(object sender, EventArgs e)
        {
            CheckBulbColor(button9, bulb9);
        }
        private void Button9_MouseEnter(object sender, EventArgs e)
        {
            buttonMouseEnter(button9);
        }
        private void Button9_MouseHover(object sender, EventArgs e)
        {
            buttonMouseOver(button9);
        }

        private void Button9_MouseLeave(object sender, EventArgs e)
        {
            buttonMouseLeave(button9);
        }

        #endregion

        private void CheckBulbColor(Button buttonName, Panel bulbName)
        {
            if (bulbName.BackColor != Color.Yellow)
            {
                bulbName.BackColor = Color.Yellow;
            }
            else
            {
                bulbName.BackColor = Color.FromArgb(51, 67, 92);
            }
        }

        private void buttonMouseOver(Button buttonName)
        {
            buttonName.BackColor = Color.FromArgb(14, 237, 204);
        }

        private void buttonMouseLeave(Button buttonName)
        {
            buttonName.BackColor = Color.FromArgb(70, 132, 227);
        }

        private void buttonMouseEnter(Button buttonName)
        {
            buttonName.BackColor = Color.FromArgb(14, 237, 204);
        }
    }
}
