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
}
