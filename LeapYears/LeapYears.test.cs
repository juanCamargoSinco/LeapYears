

namespace LeapYears
{
    public class LeapYearsTest
    {
        [Fact]
        public void Debe_devolver_false_si_el_aņo_no_es_bisiesto()
        {
            bool aņoBisiesto = ProcesadorAņos.ValidarAņoBisiesto(1993);
            Assert.False(aņoBisiesto);
        }

        [Fact]
        public void Debe_devolver_true_si_el_aņo_es_bisiesto()
        {
            bool aņoBisiesto = ProcesadorAņos.ValidarAņoBisiesto(1996);
            Assert.True(aņoBisiesto);
        }

        [Fact]
        public void Debe_devolver_aņo_es_bisiesto_si_el_aņo_es_divisible_por_4()
        {
            bool aņoBisiesto = ProcesadorAņos.ValidarAņoBisiesto(2004);
            Assert.True(aņoBisiesto);
        }

        [Theory]
        [InlineData(1900)]
        [InlineData(2100)]
        [InlineData(1800)]
        public void Debe_devolver_false_si_el_aņo_es_divisible_por_4_y_tambien_es_divisible_por_100(int aņo)
        {
            bool aņoBisiesto = ProcesadorAņos.ValidarAņoBisiesto(aņo);
            Assert.False(aņoBisiesto);
        }

    }

    internal class ProcesadorAņos
    {
        internal static bool ValidarAņoBisiesto(int aņo)
        {

            if (aņo % 4 == 0)
            {
                if (aņo % 100 == 0)
                    return false;

                return true;
            }
       

            return false;
        }
    }
}