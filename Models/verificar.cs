namespace ej5.Models;

public class verificar
{
    public bool puede(string nombre,int edad,int dni,string trabajo,int tipoEmpleo,int ingMensual,string otrasDeudas,bool tarjetaCredito,bool prestamoBancario,bool prestamoInformal,int montoSolicitado,int plazoDevolucion,string aceptaTerminos)
    {
        bool puede = false;

        double ingresoMensualPor5 = 5 * ingMensual;

        if (edad >= 18 && trabajo == "si" && ingMensual >= 250000 && otrasDeudas == "no" && aceptaTerminos == "on" && montoSolicitado < ingresoMensualPor5)
        {
            puede = true;
        }

        return puede;
    }
}