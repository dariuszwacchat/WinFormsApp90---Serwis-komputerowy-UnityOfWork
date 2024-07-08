using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp90.Models;
using WinFormsApp90.Models.Enums;

namespace WinFormsApp90.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, string>
    {
        private DataAutogenerator.NetCore.DataAutogenerator _dataAutogenerator = new DataAutogenerator.NetCore.DataAutogenerator ();
        private Random _rand = new Random ();

        public ApplicationDbContext () { }
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options)
            : base(options) { }



        public DbSet<SprzetItem> SprzetItems { get; set; }
        public DbSet<SprzetItemZalacznik> SprzetItemZalaczniki { get; set; }
        public DbSet<PoleItem> PolaItems { get; set; }


        public DbSet<Firma> Firmy { get; set; }
        public DbSet<Sprzet> Sprzet { get; set; }
        public DbSet<WolnaLicencja> WolneLicencje { get; set; }
        public DbSet<WolnaLicencjaZalacznik> WolnaLicencjaZalaczniki { get; set; }
        public DbSet<SprzetLicencja> SprzetLicencje { get; set; }
        public DbSet<SprzetLicencjaZalacznik> SprzetLicencjaZalaczniki { get; set; }
        public DbSet<RodzajSprzetu> RodzajeSprzetow { get; set; }
        public DbSet<Pole> Pola { get; set; }
        public DbSet<Archiwizacja> Archiwizacje { get; set; }
        public DbSet<Gwarancja> Gwarancje { get; set; }
        public DbSet<GwarancjaZdjecie> GwarancjaZdjecia { get; set; }
        public DbSet<HasloInfo> HaslaInfos { get; set; }
        public DbSet<Hosting> Hostingi { get; set; } 
        public DbSet<InformacjeSprzedazowe> InformacjeSprzedazowe { get; set; }
        public DbSet<InformacjaSprzedazowaZalacznik> InformacjaSprzedazowaZalaczniki { get; set; }
        public DbSet<Kontakt> Kontakty { get; set; }
        public DbSet<WolnaLicencjaZalacznik> LicencjaZalaczniki { get; set; }
        public DbSet<Naprawa> Naprawy { get; set; }
        public DbSet<Serwis> Serwisy { get; set; }
        public DbSet<SerwisZalacznik> SerwisZalaczniki { get; set; }
        public DbSet<SprzetZdjecie> SprzetZdjecia { get; set; }
        public DbSet<Umowa> Umowy { get; set; }
        public DbSet<UmowaZalacznik> UmowaZalaczniki { get; set; }
        public DbSet<Wiedza> Wiedza { get; set; }
        public DbSet<WiedzaZdjecie> WiedzaZdjecia { get; set; }
        public DbSet<ApplicationUserServis> ApplicationUserSerwisy { get; set; }
        public DbSet<ApplicationUserZalacznik> ApplicationUserZalaczniki { get; set; }

        public DbSet<Log> Logs { get; set; }



        protected override void OnConfiguring (DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=WinFormsApp90-SerwisKomputerowy;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            }
        }

        protected override void OnModelCreating (ModelBuilder builder)
        {

            builder.Entity<ApplicationUserServis>()
                .HasKey(h => new { h.UserId, h.SerwisId });

            builder.Entity<ApplicationUserServis>()
                .HasOne(h => h.User)
                .WithMany(w => w.ApplicationUserSerwisy)
                .HasForeignKey(h => h.UserId);

            builder.Entity<ApplicationUserServis>()
                .HasOne(h => h.Serwis)
                .WithMany(w => w.ApplicationUserSerwisy)
                .HasForeignKey(h => h.SerwisId); 

            builder.Entity<ApplicationUser>()
                .HasMany(h => h.Wiedza).WithOne(w => w.KtoDodal).HasForeignKey(f => f.KtoDodalId).OnDelete(DeleteBehavior.ClientSetNull);

            builder.Entity<ApplicationUser>()
                .HasMany(h => h.ApplicationUserZalaczniki).WithOne(w => w.User).HasForeignKey(f => f.UserId).OnDelete(DeleteBehavior.ClientSetNull);



            builder.Entity<Firma>()
                .HasMany(h => h.Kontakty).WithOne(w => w.Firma).HasForeignKey(f => f.FirmaId).OnDelete(DeleteBehavior.ClientSetNull);

            builder.Entity<Firma>()
                .HasMany(h => h.RodzajeSprzetow).WithOne(w => w.Firma).HasForeignKey(f => f.FirmaId).OnDelete(DeleteBehavior.ClientSetNull);

            builder.Entity<Firma>()
                .HasMany(h => h.Sprzet).WithOne(w => w.Firma).HasForeignKey(f => f.FirmaId).OnDelete(DeleteBehavior.ClientSetNull);

            builder.Entity<Firma>()
                .HasMany(h => h.Umowy).WithOne(w => w.Firma).HasForeignKey(f => f.FirmaId).OnDelete(DeleteBehavior.ClientSetNull);

            builder.Entity<Firma>()
                .HasMany(h => h.Hosting).WithOne(w => w.Firma).HasForeignKey(f => f.FirmaId).OnDelete(DeleteBehavior.ClientSetNull);

            builder.Entity<Firma>()
                .HasMany(h => h.InformacjeSprzedazowe).WithOne(w => w.Firma).HasForeignKey(f => f.FirmaId).OnDelete(DeleteBehavior.ClientSetNull);

            builder.Entity<Firma>()
                .HasMany(h => h.Serwisy).WithOne(w => w.Firma).HasForeignKey(f => f.FirmaId).OnDelete(DeleteBehavior.ClientSetNull);

            builder.Entity<Firma>()
                .HasMany(h => h.SprzetLicencje).WithOne(w => w.Firma).HasForeignKey(f => f.FirmaId).OnDelete(DeleteBehavior.ClientSetNull);

            builder.Entity<Firma>()
                .HasMany(h => h.Gwarancje).WithOne(w => w.Firma).HasForeignKey(f => f.FirmaId).OnDelete(DeleteBehavior.ClientSetNull);

            builder.Entity<Firma>()
                .HasMany(h => h.Naprawy).WithOne(w => w.Firma).HasForeignKey(f => f.FirmaId).OnDelete(DeleteBehavior.ClientSetNull);

            builder.Entity<Firma>()
                .HasMany(h => h.Archiwizacje).WithOne(w => w.Firma).HasForeignKey(f => f.FirmaId).OnDelete(DeleteBehavior.ClientSetNull);

            builder.Entity<Firma>()
                .HasMany(h => h.HaslaInfos).WithOne(w => w.Firma).HasForeignKey(f => f.FirmaId).OnDelete(DeleteBehavior.ClientSetNull);
             


            builder.Entity<Gwarancja>()
                .HasMany(h => h.GwarancjaZdjecia).WithOne(w => w.Gwarancja).HasForeignKey(f => f.GwarancjaId).OnDelete(DeleteBehavior.ClientSetNull);



            builder.Entity<RodzajSprzetu>()
                .HasMany(h => h.Sprzet).WithOne(w => w.RodzajSprzetu).HasForeignKey(f => f.RodzajSprzetuId).OnDelete(DeleteBehavior.ClientSetNull);

            builder.Entity<RodzajSprzetu>()
                .HasMany(h => h.InformacjeSprzedazowe).WithOne(w => w.RodzajSprzetu).HasForeignKey(f => f.RodzajSprzetuId).OnDelete(DeleteBehavior.ClientSetNull);




            builder.Entity<Serwis>()
                .HasMany(h => h.SerwisZalaczniki).WithOne(w => w.Serwis).HasForeignKey(f => f.SerwisId).OnDelete(DeleteBehavior.ClientSetNull);





            builder.Entity<Sprzet>()
                .HasMany(h => h.SprzetLicencje).WithOne(w => w.Sprzet).HasForeignKey(f => f.SprzetId).OnDelete(DeleteBehavior.ClientSetNull);

            builder.Entity<Sprzet>()
                .HasMany(h => h.Gwarancje).WithOne(w => w.Sprzet).HasForeignKey(f => f.SprzetId).OnDelete(DeleteBehavior.ClientSetNull);

            builder.Entity<Sprzet>()
                .HasMany(h => h.Serwisy).WithOne(w => w.Sprzet).HasForeignKey(f => f.SprzetId).OnDelete(DeleteBehavior.ClientSetNull);

            builder.Entity<Sprzet>()
                .HasMany(h => h.Naprawy).WithOne(w => w.Sprzet).HasForeignKey(f => f.SprzetId).OnDelete(DeleteBehavior.ClientSetNull);

            builder.Entity<Sprzet>()
                .HasMany(h => h.Archiwizacje).WithOne(w => w.Sprzet).HasForeignKey(f => f.SprzetId).OnDelete(DeleteBehavior.ClientSetNull);

            builder.Entity<Sprzet>()
                .HasMany(h => h.SprzetZdjecia).WithOne(w => w.Sprzet).HasForeignKey(f => f.SprzetId).OnDelete(DeleteBehavior.ClientSetNull);

            builder.Entity<Sprzet>()
                .HasMany(h => h.HaslaInfo).WithOne(w => w.Sprzet).HasForeignKey(f => f.SprzetId).OnDelete(DeleteBehavior.ClientSetNull);

            builder.Entity<Sprzet>()
                .HasMany(h => h.Pola).WithOne(w => w.Sprzet).HasForeignKey(f => f.SprzetId).OnDelete(DeleteBehavior.ClientSetNull);




            builder.Entity<SprzetItem>()
                .HasMany(h => h.PolaItems).WithOne(w => w.SprzetItem).HasForeignKey(f => f.SprzetItemId).OnDelete(DeleteBehavior.ClientSetNull);

            builder.Entity<SprzetItem>()
                .HasMany(h => h.SprzetItemZalaczniki).WithOne(w => w.SprzetItem).HasForeignKey(f => f.SprzetItemId).OnDelete(DeleteBehavior.ClientSetNull);



            builder.Entity<Umowa>()
                .HasMany(h => h.UmowaZalaczniki).WithOne(w => w.Umowa).HasForeignKey(f => f.UmowaId).OnDelete(DeleteBehavior.ClientSetNull);


            builder.Entity<Wiedza>()
                .HasMany(h => h.WiedzaZdjecia).WithOne(w => w.Wiedza).HasForeignKey(f => f.WiedzaId).OnDelete(DeleteBehavior.ClientSetNull);


            builder.Entity<WolnaLicencja>()
                .HasMany(h => h.WolnaLicencjaZalaczniki).WithOne(w => w.WolnaLicencja).HasForeignKey(f => f.WolnaLicencjaId).OnDelete(DeleteBehavior.ClientSetNull);



            builder.Entity<InformacjeSprzedazowe>()
                .HasMany(h => h.InformacjaSprzedazowaZalaczniki).WithOne(w => w.InformacjeSprzedazowe).HasForeignKey(f => f.InformacjeSprzedazoweId).OnDelete(DeleteBehavior.ClientSetNull);






            // Dodanie ról   
            ApplicationRole adminRole = new ApplicationRole()
            {
                Id = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                Name = "Administrator",
                NormalizedName = "Administrator"
            };
            ApplicationRole personelRole = new ApplicationRole()
            {
                Id = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                Name = "Personel",
                NormalizedName = "Personel",
            };
            ApplicationRole kierownikRole = new ApplicationRole()
            {
                Id = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                Name = "Kierownik",
                NormalizedName = "Kierownik",
            };
            builder.Entity<ApplicationRole>().HasData(adminRole, kierownikRole, personelRole);



            // Dodanie użytkowników  

            string photo = "https://th.bing.com/th?q=User+ICO&w=120&h=120&c=1&rs=1&qlt=90&cb=1&dpr=1.6&pid=InlineBlock&mkt=pl-PL&cc=PL&setlang=pl&adlt=moderate&t=1&mw=247";

            PasswordHasher <ApplicationUser> passwordHasher = new PasswordHasher<ApplicationUser> ();

            double placa = _rand.Next (8000,30000);
            ApplicationUser administratorUser = new ApplicationUser ()
            {
                Id = Guid.NewGuid().ToString (),
                Email = "admin@admin.pl",
                UserName = "admin@admin.pl",
                NormalizedUserName = "admin@admin.pl".ToUpper(),
                NormalizedEmail = "admin@admin.pl".ToUpper(),
                SecurityStamp = Guid.NewGuid().ToString(),
                Imie = _dataAutogenerator.Imie(),
                Nazwisko = _dataAutogenerator.Nazwisko (),
                AdresEmailSluzbowy = _dataAutogenerator.Email (),
                DataUrodzenia = _dataAutogenerator.RandomDateTime (),
                AdresZamieszkania = _dataAutogenerator.Description(1),
                NumerGG = _dataAutogenerator.Nip(),
                PrywatnyTelefon = _dataAutogenerator.Nip (),
                TelefonSluzbowy = _dataAutogenerator.Nip (),
                Uwagi = _dataAutogenerator.Description (1)
            };
            administratorUser.PasswordHash = passwordHasher.HashPassword(administratorUser, "SDG%$@5423sdgagSDert");
            IdentityUserRole <string> identityUserRoleAdmin = new IdentityUserRole<string> ()
            {
                UserId = administratorUser.Id,
                RoleId = adminRole.Id
            };

            placa = _rand.Next(8000, 30000);
            ApplicationUser kierownikUser = new ApplicationUser ()
            {
                Id = Guid.NewGuid().ToString (),
                Email = "kierownik@kierownik.pl",
                UserName = "kierownik@kierownik.pl",
                NormalizedUserName = "kierownik@kierownik.pl".ToUpper(),
                NormalizedEmail = "kierownik@kierownik.pl".ToUpper(),
                SecurityStamp = Guid.NewGuid().ToString(),
                Imie = _dataAutogenerator.Imie(),
                Nazwisko = _dataAutogenerator.Nazwisko (),
                AdresEmailSluzbowy = _dataAutogenerator.Email (),
                DataUrodzenia = _dataAutogenerator.RandomDateTime (),
                AdresZamieszkania = _dataAutogenerator.Description(1),
                NumerGG = _dataAutogenerator.Nip(),
                PrywatnyTelefon = _dataAutogenerator.Nip (),
                TelefonSluzbowy = _dataAutogenerator.Nip (),
                Uwagi = _dataAutogenerator.Description (1)
            };
            kierownikUser.PasswordHash = passwordHasher.HashPassword(kierownikUser, "SDG%$@5423sdgagSDert");
            IdentityUserRole <string> identityUserRoleKierownik= new IdentityUserRole<string> ()
            {
                UserId = kierownikUser.Id,
                RoleId = kierownikRole.Id
            };

            placa = _rand.Next(5000, 8000);
            ApplicationUser pracownik1 = new ApplicationUser ()
            {
                Id = Guid.NewGuid().ToString (),
                Email = "personel1@personel1.pl",
                UserName = "personel1@personel1.pl",
                NormalizedUserName = "personel1@personel1.pl".ToUpper(),
                NormalizedEmail = "personel1@personel1.pl".ToUpper(),
                SecurityStamp = Guid.NewGuid().ToString(),
                Imie = _dataAutogenerator.Imie(),
                Nazwisko = _dataAutogenerator.Nazwisko (),
                AdresEmailSluzbowy = _dataAutogenerator.Email (),
                DataUrodzenia = _dataAutogenerator.RandomDateTime (),
                AdresZamieszkania = _dataAutogenerator.Description(1),
                NumerGG = _dataAutogenerator.Nip(),
                PrywatnyTelefon = _dataAutogenerator.Nip (),
                TelefonSluzbowy = _dataAutogenerator.Nip (),
                Uwagi = _dataAutogenerator.Description (1)
            };
            pracownik1.PasswordHash = passwordHasher.HashPassword(pracownik1, "SDG%$@5423sdgagSDert");
            IdentityUserRole <string> identityUserRoleUser1 = new IdentityUserRole<string> ()
            {
                UserId = pracownik1.Id,
                RoleId = personelRole.Id
            };

            placa = _rand.Next(5000, 8000);
            ApplicationUser pracownik2 = new ApplicationUser ()
            {
                Id = Guid.NewGuid().ToString (),
                Email = "personel2@personel2.pl",
                UserName = "personel2@personel2.pl",
                NormalizedUserName = "personel2@personel2.pl".ToUpper(),
                NormalizedEmail = "personel2@personel2.pl".ToUpper(),
                SecurityStamp = Guid.NewGuid().ToString(),
                Imie = _dataAutogenerator.Imie(),
                Nazwisko = _dataAutogenerator.Nazwisko (),
                AdresEmailSluzbowy = _dataAutogenerator.Email (),
                DataUrodzenia = _dataAutogenerator.RandomDateTime (),
                AdresZamieszkania = _dataAutogenerator.Description(1),
                NumerGG = _dataAutogenerator.Nip(),
                PrywatnyTelefon = _dataAutogenerator.Nip (),
                TelefonSluzbowy = _dataAutogenerator.Nip (),
                Uwagi = _dataAutogenerator.Description (1)
            };
            pracownik2.PasswordHash = passwordHasher.HashPassword(pracownik2, "SDG%$@5423sdgagSDert");
            IdentityUserRole <string> identityUserRoleUser2 = new IdentityUserRole<string> ()
            {
                UserId = pracownik2.Id,
                RoleId = personelRole.Id
            };

            placa = _rand.Next(5000, 8000);
            ApplicationUser pracownik3 = new ApplicationUser ()
            {
                Id = Guid.NewGuid().ToString (),
                Email = "personel3@personel3.pl",
                UserName = "personel3@personel3.pl",
                NormalizedUserName = "personel3@personel3.pl".ToUpper(),
                NormalizedEmail = "personel3@personel3.pl".ToUpper(),
                SecurityStamp = Guid.NewGuid().ToString(),
                Imie = _dataAutogenerator.Imie(),
                Nazwisko = _dataAutogenerator.Nazwisko (),
                AdresEmailSluzbowy = _dataAutogenerator.Email (),
                DataUrodzenia = _dataAutogenerator.RandomDateTime (),
                AdresZamieszkania = _dataAutogenerator.Description(1),
                NumerGG = _dataAutogenerator.Nip(),
                PrywatnyTelefon = _dataAutogenerator.Nip (),
                TelefonSluzbowy = _dataAutogenerator.Nip (),
                Uwagi = _dataAutogenerator.Description (1)
            };
            pracownik3.PasswordHash = passwordHasher.HashPassword(pracownik3, "SDG%$@5423sdgagSDert");
            IdentityUserRole <string> identityUserRoleUser3 = new IdentityUserRole<string> ()
            {
                UserId = pracownik3.Id,
                RoleId = personelRole.Id
            };

            builder.Entity<ApplicationUser>().HasData(administratorUser, kierownikUser, pracownik1, pracownik2, pracownik3);
            builder.Entity<IdentityUserRole<string>>().HasData(identityUserRoleAdmin, identityUserRoleKierownik, identityUserRoleUser1, identityUserRoleUser2, identityUserRoleUser3);


            // pracownicy  
            for (var i = 0; i < 20; i++)
            {
                string userName = $"{_dataAutogenerator.Nazwisko()}@{_dataAutogenerator.Nazwisko()}.pl";
                placa = _rand.Next(5000, 8000);
                ApplicationUser user = new ApplicationUser ()
                {
                    Id = Guid.NewGuid().ToString (),
                    Email = userName,
                    UserName = userName,
                    NormalizedUserName = userName.ToUpper(),
                    NormalizedEmail = userName.ToUpper(),
                    SecurityStamp = Guid.NewGuid().ToString(),
                    Imie = _dataAutogenerator.Imie(),
                    Nazwisko = _dataAutogenerator.Nazwisko (),
                    AdresEmailSluzbowy = _dataAutogenerator.Email (),
                    DataUrodzenia = _dataAutogenerator.RandomDateTime (),
                    AdresZamieszkania = _dataAutogenerator.Description(1),
                    NumerGG = _dataAutogenerator.Nip(),
                    PrywatnyTelefon = _dataAutogenerator.Nip (),
                    TelefonSluzbowy = _dataAutogenerator.Nip (),
                    Uwagi = _dataAutogenerator.Description (1)
                };
                user.PasswordHash = passwordHasher.HashPassword(user, "SDG%$@5423sdgagSDert"); 
                builder.Entity<ApplicationUser>().HasData(user);

                IdentityUserRole <string> iur = new IdentityUserRole<string> ()
                {
                    UserId = user.Id,
                    RoleId = personelRole.Id
                };
                builder.Entity<IdentityUserRole<string>>().HasData(iur);
            }










            List <string> rodzajeSprzetow = new List<string>() { "Komputer", "Monitor", "Drukarka", "Router", "Router główny", "WiFi" };

            List <string> rodzajeSprzetowId = new List<string> ();
            for (var i = 0; i < rodzajeSprzetow.Count; i++)
            {
                RodzajSprzetu rodzajSprzetu = new RodzajSprzetu ()
                {
                    RodzajSprzetuId = Guid.NewGuid ().ToString (),
                    Nazwa = rodzajeSprzetow [i]
                };
                builder.Entity<RodzajSprzetu>().HasData(rodzajSprzetu);
                rodzajeSprzetowId.Add(rodzajSprzetu.RodzajSprzetuId);
            }




            // KOMPUTER
            SprzetItem sprzetItemKomputer = new SprzetItem ()
            {
                SprzetItemId = Guid.NewGuid ().ToString (),
                Nazwa = "Komputer"
            };
            builder.Entity<SprzetItem>().HasData(sprzetItemKomputer);
            List <string> komputerFields = new List<string> ()
            {
                "Nazwa",
                "Lokalizacja",
                "Użytkownik",
                "Procesor",
                "Dysk",
                "Pamięć Ram",
                "Karta Graficzna",
                "Karta LAN",
                "Karta WiFi",
                "Karta Muzyczna",
                "Napęd Optyczny",
                "Dodatkowe Porty",
                "System Operacyjny",
                "Monitor",
                "Drukarka",
                "Adres IP",
                "MS Office",
                "Antywirus",
                "Oprogramowanie",
                "Uwagi",
                "Data zakupu",
                "Kwota zakupu",
                "Numer seryjny",
                "Model", 
                "Gdzie kupione"
            };
            for (var i = 0; i < komputerFields.Count; i++)
            {
                PoleItem poleItem = new PoleItem ()
                {
                    PoleItemId = Guid.NewGuid ().ToString (),
                    Name = komputerFields [i],
                    RodzajPola = RodzajPola.MalePole,
                    SprzetItemId = sprzetItemKomputer.SprzetItemId
                };
                builder.Entity<PoleItem>().HasData(poleItem);
            }


            // MONITOR

            SprzetItem sprzetItemMonitor = new SprzetItem ()
            {
                SprzetItemId = Guid.NewGuid ().ToString (),
                Nazwa = "Monitor"
            };
            builder.Entity<SprzetItem>().HasData(sprzetItemMonitor);
            List <string> monitorFields = new List<string> ()
            {
                "Nazwa",
                "Data zakupu",
                "Kwota zakupu",
                "Numer seryjny",
                "Model",
                "Lokalizacja",
                "Porty",
                "Pod jakim portem podłączony",
                "Gwarancja",
                "Gdzie kupiony",
                "Uwagi"
            };
            for (var i = 0; i < monitorFields.Count; i++)
            {
                PoleItem poleItem = new PoleItem ()
                {
                    PoleItemId = Guid.NewGuid ().ToString (),
                    Name = monitorFields [i],
                    RodzajPola = RodzajPola.MalePole,
                    SprzetItemId = sprzetItemMonitor.SprzetItemId
                };
                builder.Entity<PoleItem>().HasData(poleItem);
            }




            // DRUKARKA

            SprzetItem sprzetItemDrukarka = new SprzetItem ()
            {
                SprzetItemId = Guid.NewGuid ().ToString (),
                Nazwa = "Drukarka"
            };
            builder.Entity<SprzetItem>().HasData(sprzetItemDrukarka);
            List <string> drukarkaFields = new List<string> ()
            {
                "Nazwa",
                "Lokalizacja",
                "Jaki toner",
                "Posiadane porty",
                "Pod jakim portem podłączona",
                "Adres IP",
                "Hasło",
                "Numer seryjny",
                "Gdzie kupiona",
                "Gwarancja",
                "Uwagi",
                "Data zakupu",
                "Kwota zakupu",
                "Numer seryjny",
                "Model",
                "Gdzie kupione"
            };
            for (var i = 0; i < drukarkaFields.Count; i++)
            {
                PoleItem poleItem = new PoleItem ()
                {
                    PoleItemId = Guid.NewGuid ().ToString (),
                    Name = drukarkaFields [i],
                    RodzajPola = RodzajPola.MalePole,
                    SprzetItemId = sprzetItemDrukarka.SprzetItemId
                };
                builder.Entity<PoleItem>().HasData(poleItem);
            }


            // ROUTER

            SprzetItem sprzetItemRouter = new SprzetItem ()
            {
                SprzetItemId = Guid.NewGuid ().ToString (),
                Nazwa = "Router"
            };
            builder.Entity<SprzetItem>().HasData(sprzetItemRouter);
            List <string> rouerFields = new List<string> ()
            {
                "Nazwa",
                "Lokalizacja",
                "Hasło",
                "Numer seryjny",
                "Gdzie kupiony",
                "Gwarancja", 
                "Data zakupu",
                "Kwota zakupu",   
                "Model",
                "Adres IP lokalny",
                "Login",
                "Hasło",
                "DHCP",
                "Zakres",
                "Adres na WAN",
                "Opis",
                "Uwagi"
            };
            for (var i = 0; i < rouerFields.Count; i++)
            {
                PoleItem poleItem = new PoleItem ()
                {
                    PoleItemId = Guid.NewGuid ().ToString (),
                    Name = rouerFields [i],
                    RodzajPola = RodzajPola.MalePole,
                    SprzetItemId = sprzetItemRouter.SprzetItemId
                };
                builder.Entity<PoleItem>().HasData(poleItem);
            }


            // WiFi

            SprzetItem sprzetItemWiFi = new SprzetItem ()
            {
                SprzetItemId = Guid.NewGuid ().ToString (),
                Nazwa = "WiFi"
            };
            builder.Entity<SprzetItem>().HasData(sprzetItemWiFi);
            List <string> wiFiFields = new List<string> ()
            {
                "Nazwa",
                "Lokalizacja",
                "Hasło",
                "Numer seryjny",
                "Gdzie kupiony",
                "Gwarancja",
                "Data zakupu",
                "Kwota zakupu",
                "Adres IP",
                "Model", 
                "Login",
                "Hasło",
                "SSID",
                "Szyfrowanie", 
                "Opis",
                "Uwagi"
            };
            for (var i = 0; i < wiFiFields.Count; i++)
            {
                PoleItem poleItem = new PoleItem ()
                {
                    PoleItemId = Guid.NewGuid ().ToString (),
                    Name = wiFiFields [i],
                    RodzajPola = RodzajPola.MalePole,
                    SprzetItemId = sprzetItemWiFi.SprzetItemId
                };
                builder.Entity<PoleItem>().HasData(poleItem);
            }


/*

            // FIRMA

            for (var i = 0; i < 2; i++)
            {
                Firma firma = new Firma ()
                {
                    FirmaId = Guid.NewGuid ().ToString (),
                    Adres = _dataAutogenerator.Ulica (),
                    Nip = _dataAutogenerator.Nip (),
                    PelnaNazwa = _dataAutogenerator.Description (1),
                    SkroconaNazwa = _dataAutogenerator.Nazwisko ()
                };
                builder.Entity<Firma>().HasData(firma);

                // Umowa
                DateTime dataRozpoczecia = _dataAutogenerator.RandomDateTime ();
                DateTime dataZakonczenia = dataRozpoczecia.AddMonths (_rand.Next(10,20));
                Umowa umowa = new Umowa ()
                {
                    UmowaId = Guid.NewGuid ().ToString (),
                    NumerUmowy = _rand.Next (100,10000).ToString (),
                    DataRozpoczecia = dataRozpoczecia.ToString (),
                    DataZakonczenia = dataZakonczenia.ToString (),
                    OkresWypowiedzenia = 3,
                    CzasNieokreslony = false,
                    FirmaId= firma.FirmaId
                };
                builder.Entity<Umowa>().HasData(umowa);

                DateTime dataRozpoczecia2 = _dataAutogenerator.RandomDateTime (); 
                DateTime dataZakonczenia2 = DateTime.Now;
                Umowa umowa2 = new Umowa ()
                {
                    UmowaId = Guid.NewGuid ().ToString (),
                    NumerUmowy = _rand.Next (100,10000).ToString (),
                    DataRozpoczecia = dataRozpoczecia2.ToString (),
                    DataZakonczenia = dataZakonczenia2.ToString (),
                    OkresWypowiedzenia = 2,
                    CzasNieokreslony = false,
                    FirmaId= firma.FirmaId
                };
                builder.Entity<Umowa>().HasData(umowa2);

                // Kontakty 
                for (var j=0; j<_rand.Next (3,10); j++)
                {
                    Kontakt kontakt = new Kontakt ()
                    {
                        KontaktId = Guid.NewGuid ().ToString (),
                        Adres = _dataAutogenerator.Description (1),
                        AdresEmail = _dataAutogenerator.Email(),
                        NumerTelefonu = _dataAutogenerator.Nip (),
                        OsobaKontaktowa = _dataAutogenerator.Nazwisko(),
                        FirmaId = firma.FirmaId
                    }; 
                    builder.Entity<Kontakt>().HasData(kontakt);
                }

                // Rodzaje sprzętów występujących w firmie

                // sprzęt komputerowy  
                for (var k = 0; k < _rand.Next(5, 10); k++)
                {
                    Sprzet sprzetKomputer = new Sprzet ()
                    {
                        SprzetId = Guid.NewGuid ().ToString (),
                        Nazwa = $"K{k+1}",
                        RodzajSprzetuId = rodzajeSprzetowId [0],
                        UrzadzenieSieciowe = false,
                        FirmaId = firma.FirmaId,
                    };
                    builder.Entity<Sprzet>().HasData(sprzetKomputer);

                    for (var l = 0; l < komputerFields.Count; l++)
                    {
                        Pole pole = new Pole ()
                        {
                            PoleId = Guid.NewGuid ().ToString (),
                            Name = komputerFields [l],
                            Wartosc = _dataAutogenerator.Nazwisko(),
                            SprzetId = sprzetKomputer.SprzetId
                        };
                        builder.Entity<Pole>().HasData(pole);
                    }

                    // działania serwisowe dla komputera
                    for (var l=0; l<_rand.Next (0,5); l++)
                    {
                        DateTime data = _dataAutogenerator.RandomDateTime ();
                        int datar = _rand.Next (1,24);
                        Serwis serwis = new Serwis ()
                        {
                            SerwisId = Guid.NewGuid ().ToString (),
                            Data = data,
                            GodzinaRozpoczecia = datar,
                            GodzinaZakonczenia = datar + _rand.Next(1, 3),
                            CzasTrwaniaSerwisu = _dataAutogenerator.IleUplynelo (data).Hours,
                            SprzetId = sprzetKomputer.SprzetId,
                            SzczegółowyOpis = _dataAutogenerator.Description (4),
                            SprawaZakonczona = false,
                            FirmaId = firma.FirmaId
                        };
                        builder.Entity <Serwis> ().HasData (serwis);
                    }

                    // naprawy komputera
                    for (var l = 0; l < _rand.Next(0, 5); l++)
                    {
                        DateTime dataNaprawy = _dataAutogenerator.RandomDateTime ();
                        int czasGwarancji = _rand.Next (2,4);
                        Naprawa naprawa = new Naprawa ()
                        {
                            NaprawaId = Guid.NewGuid ().ToString (),
                            CzasUdzielonejGwarancji = czasGwarancji,
                            DataNaprawy = dataNaprawy,
                            DataZakonczeniaGwarancji = dataNaprawy.AddMonths(czasGwarancji),
                            Uwagi = _dataAutogenerator.Description (1),
                            SprzetId = sprzetKomputer.SprzetId,
                            FirmaId = firma.FirmaId
                        };
                        builder.Entity<Naprawa>().HasData(naprawa);
                    } 
                     

                    // archiwizacje 
                    for (var l = 0; l < _rand.Next(2, 5); l++)
                    {
                        Archiwizacja archiwizacja = new Archiwizacja ()
                        {
                            ArchiwizacjaId = Guid.NewGuid ().ToString (),
                            FirmaId = firma.FirmaId,
                            SprzetId = sprzetKomputer.SprzetId,
                            CzestotliwoscArchiwizacji = _rand.Next (0,5),
                            DaneDoArchiwizacji = _dataAutogenerator.Nazwisko (),
                            DataArchiwizacji = _dataAutogenerator.RandomDateTime(),
                            KopiaPrzekazana = _dataAutogenerator.Nazwisko (),
                            NosnikArchiwizacji = _dataAutogenerator.Nazwisko (),
                            Uwagi = _dataAutogenerator.Description (1)
                        };
                        builder.Entity<Archiwizacja>().HasData(archiwizacja);
                    }

                    // hasła 
                    for (var l = 0; l < _rand.Next(1, 3); l++)
                    {
                        HasloInfo hasloInfo = new HasloInfo ()
                        {
                            HasloInfoId = Guid.NewGuid ().ToString (),
                            FirmaId = firma.FirmaId,
                            SprzetId = sprzetKomputer.SprzetId,
                            Haslo = _dataAutogenerator.Nazwisko (),
                            Login = _dataAutogenerator.Nazwisko (),
                            Uwagi = _dataAutogenerator.Description (1)
                        };
                        builder.Entity<HasloInfo>().HasData(hasloInfo);
                    }


                }

                // Monitory

                for (var k = 0; k < _rand.Next(5, 10); k++)
                {
                    Sprzet sprzetMonitor = new Sprzet ()
                    {
                        SprzetId = Guid.NewGuid ().ToString (),
                        Nazwa = $"Monitor{k+1}",
                        RodzajSprzetuId = rodzajeSprzetowId [1],
                        FirmaId = firma.FirmaId,
                    };
                    builder.Entity<Sprzet>().HasData(sprzetMonitor);

                    for (var l = 0; l < monitorFields.Count; l++)
                    {
                        Pole pole = new Pole ()
                        {
                            PoleId = Guid.NewGuid ().ToString (),
                            Name = monitorFields [l],
                            Wartosc = _dataAutogenerator.Nazwisko(),
                            SprzetId = sprzetMonitor.SprzetId
                        };
                        builder.Entity<Pole>().HasData(pole);
                    }
                    
                    // działania serwisowe dla monitora
                    for (var l = 0; l < _rand.Next(0, 3); l++)
                    {
                        DateTime data = _dataAutogenerator.RandomDateTime ();
                        int datar = _rand.Next (1,24);
                        Serwis serwis = new Serwis ()
                        {
                            SerwisId = Guid.NewGuid ().ToString (),
                            Data = data,
                            GodzinaRozpoczecia = datar,
                            GodzinaZakonczenia = datar + _rand.Next(1, 3),
                            CzasTrwaniaSerwisu = _dataAutogenerator.IleUplynelo (data).Hours,
                            SprzetId = sprzetMonitor.SprzetId,
                            SzczegółowyOpis = _dataAutogenerator.Description (4),
                            SprawaZakonczona = false,
                            FirmaId = firma.FirmaId
                        };
                        builder.Entity<Serwis>().HasData(serwis);
                    }
                }


                // Drukarki

                for (var k = 0; k < _rand.Next(1, 4); k++)
                {
                    Sprzet sprzetDrukarka = new Sprzet ()
                    {
                        SprzetId = Guid.NewGuid ().ToString (),
                        Nazwa = $"Drukarka{k+1}",
                        RodzajSprzetuId = rodzajeSprzetowId [2],
                        FirmaId = firma.FirmaId,
                    };
                    builder.Entity<Sprzet>().HasData(sprzetDrukarka);

                    for (var l = 0; l < drukarkaFields.Count; l++)
                    {
                        Pole pole = new Pole ()
                        {
                            PoleId = Guid.NewGuid ().ToString (),
                            Name = drukarkaFields [l],
                            Wartosc = _dataAutogenerator.Nazwisko(),
                            SprzetId = sprzetDrukarka.SprzetId
                        };
                        builder.Entity<Pole>().HasData(pole);
                    }
                }



                // hosting 
                for (var l = 0; l < _rand.Next(0, 1); l++)
                {
                    Hosting hosting = new Hosting ()
                    {
                        HostingId = Guid.NewGuid ().ToString (),
                        FirmaId = firma.FirmaId,
                        Information = _dataAutogenerator.Description (1)
                    };
                    builder.Entity<Hosting>().HasData(hosting);
                }

                // informacje sprzedażowe
                for (var l = 0; l < _rand.Next(2, 10); l++)
                {
                    InformacjeSprzedazowe informacjeSprzedazowe = new InformacjeSprzedazowe ()
                    {
                        InformacjeSprzedazoweId = Guid.NewGuid ().ToString (),
                        FirmaId = firma.FirmaId,
                        Cena = _rand.Next (20,120),
                        NazwaProduktu = rodzajeSprzetow [_rand.Next(0,rodzajeSprzetow.Count)],
                        Uwagi = _dataAutogenerator.Description (1)
                    };
                    builder.Entity<InformacjeSprzedazowe>().HasData(informacjeSprzedazowe);
                }
            }


            for (var i=0; i<10; i++)
            {
                Wiedza wiedza = new Wiedza ()
                {
                    WiedzaId = Guid.NewGuid ().ToString (),
                    DataDodania = _dataAutogenerator.RandomDateTime (),
                    Temat = _dataAutogenerator.Nazwisko (),
                    Rozwiazanie = _dataAutogenerator.Description (1),
                };
                builder.Entity<Wiedza>().HasData(wiedza);
            }


            // licencje wolne
            for (var i = 0; i < _rand.Next(0, 5); i++)
            {
                int iloscLicencji = _rand.Next (1,6);
                WolnaLicencja wolnaLicencja = new WolnaLicencja ()
                {
                    WolnaLicencjaId = Guid.NewGuid ().ToString (),
                    DataWaznosci = DateTime.Now.AddMonths (_rand.Next(1,6)),
                    DataZakupu = DateTime.Now.AddDays (-_rand.Next(100,300)),
                    MiejsceZakupu = _dataAutogenerator.Description (1),
                    KluczLicencji = Guid.NewGuid ().ToString (),
                    IloscLicencji = iloscLicencji
                };
                builder.Entity<WolnaLicencja>().HasData(wolnaLicencja);
            }
*/





            

            base.OnModelCreating(builder);
        }

    }
}
