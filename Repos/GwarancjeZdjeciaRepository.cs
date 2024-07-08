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
    public class GwarancjeZdjeciaRepository : IDataRepository <GwarancjaZdjecie>
    {
        private ApplicationDbContext _context;

        public GwarancjeZdjeciaRepository (ApplicationDbContext context)
        {
            _context = context;
        }

        public List<GwarancjaZdjecie> GetAll ()
        {
            return _context.GwarancjaZdjecia
                .ToList();
        }

        public GwarancjaZdjecie Get (string id)
        {
            var model = _context.GwarancjaZdjecia
                .FirstOrDefault (f=> f.GwarancjaZdjecieId == id);
            return model;
        }

        public void Create (GwarancjaZdjecie model)
        {
            if (model != null)
            {
                try
                {
                    _context.GwarancjaZdjecia.Add(model);
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
                var model = _context.GwarancjaZdjecia.FirstOrDefault (f=>f.GwarancjaZdjecieId == id);
                if (model != null)
                {
                    _context.GwarancjaZdjecia.Remove(model);
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

        public void Update (GwarancjaZdjecie model)
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
