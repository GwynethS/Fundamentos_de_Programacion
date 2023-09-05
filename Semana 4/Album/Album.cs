using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Album
{
    public class Album
    {
        public Album() { }
        public String Codigo { get; set; }
        public String Nombre { get; set; }
        public List<Heroe> heroes { get; set; }
    }
}
