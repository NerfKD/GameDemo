using GameDemo.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Entities
{
    public class Campaign: BaseProperty
    {
        public int Discount { get; set; }
        public string CampaignGame { get; set; }
    }
}
