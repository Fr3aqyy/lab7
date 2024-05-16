using System;
using System.Windows.Forms;

namespace calc
{
    public partial class Form1 : Form
    {
        double currentValue = 0;
        string operation = "";

        public Form1()
        {
            InitializeComponent();

            // �������������� ��������� ��� ������� ���������
            MessageBox.Show("����� ���������� � �����������!");
            // ������ �� ���������� ������ ���������
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operation = button.Text;
            currentValue = double.Parse(textBox1.Text);
            textBox1.Text = "";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            textBox1.Text += button.Text;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            textBox1.Text += button.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            textBox1.Text += button.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            textBox1.Text += button.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            textBox1.Text += button.Text;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            textBox1.Text += button.Text;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            textBox1.Text += button.Text;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            textBox1.Text += button.Text;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            textBox1.Text += button.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            currentValue = 0;
            operation = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operation = button.Text;
            currentValue = double.Parse(textBox1.Text);
            textBox1.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operation = button.Text;
            currentValue = double.Parse(textBox1.Text);
            textBox1.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operation = button.Text;
            currentValue = double.Parse(textBox1.Text);
            textBox1.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                double newValue = double.Parse(textBox1.Text);
                double result = 0;
                switch (operation)
                {
                    case "+":
                        result = checked(currentValue + newValue);
                        break;
                    case "-":
                        result = checked(currentValue - newValue);
                        break;
                    case "*":
                        result = checked(currentValue * newValue);
                        break;
                    case "/":
                        if (newValue != 0)
                            result = currentValue / newValue;
                        else
                            throw new DivideByZeroException("������� �� ���� �����������!");
                        break;
                }
                textBox1.Text = result.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("������������ ����!");
            }
            catch (DivideByZeroException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (OverflowException)
            {
                MessageBox.Show("��������� ������� �� ������� ����������� ��������� ��������.");
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("���� �� ������ ���� ������.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("��������� ������: " + ex.Message);
            }
        }


        private void button16_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            textBox1.Text += button.Text;
        }
    }
}