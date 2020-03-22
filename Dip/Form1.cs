using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;


namespace Dip
{
    public partial class MOB : Form
    {
        public MOB()
        {
            InitializeComponent();
            comboBox1.Items.AddRange(new string[] { "Увеличиваются", "Уменьшаются", "Не меняются" });
            comboBox2.Items.AddRange(new string[] { "Увеличиваются", "Уменьшаются", "Не меняются" });
            comboBox3.Items.AddRange(new string[] { "Увеличиваются", "Уменьшаются", "Не меняются" });
        }
        int n;
        // текст для печати
        private string printer = " ";
        // обработчик события нажатия на кнопку Печать
        private void writeToolStripMenuItem_Click(object sender, EventArgs e)
        {
             // задаем текст для печати
            printer = "Строка 1\n\n";
 
            printer += "Строка 2\nСтрока 3";
 
            // объект для печати
            PrintDocument printDocument = new PrintDocument();
 
            // обработчик события печати
            printDocument.PrintPage += PrintPageHandler;
 
            // диалог настройки печати
            PrintDialog printDialog = new PrintDialog();
 
            // установка объекта печати для его настройки
            printDialog.Document = printDocument;
 
            // если в диалоге было нажато ОК
            if (printDialog.ShowDialog() == DialogResult.OK)
                printDialog.Document.Print(); // печатаем
        }
        // обработчик события печати
        void PrintPageHandler(object sender, PrintPageEventArgs e)
        {
            // печать строки result
            e.Graphics.DrawString(printer, new Font("Arial", 14), Brushes.Black, 0, 0);
        }
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = saveFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog1.FileName, num.Text);
            }
        }
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
        private void saveas_Click(object sender, EventArgs e)
        {
            DialogResult result = saveFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog1.FileName, num.Text);
            }
        }
        private void referenceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("   Межотраслевой баланс (МОБ, модель «затраты — выпуск», метод «затраты — выпуск») — экономико-математическая балансовая модель, характеризующая межотраслевые производственные взаимосвязи в экономике страны. Характеризует связи между выпуском продукции в одной отрасли и затратами, расходованием продукции всех участвующих отраслей, необходимым для обеспечения этого выпуска. Межотраслевой баланс составляется в денежной и натуральной формах.\n"

+ "  Межотраслевой баланс представлен в виде системы линейных уравнений. Межотраслевой баланс (МОБ) представляет собой таблицу, в которой отражен процесс формирования и использования совокупного общественного продукта в отраслевом разрезе. Таблица показывает структуру затрат на производство каждого продукта и структуру его распределения в экономике. По столбцам отражается стоимостной состав валового выпуска отраслей экономики по элементам промежуточного потребления и добавленной стоимости. По строкам отражаются направления использования ресурсов каждой отрасли.\n"

+ "  В модели МОБ выделяются четыре квадранта. В первом отражается промежуточное потребление и система производственных связей, во втором — структура конечного использования ВВП, в третьем — стоимостная структура ВВП, а в четвёртом — перераспределение национального дохода.", "Справка",
                    MessageBoxButtons.OK, MessageBoxIcon.Question);
        }
        private void saveasКакToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult result = saveFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog1.FileName, num.Text);
            }
        }
        private void abouttheprogramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Программа разработана для решения задач межотраслевого баланса для кафедры прикладной математики и информатики ПГУ им. Т.Г.Шевченко.\n" +
                "\nРазработана студенткой группы ФМ16ДР62ПМ (410):\n - Кушнир И.А.\n" + 
                 "\nпод руководством старшего преподавателя:\n - Белая Е.И.\n" +
                "\n © 2020, физико-математический факультет ПГУ им. Т.Г. Шевченко", "О программе!",
                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
        private void dalee_Click(object sender, EventArgs e)
        {
            if (!(int.TryParse(num.Text, out n) && n > 0 && n < 101 /*&& n =='0'*/))
            {
                MessageBox.Show("Ошибка при заполнении данных!", "Сообщение",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning); 
                num.Clear(); 
                return;
            }
            dataGridViewArray.RowCount = n+2;
            dataGridViewArray.ColumnCount = n+3;
            //dataGridViewArray.RowHeadersWidth = 90;
            for (int i = 0; i < n; i++)
                dataGridViewArray.Rows[i].HeaderCell.Value = "Производящие отрасли:" + (i+1) .ToString();
            for (int j = 0; j < n; j++)
            {
                dataGridViewArray.Columns[j].HeaderText = "Потребляющие отрасли:" + (j+1) .ToString();
                //dataGridViewArray.Columns[j].Width = 70;
            }
            dataGridViewArray.Columns[n].HeaderText = "Конечный продукт:";
            dataGridViewArray.Columns[n+1].HeaderText = "Валовый продукт:";
            dataGridViewArray.Columns[n + 2].HeaderText = "КП на плановый период:";
            dataGridViewArray.Rows[n].HeaderCell.Value = "Основные фонды:";
            dataGridViewArray.Rows[n+1].HeaderCell.Value = "Труд:";
            MessageBox.Show("Введите значения в таблицу!", "Сообщение",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && l != '\b' )
            {
                e.Handled = true;
            }
        }
        private void comboBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && l != '\b')
            {
                e.Handled = true;
            }
        }
        private void comboBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && l != '\b')
            {
                e.Handled = true;
            }
        }
        private void textBoxCoeff1_KeyPress(object sender, KeyPressEventArgs e)
        {
           // ввод в texBox только цифр и кнопки Backspace
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        
        }
        private void textBoxCoeff2_KeyPress(object sender, KeyPressEventArgs e)
        {
            // ввод в texBox только цифр и кнопки Backspace
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }
        private void textBoxCoeff3_KeyPress(object sender, KeyPressEventArgs e)
        {
            // ввод в texBox только цифр и кнопки Backspace
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // ввод в texBox только цифр и кнопки Backspace
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        
        /*private void button1_Click(object sender, EventArgs e)
        {
            int[,] X = new int[n, n];
            int[,] R = new int[2, n];
            for (int i = 0; i < n; i++)
            {
                X[i, i] = Convert.ToInt32(dataGridViewArray.Rows[i].Cells[i].Value);
                R[2, i] = Convert.ToInt32(dataGridViewArray.Rows[2].Cells[i].Value);
            }

            
        }*/

      /* private void result_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                textBox2.Text = (.Math.Round(, 3)).ToString();
            else
                textBox2.Text = result.ToString();
        }*/
    }
}

