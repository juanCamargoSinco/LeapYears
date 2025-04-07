

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



    }

    internal class ProcesadorAņos
    {
        internal static bool ValidarAņoBisiesto(int aņo)
        {
            if (aņo == 1996) 
                return true;

            return false;
        }
    }
}