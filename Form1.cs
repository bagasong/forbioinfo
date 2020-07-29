using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace buatlo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            String location = "";

            
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Title = "Open file brow";
                ofd.Filter = "Text Files|*.txt";
                if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    MessageBox.Show(ofd.FileName + "\nsilakan dicek filenya!", "done!");
                }

                location = ofd.FileName;
            }

            catch (Exception)
            {
                MessageBox.Show("error brow soz, salah input gan", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //path
            var path = @location;

            // Part 1: the input string.
            string input = File.ReadAllText(path);
            string data = input.Replace("\n", "").Replace(" ", "");

            // Console.WriteLine("this is before \n" + data);

            // Part 2: split string on spaces (this will separate all the words).
            var arr = data.ToCharArray();

            string result = String.Join("\n", arr);

            //write a file
            File.WriteAllText(path, result);


            // Read a file  
            // string output = File.ReadAllText(path);
            // Console.WriteLine("this is the output \n" + output);

        }




    }
}
