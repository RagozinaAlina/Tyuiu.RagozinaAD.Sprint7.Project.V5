namespace Tyuiu.RagozinaAD.Sprint7.Project.V5
{
    partial class FormPost
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPost));
            buttonOpen = new Button();
            toolTip = new ToolTip(components);
            buttonSave = new Button();
            buttonFindValue = new Button();
            textBoxFindValue = new TextBox();
            buttonFind = new Button();
            dataGridViewTab1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            openFileDialogTask = new OpenFileDialog();
            saveFileDialogTask = new SaveFileDialog();
            groupBox1 = new GroupBox();
            textBoxResult = new TextBox();
            groupBox2 = new GroupBox();
            buttonFind1 = new Button();
            groupBox3 = new GroupBox();
            textBoxResult1 = new TextBox();
            buttonDone = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTab1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // buttonOpen
            // 
            buttonOpen.Image = (Image)resources.GetObject("buttonOpen.Image");
            buttonOpen.Location = new Point(12, 22);
            buttonOpen.Name = "buttonOpen";
            buttonOpen.Size = new Size(97, 56);
            buttonOpen.TabIndex = 0;
            toolTip.SetToolTip(buttonOpen, "Открыть файл");
            buttonOpen.UseVisualStyleBackColor = true;
            buttonOpen.Click += buttonOpen_Click;
            // 
            // toolTip
            // 
            toolTip.ToolTipTitle = "Подсказка";
            // 
            // buttonSave
            // 
            buttonSave.Image = (Image)resources.GetObject("buttonSave.Image");
            buttonSave.Location = new Point(12, 96);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(97, 56);
            buttonSave.TabIndex = 1;
            toolTip.SetToolTip(buttonSave, "Сохранить файл");
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonFindValue
            // 
            buttonFindValue.Location = new Point(6, 82);
            buttonFindValue.Name = "buttonFindValue";
            buttonFindValue.Size = new Size(248, 53);
            buttonFindValue.TabIndex = 5;
            buttonFindValue.Text = "Поиск";
            toolTip.SetToolTip(buttonFindValue, "Нажмите, чтобы выполнить поиск");
            buttonFindValue.UseVisualStyleBackColor = true;
            buttonFindValue.Click += buttonFindValue_Click;
            // 
            // textBoxFindValue
            // 
            textBoxFindValue.Location = new Point(6, 49);
            textBoxFindValue.Name = "textBoxFindValue";
            textBoxFindValue.Size = new Size(248, 27);
            textBoxFindValue.TabIndex = 6;
            toolTip.SetToolTip(textBoxFindValue, "Введите данные для поиска");
            // 
            // buttonFind
            // 
            buttonFind.Location = new Point(6, 71);
            buttonFind.Name = "buttonFind";
            buttonFind.Size = new Size(122, 42);
            buttonFind.TabIndex = 5;
            buttonFind.Text = "Поиск (max)";
            toolTip.SetToolTip(buttonFind, "Нажмите для поиска");
            buttonFind.UseVisualStyleBackColor = true;
            buttonFind.Click += buttonFind_Click;
            // 
            // dataGridViewTab1
            // 
            dataGridViewTab1.BackgroundColor = SystemColors.ScrollBar;
            dataGridViewTab1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTab1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dataGridViewTab1.Location = new Point(115, 22);
            dataGridViewTab1.Name = "dataGridViewTab1";
            dataGridViewTab1.RowHeadersVisible = false;
            dataGridViewTab1.RowHeadersWidth = 51;
            dataGridViewTab1.Size = new Size(474, 327);
            dataGridViewTab1.TabIndex = 2;
            // 
            // Column1
            // 
            Column1.HeaderText = "Номер";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "Поставщик";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "Дата поставки";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = "Количество";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 125;
            // 
            // openFileDialogTask
            // 
            openFileDialogTask.FileName = "openFileDialog1";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.Control;
            groupBox1.Controls.Add(buttonFindValue);
            groupBox1.Controls.Add(textBoxFindValue);
            groupBox1.Location = new Point(595, 22);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(260, 146);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Поиск                                        Введите данные";
            // 
            // textBoxResult
            // 
            textBoxResult.Location = new Point(6, 119);
            textBoxResult.Name = "textBoxResult";
            textBoxResult.Size = new Size(248, 27);
            textBoxResult.TabIndex = 6;
            textBoxResult.TextChanged += textBoxResult_TextChanged;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.Control;
            groupBox2.Controls.Add(buttonFind1);
            groupBox2.Controls.Add(buttonFind);
            groupBox2.Controls.Add(textBoxResult);
            groupBox2.Location = new Point(595, 187);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(260, 162);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Поиск максимального и минимального количества товара";
            // 
            // buttonFind1
            // 
            buttonFind1.Location = new Point(134, 71);
            buttonFind1.Name = "buttonFind1";
            buttonFind1.Size = new Size(120, 42);
            buttonFind1.TabIndex = 7;
            buttonFind1.Text = "Поиск (min)";
            toolTip.SetToolTip(buttonFind1, "Нажмите для поиска");
            buttonFind1.UseVisualStyleBackColor = true;
            buttonFind1.Click += buttonFind1_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(textBoxResult1);
            groupBox3.Controls.Add(buttonDone);
            groupBox3.Location = new Point(867, 22);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(159, 146);
            groupBox3.TabIndex = 8;
            groupBox3.TabStop = false;
            groupBox3.Text = "Общее количество товара";
            // 
            // textBoxResult1
            // 
            textBoxResult1.Location = new Point(6, 104);
            textBoxResult1.Name = "textBoxResult1";
            textBoxResult1.Size = new Size(147, 27);
            textBoxResult1.TabIndex = 1;
            // 
            // buttonDone
            // 
            buttonDone.Location = new Point(6, 49);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(147, 49);
            buttonDone.TabIndex = 0;
            buttonDone.Text = "Выполнить";
            toolTip.SetToolTip(buttonDone, "Нажмите, чтобы выполнить рассчет");
            buttonDone.UseVisualStyleBackColor = true;
            buttonDone.Click += buttonDone_Click;
            // 
            // FormPost
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1038, 378);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(dataGridViewTab1);
            Controls.Add(buttonSave);
            Controls.Add(buttonOpen);
            Name = "FormPost";
            Text = "Поставщики";
            Load += FormPost_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewTab1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonOpen;
        private ToolTip toolTip;
        private Button buttonSave;
        private DataGridView dataGridViewTab1;
        private OpenFileDialog openFileDialogTask;
        private SaveFileDialog saveFileDialogTask;
        private GroupBox groupBox1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private Button buttonFindValue;
        private TextBox textBoxFindValue;
        private Button buttonFind;
        private TextBox textBoxResult;
        private GroupBox groupBox2;
        private Button buttonFind1;
        private GroupBox groupBox3;
        private Button buttonDone;
        private TextBox textBoxResult1;
    }
}