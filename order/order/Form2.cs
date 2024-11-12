using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace order
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        string[] mainDish = new string[] { "綠色氣泡", "紫色氣泡", "金色氣泡" };
        int[] dishPrise = new int[] { 20, 50, 100 };
        string[] ing = new string[] { "QUASO", "Ak47", "大拇指" };
        int[] ingPrise = new int[] { 30, 47, 50 };

        private void Form2_Load(object sender, EventArgs e)
        {
            comboBox1.Items.AddRange(mainDish);
            comboBox1.SelectedIndex = 0;
            comboBox2.Items.AddRange(ing);
            comboBox2.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1.msg += comboBox1.Text + " " + dishPrise[comboBox1.SelectedIndex] + "元"+ "\r\n" ;
            Form1.msg += comboBox2.Text + " " + ingPrise[comboBox2.SelectedIndex] +"元"+ "\r\n";

            Form1.prise = dishPrise[comboBox1.SelectedIndex] + ingPrise[comboBox2.SelectedIndex];
            Form1.msg += $"合計{Form1.prise}元\r\n";
            
            this.Dispose(); 
            Form3 f1 = new Form3();
            f1.ShowDialog();
            
            
        }
    }
}
