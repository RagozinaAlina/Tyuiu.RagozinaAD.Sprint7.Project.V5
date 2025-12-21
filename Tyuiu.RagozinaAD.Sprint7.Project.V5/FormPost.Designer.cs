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
            buttonMin = new Button();
            dataGridViewTab1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            openFileDialogTask = new OpenFileDialog();
            saveFileDialogTask = new SaveFileDialog();
            groupBox1 = new GroupBox();
            buttonSearch = new Button();
            textBoxSearch = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTab1).BeginInit();
            groupBox1.SuspendLayout();
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
            // buttonMin
            // 
            buttonMin.Location = new Point(595, 22);
            buttonMin.Name = "buttonMin";
            buttonMin.Size = new Size(260, 73);
            buttonMin.TabIndex = 3;
            buttonMin.Text = "Сортировка от большего к меньшему";
            toolTip.SetToolTip(buttonMin, "Сортирует данные 4 столбца по уменьшению");
            buttonMin.UseVisualStyleBackColor = true;
            buttonMin.Click += buttonMin_Click;
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
            groupBox1.Controls.Add(buttonSearch);
            groupBox1.Controls.Add(textBoxSearch);
            groupBox1.Location = new Point(595, 101);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(260, 146);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Поиск поставщиков                 Введите данные";
            // 
            // buttonSearch
            // 
            buttonSearch.Location = new Point(6, 84);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(248, 48);
            buttonSearch.TabIndex = 1;
            buttonSearch.Text = "Поиск";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Location = new Point(6, 51);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(248, 27);
            textBoxSearch.TabIndex = 0;
            // 
            // FormPost
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(896, 373);
            Controls.Add(groupBox1);
            Controls.Add(buttonMin);
            Controls.Add(dataGridViewTab1);
            Controls.Add(buttonSave);
            Controls.Add(buttonOpen);
            Name = "FormPost";
            Text = "Поставщики";
            Load += FormPost_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewTab1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonOpen;
        private ToolTip toolTip;
        private Button buttonSave;
        private DataGridView dataGridViewTab1;
        private OpenFileDialog openFileDialogTask;
        private SaveFileDialog saveFileDialogTask;
        private Button buttonMin;
        private GroupBox groupBox1;
        private Button buttonSearch;
        private TextBox textBoxSearch;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
    }
}