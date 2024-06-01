using Entidades;
using Microsoft.EntityFrameworkCore;
using Services.MyDbContext;

namespace Services.ServUser
{
    
    public class SvUser : IUsers
    {
        private MyContext _myDbecontext = default!;
        public SvUser() { 
            _myDbecontext = new MyContext();    
        }
        public User AddUser(User u)
        {
            _myDbecontext.Users.Add(u); 
            _myDbecontext.SaveChanges();

            return u;
        }

        public List<User> UsersList()
        {
            return _myDbecontext.Users.ToList();   
        }
    }
}
