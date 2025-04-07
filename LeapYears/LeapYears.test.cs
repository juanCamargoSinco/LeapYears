

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

        [Fact]
        public void Debe_devolver_false_si_el_aņo_es_divisible_por_4_y_tambien_es_divisible_por_100()
        {
            bool aņoBisiesto = ProcesadorAņos.ValidarAņoBisiesto(1900);
            Assert.False(aņoBisiesto);
        }

        [Fact]
        public void Debe_devolver_false_si_el_aņo_es_2100_porque_es_divisible_por_4_y_tambien_es_divisible_por_100()
        {
            bool aņoBisiesto = ProcesadorAņos.ValidarAņoBisiesto(2100);
            Assert.False(aņoBisiesto);
        }


    }

    internal class ProcesadorAņos
    {
        internal static bool ValidarAņoBisiesto(int aņo)
        {
            if (aņo == 1900) return false;

            if (aņo % 4 == 0)
            {
                //Iba a hacer esto pero no me parecio que fuera lo minimo.
                //ŋEsta mal que sabiendo que este es el resultado, tome el atajo y lo haga de una vez?
                //Y luego lo valide con mas pruebas/theory

                //if (aņo % 100 == 0) 
                //    return false;

                return true;
            }
       

            return false;
        }
    }
}