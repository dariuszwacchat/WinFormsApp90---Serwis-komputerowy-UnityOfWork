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
    public class NaprawyRepository : IDataRepository<Naprawa>
    {
        private ApplicationDbContext _context;

        public NaprawyRepository (ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Naprawa> GetAll ()
        {
            return _context.Naprawy
                .Include(i => i.Firma)
                .Include(i => i.Sprzet)
                    .ThenInclude(t => t.Pola)
                .ToList();
        }

        public Naprawa Get (string id)
        {
            var model = _context.Naprawy
                .Include(i => i.Firma)
                .Include(i => i.Sprzet)
                    .ThenInclude (t=> t.Pola)
                .FirstOrDefault (f=> f.NaprawaId == id);
            return model;
        }

        public void Create (Naprawa model)
        {
            if (model != null)
            {
                try
                {
                    _context.Naprawy.Add(model);
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
                var model = _context.Naprawy.FirstOrDefault (f=>f.NaprawaId == id);
                if (model != null)
                {
                    _context.Naprawy.Remove(model);
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

        public void Update (Naprawa model)
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
