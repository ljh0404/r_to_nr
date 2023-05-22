using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;


namespace RtoNR.Models
{
    public class Registro
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        public string Nombre { get; set; }

        [ForeignKey(nameof(Padre))]
        public int? PadreId { get; set; }
        public Registro Padre { get; set; }

    }
}