using test2.Models;

namespace test2.Repository
{
    public interface IUserTbl
    {
        public IEnumerable<UserTbl>GetUserTbls();
        public UserTbl GetUserTbl(int id);
        public void CreateUser(UserTbl user);
        public void UpdateUser(int id,UserTbl user);
        public void DeleteUser(int id);

    }
}
