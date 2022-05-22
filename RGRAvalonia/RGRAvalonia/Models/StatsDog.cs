using System;
using System.Collections.Generic; ;

namespace RGRAvalonia
{
    public partial class StatsDog
    {
        public StatsDog()
        {
            Trainers = new HashSet<Trainer>();
        }
            

        public string Nickname { get; set; }
        public string Breed { get; set; }
        public string Type_race { get; set; }


        public virtual Trainer Trainers { get; set; }
    }
    
}
    
     

    
