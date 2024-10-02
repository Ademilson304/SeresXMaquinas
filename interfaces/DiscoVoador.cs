
namespace interfaces
{
    internal class DiscoVoador : IMaquina, IPairador, Ivoador
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

        void IPairador.Pairar()
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
