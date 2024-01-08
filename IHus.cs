using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeAlongJanuar
{
    internal interface IHus
    {
        public int Room { get; set; }
        public int Floors { get; set; }


        public void AddRoom();

    }
}
