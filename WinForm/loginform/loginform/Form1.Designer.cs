namespace loginform
{
    partial class Form1
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
            button_logInSistem = new Button();
            SuspendLayout();
            // 
            // button_logInSistem
            // 
            button_logInSistem.Location = new Point(292, 188);
            button_logInSistem.Name = "button_logInSistem";
            button_logInSistem.Size = new Size(132, 43);
            button_logInSistem.TabIndex = 0;
            button_logInSistem.Text = "Войти в систему";
            button_logInSistem.UseVisualStyleBackColor = true;
            button_logInSistem.Click += button_logInSistem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_logInSistem);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button button_logInSistem;
    }
}
