using test2.Models;

namespace test2.Repository
{
    public class InMemUserTblRep :IUserTbl
    {
        private List<UserTbl> _user;
        public InMemUserTblRep()
        {
           _user = new() { new UserTbl { Id = 1, Age = 25, Family = "Abbasi", Name = "Mohammad" } };
        }

        public void CreateUser(UserTbl user)
        {
            _user.Add(user);
        }

        public void DeleteUser(int id)
        {
            var user = _user.FindIndex(x=>x.Id==id);
            if (user>-1)
            {
                _user.RemoveAt(user);
            }
        }

        public UserTbl GetUserTbl(int id)
        {
            var user = _user.Where(x=>x.Id == id).FirstOrDefault();
            return user;
        }

        public IEnumerable<UserTbl> GetUserTbls()
        {
            return _user;
        }

        public void UpdateUser(int id, UserTbl user)
        {
            var User = _user.FindIndex(x => x.Id == id);
                if (User>-1)
            {
                _user[User] = user;
            }
        }
    }
}
