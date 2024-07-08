using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp90.Data;
using WinFormsApp90.Forms.Archiwizacje;
using WinFormsApp90.Forms.BazaWiedzy;
using WinFormsApp90.Forms.DzialaniaSerwisowe;
using WinFormsApp90.Forms.Firmy;
using WinFormsApp90.Forms.Gwarancje;
using WinFormsApp90.Forms.HaslaInfo;
using WinFormsApp90.Forms.Hostingi;
using WinFormsApp90.Forms.InformacjeSprzedazowe;
using WinFormsApp90.Forms.Kontakty;
using WinFormsApp90.Forms.Naprawy;
using WinFormsApp90.Forms.Pracownicy;
using WinFormsApp90.Forms.Preferencje.Sprzety;
using WinFormsApp90.Forms.Raporty;
using WinFormsApp90.Forms.Siec;
using WinFormsApp90.Forms.SprzetLicencje;
using WinFormsApp90.Forms.TabliceInformacyjne;
using WinFormsApp90.Forms.Terminy;
using WinFormsApp90.Forms.Umowy;
using WinFormsApp90.Forms.Uprawnienia;
using WinFormsApp90.Services;

namespace WinFormsApp90.Forms
{
    public partial class ITUserControl : BaseUserControl
    {
        public ITUserControl (IUnityOfWork unityOfWork) : base (unityOfWork)
        {
            InitializeComponent();

            S.SetColors(panelNavigationMain);
            S.SetColor(panelNavigationMain);
            S.ClearPanelContainer(panelContainerMain);
            buttonPracownicy.BackColor = Color.DimGray;
            buttonPracownicy.ForeColor = Color.White;


            PracownicyUserControl pracownicyUserControl = new PracownicyUserControl (_unityOfWork);
            pracownicyUserControl.Dock = DockStyle.Fill;
            panelContainerMain.Controls.Add(pracownicyUserControl);

        }



        private void buttonPracownicy_Click (object sender, EventArgs e)
        {
            S.ClearPanelContainer(panelContainerMain);
            PracownicyUserControl pracownicyUserControl = new PracownicyUserControl (_unityOfWork);
            pracownicyUserControl.Dock = DockStyle.Fill;
            panelContainerMain.Controls.Add(pracownicyUserControl);
        }

        private void buttonUprawnienia_Click (object sender, EventArgs e)
        {
            S.ClearPanelContainer(panelContainerMain);
            UprawnieniaUserControl uprawnieniaUserControl = new UprawnieniaUserControl (_unityOfWork);
            uprawnieniaUserControl.Dock = DockStyle.Fill;
            panelContainerMain.Controls.Add(uprawnieniaUserControl);
        }

        private void buttonFirmy_Click (object sender, EventArgs e)
        {
            S.ClearPanelContainer(panelContainerMain);
            FirmyUserControl firmyUserControl = new FirmyUserControl (_unityOfWork);
            firmyUserControl.Dock = DockStyle.Fill;
            panelContainerMain.Controls.Add(firmyUserControl);
        }

        private void buttonKontakty_Click (object sender, EventArgs e)
        {
            S.ClearPanelContainer(panelContainerMain);
            KontaktyUserControl kontaktyUserControl = new KontaktyUserControl (_unityOfWork);
            kontaktyUserControl.Dock = DockStyle.Fill;
            panelContainerMain.Controls.Add(kontaktyUserControl);
        }

        private void buttonDzialaniaSerwisowe_Click (object sender, EventArgs e)
        {
            S.ClearPanelContainer(panelContainerMain);
            DzialaniaSerwisoweUserControl dzialaniaSerwisoweUserControl = new DzialaniaSerwisoweUserControl (_unityOfWork);
            dzialaniaSerwisoweUserControl.Dock = DockStyle.Fill;
            panelContainerMain.Controls.Add(dzialaniaSerwisoweUserControl);
        }

        private void buttonNaprawy_Click (object sender, EventArgs e)
        {
            S.ClearPanelContainer(panelContainerMain);
            NaprawyUserControl naprawyUserControl = new NaprawyUserControl (_unityOfWork);
            naprawyUserControl.Dock = DockStyle.Fill;
            panelContainerMain.Controls.Add(naprawyUserControl);
        }

        private void buttonSprzet_Click (object sender, EventArgs e)
        {
            S.ClearPanelContainer(panelContainerMain);
            SprzetUserControl sprzetUserControl = new SprzetUserControl (_unityOfWork);
            sprzetUserControl.Dock = DockStyle.Fill;
            panelContainerMain.Controls.Add(sprzetUserControl);
        }

        private void buttonSiec_Click (object sender, EventArgs e)
        {
            S.ClearPanelContainer(panelContainerMain);
            SiecUserControl siecUserControl = new SiecUserControl (_unityOfWork);
            siecUserControl.Dock = DockStyle.Fill;
            panelContainerMain.Controls.Add(siecUserControl);
        }

        private void buttonLicencje_Click (object sender, EventArgs e)
        {
            S.ClearPanelContainer(panelContainerMain);
            SprzetLicencjeUserControl sprzetLicencjeUserControl = new SprzetLicencjeUserControl (_unityOfWork);
            sprzetLicencjeUserControl.Dock = DockStyle.Fill;
            panelContainerMain.Controls.Add(sprzetLicencjeUserControl);
        }

        private void buttonArchiwizacja_Click (object sender, EventArgs e)
        {
            S.ClearPanelContainer(panelContainerMain);
            ArchiwizacjeUserControl archiwizacjeUserControl = new ArchiwizacjeUserControl (_unityOfWork);
            archiwizacjeUserControl.Dock = DockStyle.Fill;
            panelContainerMain.Controls.Add(archiwizacjeUserControl);
        }

        private void buttonGwarancje_Click (object sender, EventArgs e)
        {
            S.ClearPanelContainer(panelContainerMain);
            GwarancjeUserControl gwarancjeUserControl = new GwarancjeUserControl (_unityOfWork);
            gwarancjeUserControl.Dock = DockStyle.Fill;
            panelContainerMain.Controls.Add(gwarancjeUserControl);
        }

        private void buttonHasting_Click (object sender, EventArgs e)
        {
            S.ClearPanelContainer(panelContainerMain);
            HostingUserControl hostingUserControl = new HostingUserControl (_unityOfWork);
            hostingUserControl.Dock = DockStyle.Fill;
            panelContainerMain.Controls.Add(hostingUserControl);
        }

        private void buttonHasla_Click (object sender, EventArgs e)
        {
            S.ClearPanelContainer(panelContainerMain);
            HasloInfoUserControl hasloInfoUserControl = new HasloInfoUserControl (_unityOfWork);
            hasloInfoUserControl.Dock = DockStyle.Fill;
            panelContainerMain.Controls.Add(hasloInfoUserControl);
        }

        private void buttonUmowy_Click (object sender, EventArgs e)
        {
            S.ClearPanelContainer(panelContainerMain);
            UmowyUserControl umowyUserControl = new UmowyUserControl (_unityOfWork);
            umowyUserControl.Dock = DockStyle.Fill;
            panelContainerMain.Controls.Add(umowyUserControl);
        }

        private void buttonTerminy_Click (object sender, EventArgs e)
        {
            S.ClearPanelContainer(panelContainerMain);
            TerminyUserControl terminyUserControl = new TerminyUserControl (_unityOfWork);
            terminyUserControl.Dock = DockStyle.Fill;
            panelContainerMain.Controls.Add(terminyUserControl);
        }

        private void buttonInformacjeSprzedazowe_Click (object sender, EventArgs e)
        {
            S.ClearPanelContainer(panelContainerMain);
            InformacjeSprzedazoweUserControl informacjeSprzedazoweUserControl = new InformacjeSprzedazoweUserControl (_unityOfWork);
            informacjeSprzedazoweUserControl.Dock = DockStyle.Fill;
            panelContainerMain.Controls.Add(informacjeSprzedazoweUserControl);
        }

        private void buttoRaporty_Click (object sender, EventArgs e)
        {
            S.ClearPanelContainer(panelContainerMain);
            RaportyUserControl raportyUserControl = new RaportyUserControl (_unityOfWork);
            raportyUserControl.Dock = DockStyle.Fill;
            panelContainerMain.Controls.Add(raportyUserControl);
        }

        private void buttonTablicaInformacyjna_Click (object sender, EventArgs e)
        {
            S.ClearPanelContainer(panelContainerMain);
            TablicaInformacyjnaUserControl tablicaInformacyjnaUserControl = new TablicaInformacyjnaUserControl (_unityOfWork);
            tablicaInformacyjnaUserControl.Dock = DockStyle.Fill;
            panelContainerMain.Controls.Add(tablicaInformacyjnaUserControl);
        }

        private void buttonBazaWidzy_Click (object sender, EventArgs e)
        {
            S.ClearPanelContainer(panelContainerMain);
            BazaWiedzyUserControl bazaWiedzyUserControl = new BazaWiedzyUserControl (_unityOfWork);
            bazaWiedzyUserControl.Dock = DockStyle.Fill;
            panelContainerMain.Controls.Add(bazaWiedzyUserControl);
        }

    }
}
