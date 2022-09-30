
namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.MaxNum = new System.Windows.Forms.TextBox();
            this.OutputBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MinNum = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.MaxCount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.MinCount = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.MaxDif = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxGroupBy = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(293, 150);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 27);
            this.button1.TabIndex = 0;
            this.button1.Text = "Найти";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MaxNum
            // 
            this.MaxNum.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MaxNum.Location = new System.Drawing.Point(166, 47);
            this.MaxNum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaxNum.Name = "MaxNum";
            this.MaxNum.Size = new System.Drawing.Size(281, 29);
            this.MaxNum.TabIndex = 1;
            this.MaxNum.TextChanged += new System.EventHandler(this.InputBox_TextChanged);
            // 
            // OutputBox
            // 
            this.OutputBox.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OutputBox.Location = new System.Drawing.Point(4, 188);
            this.OutputBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OutputBox.Multiline = true;
            this.OutputBox.Name = "OutputBox";
            this.OutputBox.ReadOnly = true;
            this.OutputBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.OutputBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.OutputBox.Size = new System.Drawing.Size(514, 132);
            this.OutputBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label2.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(4, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(253, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Найденные простые числа:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(60, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Искать от";
            // 
            // MinNum
            // 
            this.MinNum.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MinNum.Location = new System.Drawing.Point(166, 12);
            this.MinNum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinNum.Name = "MinNum";
            this.MinNum.Size = new System.Drawing.Size(281, 29);
            this.MinNum.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(4, 335);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(273, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "Наибольшое кол-во простых чисел ";
            // 
            // MaxCount
            // 
            this.MaxCount.Enabled = false;
            this.MaxCount.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MaxCount.Location = new System.Drawing.Point(314, 335);
            this.MaxCount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaxCount.Name = "MaxCount";
            this.MaxCount.Size = new System.Drawing.Size(204, 26);
            this.MaxCount.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(4, 368);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(280, 19);
            this.label5.TabIndex = 10;
            this.label5.Text = "Наименьшее кол-во простых чисел в";
            // 
            // MinCount
            // 
            this.MinCount.Enabled = false;
            this.MinCount.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MinCount.Location = new System.Drawing.Point(316, 368);
            this.MinCount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinCount.Name = "MinCount";
            this.MinCount.Size = new System.Drawing.Size(202, 26);
            this.MinCount.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(4, 404);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(277, 38);
            this.label6.TabIndex = 12;
            this.label6.Text = "Максимальная разница между двумя\r\nсоседними простыми числами";
            // 
            // MaxDif
            // 
            this.MaxDif.Enabled = false;
            this.MaxDif.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MaxDif.Location = new System.Drawing.Point(314, 416);
            this.MaxDif.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaxDif.Name = "MaxDif";
            this.MaxDif.Size = new System.Drawing.Size(204, 26);
            this.MaxDif.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(118, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 19);
            this.label1.TabIndex = 13;
            this.label1.Text = "до";
            // 
            // textBoxGroupBy
            // 
            this.textBoxGroupBy.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxGroupBy.Location = new System.Drawing.Point(166, 87);
            this.textBoxGroupBy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxGroupBy.Name = "textBoxGroupBy";
            this.textBoxGroupBy.Size = new System.Drawing.Size(281, 29);
            this.textBoxGroupBy.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(3, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 19);
            this.label7.TabIndex = 15;
            this.label7.Text = "Группировать по:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(637, 35);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(167, 41);
            this.button2.TabIndex = 16;
            this.button2.Text = "Создать гистограмму";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1192, 484);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxGroupBy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.MaxDif);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.MinCount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.MaxCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MinNum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.OutputBox);
            this.Controls.Add(this.MaxNum);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox MaxNum;
        private System.Windows.Forms.TextBox OutputBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox MinNum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox MaxCount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox MinCount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox MaxDif;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxGroupBy;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
    }
}

