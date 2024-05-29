namespace dz_WinFormApp._29._05._24
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
            show_text = new Label();
            incr_button = new Button();
            decr_button = new Button();
            SuspendLayout();
            // 
            // show_text
            // 
            show_text.AutoSize = true;
            show_text.BackColor = Color.Yellow;
            show_text.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            show_text.ForeColor = Color.DarkRed;
            show_text.Location = new Point(366, 201);
            show_text.Name = "show_text";
            show_text.Size = new Size(95, 40);
            show_text.TabIndex = 5;
            show_text.Text = "ready";
            // 
            // incr_button
            // 
            incr_button.BackColor = Color.DarkRed;
            incr_button.FlatStyle = FlatStyle.Popup;
            incr_button.Font = new Font("Microsoft Sans Serif", 15.75F);
            incr_button.ForeColor = SystemColors.Control;
            incr_button.Location = new Point(532, 184);
            incr_button.Name = "incr_button";
            incr_button.Size = new Size(229, 82);
            incr_button.TabIndex = 4;
            incr_button.Text = "increase";
            incr_button.UseVisualStyleBackColor = false;
            incr_button.Click += incr_button_Click;
            // 
            // decr_button
            // 
            decr_button.BackColor = Color.DarkRed;
            decr_button.FlatStyle = FlatStyle.Popup;
            decr_button.Font = new Font("Microsoft Sans Serif", 15.75F);
            decr_button.ForeColor = SystemColors.Control;
            decr_button.Location = new Point(57, 184);
            decr_button.Name = "decr_button";
            decr_button.Size = new Size(229, 82);
            decr_button.TabIndex = 3;
            decr_button.Text = "decrease";
            decr_button.UseVisualStyleBackColor = false;
            decr_button.Click += decr_button_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RoyalBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(show_text);
            Controls.Add(incr_button);
            Controls.Add(decr_button);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label show_text;
        private Button incr_button;
        private Button decr_button;
        private int counter;
    }
}
