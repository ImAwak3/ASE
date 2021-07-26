using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment1
{
    public partial class Form1 : Form
    {
        int p1 = 0, p2 = 0;
        Graphics g;
        public Form1()
        {
            InitializeComponent();
            g = Canvas.CreateGraphics();
        }
        public void RunProgramMethod()
        {
            String input = CordinateBox.Text;
            Validate v = new Validate();
            String[] val = v.getValidate(input, p1, p2);
            if (val[0] == "moveto")
            {
                int a = Convert.ToInt32(val[1]);
                int b = Convert.ToInt32(val[2]);
                p1 = a;
                p2 = b;
            }
            if (val[0] == "drawto")
            {
                ShapeIdentify s1 = new ShapeIdentify();
                Interface1 sh = s1.getShape(val[0]);
                sh.drawShape(val, g, p1, p2);
            }

            else if (val[0] == "rectangle")
            {
                ShapeIdentify s1 = new ShapeIdentify();
                Interface1 sh = s1.getShape(val[0]);
                sh.drawShape(val, g, p1, p2);
            }
            else if (val[0] == "circle")
            {
                ShapeIdentify s1 = new ShapeIdentify();
                Interface1 sh = s1.getShape(val[0]);
                sh.drawShape(val, g, p1, p2);
            }
            
            else if (val[0] == "triangle")
            {
                ShapeIdentify s1 = new ShapeIdentify();
                Interface1 sh = s1.getShape(val[0]);
                sh.drawShape(val, g, p1, p2);
            }

            else if (val[0] == "error")
            {
                System.Windows.Forms.MessageBox.Show("Error");
            }
            else
            {

            }
        }
        public void MultipleLineMethod()
        {
            int counter = MultipleText.Lines.Length;
            for (int i = 0; i < counter; i++)
            {
                String input = string.Format("text");
                input = MultipleText.Lines[i];
                Validate v = new Validate();
                String[] val = v.getValidate(input, p1, p2);
                if (val[0] == "moveto")
                {
                    int a = Convert.ToInt32(val[1]);
                    int b = Convert.ToInt32(val[2]);
                    p1 = a;
                    p2 = b;
                }
                else if (val[0] == "drawto")
                {
                    ShapeIdentify s1 = new ShapeIdentify();
                    Interface1 sh = s1.getShape(val[0]);
                    sh.drawShape(val, g, p1, p2);
                }

                else if (val[0] == "rectangle")
                {
                    ShapeIdentify s1 = new ShapeIdentify();
                    Interface1 sh = s1.getShape(val[0]);
                    sh.drawShape(val, g, p1, p2);
                }
                else if (val[0] == "circle")
                {
                    ShapeIdentify s1 = new ShapeIdentify();
                    Interface1 sh = s1.getShape(val[0]);
                    sh.drawShape(val, g, p1, p2);
                }

                else if (val[0] == "triangle")
                {
                    ShapeIdentify s1 = new ShapeIdentify();
                    Interface1 sh = s1.getShape(val[0]);
                    sh.drawShape(val, g, p1, p2);
                }
                else if (val[0] == "error")
                {
                    System.Windows.Forms.MessageBox.Show("Please enter valid value");
                }
                else
                {

                }
            }
        }
       

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            MultipleLineMethod();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            RunProgramMethod();
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
           Canvas.Refresh();
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Text Files(*.txt)|*.txt| All Files(*.*)|*.*";
            if(openFile.ShowDialog()== DialogResult.OK)
            {
                StreamReader openStream = new StreamReader(File.OpenRead(openFile.FileName));
                MultipleText.Text = openStream.ReadToEnd();
                openStream.Dispose();
            }
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "Text Files(*.txt)|*.txt| All Files(*.*)|*.*";
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                StreamWriter saveStream = new StreamWriter(File.Create(saveFile.FileName));
                saveStream.Write(MultipleText.Text);
                saveStream.Dispose();
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            p1 = 0;
            p2 = 0;
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
