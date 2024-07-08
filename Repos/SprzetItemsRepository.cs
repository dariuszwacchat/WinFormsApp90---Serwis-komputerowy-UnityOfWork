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
    public class SprzetItemsRepository : IDataRepository<SprzetItem>
    {
        private ApplicationDbContext _context;

        public SprzetItemsRepository (ApplicationDbContext context)
        {
            _context = context;
        }

        public List<SprzetItem> GetAll ()
        {
            return _context.SprzetItems
                .Include (i=> i.PolaItems)
                .ToList();
        }

        public SprzetItem Get (string id)
        {
            var model = _context.SprzetItems
                .Include (i=> i.PolaItems)
                .FirstOrDefault (f=> f.SprzetItemId == id);
            return model;
        }

        public void Create (SprzetItem model)
        {
            if (model != null)
            {
                try
                {
                    _context.SprzetItems.Add(model);
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
                var model = _context.SprzetItems.FirstOrDefault (f=>f.SprzetItemId == id);
                if (model != null)
                {
                    _context.SprzetItems.Remove(model);
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

        public void Update (SprzetItem model)
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
