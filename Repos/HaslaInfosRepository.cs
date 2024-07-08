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
    public class HaslaInfosRepository : IDataRepository <HasloInfo>
    {
        private ApplicationDbContext _context;

        public HaslaInfosRepository (ApplicationDbContext context)
        {
            _context = context;
        }

        public List<HasloInfo> GetAll ()
        {
            return _context.HaslaInfos
                        .Include(i => i.Firma)
                        .Include(i => i.Sprzet)
                        .ToList();
        }

        public HasloInfo Get (string id)
        {
            var model = _context.HaslaInfos
                        .Include (i=> i.Firma)
                        .Include (i=> i.Sprzet)
                        .FirstOrDefault (f=> f.HasloInfoId == id);
            return model;
        }

        public void Create (HasloInfo model)
        {
            if (model != null)
            {
                try
                {
                    _context.HaslaInfos.Add(model);
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
                var model = _context.HaslaInfos.FirstOrDefault (f=>f.HasloInfoId == id);
                if (model != null)
                {
                    _context.HaslaInfos.Remove(model);
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

        public void Update (HasloInfo model)
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
