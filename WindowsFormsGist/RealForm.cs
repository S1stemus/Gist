using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsGist
{
    public partial class RealForm : Form
    {
        public  List<int> List { get; set; }
        public int Grouper { get; set; }
        public int Max { get; set; }

        public RealForm(List<int>list,int grouper,int max)
        {
            List =list;
            Grouper =grouper;
            Max =max;
            Gist(List, Max, Grouper);
        }
        public RealForm()
        {
            InitializeComponent();
        }
        public void Gist(List<int> list,int Max,int Grouper)
        {
            double count = 0;
            for (double i = 1; i < Max / Grouper + 1; i++)
            {
                for (int j = 0; j < List.Count; j++)
                {
                    if (i * Grouper < List[j] && List[j] < (i + 1) * Grouper)
                    {
                        count++;
                    }
                }
                chart1.Series[0].Points.AddXY(i, count);
                count = 0;
            }
        }

        private void RealForm_Load(object sender, EventArgs e)
        {
            
            
            
        }
    }
}
