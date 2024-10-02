using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaces
{
    internal class Cachorro : ISerVivo
    {
        void ISerVivo.Comer()
        {
            throw new NotImplementedException();
        }

        void ISerVivo.Dormir()
        {
            throw new NotImplementedException();
        }

        void ISerVivo.Morrer()
        {
            throw new NotImplementedException();
        }

        void ISerVivo.Respirar()
        {
            throw new NotImplementedException();
        }
    }
}
