using Microsoft.UI;
using Numismatics.Models;
using System.Text;

namespace Numismatics
{
    public partial class Form2 : Form
    {
        public Collection newCoin = new Collection();
        public int ClientId;
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Name.Text) && !string.IsNullOrEmpty(Description.Text))
            {
                newCoin.CoinName = Name.Text;
                newCoin.Description = Description.Text;
                newCoin.ConvertImageToByte(PhotoCoin.Image);
                if (!string.IsNullOrEmpty(Cost.Text))
                    newCoin.Cost = Convert.ToInt32(Cost.Text);
                else
                    newCoin.Cost = 0;
                if (newCoin.Stage.Equals("none") || string.IsNullOrEmpty(newCoin.Stage))
                {
                    if (Stage.SelectedIndex == 1)
                    {
                        Trading trading = new Trading();
                        trading.StartSalling(newCoin);
                    }
                    if (Stage.SelectedIndex == 2)
                    {
                        Trading trading = new Trading();
                        trading.StartExchanging(newCoin);
                    }
                }
                else
                {
                    if (Stage.SelectedIndex == 1 && newCoin.Stage.Equals("change"))
                    {
                        Trading trading = new Trading();
                        trading.RemoveTradingToCoinId(newCoin.Id);
                        trading.StartSalling(newCoin);
                    }
                    if (Stage.SelectedIndex == 2 && newCoin.Stage.Equals("sale"))
                    {
                        Trading trading = new Trading();
                        trading.RemoveTradingToCoinId(newCoin.Id);
                        trading.StartExchanging(newCoin);
                    }
                }
                newCoin.Stage = Stage.SelectedItem.ToString();
                DialogResult = DialogResult.OK;
                Close();
            }
            else
                MessageBox.Show("You need to input information and photo about your additon coin!");
        }

        private void btnLoadPhoto_Click(object sender, EventArgs e)
        {
            PhotoCoin.Image = newCoin.LoadImage();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Name.Text = newCoin.CoinName;
            Description.Text = newCoin.Description;
            Cost.Text = newCoin.Cost.ToString();
            switch (newCoin.Stage)
            {
                case "none":
                    Stage.SelectedIndex = 0;
                    break;
                case "sale":
                    Stage.SelectedIndex = 1;
                    break;
                case "change":
                    Stage.SelectedIndex = 2;
                    break;
            }
            PhotoCoin.Image = newCoin.ConvertByteToImage();
        }
    }
}
