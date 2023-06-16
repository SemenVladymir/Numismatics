namespace Numismatics
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            Login = new TextBox();
            Password = new TextBox();
            lRegistration = new Label();
            btnEnter = new Button();
            btnAdd = new Button();
            Name = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(453, 26);
            label1.Name = "label1";
            label1.Size = new Size(341, 46);
            label1.TabIndex = 0;
            label1.Text = "YOUR NUMISMATIC";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(485, 221);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 1;
            label2.Text = "Login";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(475, 260);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 2;
            label3.Text = "Password";
            // 
            // Login
            // 
            Login.Location = new Point(551, 219);
            Login.Name = "Login";
            Login.Size = new Size(162, 27);
            Login.TabIndex = 3;
            // 
            // Password
            // 
            Password.Location = new Point(551, 260);
            Password.Name = "Password";
            Password.PasswordChar = '*';
            Password.Size = new Size(162, 27);
            Password.TabIndex = 4;
            // 
            // lRegistration
            // 
            lRegistration.AutoSize = true;
            lRegistration.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lRegistration.Location = new Point(551, 133);
            lRegistration.Name = "lRegistration";
            lRegistration.Size = new Size(140, 32);
            lRegistration.TabIndex = 5;
            lRegistration.Text = "Registration";
            // 
            // btnEnter
            // 
            btnEnter.Location = new Point(485, 310);
            btnEnter.Name = "btnEnter";
            btnEnter.Size = new Size(117, 29);
            btnEnter.TabIndex = 6;
            btnEnter.Text = "Enter";
            btnEnter.UseVisualStyleBackColor = true;
            btnEnter.Click += btnEnter_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(628, 310);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(148, 29);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "New client";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // Name
            // 
            Name.Location = new Point(551, 177);
            Name.Name = "Name";
            Name.Size = new Size(162, 27);
            Name.TabIndex = 9;
            Name.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(485, 179);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 8;
            label4.Text = "Name";
            label4.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(1254, 639);
            Controls.Add(Name);
            Controls.Add(label4);
            Controls.Add(btnAdd);
            Controls.Add(btnEnter);
            Controls.Add(lRegistration);
            Controls.Add(Password);
            Controls.Add(Login);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Text = "Your numismatic";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

       

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox Login;
        private TextBox Password;
        private Label lRegistration;
        private Button btnEnter;
        private Button btnAdd;
        private TextBox Name;
        private Label label4;
    }
}