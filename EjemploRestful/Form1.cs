using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploRestful
{
    public partial class Form1 : Form
    {
        
       

        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            ObtenerProvincias();
          
        }


        public DataTable CrearDataSource(dynamic dynObj) {
            DataTable dt = new DataTable();
            dt.Columns.Add("id");
            dt.Columns.Add("nombre");
            //JContainer is the base class
            var jObj = (JObject)dynObj;
            foreach (JToken token in jObj.Children())
            {
                if (token is JProperty)
                {
                    var prop = token as JProperty;
                    DataRow P = dt.NewRow();
                    P["id"] = prop.Name;
                    P["nombre"] = prop.Value;
                    dt.Rows.Add(P);

                }
            }

            return dt;
        }


        private void ObtenerProvincias() {

            var request = (HttpWebRequest)WebRequest.Create("https://ubicaciones.paginasweb.cr/provincias.json");

            request.Method = "GET";
           

            request.AutomaticDecompression = DecompressionMethods.Deflate | DecompressionMethods.GZip;

            var response = (HttpWebResponse)request.GetResponse();

            string content = string.Empty;

            using (var stream = response.GetResponseStream())

            {
                using (var sr = new StreamReader(stream))
                {
                    content = sr.ReadToEnd();
                }

                dynamic dynObj = JsonConvert.DeserializeObject(content);                

                        
                ComboProvincia.DataSource=CrearDataSource(dynObj);
                ComboProvincia.ValueMember = "id";
                ComboProvincia.DisplayMember = "nombre";
                ComboProvincia.Refresh();



            }

        }


        private void ObtenerCatones(string idprovincia)
        {
            string url = "https://ubicaciones.paginasweb.cr/provincia/" + idprovincia + "/cantones.json";
            var request = (HttpWebRequest)WebRequest.Create("https://ubicaciones.paginasweb.cr/provincia/"+idprovincia+"/cantones.json");

            request.Method = "GET";


            request.AutomaticDecompression = DecompressionMethods.Deflate | DecompressionMethods.GZip;


            try
            {
                var response = (HttpWebResponse)request.GetResponse();
                string content = string.Empty;

                using (var stream = response.GetResponseStream())

                {
                    using (var sr = new StreamReader(stream))
                    {
                        content = sr.ReadToEnd();
                    }

                    dynamic dynObj = JsonConvert.DeserializeObject(content);


                    ComboCanton.DataSource = CrearDataSource(dynObj);
                    ComboCanton.ValueMember = "id";
                    ComboCanton.DisplayMember = "nombre";
                    ComboCanton.Refresh();



                }
            }
            catch (Exception ex)
            {
               


            }

           

          

        }

        private void ObtenerDistritos(string idprovincia,string idcanton)
        {

            var request = (HttpWebRequest)WebRequest.Create("https://ubicaciones.paginasweb.cr/provincia/"+idprovincia+"/canton/"+idcanton+"/distritos.json");

            request.Method = "GET";


            request.AutomaticDecompression = DecompressionMethods.Deflate | DecompressionMethods.GZip;

            try
            {
                var response = (HttpWebResponse)request.GetResponse();

            string content = string.Empty;

            using (var stream = response.GetResponseStream())

            {
                using (var sr = new StreamReader(stream))
                {
                    content = sr.ReadToEnd();
                }

                dynamic dynObj = JsonConvert.DeserializeObject(content);


                ComboDistrito.DataSource = CrearDataSource(dynObj);
                ComboDistrito.ValueMember = "id";
                ComboDistrito.DisplayMember = "nombre";
                ComboDistrito.Refresh();



            }

            }
            catch (Exception ex)
            {



            }

        }

        private void ComboCanton_SelectedIndexChanged(object sender, EventArgs e)
        {
            ObtenerDistritos(ComboProvincia.SelectedValue.ToString(), ComboCanton.SelectedValue.ToString());
        }

        private void ComboProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            if (!ComboProvincia.SelectedValue.ToString().Equals("System.Data.DataRowView"))
                    {
                ObtenerCatones(ComboProvincia.SelectedValue.ToString());
                     }
               
        }

        
    }
}
