namespace Tyuiu.RagozinaAD.Sprint7.Project.V5
{
    partial class FormSprint
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            buttonInfo = new Button();
            toolTipTask = new ToolTip(components);
            buttonFile = new Button();
            buttonFilePost = new Button();
            panelTop = new Panel();
            panelTop.SuspendLayout();
            SuspendLayout();
            // 
            // buttonInfo
            // 
            buttonInfo.BackColor = SystemColors.ScrollBar;
            buttonInfo.Location = new Point(12, 121);
            buttonInfo.Name = "buttonInfo";
            buttonInfo.Size = new Size(198, 103);
            buttonInfo.TabIndex = 0;
            buttonInfo.Text = "Данные о программе";
            toolTipTask.SetToolTip(buttonInfo, "Нажмите, чтобы узнать данные о программе");
            buttonInfo.UseVisualStyleBackColor = false;
            buttonInfo.Click += buttonInfo_Click;
            // 
            // toolTipTask
            // 
            toolTipTask.ToolTipTitle = "Подсказка";
            // 
            // buttonFile
            // 
            buttonFile.BackColor = SystemColors.ScrollBar;
            buttonFile.Location = new Point(231, 12);
            buttonFile.Name = "buttonFile";
            buttonFile.Size = new Size(198, 103);
            buttonFile.TabIndex = 1;
            buttonFile.Text = "Работа с файлом \"Товар\"";
            toolTipTask.SetToolTip(buttonFile, "Нажмите, чтобы начать работу с файлом");
            buttonFile.UseVisualStyleBackColor = false;
            buttonFile.Click += buttonFile_Click;
            // 
            // buttonFilePost
            // 
            buttonFilePost.BackColor = SystemColors.ScrollBar;
            buttonFilePost.Location = new Point(12, 12);
            buttonFilePost.Name = "buttonFilePost";
            buttonFilePost.Size = new Size(198, 103);
            buttonFilePost.TabIndex = 2;
            buttonFilePost.Text = "Работа с файлом \"Поставщики\"";
            toolTipTask.SetToolTip(buttonFilePost, "Нажмите, чтобы начать работу с файлом");
            buttonFilePost.UseVisualStyleBackColor = false;
            buttonFilePost.Click += buttonFilePost_Click;
            // 
            // panelTop
            // 
            panelTop.Controls.Add(buttonFilePost);
            panelTop.Controls.Add(buttonInfo);
            panelTop.Controls.Add(buttonFile);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(676, 351);
            panelTop.TabIndex = 3;
            // 
            // FormSprint
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Menu;
            ClientSize = new Size(676, 353);
            Controls.Add(panelTop);
            Name = "FormSprint";
            Text = "Оптовая база";
            Load += FormSprint_Load;
            panelTop.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button buttonInfo;
        private ToolTip toolTipTask;
        private Button buttonFile;
        private Button buttonFilePost;
        private Panel panelTop;
    }
}
