using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace KlobasTransport.AppCode
{
    public static class DataManager
    {
        #region Public Metode - Insert, Update

        public static bool SpremiNovost(Novost novost)
        {
            string commandText = @"INSERT into [Novost] 
                                    (	
	                                    Naslov,
	                                    KratkiOpis,
	                                    DugiOpis,
	                                    Datum,
	                                    IdAdmin
                                    )
                                    values
                                    (
	                                    @Naslov,
	                                    @KratkiOpis,
	                                    @DugiOpis,
	                                    @Datum,
	                                    @IdAdmin
                                    )";

            using(SqlConnection konekcija = KreirajKonekciju())
            using (SqlCommand komanda = new SqlCommand())
            {
                komanda.CommandText = commandText;
                komanda.Connection = konekcija;

                komanda.Parameters.AddWithValue("@Naslov", novost.Naslov);
                komanda.Parameters.AddWithValue("@KratkiOpis", novost.KratkiOpis);
                komanda.Parameters.AddWithValue("@DugiOpis", novost.DugiOpis);
                komanda.Parameters.AddWithValue("@Datum", novost.Datum);
                komanda.Parameters.AddWithValue("@IdAdmin", novost.IdAdmin);

                komanda.Connection.Open();
                komanda.ExecuteNonQuery();

                komanda.Connection.Close();
            }
           
            return true;
        }

        public static bool IzmijeniNovost(Novost novost)
        {
            string commandText = @"UPDATE [Novost] 

                                    SET 
	                                    Naslov = @Naslov,
	                                    KratkiOpis = @KratkiOpis,
	                                    DugiOpis = @DugiOpis,
	                                    Datum = @Datum,
	                                    IdAdmin = @IdAdmin

                                    WHERE
	                                    Id = @Id";

            using (SqlConnection konekcija = KreirajKonekciju())
            using (SqlCommand komanda = new SqlCommand())
            {
                komanda.CommandText = commandText;
                komanda.Connection = konekcija;

                komanda.Parameters.AddWithValue("@Id", novost.Id);
                komanda.Parameters.AddWithValue("@Naslov", novost.Naslov);
                komanda.Parameters.AddWithValue("@KratkiOpis", novost.KratkiOpis);
                komanda.Parameters.AddWithValue("@DugiOpis", novost.DugiOpis);
                komanda.Parameters.AddWithValue("@Datum", novost.Datum);
                komanda.Parameters.AddWithValue("@IdAdmin", novost.IdAdmin);

                komanda.Connection.Open();
                komanda.ExecuteNonQuery();

                komanda.Connection.Close();
            }

            return true;
        }

        public static bool SpremiBaner(Banner baner)
        {
            string commandText = @"insert into [Baner] 
                                    (	
	                                    Naslov,
	                                    PutanjaSlike,
	                                    KratkiOpis,
	                                    Link,
	                                    IdAdmin
                                    )
                                    values
                                    (
	                                    @Naslov,
	                                    @PutanjaSlike,
	                                    @KratkiOpis,
	                                    @Link,
	                                    @IdAdmin
                                    )";

            using (SqlConnection konekcija = KreirajKonekciju())
            using (SqlCommand komanda = new SqlCommand())
            {
                komanda.CommandText = commandText;
                komanda.Connection = konekcija;

                komanda.Parameters.AddWithValue("@Naslov", baner.Naslov);
                komanda.Parameters.AddWithValue("@PutanjaSlike", baner.PutanjaSlike);
                komanda.Parameters.AddWithValue("@KratkiOpis", baner.KratkiOpis);
                komanda.Parameters.AddWithValue("@Link", baner.Link);
                komanda.Parameters.AddWithValue("@IdAdmin", baner.IdAdmin);

                komanda.Connection.Open();
                komanda.ExecuteNonQuery();
                komanda.Connection.Close();
            }

            return true;
        }

        public static bool IzmjeniBaner(Banner baner)
        {
            string commandText = @"UPDATE [Baner] 
                                    SET 
	                                    Naslov = @Naslov,
	                                    PutanjaSlike = @PutanjaSlike,
	                                    KratkiOpis = @KratkiOpis,
	                                    Link = @Link,
	                                    IdAdmin = @IdAdmin
                                  
                                    WHERE  Id = @Id";                            
	                                                                    

            using (SqlConnection konekcija = KreirajKonekciju())
            using (SqlCommand komanda = new SqlCommand())
            {
                komanda.CommandText = commandText;
                komanda.Connection = konekcija;

                komanda.Parameters.AddWithValue("@Id", baner.Id);
                komanda.Parameters.AddWithValue("@Naslov", baner.Naslov);
                komanda.Parameters.AddWithValue("@PutanjaSlike", baner.PutanjaSlike);
                komanda.Parameters.AddWithValue("@KratkiOpis", baner.KratkiOpis);
                komanda.Parameters.AddWithValue("@Link", baner.Link);
                komanda.Parameters.AddWithValue("@IdAdmin", baner.IdAdmin);

                komanda.Connection.Open();
                komanda.ExecuteNonQuery();
                komanda.Connection.Close();
            }

            return true;
        }
        
        public static bool SpremiAdmina(Admin admin)
        {
            string commandText = @"insert into [Admin] 
                                            (	
        	                                    Ime,
        	                                    Prezime,
        	                                    KorisnickoIme,
        	                                    Lozinka
        	                                    
                                            )
                                            values
                                            (
        	                                    @Ime,
        	                                    @Prezime,
        	                                    @KorisnickoIme,
        	                                    @Lozinka
    	                                    
                                            )";

                using (SqlConnection konekcija = KreirajKonekciju())
                using (SqlCommand komanda = new SqlCommand())
                {
                    komanda.CommandText = commandText;
                    komanda.Connection = konekcija;

                    komanda.Parameters.AddWithValue("@Ime", admin.Ime);
                    komanda.Parameters.AddWithValue("@Prezime", admin.Prezime);
                    komanda.Parameters.AddWithValue("@KorisnickoIme", admin.KorisnickoIme);
                    komanda.Parameters.AddWithValue("@Lozinka", admin.Lozinka);

                    komanda.Connection.Open();
                    komanda.ExecuteNonQuery();
                    komanda.Connection.Close();

                }

                return true;
        }

        public static bool IzmjeniAdmina(Admin admin)
        {
            string commandText = @"UPDATE [Admin] 
                                       SET    	
        	                                    Ime = @Ime,
        	                                    Prezime = @Prezime,
        	                                    KorisnickoIme = @KorisnickoIme,
        	                                    Lozinka = @Lozinka
        	                                    
                                       WHERE
                                               Id = @Id";

            using (SqlConnection konekcija = KreirajKonekciju())
            using (SqlCommand komanda = new SqlCommand())
            {
                komanda.CommandText = commandText;
                komanda.Connection = konekcija;

                komanda.Parameters.AddWithValue("@Id", admin.Id);
                komanda.Parameters.AddWithValue("@Ime", admin.Ime);
                komanda.Parameters.AddWithValue("@Prezime", admin.Prezime);
                komanda.Parameters.AddWithValue("@KorisnickoIme", admin.KorisnickoIme);
                komanda.Parameters.AddWithValue("@Lozinka", admin.Lozinka);

                komanda.Connection.Open();
                komanda.ExecuteNonQuery();
                komanda.Connection.Close();

            }

            return true;
        }


        #endregion

        #region Public Metode - Select

        public static DataTable GetAllBanners()
        {
            DataTable baneri = null;

            string sqlQuery = @"SELECT * FROM [Baner]";

            using (SqlConnection konekcija = KreirajKonekciju())
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlQuery, konekcija);

                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet, "Baneri");  // Baneri kao dataTable unutar dataASet-a

                baneri = dataSet.Tables["Baneri"];

                konekcija.Close(); 
            }

            return baneri;
        }

        public static DataTable GetAllNews() 
        {
            DataTable novosti = null;

            string sqlQuery = @"SELECT *  FROM [Novost]
                                order by Id desc ";

            using (SqlConnection konekcija = KreirajKonekciju())
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlQuery, konekcija);
                DataSet dataSet = new DataSet();  
                dataAdapter.Fill(dataSet, "Novosti");  

                novosti = dataSet.Tables ["Novosti"];

                konekcija.Close();
            }

            return novosti;
        }

        public static DataTable GetAllAdmins()
        {
            DataTable admini = null;

            string sqlQuery = @"SELECT * FROM [Admin]";

            using (SqlConnection konekcija = KreirajKonekciju())
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlQuery, konekcija);
                DataSet dataSet = new DataSet();

                dataAdapter.Fill(dataSet, "Admini");
                admini = dataSet.Tables["Admini"];

                konekcija.Close();

            }

            return admini;
        }

        

        #endregion

        #region Public Metode - Delete

        public static bool DeleteAdmin(int id)
        {
            bool success = false;

            try
            {
                string commandText = @" delete from [Admin] 
                                   where Id = @Id";

                using (SqlConnection konekcija = KreirajKonekciju())
                using (SqlCommand komanda = new SqlCommand())
                {
                    komanda.CommandText = commandText;
                    komanda.Connection = konekcija;

                    komanda.Parameters.AddWithValue("@Id", id);

                    komanda.Connection.Open();
                    komanda.ExecuteNonQuery();
                    komanda.Connection.Close();
                }

                success = true;

            }
            catch
            {
                success = false;            
            }
                     

            return success;
        }

        public static bool DeleteBaner(int id)
        {
            string commandText = @" delete from [Baner] 
                                   where Id = @Id";

            using (SqlConnection konekcija = KreirajKonekciju())
            using (SqlCommand komanda = new SqlCommand())
            {
                komanda.CommandText = commandText;
                komanda.Connection = konekcija;

                komanda.Parameters.AddWithValue("@Id", id);

                komanda.Connection.Open();
                komanda.ExecuteNonQuery();
                komanda.Connection.Close();
            }

            return true;
        }

        public static bool DeleteNovost(int id)
        {
            string commandText = @" delete from [Novost] 
                                   where Id = @Id";

            using (SqlConnection konekcija = KreirajKonekciju())
            using (SqlCommand komanda = new SqlCommand())
            {
                komanda.CommandText = commandText;
                komanda.Connection = konekcija;

                komanda.Parameters.AddWithValue("@Id", id);

                komanda.Connection.Open();
                komanda.ExecuteNonQuery();
                komanda.Connection.Close();
            }

            return true;
        }
        #endregion

        #region Public Metode - Frontend

        public static List<Banner> UcitajSveBanere() 
        {
            List<Banner> baneri = new List<Banner>();

            string sqlQuery = @"SELECT * FROM [Baner]";

            using (SqlConnection conection = KreirajKonekciju())
            using (SqlCommand command = new SqlCommand(sqlQuery, conection))
            {
                // 1. otvoriti konekciju
                command.Connection.Open();

                // 2. instancirati data reader koji cita podatke iz baze
                using (SqlDataReader dataReader = command.ExecuteReader())
                {

                    // 3. provjera da li je baza vratila ikakve podatke
                    if (dataReader.HasRows)
                    {
                        while (dataReader.Read())
                        {
                            Banner banner = new Banner();

                            banner.Id = Convert.ToInt32(dataReader["Id"]);
                            banner.IdAdmin = Convert.ToInt32(dataReader["IdAdmin"]);
                            banner.KratkiOpis = Convert.ToString(dataReader["KratkiOpis"]);
                            banner.Link = Convert.ToString(dataReader["Link"]);
                            banner.Naslov = Convert.ToString(dataReader["Naslov"]);
                            banner.PutanjaSlike = Convert.ToString(dataReader["PutanjaSlike"]);

                            baneri.Add(banner);
                        }
                    }
                }


                conection.Close();

            }

            return baneri;
        }

        public static Banner UcitajBaner(int Id)
        {
            Banner rezultat = null;

            string sqlQuery = @"SELECT * FROM [Baner]
                                    where Id = @Id";

            using (SqlConnection conection = KreirajKonekciju())
            using (SqlCommand command = new SqlCommand(sqlQuery, conection))
            {               
                command.Parameters.AddWithValue("@Id", Id);
              
                command.Connection.Open();
                using (SqlDataReader dataReader = command.ExecuteReader())
                {                   
                    if (dataReader.HasRows)
                    {
                        if (dataReader.Read())
                        {
                             rezultat= new Banner();

                             rezultat.Id = Convert.ToInt32(dataReader["Id"]);
                             rezultat.IdAdmin = Convert.ToInt32(dataReader["IdAdmin"]);
                             rezultat.KratkiOpis = Convert.ToString(dataReader["KratkiOpis"]);
                             rezultat.Link = Convert.ToString(dataReader["Link"]);
                             rezultat.Naslov = Convert.ToString(dataReader["Naslov"]);
                             rezultat.PutanjaSlike = Convert.ToString(dataReader["PutanjaSlike"]);

                        }
                    }
                }                
                conection.Close();
            }

            return rezultat;
        }
         
        public static List<Novost> UcitajZadnjeTriNovosti()
        {
            List<Novost> novosti = new List<Novost>();

            string sqlQuery = @"select top(3) * from Novost
                                order by Datum desc";

            using (SqlConnection conection = KreirajKonekciju())
            using (SqlCommand command = new SqlCommand(sqlQuery, conection))
            {
                // 1. otvoriti konekciju
                command.Connection.Open();

                // 2. instancirati data reader koji cita podatke iz baze
                using (SqlDataReader dataReader = command.ExecuteReader())
                {

                    // 3. provjera da li je baza vratila ikakve podatke
                    if (dataReader.HasRows)
                    {
                        while (dataReader.Read())
                        {
                            Novost novost = new Novost();

                            novost.Id = Convert.ToInt32(dataReader["Id"]);
                            novost.IdAdmin = Convert.ToInt32(dataReader["IdAdmin"]);
                            novost.Datum = Convert.ToDateTime(dataReader["Datum"]);
                            novost.Naslov = Convert.ToString(dataReader["Naslov"]);
                            novost.KratkiOpis= Convert.ToString(dataReader["KratkiOpis"]);
                            novost.DugiOpis = Convert.ToString(dataReader["DugiOpis"]);

                            novosti.Add(novost);
                        }
                    }
                }

                conection.Close();
            }

            return novosti;
        }

        public static List<Novost> UcitajSveNovosti()
        {
            List<Novost> novosti = new List<Novost>();

            string sqlQuery = @"select  * from Novost
                                order by Datum desc";

            using (SqlConnection conection = KreirajKonekciju())
            using (SqlCommand command = new SqlCommand(sqlQuery, conection))
            {
                // 1. otvoriti konekciju
                command.Connection.Open();

                // 2. instancirati data reader koji cita podatke iz baze
                using (SqlDataReader dataReader = command.ExecuteReader())
                {

                    // 3. provjera da li je baza vratila ikakve podatke
                    if (dataReader.HasRows)
                    {
                        while (dataReader.Read())
                        {
                            Novost novost = new Novost();

                            novost.Id = Convert.ToInt32(dataReader["Id"]);
                            novost.IdAdmin = Convert.ToInt32(dataReader["IdAdmin"]);
                            novost.Datum = Convert.ToDateTime(dataReader["Datum"]);
                            novost.Naslov = Convert.ToString(dataReader["Naslov"]);
                            novost.KratkiOpis = Convert.ToString(dataReader["KratkiOpis"]);
                            novost.DugiOpis = Convert.ToString(dataReader["DugiOpis"]);

                            novosti.Add(novost);
                        }
                    }
                }

                conection.Close();
            }

            return novosti;
        }

        public static List<Novost> PretraziNovosti(string searchPhrase)
        {
            List<Novost> novosti = new List<Novost>();

            string sqlQuery = @"SELECT  * FROM Novost
                                WHERE Naslov LIKE '%'+@SearchPhrase+'%' OR KratkiOpis LIKE '%'+@SearchPhrase+'%'
                                ORDER BY Datum DESC";

            using (SqlConnection conection = KreirajKonekciju())
            using (SqlCommand command = new SqlCommand(sqlQuery, conection))
            {
                command.Parameters.AddWithValue("@SearchPhrase", searchPhrase);

                // 1. otvoriti konekciju
                command.Connection.Open();
                
                // 2. instancirati data reader koji cita podatke iz baze
                using (SqlDataReader dataReader = command.ExecuteReader())
                {

                    // 3. provjera da li je baza vratila ikakve podatke
                    if (dataReader.HasRows)
                    {
                        while (dataReader.Read())
                        {
                            Novost novost = new Novost();

                            novost.Id = Convert.ToInt32(dataReader["Id"]);
                            novost.IdAdmin = Convert.ToInt32(dataReader["IdAdmin"]);
                            novost.Datum = Convert.ToDateTime(dataReader["Datum"]);
                            novost.Naslov = Convert.ToString(dataReader["Naslov"]);
                            novost.KratkiOpis = Convert.ToString(dataReader["KratkiOpis"]);
                            novost.DugiOpis = Convert.ToString(dataReader["DugiOpis"]);

                            novosti.Add(novost);
                        }
                    }
                }

                conection.Close();
            }

            return novosti;
        }

        public static Novost UcitajNovost(int Id)
        {
            Novost rezultat = null;

            string sqlQuery = @" select * from Novost
                                    where Id = @Id";

            using (SqlConnection conection = KreirajKonekciju())
            using (SqlCommand command = new SqlCommand(sqlQuery, conection))
            {
                command.Parameters.AddWithValue("@Id", Id);
                // 1. otvoriti konekciju
                command.Connection.Open();

                // 2. instancirati data reader koji cita podatke iz baze
                using (SqlDataReader dataReader = command.ExecuteReader())
                {
                    // 3. provjera da li je baza vratila ikakve podatke
                    if (dataReader.HasRows)
                    {
                        if (dataReader.Read())
                        {
                            rezultat = new Novost();

                            rezultat.Id = Convert.ToInt32(dataReader["Id"]);
                            rezultat.IdAdmin = Convert.ToInt32(dataReader["IdAdmin"]);
                            rezultat.Datum = Convert.ToDateTime(dataReader["Datum"]);
                            rezultat.Naslov = Convert.ToString(dataReader["Naslov"]);
                            rezultat.KratkiOpis = Convert.ToString(dataReader["KratkiOpis"]);
                            rezultat.DugiOpis = Convert.ToString(dataReader["DugiOpis"]);
                            
                        }
                    }
                }

                conection.Close();
            }
            return rezultat;
        }

        public static Admin UcitajAdmina(string korisnickoIme)
        {
            Admin rezultat = null;

            string sqlQuery = @"select * from [Admin]
                            where KorisnickoIme = @KorisnickoIme";

            using (SqlConnection konekcija = KreirajKonekciju())
            using (SqlConnection conection = KreirajKonekciju())
            using (SqlCommand command = new SqlCommand(sqlQuery, conection))
            {
                command.Parameters.AddWithValue("@KorisnickoIme", korisnickoIme);

                // 1. otvoriti konekciju
                command.Connection.Open();

                // 2. instancirati data reader koji cita podatke iz baze
                using (SqlDataReader dataReader = command.ExecuteReader())
                {
                    // 3. provjera da li je baza vratila ikakve podatke
                    if (dataReader.HasRows)
                    {
                        if (dataReader.Read())
                        {
                            rezultat = new Admin();

                            rezultat.Id = Convert.ToInt32(dataReader["Id"]);
                            rezultat.Ime = Convert.ToString(dataReader["Ime"]);
                            rezultat.Prezime = Convert.ToString(dataReader["Prezime"]);
                            rezultat.KorisnickoIme = Convert.ToString(dataReader["KorisnickoIme"]);
                            rezultat.Lozinka = Convert.ToString(dataReader["Lozinka"]);

                        }
                    }
                }

                conection.Close();
            }
                        
            return rezultat;
        }

        public static Admin UcitajAdmina(int Id)
        {
            Admin rezultat = null;

            string sqlQuery = @"SELECT * FROM [Admin]
                                    where Id = @Id";

            using (SqlConnection conection = KreirajKonekciju())
            using (SqlCommand command = new SqlCommand(sqlQuery, conection))
            {
                command.Parameters.AddWithValue("@Id", Id);

                command.Connection.Open();
                using (SqlDataReader dataReader = command.ExecuteReader())
                {
                    if (dataReader.HasRows)
                    {
                        if (dataReader.Read())
                        {
                            rezultat = new Admin();

                            rezultat.Id = Convert.ToInt32(dataReader["Id"]);
                            rezultat.Ime = Convert.ToString(dataReader["Ime"]);
                            rezultat.Prezime = Convert.ToString(dataReader["Prezime"]);
                            rezultat.KorisnickoIme = Convert.ToString(dataReader["KorisnickoIme"]);
                            rezultat.Lozinka = Convert.ToString(dataReader["Lozinka"]);

                        }
                    }
                }
                conection.Close();
            }

            return rezultat;
        }
        
        #endregion


        #region Private Metode

        private static string UcitajConnectionString()
        {
            // WebConfigurationManager klasa služi za čitanje konfiguracijskih postavki koje se definiraju u web.config-u

            string connectionString = WebConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

            return connectionString;
        }

        private static SqlConnection KreirajKonekciju()
        {
            string connectionString = UcitajConnectionString();

            SqlConnection connection = new SqlConnection(connectionString);

            return connection;
        }

        #endregion
    }
}