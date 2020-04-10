using Microsoft.AspNetCore.Mvc;
using SciCo.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SciCo.ViewComponents
{
    public class _LeftAsideViewComponent : ViewComponent
    {
        private readonly AppDbContext _db;
        public _LeftAsideViewComponent(AppDbContext db)
        {
            _db = db;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View(await Task.FromResult(_db.LeftAsides));
        }
    }
}
