using System;
using System.Collections.Generic;
using System.Text;

namespace Estudos_EntityFrameork.Domain
{
    public class Carros
    {
        public string Model { get; set; }
        public string Marca { get; set; }
        public bool Automatico { get; set; }
        public int Ano { get; set; }

        public bool AVenda { get; set; }
    }
}
