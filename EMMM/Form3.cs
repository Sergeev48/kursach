using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EMMM
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int num;
                if (int.TryParse(textBoxvar.Text.ToString(), out num))
                {
                    Globals.option = num;
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Неверный вариант!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } catch(Exception ex)
            {
                MessageBox.Show("Неверный вариант!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            

        }
    }
}
