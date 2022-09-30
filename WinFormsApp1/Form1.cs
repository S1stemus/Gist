using Muchenia;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsGist;



namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
                int[] Max = Eratnosfer.MaxSimpleNum(Simp, maxnum,groupBy);
                int[] Min = Eratnosfer.MinSimpleNum(Simp, maxnum, minnum,groupBy);
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
        public static int[][] GetGisto(List<int> list, int groupBy, int max)
        {
            int count = 0;
            int[] nums = new int[2] { 0, 1 };
            int[][] arrays = new int[max/groupBy+1][];

            for (int i = 1; i < (max / groupBy) + 1; i++)
            {
                for (int j = 0; j < list.Count; j++)
                {
                    //if (list[j] < i*10 || list[j] > i) continue;
                    //count++;
                    if (list[j] < i * groupBy && list[j] > (i - 1) * groupBy) count++;
                }
                nums[0] = i;
                nums[1] = count;
                arrays[i] = nums;   
                count = 0;
            }

            return arrays;
        }

        private void InputBox_TextChanged(object sender, EventArgs e)
        {
            OutputBox.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(!(String.IsNullOrWhiteSpace(OutputBox.Text)))
            {
                string[] a = OutputBox.Text.Split(',');
                List<int> list = new List<int>();
                for (int i = 0; i < a.Length; i++)
                {
                    list.Add(int.Parse(a[i]));
                }

                RealForm form = new RealForm(list, int.Parse(textBoxGroupBy.Text), int.Parse(MaxNum.Text));
                form.Gist(list, int.Parse(textBoxGroupBy.Text), int.Parse(MaxNum.Text));
                form.Show();
            }
            else
            {
                MessageBox.Show("Отсутствует ряд простых чисел", "Ошибка!");
            }
            
        }
    }
}
