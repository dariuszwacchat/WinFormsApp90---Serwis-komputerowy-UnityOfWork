using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp90.Data;
using WinFormsApp90.Models;

namespace WinFormsApp90.Repos
{
    public class RolesRepository : IDataRepository<ApplicationRole>
    {
        private ApplicationDbContext _context;

        public RolesRepository (ApplicationDbContext context)
        {
            _context = context;
        }

        public List<ApplicationRole> GetAll ()
        {
            return _context.Roles
                .ToList();
        }

        public ApplicationRole Get (string id)
        {
            var model = _context.Roles
                .FirstOrDefault (f=> f.Id == id);
            return model;
        }

        public void Create (ApplicationRole model)
        {
            if (model != null)
            {
                try
                {
                    _context.Roles.Add(model);
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

        public void Delete (string id)
        {
            try
            {
                var model = _context.Roles.FirstOrDefault (f=>f.Id == id);
                if (model != null)
                {
                    _context.Roles.Remove(model);
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

        public void Update (ApplicationRole model)
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
