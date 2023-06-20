using Microsoft.EntityFrameworkCore.Metadata.Internal;
using UnitTest_Demo.Data.Interface;
using UnitTest_Demo.Model;

namespace UnitTest_Demo.Data.Service
{
    public class UserService : IUser
    {
        private readonly DataContext _context;

        public UserService(DataContext context)
        {
            _context = context;
        }

        public List<User> Delete(int userID)
        {
            throw new NotImplementedException();
        }

        public List<User> GetAll()
        {
            var list = _context.Users.ToList();
            return list;
        }

        public User GetUserByName(string name)
        {
            User UserToSearch = _context.Users.FindAsync(name).Result;
                                                    
            return UserToSearch;
        }

        public User Post(User user)
        {
            throw new NotImplementedException();
        }

        public User Put(User user)
        {
            throw new NotImplementedException();
        }

        public List<User> Search(string name)
        {
            throw new NotImplementedException();
        }
    }
}
