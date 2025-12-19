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
            saveFileDialogTask = new SaveFileDialog();
            buttonSave = new Button();
            buttonMin = new Button();
            toolTip = new ToolTip(components);
            buttonMax = new Button();
            buttonSearch = new Button();
            textBoxSearch = new TextBox();
            groupBoxSearch = new GroupBox();
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
            dataGridViewTab1.ColumnHeadersVisible = false;
            dataGridViewTab1.Location = new Point(115, 22);
            dataGridViewTab1.Name = "dataGridViewTab1";
            dataGridViewTab1.RowHeadersVisible = false;
            dataGridViewTab1.RowHeadersWidth = 51;
            dataGridViewTab1.Size = new Size(267, 314);
            dataGridViewTab1.TabIndex = 1;
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
            buttonMin.Location = new Point(397, 22);
            buttonMin.Name = "buttonMin";
            buttonMin.Size = new Size(244, 62);
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
            buttonMax.Location = new Point(397, 90);
            buttonMax.Name = "buttonMax";
            buttonMax.Size = new Size(244, 62);
            buttonMax.TabIndex = 6;
            buttonMax.Text = "Сортировка от меньшего к большему";
            toolTip.SetToolTip(buttonMax, "Сортирует данные 3 столбца от меньшего к большему");
            buttonMax.UseVisualStyleBackColor = true;
            buttonMax.Click += buttonMax_Click;
            // 
            // buttonSearch
            // 
            buttonSearch.Location = new Point(15, 87);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(204, 40);
            buttonSearch.TabIndex = 7;
            buttonSearch.Text = "Поиск";
            toolTip.SetToolTip(buttonSearch, "Выполняет поиск");
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Location = new Point(15, 54);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(204, 27);
            textBoxSearch.TabIndex = 8;
            // 
            // groupBoxSearch
            // 
            groupBoxSearch.BackColor = Color.WhiteSmoke;
            groupBoxSearch.Controls.Add(textBoxSearch);
            groupBoxSearch.Controls.Add(buttonSearch);
            groupBoxSearch.Location = new Point(398, 158);
            groupBoxSearch.Name = "groupBoxSearch";
            groupBoxSearch.Size = new Size(243, 148);
            groupBoxSearch.TabIndex = 9;
            groupBoxSearch.TabStop = false;
            groupBoxSearch.Text = "Поиск товаров                 Введите данные";
            // 
            // FormFile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(657, 348);
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
        private Button buttonSearch;
        private TextBox textBoxSearch;
        private GroupBox groupBoxSearch;
    }
}