

namespace LeapYears
{
    public class LeapYearsTest
    {
        [Fact]
        public void Debe_devolver_false_si_el_año_no_es_biciesto()
        {
            bool añoBiciesto = ProcesadorAños.ValidarAñoBiciesto(1993);
            Assert.False(añoBiciesto);
        }

        [Fact]
        public void Debe_devolver_true_si_el_año_es_biciesto()
        {
            bool añoBiciesto = ProcesadorAños.ValidarAñoBiciesto(1996);
            Assert.True(añoBiciesto);
        }



    }

    internal class ProcesadorAños
    {
        internal static bool ValidarAñoBiciesto(int año)
        {
            return false;
        }
    }
}