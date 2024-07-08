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
    public class InformacjeSprzedazoweRepository : IDataRepository<InformacjeSprzedazowe>
    {
        private ApplicationDbContext _context;

        public InformacjeSprzedazoweRepository (ApplicationDbContext context)
        {
            _context = context;
        }

        public List<InformacjeSprzedazowe> GetAll ()
        {
            return _context.InformacjeSprzedazowe
                .Include(i => i.Firma)
                .Include(i => i.RodzajSprzetu)
                .Include(i => i.InformacjaSprzedazowaZalaczniki)
                .ToList();
        }

        public InformacjeSprzedazowe Get (string id)
        {
            var model = _context.InformacjeSprzedazowe
                .Include(i => i.Firma)
                .Include(i => i.RodzajSprzetu)
                .Include(i => i.InformacjaSprzedazowaZalaczniki)
                .FirstOrDefault (f=> f.InformacjeSprzedazoweId == id);
            return model;
        }

        public void Create (InformacjeSprzedazowe model)
        {
            if (model != null)
            {
                try
                {
                    _context.InformacjeSprzedazowe.Add(model);
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
                var model = _context.InformacjeSprzedazowe.FirstOrDefault (f=>f.InformacjeSprzedazoweId == id);
                if (model != null)
                {
                    _context.InformacjeSprzedazowe.Remove(model);
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

        public void Update (InformacjeSprzedazowe model)
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
