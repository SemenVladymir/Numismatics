using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Numismatics.Connection;
using Numismatics.Models;
using Numismatics.MyObjects;
using GroupBox = System.Windows.Forms.GroupBox;

namespace Numismatics
{
    public partial class Form1 : Form
    {
        int myId = -1;
        public List<Users> users;
        public List<Collection> collections;
        public List<Collection> myCollection;
        public List<Blogging> blogging;
        Trading trd = new Trading();
        public List<Trading> trading;
        Panel panel;
        FlowLayoutPanel myCoinsPanel;
        FlowLayoutPanel myBlogPanel;
        TextBox textBox;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        public void SelectClients()
        {
            users = new List<Users>();
            using (MyContext context = new MyContext())
            {
                users = context.Users.ToList();
            }
        }

        public void SelectCollections()
        {
            collections = new List<Collection>();
            using (MyContext context = new MyContext())
            {
                collections = context.Collections.ToList();
            }
        }

        public void SelectMyCollections(int myId)
        {
            myCollection = new List<Collection>();
            using (MyContext context = new MyContext())
            {
                myCollection = context.Collections.Where(ee => ee.ClientId == myId).ToList();
            }
        }

        public List<Collection> SelectListMyCollections(int myId)
        {
            List<Collection> myColl = new List<Collection>();
            using (MyContext context = new MyContext())
            {
                myColl = context.Collections.Where(ee => ee.ClientId == myId).ToList();
            }
            return myColl;
        }

        public void SelectMyBlog (int myId)
        {
            blogging = new List<Blogging>();
            using (MyContext context = new MyContext())
            {
                blogging = context.Blogs.Where(ee => ee.ClientId == myId).ToList();
            }
        }

        public void AddNewBlog(Blogging blog)
        {
            using (MyContext context = new MyContext())
            {
                context.Blogs.Add(blog);
                context.SaveChanges();
            }
        }

        public void AddNewClient(Users user)
        {
            using (MyContext context = new MyContext())
            {
                context.Users.Add(user);
                context.SaveChanges();
            }
        }

        public void RemoveClientToId(int id)
        {
            using (MyContext context = new MyContext())
            {
                context.Users.Remove(context.Users.FirstOrDefault(x => x.Id.Equals(id)));
                context.SaveChanges();
            }
        }

        public void AddNewCollection(Collection collection)
        {
            using (MyContext context = new MyContext())
            {
                context.Collections.Add(collection);
                context.SaveChanges();
            }
        }

        public void RemoveCollectionToClientId(int id)
        {
            if (id > -1 || id == null)
                using (MyContext context = new MyContext())
                {
                    context.Collections.RemoveRange(SelectListMyCollections(myId));
                    context.SaveChanges();
                }
        }

        public void UpdateCollection(Collection newCollection)
        {
            using (MyContext context = new MyContext())
            {
                context.Collections.Update(newCollection);
                context.SaveChanges();
            }
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            SelectClients();
            foreach (var u in users)
            {
                if (u.Login.Equals(Login.Text) && u.Password.Equals(Password.Text))
                    myId = u.Id;
            }
            if (myId != -1)
            {
                Controls.Clear();
                BackColor = Color.Aquamarine;
                GroupBox groupBox = new GroupBox();
                groupBox.BackColor = Color.Honeydew;
                groupBox.Text = "MY MENU";
                groupBox.Size = new Size(240, 240);
                groupBox.Location = new Point(15, 40);
                
                GroupBox groupBox2 = new GroupBox();
                groupBox2.BackColor = Color.Honeydew;
                groupBox2.Text = "MY BLOGGING";
                groupBox2.Size = new Size(240, 300);
                groupBox2.Location = new Point(15, 300);

                textBox = new TextBox();
                textBox.Multiline= true;
                textBox.Location = new Point(5, 18);
                textBox.Size = new Size(groupBox2.Width-10, 30);
                textBox.KeyDown += TextBox_KeyDown;

                groupBox2.Controls.Add(textBox);

                myCoinsPanel = new FlowLayoutPanel();
                myCoinsPanel.BorderStyle = BorderStyle.Fixed3D;
                myCoinsPanel.AutoScroll = true;
                myCoinsPanel.FlowDirection = FlowDirection.TopDown;
                myCoinsPanel.Size = new Size(Width - groupBox.Width - 100, 240);
                myCoinsPanel.Location = new Point(groupBox.Width + 50, 40);
                myCoinsPanel.BackColor = Color.Green;
                //myCoinsPanel.HorizontalScroll.Value = 3;

                myBlogPanel = new FlowLayoutPanel();
                myBlogPanel.BorderStyle = BorderStyle.Fixed3D;
                myBlogPanel.AutoScroll= true;
                myBlogPanel.FlowDirection= FlowDirection.TopDown;
                myBlogPanel.Size = new Size(groupBox2.Width-10, groupBox2.Height - 55);
                myBlogPanel.Location = new Point(5, 50);
                //myBlogPanel.HorizontalScroll = true;
                

                groupBox2.Controls.Add(myBlogPanel);


                Label label = new Label();
                label.Text = "MY COINS";
                label.Font = new Font(label.Font, label.Font.Style | FontStyle.Bold);
                label.Location = new Point(25 + groupBox.Width + myCoinsPanel.Width / 2 - 40, 10);

                Label labe2 = new Label();
                labe2.Text = "THE ALL COINS FOR SALLING OR EXCHANGE";
                labe2.Font = new Font(labe2.Font, labe2.Font.Style | FontStyle.Bold);
                labe2.AutoSize = true;
                labe2.Location = new Point(25 + groupBox.Width + myCoinsPanel.Width / 2-100, 320);

                panel = new Panel();
                panel.AutoScroll = true;
                panel.Size = new Size(Width - groupBox.Width - 100, 230);
                panel.Location = new Point(groupBox.Width + 50, 40 + groupBox.Height + 80);
                panel.BorderStyle = BorderStyle.Fixed3D;
                panel.BackColor = Color.Goldenrod;
                panel.HorizontalScroll.Value = 3;

                Button btnAddCoin = new Button();
                btnAddCoin.Text = "Add new Coin";
                btnAddCoin.Location = new Point(45, 30);
                btnAddCoin.Size = new Size(150, 40);
                btnAddCoin.BackColor = Color.DarkSeaGreen;
                btnAddCoin.Click += BtnAddCoin_Click;

                Button btnUpdate = new Button();
                btnUpdate.Text = "Update information";
                btnUpdate.Location = new Point(45, 100);
                btnUpdate.Size = new Size(150, 40);
                btnUpdate.BackColor = Color.DarkSeaGreen;
                btnUpdate.Click += BtnUpdate_Click;

                Button btnDelete = new Button();
                btnDelete.Text = "Delete All";
                btnDelete.Location = new Point(45, 170);
                btnDelete.Size = new Size(150, 40);
                btnDelete.BackColor = Color.Tomato;
                btnDelete.Click += BtnDelete_Click;

                Label desc = new Label();
                desc.Text = "* If you want to change or delete your coin and offer or exchange user coin, you can use context menu, click the right mouse button on photo coin";
                desc.MaximumSize = new Size(Width - 8, 80);
                desc.Location = new Point(255, 610);
                desc.AutoSize = true;
                desc.ForeColor = Color.Red;

                groupBox.Controls.Add(btnAddCoin);
                groupBox.Controls.Add(btnUpdate);
                groupBox.Controls.Add(btnDelete);

                ShowMyCoins();
                ShowOtherCoins();
                Controls.Add(label);
                Controls.Add(labe2);
                Controls.Add(desc);
                Controls.Add(groupBox);
                Controls.Add(groupBox2);
                Controls.Add(myCoinsPanel);
                Controls.Add(panel);

                ShowMyBlogging();
            }
            else
                MessageBox.Show("Client with this Login and Password haven`t find!");
        }

        private void BtnDelete_Click(object? sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Do you really want to delete all your data?",
            "Attention",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning,
            MessageBoxDefaultButton.Button2);
            if (res == DialogResult.Yes)
            {
                RemoveCollectionToClientId(myId);
                RemoveClientToId(myId);
                Close();
            }

        }

        private void ShowMyBlogging()
        {
            SelectMyBlog(myId);
            foreach(Blogging bl in blogging)
            {
                myBlogPanel.Controls.Add(new Label { Text = $"{bl.DateNTime}                    {bl.Description}", AutoSize = true, Dock = DockStyle.Fill });
                myBlogPanel.Controls.Add(new Label { Text = "__________________________________", AutoSize = true, Dock = DockStyle.Fill });
            }
        }

        private void TextBox_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textBox.Text != "")
                {
                    Blogging newBlog = new Blogging(myId, DateTime.Now, textBox.Text);
                    AddNewBlog(newBlog);
                    myBlogPanel.Controls.Add(new Label { Text = $"{DateTime.Now}                    {textBox.Text}", AutoSize=true, Dock=DockStyle.Fill});
                    myBlogPanel.Controls.Add(new Label { Text = "__________________________________", AutoSize = true, Dock = DockStyle.Fill });
                    textBox.Text = "";
                }
            }
        }

        private void BtnUpdate_Click(object? sender, EventArgs e)
        {
            ShowMyCoins();
            ShowOtherCoins();
        }

        private void BtnAddCoin_Click(object? sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.newCoin.ClientId = myId;
            form2.ShowDialog();
            if (form2.DialogResult == DialogResult.OK)
            {
                AddNewCollection(form2.newCoin);
                ShowMyCoins();
                ShowOtherCoins();
            }
        }

        public void ShowMyCoins()
        {
            myCoinsPanel.Controls.Clear();
            if (myCollection !=null)
                myCollection.Clear();
            SelectMyCollections(myId);
            foreach (Collection col in myCollection)
            {
                var item = new UserControl1(col);
                myCoinsPanel.Controls.Add(item);
                myCoinsPanel.Height = item.Height + 33;
            }
        }

        public void ShowOtherCoins()
        {
            panel.Controls.Clear();
            SelectCollections();
            int y = 0;
            UserControl2 item;
            trading = trd.GetTradingList();
            foreach (Collection col in collections)
            {
                if (col.Stage == stage.sale.ToString() || col.Stage == stage.change.ToString())
                {
                    if (col.ClientId == myId)
                    {
                        item = new UserControl2(col, true, myId);
                        item.trd = trading.LastOrDefault(ee => ee.CoinId == col.Id);
                        item.BackColor = Color.MediumTurquoise;
                    }
                    else
                    {
                        item = new UserControl2(col, false, myId);
                        item.trd = trading.LastOrDefault(ee => ee.CoinId == col.Id);
                    }
                    item.Location = new Point(y * (item.Width + 10), 5);
                    y++;
                    panel.Controls.Add(item);
                    panel.Height = item.Height + 33;
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form3 newForm = new Form3();
            newForm.Show();
            newForm.Deactivate += (s, ee) => { Login.Text = newForm.newUser.Login; Password.Text = newForm.newUser.Password; };
        }

        private void ActiveForm_GotFocus(object sender, EventArgs e)
        {
            ShowMyCoins();
            ShowOtherCoins();
        }
    }
}