[assembly: CollectionBehavior(CollectionBehavior.CollectionPerClass)]
namespace ArtigoDeTestes.Collection
{
    [Collection("OperaComNumero10")]
    
    public class PrimeiroTeste
    {
        [Fact]
        public void EsperarDezSegundos()
        {
            Thread.Sleep(10000);
        }
    }

    [Collection("OperaComNumero20")]
    public class SegundoTeste
    {
        [Fact(DisplayName ="robert deNiro")]
        public void EsperarCincoSegundos() 
        {
            Thread.Sleep(5000);
        }
    }
}
