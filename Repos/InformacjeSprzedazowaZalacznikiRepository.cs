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
    public class InformacjeSprzedazowaZalacznikiRepository : IDataRepository<InformacjaSprzedazowaZalacznik>
    {
        private ApplicationDbContext _context;

        public InformacjeSprzedazowaZalacznikiRepository (ApplicationDbContext context)
        {
            _context = context;
        }

        public List<InformacjaSprzedazowaZalacznik> GetAll ()
        {
            return _context.InformacjaSprzedazowaZalaczniki
                .ToList();
        }

        public InformacjaSprzedazowaZalacznik Get (string id)
        {
            var model = _context.InformacjaSprzedazowaZalaczniki
                .FirstOrDefault (f=> f.InformacjaSprzedazowaZalacznikId == id);
            return model;
        }

        public void Create (InformacjaSprzedazowaZalacznik model)
        {
            if (model != null)
            {
                try
                {
                    _context.InformacjaSprzedazowaZalaczniki.Add(model);
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
                var model = _context.InformacjaSprzedazowaZalaczniki.FirstOrDefault (f=>f.InformacjaSprzedazowaZalacznikId == id);
                if (model != null)
                {
                    _context.InformacjaSprzedazowaZalaczniki.Remove(model);
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

        public void Update (InformacjaSprzedazowaZalacznik model)
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
