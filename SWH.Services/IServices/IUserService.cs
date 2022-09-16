namespace SWH.Services.IServices
{
    using Data.Models;

    public interface IUserService
    {
        public LoginDto Login(LoginUserDto user);
    }
}