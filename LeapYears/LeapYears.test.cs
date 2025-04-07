

namespace LeapYears
{
    public class LeapYearsTest
    {
        [Fact]
        public void Debe_devolver_false_si_el_año_no_es_bisiesto()
        {
            bool añoBisiesto = ProcesadorAños.ValidarAñoBisiesto(1993);
            Assert.False(añoBisiesto);
        }

        [Fact]
        public void Debe_devolver_true_si_el_año_es_bisiesto()
        {
            bool añoBisiesto = ProcesadorAños.ValidarAñoBisiesto(1996);
            Assert.True(añoBisiesto);
        }

        [Fact]
        public void Debe_devolver_año_es_bisiesto_si_el_año_es_divisible_por_4()
        {
            bool añoBisiesto = ProcesadorAños.ValidarAñoBisiesto(2004);
            Assert.True(añoBisiesto);
        }



    }

    internal class ProcesadorAños
    {
        internal static bool ValidarAñoBisiesto(int año)
        {
            if (año % 4 == 0) 
                return true;

            return false;
        }
    }
}