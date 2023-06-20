using UnitTest_Demo.Model;

namespace UnitTest_Demo.Data.Interface
{
    public interface IUser
    {
        List<User> GetAll();
        List<User> Search(string name);
        User Post(User user);
        User Put(User user);
        User GetUserByName(string name);
        List<User> Delete(int userID);
    }
}
