using MySql.Data.MySqlClient;

namespace dotnet_mysql_minimal_api
{
    public class DatabaseService
    {
        private readonly string _connectionString;

        public DatabaseService(string connectionString)
        {
            _connectionString = connectionString;
        }

        public List<Voluntario> ObterVoluntarios()
        {
            var voluntarios = new List<Voluntario>();

            using (var connection = new MySqlConnection(_connectionString))
            {
                connection.Open();
                string query = "select ID_Voluntario, Nome, CPF from Voluntario v";
                using (var command = new MySqlCommand(query, connection))
                {
                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        var voluntario = new Voluntario
                        {
                            Id = reader.GetInt32("ID_Voluntario"),
                            Nome = reader.GetString("Nome"),
                            CPF = reader.GetInt32("CPF")
                        };

                        voluntarios.Add(voluntario);
                    }
                }
            }

            return voluntarios;
        }
        public bool Login(LoginRequest payload)
        {
            bool result = false;

            using (var connection = new MySqlConnection(_connectionString))
            {
                connection.Open();
                string query = $"""
                    SELECT ID_Voluntario, Nome, CPF
                    FROM Voluntario v 
                    WHERE E_mail = '{payload.User}'
                    AND Senha = '{payload.Password}'
                """;

                using (var command = new MySqlCommand(query, connection))
                {
                    var reader = command.ExecuteReader();
                    result = reader.HasRows;
                }

                return result;
            }
        }
    }
}
