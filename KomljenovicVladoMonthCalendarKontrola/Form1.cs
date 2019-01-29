using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KomljenovicVladoMonthCalendarKontrola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TimeSpan ts = monthCalendar1.SelectionEnd - monthCalendar1.SelectionStart;

            if (ts.Days < 1)
            {
                MessageBox.Show("Korištenjem tipke SHIFT odaberite opseg datuma.");
                return;

            }

            // poruka o izabranom broju dana
            MessageBox.Show("Rezervirali ste usluge u trajanju od " + ts.Days.ToString() + "dana.", "Rezervacija");
            // poruka o izabranim datumima pocetka i kraja rezervacije
            MessageBox.Show("Vasa rezervacija počinje " + monthCalendar1.SelectionStart.ToShortDateString() + " a završava se " + monthCalendar1.SelectionEnd.ToShortDateString());

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            MessageBox.Show("Naziv programa: MonthCalendarKontrola\n Ime učenika: Vlado  \n Prezime učenika: Komljenovic \n" +
           " Datum izrade 22.1.2019 \nDavatelj licence dopušta umnožavanje, distribuiranje i priopćavanje djela javnosti." +
           " Zauzvrat primatelji licence moraju imenovanjem priznati i označiti izvornog autora.");
        }
    }
    }

