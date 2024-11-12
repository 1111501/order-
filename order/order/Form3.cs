using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace order
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1.msg += "====================\r\n";
            
            if(checkBox1.Checked) 
            {
                Form1.prise = Form1.prise * 0.8 ;
                Form1.msg += "會員打八折\r\n";
            }
            if(checkBox2.Checked) 
            {
                Form1.prise = Form1.prise - 10 ;
                Form1.msg += "折扣10元\r\n";
            }
            
            Form1.msg += $"實收"+Math.Round(Form1.prise,0).ToString()+"元";

            this.Dispose();
            
        }
    }
}
