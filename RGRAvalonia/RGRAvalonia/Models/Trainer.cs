using System;
using Sysytem.Collections.Generic;

namespace RGRAvalonia
{
    public partial class Trainer
    {
        public Tainer()
        {
            StatisticDog = new HashSet<StatsDog>();
        }

        public string Name { get; set; }
        public int Num_runners { get; set; }
    }

    public virtual ICollection<StatsDod>StatisticDog { get; set; }
}
