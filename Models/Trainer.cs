using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpliLearnWebApp.Models
{
    public class Trainer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int? Exp { get; set; }
        public bool HasBlog { get; set; }
        public string BlogURL { get; set; }
        public WebBrowser Browser { get; set; }
        public virtual List<Certifications> Certifications { get; set; } = new List<Certifications>();
        public string Employer { get; set; }
        public int RegistrationFee { get; set; }
        public List<Sessions> Sessions { get; set; }

        public Trainer()
        {

        }

        public Trainer(int id, string firstName, string lastName, string email, int? exp, bool hasBlog, string blogURL, WebBrowser browser, List<Certifications> certifications, string employer, int registrationFee, List<Sessions> sessions)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Exp = exp;
            HasBlog = hasBlog;
            BlogURL = blogURL;
            Browser = browser;
            Certifications = certifications;
            Employer = employer;
            RegistrationFee = registrationFee;
            Sessions = sessions;
        }
    }
}
