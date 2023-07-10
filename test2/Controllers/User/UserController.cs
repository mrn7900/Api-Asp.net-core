using Microsoft.AspNetCore.Mvc;
using test2.Repository;
using test2.Models;
using test2.MySQLConnection;
using MySql.Data.MySqlClient;
using Microsoft.EntityFrameworkCore;

namespace test2.Controllers
{
    [ApiController]
    [Route("user")]
    public class UserController : ControllerBase
    {
        private IUserTbl _userTbl;
        private readonly DbContext DBContext1;

        public UserController(IUserTbl user , AppDbContext DBContext)
        {
            this.DBContext1 = DBContext;
            //for saving data
            _userTbl = user;
        }
        [HttpGet]
        public ActionResult<IEnumerable<UserTbl>> GetUsers()
        {
            //to store in database
           // var List = await DbContext1.
            //to showing in app
            return _userTbl.GetUserTbls().ToList();
        }

        [HttpGet("{id}")]
        public ActionResult<UserTbl> GetUser(int id)
        {
            var userrec = _userTbl.GetUserTbl(id);
            if (userrec == null)
            {
                return NotFound();
            }
            else
            {
                var user = new UserTbl
                {
                    Id = userrec.Id,
                    Name = userrec.Name,
                    Family = userrec.Family,
                    Age = userrec.Age
                };
            return user;
            }   
        }
        [HttpPost]
        public ActionResult CreateUser(UserTbl user)
        {

            var myuser = new UserTbl();
            myuser.Id = user.Id;
            myuser.Name = user.Name;
            myuser.Family = user.Family;
            myuser.Age = user.Age;
            
            _userTbl.CreateUser(myuser);
            return Ok();
        } 
        [HttpPut]
        public ActionResult UpdateUser(int id ,UserTbl user)
        {

            var myuser = new UserTbl();
            myuser.Id = user.Id;
            myuser.Name = user.Name;
            myuser.Family = user.Family;
            myuser.Age = user.Age;

            _userTbl.UpdateUser(id , myuser);
            return Ok();
        }
        [HttpDelete]
         public ActionResult DeleteUser(int id)
        {
            var myuser = _userTbl.GetUserTbl(id);
            _userTbl.DeleteUser(id);
            return Ok();
        }

    }
}
