using Numismatics.Models;

namespace Numismatics.MyObjects
{
    public partial class UserControl2 : UserControl
    {
        ToolTip toolTip1 = new ToolTip();
        Collection collection = new Collection();
        int myId;
        public bool check = false;
        public Trading trd = new Trading();
        public UserControl2()
        {
            InitializeComponent();
            MouseHover += UserControl2_MouseHover1;
            MouseLeave += UserControl2_MouseLeave1;
            toolTip1.AutoPopDelay = 10000;
            toolTip1.InitialDelay = 500;
            toolTip1.ReshowDelay = 500;
            toolTip1.ShowAlways = true;
        }

        public UserControl2(Collection col, bool tmp, int id) : this()
        {
            myId = id;
            collection = col;
            Name.Text = col.CoinName;
            Photo.Image = col.ConvertByteToImage();
            StartCost.Text = col.Cost.ToString();
            toolTip1.SetToolTip(this, $"{col.Stage}\n{col.Description}");
            toolTip1.SetToolTip(this.Photo, $"{col.Stage}\n{col.Description}");

            ContextMenuStrip contextMenuStrip1 = new ContextMenuStrip();
            ContextMenuStrip contextMenuStrip2 = new ContextMenuStrip();
            ToolStripMenuItem buyMenuItem = new ToolStripMenuItem("Offer price");
            ToolStripMenuItem exchangeMenuItem = new ToolStripMenuItem("Exchange");
            ToolStripMenuItem acceptMenuItem = new ToolStripMenuItem("Accept");
            ToolStripMenuItem rejectMenuItem = new ToolStripMenuItem("Reject");

            // добавляем элементы в меню
            contextMenuStrip1.Items.AddRange(new[] { buyMenuItem, exchangeMenuItem });
            contextMenuStrip2.Items.AddRange(new[] { acceptMenuItem, rejectMenuItem });

            if (tmp)
            {
                Photo.ContextMenuStrip = contextMenuStrip2;
                acceptMenuItem.Click += AcceptMenuItem_Click;
                rejectMenuItem.Click += RejectMenuItem_Click;
            }
            else
            {
                Photo.ContextMenuStrip = contextMenuStrip1;
                buyMenuItem.Click += BuyMenuItem_Click;
                exchangeMenuItem.Click += ExchangeMenuItem_Click;
            }
        }

        private void RejectMenuItem_Click(object? sender, EventArgs e)
        {
            trd.StatusSalling(collection, false);
        }

        private void AcceptMenuItem_Click(object? sender, EventArgs e)
        {
            trd.StatusSalling(collection, true);
        }

        private void ExchangeMenuItem_Click(object? sender, EventArgs e)
        {
            
        }

        private void BuyMenuItem_Click(object? sender, EventArgs e)
        {
            Form4 newForm = new Form4();
            newForm.ShowDialog();
            string price = newForm.price.ToString();

            if (newForm.ShowDialog() == DialogResult.OK)
            {
                trd.SetOfferPrice(myId, newForm.price);
                EndCost.Text = price;
            }
        }

       

        private void UserControl2_MouseLeave1(object sender, EventArgs e)
        {
            if (BackColor == Color.MediumTurquoise)
                check = true;
            if (!check)
                BackColor = SystemColors.Info;
            else
                BackColor = Color.MediumTurquoise;
        }

        private void UserControl2_MouseHover1(object sender, EventArgs e)
        {
            if (BackColor== Color.MediumTurquoise)
            {
                check = true;
                BackColor = SystemColors.ControlDark;
            }
            else
                BackColor = SystemColors.ControlDark;
        }
    }
}
