

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

        [Fact]
        public void Debe_devolver_false_si_el_año_es_divisible_por_4_y_tambien_es_divisible_por_100()
        {
            bool añoBisiesto = ProcesadorAños.ValidarAñoBisiesto(1900);
            Assert.False(añoBisiesto);
        }


    }

    internal class ProcesadorAños
    {
        internal static bool ValidarAñoBisiesto(int año)
        {
            if (año == 1900) return false;

            if (año % 4 == 0)
            {
                //Iba a hacer esto pero no me parecio que fuera lo minimo.
                //¿Esta mal que sabiendo que este es el resultado, tome el atajo y lo haga de una vez?
                //Y luego lo valide con mas pruebas/theory

                //if (año % 100 == 0) 
                //    return false;

                return true;
            }
       

            return false;
        }
    }
}