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
    public class UmowyZalacznikiRepository : IDataRepository<UmowaZalacznik>
    {
        private ApplicationDbContext _context;

        public UmowyZalacznikiRepository (ApplicationDbContext context)
        {
            _context = context;
        }

        public List<UmowaZalacznik> GetAll ()
        {
            return _context.UmowaZalaczniki
                .ToList();
        }

        public UmowaZalacznik Get (string id)
        {
            var model = _context.UmowaZalaczniki
                .FirstOrDefault (f=> f.UmowaZalacznikId == id);
            return model;
        }

        public void Create (UmowaZalacznik model)
        {
            if (model != null)
            {
                try
                {
                    _context.UmowaZalaczniki.Add(model);
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
                var model = _context.UmowaZalaczniki.FirstOrDefault (f=>f.UmowaZalacznikId == id);
                if (model != null)
                {
                    _context.UmowaZalaczniki.Remove(model);
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

        public void Update (UmowaZalacznik model)
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
