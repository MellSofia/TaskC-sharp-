namespace leasson12._09
{
    partial class MainForm
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
            buttonNewForm = new Button();
            buttonHide = new Button();
            buttonClose = new Button();
            buttonEx = new Button();
            buttonEnt = new Button();
            SuspendLayout();
            // 
            // buttonNewForm
            // 
            buttonNewForm.Location = new Point(362, 54);
            buttonNewForm.Name = "buttonNewForm";
            buttonNewForm.Size = new Size(75, 23);
            buttonNewForm.TabIndex = 9;
            buttonNewForm.Text = "NewForm";
            buttonNewForm.UseVisualStyleBackColor = true;
            // 
            // buttonHide
            // 
            buttonHide.Location = new Point(487, 136);
            buttonHide.Name = "buttonHide";
            buttonHide.Size = new Size(75, 23);
            buttonHide.TabIndex = 8;
            buttonHide.Text = "Hide";
            buttonHide.UseVisualStyleBackColor = true;
            // 
            // buttonClose
            // 
            buttonClose.Location = new Point(228, 136);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(75, 23);
            buttonClose.TabIndex = 7;
            buttonClose.Text = "Close";
            buttonClose.UseVisualStyleBackColor = true;
            // 
            // buttonEx
            // 
            buttonEx.Location = new Point(12, 374);
            buttonEx.Name = "buttonEx";
            buttonEx.Size = new Size(150, 23);
            buttonEx.TabIndex = 6;
            buttonEx.Text = "Выход из программы";
            buttonEx.UseVisualStyleBackColor = true;
            // 
            // buttonEnt
            // 
            buttonEnt.Location = new Point(713, 374);
            buttonEnt.Name = "buttonEnt";
            buttonEnt.Size = new Size(75, 23);
            buttonEnt.TabIndex = 5;
            buttonEnt.Text = "Вход";
            buttonEnt.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonNewForm);
            Controls.Add(buttonHide);
            Controls.Add(buttonClose);
            Controls.Add(buttonEx);
            Controls.Add(buttonEnt);
            Name = "MainForm";
            Text = "Тестовая программа";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonNewForm;
        private Button buttonHide;
        private Button buttonClose;
        private Button buttonEx;
        private Button buttonEnt;
    }
}
