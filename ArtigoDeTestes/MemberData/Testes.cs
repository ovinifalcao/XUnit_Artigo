using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtigoDeTestes.MemberData
{
    public class Testes
    {
        public static List<object[]> massaDeTestes = new List<object[]>()
        {
            new object[] { 2, 2, 4},
            new object[] { 1, 2, 2},
            new object[] { 0, 0, 0}
        };

        [Theory]
        [MemberData(nameof(massaDeTestes))]
        public void Soma(int n1, int n2, int resultadoEsperado)
        {
            var resultadoObtido = n1 + n2;
            Assert.Equal(resultadoEsperado, resultadoObtido);
        }

        [Theory]
        [MemberData(nameof(massaDeTestes))]
        public void Multiplicacao(int n1, int n2, int resultadoEsperado)
        {
            var resultadoObtido = n1 * n2;
            Assert.Equal(resultadoEsperado, resultadoObtido);
        }
    }
}
