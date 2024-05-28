
namespace _28._05._2024
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            decr_button = new Button();
            incr_button = new Button();
            show_text = new Label();
            pictureBox1 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            show_meter = new Label();
            show_life = new Label();
            show_hit = new Label();
            button_start = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // decr_button
            // 
            decr_button.Location = new Point(181, 406);
            decr_button.Name = "decr_button";
            decr_button.Size = new Size(103, 36);
            decr_button.TabIndex = 0;
            decr_button.Text = "decrease";
            decr_button.UseVisualStyleBackColor = true;
            decr_button.Click += Decr_Button_Click;
            // 
            // incr_button
            // 
            incr_button.Location = new Point(544, 406);
            incr_button.Name = "incr_button";
            incr_button.Size = new Size(102, 36);
            incr_button.TabIndex = 1;
            incr_button.Text = "increase";
            incr_button.UseVisualStyleBackColor = true;
            incr_button.Click += Incr_button_Click;
            // 
            // show_text
            // 
            show_text.AutoSize = true;
            show_text.Location = new Point(381, 417);
            show_text.Name = "show_text";
            show_text.Size = new Size(36, 15);
            show_text.TabIndex = 2;
            show_text.Text = "ready";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.photo_5368384635677039573_w;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(205, 83);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(349, 231);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // show_meter
            // 
            show_meter.AutoSize = true;
            show_meter.Location = new Point(134, 20);
            show_meter.Name = "show_meter";
            show_meter.Size = new Size(38, 15);
            show_meter.TabIndex = 5;
            show_meter.Text = "label2";
            // 
            // show_life
            // 
            show_life.AutoSize = true;
            show_life.Location = new Point(39, 20);
            show_life.Name = "show_life";
            show_life.Size = new Size(38, 15);
            show_life.TabIndex = 6;
            show_life.Text = "label1";
            // 
            // show_hit
            // 
            show_hit.AutoSize = true;
            show_hit.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            show_hit.Location = new Point(324, 30);
            show_hit.Name = "show_hit";
            show_hit.Size = new Size(108, 50);
            show_hit.TabIndex = 7;
            show_hit.Text = "HIT!!";
            show_hit.Visible = false;
            // 
            // button_start
            // 
            button_start.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button_start.Location = new Point(301, 320);
            button_start.Name = "button_start";
            button_start.Size = new Size(196, 68);
            button_start.TabIndex = 8;
            button_start.Text = "START";
            button_start.UseVisualStyleBackColor = true;
            button_start.Click += button_start_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_start);
            Controls.Add(show_hit);
            Controls.Add(show_life);
            Controls.Add(show_meter);
            Controls.Add(pictureBox1);
            Controls.Add(show_text);
            Controls.Add(incr_button);
            Controls.Add(decr_button);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private Button decr_button;
        private Button incr_button;
        private Label show_text;
        private int counter;
        private PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private Label show_meter;
        private Label show_life;
        private Label show_hit;
        private Button button_start;
    }
}
