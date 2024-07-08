using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp90.Models;

namespace WinFormsApp90.Data
{
    public interface IUnityOfWork
    {
        IDataRepository<ApplicationUser> UsersRepository { get; set; }
        IDataRepository<ApplicationRole> RolesRepository { get; set; }
        IIdentityUserRole UsersRolesRepository { get; set; }
        IDataRepository<ApplicationUserZalacznik> UsersZalacznikiRepository { get; set; }
        IDataRepository<Archiwizacja> ArchiwizacjeRepository { get; set; }
        IDataRepository<Firma> FirmyRepository { get; set; }
        IDataRepository<Gwarancja> GwarancjeRepository { get; set; }
        IDataRepository<GwarancjaZdjecie> GwarancjeZdjeciaRepository { get; set; }
        IDataRepository<Hosting> HostingiRepository { get; set; }
        IDataRepository<ApplicationUserServis> ApplicationUserServisy { get; set; }
        IDataRepository<HasloInfo> HaslaInfosRepository { get; set; }
        IDataRepository<PoleItem> PolaItemsRepository { get; set; }
        IDataRepository<InformacjaSprzedazowaZalacznik> InformacjeSprzedazoweZalacznikiRepository { get; set; }
        IDataRepository<InformacjeSprzedazowe> InformacjeSprzedazoweRepository { get; set; }
        IDataRepository<Kontakt> KontaktyRepository { get; set; }
        IDataRepository<Naprawa> NaprawyRepository { get; set; }
        IDataRepository<Oferta> OfertyRepository { get; set; }
        IDataRepository<Pole> PolaRepository { get; set; }
        IDataRepository<PoleItem> PoleItemsRepository { get; set; }
        IDataRepository<RodzajSprzetu> RodzajeSprzetowRepository { get; set; }
        IDataRepository<Serwis> SerwisyRepository { get; set; }
        IDataRepository<SerwisZalacznik> SerwisyZalacznikiRepository { get; set; }
        IDataRepository<Sprzet> SprzetyRepository { get; set; }
        IDataRepository<SprzetItem> SprzetItemsRepository { get; set; }
        IDataRepository<SprzetItemZalacznik> SprzetItemsZalacznikiRepository { get; set; }
        IDataRepository<SprzetLicencja> SprzetLicencjeRepository { get; set; }
        IDataRepository<SprzetLicencjaZalacznik> SprzetLicencjeZalacznikiRepository { get; set; }
        IDataRepository<SprzetZdjecie> SprzetZdjeciaRepository { get; set; }
        IDataRepository<Termin> TerminyRepository { get; set; }
        IDataRepository<Umowa> UmowyRepository { get; set; }
        IDataRepository<UmowaZalacznik> UmowyZalacznikiRepository { get; set; }
        IDataRepository<Wiedza> WiedzaRepository { get; set; }
        IDataRepository<WiedzaZdjecie> WiedzaZdjeciaRepository { get; set; }
        IDataRepository<WolnaLicencja> WolneLicencjeRepository { get; set; }
        IDataRepository<WolnaLicencjaZalacznik> WolneLicencjeZalacznikiRepository { get; set; }
        IDataRepository<Log> LogsRepository { get; set; }

        void SaveChanges ();
    }
}
