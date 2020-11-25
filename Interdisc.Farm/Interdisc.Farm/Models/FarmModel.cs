using System;

namespace Interdisc.Farm.Models
{
    public class FarmModel
    {
        public int FarmID { get; set; }
        public string Name { get; set; }



public FarmModel (int farmid, string name)
        {
            FarmID = farmid;
            Name = name;
        }
    }
}
