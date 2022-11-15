using InnogotchiFarm.DataTransferObjects;

namespace InnogotchiFarm.Contracts
{
    public interface IAuthenticationManager
    {
        Task<bool> ValidateUser(UserForAuthenticationDto userForAuth);
        Task<string> CreateToken();
    }
}
