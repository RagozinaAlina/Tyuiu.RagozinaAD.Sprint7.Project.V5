namespace Tyuiu.RagozinaAD.Sprint7.Project.V5
{
    partial class FormFile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFile));
            buttonOpen = new Button();
            openFileDialogTask = new OpenFileDialog();
            dataGridViewTab1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            saveFileDialogTask = new SaveFileDialog();
            buttonSave = new Button();
            buttonMin = new Button();
            toolTip = new ToolTip(components);
            buttonMax = new Button();
            buttonMinPrice = new Button();
            textBoxResult = new TextBox();
            buttonMaxPrice = new Button();
            groupBoxSearch = new GroupBox();
            buttonHelp = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTab1).BeginInit();
            groupBoxSearch.SuspendLayout();
            SuspendLayout();
            // 
            // buttonOpen
            // 
            buttonOpen.BackgroundImageLayout = ImageLayout.None;
            buttonOpen.Image = (Image)resources.GetObject("buttonOpen.Image");
            buttonOpen.Location = new Point(12, 22);
            buttonOpen.Name = "buttonOpen";
            buttonOpen.Size = new Size(97, 57);
            buttonOpen.TabIndex = 0;
            buttonOpen.TextAlign = ContentAlignment.BottomCenter;
            toolTip.SetToolTip(buttonOpen, "с");
            buttonOpen.UseVisualStyleBackColor = true;
            buttonOpen.Click += buttonOpen_Click;
            // 
            // openFileDialogTask
            // 
            openFileDialogTask.FileName = "openFileDialog1";
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
            dataGridViewTab1.Size = new Size(381, 314);
            dataGridViewTab1.TabIndex = 1;
            dataGridViewTab1.CellContentClick += dataGridViewTab1_CellContentClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "Код";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 50;
            // 
            // Column2
            // 
            Column2.HeaderText = "Продукт";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "Количество";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 115;
            // 
            // Column4
            // 
            Column4.HeaderText = "Цена";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 90;
            // 
            // buttonSave
            // 
            buttonSave.Image = (Image)resources.GetObject("buttonSave.Image");
            buttonSave.Location = new Point(12, 94);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(97, 58);
            buttonSave.TabIndex = 4;
            toolTip.SetToolTip(buttonSave, "Сохранить файл");
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click_1;
            // 
            // buttonMin
            // 
            buttonMin.Location = new Point(524, 22);
            buttonMin.Name = "buttonMin";
            buttonMin.Size = new Size(266, 62);
            buttonMin.TabIndex = 5;
            buttonMin.Text = "Сортировка от большего к меньшему";
            toolTip.SetToolTip(buttonMin, "Сортирует данные 4 столбца от большего к меньшего");
            buttonMin.UseVisualStyleBackColor = true;
            buttonMin.Click += buttonMin_Click;
            // 
            // toolTip
            // 
            toolTip.ToolTipTitle = "Подсказка";
            // 
            // buttonMax
            // 
            buttonMax.Location = new Point(524, 90);
            buttonMax.Name = "buttonMax";
            buttonMax.Size = new Size(266, 62);
            buttonMax.TabIndex = 6;
            buttonMax.Text = "Сортировка от меньшего к большему";
            toolTip.SetToolTip(buttonMax, "Сортирует данные 3 столбца от меньшего к большему");
            buttonMax.UseVisualStyleBackColor = true;
            buttonMax.Click += buttonMax_Click;
            // 
            // buttonMinPrice
            // 
            buttonMinPrice.Location = new Point(8, 26);
            buttonMinPrice.Name = "buttonMinPrice";
            buttonMinPrice.Size = new Size(131, 91);
            buttonMinPrice.TabIndex = 10;
            buttonMinPrice.Text = "Поиск минимальной цены товара";
            buttonMinPrice.UseVisualStyleBackColor = true;
            buttonMinPrice.Click += buttonMinPrice_Click;
            // 
            // textBoxResult
            // 
            textBoxResult.Location = new Point(8, 123);
            textBoxResult.Name = "textBoxResult";
            textBoxResult.Size = new Size(258, 27);
            textBoxResult.TabIndex = 0;
            // 
            // buttonMaxPrice
            // 
            buttonMaxPrice.Location = new Point(145, 26);
            buttonMaxPrice.Name = "buttonMaxPrice";
            buttonMaxPrice.Size = new Size(121, 91);
            buttonMaxPrice.TabIndex = 12;
            buttonMaxPrice.Text = "Поиск максимальной цены товара";
            buttonMaxPrice.UseVisualStyleBackColor = true;
            buttonMaxPrice.Click += buttonMaxPrice_Click;
            // 
            // groupBoxSearch
            // 
            groupBoxSearch.Controls.Add(textBoxResult);
            groupBoxSearch.Controls.Add(buttonMaxPrice);
            groupBoxSearch.Controls.Add(buttonMinPrice);
            groupBoxSearch.Location = new Point(518, 158);
            groupBoxSearch.Name = "groupBoxSearch";
            groupBoxSearch.Size = new Size(272, 164);
            groupBoxSearch.TabIndex = 13;
            groupBoxSearch.TabStop = false;
            groupBoxSearch.Text = "Поиск";
            // 
            // buttonHelp
            // 
            buttonHelp.Location = new Point(12, 281);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(97, 55);
            buttonHelp.TabIndex = 14;
            buttonHelp.Text = "Справка";
            toolTip.SetToolTip(buttonHelp, "Перевод товаров");
            buttonHelp.UseVisualStyleBackColor = true;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // FormFile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(805, 356);
            Controls.Add(buttonHelp);
            Controls.Add(groupBoxSearch);
            Controls.Add(buttonMax);
            Controls.Add(buttonMin);
            Controls.Add(buttonSave);
            Controls.Add(dataGridViewTab1);
            Controls.Add(buttonOpen);
            Name = "FormFile";
            Text = "Товары";
            Load += FormFile_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewTab1).EndInit();
            groupBoxSearch.ResumeLayout(false);
            groupBoxSearch.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonOpen;
        private OpenFileDialog openFileDialogTask;
        private DataGridView dataGridViewTab1;
        private SaveFileDialog saveFileDialogTask;
        private Button buttonSave;
        private Button buttonMin;
        private ToolTip toolTip;
        private Button buttonMax;
        private Button buttonMinPrice;
        private TextBox textBoxResult;
        private Button buttonMaxPrice;
        private GroupBox groupBoxSearch;
        private Button buttonHelp;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
    }
}