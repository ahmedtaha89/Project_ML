using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace decetion_making
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void button1_Click(object sender, EventArgs e)
        {

            int text_1 = Convert.ToInt32(textBox1.Text);
            int text_2 = Convert.ToInt32(textBox9.Text);
            int text_3 = Convert.ToInt32(textBox8.Text);
            int text_4 = Convert.ToInt32(textBox7.Text);
            int text_5 = Convert.ToInt32(textBox6.Text);
            int text_6 = Convert.ToInt32(textBox5.Text);
            int text_7 = Convert.ToInt32(textBox4.Text);
            int text_8 = Convert.ToInt32(textBox3.Text);
            int text_9 = Convert.ToInt32(textBox2.Text);





            if (text_1 > text_2 && text_1 > text_3)
            {
                label17.Text = text_1.ToString();
            }
            else if (text_2 > text_1 && text_2 > text_3)
            {
                label17.Text = text_2.ToString();

            }
            else if (text_3 > text_1 && text_3 > text_2)
            {
                label17.Text = text_3.ToString();

            }
            ////////////////////////////////////////////////////////////////////////////
            if (text_4 > text_5 && text_4 > text_6)
            {
                label16.Text = text_4.ToString();
            }
            else if (text_5 > text_4 && text_5 > text_6)
            {
                label16.Text = text_5.ToString();

            }
            else if (text_6 > text_4 && text_6 > text_5)
            {
                label16.Text = text_6.ToString();

            }
            /////////////////////////////////////////////////////////////
            if (text_7 > text_8 && text_7 > text_9)
            {
                label15.Text = text_7.ToString();
            }
            else if (text_8 > text_7 && text_8 > text_9)
            {
                label15.Text = text_8.ToString();

            }
            else if (text_9 > text_7 && text_9 > text_8)
            {
                label15.Text = text_9.ToString();

            }


        }

        private void button5_Click(object sender, EventArgs e)
        {
            int la_1 = Convert.ToInt32(label17.Text);
            int la_2 = Convert.ToInt32(label16.Text);
            int la_3 = Convert.ToInt32(label15.Text);

            if (la_1 > la_2 && la_1 > la_3)
            {
                label9.Text = la_1.ToString();
            }
            else if (la_2 > la_1 && la_2 > la_3)
            {
                label9.Text = la_2.ToString();
            }
            else if (la_3 > la_2 && la_3 > la_1)
            {
                label9.Text = la_3.ToString();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int text_1 = Convert.ToInt32(textBox1.Text);
            int text_2 = Convert.ToInt32(textBox9.Text);
            int text_3 = Convert.ToInt32(textBox8.Text);
            int text_4 = Convert.ToInt32(textBox7.Text);
            int text_5 = Convert.ToInt32(textBox6.Text);
            int text_6 = Convert.ToInt32(textBox5.Text);
            int text_7 = Convert.ToInt32(textBox4.Text);
            int text_8 = Convert.ToInt32(textBox3.Text);
            int text_9 = Convert.ToInt32(textBox2.Text);

            if (text_1 < text_2 && text_1 < text_3)
            {
                label14.Text = text_1.ToString();
            }
            else if (text_2 < text_1 && text_2 < text_3)
            {
                label14.Text = text_2.ToString();

            }
            else if (text_3 < text_1 && text_3 < text_2)
            {
                label14.Text = text_3.ToString();

            }
            ////////////////////////////////////////////////////////////////////////////
            if (text_4 < text_5 && text_4 < text_6)
            {
                label13.Text = text_4.ToString();
            }
            else if (text_5 < text_4 && text_5 < text_6)
            {
                label13.Text = text_5.ToString();

            }
            else if (text_6 < text_4 && text_6 < text_5)
            {
                label13.Text = text_6.ToString();

            }
            /////////////////////////////////////////////////////////////
            if (text_7 < text_8 && text_7 < text_9)
            {
                label12.Text = text_7.ToString();
            }
            else if (text_8 < text_7 && text_8 < text_9)
            {
                label12.Text = text_8.ToString();

            }
            else if (text_9 < text_7 && text_9 < text_8)
            {
                label12.Text = text_9.ToString();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int la_1 = Convert.ToInt32(label14.Text);
            int la_2 = Convert.ToInt32(label13.Text);
            int la_3 = Convert.ToInt32(label12.Text);

            if (la_1 > la_2 && la_1 > la_3)
            {
                label8.Text = la_1.ToString();
            }
            else if (la_2 > la_1 && la_2 > la_3)
            {
                label8.Text = la_2.ToString();
            }
            else if (la_3 > la_2 && la_3 > la_1)
            {
                label8.Text = la_3.ToString();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
        



        }



        private void button8_Click(object sender, EventArgs e)
        {
            
        }

        private void button9_Click(object sender, EventArgs e)
        {







        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {

        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            try
            {
                int tex_1= Convert.ToInt32(textBox1.Text);
                int tex_7 = Convert.ToInt32(textBox7.Text);
                int tex_4 = Convert.ToInt32(textBox4.Text);
                /////////////////////////////////////////
                int tex_2 = Convert.ToInt32(textBox9.Text);
                int tex_5 = Convert.ToInt32(textBox6.Text);
                int tex_8 = Convert.ToInt32(textBox3.Text);
                ////////////////////////////////////////////
                int tex_3 = Convert.ToInt32(textBox8.Text);
                int tex_6 = Convert.ToInt32(textBox5.Text);
                int tex_9 = Convert.ToInt32(textBox2.Text);




                if (tex_1 > tex_4 && tex_1 > tex_7)
                {
                    label10.Text =(tex_1).ToString();

                }
                else if (tex_4 > tex_1 && tex_4 > tex_7)
                {
                    label10.Text = (tex_4).ToString();
                }
                else if (tex_7 > tex_1 && tex_7 > tex_4)
                {
                    label10.Text = (tex_7).ToString();
                }
                /////////////////////////////////////////////////////

                if (tex_2 > tex_5 && tex_2 > tex_8)
                {
                    label11.Text = (tex_2).ToString();
                }
                else if (tex_5 > tex_2 && tex_5 > tex_8)
                {
                    label11.Text = (tex_5).ToString();
                }
                else if (tex_8 > tex_2 && tex_8 > tex_5)
                {
                    label11.Text = (tex_8).ToString();
                }
                //////////////////////////////////////////////////////


                if (tex_3 > tex_6 && tex_3 > tex_9)
                {
                    label18.Text = (tex_3).ToString();
                }
                else if (tex_6 > tex_3 && tex_6 > tex_9)
                {
                    label18.Text = (tex_6).ToString();
                }
                else if (tex_9 > tex_3 && tex_9 > tex_6)
                {
                    label18.Text = (tex_9).ToString();
                }






            }
            catch
            {

            }
        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            try
            {
                int la_10 = Convert.ToInt32(label10.Text);
                int la_11 = Convert.ToInt32(label11.Text);
                int la_18 = Convert.ToInt32(label18.Text);

                if (la_10 < la_11 && la_10 < la_18)
                {
                    label7.Text = (la_10).ToString();
                }
                else if (la_11 < la_10 && la_11 < la_18)
                {
                    label7.Text = (la_11).ToString();
                }
                else if (la_18 < la_10 && la_18 < la_11)
                {
                    label7.Text = (la_18).ToString();
                }
            }

            catch
            {

            }
            
        }
    }
}
