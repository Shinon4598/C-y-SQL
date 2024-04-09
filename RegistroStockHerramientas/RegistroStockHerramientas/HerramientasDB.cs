using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace RegistroStockHerramientas
{
    internal class HerramientasDB
    {
        private string ConnectionString
            = "Data Source=localhost;Initial Catalog = Herramientas;" +
            "User=sa;Password=123456";

        public List<Herramienta> Get()
        {
            List <Herramienta> herramientas = new List<Herramienta>();

            string query = "SELECT * FROM herramientas";

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Herramienta Oherramienta = new Herramienta();

                        Oherramienta.Id = reader.GetInt32(0);
                        Oherramienta.Nombre = reader.GetString(1);

                        Oherramienta.Descripcion = reader.IsDBNull(2) ? null : reader.GetString(2);

                        Oherramienta.Codigo = reader.GetString(3);
                        Oherramienta.Marca = reader.GetString(4);
                        Oherramienta.Stock_minimo = reader.GetInt32(5);
                        Oherramienta.Stock_maximo = reader.GetInt32(6);
                        Oherramienta.Precio_unitario = reader.GetDouble(7);

                        herramientas.Add(Oherramienta);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    connection.Close();
                }
                return herramientas;
            }
        }

        public Herramienta Get(int id)
        {
            string query = "SELECT id,nombre,descripcion,codigo,marca,stock_minimo,stock_maximo,precio_unitario FROM herramientas " +
                "where id = @id";

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", id);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    reader.Read();

                    Herramienta Oherramienta = new Herramienta();

                    Oherramienta.Id = reader.GetInt32(0);
                    Oherramienta.Nombre = reader.GetString(1);
                    Oherramienta.Descripcion = reader.IsDBNull(2) ? null : reader.GetString(2);
                    Oherramienta.Codigo = reader.GetString(3);
                    Oherramienta.Marca = reader.GetString(4);
                    Oherramienta.Stock_minimo = reader.GetInt32(5);
                    Oherramienta.Stock_maximo = reader.GetInt32(6);
                    Oherramienta.Precio_unitario = reader.GetDouble(7);

                    reader.Close();
                    connection.Close();
                    return Oherramienta;
                }
                catch (Exception ex)
                {
                    throw new Exception("en Persona Get" + ex.Message);
                }
            }
        }

        public void Add(string Nombre, string Cod, string Marca, int stMin, int stMax, double PrecioUn,string Descr = null)
        {
            string query = "INSERT INTO herramientas(nombre, descripcion, codigo, marca, stock_minimo, stock_maximo, precio_unitario) VALUES" +
                "(@nombre,@descripcion,@codigo,@marca,@stock_minimo, @stock_maximo, @precio_unitario);";

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@nombre", Nombre);
                command.Parameters.AddWithValue("@descripcion", Descr);
                command.Parameters.AddWithValue("@codigo", Cod);
                command.Parameters.AddWithValue("@marca", Marca);
                command.Parameters.AddWithValue("@stock_minimo", stMin);
                command.Parameters.AddWithValue("@stock_maximo", stMax);
                command.Parameters.AddWithValue("@precio_unitario", PrecioUn);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }
        public void Update(int id, string Nombre, string Cod, string Marca, int stMin, int stMax, double PrecioUn, string Descr = null)
        {
            string query = "update herramientas set nombre = @nombre, descripcion = @descr, codigo = @cod, " +
                "marca =@marca, stock_minimo = @stMin, stock_maximo =@stMax, precio_unitario = @precio " +
                "where id = @id";

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", id);
                command.Parameters.AddWithValue("@nombre", Nombre);
                command.Parameters.AddWithValue("@descr", Descr);
                command.Parameters.AddWithValue("@cod", Cod);
                command.Parameters.AddWithValue("@marca", Marca);
                command.Parameters.AddWithValue("@stMin", stMin);
                command.Parameters.AddWithValue("@stMax", stMax);
                command.Parameters.AddWithValue("@precio", PrecioUn);
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch(Exception ex)
                {
                    throw new Exception(ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        public void Delete(int id)
        {
            string query = "Delete from herramientas " +
                "where id = @id";

            using (SqlConnection connection = new SqlConnection(ConnectionString)){

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@id", id);
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        public List<Herramienta> MenorPrecio()
        {
            List<Herramienta> herramientas = new List<Herramienta>();
            string query = "SELECT * FROM herramientas " +
                "ORDER by precio_unitario asc;";

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                SqlCommand sqlCommand = new SqlCommand(query, connection);
                try
                {
                    connection.Open();
                    SqlDataReader reader = sqlCommand.ExecuteReader();
                    while (reader.Read())
                    {
                        Herramienta Oherramienta = new Herramienta();

                        Oherramienta.Id = reader.GetInt32(0);
                        Oherramienta.Nombre = reader.GetString(1);
                        Oherramienta.Descripcion = reader.IsDBNull(2) ? null : reader.GetString(2);
                        Oherramienta.Codigo = reader.GetString(3);
                        Oherramienta.Marca = reader.GetString(4);
                        Oherramienta.Stock_minimo = reader.GetInt32(5);
                        Oherramienta.Stock_maximo = reader.GetInt32(6);
                        Oherramienta.Precio_unitario = reader.GetDouble(7);

                        herramientas.Add(Oherramienta);
                    }
                    reader.Close();
                }catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
            return herramientas;
        }
        public List<Herramienta> MayorPrecio()
        {
            List<Herramienta> herramientas = new List<Herramienta>();
            string query = "SELECT * FROM herramientas " +
                "ORDER by precio_unitario desc;";

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                SqlCommand sqlCommand = new SqlCommand(query, connection);
                try
                {
                    connection.Open();
                    SqlDataReader reader = sqlCommand.ExecuteReader();
                    while (reader.Read())
                    {
                        Herramienta Oherramienta = new Herramienta();

                        Oherramienta.Id = reader.GetInt32(0);
                        Oherramienta.Nombre = reader.GetString(1);
                        Oherramienta.Descripcion = reader.IsDBNull(2) ? null : reader.GetString(2);
                        Oherramienta.Codigo = reader.GetString(3);
                        Oherramienta.Marca = reader.GetString(4);
                        Oherramienta.Stock_minimo = reader.GetInt32(5);
                        Oherramienta.Stock_maximo = reader.GetInt32(6);
                        Oherramienta.Precio_unitario = reader.GetDouble(7);

                        herramientas.Add(Oherramienta);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
            return herramientas;
        }
    }
    public class Herramienta {
        private int _stock_maximo;
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Marca { get; set; }
        public string Codigo { get; set; }
        public int Stock_minimo { get; set; }
        public int Stock_maximo {
            get 
            { 
                return _stock_maximo;
            } 
            set 
            {
                if (value >= Stock_minimo)
                {
                    _stock_maximo = value;
                }
            }
        }
        public double Precio_unitario { get; set; }
    }

}
