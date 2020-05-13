using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Logica
{
    public class Padre : Persona
    {
        public List<Alumno> Hijos { get; set; }
    }
}
