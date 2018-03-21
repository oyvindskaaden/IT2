using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChartTing
{
    class Karakterer
    {
        string name;

        int[] karakterer;

        public Karakterer(string n, int[] k)
        {
            name = n;
            karakterer = k;
        }

        public string Name { get { return name; } }

        public int[] Karakter { get { return karakterer; } }

    }
}
