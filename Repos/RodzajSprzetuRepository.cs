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
    public class RodzajSprzetuRepository : IDataRepository<RodzajSprzetu>
    {
        private ApplicationDbContext _context;

        public RodzajSprzetuRepository (ApplicationDbContext context)
        {
            _context = context;
        }

        public List<RodzajSprzetu> GetAll ()
        {
            return _context.RodzajeSprzetow
                .ToList();
        }

        public RodzajSprzetu Get (string id)
        {
            var model = _context.RodzajeSprzetow
                .FirstOrDefault (f=> f.RodzajSprzetuId == id);
            return model;
        }

        public void Create (RodzajSprzetu model)
        {
            if (model != null)
            {
                try
                {
                    _context.RodzajeSprzetow.Add(model);
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
                var model = _context.RodzajeSprzetow.FirstOrDefault (f=>f.RodzajSprzetuId == id);
                if (model != null)
                {
                    _context.RodzajeSprzetow.Remove(model);
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

        public void Update (RodzajSprzetu model)
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
