using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        bool canAddOperator = true;
        bool isNext = false;
        bool canAddDigital = false;  //默认开始带0
        bool canAddPointSigin = true;
        bool pressResultSigin = false;
        string leftResult;
        char theLastOperator;
        public Calculator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;   // Maxi mize Box    
            leftResult = resultDisplayer.Text; 
        }

        private void button_1_Click(object sender, EventArgs e)
        {
            canAddOperator = true;
            if (canAddDigital)
            {
                if (isNext)
                {
                    isNext = false;
                    resultDisplayer.Clear(); 
                }
                resultDisplayer.Text += "1";
            }
            else
            {
                canAddDigital = true;
                resultDisplayer.Clear();
                resultDisplayer.Text += "1";
            }
           
        }

        private void button_2_Click(object sender, EventArgs e)
        {
            canAddOperator = true;
            if (canAddDigital)
            {
                if (isNext)
                {
                    isNext = false;
                    resultDisplayer.Clear();
                }
                resultDisplayer.Text += "2";
            }
            else
            {
                canAddDigital = true;
                resultDisplayer.Clear();
                resultDisplayer.Text += "2";
            }
        }

        private void button_3_Click(object sender, EventArgs e)
        {
            canAddOperator = true;
            if (canAddDigital)
            {
                if (isNext)
                {
                    isNext = false;
                    resultDisplayer.Clear();
                }
                resultDisplayer.Text += "3";
            }
            else
            {
                canAddDigital = true;
                resultDisplayer.Clear();
                resultDisplayer.Text += "3";
            }
        }

        private void button_4_Click(object sender, EventArgs e)
        {
            canAddOperator = true;
            if (canAddDigital)
            {
                if (isNext)
                {
                    isNext = false;
                    resultDisplayer.Clear();
                }
                resultDisplayer.Text += "4";
            }
            else
            {
                canAddDigital = true;
                resultDisplayer.Clear();
                resultDisplayer.Text += "4";
            }
        }

        private void button_5_Click(object sender, EventArgs e)
        {
            canAddOperator = true;
            if (canAddDigital)
            {
                if (isNext)
                {
                    isNext = false;
                    resultDisplayer.Clear();
                }
                resultDisplayer.Text += "5";
            }
            else
            {
                canAddDigital = true;
                resultDisplayer.Clear();
                resultDisplayer.Text += "5";
            }
        }

        private void button_6_Click(object sender, EventArgs e)
        {
            canAddOperator = true;
            if (canAddDigital)
            {
                if (isNext)
                {
                    isNext = false;
                    resultDisplayer.Clear();
                }
                resultDisplayer.Text += "6";
            }
            else
            {
                canAddDigital = true;
                resultDisplayer.Clear();
                resultDisplayer.Text += "5";
            }
        }

        private void button_7_Click(object sender, EventArgs e)
        {
            canAddOperator = true;
            if (canAddDigital)
            {
                if (isNext)
                {
                    isNext = false;
                    resultDisplayer.Clear();
                }
                resultDisplayer.Text += "7";
            }
            else
            {
                canAddDigital = true;
                resultDisplayer.Clear();
                resultDisplayer.Text += "7";
            }
        }

        private void button_8_Click(object sender, EventArgs e)
        {
            canAddOperator = true;
            if (canAddDigital)
            {
                if (isNext)
                {
                    isNext = false;
                    resultDisplayer.Clear();
                }
                resultDisplayer.Text += "8";
            }
            else
            {
                canAddDigital = true;
                resultDisplayer.Clear();
                resultDisplayer.Text += "8";
            }
        }

        private void button_9_Click(object sender, EventArgs e)
        {
            canAddOperator = true;
            if (canAddDigital)
            {
                if (isNext)
                {
                    isNext = false;
                    resultDisplayer.Clear();
                }
                resultDisplayer.Text += "9";
            }
            else
            {
                canAddDigital = true;
                resultDisplayer.Clear();
                resultDisplayer.Text += "9";
            }
        }

        private void button_0_Click(object sender, EventArgs e)
        {
           canAddOperator = true;
            if (canAddDigital)
            {
                canAddDigital = true;
                if (isNext)
                {
                    isNext = false;
                    resultDisplayer.Clear();
                }
                resultDisplayer.Text += "0";
            }
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            if (canAddOperator)
            {
                if (pressResultSigin)
                {
                    leftResult = "0";
                    pressResultSigin = false;
                }
                canAddOperator = false;
                canAddPointSigin = true;
                isNext = true;
                theLastOperator = '+';
                expressionDisplayer.Text += resultDisplayer.Text + "+";
                resultDisplayer.Text = GetResult(leftResult, theLastOperator, resultDisplayer.Text);
                leftResult = resultDisplayer.Text;
            }
        }

        private void button_point_Click(object sender, EventArgs e)
        {
           
            if (canAddPointSigin)
            {
                canAddOperator = true;
                canAddDigital = true;
                canAddPointSigin = false;
                resultDisplayer.Text += ".";
            }
            else
            {
                canAddOperator = true;
                canAddDigital = true;
            }
        }

        private void button_clean_Click(object sender, EventArgs e)
        {
            canAddOperator = true;
            isNext = false;
            canAddDigital = false;  //默认开始带0
            canAddPointSigin = true;
            leftResult = "0";
            expressionDisplayer.Clear();
            resultDisplayer.Clear();
            resultDisplayer.Text = "0";
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            int len = resultDisplayer.Text.Length;
            if(len > 1)
            {
                char theDeleteChar = resultDisplayer.Text[len - 1];
                resultDisplayer.Text = resultDisplayer.Text.Substring(0, len - 1);
                if (theDeleteChar == '.') canAddPointSigin = true;
               
            }
            else
            {
                canAddDigital = false;  //默认开始带0
                resultDisplayer.Text = "0";
            }
        }

        private void button_result_Click(object sender, EventArgs e)
        {
            pressResultSigin = true;
            expressionDisplayer.Clear();
            resultDisplayer.Text = GetResult(leftResult, theLastOperator, resultDisplayer.Text);
            leftResult = resultDisplayer.Text;
        }
        
        //返回操作符对象
        private Tools getOperatorObject(char operator_)
        {
            switch (operator_)
            {
                case '+': return new AddOperator();
                default: return null;
            }
        }
        //根据操作符返回对应结果
        private string GetResult(string A, char operator_, string B)
        {
           return getOperatorObject(operator_).GetResult(Double.Parse(A),Double.Parse(B)).ToString();
        }

        private void button_sub_Click(object sender, EventArgs e)
        {
            // visual studio 2015 提交 测试
        }
    }

    /**
     * 操作符抽象
     * 
     * **/
    public abstract class Tools
    {
        public abstract double GetResult(double A, double B);
    }

    public class AddOperator : Tools
    {
        public override double GetResult(double A, double B)
        {
            return A + B;
        }
    }
    public class SubOperator : Tools
    {
        public override double GetResult(double A, double B)
        {
            return A - B;
        }
    }
}
