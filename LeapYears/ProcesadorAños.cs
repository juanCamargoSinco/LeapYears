

namespace LeapYears
{
    public static class ProcesadorAños
    {
        public static bool ValidarAñoBisiesto(int año)
        {
            if(año % 400 == 0)
                return true;
            if (año % 100 == 0)
                return false;

            return año % 4 == 0;

            //return (año % 4 == 0 && (año % 100 != 0 || año % 400 == 0));

        }
    }
}