using System;
using System.Collections.Generic;


namespace RGRAvalonia
{
    public partial class Resault
    {
        public Resault()
        {
            Nicknames = new HashSet<StatsDog>();
            Dates = new HashSet<PlaceOfTheRace>();
        }


        public DateTime? Date { get; set; }
        public int StartPosotoin { get; set; }
        public DateTime? TimeRace { get; set; }
        public int Finish { get; set; }


        public virtual ICollection<StatsDog> Nicknames { get; set; }
        //public virtual StatsDog Nicknames { get; set; }???????
        public virtual ICollection<PlaceOfTheRace> Dates { get; set; }

    }
}
