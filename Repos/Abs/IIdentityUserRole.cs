using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp90.Data
{
    public interface IIdentityUserRole
    {
        List <IdentityUserRole<string>> GetAll ();
        IdentityUserRole<string> Get (string userId, string roleId);
        void Create (IdentityUserRole<string> model);
        void Delete (string userId, string roleId);
        void Update (IdentityUserRole<string> model);
    }
}
