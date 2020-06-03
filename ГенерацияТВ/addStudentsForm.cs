using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ГенерацияТВ
{
    public partial class addStudentsForm : Form
    {
        Form1 form1;
        DataGridView studentsDataGrid;

        public addStudentsForm(Form1 form)
        {
            InitializeComponent();
            form1 = form;
            studentsDataGrid = form.studentsDataGrid;
        }

        private void SaveStudentsButton_Click(object sender, EventArgs e)
        {
            if (fioCheckBox.Checked == true)
            {
                char[] warnSymbol = { '/', ',', '\\', '\'', ']', '[', '{', ';', '}', ':', '"', '+', '=', '_', '-', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0', '!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '№', '?', '`', '~', '<', '>' };
                if (fioFormatComboBox.Text == "Иванов Иван Иванович") warnSymbol = warnSymbol.Append('.').ToArray();

                studentsRichTextBox.Text = studentsRichTextBox.Text.Trim();

                string[] students = studentsRichTextBox.Lines;

                if (students.Length == 0) { MessageBox.Show("Введите студентов!"); return; }

                for (int i = 0; i < students.Length; ++i)
                    students[i] = students[i].Trim();

                string[] fio;
                for (int i = 0; i < students.Length; ++i)
                {
                    fio = students[i].Split(' ');

                    for (int j = 0; j < fio.Length; j++)
                        fio[j] = fio[j].Trim();

                    if (fio.Length != 3) { MessageBox.Show("Неверный формат ФИО! (Возможно встречены лишние пробелы)"); return; }

                    for (int j = 0; j < fio.Length; j++)
                    {
                        if (fioFormatComboBox.Text == "Иванов Иван Иванович" && j > 0 && fio[j].Contains('.')) { MessageBox.Show("Неверный формат ФИО!"); return; }

                        for (int k = 0; k < fio[j].Length; k++)
                            if (warnSymbol.Contains(fio[j][k])) { MessageBox.Show("Недопустимые символы в ФИО!"); return; }

                        if (fioFormatComboBox.Text == "Иванов И. И." && j > 0 && !fio[j].Contains('.')) { MessageBox.Show("Неверный формат ФИО!"); return; }
                    }
                }

                for (int i = 0; i < students.Length; ++i)
                    studentsDataGrid.Rows.Add(students[i]);

                form1.updateCountVariants();

                this.Hide();
            }
            else
            {
                studentsRichTextBox.Text = studentsRichTextBox.Text.Trim();

                string[] students = studentsRichTextBox.Lines;

                if (students.Length == 0) { MessageBox.Show("Введите студентов!"); return; }

                for (int i = 0; i < students.Length; ++i)
                    students[i] = students[i].Trim();

                for (int i = 0; i < students.Length; ++i)
                    studentsDataGrid.Rows.Add(students[i]);

                form1.updateCountVariants();

                this.Hide();
            }

        }

        private void fioCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (fioCheckBox.Checked == false) fioFormatGroupBox.Visible = false;
            else fioFormatGroupBox.Visible = true;
        }
    }
}
