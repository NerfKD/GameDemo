using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Entities
{
    public class Sales
    {
        public int Id { get; set; }
        public int GameId { get; set; }
        public int MemberId { get; set; }
        public int CampaingId { get; set; }
        public double PurchasePrice { get; set; }

    }
}
