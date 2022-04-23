using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTrein.Logic.Enums
{
    public class Size
    {
        public enum SizeEnum
        {
            Small,
            Medium,
            Large
        }
        public SizeEnum GenerateSize()
        {
            Random rnd = new Random();
            int size = rnd.Next(0, 3);
            return (SizeEnum)size;
        }
    }
}
