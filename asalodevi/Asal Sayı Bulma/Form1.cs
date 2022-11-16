using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asal_Sayı_Bulma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sayı1=Convert.ToInt64(textBox1.Text);
            double sayı2=Convert.ToInt64(textBox2.Text);
            for (double i=sayı1;i<=sayı2 ;i++)
            {
                int kontrol = 0;
                for(int j=2;j<i;j++)
                {
                    if (i%j==0)
                    {
                        kontrol++;
                        break;
                    }
                }
                if (kontrol==0)
                {
                    listBox1.Items.Add(i);
                }
            }
           
            
            }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
        }
    

