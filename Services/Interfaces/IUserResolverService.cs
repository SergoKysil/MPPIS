using System.Collections.Generic;
using System.Security.Claims;

namespace MPPIS.Services.Interfaces
{
    public interface IUserResolverService
    {
        public int GetUserId();

        public IEnumerable<Claim> GetClaims();

        public bool IsUserAdmin();

    }
}
