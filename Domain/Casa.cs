using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domain
{

    public class Casa
    {

        public int ID { get; set; }
        public string calle { get; set; }
        public int numero { get; set; }
        public int CompradorID { get; set;}

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime ?RowVersion { get; set; }

        public Comprador Comprador { get; set; }

    }
}
