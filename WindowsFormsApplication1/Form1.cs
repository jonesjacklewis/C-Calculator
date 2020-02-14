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


namespace WindowsFormsApplication1
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();
        }

        private void txtNum1_TextChanged(object sender, EventArgs e)  // whenever textbox1's value changes
        {
            if (txtNum1.Text.ToLower() == "e")  // If the lowercase value of the conetents of textnumm1 is e
            {
                txtNum1.Text = Convert.ToString(Math.E);  // Convert to Euler's number
            }
            if (txtNum2.Text.ToLower() == "e")  // If the lowercase value of the conetents of textnumm1 is e
            {
                txtNum2.Text = Convert.ToString(Math.E);  // Convert to Euler's number
            }
            if (txtNum1.Text.ToLower() == "pi")  // If the lowercase value of the conetents of textnumm1 is pi
            {
                txtNum1.Text = Convert.ToString(Math.PI);   // Convert to π
            }
            if (txtNum2.Text.ToLower() == "pi")  // If the lowercase value of the conetents of textnumm1 is pi
            {
                txtNum2.Text = Convert.ToString(Math.PI);  // Convert to π

            }



            
            if (txtNum1.Text.ToLower() == "pre")   // If the lowercase value of the conetents of textnumm1 is pre
            {
                string filename = ".//previous.txt";  // sets filename to directory of txt file
                StreamReader sw = new StreamReader(filename);  // sw is new instance of StreamReader
                string previousVal = sw.ReadLine();  // Stores the value stored in the file to the string variable previousVal
                sw.Close();  // Closes this instance of streamwriter
                txtNum1.Text = previousVal;   // Converts pre to the value stored
            }
            if (txtNum2.Text.ToLower() == "pre")  // If the lowercase value of the conetents of textnumm1 is pi
            {
                string filename = ".//previous.txt";  // sets filename to directory of txt file
                StreamReader sw = new StreamReader(filename);  // sw is new instance of StreamReader
                string previousVal = sw.ReadLine();  // Stores the value stored in the file to the string variable previousVal
                sw.Close();  // Closes this instance of streamwriter
                txtNum2.Text = previousVal;   // Converts pre to the value stored
            }

        }

        private void txtNum2_TextChanged(object sender, EventArgs e)// whenever textbox2's value changes
        {
            if (txtNum1.Text.ToLower() == "e")  // If the lowercase value of the conetents of textnumm1 is e
            {
                txtNum1.Text = Convert.ToString(Math.E);  // Convert to Euler's number
            }
            if (txtNum2.Text.ToLower() == "e")  // If the lowercase value of the conetents of textnumm1 is e
            {
                txtNum2.Text = Convert.ToString(Math.E);  // Convert to Euler's number
            }
            if (txtNum1.Text.ToLower() == "pi")  // If the lowercase value of the conetents of textnumm1 is pi
            {
                txtNum1.Text = Convert.ToString(Math.PI);   // Convert to π
            }
            if (txtNum2.Text.ToLower() == "pi")  // If the lowercase value of the conetents of textnumm1 is pi
            {
                txtNum2.Text = Convert.ToString(Math.PI);  // Convert to π
            }



            if (txtNum1.Text.ToLower() == "pre")   // If the lowercase value of the conetents of textnumm1 is pre
            {
                string filename = ".//previous.txt";  // sets filename to directory of txt file
                StreamReader sw = new StreamReader(filename);  // sw is new instance of StreamReader
                string previousVal = sw.ReadLine();  // Stores the value stored in the file to the string variable previousVal
                sw.Close();  // Closes this instance of streamwriter
                txtNum1.Text = previousVal;   // Converts pre to the value stored
            }
            if (txtNum2.Text.ToLower() == "pre")  // If the lowercase value of the conetents of textnumm1 is pi
            {
                string filename = ".//previous.txt";  // sets filename to directory of txt file
                StreamReader sw = new StreamReader(filename);  // sw is new instance of StreamReader
                string previousVal = sw.ReadLine();  // Stores the value stored in the file to the string variable previousVal
                sw.Close();  // Closes this instance of streamwriter
                txtNum2.Text = previousVal;   // Converts pre to the value stored
            }

        }

        private void Form1_Load(object sender, EventArgs e)   // on load
        {
            string filename = ".//previous.txt";  // Assings the variable filename to the directory
            if (!(File.Exists(filename))){  // If the file doesn't exist
                StreamWriter sw =new StreamWriter(filename, true);  // Create an instant of the streamwriter class
                sw.WriteLine("");  // Writes blank line
                sw.Close();  // Close the instance

            }


          


        }

        private void btnCalc_Click(object sender, EventArgs e)  // When the calculate button is clicked
        {

            if (cmbFunction.Text == "num1+num2")
            {
                try
                {
                    LblResult.Text = Convert.ToString(Convert.ToDouble(txtNum1.Text) + Convert.ToDouble(txtNum2.Text));
                }
                catch
                {
                    LblResult.Text = "Maths Error";
                }

            }
            else if (cmbFunction.Text == "num1-num2")
            {
                try
                {
                    LblResult.Text = Convert.ToString(Convert.ToDouble(txtNum1.Text) - Convert.ToDouble(txtNum2.Text));
                }
                catch
                {
                    LblResult.Text = "Maths Error";
                }
            }
            else if (cmbFunction.Text == "num1*num2")
            {
                try
                {
                    LblResult.Text = Convert.ToString(Convert.ToDouble(txtNum1.Text) * Convert.ToDouble(txtNum2.Text));
                }
                catch
                {
                    LblResult.Text = "Maths Error";
                }
            }
            else if (cmbFunction.Text == "num1÷num2")
            {
                try
                {
                    LblResult.Text = Convert.ToString(Convert.ToDouble(txtNum1.Text) / Convert.ToDouble(txtNum2.Text));
                }
                catch
                {
                    LblResult.Text = "Math Error";
                }
            }
            else if (cmbFunction.Text == "num1 Mod num2")
            {
                try
                {
                    LblResult.Text = Convert.ToString(Convert.ToDouble(txtNum1.Text) % Convert.ToDouble(txtNum2.Text));
                }
                catch
                {
                    LblResult.Text = "Math Error";
                }
            }
            else if (cmbFunction.Text == "√(num2)")
            {
                if (txtNum1.Text == "" && !(txtNum2.Text == ""))
                {
                    try
                    {
                        LblResult.Text = Convert.ToString(Math.Sqrt(Convert.ToDouble(txtNum2.Text)));
                    }
                    catch
                    {
                        LblResult.Text = "Maths Error";
                    }
                }
                else if (txtNum2.Text == "" && !(txtNum1.Text == ""))
                {
                    try
                    {
                        LblResult.Text = Convert.ToString(Math.Sqrt(Convert.ToDouble(txtNum1.Text)));
                    }
                    catch
                    {
                        LblResult.Text = "Maths Error";
                    }
                }
                else
                {
                    LblResult.Text = "Maths Error";
                }

            }
            else if (cmbFunction.Text == "Sin(num)")
            {
                if (txtNum1.Text == "" && !(txtNum2.Text == ""))
                {
                    try
                    {
                        double degval = Convert.ToDouble(txtNum2.Text);
                        double radval = (degval * Math.PI) / 180;
                        double ang = Math.Sin(radval);
                        LblResult.Text = Convert.ToString(ang);
                    }
                    catch
                    {
                        LblResult.Text = "Maths Error";
                    }
                }
                else if (txtNum2.Text == "" && !(txtNum1.Text == ""))
                {
                    try
                    {
                        double degval = Convert.ToDouble(txtNum1.Text);
                        double radval = (degval * Math.PI) / 180;
                        double ang = Math.Sin(radval);
                        LblResult.Text = Convert.ToString(ang);
                    }
                    catch
                    {
                        LblResult.Text = "Maths Error";
                    }
                }
                else
                {
                    LblResult.Text = "Maths Error";
                }

            }
            else if (cmbFunction.Text == "Cos(num)")
            {
                if (txtNum1.Text == "" && !(txtNum2.Text == ""))
                {
                    try
                    {
                        double degval = Convert.ToDouble(txtNum2.Text);
                        double radval = (degval * Math.PI) / 180;
                        double ang = Math.Cos(radval);
                        LblResult.Text = Convert.ToString(ang);
                    }
                    catch
                    {
                        LblResult.Text = "Maths Error";
                    }
                }
                else if (txtNum2.Text == "" && !(txtNum1.Text == ""))
                {
                    try
                    {
                        double degval = Convert.ToDouble(txtNum1.Text);
                        double radval = (degval * Math.PI) / 180;
                        double ang = Math.Cos(radval);
                        LblResult.Text = Convert.ToString(ang);
                    }
                    catch
                    {
                        LblResult.Text = "Maths Error";
                    }
                }
                else
                {
                    LblResult.Text = "Maths Error";
                }
            }
            else if (cmbFunction.Text == "Tan(num)")
            {
                if (txtNum1.Text == "" && !(txtNum2.Text == ""))
                {
                    try
                    {
                        double degval = Convert.ToDouble(txtNum2.Text);
                        double radval = (degval * Math.PI) / 180;
                        double ang = Math.Tan(radval);
                        LblResult.Text = Convert.ToString(ang);
                    }
                    catch
                    {
                        LblResult.Text = "Maths Error";
                    }
                }
                else if (txtNum2.Text == "" && !(txtNum1.Text == ""))
                {
                    try
                    {
                        double degval = Convert.ToDouble(txtNum1.Text);
                        double radval = (degval * Math.PI) / 180;
                        double ang = Math.Tan(radval);
                        LblResult.Text = Convert.ToString(ang);
                    }
                    catch
                    {
                        LblResult.Text = "Maths Error";
                    }
                }
                else
                {
                    LblResult.Text = "Maths Error";
                }
            }
            else if (cmbFunction.Text == "Log10(num)")
            {
                if (txtNum1.Text == "" && !(txtNum2.Text == ""))
                {
                    try
                    {
                        LblResult.Text = Convert.ToString(Math.Log10(Convert.ToDouble(txtNum2.Text)));
                    }
                    catch
                    {
                        LblResult.Text = "Maths Error";
                    }
                }
                else if (txtNum2.Text == "" && !(txtNum1.Text == ""))
                {
                    try
                    {
                        LblResult.Text = Convert.ToString(Math.Log10(Convert.ToDouble(txtNum1.Text)));
                    }
                    catch
                    {
                        LblResult.Text = "Maths Error";
                    }
                }
                else
                {
                    LblResult.Text = "Maths Error";
                }

            }
            else if (cmbFunction.Text == "ln(num)")
            {
                if (txtNum1.Text == "" && !(txtNum2.Text == ""))
                {
                    try
                    {
                        LblResult.Text = Convert.ToString(Math.Log(Convert.ToDouble(txtNum2.Text)));
                    }
                    catch
                    {
                        LblResult.Text = "Maths Error";
                    }
                }
                else if (txtNum2.Text == "" && !(txtNum1.Text == ""))
                {
                    try
                    {
                        LblResult.Text = Convert.ToString(Math.Log(Convert.ToDouble(txtNum1.Text)));
                    }
                    catch
                    {
                        LblResult.Text = "Maths Error";
                    }
                }
                else
                {
                    LblResult.Text = "Maths Error";
                }


            }
            else if (cmbFunction.Text == "num! (Factorial)")
            {
                if (txtNum1.Text == "" && !(txtNum2.Text == ""))
                {
                    try
                    {
                        LblResult.Text = Convert.ToString(Factorial.Fact(Convert.ToInt32(txtNum2.Text)));
                    }
                    catch
                    {
                        LblResult.Text = "Maths Error";
                    }
                }
                else if (txtNum2.Text == "" && !(txtNum1.Text == ""))
                {
                    try
                    {
                        LblResult.Text = Convert.ToString(Factorial.Fact(Convert.ToInt32(txtNum1.Text)));
                    }
                    catch
                    {
                        LblResult.Text = "Maths Error";
                    }
                }
                else
                {
                    LblResult.Text = "Maths Error";
                }


            }

            else if (cmbFunction.Text == "Abs(num)")
            {
                if (txtNum1.Text == "" && !(txtNum2.Text == "") && Convert.ToDouble(txtNum2.Text)<0)
                {
                    try
                    {
                        LblResult.Text = Convert.ToString(-1*(Convert.ToDouble(txtNum2.Text)));
                    }
                    catch
                    {
                        LblResult.Text = "Maths Error";
                    }
                }
                else if (txtNum2.Text == "" && Convert.ToDouble(txtNum1.Text)<0  && !(txtNum1.Text == ""))
                {
                    try
                    {
                        LblResult.Text = Convert.ToString(-1*(Convert.ToDouble(txtNum1.Text)));
                    }
                    catch
                    {
                        LblResult.Text = "Maths Error";
                    }
                }
                else if (txtNum1.Text == "" && !(txtNum2.Text == "") )
                {
                    try
                    {
                        LblResult.Text = Convert.ToString((Convert.ToDouble(txtNum2.Text)));
                    }
                    catch
                    {
                        LblResult.Text = "Maths Error";
                    }
                }
                else if (txtNum2.Text == "" && !(txtNum1.Text == ""))
                {
                    try
                    {
                        LblResult.Text = Convert.ToString((Convert.ToDouble(txtNum1.Text)));
                    }
                    catch
                    {
                        LblResult.Text = "Maths Error";
                    }
                }else
                {
                    LblResult.Text = "Maths Error";
                }
            }
            else if (cmbFunction.Text == "Random")
            {
                try
                {
                    Random r = new Random();
                    LblResult.Text = Convert.ToString(r.Next((Convert.ToInt32(txtNum1.Text)), Convert.ToInt32(txtNum2.Text) + 1));

                }
                catch
                {
                    LblResult.Text = "Maths Error";
                }
            }
            else
            {
                LblResult.Text = "Result";
            }



            }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            string filename = ".//previous.txt";
            StreamWriter sw = new StreamWriter(filename);
            sw.WriteLine(LblResult.Text);
            sw.Close();
        }
    }


    
    }


