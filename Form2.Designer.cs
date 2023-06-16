namespace Numismatics
{
    partial class Form2
    {
        enum stage
        {
            none,
            sale,
            change
        }
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            label2 = new Label();
            CoinName = new Label();
            groupBox1 = new GroupBox();
            Stage = new ComboBox();
            label1 = new Label();
            Cost = new TextBox();
            Description = new TextBox();
            label4 = new Label();
            Name = new TextBox();
            btnLoadPhoto = new Button();
            button1 = new Button();
            button2 = new Button();
            PhotoCoin = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PhotoCoin).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(0, 0, 192);
            label2.Location = new Point(18, 251);
            label2.Name = "label2";
            label2.Size = new Size(44, 20);
            label2.TabIndex = 10;
            label2.Text = "Cost:";
            // 
            // CoinName
            // 
            CoinName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            CoinName.Location = new Point(6, 44);
            CoinName.Name = "CoinName";
            CoinName.Size = new Size(100, 25);
            CoinName.TabIndex = 8;
            CoinName.Text = "Name";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(Stage);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(Cost);
            groupBox1.Controls.Add(Description);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(Name);
            groupBox1.Controls.Add(CoinName);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(12, 19);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(444, 292);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "Information about the coin";
            // 
            // Stage
            // 
            Stage.FormattingEnabled = true;
            Stage.Items.AddRange(new object[] { stage.none, stage.sale, stage.change });
            Stage.Location = new Point(287, 247);
            Stage.Name = "Stage";
            Stage.Size = new Size(111, 28);
            Stage.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(0, 0, 192);
            label1.Location = new Point(230, 251);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 12;
            label1.Text = "Stage:";
            // 
            // Cost
            // 
            Cost.Location = new Point(68, 248);
            Cost.Name = "Cost";
            Cost.Size = new Size(70, 27);
            Cost.TabIndex = 11;
            // 
            // Description
            // 
            Description.Location = new Point(6, 99);
            Description.Multiline = true;
            Description.Name = "Description";
            Description.Size = new Size(416, 130);
            Description.TabIndex = 9;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(171, 71);
            label4.Name = "label4";
            label4.Size = new Size(100, 25);
            label4.TabIndex = 10;
            label4.Text = "Description";
            // 
            // Name
            // 
            Name.Location = new Point(70, 41);
            Name.Name = "Name";
            Name.Size = new Size(352, 27);
            Name.TabIndex = 0;
            // 
            // btnLoadPhoto
            // 
            btnLoadPhoto.Location = new Point(493, 282);
            btnLoadPhoto.Name = "btnLoadPhoto";
            btnLoadPhoto.Size = new Size(192, 29);
            btnLoadPhoto.TabIndex = 15;
            btnLoadPhoto.Text = "Load photo from file";
            btnLoadPhoto.UseVisualStyleBackColor = true;
            btnLoadPhoto.Click += btnLoadPhoto_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(103, 337);
            button1.Name = "button1";
            button1.Size = new Size(157, 44);
            button1.TabIndex = 16;
            button1.Text = "Ok";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(412, 337);
            button2.Name = "button2";
            button2.Size = new Size(157, 44);
            button2.TabIndex = 17;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // PhotoCoin
            // 
            PhotoCoin.BackColor = Color.White;
            PhotoCoin.BorderStyle = BorderStyle.FixedSingle;
            PhotoCoin.InitialImage = (Image)resources.GetObject("PhotoCoin.InitialImage");
            PhotoCoin.Location = new Point(462, 30);
            PhotoCoin.Name = "PhotoCoin";
            PhotoCoin.Size = new Size(250, 246);
            PhotoCoin.SizeMode = PictureBoxSizeMode.StretchImage;
            PhotoCoin.TabIndex = 0;
            PhotoCoin.TabStop = false;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            ClientSize = new Size(724, 405);
            Controls.Add(PhotoCoin);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnLoadPhoto);
            Controls.Add(groupBox1);
            Text = "Add the new coin";
            Load += Form2_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PhotoCoin).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label label2;
        //private PictureBox Photo;
        private Label CoinName;
        private GroupBox groupBox1;
        private TextBox Description;
        private Label label4;
        private TextBox Name;
        private TextBox Cost;
        private Button btnLoadPhoto;
        private Button button1;
        private Button button2;
        private ComboBox Stage;
        private Label label1;
        private PictureBox PhotoCoin;
    }
}