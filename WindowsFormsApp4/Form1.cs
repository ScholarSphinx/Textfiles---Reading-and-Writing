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

//for texfiles we are using System.IO

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //a textfile is a permanent data storage
            //There are two main functions of a textfile
            //Read from a textfile --> Input - datasource that we are reading.
            //Write to a textfile --> Output - giving the datasource information/data

            //string, double, integer, decimal, bool,
            //Read - StreamReader
            //Write - StreamWriter

            //string name;
            //StreamReader datasource;
            //StreamWriter datasource

            //Two types of writing
            //Rewriting a textfile - assume the file doesn't exist, and you replce any exsiting data
            //eg. Notice --> Noted
            //Appending to a textfile - assumes the file exists, and you add on to the existing content
            //eg. Notice --> NoticeNoted

            StreamWriter output;
            output = File.CreateText("test.txt");
            //.txt - this is the file extension for a textfile --> DO NOT LEAVE THIS OUT
            //Rewriting a file


            //output.Write("1");
            //output.Write("2");
            //output.Write("3");

            //123

            //output.WriteLine("1");
            //output.WriteLine("2");
            //output.WriteLine("3");

            //1
            //2
            //3

            output.Write("1");
            output.Write("2");
            output.Write("3");

            //close the textfile
            //if you do not close it and run a method or press a button that uses the same textfile it will break!
            output.Close();
            MessageBox.Show("Written to textfile");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            StreamWriter output;
            //[variable type] [variable name];\
            output = File.AppendText("test.txt");
            //Appending a file

            

            output.Write("1");
            output.Write("2");
            output.Write("3");

            output.WriteLine("1");
            output.WriteLine("2");
            output.WriteLine("3");

            output.Close();
            MessageBox.Show("Appended to textfile");

        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            StreamWriter output = File.AppendText("test.txt");
            //[variable type] [variable name] = File.AppendText("[file name.txt]");
            //[variable type] [variable name] = File.CreateText("[file name.txt]");
            for (int i = 0; i< listBox1.Items.Count ; i++)
            //indexes in listboxes start from 0;
            //we do not need the -1, if we add the minus one, then the final value will be less than the final index. This means that it misses one of the values in the listbox
            //lets say you have 1 item, the item is the first one, but its index is 0
            //lets say you have a 2nd item, its 2 items, but the second items index is 1
            {
                output.WriteLine(listBox1.Items[i]);
            }
            output.Close();
            MessageBox.Show("Advanced Writing done");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Getting data from the textfile
            //Use StreamReader
            //[variable type] [variable name];
            StreamReader input;
            input = File.OpenText("test2.txt");

            //store line data in a variable

            string sLine;
            sLine = input.ReadLine();
            MessageBox.Show(sLine);

            //Please please please close the textfile
            input.Close();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            StreamReader input;
            input = File.OpenText("test2.txt");
            MessageBox.Show(input.ReadLine());
            input.Close();

            //Difference is that I'm not using the variable sLine
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StreamReader input;
            input = File.OpenText("test.txt");

            //We do not know how many lines the textfile has

            //input.EndOfStream
            //EndOfStream checks for the end of the textfile

            while (input.EndOfStream == false)
                //while the condition () is true
            {
                string sLine;
                sLine = input.ReadLine();
                //Reads the first line that has not been read yet.
                listBox2.Items.Add(sLine);
            }
            MessageBox.Show("Job is done");

        }

        private void button7_Click(object sender, EventArgs e)
        {
            StreamReader input = File.OpenText("test.txt");
            listBox2.Items.Clear();
            while (input.EndOfStream == false)
            {
                listBox2.Items.Add(input.ReadLine());
            }
            MessageBox.Show("Next job is done");
        }
    }
}
