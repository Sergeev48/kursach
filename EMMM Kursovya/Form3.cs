using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EMMM_Kursovya
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num;
            if(int.TryParse(textBoxvar.Text.ToString(), out num))
            {
                Globals.option = num;
                this.Hide();
            }
            else
            {

            }

        }
    }
}
