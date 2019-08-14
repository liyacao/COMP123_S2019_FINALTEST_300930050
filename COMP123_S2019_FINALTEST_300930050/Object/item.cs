using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 *STUDENT NAME:liya cao
 *STUDENT ID:300930050
 *DESCRIPTION: This is the Item Class
 *             Used for Inventory Management
     */
namespace COMP123_S2019_FINALTEST_300930050.Object
{
    public class Item
    {
        public string Description { get; set; }
        public float Weight { get; set; }
        public int Cost { get; set; }

        public Item(string desc, float weight, int cost)
        {
            this.Cost = cost;
            this.Description = desc;
            this.Weight = weight;
        }

        public override string ToString()
        {
            return "Description : " + Description + " Weight : " + Weight + " Cost :" + Cost;
        }
    }
}
