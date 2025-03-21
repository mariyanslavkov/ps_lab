using Welcome.Model;
using Welcome.View;
using Welcome.ViewModel;
using Welcome.Others;
using System.Runtime.InteropServices;

namespace WelcomeExtended
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var user = new User
                {
                    Name = "John Smith",
                    Password = "password123",
                    FacultyNumber = "121222144",
                    Email = "what@what.what",
                    Roles = UserRolesEnum.STUDENT
                };

                var viewModel = new UserViewModel(user);
                var view = new UserView(viewModel);
                view.Display();
                view.DisplayError();
            }
            catch (Exception e)
            {
                var log = new ActionOnError(Others.Delegates.Log);
                log(e.Message);
            }
            finally
            {
                Console.WriteLine("Executed in any case!");
            }
        }
    }
}