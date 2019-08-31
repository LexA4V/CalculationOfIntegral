using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace COTDI
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            int l, t, k; bool a = true, b = true; String str;
            if (textBox1.Text != "")
            {
                str = textBox1.Text;
                l = str.Length;
                //индекс символа, с которым работаем
                t = 0;
                //колличество запятых в строке (дабы избежать варианта 0,2384,1254,1251 – это не число)
                k = 0;
                //двигаем индексатор, если наше число отрицательное
                if (str[t] != '-')
                {
                    //число не может начинаться с запятой
                    if ((str[t] == ',') || (str[t] == '.')) a = false;
                    while (t < l)
                    {
                        if ((str[t] == ',') || (str[t] == '.'))
                        //если запятая стоит последним символом или запятая уже была найдена
                        {
                            if (t == l - 1 || k > 0) a = false;
                            b = false;
                            k++;
                        }
                        //если t-ый символ не лежит в диапазоне от '0' до '9'
                        else if (str[t] < '0' || str[t] > '9') a = false;
                        t++;
                    }
                    if (a == false)
                    {
                        MessageBox.Show("Параметр не является числом!", "Ошибка ввода данных", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        this.textBox1.Focus();
                        this.textBox1.Clear();
                    }
                    else if (b == false)
                    {
                        MessageBox.Show("Параметр не может принимать дробное значение!", "Ошибка ввода данных", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        this.textBox1.Focus();
                        this.textBox1.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Параметр не может принимать отрицательное значение!", "Ошибка ввода данных", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.textBox1.Focus();
                    this.textBox1.Clear();
                }
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            int l, t, k; bool a = true, b = true; String str;
            if (textBox2.Text != "")
            {
                str = textBox2.Text;
                l = str.Length;
                //индекс символа, с которым работаем
                t = 0;
                //колличество запятых в строке (дабы избежать варианта 0,2384,1254,1251 – это не число)
                k = 0;
                //двигаем индексатор, если наше число отрицательное
                if (str[t] != '-')
                {
                    //число не может начинаться с запятой
                    if ((str[t] == ',') || (str[t] == '.')) a = false;
                    while (t < l)
                    {
                        if ((str[t] == ',') || (str[t] == '.'))
                        //если запятая стоит последним символом или запятая уже была найдена
                        {
                            if (t == l - 1 || k > 0) a = false;
                            b = false;
                            k++;
                        }
                        //если t-ый символ не лежит в диапазоне от '0' до '9'
                        else if (str[t] < '0' || str[t] > '9') a = false;
                        t++;
                    }
                    if (a == false)
                    {
                        MessageBox.Show("Параметр не является числом!", "Ошибка ввода данных", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        this.textBox2.Focus();
                        this.textBox2.Clear();
                    }
                    else if (b == false)
                    {
                        MessageBox.Show("Параметр не может принимать дробное значение!", "Ошибка ввода данных", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        this.textBox2.Focus();
                        this.textBox2.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Параметр не может принимать отрицательное значение!", "Ошибка ввода данных", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.textBox2.Focus();
                    this.textBox2.Clear();
                }
            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            int l, t, k; bool a = true; String str;
            if (textBox3.Text != "")
            {
                str = textBox3.Text;
                l = str.Length;
                //индекс символа, с которым работаем
                t = 0;
                //колличество запятых в строке (дабы избежать варианта 0,2384,1254,1251 – это не число)
                k = 0;
                //двигаем индексатор, если наше число отрицательное
                if (str[t] == '-')
                    t++;
                //число не может начинаться с запятой
                if (str[t] == ',') a = false;
                while (t < l)
                {
                    if ((str[t] == ',') || (str[t] == '.'))
                    //если запятая стоит последним символом или запятая уже была найдена
                    {
                        if (t == l - 1 || k > 0) a = false;
                        k++;
                    }
                    //если t-ый символ не лежит в диапазоне от '0' до '9'
                    else if (str[t] < '0' || str[t] > '9') a = false;
                    t++;
                }
                if (a == false)
                {
                    MessageBox.Show("Параметр не является числом!", "Ошибка ввода данных", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.textBox3.Focus();
                    this.textBox3.Clear();
                }
            }
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            int l, t, k; bool a = true; String str;
            if (textBox4.Text != "")
            {
                str = textBox4.Text;
                l = str.Length;
                //индекс символа, с которым работаем
                t = 0;
                //колличество запятых в строке (дабы избежать варианта 0,2384,1254,1251 – это не число)
                k = 0;
                //двигаем индексатор, если наше число отрицательное
                if (str[t] == '-')
                    t++;
                //число не может начинаться с запятой
                if (str[t] == ',') a = false;
                while (t < l)
                {
                    if ((str[t] == ',') || (str[t] == '.'))
                    //если запятая стоит последним символом или запятая уже была найдена
                    {
                        if (t == l - 1 || k > 0) a = false;
                        k++;
                    }
                    //если t-ый символ не лежит в диапазоне от '0' до '9'
                    else if (str[t] < '0' || str[t] > '9') a = false;
                    t++;
                }
                if (a == false)
                {
                    MessageBox.Show("Параметр не является числом!", "Ошибка ввода данных", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.textBox4.Focus();
                    this.textBox4.Clear();
                }
            }
        }

        private void textBox5_Leave(object sender, EventArgs e)
        {
            int l, t, k; bool a = true; String str;
            if (textBox5.Text != "")
            {
                str = textBox5.Text;
                l = str.Length;
                //индекс символа, с которым работаем
                t = 0;
                //колличество запятых в строке (дабы избежать варианта 0,2384,1254,1251 – это не число)
                k = 0;
                //двигаем индексатор, если наше число отрицательное
                if (str[t] == '-')
                    t++;
                //число не может начинаться с запятой
                if (str[t] == ',') a = false;
                while (t < l)
                {
                    if ((str[t] == ',') || (str[t] == '.'))
                    //если запятая стоит последним символом или запятая уже была найдена
                    {
                        if (t == l - 1 || k > 0) a = false;
                        k++;
                    }
                    //если t-ый символ не лежит в диапазоне от '0' до '9'
                    else if (str[t] < '0' || str[t] > '9') a = false;
                    t++;
                }
                if (a == false)
                {
                    MessageBox.Show("Параметр не является числом!", "Ошибка ввода данных", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.textBox5.Focus();
                    this.textBox5.Clear();
                }
            }
        }

        private void textBox6_Leave(object sender, EventArgs e)
        {
            int l, t, k; bool a = true; String str;
            if (textBox6.Text != "")
            {
                str = textBox6.Text;
                l = str.Length;
                //индекс символа, с которым работаем
                t = 0;
                //колличество запятых в строке (дабы избежать варианта 0,2384,1254,1251 – это не число)
                k = 0;
                //двигаем индексатор, если наше число отрицательное
                if (str[t] == '-')
                    t++;
                //число не может начинаться с запятой
                if (str[t] == ',') a = false;
                while (t < l)
                {
                    if ((str[t] == ',') || (str[t] == '.'))
                    //если запятая стоит последним символом или запятая уже была найдена
                    {
                        if (t == l - 1 || k > 0) a = false;
                        k++;
                    }
                    //если t-ый символ не лежит в диапазоне от '0' до '9'
                    else if (str[t] < '0' || str[t] > '9') a = false;
                    t++;
                }
                if (a == false)
                {
                    MessageBox.Show("Параметр не является числом!", "Ошибка ввода данных", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.textBox6.Focus();
                    this.textBox6.Clear();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //проверка на заполненность полей
            if (textBox1.Text != String.Empty && textBox2.Text != String.Empty && textBox3.Text != String.Empty &&
                textBox4.Text != String.Empty && textBox5.Text != String.Empty && textBox6.Text != String.Empty)
            {
                try
                {
                    double a, A, b, B, h, k, I;
                    //количество пар участков разбиения отрезка [a; A]
                    int n = 4 * Convert.ToInt32(textBox1.Text);
                    //количество пар участков разбиения отрезка [b; B] 
                    int m = 4 * Convert.ToInt32(textBox2.Text);
                    //координаты начала и конца отрезка интегрирования [a; A]
                    a = Convert.ToDouble(textBox3.Text); A = Convert.ToDouble(textBox4.Text);
                    //координаты начала и конца отрезка интегрирования [b; B]
                    b = Convert.ToDouble(textBox5.Text); B = Convert.ToDouble(textBox6.Text);
                    if (a > A || b > B)
                    { MessageBox.Show("Нижний интервал не может быть больше верхнего!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return; }
                    h = (A - a) / n;
                    k = (B - b) / m;
                    n++; m++;
                    double[] x = new double[n];
                    double[] y = new double[m];
                    //Координаты узлов
                    for (int i = 0; i < n; i++)
                        x[i] = a + i * h;
                    for (int j = 0; j < m; j++)
                        y[j] = b + j * k;

                    //матрица л коэффициентов
                    double[,] l = new double[m, n];
                    for (int i = 0; i < m; i++)
                        for (int j = 0; j < n; j++)
                        {
                            if (i == 0)
                            {
                                if (j == 0)
                                    l[i, j] = 2;
                                else if (j == n - 1)
                                    l[i, j] = 1;
                                else
                                    l[i, j] = 3;
                            }
                            else if (i == m - 1)
                            {
                                if (j == n - 1)
                                    l[i, j] = 2;
                                else if (j == 0)
                                    l[i, j] = 1;
                                else
                                    l[i, j] = 3;
                            }
                            else
                            {
                                if (j == 0 || j == n - 1)
                                    l[i, j] = 3;
                                else
                                    l[i, j] = 6;
                            }
                        }

                    //кубатурная формула трапеций
                    double S = 0.0;
                    double[,] f = new double[m, n];
                    for (int i = 0; i < m; i++)
                    {
                        for (int j = 0; j < n; j++)
                        {
                            f[i, j] = 1 / (x[j] * y[i]);
                            S += l[i, j] * f[i, j];
                        }
                    }
                    I = h * k / 6 * S;
                    textBox7.Text = Math.Round(I, 3).ToString();
                }
                catch { MessageBox.Show("Ошибка ввода данных!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return; }
            }
            else
                MessageBox.Show("Заполните поля, чтобы произвести вычисления!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            G G = new G();
            G.ShowDialog();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 A = new AboutBox1();
            this.Hide();
            A.ShowDialog();
            this.Show();
        }

        private void теоретическиеСведенияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 A = new Form4();
            this.Hide();
            A.ShowDialog();
            this.Show();
        }
    }
}
