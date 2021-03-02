using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora
{
   public partial class Form1 : Form
   {
      private TextBox txtBoxSelected;
      private Calculo calculo = new Calculo();

      public Form1()
      {
         InitializeComponent();
         txtBoxSelected = textBoxNumber1;
         textBoxNumber1.Focus();
      }

      #region Buttons Numbers

      private void button0_Click(object sender, EventArgs e)
      {
         txtBoxSelected.Text += "0";
      }

      private void button00_Click(object sender, EventArgs e)
      {
         txtBoxSelected.Text += "00";
      }

      private void button1_Click(object sender, EventArgs e)
      {
         txtBoxSelected.Text += "1";
      }

      private void button2_Click(object sender, EventArgs e)
      {
         txtBoxSelected.Text += "2";
      }

      private void button3_Click(object sender, EventArgs e)
      {
         txtBoxSelected.Text += "3";
         txtBoxSelected.Focus();
      }

      private void button4_Click(object sender, EventArgs e)
      {
         txtBoxSelected.Text += "4";
         txtBoxSelected.Focus();
      }

      private void button5_Click(object sender, EventArgs e)
      {
         txtBoxSelected.Text += "5";
         txtBoxSelected.Focus();
      }

      private void button6_Click(object sender, EventArgs e)
      {
         txtBoxSelected.Text += "6";
         txtBoxSelected.Focus();
      }

      private void button7_Click(object sender, EventArgs e)
      {
         txtBoxSelected.Text += "7";
         txtBoxSelected.Focus();
      }

      private void button8_Click(object sender, EventArgs e)
      {
         txtBoxSelected.Text += "8";
         txtBoxSelected.Focus();
      }

      private void button9_Click(object sender, EventArgs e)
      {
         txtBoxSelected.Text += "9";
         txtBoxSelected.Focus();
      }
      #endregion

      private void textBoxNumber1_Click(object sender, EventArgs e)
      {
         txtBoxSelected = textBoxNumber1;
      }

      private void textBoxNumber2_Click(object sender, EventArgs e)
      {
         txtBoxSelected = textBoxNumber2;
      }

      private void buttonPoint_Click(object sender, EventArgs e)
      {
         txtBoxSelected.Text += ",";
      }

      #region Calculations
      private void buttonPlus_Click(object sender, EventArgs e)
      {
         if (textBoxNumber1.Text.Equals("") || textBoxNumber2.Text.Equals(""))
         {
            return;
         }
         float n1 = (float) Convert.ToDouble(textBoxNumber1.Text);
         float n2 = (float)Convert.ToDouble(textBoxNumber2.Text);

         float result = calculo.Add(n1, n2);

         labelResult.Text = result.ToString();
         labelLastOperation.Text = n1 + " + " + n2 + " = " + result;
      }

      private void buttonMin_Click(object sender, EventArgs e)
      {
         if (textBoxNumber1.Text.Equals("") || textBoxNumber2.Text.Equals(""))
         {
            return;
         }

         float n1 = (float)Convert.ToDouble(textBoxNumber1.Text);
         float n2 = (float)Convert.ToDouble(textBoxNumber2.Text);

         float result = calculo.Decrease(n1, n2);

         labelResult.Text = result.ToString();
         labelLastOperation.Text = n1 + " - " + n2 + " = " + result;
      }

      private void buttonMultiply_Click(object sender, EventArgs e)
      {
         if (textBoxNumber1.Text.Equals("") || textBoxNumber2.Text.Equals(""))
         {
            return;
         }

         float n1 = (float)Convert.ToDouble(textBoxNumber1.Text);
         float n2 = (float)Convert.ToDouble(textBoxNumber2.Text);

         float result = calculo.Multiply(n1, n2);

         labelResult.Text = result.ToString();
         labelLastOperation.Text = n1 + " x " + n2 + " = " + result;
      }

      private void buttonShare_Click(object sender, EventArgs e)
      {
         if (textBoxNumber1.Text.Equals("") || textBoxNumber2.Text.Equals(""))
         {
            return;
         }

         float n1 = (float)Convert.ToDouble(textBoxNumber1.Text);
         float n2 = (float)Convert.ToDouble(textBoxNumber2.Text);

         float result = calculo.Share(n1, n2);

         labelResult.Text = result.ToString();
         labelLastOperation.Text = n1 + " / " + n2 + " = " + result;
      }
      #endregion

      private void buttonClear_Click(object sender, EventArgs e)
      {
         labelResult.Text = "";
         textBoxNumber1.Text = "";
         textBoxNumber2.Text = "";
         labelLastOperation.Text = "";
      }

      private void buttonClearField_Click(object sender, EventArgs e)
      {
         textBoxNumber1.Text = "";
         textBoxNumber2.Text = "";
      }
   }
}
