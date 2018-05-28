using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;


namespace Core2PolicyAuth.Controllers
{

  public class AdminController : Controller
  {
    private IConfiguration _config { get; }

    public AdminController(IConfiguration config)
    {
      _config = config;
    }
    
    public IActionResult Index()
    {
      @ViewBag.DevConnString = _config["ConnectionStrings:DevSQLServer"].ToString();
      return View();
    }




  }



}