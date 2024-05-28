
namespace _23._05._24
{
    partial class Main_Form
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
            incr_button = new Button();
            label1 = new Label();
            decr_button = new Button();
            SuspendLayout();
            // 
            // incr_button
            // 
            incr_button.BackColor = Color.Transparent;
            incr_button.Location = new Point(796, 343);
            incr_button.Name = "incr_button";
            incr_button.Padding = new Padding(20);
            incr_button.Size = new Size(273, 155);
            incr_button.TabIndex = 0;
            incr_button.Text = "increase";
            incr_button.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(669, 259);
            label1.Name = "label1";
            label1.Size = new Size(102, 40);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // decr_button
            // 
            decr_button.BackColor = Color.Transparent;
            decr_button.Location = new Point(365, 343);
            decr_button.Name = "decr_button";
            decr_button.Padding = new Padding(20);
            decr_button.Size = new Size(273, 155);
            decr_button.TabIndex = 2;
            decr_button.Text = "decrease";
            decr_button.UseVisualStyleBackColor = false;
            decr_button.Click += Decr_Button_Click;
            // 
            // Main_Form
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1416, 644);
            Controls.Add(decr_button);
            Controls.Add(label1);
            Controls.Add(incr_button);
            Name = "Main_Form";
            Text = "First Progect";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private Button incr_button;
        private TextBox textBox1;
        private Label label1;
        private Button decr_button;
    }
}
