using Microsoft.AspNetCore.Mvc;
using Project.Models;
using System.Collections.Generic;
using System.Linq;

namespace ToDoList.Controllers
{
  public class ItemsController : Controller
  {
    private readonly ProjectContext _db;

    public ItemsController(ProjectContext db)
    {
      _db = db;
    }

  }
}