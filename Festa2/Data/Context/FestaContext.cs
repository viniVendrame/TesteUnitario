using Data.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Context
{
    class FestaContext:DbContext
    {

        public DbSet<Salgado> Salgados { get; set; }

        public FestaContext():base("Data Source=192.168.0.117;Initial Catalog=Festa;Persist Security Info=True;User ID=UserFesta;Password=74269")
        {

        }
    }
}
