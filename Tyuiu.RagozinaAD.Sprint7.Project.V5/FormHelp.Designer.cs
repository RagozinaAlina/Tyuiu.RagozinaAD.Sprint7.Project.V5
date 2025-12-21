namespace Tyuiu.RagozinaAD.Sprint7.Project.V5
{
    partial class FormHelp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHelp));
            groupBox1 = new GroupBox();
            buttonOk = new Button();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(17, 11);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(253, 226);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = resources.GetString("groupBox1.Text");
            // 
            // buttonOk
            // 
            buttonOk.Location = new Point(178, 246);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(92, 32);
            buttonOk.TabIndex = 1;
            buttonOk.Text = "ОК";
            buttonOk.UseVisualStyleBackColor = true;
            buttonOk.Click += buttonOk_Click;
            // 
            // FormHelp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(283, 290);
            Controls.Add(buttonOk);
            Controls.Add(groupBox1);
            Name = "FormHelp";
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button buttonOk;
    }
}