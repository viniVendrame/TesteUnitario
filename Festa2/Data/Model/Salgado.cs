using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Model
{
    [Table("Salgados")]
    public class Salgado : BaseModel
    {
        public string Nome { get; set; }
        public string Sabor { get; set; }
    }
}
