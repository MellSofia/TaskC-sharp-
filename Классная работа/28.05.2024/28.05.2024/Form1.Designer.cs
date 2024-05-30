
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
            BG1 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            show_meter = new Label();
            show_life = new Label();
            show_hit = new Label();
            button_start = new Button();
            button_stop = new Button();
            button_restart = new Button();
            player = new PictureBox();
            BG2 = new PictureBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)BG1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)player).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BG2).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // decr_button
            // 
            decr_button.Location = new Point(194, 402);
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
            // BG1
            // 
            BG1.BackgroundImage = (Image)resources.GetObject("BG1.BackgroundImage");
            BG1.BackgroundImageLayout = ImageLayout.Stretch;
            BG1.InitialImage = (Image)resources.GetObject("BG1.InitialImage");
            BG1.Location = new Point(0, 147);
            BG1.Name = "BG1";
            BG1.Size = new Size(800, 167);
            BG1.TabIndex = 3;
            BG1.TabStop = false;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // show_meter
            // 
            show_meter.AutoSize = true;
            show_meter.Location = new Point(115, 29);
            show_meter.Name = "show_meter";
            show_meter.Size = new Size(38, 15);
            show_meter.TabIndex = 5;
            show_meter.Text = "label2";
            // 
            // show_life
            // 
            show_life.AutoSize = true;
            show_life.Location = new Point(29, 29);
            show_life.Name = "show_life";
            show_life.Size = new Size(38, 15);
            show_life.TabIndex = 6;
            show_life.Text = "label1";
            // 
            // show_hit
            // 
            show_hit.AutoSize = true;
            show_hit.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            show_hit.Location = new Point(335, 94);
            show_hit.Name = "show_hit";
            show_hit.Size = new Size(108, 50);
            show_hit.TabIndex = 7;
            show_hit.Text = "HIT!!";
            show_hit.Visible = false;
            // 
            // button_start
            // 
            button_start.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button_start.Location = new Point(286, 320);
            button_start.Name = "button_start";
            button_start.Size = new Size(196, 68);
            button_start.TabIndex = 8;
            button_start.Text = "START";
            button_start.UseVisualStyleBackColor = true;
            button_start.Click += button_start_Click;
            // 
            // button_stop
            // 
            button_stop.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button_stop.Location = new Point(286, 320);
            button_stop.Name = "button_stop";
            button_stop.Size = new Size(98, 68);
            button_stop.TabIndex = 9;
            button_stop.Text = "STOP";
            button_stop.UseVisualStyleBackColor = true;
            button_stop.Visible = false;
            button_stop.Click += button_stop_Click;
            // 
            // button_restart
            // 
            button_restart.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button_restart.Location = new Point(381, 320);
            button_restart.Name = "button_restart";
            button_restart.Size = new Size(108, 68);
            button_restart.TabIndex = 10;
            button_restart.Text = "RESTART";
            button_restart.UseVisualStyleBackColor = true;
            button_restart.Visible = false;
            button_restart.Click += button_restart_Click;
            // 
            // player
            // 
            player.BackColor = Color.DimGray;
            player.BackgroundImage = (Image)resources.GetObject("player.BackgroundImage");
            player.BackgroundImageLayout = ImageLayout.Stretch;
            player.BorderStyle = BorderStyle.FixedSingle;
            player.Location = new Point(0, 246);
            player.Name = "player";
            player.Size = new Size(109, 55);
            player.TabIndex = 11;
            player.TabStop = false;
            player.Click += player_Click;
            // 
            // BG2
            // 
            BG2.BackgroundImage = (Image)resources.GetObject("BG2.BackgroundImage");
            BG2.BackgroundImageLayout = ImageLayout.Stretch;
            BG2.InitialImage = (Image)resources.GetObject("BG2.InitialImage");
            BG2.Location = new Point(800, 147);
            BG2.Name = "BG2";
            BG2.Size = new Size(800, 167);
            BG2.TabIndex = 12;
            BG2.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(show_life);
            groupBox1.Controls.Add(show_meter);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 68);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            groupBox2.Location = new Point(513, 18);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(200, 62);
            groupBox2.TabIndex = 14;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(player);
            Controls.Add(button_restart);
            Controls.Add(button_stop);
            Controls.Add(button_start);
            Controls.Add(show_hit);
            Controls.Add(show_text);
            Controls.Add(incr_button);
            Controls.Add(decr_button);
            Controls.Add(BG2);
            Controls.Add(BG1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form1";
            Text = "Form1";
            KeyDown += Form1_KeyDown;
            ((System.ComponentModel.ISupportInitialize)BG1).EndInit();
            ((System.ComponentModel.ISupportInitialize)player).EndInit();
            ((System.ComponentModel.ISupportInitialize)BG2).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private Button decr_button;
        private Button incr_button;
        private Label show_text;
        private int counter;
        private PictureBox BG1;
        private System.Windows.Forms.Timer timer1;
        private Label show_meter;
        private Label show_life;
        private Label show_hit;
        private Button button_start;
        private Button button_stop;
        private Button button_restart;
        private PictureBox player;
        private PictureBox BG2;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
    }
}
