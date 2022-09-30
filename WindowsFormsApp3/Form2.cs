using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Muchenia;

namespace WindowsFormsApp3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int N;
            try
            {
                int maxnum = int.Parse(MaxNum.Text);
                int minnum = int.Parse(MinNum.Text);
                int groupBy = int.Parse(textBoxGroupBy.Text);
                if (groupBy < 2 || groupBy >= 5000) throw new NullReferenceException();
                if (maxnum <= 0 || minnum <= 0) throw new IndexOutOfRangeException();
                if (maxnum < minnum)
                {
                    DialogResult dialogResult = MessageBox.Show("Изменить?", "Максимальное значение меньше минимального", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        int tmp = maxnum;
                        maxnum = minnum;
                        minnum = tmp;
                        MaxNum.Text = maxnum.ToString();
                        MinNum.Text = minnum.ToString();
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        return;
                    }
                }
                string output = "";
                // List<int> Simp = Eratnosfer.ListFalseIndeces(Eratnosfer.GetMatrix(maxnum));
                List<int> Simp = Eratnosfer.FilterArray(minnum, maxnum);
                // Eratnosfer.Filter(Simp, minnum);
                int[] Diff = Eratnosfer.MaxDiff1(Simp);
                int[] Max = Eratnosfer.MaxSimpleNum(Simp, maxnum, groupBy);
                int[] Min = Eratnosfer.MinSimpleNum(Simp, maxnum, minnum, groupBy);
                OutputBox.Text = String.Join(",", Simp);
                MaxCount.Text = $"{Max[1]} ({Max[0]})";
                MinCount.Text = $"{Min[1]} ({Min[0]})";
                MaxDif.Text = $"{Diff[0]} ({Diff[1]}-{Diff[2]})";
                OutputBox.Text += output;
            }
            catch (NullReferenceException)
            {
                OutputBox.Text = "Введите число от 2 до 5000";
            }
            catch (FormatException)
            {
                OutputBox.Text = "Вводите только числа";
            }
            catch (OverflowException)
            {
                OutputBox.Text = "Введено слишком большое число";
            }
            catch (IndexOutOfRangeException)
            {
                OutputBox.Text = "Введите число которое больше нуля";
            }
        }
    }
}
