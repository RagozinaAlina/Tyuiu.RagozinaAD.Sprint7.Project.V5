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
            SuspendLayout();
            // 
            // buttonInfo
            // 
            buttonInfo.BackColor = SystemColors.ScrollBar;
            buttonInfo.Location = new Point(12, 12);
            buttonInfo.Name = "buttonInfo";
            buttonInfo.Size = new Size(137, 103);
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
            buttonFile.Location = new Point(12, 137);
            buttonFile.Name = "buttonFile";
            buttonFile.Size = new Size(137, 103);
            buttonFile.TabIndex = 1;
            buttonFile.Text = "Работа с файлами";
            toolTipTask.SetToolTip(buttonFile, "Нажмите, чтобы начать работу с файлами");
            buttonFile.UseVisualStyleBackColor = false;
            buttonFile.Click += buttonFile_Click;
            // 
            // FormSprint
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Menu;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonFile);
            Controls.Add(buttonInfo);
            Name = "FormSprint";
            Text = "Оптовая база";
            Load += FormSprint_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button buttonInfo;
        private ToolTip toolTipTask;
        private Button buttonFile;
    }
}
