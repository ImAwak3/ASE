using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment1
{
    public class Validate
    {
        public string[] getValidate(string a, int temp1, int temp2)
        {

            string[] txt = { }; //for getting the text from input
            string[] send = a.Split(',', ' ');

            {
                if (send[0].ToUpper() == "MOVETO")
                {
                    if (send.Length < 4)
                    {
                        int x = Convert.ToInt32(send[1]);
                        int y = Convert.ToInt32(send[2]);
                        string a1 = Convert.ToString(x);
                        string b1 = Convert.ToString(y);
                        string[] k = { "moveto", a1, b1 };
                        txt = k;
                    }
                }
                else
                {
                    if (send[0].ToUpper() == "DRAWTO")
                    {
                        if (send.Length == 3)
                        {
                            int x = Convert.ToInt32(send[1]);
                            int y = Convert.ToInt32(send[2]);
                            string a1 = Convert.ToString(x);
                            string b1 = Convert.ToString(y);
                            string[] k = { "drawto", a1, b1 };
                            txt = k;
                        }
                        else
                        {
                            System.Windows.Forms.MessageBox.Show("Please check the format of moveto");
                            string[] n = { "123" };
                            txt = n;
                        }
                    }
                    else if (send[0].ToUpper() == "RECTANGLE")
                    {
                        if (send.Length ==3)
                        {
                            int x = Convert.ToInt32(send[1]);
                            int y = Convert.ToInt32(send[2]);
                            string a1 = Convert.ToString(x);
                            string b1 = Convert.ToString(y);
                            string[] k = { "rectangle", a1, b1 };
                            txt = k;

                        }
                        else
                        {
                            System.Windows.Forms.MessageBox.Show("Please input correct value for Rectangle");
                            string[] n = { "123" };
                            txt = n;
                        }
                    }


                    else if (send[0].ToUpper() == "CIRCLE")
                    {
                        if (send.Length ==2)
                        {
                            int x = Convert.ToInt32(send[1]);
                            string a1 = Convert.ToString(x * 2);
                            string[] k = { "circle", a1 };
                            txt = k;
                        }
                        else
                        {
                            System.Windows.Forms.MessageBox.Show("Please input correct value for Circle");
                            string[] n = { "123" };
                            txt = n;
                        }
                    }


                    else if (send[0].ToUpper() == "TRIANGLE")
                    {
                        if (send.Length ==4)
                        {

                            int x = Convert.ToInt32(send[1]);
                            int y = Convert.ToInt32(send[2]);
                            int z = Convert.ToInt32(send[3]);
                            string a1 = Convert.ToString(x);
                            string b1 = Convert.ToString(y);
                            string c1 = Convert.ToString(z);
                            string[] k = { "triangle", a1, b1, c1 };
                            txt = k;

                        }
                        else
                        {
                            System.Windows.Forms.MessageBox.Show("Please input correct value for Triangle");
                            string[] n = { "123" };
                            txt = n;
                        }
                    }
                    else
                    {
                        string[] k = { "error" };
                        txt = k;
                    }
                }


                return txt;
            }
        }

        internal string[] getValidate(TextBox runtextbox)
        {
            throw new NotImplementedException();
        }
    }
}
