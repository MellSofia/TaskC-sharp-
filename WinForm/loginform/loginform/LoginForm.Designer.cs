namespace loginform
{
    partial class LoginForm
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
            textBox_password = new TextBox();
            textBox_user_name = new TextBox();
            button_login = new Button();
            label_password = new Label();
            label_user_name = new Label();
            SuspendLayout();
            // 
            // textBox_password
            // 
            textBox_password.Location = new Point(319, 126);
            textBox_password.Name = "textBox_password";
            textBox_password.Size = new Size(131, 23);
            textBox_password.TabIndex = 0;
            // 
            // textBox_user_name
            // 
            textBox_user_name.Location = new Point(319, 82);
            textBox_user_name.Name = "textBox_user_name";
            textBox_user_name.Size = new Size(131, 23);
            textBox_user_name.TabIndex = 1;
            // 
            // button_login
            // 
            button_login.Location = new Point(494, 82);
            button_login.Name = "button_login";
            button_login.Size = new Size(95, 42);
            button_login.TabIndex = 2;
            button_login.Text = "Войти";
            button_login.UseVisualStyleBackColor = true;
            button_login.Click += button_login_Click;
            // 
            // label_password
            // 
            label_password.AutoSize = true;
            label_password.Location = new Point(264, 129);
            label_password.Name = "label_password";
            label_password.Size = new Size(49, 15);
            label_password.TabIndex = 3;
            label_password.Text = "Пароль";
            // 
            // label_user_name
            // 
            label_user_name.AutoSize = true;
            label_user_name.Location = new Point(264, 85);
            label_user_name.Name = "label_user_name";
            label_user_name.Size = new Size(41, 15);
            label_user_name.TabIndex = 4;
            label_user_name.Text = "Логин";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label_user_name);
            Controls.Add(label_password);
            Controls.Add(button_login);
            Controls.Add(textBox_user_name);
            Controls.Add(textBox_password);
            Name = "LoginForm";
            Text = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_password;
        private TextBox textBox_user_name;
        private Button button_login;
        private Label label_password;
        private Label label_user_name;
    }
}