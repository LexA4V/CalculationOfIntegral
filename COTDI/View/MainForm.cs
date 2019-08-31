using System;
using System.Windows.Forms;

namespace CalculationOfIntegral
{
    public partial class MainForm : Form
    {
        protected MainForm()
        {
            InitializeComponent();
        }

        public MainForm(BaseCalculateIntegral t) : this()
        {
            calc = t;
        }

        private BaseCalculateIntegral calc;

        private bool CheckValidator()
        {
            return tBXNumberOfSections.Text != String.Empty && tBYNumberOfSections.Text != String.Empty && tBXStart.Text != String.Empty &&
                tBXFinish.Text != String.Empty && tBYStart.Text != String.Empty && tBYFinish.Text != String.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //проверка на заполненность полей
            if (!CheckValidator())
                MessageBox.Show("Заполните поля, чтобы произвести вычисления!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            try
            {
                calc.OXStart = double.Parse(tBXStart.Text);
                calc.OXFinish = double.Parse(tBXFinish.Text);
                calc.XNumberOfSections = int.Parse(tBXNumberOfSections.Text);

                calc.OYStart = double.Parse(tBYStart.Text);
                calc.OYFinish = double.Parse(tBYFinish.Text);
                calc.YNumberOfSections = int.Parse(tBYNumberOfSections.Text);


                //if (0)
                //{ MessageBox.Show("Нижний интервал не может быть больше верхнего!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return; }

                tBResult.Text = calc.Calculate().ToString();
            }
            catch (Exception ex){ MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
        }

        private void btnToBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuForm G = new MenuForm();
            G.ShowDialog();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutTheProgram A = new AboutTheProgram();
            this.Hide();
            A.ShowDialog();
            this.Show();
        }

        private void теоретическиеСведенияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReferenceForm A = new ReferenceForm();
            this.Hide();
            A.ShowDialog();
            this.Show();
        }

        #region Проверки корректности ввода

        private void DOUBLE_Leave(object sender, EventArgs e)
        {
            TextBox currentTextBox = sender as TextBox;
            if (currentTextBox == null)
                return;



            int l, t, k; bool a = true, b = true;
            
            string str = currentTextBox.Text;

            if (tBXNumberOfSections.Text != "")
            {
                str = tBXNumberOfSections.Text;
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
                        this.tBXNumberOfSections.Focus();
                        this.tBXNumberOfSections.Clear();
                    }
                    else if (b == false)
                    {
                        MessageBox.Show("Параметр не может принимать дробное значение!", "Ошибка ввода данных", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        this.tBXNumberOfSections.Focus();
                        this.tBXNumberOfSections.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Параметр не может принимать отрицательное значение!", "Ошибка ввода данных", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.tBXNumberOfSections.Focus();
                    this.tBXNumberOfSections.Clear();
                }
            }
        }

        private void UINT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void DOUBLE_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar > 47 && e.KeyChar < 58) //цифры
            {
                e.Handled = false;
            }
            else if (e.KeyChar == 8) //бекспейс
            {
                e.Handled = false;
            }
            else if (e.KeyChar == 44)  //запятая 
            {
                e.Handled = false;
            }
            else if (e.KeyChar == 46) //замена точки на запятую
            {
                e.KeyChar = (char)44;
            }
            else if (e.KeyChar == 45) //знак "-"
            {
                e.Handled = false;
            }
            else
                e.Handled = true;
        }

        #endregion
    }
}
