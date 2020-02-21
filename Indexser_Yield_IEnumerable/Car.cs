using System;
using System.Collections.Generic;
using System.Text;

namespace Indexser_Yield_IEnumerable
{
    public class Car
    {
        public string Name { get; set; }
        public string Number { get; set; }
        public override string ToString()
        {
            return $"Автомобиль - {Name} номер {Number}";
        }
    }
}
