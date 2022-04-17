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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void passwordButton_Click(object sender, EventArgs e)
        {
            if (passwordField.Text == "1")
            {
                Globals.adminFlag = true;
                this.Close();
            }
            else
            {
                Globals.adminFlag = false;
                MessageBox.Show("Неверный пароль!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
    }
}
