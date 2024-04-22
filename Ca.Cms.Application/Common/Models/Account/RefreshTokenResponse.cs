using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ca.Cms.Application.Common.Models.Account
{
    public class RefreshTokenResponse
    {
        public string Id { get; set; }
        public string? RefreshToken { get; set; }
    }
}
