using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp90.Data;
using WinFormsApp90.Models;
using WinFormsApp90.Repos;

namespace WinFormsApp90.Services
{
    public class UnityOfWork : IUnityOfWork
    {
        private readonly ApplicationDbContext _context;

        public IDataRepository<ApplicationUser> UsersRepository { get; set; }
        public IDataRepository<ApplicationRole> RolesRepository { get; set; }
        public IIdentityUserRole UsersRolesRepository { get; set; }
        public IDataRepository<ApplicationUserZalacznik> UsersZalacznikiRepository { get; set; }
        public IDataRepository<Archiwizacja> ArchiwizacjeRepository { get; set; }
        public IDataRepository<Firma> FirmyRepository { get; set; }
        public IDataRepository<Hosting> HostingiRepository { get; set; }
        public IDataRepository<Gwarancja> GwarancjeRepository { get; set; }
        public IDataRepository<GwarancjaZdjecie> GwarancjeZdjeciaRepository { get; set; }
        public IDataRepository<ApplicationUserServis> ApplicationUserServisy { get; set; }
        public IDataRepository<HasloInfo> HaslaInfosRepository { get; set; }
        public IDataRepository<PoleItem> PolaItemsRepository { get; set; }
        public IDataRepository<InformacjaSprzedazowaZalacznik> InformacjeSprzedazoweZalacznikiRepository { get; set; }
        public IDataRepository<InformacjeSprzedazowe> InformacjeSprzedazoweRepository { get; set; }
        public IDataRepository<Kontakt> KontaktyRepository { get; set; }
        public IDataRepository<Naprawa> NaprawyRepository { get; set; }
        public IDataRepository<Oferta> OfertyRepository { get; set; }
        public IDataRepository<Pole> PolaRepository { get; set; }
        public IDataRepository<PoleItem> PoleItemsRepository { get; set; }
        public IDataRepository<RodzajSprzetu> RodzajeSprzetowRepository { get; set; }
        public IDataRepository<Serwis> SerwisyRepository { get; set; }
        public IDataRepository<SerwisZalacznik> SerwisyZalacznikiRepository { get; set; }
        public IDataRepository<Sprzet> SprzetyRepository { get; set; }
        public IDataRepository<SprzetItem> SprzetItemsRepository { get; set; }
        public IDataRepository<SprzetItemZalacznik> SprzetItemsZalacznikiRepository { get; set; }
        public IDataRepository<SprzetLicencja> SprzetLicencjeRepository { get; set; }
        public IDataRepository<SprzetLicencjaZalacznik> SprzetLicencjeZalacznikiRepository { get; set; }
        public IDataRepository<SprzetZdjecie> SprzetZdjeciaRepository { get; set; }
        public IDataRepository<Termin> TerminyRepository { get; set; }
        public IDataRepository<Umowa> UmowyRepository { get; set; }
        public IDataRepository<UmowaZalacznik> UmowyZalacznikiRepository { get; set; }
        public IDataRepository<Wiedza> WiedzaRepository { get; set; }
        public IDataRepository<WiedzaZdjecie> WiedzaZdjeciaRepository { get; set; }
        public IDataRepository<WolnaLicencja> WolneLicencjeRepository { get; set; }
        public IDataRepository<WolnaLicencjaZalacznik> WolneLicencjeZalacznikiRepository { get; set; }
        public IDataRepository<Log> LogsRepository { get; set; }

        public UnityOfWork (ApplicationDbContext context)
        {
            _context = context;

            UsersRepository = new UsersRepository(_context);
            RolesRepository = new RolesRepository(_context);
            UsersRolesRepository = new UsersRolesRepository (_context);
            UsersZalacznikiRepository = new UsersZalacznikiRepository (_context);
            ArchiwizacjeRepository = new ArchiwizacjeRepository(_context);
            FirmyRepository = new FirmyRepository(_context);
            HostingiRepository = new HostingiRepository(_context);
            GwarancjeRepository = new GwarancjeRepository(_context);
            GwarancjeZdjeciaRepository = new GwarancjeZdjeciaRepository (_context);
            ApplicationUserServisy = new UsersSerwisyRepository(_context);
            HaslaInfosRepository = new HaslaInfosRepository (_context);
            PolaItemsRepository = new PolaItemsRepository (_context);
            InformacjeSprzedazoweZalacznikiRepository = new InformacjeSprzedazowaZalacznikiRepository(_context);
            InformacjeSprzedazoweRepository = new InformacjeSprzedazoweRepository(_context);
            KontaktyRepository = new KontaktyRepository(_context);
            NaprawyRepository = new NaprawyRepository(_context);
            PolaRepository = new PolaRepository(_context);
            PoleItemsRepository = new PoleItemsRepository(_context);
            RodzajeSprzetowRepository = new RodzajSprzetuRepository(_context);
            SerwisyRepository = new SerwisyRepository(_context);
            SerwisyZalacznikiRepository = new SerwisyZalacznikiRepository(_context);
            SprzetyRepository = new SprzetyRepository(_context);
            SprzetItemsRepository = new SprzetItemsRepository(_context);
            SprzetItemsZalacznikiRepository = new SprzetItemsZalacznikiRepository(_context);
            SprzetLicencjeRepository = new SprzetLicencjeRepository(_context);
            SprzetLicencjeZalacznikiRepository = new SprzetLicencjeZalacznikiRepository(_context);
            SprzetZdjeciaRepository = new SprzetZdjeciaRepository(_context);
            UmowyRepository = new UmowyRepository(_context);
            UmowyZalacznikiRepository = new UmowyZalacznikiRepository(_context);
            WiedzaRepository = new WiedzaRepository(_context);
            WiedzaZdjeciaRepository = new WiedzaZdjeciaRepository(_context);
            WolneLicencjeRepository = new WolneLicencjeRepository(_context);
            WolneLicencjeZalacznikiRepository = new WolneLicencjeZalacznikiRepository(_context);
            LogsRepository = new LogsRepository (_context);
        }

        public void SaveChanges ()
        {
            _context.SaveChanges();
        }

    }
}
