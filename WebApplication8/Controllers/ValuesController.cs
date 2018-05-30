using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web;
using System.Web.Http;

namespace WebApplication8.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "Leanne Graham", "value2" };
        }

        // GET api/values/5
        public Object Get(int id)
        {
            

            if (id == 1)
            {
                Object json = "";
                //String cadena = "";
                StringBuilder stringBuilder = new StringBuilder();
                Usuario usuario = new Usuario();
                StringBuilder texto = new StringBuilder();
                String connString = "datasource=192.168.1.148;port=3306;Database=noticias;Uid=lamp;password=lamp;SslMode=none";
                MySqlConnection conn = new MySqlConnection(connString);
                MySqlCommand command = conn.CreateCommand();
                command.CommandText = "select id,nombre from usuario order by id";

                conn.Open();
                MySqlDataReader reader = command.ExecuteReader();

                Usuario[] usu = new Usuario[10];
                int contador = 0;

                //Mal formato al devolver con JsonConvert.SerializeObject
                while (reader.Read())
                {
                    usu[contador]=new Usuario(
                    usuario.nombre = (reader["nombre"].ToString()),
                    usuario.Id= ((int)reader["Id"]));
                    contador++;
                }
                //json = JsonConvert.SerializeObject(usu);
                //return usu[0];
                return usu;
            }


            if (id == 2)
            {

                Object json = "";
                //String cadena = "";
                StringBuilder stringBuilder = new StringBuilder();
                Usuario usuario = new Usuario();
                StringBuilder texto = new StringBuilder();
                String connString = "datasource=192.168.1.148;port=3306;Database=noticias;Uid=lamp;password=lamp;SslMode=none";
                MySqlConnection conn = new MySqlConnection(connString);
                MySqlCommand command = conn.CreateCommand();
                command.CommandText = "select id,nombre from usuario order by id";

                conn.Open();
                MySqlDataReader reader = command.ExecuteReader();
                //Mal formato al devolver con StringBuilder
                stringBuilder.Append("{");

                while (reader.Read())
                {
                    stringBuilder.Append("id");
                    stringBuilder.Append(":");
                    stringBuilder.Append(reader["id"].ToString());
                    stringBuilder.Append(",");
                    //stringBuilder.AppendLine();
                    //int codigo = ((int)reader["Id"]));
                    stringBuilder.Append("name");
                    stringBuilder.Append(":");
                    stringBuilder.Append(reader["nombre"].ToString());
                    stringBuilder.Append(",");
                    //stringBuilder.AppendLine();

                }
                stringBuilder.Append("}");

                return stringBuilder;
            }


            if (id == 3)
            {
                Object json = "";
                //String cadena = "";
                StringBuilder stringBuilder = new StringBuilder();
                Usuario usuario = new Usuario();
                StringBuilder texto = new StringBuilder();
                String connString = "datasource=192.168.1.148;port=3306;Database=noticias;Uid=lamp;password=lamp;SslMode=none";
                MySqlConnection conn = new MySqlConnection(connString);
                MySqlCommand command = conn.CreateCommand();
                command.CommandText = "select id,nombre from usuario order by id";

                conn.Open();
                MySqlDataReader reader = command.ExecuteReader();

                string allText = System.IO.File.ReadAllText(@"C: \Users\Roberto\source\repos\WebApplication8\WebApplication8\Models\json.json");

                object jsonObject = JsonConvert.DeserializeObject(allText);
                return jsonObject;
            }

            if (id == 4)
            {
                Object json = "";
                //String cadena = "";
                StringBuilder stringBuilder = new StringBuilder();
                Usuario usuario = new Usuario();
                StringBuilder texto = new StringBuilder();
                String connString = "datasource=192.168.1.148;port=3306;Database=noticias;Uid=lamp;password=lamp;SslMode=none";
                MySqlConnection conn = new MySqlConnection(connString);
                MySqlCommand command = conn.CreateCommand();
                command.CommandText = "select id,nombre from usuario order by id";

                conn.Open();
                MySqlDataReader reader = command.ExecuteReader();

                int contador = 0;
                String[] prueba = new String[20];
                ArrayList myal = new ArrayList();
                while (reader.Read()) {

                    prueba[contador] =(reader["nombre"].ToString());
                    contador++;
                    prueba[contador] = (reader["id"].ToString());
                    contador++;
            }

                //cadena = "\"" + "nombre" + ":" + "\"" + prueba[0] + "\"" + "," + "\"" + "Id" + "\"" + ":" + prueba[1];

                for (int i=0;i<= prueba.Length - 1; i++)
                {
                    myal.Add(prueba[i]);
                }

                return myal;
            }

            if (id == 5)
            {
                Object json = "";
                //String cadena = "";
                StringBuilder stringBuilder = new StringBuilder();
                Usuario usuario = new Usuario();
                StringBuilder texto = new StringBuilder();
                String connString = "datasource=192.168.1.148;port=3306;Database=noticias;Uid=lamp;password=lamp;SslMode=none";
                MySqlConnection conn = new MySqlConnection(connString);
                MySqlCommand command = conn.CreateCommand();
                command.CommandText = "select id,nombre from usuario order by id";

                conn.Open();
                MySqlDataReader reader = command.ExecuteReader();

                int contador = 0;
                Usuario[] usus = new Usuario[contador];
                String cont = "datasource=192.168.1.148;port=3306;Database=noticias;Uid=lamp;password=lamp;SslMode=none";
                MySqlConnection conect = new MySqlConnection(cont);
                conect.Open();
                MySqlCommand commando = conect.CreateCommand();

                //consulta select
                commando.CommandText = ("SELECT `id`,`nombre` FROM `usuario` order by id");
                commando.Connection = conect;
                MySqlDataReader readerr = commando.ExecuteReader();

                ArrayList myal = new ArrayList();


                while (reader.Read())
                {
                    usus = new Usuario[] {
                 new Usuario(){
                     Id=(int)reader["id"],
                     nombre=reader["nombre"].ToString()
                             }

                 };

                    myal.Add(usus);
                }
                //Object jsonString = JsonConvert.SerializeObject(usus);
                return myal;
            }

            if (id == 6)
            {
                StreamReader leer = new StreamReader(HttpContext.Current.Request.InputStream);
                string requestFromPost = leer.ReadToEnd();

                foreach (string key in HttpContext.Current.Request.Form.AllKeys)
                {
                    string value = HttpContext.Current.Request.Form[key];
                }

                return requestFromPost;
            }

            else
            {
                return null;
            }
        }


        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
