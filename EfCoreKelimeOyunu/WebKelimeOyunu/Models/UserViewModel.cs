using Entity.KelimeOyunu;

namespace WebKelimeOyunu.Models
{
    public class UserViewModel
    {
        public User User { get; set; }
        public IEnumerable<User> Gamers{get;set;}
        public IEnumerable<User> Admins{get;set;}
    }
}
