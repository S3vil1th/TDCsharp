using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using WpfApplication1.Model;


namespace WpfApplication1.CodeFirst
{
    public class ContactContext:DbContext
    {
        public ContactContext () : base("lesDepenses")
        { }
        public DbSet<Personne> Personne { get; set; }
        public DbSet<Depense> Depense { get; set; }
    }
}
