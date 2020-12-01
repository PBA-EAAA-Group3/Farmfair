using System;

namespace Interdisc.Farm.Models
{
    public class FarmModel
    {
        public int FarmModelId { get; set; }
        public string Name { get; set; }
        //public int ProductId { get; set; }
        //public virtual ProductModel ProductModel { get; set; }
        //public int ProductGroupModelId { get; set; }
        //public virtual ProductGroupModel ProductGroupModel { get; set; }


        public FarmModel() { }
public FarmModel (int farmid, string name)
        {
            FarmModelId = farmid;
            Name = name;
        }
    }
}
