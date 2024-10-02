namespace interfaces
{
    internal class Dragao : ISerVivo, Ivoador
    {
        void Ivoador.Cair()
        {
            Console.WriteLine("Cuspo fogo");
        }

        void ISerVivo.Comer()
        {
          
        }

        void Ivoador.Decolar()
        {
            
        }

        void ISerVivo.Dormir()
        {
            
        }

        void ISerVivo.Morrer()
        {
            
        }

        void Ivoador.Planar()
        {
        }

        void Ivoador.Pousar()
        {
        }

        void ISerVivo.Respirar()
        {
        }
    }
}
