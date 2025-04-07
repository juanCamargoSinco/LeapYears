

namespace LeapYears
{
    public class LeapYearsTest
    {
        [Fact]
        public void Debe_devolver_false_si_el_aņo_no_es_biciesto()
        {
            bool aņoBiciesto = ProcesadorAņos.ValidarAņoBiciesto(1993);
            Assert.False(aņoBiciesto);
        }


    }

    internal class ProcesadorAņos
    {
        internal static bool ValidarAņoBiciesto(int aņo)
        {
            return false;
        }
    }
}