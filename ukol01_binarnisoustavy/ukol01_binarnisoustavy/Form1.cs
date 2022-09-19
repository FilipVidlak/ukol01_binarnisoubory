using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ukol01_binarnisoustavy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream soubor = new Filestream(@"..\..\znaky.dat", FileMode.Open, FileAccess.Read);
                BinaryReader cteni = new BinaryReader(soubor, Encoding.GetEncoding("Windows-1250"));
                cteni.BaseStream.Position = 0;
                while (cteni.BaseStream.Position < cteni.BaseStream.Length)
                {
                    if (cteni.ReadChar() == '?') {
                        label3.Text = "První otazník je na pozici " + cteni.BaseStream.Position.ToString();
                        cteni.BaseStream.Position -= 2;
                        label4.Text = "A znak před otazníkem je " + cteni.ReadChar().ToString();
                        break;
                    }
                }
                soubor.Close();
                cteni.Close();
            }
            catch
            {
                MessageBox.Show("Nastala chyba!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
