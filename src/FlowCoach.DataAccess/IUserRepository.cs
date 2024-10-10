using FlowCoach.Entities;

namespace FlowCoach.DataAccess
{
    public interface IUserRepository : IRepository<User>
    {

        bool Login(string email, string password);

    }
}
