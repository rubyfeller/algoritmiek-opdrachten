using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTrein.Logic.Models
{
    // Base class
    public abstract class Animal
    {
        public Animal(int size)
        {
            Size = size;
        }

        public int Size { get; set; }
    }
}
