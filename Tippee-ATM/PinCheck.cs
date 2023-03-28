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

        private void txt_pin_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyValue == (char)Keys.Enter)
            {
                var pin = txt_pin.Text;

                if(pin == "1234")
                {
                    Dashboard obj = new Dashboard();
                    obj.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Enter 1234!");
                }

            }
        }

        private void PinCheck_Load(object sender, EventArgs e)
        {
            txt_pin.Focus();
        }
    }
}
