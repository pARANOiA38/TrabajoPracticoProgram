using System;
using System.Collections.Generic;
using System.Text;

namespace Logica
{
    public class ClasePrincipal //Singleton
    {
        public List<Institucion> ListaInstituciones { get; set; }
        public List<Padre> ListaPadres { get; set; }
        public List<Docente> ListaDocentes { get; set; }
        public List<Director> ListaDirectores { get; set; }
    }
}
