using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Comprador
    {
        public int ID { get; set; }
        public string nombre { get; set; }
        public string dni { get; set; }


        public ICollection<Casa> Casa { get; set; }

    }
}
