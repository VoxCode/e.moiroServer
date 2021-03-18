using System.Collections.Generic;

namespace e.moiroServer.Services
{
    public interface IIdentityService
    {
        string GenerateJwtToken(string userId, string userName, string secret, IList<string> roles);
    }
}
