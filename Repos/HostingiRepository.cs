﻿ using Microsoft.EntityFrameworkCore;
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
    public class HostingiRepository : IDataRepository<Hosting>
    {
        private ApplicationDbContext _context;

        public HostingiRepository (ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Hosting> GetAll ()
        {
            return _context.Hostingi
                .Include (i=> i.Firma)
                .ToList();
        }

        public Hosting Get (string id)
        {
            var model = _context.Hostingi
                .Include (i=> i.Firma)
                .FirstOrDefault (f=> f.HostingId == id);
            return model;
        }

        public void Create (Hosting model)
        {
            if (model != null)
            {
                try
                {
                    _context.Hostingi.Add(model);
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
                var model = _context.Hostingi.FirstOrDefault (f=>f.HostingId == id);
                if (model != null)
                {
                    _context.Hostingi.Remove(model);
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

        public void Update (Hosting model)
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
