using Numismatics.Connection;
using Numismatics.Models;
using System.Windows.Forms;

namespace Numismatics.MyObjects
{
    public partial class UserControl1 : UserControl
    {
        Collection collect { get; set; }
        ToolTip toolTip1 = new ToolTip();
        public bool check = false;
        public UserControl1()
        {
            InitializeComponent();
            MouseHover += UserControl1_MouseHover1;
            MouseLeave += UserControl1_MouseLeave1;
            //this.Click += UserControl1_Click;

            toolTip1.AutoPopDelay = 10000;
            toolTip1.InitialDelay = 500;
            toolTip1.ReshowDelay = 500;
            toolTip1.ShowAlways = true;

        }

        public UserControl1(Collection col) : this()
        {
            collect = col;
            CoinName.Text = col.CoinName;
            //Description.Text = col.Description;
            Photo.Image = col.ConvertByteToImage();
            Stage.Text = col.Stage;
            Cost.Text = col.Cost.ToString();
            toolTip1.SetToolTip(this, col.Description);
            toolTip1.SetToolTip(this.Photo, col.Description);

            ContextMenuStrip contextMenuStrip1 = new ContextMenuStrip();
            ToolStripMenuItem correctMenuItem = new ToolStripMenuItem("Change");
            ToolStripMenuItem deleteMenuItem = new ToolStripMenuItem("Delete");
            // добавляем элементы в меню
            contextMenuStrip1.Items.AddRange(new[] { correctMenuItem, deleteMenuItem });

            // ассоциируем контекстное меню с текстовым полем
            Photo.ContextMenuStrip = contextMenuStrip1;
            // устанавливаем обработчики событий для меню
            correctMenuItem.Click += CorrectMenuItem_Click;
            deleteMenuItem.Click += DeleteMenuItem_Click;
        }

        private void DeleteMenuItem_Click(object? sender, EventArgs e)
        {
        DialogResult res = MessageBox.Show("Do you really want to delete this coin?",
            "Attention",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning,
            MessageBoxDefaultButton.Button2);
            if (res == DialogResult.Yes)
            {
                using (MyContext context = new MyContext())
                {
                    context.Collections.Remove(collect);
                    if (context.SaveChanges() > 0)
                        MessageBox.Show("The coin was deleted!");
                }
            }
        }

        private void CorrectMenuItem_Click(object? sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Text = "Correct information about the coin";
            form2.newCoin = collect;
            form2.ShowDialog();
            if (form2.DialogResult == DialogResult.OK)
            {
                using (MyContext context = new MyContext())
                {
                    context.Collections.Update(form2.newCoin);
                    if (context.SaveChanges() > 0)
                        MessageBox.Show("Information about the coin corrected successfully!");
                }
                form2.Close();
            }
        }


        private void UserControl1_MouseLeave1(object sender, EventArgs e)
        {
            if (!check)
            {
                BackColor = SystemColors.GradientActiveCaption;
            }
        }

        private void UserControl1_MouseHover1(object sender, EventArgs e)
        {
            if (!check)
            {
                BackColor = SystemColors.ControlDark;
            }
        }
    }
}
