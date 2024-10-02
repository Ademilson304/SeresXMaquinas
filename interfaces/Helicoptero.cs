using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaces
{
    internal class Helicoptero : IMaquina, Ivoador
    {
        void IMaquina.Abastecer()
        {
            throw new NotImplementedException();
        }

        void Ivoador.Cair()
        {
            throw new NotImplementedException();
        }

        void Ivoador.Decolar()
        {
            throw new NotImplementedException();
        }

        void IMaquina.Deslugar()
        {
            throw new NotImplementedException();
        }

        void IMaquina.emitirAlerta()
        {
            throw new NotImplementedException();
        }

        void IMaquina.ligar()
        {
            throw new NotImplementedException();
        }

        void Ivoador.Planar()
        {
            throw new NotImplementedException();
        }

        void Ivoador.Pousar()
        {
            throw new NotImplementedException();
        }
    }
}
