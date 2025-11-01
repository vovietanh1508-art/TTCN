using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aznews.Models;
using Microsoft.AspNetCore.Mvc;

namespace aznews.Components
{
  [ViewComponent(Name = "Post")]
    public class PostComponent : ViewComponent
    {
        private readonly Datacontext _context;

        public PostComponent(Datacontext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var listOfPost = (from p in _context.viewPostMenus
                              where p.IsActive == true
                              orderby p.PostID descending
                              select p)
                              .Take(8) // Lấy 8 bài viết mới nhất
                              .ToList();

            return await Task.FromResult((IViewComponentResult)View("Default", listOfPost));
        }
    }
}