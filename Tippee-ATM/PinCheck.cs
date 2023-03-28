using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tippee_ATM
{
    public partial class PinCheck : Form
    {
        public PinCheck()
        {
            InitializeComponent();
        }

        private void PinCheck_Load(object sender, EventArgs e)
        {
            txt_pin.Focus();
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            String digits = txt_pin.Text.ToString();

            digits = digits + '1';

            txt_pin.Text = digits;
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            String digits = txt_pin.Text.ToString();

            digits = digits + '2';

            txt_pin.Text = digits;
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            String digits = txt_pin.Text.ToString();

            digits = digits + '3';

            txt_pin.Text = digits;
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            String digits = txt_pin.Text.ToString();

            digits = digits + '4';

            txt_pin.Text = digits;
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            String digits = txt_pin.Text.ToString();

            digits = digits + '5';

            txt_pin.Text = digits;
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            String digits = txt_pin.Text.ToString();

            digits = digits + '6';

            txt_pin.Text = digits;
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            String digits = txt_pin.Text.ToString();

            digits = digits + '7';

            txt_pin.Text = digits;
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            String digits = txt_pin.Text.ToString();

            digits = digits + '8';

            txt_pin.Text = digits;
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            String digits = txt_pin.Text.ToString();

            digits = digits + '9';

            txt_pin.Text = digits;
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            String digits = txt_pin.Text.ToString();

            digits = digits + '0';

            txt_pin.Text = digits;
        }

        private void btn_dot_Click(object sender, EventArgs e)
        {
            String digits = txt_pin.Text.ToString();

            digits = digits + '.';

            txt_pin.Text = digits;
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            String digits = txt_pin.Text.ToString();

            digits = digits.Remove(digits.Length - 1);

            txt_pin.Text = digits;
        }

        private void txt_pin_TextChanged(object sender, EventArgs e)
        {
            if (txt_pin.Text.Length == 4)
            {
                var pin = txt_pin.Text;

                if (pin == "1234")
                {
                    Dashboard obj = new Dashboard();
                    obj.Show();
                    this.Close();
                }
                else
                {
                    txt_pin.Clear();
                }
            }
        }
    }
}
