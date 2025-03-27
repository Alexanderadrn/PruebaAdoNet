using Microsoft.Data.SqlClient;
using PruebaadoNet.Dto;
using PruebaadoNet.Models;

namespace PruebaadoNet.Service
{
    public class PersonaService : IPersonaService
    {
        private readonly string _connectionString ="";

        public PersonaService(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("cadenaSQL");
        }

        public async Task<List<PersonaDTO>> ObtenerPersona()
        {
            var listaPersonas = new List<PersonaDTO>();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                await connection.OpenAsync();
                string query = @"SELECT top 1000 Nombres, Apellidos, Cedula, Ciudadania, FechaNacimiento, 
                                    EstadoCivil, Profesion, NivelEstudios, EsCliente, TipoPersona 
                             FROM HCK_PERSONAS";

                using (SqlCommand command = new SqlCommand(query, connection))
                using (SqlDataReader reader = await command.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                    {
                        var persona = new PersonaDTO
                        {
                            Nombres = reader["Nombres"]?.ToString(),
                            Apellidos = reader["Apellidos"]?.ToString(),
                            Cedula = reader["Cedula"]?.ToString(),
                            Ciudadania = reader["Ciudadania"]?.ToString(),
                            FechaNacimiento = reader["FechaNacimiento"] != DBNull.Value
                                                ? Convert.ToDateTime(reader["FechaNacimiento"])
                                                : (DateTime?)null,
                            EstadoCivil = reader["EstadoCivil"]?.ToString(),
                            Profesion = reader["Profesion"]?.ToString(),
                            NivelEstudios = reader["NivelEstudios"]?.ToString(),
                            EsCliente = reader["EsCliente"] != DBNull.Value
                            ? Convert.ToInt32(reader["EsCliente"])
                            : 0,
                            TipoPersona = reader["TipoPersona"]?.ToString(),
                        };
                        listaPersonas.Add(persona);
                    }
                }
            }
            return listaPersonas;
        }
    }
}
