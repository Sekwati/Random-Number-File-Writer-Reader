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

namespace Practical8_28124227
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
                int InputNumber;
                Random randomvalue = new Random();
                int GeneratedNumber = 0;
                int sum = 0;
                StreamWriter outputFile;


                outputFile = File.CreateText("Random_Number.txt");

                if (int.TryParse(textBox1.Text, out InputNumber))
                {
                    for (int count = 1; count <= InputNumber; count++)
                    {
                        GeneratedNumber = randomvalue.Next(1, 100);
                        outputFile.WriteLine(GeneratedNumber);
                        sum += GeneratedNumber;
                    }

                    outputFile.Close();
                }
                else
                {
                    MessageBox.Show("Please Enter Numbers only!");
                }

                
   

                MessageBox.Show("File saved successfully!");
            }
            catch
            {
                MessageBox.Show("Error Invalid Input! \nEnter intergers only.");

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int InputNumber;
            int count = 0;
            int OutPut;
            int sum = 0;
            int.TryParse(textBox1.Text, out InputNumber);

            StreamReader inputFile;

            inputFile = File.OpenText("Random_Number.txt");

            while (!inputFile.EndOfStream)
            {
                OutPut=int.Parse(inputFile.ReadLine());
                listBox1.Items.Add(OutPut);
                count++;
                sum += OutPut;
            }
            listBox1.Items.Add("");
            listBox1.Items.Add("The number of random values read from the file: " + count);
            listBox1.Items.Add("The total of numbers is: " + sum);
        }
    }
}
