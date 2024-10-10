using FlowCoach.Entities;

namespace FlowCoach.DataAccess
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(DataContext dataContext) : base(dataContext)
        {
        }

        public bool Login(string email, string password)
        {
            if (dataContext.Users.Any(u => u.Email == email && u.Password == password))
            {
                return true;
            }
            return false;
        }
    }
}
