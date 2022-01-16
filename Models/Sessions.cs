using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpliLearnWebApp.Models
{
    public class Sessions
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool Approved { get; set; }

        public Sessions(int id, string title, string description, bool approved)
        {
            Id = id;
            Title = title;
            Description = description;
            Approved = approved;
        }
    }
}
