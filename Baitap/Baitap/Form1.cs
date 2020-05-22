using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Baitap
{
    public partial class Form1 : Form
    {
        Baitap.Xuly connect;
        public Form1()
        {
            connect = new Xuly();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "Prolog file|*.pl";
            op.ShowDialog();
            String FilePath = op.FileName;
            connect.Load_file(FilePath);
            MessageBox.Show("Load file success !");
        }

        private void btThuchien_Click(object sender, EventArgs e)
        {
            if (this.txtinput.Text != null)
            {
                //Chuyển textBox1.txt sang câu truy vấn
                String s = connect.Query(changestring());

                this.txtoutput.Text = s;
                //this.txtTree.Text = s;
            }
            else
            {
                MessageBox.Show("Please enter query !");
            }    
        }

        // ham chuyen
        public string changestring()
        {
            string s = "cau(Cay,[";
            string dulieu = txtinput.Text;
            string[] chuoi = dulieu.Split(new Char[] { ' ' });
            for (int i = 0; i < int.Parse(chuoi.Length.ToString()); i++)
            {
                s = s + chuoi[i];
                if (i != int.Parse(chuoi.Length.ToString()) - 1)
                    s = s + ',';
            }
            s = s + "],[]).";
            return s;
        }

    }
}
