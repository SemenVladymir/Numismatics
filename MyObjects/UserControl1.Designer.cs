namespace Numismatics.MyObjects
{
    partial class UserControl1
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl1));
            Photo = new PictureBox();
            CoinName = new Label();
            label2 = new Label();
            Cost = new Label();
            Stage = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)Photo).BeginInit();
            SuspendLayout();
            // 
            // Photo
            // 
            Photo.InitialImage = (Image)resources.GetObject("Photo.InitialImage");
            Photo.Location = new Point(14, 36);
            Photo.Name = "Photo";
            Photo.Size = new Size(160, 160);
            Photo.SizeMode = PictureBoxSizeMode.StretchImage;
            Photo.TabIndex = 0;
            Photo.TabStop = false;
            //Photo.Click += UserControl1_Click;
            Photo.MouseLeave += UserControl1_MouseLeave1;
            Photo.MouseHover += UserControl1_MouseHover1;
            // 
            // CoinName
            // 
            CoinName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            CoinName.Location = new Point(14, 8);
            CoinName.Name = "CoinName";
            CoinName.Size = new Size(160, 25);
            CoinName.TabIndex = 1;
            CoinName.Text = "CoinName";
            CoinName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(0, 0, 192);
            label2.Location = new Point(100, 199);
            label2.Name = "label2";
            label2.Size = new Size(41, 20);
            label2.TabIndex = 3;
            label2.Text = "Cost:";
            // 
            // Cost
            // 
            Cost.AutoSize = true;
            Cost.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Cost.ForeColor = Color.FromArgb(0, 0, 192);
            Cost.Location = new Point(147, 199);
            Cost.Name = "Cost";
            Cost.Size = new Size(36, 20);
            Cost.TabIndex = 4;
            Cost.Text = "10$";
            // 
            // Stage
            // 
            Stage.AutoSize = true;
            Stage.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Stage.ForeColor = Color.FromArgb(0, 0, 192);
            Stage.Location = new Point(50, 199);
            Stage.Name = "Stage";
            Stage.Size = new Size(44, 20);
            Stage.TabIndex = 6;
            Stage.Text = "none";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(0, 0, 192);
            label3.Location = new Point(3, 199);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 5;
            label3.Text = "Stage:";
            // 
            // UserControl1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(Stage);
            Controls.Add(label3);
            Controls.Add(Cost);
            Controls.Add(label2);
            Controls.Add(CoinName);
            Controls.Add(Photo);
            Name = "UserControl1";
            Size = new Size(190, 229);
            ((System.ComponentModel.ISupportInitialize)Photo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox Photo;
        private Label CoinName;
        private Label label2;
        private Label Cost;
        private Label Stage;
        private Label label3;
    }
}
