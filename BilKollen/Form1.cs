using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BilKollen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.ActiveControl = textBox1;
        }

        //När man trycker på enter i textfältet så kommer go-knappen att "tryckas"
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(this, new EventArgs());
            }
        }

        //Go-knappen
        private void button1_Click(object sender, EventArgs e)
        {
            //kontroll för att programmet ska skicka regnr i rätt format
            if (textBox1.Text.Length < 6 ||
                !char.IsDigit(textBox1.Text[textBox1.Text.Length - 1]) ||
                !char.IsDigit(textBox1.Text[textBox1.Text.Length - 2]) ||
                !char.IsDigit(textBox1.Text[textBox1.Text.Length - 3]))
            {
                MessageBox.Show("Du måste skriva ett giltigt registreringsnummer!");
            }
            else
            {
                VisaBilUppgifter();
            }

        }

        public void VisaBilUppgifter()
        {

            using (var webClient = new WebClient())
            {
                try
                {
                    //Hämtar uppgifter från servern med hjälp av en token
                    webClient.Headers.Add(HttpRequestHeader.Authorization, "Bearer iDCtQ4huZcBUtvjioUNsopJGSVhYnEQQSIlJrzoqrvGPJq8uJBOIoBllBgGo");
                    string json = webClient.DownloadString("https://api.biluppgifter.se/api/v1/vehicle/regno/" + textBox1.Text);
                    this.Size = new Size(802, 410);
                    var welcome = Welcome.FromJson(json);
                    listBox1.Items.Clear();
                    listBox1.Items.Add("Registreringsnummer: " + welcome.Data.Attributes.Regno);
                    listBox1.Items.Add("Färg: " + welcome.Data.Basic.Data.Color);
                    listBox1.Items.Add("Märke: " + welcome.Data.Basic.Data.Make);
                    listBox1.Items.Add("Modell: " + welcome.Data.Basic.Data.Model);
                    listBox1.Items.Add("VIN: " + welcome.Data.Attributes.Vin);
                    listBox1.Items.Add("Årsmodell: " + welcome.Data.Basic.Data.VehicleYear);
                    listBox1.Items.Add("Längd: " + welcome.Data.Technical.Data.Length);
                    listBox1.Items.Add("Bredd: " + welcome.Data.Technical.Data.AxelWidth);
                    listBox1.Items.Add("Kategori: " + welcome.Data.Technical.Data.Category);
                    listBox1.Items.Add("Total vikt: " + welcome.Data.Technical.Data.TotalWeight + " KG");
                    listBox1.Items.Add("Tire Back: " + welcome.Data.Technical.Data.TireBack);
                    listBox1.Items.Add("Tire Front: " + welcome.Data.Technical.Data.TireFront);
                    listBox1.Items.Add("Rim Back: " + welcome.Data.Technical.Data.RimBack);
                    listBox1.Items.Add("Rim Front: " + welcome.Data.Technical.Data.RimFront);
                }
                catch (WebException)
                {

                    MessageBox.Show("Du måste skriva ett giltigt registreringsnummer!");
                }
                


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();

        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            // Hämta filnamn.
            string name = saveFileDialog1.FileName;
            // Skriv till filen.
            foreach (var item in listBox1.Items)
            {
                File.AppendAllText(name, item.ToString() + Environment.NewLine);
            }
        }
    }
}
