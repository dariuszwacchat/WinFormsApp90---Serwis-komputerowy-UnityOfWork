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
    public class WolneLicencjeRepository : IDataRepository<WolnaLicencja>
    {
        private ApplicationDbContext _context;

        public WolneLicencjeRepository (ApplicationDbContext context)
        {
            _context = context;
        }

        public List<WolnaLicencja> GetAll ()
        {
            return _context.WolneLicencje
                .Include (i=> i.WolnaLicencjaZalaczniki)
                .ToList();
        }

        public WolnaLicencja Get (string id)
        {
            var model = _context.WolneLicencje
                .Include (i=> i.WolnaLicencjaZalaczniki)
                .FirstOrDefault (f=> f.WolnaLicencjaId == id);
            return model;
        }

        public void Create (WolnaLicencja model)
        {
            if (model != null)
            {
                try
                {
                    _context.WolneLicencje.Add(model);
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
                var model = _context.WolneLicencje.FirstOrDefault (f=>f.WolnaLicencjaId == id);
                if (model != null)
                {
                    _context.WolneLicencje.Remove(model);
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

        public void Update (WolnaLicencja model)
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
