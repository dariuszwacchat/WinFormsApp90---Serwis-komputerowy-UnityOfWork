using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp90.Data;

namespace WinFormsApp90.Repos
{
    public class UsersRolesRepository : IIdentityUserRole
    {
        private readonly ApplicationDbContext _context;

        public UsersRolesRepository (ApplicationDbContext context)
        {
            _context = context;
        }

        public List<IdentityUserRole<string>> GetAll ()
        {
            return _context.UserRoles.ToList();
        }

        public IdentityUserRole<string> Get (string userId, string roleId)
        {
            return _context.UserRoles.FirstOrDefault(f => f.UserId == userId && f.RoleId == roleId);
        }

        public void Create (IdentityUserRole<string> model)
        {
            if (model != null)
            {
                try
                {
                    _context.UserRoles.Add(model);
                    _context.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Błąd podczas tworzenia rekordu. Metoda 'Create'.");
                }
            }
            else
            {
                MessageBox.Show("Błąd metody 'Create'. 'model' null");
            }
        }

        public void Delete (string userId, string roleId)
        {
            try
            {
                var model = _context.UserRoles.FirstOrDefault (f=>f.UserId == userId && f.RoleId == roleId);
                if (model != null)
                {
                    _context.UserRoles.Remove(model);
                    _context.SaveChanges();
                }
                else
                {
                    MessageBox.Show("Metoda 'Delete'. 'model' null");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Błąd podczas usuwania rekordu. Metoda 'Delete'.");
            }
        }

        public void Update (IdentityUserRole<string> model)
        {
            if (model != null)
            {
                try
                {
                    _context.Entry(model).State = EntityState.Modified;
                    _context.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Błąd podczas aktualizowania rekordu. Metoda 'Update'.");
                }
            }
            else
            {
                MessageBox.Show("Błąd metody 'Update'. 'model' null");
            }

        }
    }
}
