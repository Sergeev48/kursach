using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Windows;
using System.Diagnostics;

namespace EMMM
{

    public partial class Form1 : Form
    {
        private Form2 newForm;
        private Form3 newForm2;

        public Form1()
        {
            InitializeComponent();

            // load tables
            setUpTables();

            //testValues();

        }

        private void setUpTables()
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            tabControl1.Visible = false;

            TableOne.Height = 9 * 33 - 8;
            TableOne.AllowUserToResizeRows = false;
            TableOne.AllowUserToResizeColumns = false;
            TableOne.Width = 100;
            for (int i = 1; i < 9; i++)
            {
                TableOne.Rows.Add(Convert.ToString(i));
                TableOne.Rows[i - 1].Cells[1].ReadOnly = false;
            }
            foreach (DataGridViewColumn column in TableOne.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            TableTwo.Height = 9 * 33 - 8;
            TableTwo.AllowUserToResizeRows = false;
            TableTwo.AllowUserToResizeColumns = false;
            TableTwo.Width = 450;
            for (int i = 1; i < 9; i++)
            {
                TableTwo.Rows.Add(Convert.ToString(i));
                TableTwo.Rows[i - 1].Cells[1].ReadOnly = false;
                if (i >= 3)
                {
                    TableTwo.Rows[i - 1].Cells[11 - i].Value = " — ";
                    TableTwo.Rows[i - 1].Cells[11 - i].ReadOnly = true;
                }
                if (i >= 4)
                {
                    TableTwo.Rows[i - 1].Cells[12 - i].Value = " — ";
                    TableTwo.Rows[i - 1].Cells[12 - i].ReadOnly = true;

                }
                if (i >= 5)
                {
                    TableTwo.Rows[i - 1].Cells[13 - i].Value = " — ";
                    TableTwo.Rows[i - 1].Cells[13 - i].ReadOnly = true;

                }
                if (i >= 6)
                {
                    TableTwo.Rows[i - 1].Cells[14 - i].Value = " — ";
                    TableTwo.Rows[i - 1].Cells[14 - i].ReadOnly = true;

                }
                if (i >= 7)
                {
                    TableTwo.Rows[i - 1].Cells[15 - i].Value = " — ";
                    TableTwo.Rows[i - 1].Cells[15 - i].ReadOnly = true;

                }
                if (i >= 8)
                {
                    TableTwo.Rows[i - 1].Cells[16 - i].Value = " — ";
                    TableTwo.Rows[i - 1].Cells[16 - i].ReadOnly = true;

                }
            }
            foreach (DataGridViewColumn column in TableTwo.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            TableThree.Height = 9 * 33 - 8;
            TableThree.AllowUserToResizeRows = false;
            TableThree.AllowUserToResizeColumns = false;
            TableThree.Width = 500;
            for (int i = 1; i < 9; i++)
            {
                TableThree.Rows.Add(Convert.ToString(i));
                TableThree.Rows[i - 1].Cells[8].ReadOnly = false;

                if (i >= 2)
                {
                    TableThree.Rows[i - 1].Cells[11 - i].Value = " — ";
                    TableThree.Rows[i - 1].Cells[11 - i].ReadOnly = true;
                }
                if (i >= 3)
                {
                    TableThree.Rows[i - 1].Cells[12 - i].Value = " — ";
                    TableThree.Rows[i - 1].Cells[12 - i].ReadOnly = true;
                }
                if (i >= 4)
                {
                    TableThree.Rows[i - 1].Cells[13 - i].Value = " — ";
                    TableThree.Rows[i - 1].Cells[13 - i].ReadOnly = true;

                }
                if (i >= 5)
                {
                    TableThree.Rows[i - 1].Cells[14 - i].Value = " — ";
                    TableThree.Rows[i - 1].Cells[14 - i].ReadOnly = true;

                }
                if (i >= 6)
                {
                    TableThree.Rows[i - 1].Cells[15 - i].Value = " — ";
                    TableThree.Rows[i - 1].Cells[15 - i].ReadOnly = true;

                }
                if (i >= 7)
                {
                    TableThree.Rows[i - 1].Cells[16 - i].Value = " — ";
                    TableThree.Rows[i - 1].Cells[16 - i].ReadOnly = true;

                }
                if (i >= 8)
                {
                    TableThree.Rows[i - 1].Cells[17 - i].Value = " — ";
                    TableThree.Rows[i - 1].Cells[17 - i].ReadOnly = true;

                }
            }
            TableThree.Rows[0].Cells[1].Value = " — ";
            TableThree.Rows[0].Cells[1].ReadOnly = true;
            foreach (DataGridViewColumn column in TableThree.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }


            TableFour.Height = 9 * 33 - 8;
            TableFour.AllowUserToResizeRows = false;
            TableFour.AllowUserToResizeColumns = false;
            TableFour.Width = 100;
            for (int i = 1; i < 9; i++)
            {
                TableFour.Rows.Add(Convert.ToString(i));
                TableFour.Rows[i - 1].Cells[1].ReadOnly = false;
            }
            foreach (DataGridViewColumn column in TableFour.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            TableP3.Height = 10 * 33 - 8;
            TableP3.AllowUserToResizeRows = false;
            TableP3.AllowUserToResizeColumns = false;
            TableP3.Width = 150;
            for (int i = 2; i < 11; i++)
            {
                TableP3.Rows.Add(Convert.ToString(i));
                TableP3.Rows[i - 2].Cells[1].ReadOnly = false;

            }
            foreach (DataGridViewColumn column in TableP3.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            TableP2.Height = 9 * 33 - 8;
            TableP2.AllowUserToResizeRows = false;
            TableP2.AllowUserToResizeColumns = false;
            TableP2.Width = 150;
            for (int i = 4; i < 12; i++)
            {
                TableP2.Rows.Add(Convert.ToString(i));
                TableP2.Rows[i - 4].Cells[1].ReadOnly = false;
            }
            foreach (DataGridViewColumn column in TableP2.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            TableP1.Height = 2 * 33 - 8;
            TableP1.AllowUserToResizeRows = false;
            TableP1.AllowUserToResizeColumns = false;
            TableP1.Width = 150;
            TableP1.Rows.Add(Convert.ToString(12));
            TableP1.Rows[0].Cells[1].ReadOnly = false;
            foreach (DataGridViewColumn column in TableP1.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            TableHelp3.Height = 5 * 33 - 8;
            TableHelp3.AllowUserToResizeRows = false;
            TableHelp3.AllowUserToResizeColumns = false;
            TableHelp3.Width = 400;
            foreach (DataGridViewColumn column in TableHelp3.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            TableHelp2.Height = 5 * 33 - 8;
            TableHelp2.AllowUserToResizeRows = false;
            TableHelp2.AllowUserToResizeColumns = false;
            TableHelp2.Width = 400;
            foreach (DataGridViewColumn column in TableHelp2.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            TableHelp1.Height = 8 * 33 - 8;
            TableHelp1.AllowUserToResizeRows = false;
            TableHelp1.AllowUserToResizeColumns = false;
            TableHelp1.Width = 400;
            foreach (DataGridViewColumn column in TableHelp1.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            TableX.Height = 2 * 33 - 8;
            TableX.AllowUserToResizeRows = false;
            TableX.AllowUserToResizeColumns = false;
            TableX.Width = 400;
            TableX.Rows.Add(Convert.ToString(12));
            TableX.Rows[0].Cells[1].ReadOnly = false;
            foreach (DataGridViewColumn column in TableX.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }
        // exit btn
        private void test3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //restart btn
        private void test2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TableOne.Rows.Clear();
            TableTwo.Rows.Clear();
            TableThree.Rows.Clear();
            TableFour.Rows.Clear();

            TableHelp1.Rows.Clear();
            TableHelp2.Rows.Clear();
            TableHelp3.Rows.Clear();
            TableP1.Rows.Clear();
            TableP2.Rows.Clear();
            TableP3.Rows.Clear();
            TableX.Rows.Clear();
            setUpTables();

            tabControl1.Visible = false;

        }

        // calculate method
        private int[] calculate(int[] tableOne, int[,] tableTwo, int[,] tableThree)
        {
            int k1 = 12, x1 = 0, k2 = 0, x2 = 0, k3 = 0, x3 = 0, x4 = 0, p1 = tableOne[2];
            x1 = tableOne[1];
            k2 = k1 - x1;
            for (int i = 0; i < 8; i++)
            {
                if (tableTwo[i, 0] == k2)
                {
                    x2 = tableTwo[i, 1];
                }
            }

            k3 = k2 - x2;
            for (int i = 0; i < 9; i++)
            {
                if (tableThree[i, 0] == k3)
                {
                    x3 = tableThree[i, 1];
                }
            }

            x4 = k3 - x3;
            int[] result = new int[6];
            result[0] = x1;
            result[1] = k2;
            result[2] = x2;
            result[3] = k3;
            result[4] = x3;
            result[5] = x4;
            return result;

            //Console.WriteLine("Ответ: P1 (12) = " + p1 + " при x1 = " + x1 + ", x2 = " + x2 + ", x3 = " + x3 + ", x4 = " + x4);
        }

        // calculate btn
        private void buttonCalc_Click(object sender, EventArgs e)
        {
            bool calcFlag = true;
            int[] f1 = new int[8];
            for (int i = 0; i < 8; i++)
            {
                if (TableOne.Rows[i].Cells[1].Value == null)
                {
                    TableOne.Rows[i].Cells[1].Style.BackColor = Color.LightPink;
                    calcFlag = false;
                }
                else
                {
                    TableOne.Rows[i].Cells[1].Style.BackColor = Color.White;
                    f1[i] = Convert.ToInt32(TableOne.Rows[i].Cells[1].Value);
                }

            }
            int[,] f2 = new int[8, 8];
            for (int j = 1; j < 9; j++)
            {
                for (int i = 0; i < 8; i++)
                {
                    if (TableTwo.Rows[i].Cells[j].Value == null)
                    {
                        TableTwo.Rows[i].Cells[j].Style.BackColor = Color.LightPink;
                        calcFlag = false;
                    }
                    else
                    {
                        TableTwo.Rows[i].Cells[j].Style.BackColor = Color.White;
                        if (!(TableTwo.Rows[i].Cells[j].Value.ToString().Trim() == "—"))
                        {
                            if (!(TableTwo.Rows[i].Cells[j].Value.ToString().Trim() == "-"))
                            {
                                f2[i, j - 1] = Convert.ToInt32(TableTwo.Rows[i].Cells[j].Value);
                            }
                        }
                    }

                }
            }
            int[,] f3 = new int[8, 9];
            for (int j = 1; j < 10; j++)
            {
                for (int i = 0; i < 8; i++)
                {
                    if (TableThree.Rows[i].Cells[j].Value == null)
                    {
                        TableThree.Rows[i].Cells[j].Style.BackColor = Color.LightPink;
                        calcFlag = false;
                    }
                    else
                    {
                        TableThree.Rows[i].Cells[j].Style.BackColor = Color.White;
                        if (!(TableThree.Rows[i].Cells[j].Value.ToString().Trim() == "—"))
                        {
                            if (!(TableThree.Rows[i].Cells[j].Value.ToString().Trim() == "-"))
                            {
                                f3[i, j - 1] = Convert.ToInt32(TableThree.Rows[i].Cells[j].Value);
                            }
                        }

                    }
                }

            }

            int[] f4 = new int[8];
            for (int i = 0; i < 8; i++)
            {
                if (TableFour.Rows[i].Cells[1].Value == null)
                {
                    TableFour.Rows[i].Cells[1].Style.BackColor = Color.LightPink;
                    calcFlag = false;
                }
                else
                {
                    TableFour.Rows[i].Cells[1].Style.BackColor = Color.White;
                    f4[i] = Convert.ToInt32(TableFour.Rows[i].Cells[1].Value);
                }

            }
            if (!calcFlag)
            {
                MessageBox.Show("Не все поля заполнены!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                tabControl1.Visible = true;
                // auto calculate
                if (Globals.adminFlag)
                {
                    int[,] table_P3 = p3Table(f3, f4);
                    int[] P3 = new int[9];
                    for (int i = 0; i < 9; i++)
                    {
                        P3[i] = table_P3[i, 2];
                        TableP3.Rows[i].Cells[1].Value = table_P3[i, 1];
                        TableP3.Rows[i].Cells[2].Value = table_P3[i, 2];
                    }
                    int[,] table_P2 = p2Table(f2, P3);
                    int[] P2 = new int[8];
                    for (int i = 0; i < 8; i++)
                    {
                        P2[i] = table_P2[i, 2];
                        TableP2.Rows[i].Cells[1].Value = table_P2[i, 1];
                        TableP2.Rows[i].Cells[2].Value = table_P2[i, 2];
                    }
                    int[] table_P1 = p1Table(f1, P2);
                    TableP1.Rows[0].Cells[1].Value = table_P1[1];
                    TableP1.Rows[0].Cells[2].Value = table_P1[2];
                    int[] result = calculate(table_P1, table_P2, table_P3);
                    for (int i = 1; i < 7; i++)
                    {
                        TableX.Rows[0].Cells[i].Value = result[i - 1];
                    }
                }
            }
        }

        private int[,] p3Table(int[,] f3, int[] f4)
        {
            int[] k3 = new int[9];
            int[] x3 = new int[9];
            int[] p3 = new int[9];
            for (int j = 8, k = 0; j >= 0; j--, k++)
            {
                int kTmp = 0, xTmp = 0, pTmp = 0;
                for (int i = 0; i < 8; i++)
                {
                    if (f3[i, j] != 0)
                    {
                        if (f3[i, j] + f4[k - i] > pTmp)
                        {
                            kTmp = k + 2;
                            xTmp = i + 1;
                            pTmp = f3[i, j] + f4[k - i];
                        }
                    }
                }

                k3[8 - j] = kTmp;
                x3[8 - j] = xTmp;
                p3[8 - j] = pTmp;
            }

            int[,] tableThree = new int[9, 3];
            for (int i = 0; i < 9; i++)
            {
                tableThree[i, 0] = k3[i];
                tableThree[i, 1] = x3[i];
                tableThree[i, 2] = p3[i];
            }

            return tableThree;
        }

        private int[,] p2Table(int[,] f2, int[] p3)
        {
            int[] k2 = new int[8];
            int[] x2 = new int[8];
            int[] p2 = new int[8];
            for (int j = 7, k = 1; j >= 0; j--, k++)
            {
                int kTmp = 0, xTmp = 0, pTmp = 0;
                for (int i = 0; i < 8; i++)
                {
                    if (f2[i, j] != 0)
                    {
                        if (f2[i, j] + p3[k - i] > pTmp)
                        {
                            kTmp = k + 3;
                            xTmp = i + 1;
                            pTmp = f2[i, j] + p3[k - i];
                        }
                    }
                }

                k2[7 - j] = kTmp;
                x2[7 - j] = xTmp;
                p2[7 - j] = pTmp;
            }

            int[,] tableTwo = new int[8, 3];
            for (int i = 0; i < 8; i++)
            {
                tableTwo[i, 0] = k2[i];
                tableTwo[i, 1] = x2[i];
                tableTwo[i, 2] = p2[i];
            }

            return tableTwo;
        }

        private int[] p1Table(int[] f1, int[] p2)
        {
            int size = 8;
            int k1 = 12, x1 = 0, p1 = 0;
            for (int i = 0, k = 2; i < size; i++)
            {
                if (f1[i] + p2[size - i - 1] > p1)
                {
                    x1 = i + 1;
                    p1 = f1[i] + p2[size - i - 1];
                }
            }

            int[] tableOne = new int[3];
            tableOne[0] = k1;
            tableOne[1] = x1;
            tableOne[2] = p1;

            return tableOne;
        }

        //public void testValues()
        //{
        //    string[] f_1 = { "4", "7", "9", "11", "12", "13", "14", "15" };
        //    string[,] f_2 = new string[,]
        //    {
        //        {"-", "6", "9", "12", "14", "15", "16", "17"},
        //        {"6", "12", "15", "17", "18", "19", "20", "21"},
        //        {"12", "18", "20", "21", "22", "23", "24", "-"},
        //        {"18", "23", "24", "25", "26", "27", "-", "-"},
        //        {"23", "27", "28", "29", "30", "-", "-", "-"},
        //        {"27", "30", "31", "32", "-", "-", "-", "-"},
        //        {"30", "33", "34", "-", "-", "-", "-", "-"},
        //        {"33", "35", "-", "-", "-", "-", "-", "-"}
        //    };

        //    string[,] f_3 = new string[,]
        //    {
        //        {"-", "6", "9", "11", "13", "15", "16", "17", "18"},
        //        {"7", "13", "16", "18", "20", "21", "22", "23", "-"},
        //        {"14", "20", "22", "24", "26", "27", "28", "-", "-"},
        //        {"21", "26", "28", "30", "31", "32", "-", "-", "-"},
        //        {"27", "32", "34", "35", "36", "-", "-", "-", "-"},
        //        {"33", "38", "39", "40", "-", "-", "-", "-", "-"},
        //        {"39", "43", "44", "-", "-", "-", "-", "-", "-"},
        //        {"44", "48", "-", "-", "-", "-", "-", "-", "-"}
        //    };
        //    string[] f_4 =
        //    {
        //        "8",
        //        "16",
        //        "24",
        //        "31",
        //        "37",
        //        "43",
        //        "49",
        //        "54"
        //    };
//            for (int i = 0; i< 8; i++)
//            {
//                TableOne.Rows[i].Cells[1].Value = f_1[i];
//                TableFour.Rows[i].Cells[1].Value = f_4[i];
//            }

//            for (int i = 0; i< 8; i++)
//            {
//                for (int j = 0; j< 8; j++)
//                {
//                    TableTwo.Rows[i].Cells[j + 1].Value = f_2[i, j];
//                }
//            }
//            for (int i = 0; i < 8; i++)
//{
//    for (int j = 0; j < 9; j++)
//    {
//        TableThree.Rows[i].Cells[j + 1].Value = f_3[i, j];
//    }
//}
//        }

        private void автоматическиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newForm = new Form2();
            newForm.ShowDialog();

            if (Globals.adminFlag)
            {
                MessageBox.Show("Пароль введён верно", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Неправльный пароль!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void TableP3_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                TableHelp3.Rows.Clear();
                int ki = Convert.ToInt32(TableP3.Rows[e.RowIndex].Cells[0].Value);
                if (ki == 10)
                {
                    if (TableThree.Rows[0].Cells[1].Value.ToString().Trim() == "-" || TableThree.Rows[0].Cells[1].Value.ToString().Trim() == "—")
                    {
                        for (int i = 3; i < ki; i++)
                        {

                            TableHelp3.Rows.Add(Convert.ToString(i - 1), 12 - ki, ki - i + 1);
                        }
                    }
                }
                else
                {
                    for (int i = 1; i < ki; i++)
                    {
                        TableHelp3.Rows.Add(Convert.ToString(i), 12 - ki, ki - i);
                        TableHelp3.Rows[i - 1].Cells[1].ReadOnly = false;

                    }
                }

            }
        }

        private void TableP2_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                TableHelp2.Rows.Clear();
                int ki = Convert.ToInt32(TableP2.Rows[e.RowIndex].Cells[0].Value);
                if (ki == 11)
                {
                    bool flag = true;
                    if (TableTwo.Rows[0].Cells[1].Value.ToString().Trim() == "-" || TableTwo.Rows[0].Cells[1].Value.ToString().Trim() == "—")
                    {
                        for (int i = 2; i < ki - 1; i++)
                        {
                            if (flag)
                            {
                                flag = false;
                                continue;
                            }

                            TableHelp2.Rows.Add(Convert.ToString(i - 1), 12 - ki, ki + 1 - i);
                        }
                    }
                }
                else
                {
                    for (int i = 2; i < ki; i++)
                    {
                        TableHelp2.Rows.Add(Convert.ToString(i - 1), 12 - ki, ki - i);

                    }
                }

            }
        }

        private void TableP1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                TableHelp1.Rows.Clear();
                int k1 = 12;
                for (int i = 1; i < 9; i++)
                {
                    TableHelp1.Rows.Add(Convert.ToString(i), 12 - i);
                    TableHelp1.Rows[i - 1].Cells[1].ReadOnly = false;

                }
            }
        }

        private void TableP3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                TableHelp3.Rows.Clear();
                int ki = Convert.ToInt32(TableP3.Rows[e.RowIndex].Cells[0].Value);
                if (ki == 10)
                {
                    if (TableThree.Rows[0].Cells[1].Value.ToString().Trim() == "-" || TableThree.Rows[0].Cells[1].Value.ToString().Trim() == "—")
                    {
                        for (int i = 3; i < ki; i++)
                        {

                            TableHelp3.Rows.Add(Convert.ToString(i - 1), 12 - ki, ki - i + 1);
                        }
                    }
                }
                else
                {
                    for (int i = 1; i < ki; i++)
                    {
                        TableHelp3.Rows.Add(Convert.ToString(i), 12 - ki, ki - i);
                        TableHelp3.Rows[i - 1].Cells[1].ReadOnly = false;

                    }
                }

            }
        }

        private void TableP2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                TableHelp2.Rows.Clear();
                int ki = Convert.ToInt32(TableP2.Rows[e.RowIndex].Cells[0].Value);
                if (ki == 11)
                {
                    bool flag = true;
                    if (TableTwo.Rows[0].Cells[1].Value.ToString().Trim() == "-" || TableTwo.Rows[0].Cells[1].Value.ToString().Trim() == "—")
                    {
                        for (int i = 2; i < ki - 1; i++)
                        {
                            if (flag)
                            {
                                flag = false;
                                continue;
                            }

                            TableHelp2.Rows.Add(Convert.ToString(i - 1), 12 - ki, ki + 1 - i);
                        }
                    }
                }
                else
                {
                    for (int i = 2; i < ki; i++)
                    {
                        TableHelp2.Rows.Add(Convert.ToString(i - 1), 12 - ki, ki - i);

                    }
                }

            }
        }

        private void TableP1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                TableHelp1.Rows.Clear();
                for (int i = 1; i < 9; i++)
                {
                    TableHelp1.Rows.Add(Convert.ToString(i), 12 - i);
                    TableHelp1.Rows[i - 1].Cells[1].ReadOnly = false;

                }
            }
        }
        private void TableHelp3_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            updateSumHelp3();
        }
        private void TableHelp2_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            updateSumHelp2();
        }
        private void TableHelp1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            updateSumHelp1();
        }
        private void updateSumHelp3()
        {
            int sum = 0;
            for (int i = 0; i < TableHelp3.Rows.Count; i++)
            {
                if (TableHelp3.Rows[i].Cells[4].Value != null && TableHelp3.Rows[i].Cells[3].Value != null)
                {
                    TableHelp3.Rows[i].Cells[5].Value = Convert.ToInt32(TableHelp3.Rows[i].Cells[4].Value) + Convert.ToInt32(TableHelp3.Rows[i].Cells[3].Value);
                }
            }
        }
        private void updateSumHelp2()
        {
            int sum = 0;
            for (int i = 0; i < TableHelp2.Rows.Count; i++)
            {
                if (TableHelp2.Rows[i].Cells[4].Value != null && TableHelp2.Rows[i].Cells[3].Value != null)
                {
                    TableHelp2.Rows[i].Cells[5].Value = Convert.ToInt32(TableHelp2.Rows[i].Cells[4].Value) + Convert.ToInt32(TableHelp2.Rows[i].Cells[3].Value);
                }
            }
        }
        private void updateSumHelp1()
        {
            int sum = 0;
            for (int i = 0; i < TableHelp1.Rows.Count; i++)
            {
                if (TableHelp1.Rows[i].Cells[2].Value != null && TableHelp1.Rows[i].Cells[3].Value != null)
                {
                    TableHelp1.Rows[i].Cells[4].Value = Convert.ToInt32(TableHelp1.Rows[i].Cells[2].Value) + Convert.ToInt32(TableHelp1.Rows[i].Cells[3].Value);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int[] f1 = new int[8];
            for (int i = 0; i < 8; i++)
            {
                if (TableOne.Rows[i].Cells[1].Value == null)
                {
                    TableOne.Rows[i].Cells[1].Style.BackColor = Color.LightPink;
                }
                else
                {
                    TableOne.Rows[i].Cells[1].Style.BackColor = Color.White;
                    f1[i] = Convert.ToInt32(TableOne.Rows[i].Cells[1].Value);
                }

            }
            int[,] f2 = new int[8, 8];
            for (int j = 1; j < 9; j++)
            {
                for (int i = 0; i < 8; i++)
                {
                    if (TableTwo.Rows[i].Cells[j].Value == null)
                    {
                        TableTwo.Rows[i].Cells[j].Style.BackColor = Color.LightPink;
                    }
                    else
                    {
                        TableTwo.Rows[i].Cells[j].Style.BackColor = Color.White;
                        if (!(TableTwo.Rows[i].Cells[j].Value.ToString().Trim() == "—"))
                        {
                            if (!(TableTwo.Rows[i].Cells[j].Value.ToString().Trim() == "-"))
                            {
                                f2[i, j - 1] = Convert.ToInt32(TableTwo.Rows[i].Cells[j].Value);
                            }
                        }
                    }

                }
            }
            int[,] f3 = new int[8, 9];
            for (int j = 1; j < 10; j++)
            {
                for (int i = 0; i < 8; i++)
                {
                    if (TableThree.Rows[i].Cells[j].Value == null)
                    {
                        TableThree.Rows[i].Cells[j].Style.BackColor = Color.LightPink;
                    }
                    else
                    {
                        TableThree.Rows[i].Cells[j].Style.BackColor = Color.White;
                        if (!(TableThree.Rows[i].Cells[j].Value.ToString().Trim() == "—"))
                        {
                            if (!(TableThree.Rows[i].Cells[j].Value.ToString().Trim() == "-"))
                            {
                                f3[i, j - 1] = Convert.ToInt32(TableThree.Rows[i].Cells[j].Value);
                            }
                        }

                    }
                }

            }
            int[] f4 = new int[8];
            for (int i = 0; i < 8; i++)
            {
                if (TableFour.Rows[i].Cells[1].Value == null)
                {
                    TableFour.Rows[i].Cells[1].Style.BackColor = Color.LightPink;
                }
                else
                {
                    TableFour.Rows[i].Cells[1].Style.BackColor = Color.White;
                    f4[i] = Convert.ToInt32(TableFour.Rows[i].Cells[1].Value);
                }

            }
            int[,] table_P3 = p3Table(f3, f4);
            bool flag = true;
            for (int i = 0; i < 9; i++)
            {
                if(TableP3.Rows[i].Cells[1].Value == null)
                {
                    flag = false;
                    TableP3.Rows[i].Cells[1].Style.BackColor = Color.LightPink;
                    if (TableP3.Rows[i].Cells[2].Value == null)
                    {
                        flag = false;
                        TableP3.Rows[i].Cells[2].Style.BackColor = Color.LightPink;
                    }
                } 
                else if (TableP3.Rows[i].Cells[2].Value == null)
                {
                    flag = false;
                    TableP3.Rows[i].Cells[2].Style.BackColor = Color.LightPink;
                }
                else
                {
                    if (Convert.ToInt32(TableP3.Rows[i].Cells[2].Value) != table_P3[i, 2])
                    {
                        TableP3.Rows[i].Cells[2].Style.BackColor = Color.LightPink;
                        flag = false;
                    }
                    else
                    {
                        TableP3.Rows[i].Cells[2].Style.BackColor = Color.White;
                        if (Convert.ToInt32(TableP3.Rows[i].Cells[1].Value) == table_P3[i, 1])
                        {
                            TableP3.Rows[i].Cells[1].Style.BackColor = Color.White;
                        }
                        else
                        {
                            bool alternate = false;
                            // поиск альтернативы
                            for (int j = 8, k = 0; j >= 0; j--, k++)
                            {
                                if (alternate)
                                    break;
                                int kTmp = 0, xTmp = 0, pTmp = 0;
                                for (int c = 0; c < 8; c++)
                                {
                                    if (f3[c, j] != 0)
                                    {
                                        if (f3[c, j] + f4[k - c] == table_P3[i, 2])
                                        {
                                            kTmp = k + 2;
                                            xTmp = c + 1;
                                            pTmp = f3[c, j] + f4[k - c];
                                            if ((Convert.ToInt32(TableP3.Rows[i].Cells[1].Value)) == xTmp)
                                            {
                                                alternate = true;
                                                break;
                                            }
                                        }
                                    }
                                }
                            }
                            // поиск альтернативы
                            if (!alternate)
                            {
                                flag = false;
                                TableP3.Rows[i].Cells[1].Style.BackColor = Color.LightPink;
                            }
                            else
                            {
                                TableP3.Rows[i].Cells[1].Style.BackColor = Color.White;
                            }
                        }
                    }
                }
            }
            if (!flag)
            {
                MessageBox.Show("Не все поля заполнены верно!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                MessageBox.Show("Все поля заполнены верно!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int[] f1 = new int[8];
            for (int i = 0; i < 8; i++)
            {
                if (TableOne.Rows[i].Cells[1].Value == null)
                {
                    TableOne.Rows[i].Cells[1].Style.BackColor = Color.LightPink;
                }
                else
                {
                    TableOne.Rows[i].Cells[1].Style.BackColor = Color.White;
                    f1[i] = Convert.ToInt32(TableOne.Rows[i].Cells[1].Value);
                }

            }
            int[,] f2 = new int[8, 8];
            for (int j = 1; j < 9; j++)
            {
                for (int i = 0; i < 8; i++)
                {
                    if (TableTwo.Rows[i].Cells[j].Value == null)
                    {
                        TableTwo.Rows[i].Cells[j].Style.BackColor = Color.LightPink;
                    }
                    else
                    {
                        TableTwo.Rows[i].Cells[j].Style.BackColor = Color.White;
                        if (!(TableTwo.Rows[i].Cells[j].Value.ToString().Trim() == "—"))
                        {
                            if (!(TableTwo.Rows[i].Cells[j].Value.ToString().Trim() == "-"))
                            {
                                f2[i, j - 1] = Convert.ToInt32(TableTwo.Rows[i].Cells[j].Value);
                            }
                        }
                    }

                }
            }
            int[,] f3 = new int[8, 9];
            for (int j = 1; j < 10; j++)
            {
                for (int i = 0; i < 8; i++)
                {
                    if (TableThree.Rows[i].Cells[j].Value == null)
                    {
                        TableThree.Rows[i].Cells[j].Style.BackColor = Color.LightPink;
                    }
                    else
                    {
                        TableThree.Rows[i].Cells[j].Style.BackColor = Color.White;
                        if (!(TableThree.Rows[i].Cells[j].Value.ToString().Trim() == "—"))
                        {
                            if (!(TableThree.Rows[i].Cells[j].Value.ToString().Trim() == "-"))
                            {
                                f3[i, j - 1] = Convert.ToInt32(TableThree.Rows[i].Cells[j].Value);
                            }
                        }

                    }
                }

            }
            int[] f4 = new int[8];
            for (int i = 0; i < 8; i++)
            {
                if (TableFour.Rows[i].Cells[1].Value == null)
                {
                    TableFour.Rows[i].Cells[1].Style.BackColor = Color.LightPink;
                }
                else
                {
                    TableFour.Rows[i].Cells[1].Style.BackColor = Color.White;
                    f4[i] = Convert.ToInt32(TableFour.Rows[i].Cells[1].Value);
                }

            }
            int[,] table_P3 = p3Table(f3, f4);
            int[] P3 = new int[9];
            for (int i = 0; i < 9; i++)
            {
                P3[i] = table_P3[i, 2];
            }
            int[,] table_P2 = p2Table(f2, P3);
            int[] P2 = new int[8];
            for (int i = 0; i < 8; i++)
            {
                P2[i] = table_P2[i, 2];
            }

            bool flag = true;
            for (int i = 0; i < 8; i++)
            {
                if (TableP2.Rows[i].Cells[1].Value == null)
                {
                    flag = false;
                    TableP2.Rows[i].Cells[1].Style.BackColor = Color.LightPink;
                    if (TableP2.Rows[i].Cells[2].Value == null)
                    {
                        flag = false;
                        TableP2.Rows[i].Cells[2].Style.BackColor = Color.LightPink;
                    }
                }
                else if (TableP2.Rows[i].Cells[2].Value == null)
                {
                    flag = false;
                    TableP2.Rows[i].Cells[2].Style.BackColor = Color.LightPink;
                }
                else
                {
                    if (Convert.ToInt32(TableP2.Rows[i].Cells[2].Value) != table_P2[i, 2])
                    {
                        TableP2.Rows[i].Cells[2].Style.BackColor = Color.LightPink;
                        flag = false;
                    }
                    else
                    {
                        TableP2.Rows[i].Cells[2].Style.BackColor = Color.White;
                        if (Convert.ToInt32(TableP2.Rows[i].Cells[1].Value) == table_P2[i, 1])
                        {
                            TableP2.Rows[i].Cells[1].Style.BackColor = Color.White;
                        }
                        else
                        {
                            // поиск альтернативы
                            bool alternate = false;
                            for (int j = 7, k = 1; j >= 0; j--, k++)
                            {
                                if (alternate)
                                    break;
                                int kTmp = 0, xTmp = 0, pTmp = 0;
                                for (int c = 0; c < 8; c++)
                                {
                                    if (f2[c, j] != 0)
                                    {
                                        if (f2[c, j] + P3[k - c] == table_P2[i, 2])
                                        {
                                            kTmp = k + 3;
                                            xTmp = c + 1;
                                            pTmp = f2[c, j] + P3[k - c];
                                            if (Convert.ToInt32(TableP2.Rows[i].Cells[1].Value) == xTmp)
                                            {
                                                alternate = true;
                                                break;
                                            }
                                        }
                                    }
                                }
                            }
                            // поиск альтернативы
                            if(alternate)
                            {
                                TableP2.Rows[i].Cells[1].Style.BackColor = Color.White;
                            }
                            else
                            {
                                flag = false;
                                TableP2.Rows[i].Cells[1].Style.BackColor = Color.LightPink;
                            }

                        }
                    }
                }

            }
            if (!flag)
            {
                MessageBox.Show("Не все поля заполнены верно!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                MessageBox.Show("Все поля заполнены верно!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] f1 = new int[8];
            for (int i = 0; i < 8; i++)
            {
                if (TableOne.Rows[i].Cells[1].Value == null)
                {
                    TableOne.Rows[i].Cells[1].Style.BackColor = Color.LightPink;
                }
                else
                {
                    TableOne.Rows[i].Cells[1].Style.BackColor = Color.White;
                    f1[i] = Convert.ToInt32(TableOne.Rows[i].Cells[1].Value);
                }

            }
            int[,] f2 = new int[8, 8];
            for (int j = 1; j < 9; j++)
            {
                for (int i = 0; i < 8; i++)
                {
                    if (TableTwo.Rows[i].Cells[j].Value == null)
                    {
                        TableTwo.Rows[i].Cells[j].Style.BackColor = Color.LightPink;
                    }
                    else
                    {
                        TableTwo.Rows[i].Cells[j].Style.BackColor = Color.White;
                        if (!(TableTwo.Rows[i].Cells[j].Value.ToString().Trim() == "—"))
                        {
                            if (!(TableTwo.Rows[i].Cells[j].Value.ToString().Trim() == "-"))
                            {
                                f2[i, j - 1] = Convert.ToInt32(TableTwo.Rows[i].Cells[j].Value);
                            }
                        }
                    }

                }
            }
            int[,] f3 = new int[8, 9];
            for (int j = 1; j < 10; j++)
            {
                for (int i = 0; i < 8; i++)
                {
                    if (TableThree.Rows[i].Cells[j].Value == null)
                    {
                        TableThree.Rows[i].Cells[j].Style.BackColor = Color.LightPink;
                    }
                    else
                    {
                        TableThree.Rows[i].Cells[j].Style.BackColor = Color.White;
                        if (!(TableThree.Rows[i].Cells[j].Value.ToString().Trim() == "—"))
                        {
                            if (!(TableThree.Rows[i].Cells[j].Value.ToString().Trim() == "-"))
                            {
                                f3[i, j - 1] = Convert.ToInt32(TableThree.Rows[i].Cells[j].Value);
                            }
                        }

                    }
                }

            }
            int[] f4 = new int[8];
            for (int i = 0; i < 8; i++)
            {
                if (TableFour.Rows[i].Cells[1].Value == null)
                {
                    TableFour.Rows[i].Cells[1].Style.BackColor = Color.LightPink;
                }
                else
                {
                    TableFour.Rows[i].Cells[1].Style.BackColor = Color.White;
                    f4[i] = Convert.ToInt32(TableFour.Rows[i].Cells[1].Value);
                }

            }
            int[,] table_P3 = p3Table(f3, f4);
            int[] P3 = new int[9];
            for (int i = 0; i < 9; i++)
            {
                P3[i] = table_P3[i, 2];
            }
            int[,] table_P2 = p2Table(f2, P3);
            int[] P2 = new int[8];
            for (int i = 0; i < 8; i++)
            {
                P2[i] = table_P2[i, 2];
            }
            int[] table_P1 = p1Table(f1, P2);
            bool flag = true;
            if (Convert.ToInt32(TableP1.Rows[0].Cells[2].Value) != table_P1[2])
            {
                TableP1.Rows[0].Cells[2].Style.BackColor = Color.LightPink;
                flag = false;
            }
            else
            {
                TableP1.Rows[0].Cells[2].Style.BackColor = Color.White;

                if (Convert.ToInt32(TableP1.Rows[0].Cells[1].Value) == table_P1[1])
                {
                    TableP1.Rows[0].Cells[1].Style.BackColor = Color.White;
                }
                else
                {
                    bool alternate = false;
                    int x1 = 0, p1 = 0;
                    for (int i = 0, k = 2; i < 8; i++)
                    {
                        if (alternate)
                            break;
                        if (f1[i] + P2[8 - i - 1] == table_P1[2])
                        {
                            x1 = i + 1;
                            p1 = f1[i] + P2[8 - i - 1];
                            if(Convert.ToInt32(TableP1.Rows[0].Cells[1].Value) == x1)
                            {
                                alternate = true;
                                break;
                            }
                        }
                    }


                    if(!alternate)
                    {
                        flag = false;
                        TableP1.Rows[0].Cells[1].Style.BackColor = Color.LightPink;
                    }
                    else
                    {
                        TableP1.Rows[0].Cells[1].Style.BackColor = Color.White;
                    }
                }
            }
            if (!flag)
            {
                MessageBox.Show("Не все поля заполнены верно!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                MessageBox.Show("Все поля заполнены верно!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonCheckSolution_Click(object sender, EventArgs e)
        {
            int[] f1 = new int[8];
            for (int i = 0; i < 8; i++)
            {
                if (TableOne.Rows[i].Cells[1].Value == null)
                {
                    TableOne.Rows[i].Cells[1].Style.BackColor = Color.LightPink;
                }
                else
                {
                    TableOne.Rows[i].Cells[1].Style.BackColor = Color.White;
                    f1[i] = Convert.ToInt32(TableOne.Rows[i].Cells[1].Value);
                }

            }
            int[,] f2 = new int[8, 8];
            for (int j = 1; j < 9; j++)
            {
                for (int i = 0; i < 8; i++)
                {
                    if (TableTwo.Rows[i].Cells[j].Value == null)
                    {
                        TableTwo.Rows[i].Cells[j].Style.BackColor = Color.LightPink;
                    }
                    else
                    {
                        TableTwo.Rows[i].Cells[j].Style.BackColor = Color.White;
                        if (!(TableTwo.Rows[i].Cells[j].Value.ToString().Trim() == "—"))
                        {
                            if (!(TableTwo.Rows[i].Cells[j].Value.ToString().Trim() == "-"))
                            {
                                f2[i, j - 1] = Convert.ToInt32(TableTwo.Rows[i].Cells[j].Value);
                            }
                        }
                    }

                }
            }
            int[,] f3 = new int[8, 9];
            for (int j = 1; j < 10; j++)
            {
                for (int i = 0; i < 8; i++)
                {
                    if (TableThree.Rows[i].Cells[j].Value == null)
                    {
                        TableThree.Rows[i].Cells[j].Style.BackColor = Color.LightPink;
                    }
                    else
                    {
                        TableThree.Rows[i].Cells[j].Style.BackColor = Color.White;
                        if (!(TableThree.Rows[i].Cells[j].Value.ToString().Trim() == "—"))
                        {
                            if (!(TableThree.Rows[i].Cells[j].Value.ToString().Trim() == "-"))
                            {
                                f3[i, j - 1] = Convert.ToInt32(TableThree.Rows[i].Cells[j].Value);
                            }
                        }

                    }
                }

            }
            int[] f4 = new int[8];
            for (int i = 0; i < 8; i++)
            {
                if (TableFour.Rows[i].Cells[1].Value == null)
                {
                    TableFour.Rows[i].Cells[1].Style.BackColor = Color.LightPink;
                }
                else
                {
                    TableFour.Rows[i].Cells[1].Style.BackColor = Color.White;
                    f4[i] = Convert.ToInt32(TableFour.Rows[i].Cells[1].Value);
                }

            }
            int[,] table_P3 = p3Table(f3, f4);
            int[] P3 = new int[9];
            for (int i = 0; i < 9; i++)
            {
                P3[i] = table_P3[i, 2];
            }
            int[,] table_P2 = p2Table(f2, P3);
            int[] P2 = new int[8];
            for (int i = 0; i < 8; i++)
            {
                P2[i] = table_P2[i, 2];
            }
            int[] table_P1 = p1Table(f1, P2);
            int[] result = calculate(table_P1, table_P2, table_P3);
            bool flag = true;

            for (int i = 1; i < 7; i++)
            {
                if (Convert.ToInt32(TableX.Rows[0].Cells[i].Value) != result[i - 1])
                {
                    TableX.Rows[0].Cells[i].Style.BackColor = Color.LightPink;
                    flag = false;
                }
                else
                {
                    TableX.Rows[0].Cells[i].Style.BackColor = Color.White;
                }

            }

            if (!flag)
            {
                MessageBox.Show("Не все поля заполнены верно!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                MessageBox.Show("Все поля заполнены верно!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show("Задача успешно решена! Поздравляем!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void вводИзФайлаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newForm2 = new Form3();
            newForm2.ShowDialog();
            returnVariant(Globals.option);
        }

        public void returnVariant(int num)
        {
            try
            {
                string option = "***         Вариант " + num;
                string[] list = new string[32];
                int c = 0;
                bool flag = false;
                foreach (string line in File.ReadLines("task.txt"))
                {
                    if (flag && c < 31)
                    {
                        list[c] = line;
                        list[c] = list[c].Trim();
                        c++;
                    }

                    if (line.StartsWith(option) && !flag)
                    {
                        list[c] = line;
                        list[c] = list[c].Trim();
                        c++;
                        flag = true;
                    }
                }

                int[] f1 = new int[8];
                int[,] f2 = new int[8, 8];
                int[,] f3 = new int[8, 9];
                int[] f4 = new int[8];
                for (int i = 10, j = 0; i < 18; i++, j++)
                {
                    int row = i - 10, column = 0;
                    for (int k = 0; k < 8; k++)
                    {
                        string line = list[i].Remove(0, 16 + k * 3).Remove(3, 21 - k * 3);
                        if (line.Trim() != "-")
                            f2[row, column] = Convert.ToInt32(line);
                        column++;
                    }

                    f1[j] = Convert.ToInt32(list[i].Remove(0, 3).Remove(2, list[i].Length - 5));
                }

                for (int i = 23, j = 0; i < 31; i++, j++)
                {
                    string startStr = list[i];
                    int row = i - 23, column = 0;
                    for (int k = 0; k < 9; k++)
                    {
                        string line = list[i].Remove(0, 8 + k * 3).Remove(3, 32 - k * 3);
                        if (line.Trim() != "-")
                            f3[row, column] = Convert.ToInt32(line);
                        column++;
                    }

                    string part = startStr.Remove(0, 41).Trim();
                    f4[row] = Convert.ToInt32(part);
                }
                for (int i = 0; i < 8; i++)
                {
                    TableOne.Rows[i].Cells[1].Value = f1[i];
                    TableFour.Rows[i].Cells[1].Value = f4[i];
                }

                for (int i = 0; i < 8; i++)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        if (f2[i, j] != 0)
                        {
                            TableTwo.Rows[i].Cells[j + 1].Value = f2[i, j];
                        }
                        else
                        {
                            TableTwo.Rows[i].Cells[j + 1].Value = "-";
                        }
                    }
                }
                for (int i = 0; i < 8; i++)
                {
                    for (int j = 0; j < 9; j++)
                    {
                        if (f3[i, j] != 0)
                        {
                            TableThree.Rows[i].Cells[j + 1].Value = f3[i, j];
                        }
                        else
                        {
                            TableThree.Rows[i].Cells[j + 1].Value = "-";
                        }
                    }
                }
            }catch (Exception ex)
            {
                MessageBox.Show("Неверный вариант!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
        }

        private void ручнойВводToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TableOne.Rows.Clear();
            TableTwo.Rows.Clear();
            TableThree.Rows.Clear();
            TableFour.Rows.Clear();

            TableHelp1.Rows.Clear();
            TableHelp2.Rows.Clear();
            TableHelp3.Rows.Clear();
            TableP1.Rows.Clear();
            TableP2.Rows.Clear();
            TableP3.Rows.Clear();
            TableX.Rows.Clear();
            setUpTables();

            tabControl1.Visible = false;
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("Памятка пользователя.pdf");
        }

        private void TableOne_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
        }
    }

    public static class Globals
    {
        public static bool adminFlag = false;
        public static int option = 0;
    }


}
