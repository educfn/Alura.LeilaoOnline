using Alura.LeilaoOnline.Core;

namespace Alura.LeilaoOnline.ConsoleApp
{
    class Program
    {
        private static void LeilaoComVariosLen()
        {
            //Arrange - cenário
            var leilao = new Leilao("Van Gogh");
            var fulano = new Interessada("Fulano", leilao);
            var maria = new Interessada("Maria", leilao);

            leilao.RecebeLance(fulano, 800);
            leilao.RecebeLance(maria, 900);
            leilao.RecebeLance(fulano, 1000);
            leilao.RecebeLance(maria, 990);

            //Act - método sob teste
            leilao.TerminaPregao();

            //Assert
            var valorEsperado = 1000;
            var valorObtido = leilao.Ganhador.Valor;

            if (valorEsperado == valorObtido)
            {
                Console.WriteLine("TESTE OK");
            }
            else
            {
                Console.WriteLine("TESTE FALHOU");
            }
        }

        static void Main()
        {
        }
    }
}