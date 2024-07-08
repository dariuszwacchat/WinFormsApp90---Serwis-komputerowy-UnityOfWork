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
    public class SprzetLicencjeZalacznikiRepository : IDataRepository<SprzetLicencjaZalacznik>
    {
        private ApplicationDbContext _context;

        public SprzetLicencjeZalacznikiRepository (ApplicationDbContext context)
        {
            _context = context;
        }

        public List<SprzetLicencjaZalacznik> GetAll ()
        {
            return _context.SprzetLicencjaZalaczniki
                .ToList();
        }

        public SprzetLicencjaZalacznik Get (string id)
        {
            var model = _context.SprzetLicencjaZalaczniki
                .FirstOrDefault (f=> f.SprzetLicencjaZalacznikId == id);
            return model;
        }

        public void Create (SprzetLicencjaZalacznik model)
        {
            if (model != null)
            {
                try
                {
                    _context.SprzetLicencjaZalaczniki.Add(model);
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
                var model = _context.SprzetLicencjaZalaczniki.FirstOrDefault (f=>f.SprzetLicencjaZalacznikId == id);
                if (model != null)
                {
                    _context.SprzetLicencjaZalaczniki.Remove(model);
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

        public void Update (SprzetLicencjaZalacznik model)
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
