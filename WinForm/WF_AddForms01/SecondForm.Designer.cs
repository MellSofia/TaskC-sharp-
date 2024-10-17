namespace WF_AddForms01
{
    partial class SecondForm
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
            buttonClose = new Button();
            buttonHide = new Button();
            SuspendLayout();
            // 
            // buttonClose
            // 
            buttonClose.Location = new Point(184, 185);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(121, 23);
            buttonClose.TabIndex = 0;
            buttonClose.Text = "buttonClose";
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += buttonClose_Click;
            // 
            // buttonHide
            // 
            buttonHide.Location = new Point(435, 185);
            buttonHide.Name = "buttonHide";
            buttonHide.Size = new Size(75, 23);
            buttonHide.TabIndex = 1;
            buttonHide.Text = "Hide";
            buttonHide.UseVisualStyleBackColor = true;
            buttonHide.Click += buttonHide_Click;
            // 
            // SecondForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonHide);
            Controls.Add(buttonClose);
            Name = "SecondForm";
            Text = "SecondForm";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonClose;
        private Button buttonHide;
    }
}