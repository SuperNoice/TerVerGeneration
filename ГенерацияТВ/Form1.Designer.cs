namespace ГенерацияТВ
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.genButton = new System.Windows.Forms.Button();
            this.variantTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.headerLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.studentsDataGrid = new System.Windows.Forms.DataGridView();
            this.studentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.addStudentsButton = new System.Windows.Forms.Button();
            this.splitCheckBox = new System.Windows.Forms.CheckBox();
            this.clearButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.studentsDataGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // genButton
            // 
            this.genButton.Location = new System.Drawing.Point(46, 81);
            this.genButton.Name = "genButton";
            this.genButton.Size = new System.Drawing.Size(110, 52);
            this.genButton.TabIndex = 0;
            this.genButton.Text = "Генерировать";
            this.genButton.UseVisualStyleBackColor = true;
            this.genButton.Click += new System.EventHandler(this.genButton_Click);
            // 
            // variantTextBox
            // 
            this.variantTextBox.Location = new System.Drawing.Point(142, 19);
            this.variantTextBox.Name = "variantTextBox";
            this.variantTextBox.Size = new System.Drawing.Size(43, 20);
            this.variantTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Количество вариантов";
            // 
            // headerLabel
            // 
            this.headerLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.Location = new System.Drawing.Point(35, 15);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(511, 24);
            this.headerLabel.TabIndex = 3;
            this.headerLabel.Text = "Генерация вариантов по теории вероятности(1-18 номера)";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(416, 346);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Андрей Галан, Лозовик Леонид";
            // 
            // studentsDataGrid
            // 
            this.studentsDataGrid.AllowUserToResizeColumns = false;
            this.studentsDataGrid.AllowUserToResizeRows = false;
            this.studentsDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.studentsDataGrid.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.studentsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentsDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentName});
            this.studentsDataGrid.Location = new System.Drawing.Point(24, 83);
            this.studentsDataGrid.Name = "studentsDataGrid";
            this.studentsDataGrid.RowHeadersVisible = false;
            this.studentsDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.studentsDataGrid.Size = new System.Drawing.Size(287, 257);
            this.studentsDataGrid.TabIndex = 6;
            this.studentsDataGrid.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.studentsDataGrid_RowsAdded);
            this.studentsDataGrid.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.studentsDataGrid_RowsRemoved);
            // 
            // studentName
            // 
            this.studentName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.studentName.HeaderText = "ФИО";
            this.studentName.Name = "studentName";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.splitCheckBox);
            this.groupBox1.Controls.Add(this.progressBar);
            this.groupBox1.Controls.Add(this.genButton);
            this.groupBox1.Controls.Add(this.variantTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(351, 126);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 183);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(6, 151);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(188, 17);
            this.progressBar.TabIndex = 8;
            // 
            // addStudentsButton
            // 
            this.addStudentsButton.Location = new System.Drawing.Point(24, 50);
            this.addStudentsButton.Name = "addStudentsButton";
            this.addStudentsButton.Size = new System.Drawing.Size(123, 27);
            this.addStudentsButton.TabIndex = 3;
            this.addStudentsButton.Text = "Добавить студентов";
            this.addStudentsButton.UseVisualStyleBackColor = true;
            this.addStudentsButton.Click += new System.EventHandler(this.addStudentsButton_Click);
            // 
            // splitCheckBox
            // 
            this.splitCheckBox.AutoSize = true;
            this.splitCheckBox.Location = new System.Drawing.Point(17, 48);
            this.splitCheckBox.Name = "splitCheckBox";
            this.splitCheckBox.Size = new System.Drawing.Size(180, 17);
            this.splitCheckBox.TabIndex = 9;
            this.splitCheckBox.Text = "Варианты в отдельные файлы";
            this.splitCheckBox.UseVisualStyleBackColor = true;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(188, 50);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(123, 27);
            this.clearButton.TabIndex = 8;
            this.clearButton.TabStop = false;
            this.clearButton.Text = "Очистить список";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.addStudentsButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.studentsDataGrid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.headerLabel);
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Генерация типовых расчетов";
            ((System.ComponentModel.ISupportInitialize)(this.studentsDataGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button genButton;
        private System.Windows.Forms.TextBox variantTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button addStudentsButton;
        public System.Windows.Forms.DataGridView studentsDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentName;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.CheckBox splitCheckBox;
        private System.Windows.Forms.Button clearButton;
    }
}

