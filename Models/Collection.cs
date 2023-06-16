using System.Drawing.Imaging;

namespace Numismatics.Models
{
    public enum stage
    {
        none,
        sale,
        change
    }
    public class Collection
    {
        public int Id { get; set; }
        public string? CoinName { get; set; }
        public string? Description { get; set; }
        public int? Cost { get; set; }
        public int? ClientId { get; set; }
        public byte[]? Image { get; set; }
        public string? Stage { get; set; }

        public Collection() {
            Id = 0;
            CoinName = string.Empty;
            Description = string.Empty;
            Cost = 0;
            Image = new byte[0];
            ClientId = 0;
            Stage = stage.none.ToString();
        }

        public Collection(int id, string coinName, string description, int cost, int clientId, string stage)
        {
            Id = id;
            CoinName = coinName;
            Description = description;
            Cost = cost;
            ClientId = clientId;
            Stage = stage;
        }

        public Collection(string coinName, string description, int cost, int clientId, string stage)
        {
            CoinName = coinName;
            Description = description;
            Cost = cost;
            ClientId = clientId;
            Stage = stage;
        }

        public Collection(string coinName, string description, int cost, int clientId, string stage, byte[] image)
        {
            CoinName = coinName;
            Description = description;
            Cost = cost;
            ClientId = clientId;
            Stage = stage;
            this.Image = image;
        }

        public Image? LoadImage() 
        {
            Image? img = null;
            OpenFileDialog files = new OpenFileDialog();
            files.Filter = "*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*";
            files.ShowDialog();
            if (!string.IsNullOrEmpty(files.FileName))
            {
                img = System.Drawing.Image.FromFile(files.FileName);
                Image = ConvertImageToByte(img);
            }
            return img;
        }

        public byte[] ConvertImageToByte(Image img)
        {
            int maxWidth = 300, maxHeight = 300;
            //размеры выбраны произвольно
            double ratioX = (double)maxWidth / img.Width;
            double ratioY = (double)maxHeight / img.Height;
            double ratio = Math.Min(ratioX, ratioY);
            int newWidth = (int)(img.Width * ratio);
            int newHeight = (int)(img.Height * ratio);
            Image mi = new Bitmap(newWidth, newHeight);
            //рисунок в памяти
            Graphics g = Graphics.FromImage(mi);
            g.DrawImage(img, 0, 0, newWidth, newHeight);
            MemoryStream ms = new MemoryStream();
            //поток для ввода|вывода байт из памяти
            mi.Save(ms, ImageFormat.Jpeg);
            ms.Flush();//выносим в поток все данные из буфера
            ms.Seek(0, SeekOrigin.Begin);
            BinaryReader br = new BinaryReader(ms);
            byte[] buf = br.ReadBytes((int)ms.Length);
            return buf;
        }

        public Image ConvertByteToImage()
        {
            if (Image != null && Image.Length!=0)
            {
                MemoryStream ms = new MemoryStream(Image);
                return System.Drawing.Image.FromStream(ms);
            }
            else
            {
                return System.Drawing.Image.FromFile("C:\\Users\\User\\OneDrive\\Documents\\GitHub\\Numismatics\\Images\\WithoutPhoto.jpg");
            }
        }
    }
}
