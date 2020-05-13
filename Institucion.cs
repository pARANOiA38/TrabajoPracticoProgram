using System;
using System.Collections.Generic;
using System.Text;

namespace Logica
{
    public class Institucion
    {
        public Director DirectorTitular { get; set; }
        public List<Sala> ListaSalas { get; set; }
        public List<Docente> ListaDocentes { get; set; }
    }
}
