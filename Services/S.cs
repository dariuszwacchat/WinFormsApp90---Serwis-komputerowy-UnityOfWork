using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp90.Forms;

namespace WinFormsApp90.Services
{
    public static class S
    {


        public static void ClearPanelContainer (Panel panelContainer)
        {
            panelContainer.Controls.Clear();
        }


        // Ustawienie koloru dla jednego buttona
        public static void SetColor (Panel panelNavigation)
        {
            foreach (Control control in panelNavigation.Controls)
            {
                if (control is Button)
                {
                    Button button = control as Button;
                    button.Click += (s, e) =>
                    {
                        SetColors(panelNavigation);
                        Button b = (Button) s;
                        b.BackColor = Color.DimGray;
                        b.ForeColor = Color.White;
                    }; 
                }
            }
        }

        // Ustawienie kolorów dla wszystkich buttonów
        public static void SetColors (Panel panelNavigation)
        {
            foreach (Control control in panelNavigation.Controls)
            {
                if (control is Button)
                {
                    Button button = control as Button;
                    button.BackColor = Color.FromArgb(220, 220, 220);
                    button.ForeColor = Color.Black;
                    button.Paint += (s, e) =>
                    {
                        e.Graphics.DrawRectangle(new Pen(Brushes.DarkGray, 2), new Rectangle(
                            new Point(15, 17),
                            new Size(16, 16)
                            ));
                    };
                }
            }

        }


        public static void SetDataGridViewStyles (DataGridView dataGridView)
        {
            dataGridView.AllowUserToOrderColumns = false;
            dataGridView.AllowUserToResizeRows = false;
            dataGridView.AllowUserToResizeColumns = true;
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;

            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.RowHeadersVisible = false;
            dataGridView.BorderStyle = BorderStyle.None;
            dataGridView.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.ReadOnly = false;
            dataGridView.MultiSelect = false;
            dataGridView.EnableHeadersVisualStyles = false;
            dataGridView.BackgroundColor = Color.White;

            dataGridView.ColumnHeadersHeight = 50;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Raised;

            dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
            dataGridView.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(245, 245, 245);
            dataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9, FontStyle.Bold);
             
            dataGridView.DefaultCellStyle.SelectionBackColor = Color.CadetBlue;
            dataGridView.DefaultCellStyle.SelectionForeColor = Color.White;
            dataGridView.DefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245);

        }


        public static void SetDataGridViewStylesOrders (DataGridView dataGridView)
        {
            dataGridView.AllowUserToOrderColumns = false;
            dataGridView.AllowUserToResizeRows = false;
            dataGridView.AllowUserToResizeColumns = false;
            dataGridView.AllowUserToAddRows = true;
            dataGridView.AllowUserToDeleteRows = false;

            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.RowHeadersVisible = false;
            dataGridView.BorderStyle = BorderStyle.None;
            dataGridView.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.ReadOnly = false;
            dataGridView.MultiSelect = false;
            dataGridView.EnableHeadersVisualStyles = false;

            dataGridView.ColumnHeadersHeight = 50;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Raised;

            dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
            dataGridView.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.White;
            dataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9, FontStyle.Bold);

            dataGridView.DefaultCellStyle.SelectionForeColor = Color.Black;
            dataGridView.DefaultCellStyle.SelectionBackColor = Color.White;

        }





    }
}
