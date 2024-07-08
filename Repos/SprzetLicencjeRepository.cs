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
    public class SprzetLicencjeRepository : IDataRepository<SprzetLicencja>
    {
        private ApplicationDbContext _context;

        public SprzetLicencjeRepository (ApplicationDbContext context)
        {
            _context = context;
        }

        public List<SprzetLicencja> GetAll ()
        {
            return _context.SprzetLicencje
                .Include(i => i.Firma)
                .Include(i => i.Sprzet)
                .ToList();
        }

        public SprzetLicencja Get (string id)
        {
            var model = _context.SprzetLicencje
                .Include(i => i.Firma)
                .Include(i => i.Sprzet)
                .FirstOrDefault (f=> f.SprzetLicencjaId == id);
            return model;
        }

        public void Create (SprzetLicencja model)
        {
            if (model != null)
            {
                try
                {
                    _context.SprzetLicencje.Add(model);
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
                var model = _context.SprzetLicencje.FirstOrDefault (f=>f.SprzetLicencjaId == id);
                if (model != null)
                {
                    _context.SprzetLicencje.Remove(model);
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

        public void Update (SprzetLicencja model)
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
