using Numismatics.Connection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numismatics.Models
{
    public class Trading
    {
        public int Id { get; set; }
        public int CoinId { get; set; }
        public int? StartCost { get; set;}
        public int? OfferPrice { get; set;}
        public int? EndCost { get; set; }
        public int? ClientIdWithOffer { get; set; }
        public string? Status { get; set; }

        public Trading()
        {
            Id = 0;
            CoinId = 0;
            StartCost = 0;
            OfferPrice = 0;
            EndCost = 0;
            ClientIdWithOffer = 0;
            Status = "none";
        }

        public Trading(int id, int coinId, int? startCost, int? offerPrice, int? endCost, int? clientIdWithOffer, string? status="none")
        {
            Id = id;
            CoinId = coinId;
            StartCost = startCost;
            OfferPrice = offerPrice;
            EndCost = endCost;
            ClientIdWithOffer = clientIdWithOffer;
            Status = status;
        }

        public Trading(int coinId, int? startCost, int? offerPrice, int? endCost, int? clientIdWithOffer, string? status="none")
        {
            CoinId = coinId;
            StartCost = startCost;
            OfferPrice = offerPrice;
            EndCost = endCost;
            ClientIdWithOffer = clientIdWithOffer;
            Status = status;
        }

        public List<Trading> GetTradingList()
        {
            List<Trading> trading = new List<Trading>();
            using (MyContext context = new MyContext())
            {
                trading = context.Tradings.ToList();
            }
            return trading;
        }

        public Trading GetTradingByCoinId(int coinId)
        {
            Trading trading = new Trading();
            using (MyContext context = new MyContext())
            {
                trading = context.Tradings.LastOrDefault(ee => ee.CoinId == coinId);
            }
            return trading;
        }

        public void StartSalling(Collection coin)
        {
            CoinId = coin.Id;
            StartCost = coin.Cost;
            Status = "salling";
            using (MyContext context = new MyContext())
            {
                context.Tradings.Add(this);
                context.SaveChanges();
            }
        }

        public void SetOfferPrice(int? clientId, int offer)
        {
            ClientIdWithOffer = clientId;
            OfferPrice = offer;
            using (MyContext context = new MyContext())
            {
                context.Tradings.Update(this);
                context.SaveChanges();
            }
        }

        public void StatusSalling(Collection coin, bool resulr)   // result - true is saled and false - rejected
        {
            if (resulr)
            {
                EndCost = OfferPrice;
                coin.ClientId = ClientIdWithOffer;
                coin.Cost = EndCost;
                Status = "Saled";
            }
            else
            {
                OfferPrice = 0;
                Status = "Reject";
            }
            using (MyContext context = new MyContext())
            {
                context.Tradings.Update(this);
                context.Collections.Update(coin);
                context.SaveChanges();
            }
        }

        public void StartExchanging(Collection coin)
        {
            CoinId = coin.Id;
            StartCost = coin.Cost;
            Status = "exchanging";
            using (MyContext context = new MyContext())
            {
                context.Tradings.Add(this);
                context.SaveChanges();
            }
        }

        public void StatusExchenging(Collection coin, bool resulr)   // result - true is saled and false - rejected
        {
            if (resulr)
            {
                coin.ClientId = ClientIdWithOffer;
                Status = "Accepted";
            }
            else
            {
                Status = "Reject";
            }
            using (MyContext context = new MyContext())
            {
                context.Tradings.Update(this);
                context.Collections.Update(coin);
                context.SaveChanges();
            }
        }

        public void RemoveTradingToCoinId(int coinId)
        {
            using (MyContext context = new MyContext())
            {
                context.Tradings.Remove(context.Tradings.LastOrDefault(x => x.CoinId.Equals(coinId)));
                context.SaveChanges();
            }
        }
    }
}
