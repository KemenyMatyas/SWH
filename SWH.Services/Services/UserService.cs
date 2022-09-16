namespace SWH.Services.Services
{
    using Data.Models;
    using IServices;
    using System.Linq;

    public class UserService : IUserService
    {
        private readonly IDataAccess _dataAccess;
        
        

        public UserService(IDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }


        public LoginDto Login(LoginUserDto user)
        {
            var loginUser = _dataAccess.LoginUserData(user);
            if (loginUser != null)
            {
                return new LoginDto
                {
                    Person = loginUser,
                    IsLogin = true
                };
            }

            return new LoginDto
            {
                IsLogin = false
            };
        }

       
    }
}