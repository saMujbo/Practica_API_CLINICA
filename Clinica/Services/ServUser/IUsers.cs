using Entidades;

namespace Services.ServUser
{
    public interface IUsers
    {
        public User AddUser(User user);
        List<User> UsersList();
    }
}
