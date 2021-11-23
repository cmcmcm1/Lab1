using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace LabCalculator
{
    partial class Form1 : Form
    {
        int columns = 0,
            rows = 0;
        const int size = 20;
        List<List<Cell>> values = new List<List<Cell>>();
        public Form1()
        {
            InitializeComponent();
            CreateValues(size, size);
        }
        private void ClearValues()
        {
            for (int i = 0; i < rows; i++)
            {
                values[i].Clear();
            }
            values.Clear();
        }
        private void CreateValues(int rows,int columns)
        {
            for (int i = 0; i < rows; i++)
            {
                List<Cell> row = new List<Cell>();
                for (int j = 0; j < columns; j++)
                {
                    Cell cell = new Cell();
                    row.Add(cell);
                }
                values.Add(row);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < size; i++) //creating table
            {
                DataGridViewColumn new_col = new DataGridViewTextBoxColumn();
                new_col.HeaderText = ColName(i);
                new_col.Name = new_col.HeaderText;
                dataGridView1.Columns.Add(new_col);
            }
            for (int i = 1; i <= size; i++)
            {
                DataGridViewRow new_row = new DataGridViewRow();
                new_row.HeaderCell.Value = i.ToString();
                dataGridView1.Rows.Add(new_row);
            }
            columns = size;
            rows = size;
        }
        private void додатиРядокToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridViewRow new_row = new DataGridViewRow();
            rows++;
            new_row.HeaderCell.Value = rows.ToString();
            dataGridView1.Rows.Add(new_row);
            List<Cell> row = new List<Cell>();
            values.Add(row);
        }

        private void додатиСтовпчикToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridViewColumn new_col = new DataGridViewTextBoxColumn();
            string name = ColName(columns);
            new_col.HeaderText = name;
            new_col.Name = name;
            dataGridView1.Columns.Add(new_col);
            for(int i = 0; i < rows; i++)
            {
                Cell cell = new Cell();
                values[i].Add(cell);
            }
            columns++;
        }

        private void видалитиРядокToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (rows <= 2) MessageBox.Show("Неможливо далі видаляти рядки.");
            else
            {
                bool possibleToDelete = true;
                for (int i = 0; i < columns; i++)
                {
                    if (dataGridView1.Rows[rows].Cells[i].Value != null)
                    {
                        MessageBox.Show("Неможливо видалити рядок");
                        possibleToDelete = false;
                        break;
                    }
                }
                if (possibleToDelete)
                {
                    dataGridView1.Rows.RemoveAt(rows - 1);
                    values[rows - 1].Clear();
                    rows--;
                }
            }
        }

        private void видалитиСтовпчикToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (columns <= 2) MessageBox.Show("Неможливо далі видаляти стовпчики.");
            else
            {
                bool possibleToDelete = true;
                for (int i = 0; i < rows; i++)
                {
                    if (values[i][columns - 1].Exp != "0") 
                    {
                        MessageBox.Show("Неможливо видалити стовпчик.");
                        possibleToDelete = false;
                        break;
                    }
                }
                if (possibleToDelete)
                {
                    dataGridView1.Columns.RemoveAt(columns - 1);
                    for(int i = 0; i < rows; i++)
                    {
                        values[i].RemoveAt(columns - 1);
                    }
                    columns--;
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string mes = "Введіть формулу у відповідну клітинку та натисніть Enter." + '\n';
            mes += "Формула може містити:" + '\n' + "цілі числа" + '\n' + "круглі дужки" + '\n' + "імена клітинок" + '\n';
            mes += "наступні операції:" + '\n' + "+ додавання" + '\n' + "- віднімання" + '\n' + "* множення" + '\n' + " / ділення" + '\n' + "^ піднесення у степінь";
            mes += '\n' + "n1 mod n2 остача від ділення n1 на  n2(n1, n2 - числа)" + '\n' + "n1 div n2 ціла частка від ділення n1 на n2(n1, n2 -числа)" + '\n';
            mes += "max(n1, n2) максимум чисел n1, n2" + '\n' + "min(n1, n2) мінімум чисел n1, n2" + '\n';
            MessageBox.Show(mes);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = values[e.RowIndex][e.ColumnIndex].Exp;
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int cur_row = e.RowIndex,
                cur_col = e.ColumnIndex;
            values[cur_row][cur_col].Exp = dataGridView1.CurrentCell.Value.ToString();
            ReCalculate(cur_row, cur_col);
        }


        private void завантажитиТаблицюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            ClearValues();
            this.dataGridView1.Rows.Clear();
            this.dataGridView1.Columns.Clear();
            var filename = openFileDialog1.FileName;
            FileStream stream = new FileStream(filename, FileMode.OpenOrCreate);
            StreamReader file = new StreamReader(stream);
            string[] names = file.ReadLine().Split(' ');
            List<string> columnnames = new List<string>();
            for(int j = 0; j < names.Length; j++)
            {
                names[j] = String.Concat(names[j].Where(c => !Char.IsWhiteSpace(c)));
                if (names[j] != "")
                {
                    columnnames.Add(names[j]);
                }
            }

            foreach (string c in columnnames)
            {
                DataGridViewColumn col = new DataGridViewTextBoxColumn();
                col.HeaderText = c;
                col.Name = c;
                dataGridView1.Columns.Add(col);
            }
            columns = columnnames.Count();
            string newline;
            int i = 0;
            while ((newline = file.ReadLine()) != null)
            {
                string[] val = newline.Split(' ');
                List<Cell> vals = new List<Cell>();
                for(int j = 1; j < val.Length; j++)
                {
                    val[j] = String.Concat(val[j].Where(c => !Char.IsWhiteSpace(c)));
                    if (val[j] != "")
                    {
                        Cell cell = new Cell();
                        cell.Val = Convert.ToDouble(val[j]);
                        cell.Exp = val[j];
                        vals.Add(cell);
                    }
                }
                values.Add(vals);
                DataGridViewRow row = new DataGridViewRow();
                row.HeaderCell.Value = (i + 1).ToString();
                dataGridView1.Rows.Add(row);
                i++;
            }
            rows = i;
            file.Close();
            for (i = 0; i < rows; i++)
            {
                for(int j = 0; j < columns; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = values[i][j].Exp;
                }
            }
        }

        private void зберегтиТаблицюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            var filename = saveFileDialog1.FileName;
            FileStream stream = new FileStream(filename, FileMode.OpenOrCreate);
            StreamWriter streamWriter = new StreamWriter(stream);
            int spacecount = rows / 10 - 1;
            streamWriter.Write("    ");
            for (int i = 0; i < columns; i++) //first line with columns headers
            {
                streamWriter.Write("{0,4}", dataGridView1.Columns[i].HeaderText);
            }
            streamWriter.Write('\n');
            for(int i = 0; i < rows; i++)
            {
                streamWriter.Write("{0,4}", (i + 1).ToString());
                for (int j = 0; j < columns; j++)
                {
                    streamWriter.Write("{0,4}", values[i][j].Val.ToString());
                }streamWriter.Write('\n');
            }
            streamWriter.Close();
            MessageBox.Show("Файл збережено.");
        }



        public string AddressAnalize(int rowIndex, int colIndex)  //changes address to value in cell expression
        {
            string expression = values[rowIndex][colIndex].Exp;
            for(int i = 1; i <= rows; i++)
            {
                for(int j = 0; j < columns; j++)
                {
                    string name = ColName(j) + (i).ToString();
                    if (expression.Contains(name))
                    {
                        expression = expression.Replace(name, values[i - 1][j].Val.ToString());
                        values[i - 1][j].AddDependCell(rowIndex, colIndex);
                    }
                }
            }
            return expression;
        }
        public bool ReckurCheck(int rowIndex, int colIndex)
        {
            try
            {
                string name = ColName(colIndex) + (rowIndex + 1).ToString();
                if (values[rowIndex][colIndex].Exp.Contains(name))
                {
                    throw new Exception("Зациклення!");
                }
                else
                {
                    return false;
                }
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.ToString());
                return true;
            }
        }
        public void ReCalculate(int cur_row, int cur_col) //calculates cell value
        {
            if (!ReckurCheck(cur_row, cur_col))
            {
                string expression = AddressAnalize(cur_row, cur_col);
                Cell cell = new Cell();
                cell.Exp = expression;
                cell.Recalculate();
                values[cur_row][cur_col].Val = cell.Val;
                dataGridView1.Rows[cur_row].Cells[cur_col].Value = values[cur_row][cur_col].Val.ToString();
                List<int> depRow = values[cur_row][cur_col].DependsFromMeRows;
                List<int> depCol = values[cur_row][cur_col].DependsFromMeColumns;
                int l = depRow.Count();
                if (l != 0)
                {
                    for(int i = 0; i < l; i++)
                    {
                        ReCalculate(depRow[i], depCol[i]);
                    }
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Ви впевнені, що хочете закрити файл?","", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation))
            {

            }
            else
            {
                e.Cancel = true;
            }
        }

        public string ColName(int i)
        {
            const int alphabet = 26;
            string name = "";
            if (i < alphabet)
            {
                name += (char)(i + 65);
                return name;
            }
            while (i >= alphabet)
            {
                name += (char)(i / alphabet + 64);
                if (i / alphabet < alphabet)
                {
                    name += (char)(i % alphabet + 65);
                }
                i = i / alphabet;
            }
            return name;
        }
    }
}
