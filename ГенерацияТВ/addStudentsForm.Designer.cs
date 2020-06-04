namespace ГенерацияТВ
{
    partial class addStudentsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.studentsRichTextBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SaveStudentsButton = new System.Windows.Forms.Button();
            this.fioCheckBox = new System.Windows.Forms.CheckBox();
            this.fioFormatComboBox = new System.Windows.Forms.ComboBox();
            this.fioFormatGroupBox = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.fioFormatGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // studentsRichTextBox
            // 
            this.studentsRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.studentsRichTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.studentsRichTextBox.Location = new System.Drawing.Point(6, 50);
            this.studentsRichTextBox.Name = "studentsRichTextBox";
            this.studentsRichTextBox.Size = new System.Drawing.Size(369, 399);
            this.studentsRichTextBox.TabIndex = 0;
            this.studentsRichTextBox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Каждый студент вводится с новой строки";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.studentsRichTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(381, 455);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Заполнение списка студентов";
            // 
            // SaveStudentsButton
            // 
            this.SaveStudentsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveStudentsButton.Location = new System.Drawing.Point(447, 427);
            this.SaveStudentsButton.Name = "SaveStudentsButton";
            this.SaveStudentsButton.Size = new System.Drawing.Size(78, 34);
            this.SaveStudentsButton.TabIndex = 2;
            this.SaveStudentsButton.Text = "Save";
            this.SaveStudentsButton.UseVisualStyleBackColor = true;
            this.SaveStudentsButton.Click += new System.EventHandler(this.SaveStudentsButton_Click);
            // 
            // fioCheckBox
            // 
            this.fioCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fioCheckBox.AutoSize = true;
            this.fioCheckBox.Location = new System.Drawing.Point(426, 45);
            this.fioCheckBox.Name = "fioCheckBox";
            this.fioCheckBox.Size = new System.Drawing.Size(111, 17);
            this.fioCheckBox.TabIndex = 3;
            this.fioCheckBox.Text = "Проверять ФИО";
            this.fioCheckBox.UseVisualStyleBackColor = true;
            this.fioCheckBox.CheckedChanged += new System.EventHandler(this.fioCheckBox_CheckedChanged);
            // 
            // fioFormatComboBox
            // 
            this.fioFormatComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.fioFormatComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.fioFormatComboBox.BackColor = System.Drawing.Color.White;
            this.fioFormatComboBox.FormattingEnabled = true;
            this.fioFormatComboBox.Items.AddRange(new object[] {
            "Иванов Иван Иванович",
            "Иванов И. И."});
            this.fioFormatComboBox.Location = new System.Drawing.Point(6, 19);
            this.fioFormatComboBox.Name = "fioFormatComboBox";
            this.fioFormatComboBox.Size = new System.Drawing.Size(150, 21);
            this.fioFormatComboBox.TabIndex = 4;
            this.fioFormatComboBox.Text = "Иванов Иван Иванович";
            this.fioFormatComboBox.TextChanged += new System.EventHandler(this.fioFormatComboBox_TextChanged);
            // 
            // fioFormatGroupBox
            // 
            this.fioFormatGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fioFormatGroupBox.Controls.Add(this.fioFormatComboBox);
            this.fioFormatGroupBox.Location = new System.Drawing.Point(402, 85);
            this.fioFormatGroupBox.Name = "fioFormatGroupBox";
            this.fioFormatGroupBox.Size = new System.Drawing.Size(162, 55);
            this.fioFormatGroupBox.TabIndex = 5;
            this.fioFormatGroupBox.TabStop = false;
            this.fioFormatGroupBox.Text = "Формат ФИО";
            this.fioFormatGroupBox.Visible = false;
            // 
            // addStudentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 479);
            this.Controls.Add(this.fioFormatGroupBox);
            this.Controls.Add(this.fioCheckBox);
            this.Controls.Add(this.SaveStudentsButton);
            this.Controls.Add(this.groupBox1);
            this.MinimumSize = new System.Drawing.Size(521, 244);
            this.Name = "addStudentsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление студентов";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.fioFormatGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox studentsRichTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button SaveStudentsButton;
        private System.Windows.Forms.CheckBox fioCheckBox;
        private System.Windows.Forms.ComboBox fioFormatComboBox;
        private System.Windows.Forms.GroupBox fioFormatGroupBox;
    }
}