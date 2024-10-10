using FlowCoach.Entities;

namespace FlowCoach.DataAccess
{
    public interface IUserRepository : IRepository<User>
    {

        bool Login(string username, string password);

    }
}
