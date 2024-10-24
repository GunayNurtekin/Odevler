using System.ComponentModel;
using BlogApp.Models;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Mvc;

namespace BlogApp.Controllers
{
    public class BlogController : Controller
    {
        // GET: BlogController
        public ActionResult Index()
        {

            var blogposts = new List<BlogModel> 
            {
                new BlogModel{ Title="Page Title 1" , Desc="Blog Posting 1" , img="https://picsum.photos/200/300" },
                new BlogModel{ Title="Page Title 2" , Desc="Blog Posting 2" , img="https://picsum.photos/200/300" },
                new BlogModel{ Title="Page Title 3" , Desc="Blog Posting 3" , img="https://picsum.photos/200/300" },
                new BlogModel{ Title="Page Title 4" , Desc="Blog Posting 4" , img="https://picsum.photos/200/300" },
                new BlogModel{ Title="Page Title 5" , Desc="Blog Posting 5" , img="https://picsum.photos/200/300" },
                new BlogModel{ Title="Page Title 6" , Desc="Blog Posting 6" , img="https://picsum.photos/200/300" },
                new BlogModel{ Title="Page Title 7"  , Desc="Blog Posting 7" , img="https://picsum.photos/200/300" },
                new BlogModel{ Title="Page Title 8" , Desc="Blog Posting 8" , img="https://picsum.photos/200/300" },
                new BlogModel{ Title="Page Title 9" , Desc="Blog Posting 9" , img="https://picsum.photos/200/300" },
                new BlogModel{ Title="Page Title 10" , Desc="Blog Posting 10" , img="https://picsum.photos/200/300" },

            };

            
            return View(blogposts);
        }

    }
}
