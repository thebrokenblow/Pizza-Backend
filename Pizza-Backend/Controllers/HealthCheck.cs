using Microsoft.AspNetCore.Mvc;

namespace Pizza_Backend.Controllers;

public class HealthCheck : Controller
{
    public string Cheach() => 
        "Check";
}