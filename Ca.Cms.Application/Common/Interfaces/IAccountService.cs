using Ca.Cms.Application.Common.Models.Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ca.Cms.Application.Common.Interfaces
{
    public interface IAccountService
    {
        Task<AuthenticationResponse?> AuthenticateAsync(AuthenticationRequest request);

        Task LogoutAsync();

        Task<bool> IsInRoleAsync(string userId, string role);

        Task<AuthenticationResponse?> RegisterAsync(RegisterRequest request);

        Task<string?> GetUserNameAsync(string userId);

        Task<bool> ActivateUserAsync(string userId, string code);

        Task<bool> IsUserExist(string email);
    }
}
