using FlowCoach.Entities;

namespace FlowCoach.DataAccess
{
    public class UserRepository : IUserRepository, IRepository<User>
    {
        public UserRepository(DataContext dataContext) : base(dataContext)
        {
        }
        public void Add(User entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(User entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> GetAll()
        {
            throw new NotImplementedException();
        }

        public User GetBy(int id)
        {
            throw new NotImplementedException();
        }

        public bool Login(string username, string password)
        {


        }

        public void Update(User entity)
        {
            throw new NotImplementedException();
        }
    }
}
