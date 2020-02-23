using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;





namespace AllPayC
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            
            
            Repaint();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CloseWindow(object sender, EventArgs e)
        {
            this.Close();
        }


        // Line 1 (1 to 5)
        private void b1_Click(object sender, EventArgs e)
        {

            check_b1();
            check_b2();
            check_b6();
            check_end();

        }

        private void b2_Click(object sender, EventArgs e)
        {
            check_b2();
            check_b1();
            check_b3();
            check_b7();
            check_end();

        }

        private void b3_Click(object sender, EventArgs e)
        {
            check_b3();
            check_b2();
            check_b4();
            check_b8();
            check_end();

        }

        private void b4_Click(object sender, EventArgs e)
        {
            check_b4();
            check_b3();
            check_b5();
            check_b10();
            check_end();

        }

        private void b5_Click(object sender, EventArgs e)
        {
            check_b5();
            check_b4();
            check_b10();
            check_end();
        }


        // Line 2 (6 to 10)
        private void b6_Click(object sender, EventArgs e)
        {

            check_b6();
            check_b1();
            check_b7();
            check_b11();
            check_end();
        }

        private void b7_Click(object sender, EventArgs e)
        {

            check_b7();
            check_b2();
            check_b6();
            check_b8();
            check_b12();
            check_end();
        }

        private void b8_Click(object sender, EventArgs e)
        {

            check_b8();
            check_b3();
            check_b7();
            check_b9();
            check_b13();
            check_end();
        }

        private void b9_Click(object sender, EventArgs e)
        {

            check_b9();
            check_b4();
            check_b8();
            check_b10();
            check_b14();
            check_end();
        }

        private void b10_Click(object sender, EventArgs e)
        {

            check_b10();
            check_b5();
            check_b9();
            check_b15();
            check_end();
        }

        // Line 3 (11 to 15)
        private void b11_Click(object sender, EventArgs e)
        {

            check_b11();
            check_b6();
            check_b12();
            check_b16();
            check_end();
        }

        private void b12_Click(object sender, EventArgs e)
        {
            check_b12();
            check_b7();
            check_b11();
            check_b13();
            check_b17();
            check_end();
        }

        private void b13_Click(object sender, EventArgs e)
        {
            check_b13();
            check_b8();
            check_b12();
            check_b14();
            check_b18();
            check_end();
        }

        private void b14_Click(object sender, EventArgs e)
        {
            check_b14();
            check_b9();
            check_b13();
            check_b15();
            check_b19();
            check_end();

        }

        private void b15_Click(object sender, EventArgs e)
        {
            check_b15();
            check_b10();
            check_b14();
            check_b20();
            check_end();
        }


        // Line 4 (16 to 20)
        private void b16_Click(object sender, EventArgs e)
        {

            check_b16();
            check_b11();
            check_b17();
            check_b21();
            check_end();
        }

        private void b17_Click(object sender, EventArgs e)
        {

            check_b17();
            check_b12();
            check_b16();
            check_b18();
            check_b22();
            check_end();
        }

        private void b18_Click(object sender, EventArgs e)
        {

            check_b18();
            check_b13();
            check_b17();
            check_b19();
            check_b23();
            check_end();
        }

        private void b19_Click(object sender, EventArgs e)
        {

            check_b19();
            check_b14();
            check_b18();
            check_b20();
            check_b24();
            check_end();
        }

        private void b20_Click(object sender, EventArgs e)
        {

            check_b20();
            check_b15();
            check_b19();
            check_b25();
            check_end();
        }

      
        // Line 5 (21 to 25)
        private void b21_Click(object sender, EventArgs e)
        {

            check_b21();
            check_b16();
            check_b22();
            check_end();
        }

        private void b22_Click(object sender, EventArgs e)
        {
            check_b22();
            check_b17();
            check_b21();
            check_b23();
            check_end();
        }

        private void b23_Click(object sender, EventArgs e)
        {
            check_b23();
            check_b18();
            check_b22();
            check_b24();
            check_end();
        }

        private void b24_Click(object sender, EventArgs e)
        {
            check_b24();
            check_b19();
            check_b23();
            check_b25();
            check_end();
        }

        private void b25_Click(object sender, EventArgs e)
        {
            check_b25();
            check_b20();
            check_b24();
            check_end();
        }




        private void check_end()
        {
            // check if no green
            int vQtyToEnd = 0;
            if (b1.BackColor == Color.Green)
            {
                vQtyToEnd += 1;
            }
            if (b2.BackColor == Color.Green)
            {
                vQtyToEnd+= 1;
            }
            if (b3.BackColor == Color.Green)
            {
                vQtyToEnd+= 1;
            }
            if (b4.BackColor == Color.Green)
            {
                vQtyToEnd+= 1;
            }
            if (b5.BackColor == Color.Green)
            {
                vQtyToEnd+= 1;
            }
            if (b6.BackColor == Color.Green)
            {
                vQtyToEnd+= 1;
            }
            if (b7.BackColor == Color.Green)
            {
                vQtyToEnd+= 1;
            }
            if (b8.BackColor == Color.Green)
            {
                vQtyToEnd+= 1;
            }
            if (b9.BackColor == Color.Green)
            {
                vQtyToEnd+= 1;
            }
            if (b10.BackColor == Color.Green)
            {
                vQtyToEnd+= 1;
            }
            if (b11.BackColor == Color.Green)
            {
                vQtyToEnd+= 1;
            }
            if (b12.BackColor == Color.Green)
            {
                vQtyToEnd+= 1;
            }
            if (b13.BackColor == Color.Green)
            {
                vQtyToEnd+= 1;
            }
            if (b14.BackColor == Color.Green)
            {
                vQtyToEnd+= 1;
            }
            if (b15.BackColor == Color.Green)
            {
                vQtyToEnd+= 1;
            }
            if (b16.BackColor == Color.Green)
            {
                vQtyToEnd+= 1;
            }
            if (b17.BackColor == Color.Green)
            {
                vQtyToEnd+= 1;
            }
            if (b18.BackColor == Color.Green)
            {
                vQtyToEnd+= 1;
            }
            if (b19.BackColor == Color.Green)
            {
                vQtyToEnd+= 1;
            }
            if (b20.BackColor == Color.Green)
            {
                vQtyToEnd+= 1;
            }
            if (b21.BackColor == Color.Green)
            {
                vQtyToEnd+= 1;
            }
            if (b22.BackColor == Color.Green)
            {
                vQtyToEnd+= 1;
            }
            if (b23.BackColor == Color.Green)
            {
                vQtyToEnd+= 1;
            }
            if (b24.BackColor == Color.Green)
            {
                vQtyToEnd+= 1;
            }
            if (b25.BackColor == Color.Green)
            {
                vQtyToEnd += 1;
            }

            QtyToEnd.Text = vQtyToEnd.ToString();

            if (vQtyToEnd == 0)
            {
                
                string message = "Congratulations you won... play again?";
                string caption = "Game Over";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;

                
                result = MessageBox.Show(message, caption, buttons);
                if (result == System.Windows.Forms.DialogResult.No)
                {
                    
                    this.Close();
                }
                else
                {
                    Repaint();
                }
            }
            
        }

        public void Repaint()
        {
            b1.BackColor = Color.LightGray;
            b2.BackColor = Color.LightGray;
            b3.BackColor = Color.LightGray;
            b4.BackColor = Color.LightGray;
            b5.BackColor = Color.LightGray;

            b6.BackColor = Color.LightGray;
            b7.BackColor = Color.LightGray;
            b8.BackColor = Color.LightGray;
            b9.BackColor = Color.LightGray;
            b10.BackColor = Color.LightGray;

            b11.BackColor = Color.LightGray;
            b12.BackColor = Color.LightGray;
            b13.BackColor = Color.LightGray;
            b14.BackColor = Color.LightGray;
            b15.BackColor = Color.LightGray;

            b16.BackColor = Color.LightGray;
            b17.BackColor = Color.LightGray;
            b18.BackColor = Color.LightGray;
            b19.BackColor = Color.LightGray;
            b20.BackColor = Color.LightGray;

            b21.BackColor = Color.LightGray;
            b22.BackColor = Color.LightGray;
            b23.BackColor = Color.LightGray;
            b24.BackColor = Color.LightGray;
            b25.BackColor = Color.LightGray;

            // * randomise initial block
            {
                int b = RandomNumber(1, 25);

                if (b == 1)
                {
                    b1.BackColor = Color.Green;
                }
                else if (b == 2)
                {
                    b2.BackColor = Color.Green;
                }
                else if (b == 3)
                {
                    b3.BackColor = Color.Green;
                }
                else if (b == 4)
                {
                    b4.BackColor = Color.Green;
                }
                else if (b == 5)
                {
                    b5.BackColor = Color.Green;
                }
                else if (b == 6)
                {
                    b6.BackColor = Color.Green;
                }
                else if (b == 7)
                {
                    b7.BackColor = Color.Green;
                }
                else if (b == 8)
                {
                    b8.BackColor = Color.Green;
                }
                else if (b == 9)
                {
                    b9.BackColor = Color.Green;
                }
                else if (b == 10)
                {
                    b10.BackColor = Color.Green;
                }
                else if (b == 11)
                {
                    b11.BackColor = Color.Green;
                }
                else if (b == 12)
                {
                    b12.BackColor = Color.Green;
                }
                else if (b == 13)
                {
                    b13.BackColor = Color.Green;
                }
                else if (b == 14)
                {
                    b14.BackColor = Color.Green;
                }
                else if (b == 15)
                {
                    b15.BackColor = Color.Green;
                }
                else if (b == 16)
                {
                    b16.BackColor = Color.Green;
                }
                else if (b == 17)
                {
                    b17.BackColor = Color.Green;
                }
                else if (b == 18)
                {
                    b18.BackColor = Color.Green;
                }
                else if (b == 19)
                {
                    b19.BackColor = Color.Green;
                }
                else if (b == 20)
                {
                    b20.BackColor = Color.Green;
                }
                else if (b == 21)
                {
                    b21.BackColor = Color.Green;
                }
                else if (b == 22)
                {
                    b22.BackColor = Color.Green;
                }
                else if (b == 23)
                {
                    b23.BackColor = Color.Green;
                }
                else if (b == 24)
                {
                    b24.BackColor = Color.Green;
                }
                else if (b == 25)
                {
                    b25.BackColor = Color.Green;
                }
            }

            check_end();
        }

        private void button98_Click(object sender, EventArgs e)
        {
            Repaint();
        }

        public int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }


        // each button control
        private void check_b1()
        {
            if (b1.BackColor == Color.LightGray)
            {
                b1.BackColor = Color.Green;
            }
            else
            {
                b1.BackColor = Color.LightGray;
            }
        }

        private void check_b2()
        {
            if (b2.BackColor == Color.LightGray)
            {
                b2.BackColor = Color.Green;
            }
            else
            {
                b2.BackColor = Color.LightGray;
            }
        }

        private void check_b3()
        {
            if (b3.BackColor == Color.LightGray)
            {
                b3.BackColor = Color.Green;
            }
            else
            {
                b3.BackColor = Color.LightGray;
            }
        }

        private void check_b4()
        {
            if (b4.BackColor == Color.LightGray)
            {
                b4.BackColor = Color.Green;
            }
            else
            {
                b4.BackColor = Color.LightGray;
            }
        }

        private void check_b5()
        {
            if (b5.BackColor == Color.LightGray)
            {
                b5.BackColor = Color.Green;
            }
            else
            {
                b5.BackColor = Color.LightGray;
            }
        }

        private void check_b6()
        {
            if (b6.BackColor == Color.LightGray)
            {
                b6.BackColor = Color.Green;
            }
            else
            {
                b6.BackColor = Color.LightGray;
            }
        }

        private void check_b7()
        {
            if (b7.BackColor == Color.LightGray)
            {
                b7.BackColor = Color.Green;
            }
            else
            {
                b7.BackColor = Color.LightGray;
            }
        }

        private void check_b8()
        {
            if (b8.BackColor == Color.LightGray)
            {
                b8.BackColor = Color.Green;
            }
            else
            {
                b8.BackColor = Color.LightGray;
            }
        }

        private void check_b9()
        {
            if (b9.BackColor == Color.LightGray)
            {
                b9.BackColor = Color.Green;
            }
            else
            {
                b9.BackColor = Color.LightGray;
            }
        }

        private void check_b10()
        {
            if (b10.BackColor == Color.LightGray)
            {
                b10.BackColor = Color.Green;
            }
            else
            {
                b10.BackColor = Color.LightGray;
            }
        }

        private void check_b11()
        {
            if (b11.BackColor == Color.LightGray)
            {
                b11.BackColor = Color.Green;
            }
            else
            {
                b11.BackColor = Color.LightGray;
            }
        }

        private void check_b12()
        {
            if (b12.BackColor == Color.LightGray)
            {
                b12.BackColor = Color.Green;
            }
            else
            {
                b12.BackColor = Color.LightGray;
            }
        }

        private void check_b13()
        {
            if (b13.BackColor == Color.LightGray)
            {
                b13.BackColor = Color.Green;
            }
            else
            {
                b13.BackColor = Color.LightGray;
            }
        }

        private void check_b14()
        {
            if (b14.BackColor == Color.LightGray)
            {
                b14.BackColor = Color.Green;
            }
            else
            {
                b14.BackColor = Color.LightGray;
            }
        }

        private void check_b15()
        {
            if (b15.BackColor == Color.LightGray)
            {
                b15.BackColor = Color.Green;
            }
            else
            {
                b15.BackColor = Color.LightGray;
            }
        }

        private void check_b16()
        {
            if (b16.BackColor == Color.LightGray)
            {
                b16.BackColor = Color.Green;
            }
            else
            {
                b16.BackColor = Color.LightGray;
            }
        }

        private void check_b17()
        {
            if (b17.BackColor == Color.LightGray)
            {
                b17.BackColor = Color.Green;
            }
            else
            {
                b17.BackColor = Color.LightGray;
            }
        }

        private void check_b18()
        {
            if (b18.BackColor == Color.LightGray)
            {
                b18.BackColor = Color.Green;
            }
            else
            {
                b18.BackColor = Color.LightGray;
            }
        }

        private void check_b19()
        {
            if (b19.BackColor == Color.LightGray)
            {
                b19.BackColor = Color.Green;
            }
            else
            {
                b19.BackColor = Color.LightGray;
            }
        }

        private void check_b20()
        {
            if (b20.BackColor == Color.LightGray)
            {
                b20.BackColor = Color.Green;
            }
            else
            {
                b20.BackColor = Color.LightGray;
            }
        }

        private void check_b21()
        {
            if (b21.BackColor == Color.LightGray)
            {
                b21.BackColor = Color.Green;
            }
            else
            {
                b21.BackColor = Color.LightGray;
            }
        }

        private void check_b22()
        {
            if (b22.BackColor == Color.LightGray)
            {
                b22.BackColor = Color.Green;
            }
            else
            {
                b22.BackColor = Color.LightGray;
            }
        }

        private void check_b23()
        {
            if (b23.BackColor == Color.LightGray)
            {
                b23.BackColor = Color.Green;
            }
            else
            {
                b23.BackColor = Color.LightGray;
            }
        }

        private void check_b24()
        {
            if (b24.BackColor == Color.LightGray)
            {
                b24.BackColor = Color.Green;
            }
            else
            {
                b24.BackColor = Color.LightGray;
            }
        }

        private void check_b25()
        {
            if (b25.BackColor == Color.LightGray)
            {
                b25.BackColor = Color.Green;
            }
            else
            {
                b25.BackColor = Color.LightGray;
            }
        }


    }

    
}

        

