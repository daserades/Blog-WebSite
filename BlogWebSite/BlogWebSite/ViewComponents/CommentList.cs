using BlogWebSite.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogWebSite.ViewComponents
{
    public class CommentList : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var commentvalues = new List<UserComment>
            {
                new UserComment
                {
                    ID=1,
                    Username="Elif"
                },
                new UserComment
                {
                    ID=2,
                    Username="Suat"
                },
                new UserComment
                {
                    ID=3,
                    Username="Derya"
                }
            };
           return View(commentvalues);
        }
    }
}
