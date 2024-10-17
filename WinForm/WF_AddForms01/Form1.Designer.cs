namespace WF_AddForms01
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
            buttonEnt = new Button();
            buttonEx = new Button();
            buttonNewForm = new Button();
            buttonShowDialog = new Button();
            buttonShow = new Button();
            SuspendLayout();
            // 
            // buttonEnt
            // 
            buttonEnt.Location = new Point(713, 415);
            buttonEnt.Name = "buttonEnt";
            buttonEnt.Size = new Size(75, 23);
            buttonEnt.TabIndex = 0;
            buttonEnt.Text = "Вход";
            buttonEnt.UseVisualStyleBackColor = true;
            buttonEnt.Click += buttonEnt_Click;
            // 
            // buttonEx
            // 
            buttonEx.Location = new Point(12, 415);
            buttonEx.Name = "buttonEx";
            buttonEx.Size = new Size(150, 23);
            buttonEx.TabIndex = 1;
            buttonEx.Text = "Выход из программы";
            buttonEx.UseVisualStyleBackColor = true;
            buttonEx.Click += buttonEx_Click;
            // 
            // buttonNewForm
            // 
            buttonNewForm.Location = new Point(362, 95);
            buttonNewForm.Name = "buttonNewForm";
            buttonNewForm.Size = new Size(75, 23);
            buttonNewForm.TabIndex = 4;
            buttonNewForm.Text = "NewForm";
            buttonNewForm.UseVisualStyleBackColor = true;
            buttonNewForm.Click += buttonNewForm_Click;
            // 
            // buttonShowDialog
            // 
            buttonShowDialog.Location = new Point(460, 177);
            buttonShowDialog.Name = "buttonShowDialog";
            buttonShowDialog.Size = new Size(102, 23);
            buttonShowDialog.TabIndex = 3;
            buttonShowDialog.Text = "ShowDialog";
            buttonShowDialog.UseVisualStyleBackColor = true;
            buttonShowDialog.Click += buttonShowDialog_Click;
            // 
            // buttonShow
            // 
            buttonShow.Location = new Point(228, 177);
            buttonShow.Name = "buttonShow";
            buttonShow.Size = new Size(75, 23);
            buttonShow.TabIndex = 2;
            buttonShow.Text = "Show";
            buttonShow.UseVisualStyleBackColor = true;
            buttonShow.Click += buttonShow_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonNewForm);
            Controls.Add(buttonShowDialog);
            Controls.Add(buttonShow);
            Controls.Add(buttonEx);
            Controls.Add(buttonEnt);
            Name = "MainForm";
            Text = "Тестовая программа";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonEnt;
        private Button buttonEx;
        private Button buttonNewForm;
        private Button buttonShowDialog;
        private Button buttonShow;
    }
}
