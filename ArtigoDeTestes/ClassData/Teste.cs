using System.Collections;

namespace ArtigoDeTestes.ClassData
{

    public class Dados : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { 40, true };
            yield return new object[] { -2, false };
            yield return new object[] { 0, true };
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public class Teste
    {
        [Theory]
        [ClassData(typeof(Dados))]
        public void VerificaSeNumeroPositivo(int valor, bool resultadoEsperado)
        {
            var resultadoObtido = valor >= 0;
            Assert.Equal(resultadoEsperado, resultadoObtido);
        }
    }
}
