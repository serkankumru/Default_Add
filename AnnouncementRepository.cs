using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class AnnouncementRepository:BaseRepository<Announcement>
    {
        public AnnouncementRepository()
        {
            try
            {
                var a = base.List().First();
            }
            catch (Exception)
            {
                Announcement a1 = new Announcement();
                Announcement a2 = new Announcement();
                Announcement a3 = new Announcement();
                Announcement a4 = new Announcement();
                Announcement a5 = new Announcement();


                a1.Title = "Fully Responsive Design";
                a1.Description = "When you use a theme created by Start Bootstrap, you know that the theme will look great on any device, whether it's a phone, tablet, or desktop the page will behave responsively!";
                a1.IsActive = true;
                a1.CreateDate = DateTime.Now;


                a2.Title = "Updated For Bootstrap 4";
                a2.Description = "Newly improved, and full of great utility classes, Bootstrap 4 is leading the way in mobile responsive web development! All of the themes on Start Bootstrap are now using Bootstrap 4!";
                a2.IsActive = true;
                a2.CreateDate = DateTime.Now;

                a3.Title = "Easy to Use & Customize";
                a3.Description = "Landing Page is just HTML and CSS with a splash of SCSS for users who demand some deeper customization options. Out of the box, just add your content and images, and your new landing page will be ready to go!";
                a3.IsActive = true;
                a3.CreateDate = DateTime.Now;

                a4.Title = "Fully Responsive Design";
                a4.Description = "When you use a theme created by Start Bootstrap, you know that the theme will look great on any device, whether it's a phone, tablet, or desktop the page will behave responsively!";
                a4.IsActive = true;
                a4.CreateDate = DateTime.Now;


                a5.Title = "Updated For Bootstrap 4";
                a5.Description = "Newly improved, and full of great utility classes, Bootstrap 4 is leading the way in mobile responsive web development! All of the themes on Start Bootstrap are now using Bootstrap 4!";
                a5.IsActive = true;
                a5.CreateDate = DateTime.Now;

                base.Add(a1);
                base.Add(a2);
                base.Add(a3);
                base.Add(a4);
                base.Add(a5);
            }
        }
    }
}
