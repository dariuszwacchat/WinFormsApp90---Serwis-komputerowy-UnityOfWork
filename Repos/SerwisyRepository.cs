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
    public class SerwisyRepository : IDataRepository<Serwis>
    {
        private ApplicationDbContext _context;

        public SerwisyRepository (ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Serwis> GetAll ()
        {
            return _context.Serwisy
                .Include(i => i.ApplicationUserSerwisy)
                    .ThenInclude(t => t.User)
                .Include(i => i.SerwisZalaczniki)
                .Include(i => i.Firma)
                .Include(i => i.Sprzet)
                .ToList();
        }

        public Serwis Get (string id)
        {
            var model = _context.Serwisy
                .Include(i => i.ApplicationUserSerwisy)
                    .ThenInclude(t => t.User)
                .Include(i => i.SerwisZalaczniki)
                .Include(i => i.Firma)
                .Include(i => i.Sprzet)
                .FirstOrDefault (f=> f.SerwisId == id);
            return model;
        }

        public void Create (Serwis model)
        {
            if (model != null)
            {
                try
                {
                    _context.Serwisy.Add(model);
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
                var model = _context.Serwisy.FirstOrDefault (f=>f.SerwisId == id);
                if (model != null)
                {
                    _context.Serwisy.Remove(model);
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

        public void Update (Serwis model)
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
