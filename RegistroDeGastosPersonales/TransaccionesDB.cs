using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistroDeGastosPersonales
{
    internal class TransaccionesDB
    {
        /*TransaccionesBD (Columnas con números de identificación)
         * 
        tipo = 
        1.ingreso, 2.gasto,

        motivo = 
        1	Alquileres, 2	Aportes de Capital, 3	Bienes registrables habituales
        4	Bienes registrables no habitualistas, 5	Cuotas, 6	Expensas
        7	Facturas, 8	Haberes, 9	Honorarios, 10	Operaciones inmobiliarias
        11	Préstamos, 12	Seguros, 13	Varios

        metodo =
        1.Crédito, 2.Débito, 3.Efectivo
        */

        string connectionString = @"Data Source=localhost;Initial Catalog=RegistroGastos;"+
        "User=sa;Password=123456";

        public List<Transaccion> Get()
        {
            List<Transaccion> transacciones = new List<Transaccion>();

            string query = "SELECT t.id, t.fecha, t.descripcion, m.nombre as Motivo, t.monto, me.nombre, tp.nombre as Tipo from transacciones t " +
                "join motivo m on m.id = t.motivo_id " +
                "join tipo tp on tp.id = t.tipo_id " +
                "join metodo me on me.id = t.metodo_id;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Transaccion Otransaccion = new Transaccion();

                        Otransaccion.Id = reader.GetInt32(0);
                        Otransaccion.Fecha = reader.GetDateTime(1);
                        Otransaccion.Descripcion = reader.GetString(2);
                        Otransaccion.Motivo = reader.GetString(3);
                        Otransaccion.Monto = reader.GetDecimal(4);
                        Otransaccion.Metodo = reader.GetString(5);
                        Otransaccion.Tipo = reader.GetString(6);

                        transacciones.Add(Otransaccion);
                    }
                }catch(Exception ex)
                {
                    MessageBox.Show("Error obteniendo los datos de la tabla Transacciones: " + ex.Message);
                }
            }
            return transacciones;
        }
        public Transaccion Get(int id)
        {
            string query = "SELECT t.id, t.fecha, t.descripcion, m.nombre as Motivo, t.monto, me.nombre, tp.nombre as Tipo from transacciones t " +
                "join motivo m on m.id = t.motivo_id " +
                "join tipo tp on tp.id = t.tipo_id " +
                "join metodo me on me.id = t.metodo_id " +
                "where t.id = @id;";

            Transaccion Otransaccion = new Transaccion();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand(query, connection);
                sqlCommand.Parameters.AddWithValue("@id", id);

                try
                {
                    connection.Open();
                    SqlDataReader reader = sqlCommand.ExecuteReader();
                    while (reader.Read())
                    {
                        Otransaccion.Id = reader.GetInt32(0);
                        Otransaccion.Fecha = reader.GetDateTime(1);
                        Otransaccion.Descripcion = reader.GetString(2);
                        Otransaccion.Motivo = reader.GetString(3);
                        Otransaccion.Monto = reader.GetDecimal(4);
                        Otransaccion.Metodo = reader.GetString(5);
                        Otransaccion.Tipo = reader.GetString(6);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error obteniendo los datos de la tabla Transacciones: " + ex.Message);
                }
            }
            return Otransaccion;
        }
        public void Update(int id, DateTime fecha, int mot_id, decimal mont, int met_id, int tipo_id, string descripcion = null)
        {
            string query = "UPDATE transacciones SET fecha = @fecha, descripcion = @descripcion, motivo_id = @motivo, monto = @monto, metodo_id = @metodo, tipo_id = @tipo " +
                "WHERE id = @id;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@id", id);
                command.Parameters.AddWithValue("@fecha", fecha);
                command.Parameters.AddWithValue("@descripcion", descripcion);
                command.Parameters.AddWithValue("@motivo", mot_id);
                command.Parameters.AddWithValue("@monto", mont);
                command.Parameters.AddWithValue("@metodo", met_id);
                command.Parameters.AddWithValue("@tipo", tipo_id);
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error actualizando datos en la tabla Transacciones: " + ex.Message);
                }
            }
        }
        public void Add(DateTime fecha, int mot_id, decimal mont, int met_id, int tipo_id, string descripcion = null)
        {
            string query = "INSERT INTO transacciones (fecha, descripcion, motivo_id, monto, metodo_id, tipo_id) " +
                "VALUES (@fecha, @descripcion, @motivo, @monto, @metodo, @tipo);";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@fecha", fecha);
                command.Parameters.AddWithValue("@descripcion", descripcion);
                command.Parameters.AddWithValue("@motivo", mot_id);
                command.Parameters.AddWithValue("@monto", mont);
                command.Parameters.AddWithValue("@metodo", met_id);
                command.Parameters.AddWithValue("@tipo", tipo_id);
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error insertando datos en la tabla Transacciones: " + ex.Message);
                }
            }
        }
        public void Delete(int id)
        {
            string query = "DELETE FROM transacciones" +
                " WHERE id = @id;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", id);
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error eliminando datos de la tabla Transacciones: " + ex.Message);
                }
            }
        }
        public List<Motivo> GetMotivos()
        {
            string query = "SELECT id, nombre FROM motivo";
            List<Motivo> motivos = new List<Motivo>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Motivo Omotivo = new Motivo();
                        Omotivo.Id = reader.GetInt32(0);
                        Omotivo.Nombre = reader.GetString(1);

                        motivos.Add(Omotivo);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error obteniendo los datos de la tabla Motivo: " + ex.Message);
                }
            }
            return motivos;
        }
        public List<Balance> GetBalance()
        {
            string query = "SELECT monto, m.nombre as metodo, tp.nombre as tipo FROM transacciones as t " +
                "join metodo m on m.id = t.metodo_id " +
                "join tipo tp on tp.id = t.tipo_id";

            List<Balance> saldos = new List<Balance>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Balance OBalance = new Balance();
                        OBalance.Monto = reader.GetDecimal(0);
                        OBalance.Metodo = reader.GetString(1);
                        OBalance.Tipo = reader.GetString(2);

                        saldos.Add(OBalance);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error obteniendo los datos de la tabla Balance: " + ex.Message);
                }
            }
            return saldos;
        }
        public List <Transaccion> MasReciente()
        {
            string query = "SELECT t.id, t.fecha, t.descripcion, m.nombre as Motivo, t.monto, me.nombre as Metodo, tp.nombre FROM transacciones t " +
                "join motivo m on m.id = t.motivo_id " +
                "join metodo me on me.id = t.metodo_Id " +
                "join tipo tp on tp.id = t.tipo_id " +
                "ORDER BY fecha ASC;";

            List<Transaccion> transacciones = new List<Transaccion>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Transaccion Otransaccion = new Transaccion();
                        Otransaccion.Id = reader.GetInt32(0);
                        Otransaccion.Fecha = reader.GetDateTime(1);
                        Otransaccion.Descripcion = reader.GetString(2);
                        Otransaccion.Motivo = reader.GetString(3);
                        Otransaccion.Monto = reader.GetDecimal(4);
                        Otransaccion.Metodo = reader.GetString(5);
                        Otransaccion.Tipo = reader.GetString(6);

                        transacciones.Add(Otransaccion);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error obteniendo los datos de la tabla Transacciones: " + ex.Message);
                }
            }
            return transacciones;
        }
        public List<Transaccion> MasAntiguo()
        {
            string query = "SELECT t.id, t.fecha, t.descripcion, m.nombre as Motivo, t.monto, me.nombre as Metodo, tp.nombre FROM transacciones t " +
                "join motivo m on m.id = t.motivo_id " +
                "join metodo me on me.id = t.metodo_Id " +
                "join tipo tp on tp.id = t.tipo_id " +
                "ORDER BY fecha DESC;";

            List<Transaccion> transacciones = new List<Transaccion>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Transaccion Otransaccion = new Transaccion();
                        Otransaccion.Id = reader.GetInt32(0);
                        Otransaccion.Fecha = reader.GetDateTime(1);
                        Otransaccion.Descripcion = reader.GetString(2);
                        Otransaccion.Motivo = reader.GetString(3);
                        Otransaccion.Monto = reader.GetDecimal(4);
                        Otransaccion.Metodo = reader.GetString(5);
                        Otransaccion.Tipo = reader.GetString(6);

                        transacciones.Add(Otransaccion);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error obteniendo los datos de la tabla Transacciones: " + ex.Message);
                }
            }
            return transacciones;
        }
        public List<Transaccion> GetForPayMent(string metodo)
        {
            string query = "SELECT t.id, t.fecha, t.descripcion, m.nombre as Motivo, t.monto, me.nombre as Metodo, tp.nombre FROM transacciones t " +
                "join motivo m on m.id = t.motivo_id " +
                "join metodo me on me.id = t.metodo_Id " +
                "join tipo tp on tp.id = t.tipo_id " +
                "where me.nombre = @metodo";

            List<Transaccion> transacciones = new List<Transaccion>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@metodo", metodo);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Transaccion Otransaccion = new Transaccion();
                        Otransaccion.Id = reader.GetInt32(0);
                        Otransaccion.Fecha = reader.GetDateTime(1);
                        Otransaccion.Descripcion = reader.GetString(2);
                        Otransaccion.Motivo = reader.GetString(3);
                        Otransaccion.Monto = reader.GetDecimal(4);
                        Otransaccion.Metodo = reader.GetString(5);
                        Otransaccion.Tipo = reader.GetString(6);

                        transacciones.Add(Otransaccion);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error obteniendo los datos de la tabla Transacciones: " + ex.Message);
                }
            }
            return transacciones;
        }
    }
    class Transaccion
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Monto { get; set; }
        public string Descripcion { get; set; }
        public string Motivo { get; set; }
        public string Tipo { get; set; }
        public string Metodo { get; set; }
    }
    public class Motivo
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
    }
    public class Balance
    {
        public int Id { get; set; }
        public decimal Monto { get; set; }
        public string Metodo { get; set; }
        public string Tipo { get; set; }
    }
}
