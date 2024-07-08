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
    public class SprzetyRepository : IDataRepository<Sprzet>
    {
        private ApplicationDbContext _context;

        public SprzetyRepository (ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Sprzet> GetAll ()
        {
            return _context.Sprzet
                      .Include(i => i.Pola)
                      .Include(i => i.SprzetLicencje)
                      .Include(i => i.SprzetZdjecia)
                      .ToList();
        }

        public Sprzet Get (string id)
        {
            var model = _context.Sprzet
                      .Include(i => i.Pola)
                      .Include(i => i.SprzetLicencje)
                      .Include(i => i.SprzetZdjecia)
                      .FirstOrDefault (f=> f.SprzetId == id);
            return model;
        }

        public void Create (Sprzet model)
        {
            if (model != null)
            {
                try
                {
                    _context.Sprzet.Add(model);
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
                var model = _context.Sprzet.FirstOrDefault (f=>f.SprzetId == id);
                if (model != null)
                {
                    _context.Sprzet.Remove(model);
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

        public void Update (Sprzet model)
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
