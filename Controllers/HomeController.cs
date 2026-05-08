using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ej5.Models;

namespace ej5.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }
    [HttpPost]
public IActionResult GuardarDatos(
    string nombre,
    int edad,
    int dni,
    string trabajo,
    int tipoEmpleo,
    int ingMensual,
    string otrasDeudas,
    bool tarjetaCredito,
    bool prestamoBancario,
    bool prestamoInformal,
    int montoSolicitado,
    int plazoDevolucion,
    string aceptaTerminos)
{

    ViewBag.nombre = nombre;
    ViewBag.edad = edad;
    ViewBag.dni = dni;
    ViewBag.trabajo = trabajo;
    ViewBag.tipoEmpleo = tipoEmpleo;
    ViewBag.ingMensual = ingMensual;
    ViewBag.otrasDeudas = otrasDeudas;
    ViewBag.tarjetaCredito = tarjetaCredito;
    ViewBag.prestamoBancario = prestamoBancario;
    ViewBag.prestamoInformal = prestamoInformal;
    ViewBag.montoSolicitado = montoSolicitado;
    ViewBag.plazoDevolucion = plazoDevolucion;
    ViewBag.aceptaTerminos = aceptaTerminos;

     


    verificar ver = new verificar();

    bool puede = ver.puede(
        nombre,
        edad,
        dni,
        trabajo,
        tipoEmpleo,
        ingMensual,
        otrasDeudas,
        tarjetaCredito,
        prestamoBancario,
        prestamoInformal,
        montoSolicitado,
        plazoDevolucion,
        aceptaTerminos
    );
       ViewBag.puede = puede;

    return View();
}

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
