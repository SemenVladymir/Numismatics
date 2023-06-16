namespace Numismatics.MyObjects
{
    partial class UserControl2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl2));
            Name = new Label();
            Photo = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            StartCost = new Label();
            EndCost = new Label();
            ((System.ComponentModel.ISupportInitialize)Photo).BeginInit();
            SuspendLayout();
            // 
            // Name
            // 
            Name.Font = new Font("Segoe UI", 7F, FontStyle.Bold, GraphicsUnit.Point);
            Name.Location = new Point(21, 9);
            Name.Name = "Name";
            Name.Size = new Size(125, 21);
            Name.TabIndex = 0;
            Name.Text = "CoinName";
            Name.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Photo
            // 
            Photo.InitialImage = (Image)resources.GetObject("Photo.InitialImage");
            Photo.Location = new Point(21, 33);
            Photo.Name = "Photo";
            Photo.Size = new Size(125, 108);
            Photo.SizeMode = PictureBoxSizeMode.StretchImage;
            Photo.TabIndex = 2;
            Photo.TabStop = false;
            //Photo.Click += UserControl2_Click;
            Photo.MouseLeave += UserControl2_MouseLeave1;
            Photo.MouseHover += UserControl2_MouseHover1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 144);
            label1.Name = "label1";
            label1.Size = new Size(74, 20);
            label1.TabIndex = 3;
            label1.Text = "Start cost:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 173);
            label2.Name = "label2";
            label2.Size = new Size(94, 20);
            label2.TabIndex = 4;
            label2.Text = "Offered cost:";
            // 
            // StartCost
            // 
            StartCost.AutoSize = true;
            StartCost.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            StartCost.Location = new Point(112, 144);
            StartCost.Name = "StartCost";
            StartCost.Size = new Size(18, 20);
            StartCost.TabIndex = 5;
            StartCost.Text = "0";
            // 
            // EndCost
            // 
            EndCost.AutoSize = true;
            EndCost.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            EndCost.Location = new Point(112, 173);
            EndCost.Name = "EndCost";
            EndCost.Size = new Size(18, 20);
            EndCost.TabIndex = 6;
            EndCost.Text = "0";
            // 
            // UserControl2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(EndCost);
            Controls.Add(StartCost);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Photo);
            Controls.Add(Name);
            Size = new Size(166, 203);
            ((System.ComponentModel.ISupportInitialize)Photo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Name;
        private PictureBox Photo;
        private Label label1;
        private Label label2;
        private Label StartCost;
        private Label EndCost;
    }
}
