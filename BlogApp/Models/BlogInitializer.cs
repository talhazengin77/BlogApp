using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BlogApp.Models
{
    public class BlogInitializer:DropCreateDatabaseIfModelChanges<BlogContext>
    {
        protected override void Seed(BlogContext context)
        {
            List<Category> categories = new List<Category>()
            {
                new Category(){CategoryName="C#"},
                new Category(){CategoryName="ASP.NET MVC"},
                new Category(){CategoryName="ASP.NET WebForm"},
                new Category(){CategoryName="ASP.NET WindowsForm"},
            };
            foreach (var item in categories)
            {
                context.Categories.Add(item);
            }
            context.SaveChanges();
            List<Blog> blogs = new List<Blog>()
            {
                new Blog(){Title="C# DelegatesC# DelegatesC# DelegatesC# DelegatesC# DelegatesC# DelegatesC# DelegatesC# Delegates",Description="C# DelegatesC# DelegatesC# DelegatesC# Delegates",Date=DateTime.Now.AddDays(-10),Home=true,Confirmation=true,Content="C# DelegatesC# DelegatesC# DelegatesC# DelegatesC# DelegatesC# DelegatesC# DelegatesC# Delegates",Picture="1.jpg",CategoryId=1},
                new Blog(){Title="C# Generic List",Description="C# Generic ListC# Generic ListC# Generic List",Date=DateTime.Now.AddDays(-8),Home=false,Confirmation=true,Content="C# Generic ListC# Generic ListC# Generic ListC# Generic ListC# Generic ListC# Generic List",Picture="2.jpg",CategoryId=2},
                new Blog(){Title="C# Generic List",Description="C# Generic ListC# Generic ListC# Generic List",Date=DateTime.Now.AddDays(-8),Home=true,Confirmation=true,Content="C# Generic ListC# Generic ListC# Generic ListC# Generic ListC# Generic ListC# Generic List",Picture="2.jpg",CategoryId=2},
                new Blog(){Title="C# Generic List",Description="C# Generic ListC# Generic ListC# Generic List",Date=DateTime.Now.AddDays(-8),Home=false,Confirmation=true,Content="C# Generic ListC# Generic ListC# Generic ListC# Generic ListC# Generic ListC# Generic List",Picture="2.jpg",CategoryId=2},
                new Blog(){Title="C# Generic List",Description="C# Generic ListC# Generic ListC# Generic List",Date=DateTime.Now.AddDays(-8),Home=true,Confirmation=true,Content="C# Generic ListC# Generic ListC# Generic ListC# Generic ListC# Generic ListC# Generic List",Picture="2.jpg",CategoryId=2},
                new Blog(){Title="C# Generic List",Description="C# Generic ListC# Generic ListC# Generic List",Date=DateTime.Now.AddDays(-8),Home=true,Confirmation=false,Content="C# Generic ListC# Generic ListC# Generic ListC# Generic ListC# Generic ListC# Generic List",Picture="2.jpg",CategoryId=2},
                new Blog(){Title="C# Generic List",Description="C# Generic ListC# Generic ListC# Generic List",Date=DateTime.Now.AddDays(-8),Home=true,Confirmation=true,Content="C# Generic ListC# Generic ListC# Generic ListC# Generic ListC# Generic ListC# Generic List",Picture="2.jpg",CategoryId=2},
                new Blog(){Title="C# Generic List",Description="C# Generic ListC# Generic ListC# Generic List",Date=DateTime.Now.AddDays(-8),Home=true,Confirmation=false,Content="C# Generic ListC# Generic ListC# Generic ListC# Generic ListC# Generic ListC# Generic List",Picture="2.jpg",CategoryId=2},

            };
            foreach (var item in blogs)
            {
                context.Blogs.Add(item);
            }
            context.SaveChanges();
            base.Seed(context);
        }
    }
}