using System;
using System.Collections.Generic;
using System.Text;

namespace Worker.entities
{
    class Departament
    {
        public string Name { get; set; }

        public Departament()
        {

        }
        public Departament(string nome)
        {
            Name = nome;
        }
    }
}
