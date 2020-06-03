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

        public addStudentsForm()
        {
            InitializeComponent();
        }

        private void SaveStudentsButton_Click(object sender, EventArgs e)
        {
            string[] students = studentsRichTextBox.Lines;

            if (students.Length == 0) { MessageBox.Show("Введите студентов!"); return; }

            for (int i = 0; i < students.Length; ++i)
                students[i] = students[i].Trim();
            
            for (int i = 0; i < students.Length; ++i)
            {
                form.studentsDataGrid.Rows.Add();
                form.studentsDataGrid[0, form.studentsDataGrid.Rows.Count - 1].Value = students[i];
            }

            
        }
    }
}
