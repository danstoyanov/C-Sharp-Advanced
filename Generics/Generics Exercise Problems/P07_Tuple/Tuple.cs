using System;
using System.Collections.Generic;
using System.Text;

namespace Tuple
{
    public class Tuple <TFrist, TSecond>
    {
        public Tuple(TFrist item1, TSecond item2)
        {
            this.Item1 = item1;
            this.Item2 = item2;
        }

        public TFrist Item1 { get; set; }
        public TSecond Item2 { get; set; }

        public override string ToString()
        {
            return $"{this.Item1} -> {this.Item2}";
        }
    }
}
