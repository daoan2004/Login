using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text==""&&textBox2.Text=="")
            {
                MessageBox.Show("Chưa nhập cả 2");
            }
            else 
            {
                if(textBox1.Text==""&&textBox2.Text!="")
                {
                    MessageBox.Show("chưa nhập tên đăng nhập");
                }   
                else if(textBox1.Text!=""&&textBox2.Text=="")
                {
                    MessageBox.Show("chưa nhập mật khẩu");
                }    
                else
                {
                    if (textBox1.Text == "DHSP" && textBox2.Text == "tinhoc")
                    {                        
                     MessageBox.Show("đăng nhập thành công ");                                                            
                    }

                    else { MessageBox.Show("Đăng nhập không thành công"); }
                }
            }    
            } 
            
           

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
