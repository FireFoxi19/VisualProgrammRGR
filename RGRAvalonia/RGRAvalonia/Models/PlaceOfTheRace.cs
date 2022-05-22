using System;
using System.Collections.Generic;

namespace RGRAvalonia
{
    public partial class PlaceOfTheRace
    {
        public DateTime Date { get; set; }
        public int NumParticipans { get; set; }
        public string PlaceName { get; set; }
        public int Num_Winner { get; set; }

        public virtual Resault Resault { get; set; }
    }
}