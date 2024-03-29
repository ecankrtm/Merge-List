using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Merge_List
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                string a = (string)listBox1.SelectedItem;

             
                string b = (string)listBox2.SelectedItem;

                if (string.IsNullOrEmpty(a) || string.IsNullOrEmpty(b))
                {
                    MessageBox.Show("Lütfen her iki listeden de bir öğe seçin.");
                    return;
                }

               
                listBox3.Items.Add($"{a} {b}");
            }
        }
    }


