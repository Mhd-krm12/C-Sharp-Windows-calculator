using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp9
{
    public partial class Form1 : Form
    {

        bool optCase = false; 
        double result = 0;
        string opt = "";
        double square_root;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void numberClick(object sender, EventArgs e)
        {
            
            if (textBox3.Text == "0" || optCase) //baştaki var olan 0 bir rakam yazıdığımızda silinsin <|| //operatora tıkladığımızda mevcut rakam silinsin
                textBox3.Clear();  
            optCase = false; // mevcut rakamı sil
            Button btn = (Button)sender; 
            textBox3.Text = textBox3.Text + btn.Text; // buttonun ismini textBoxte yazsın



        }

        private void optClick(object sender, EventArgs e)
        {
         
            optCase = true;
            
            Button btn = (Button)sender;
            string newOpt = btn.Text;
            label1.Text = label1.Text + " " + textBox3.Text + " " + newOpt;

            switch (opt)
            {
                case "+":
                    textBox3.Text = (result + Double.Parse(textBox3.Text)).ToString();
                    break;
                case "-":
                    textBox3.Text = (result - Double.Parse(textBox3.Text)).ToString();
                    break;
                case "×":
                    textBox3.Text = (result * Double.Parse(textBox3.Text)).ToString();
                    break;
                case "÷":
                    textBox3.Text = (result / Double.Parse(textBox3.Text)).ToString();
                    break;
            }
            result = Double.Parse(textBox3.Text);
            textBox3.Text = result.ToString();
            opt = newOpt;
            
            

        }

        private void click(object sender, EventArgs e)
        {

            label1.Text = "";
            optCase = true;
            switch (opt)
            {
                case "+":
                    textBox3.Text = (result + Double.Parse(textBox3.Text)).ToString();
                    break;
                case "-": textBox3.Text = (result - Double.Parse(textBox3.Text)).ToString(); break;
                case "×": textBox3.Text = (result * Double.Parse(textBox3.Text)).ToString(); break;
                case "÷": textBox3.Text = (result / Double.Parse(textBox3.Text)).ToString(); break;
            }
            result = Double.Parse(textBox3.Text);
            textBox3.Text = result.ToString();
            opt = "";

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox3.Text = "0";

        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox3.Text = "0";
            label1.Text = "";
            opt = "";
            result = 0;
            optCase = false;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            

        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            if (textBox3.Text == "0")
            {
                textBox3.Text = "0"; // virgulden önce sıfır eklesin diye
            }
            else if (optCase)
            {
                textBox3.Text = "0";
            }

            if (!textBox3.Text.Contains(",")) // sartın amacı virgulu tekrar etmesin
            {
                textBox3.Text += ","; //buttomun amacı
            }
            
            optCase = false;

        }

        private void button12_Click(object sender, EventArgs e)
        {

            // +/- butomu
            if (textBox3.Text != "0")      // rakamın sıfır olmama şartı
            {
                if (textBox3.Text.StartsWith("-"))
                {
                    textBox3.Text = textBox3.Text.Replace("-", "");
                }
                else if (textBox3.Text.StartsWith(""))
                {
                    textBox3.Text = "-" + textBox3.Text;
                }
            }

        }

        private void button19_Click(object sender, EventArgs e)
        {
            result = Convert.ToDouble(textBox3.Text);
            if (result >= 0 )
            {

                square_root = Math.Sqrt((double)result);
                textBox3.Text = square_root.ToString();
            }
        }
    }
}
