using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ca.Cms.Infrastructure.Authentication
{
    public class ApplicationRole : IdentityRole
    {
        public ApplicationRole()
        {
        }

        public ApplicationRole(string roleName) : base(roleName)
        {
        }
    }
}
