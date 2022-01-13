using Microsoft.AspNetCore.Mvc;
using dotnetapi.Models;

namespace dotnetapi.Controllers
{
    [ApiController]
    [Route("users/")]
    public class UserController : ControllerBase
    {
        public static List<User> Userlist = new List<User>()
        {
        new User { CreatedAt = DateTime.Now, ID = 0, Email = "testuser1@testmail.com", Name = "testuser1", UserName = "testusr1" },
        new User { CreatedAt = DateTime.Now, ID = 1, Email = "testuser2@testmail.com", Name = "testuser2", UserName = "testusr2" },
        new User { CreatedAt = DateTime.Now, ID = 2, Email = "testuser3@testmail.com", Name = "testuser3", UserName = "testusr3" },
        new User { CreatedAt = DateTime.Now, ID = 3, Email = "testuser4@testmail.com", Name = "testuser4", UserName = "testusr4" },
        new User { CreatedAt = DateTime.Now, ID = 4, Email = "testuser5@testmail.com", Name = "testuser5", UserName = "testusr5" },
        };

        [HttpGet]
        [Route("[action]")]
        //"../user/GetUsers"
        public IEnumerable<User> GetUsers()
        {
            return Userlist;
        }
        [HttpGet]
        [Route("[action]")]
        //"../user/GetUserById"
        public User? GetUserByID(int id)
        {
            foreach (var user in Userlist)
            {
                if (user.ID == id)
                {
                    return user;
                }
            }
            return null;
        }
        [HttpPost]
        [Route("[action]")]
        public User AddUser(User user)
        {
            User newUser = new User();
            newUser.ID = user.ID;
            newUser.Email = user.Email;
            newUser.Name = user.Name;
            newUser.UserName = user.UserName;
            Userlist.Append(newUser);
            return newUser;
        }
        [HttpPut]
        [Route("[action]")]
        public User? UpdateUser(User _user)
        {
            foreach (var user in Userlist)
            {
                if (user.ID == _user.ID)
                {
                    user.Email = _user.Email;
                    user.Name = _user.Name;
                    user.UserName = _user.UserName;
                    user.UpdatedAT = DateTime.Now;
                }
            }
            return null;
        }
        [HttpDelete]
        [Route("[action]")]
        public User? DeleteUserByID(int id)
        {
            for (int i = 0; i < Userlist.Count; i++)
            {
                User user = Userlist[i];
                if (user.ID == id)
                {
                    Userlist.Remove(user);
                    Console.WriteLine(Userlist);
                    return user;
                }
            }
            return null;
        }
    }
}
