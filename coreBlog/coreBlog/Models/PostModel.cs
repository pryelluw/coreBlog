using System;
using Slugify;
using Microsoft.AspNetCore.Identity;


namespace coreBlog.Models
{
    public class PostModel
    {
        public string Title { get; set; }
        public string Slug { get; set; }
        public string Body { get; set; }
        public DateTime Created { get; }
        //public IdentityUser User { get; set; }


        public PostModel(string title, string body, IdentityUser user)
        {
            SlugHelper slugHelper = new SlugHelper();

            this.Title = title;
            this.Body = body;
            this.Slug = slugHelper.GenerateSlug(title);
            this.Created = new DateTime();
            //this.User = user;
        }
    }
}
