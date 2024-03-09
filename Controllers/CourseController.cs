using basics.Models;
using Microsoft.AspNetCore.Mvc;


namespace basics.Controllers;
public class CourseController:Controller{
    public IActionResult Index()
    {
        var kurs = new Course();
        kurs.Id=1;
        kurs.Title="asp.net kursu";
        kurs.Description="güzel bir kurs";
        kurs.Image="1.jpeg";
        return View(kurs);
    }
     public IActionResult Details()
    {
        var kurs = new Course();
        kurs.Id=1;
        kurs.Title="asp.net kursu";
        kurs.Description="güzel bir kurs";
        kurs.Image="1.jpeg";
        return View(kurs);
    }
    public IActionResult List()
    {
        
        return View("List",Repository.Couses);
    }

}