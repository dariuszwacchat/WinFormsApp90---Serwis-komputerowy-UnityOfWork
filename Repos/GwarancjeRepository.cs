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
    public class GwarancjeRepository : IDataRepository<Gwarancja>
    {
        private ApplicationDbContext _context;

        public GwarancjeRepository (ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Gwarancja> GetAll ()
        {
            return _context.Gwarancje
                .Include (i=> i.GwarancjaZdjecia)
                .ToList();
        }

        public Gwarancja Get (string id)
        {
            var model = _context.Gwarancje
                .Include (i=> i.GwarancjaZdjecia)
                .FirstOrDefault (f=> f.GwarancjaId == id);
            return model;
        }

        public void Create (Gwarancja model)
        {
            if (model != null)
            {
                try
                {
                    _context.Gwarancje.Add(model);
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
                var model = _context.Gwarancje.FirstOrDefault (f=>f.GwarancjaId == id);
                if (model != null)
                {
                    _context.Gwarancje.Remove(model);
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

        public void Update (Gwarancja model)
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
