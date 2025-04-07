

namespace LeapYears
{
    public class LeapYearsTest
    {
        [Fact]
        public void Debe_devolver_false_si_el_a�o_no_es_bisiesto()
        {
            bool a�oBisiesto = ProcesadorA�os.ValidarA�oBisiesto(1993);
            Assert.False(a�oBisiesto);
        }

        [Fact]
        public void Debe_devolver_true_si_el_a�o_es_bisiesto()
        {
            bool a�oBisiesto = ProcesadorA�os.ValidarA�oBisiesto(1996);
            Assert.True(a�oBisiesto);
        }

        [Fact]
        public void Debe_devolver_a�o_es_bisiesto_si_el_a�o_es_divisible_por_4()
        {
            bool a�oBisiesto = ProcesadorA�os.ValidarA�oBisiesto(2004);
            Assert.True(a�oBisiesto);
        }

        [Theory]
        [InlineData(1900)]
        [InlineData(2100)]
        [InlineData(1800)]
        [InlineData(1600)]
        public void Debe_devolver_false_si_el_a�o_es_divisible_por_4_y_tambien_es_divisible_por_100(int a�o)
        {
            bool a�oBisiesto = ProcesadorA�os.ValidarA�oBisiesto(a�o);
            Assert.False(a�oBisiesto);
        }

        [Fact]
        public void Debe_devolver_true_si_el_a�o_es_divisible_por_4_por_100_y_por_400()
        {
            bool a�oBisiesto = ProcesadorA�os.ValidarA�oBisiesto(1600);
            Assert.True(a�oBisiesto);
        }

    }

    internal class ProcesadorA�os
    {
        internal static bool ValidarA�oBisiesto(int a�o)
        {


            if (a�o % 4 == 0)
            {
                if (a�o % 100 == 0)
                    return false;

                return true;
            }
       

            return false;
        }
    }
}