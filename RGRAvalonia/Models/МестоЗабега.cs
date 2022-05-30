using System;
using System.Collections.Generic;

namespace RGRAvalonia
{
    public partial class МестоЗабега
    {
        public byte[] Date { get; set; } = null!;
        public byte[]? PlaceName { get; set; }
        public long? NumRunners { get; set; }
        public long? NumWinners { get; set; }
    }
}
