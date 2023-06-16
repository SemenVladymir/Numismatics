using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numismatics.Models
{
    public class Blogging
    {
        public int Id { get; set; }
        public int ClientId { get; set;}
        public DateTime DateNTime { get; set; }
        public string Description { get; set; }

        public Blogging()
        {
            Id = 0;
            ClientId = 0;
            DateNTime = DateTime.Now;
            Description = string.Empty;
        }

        public Blogging(int id, int clientId, DateTime dateNTime, string description)
        {
            Id = id;
            ClientId = clientId;
            DateNTime = dateNTime;
            Description = description;
        }


        public Blogging(int clientId, DateTime dateNTime, string description)
        {
            ClientId = clientId;
            DateNTime = dateNTime;
            Description = description;
        }

        public override string ToString()
        {
            return $"\n{DateNTime}\n{Description}\n";
        }
    }


}
