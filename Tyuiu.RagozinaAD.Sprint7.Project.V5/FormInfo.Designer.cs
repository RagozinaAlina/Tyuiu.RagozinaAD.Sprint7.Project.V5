namespace Tyuiu.RagozinaAD.Sprint7.Project.V5
{
    partial class FormInfo
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
            buttonOk = new Button();
            groupBoxOk = new GroupBox();
            SuspendLayout();
            // 
            // buttonOk
            // 
            buttonOk.Location = new Point(234, 214);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(112, 37);
            buttonOk.TabIndex = 0;
            buttonOk.Text = "ОК";
            buttonOk.UseVisualStyleBackColor = true;
            buttonOk.Click += buttonOk_Click;
            // 
            // groupBoxOk
            // 
            groupBoxOk.Location = new Point(8, 9);
            groupBoxOk.Name = "groupBoxOk";
            groupBoxOk.Size = new Size(338, 199);
            groupBoxOk.TabIndex = 1;
            groupBoxOk.TabStop = false;
            groupBoxOk.Text = "Данная программа предназначена для просмотра таблиц. Она помогает найти нужные данные.";
            // 
            // FormInfo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(360, 260);
            Controls.Add(groupBoxOk);
            Controls.Add(buttonOk);
            Name = "FormInfo";
            Text = "О программе";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonOk;
        private GroupBox groupBoxOk;
    }
}