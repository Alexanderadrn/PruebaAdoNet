using System.ComponentModel.DataAnnotations.Schema;

namespace PruebaadoNet.Models
{
    [Table("HCK_PERSONAS")]
    public class Persona
    {
        [Column("CEDULA")]
        public string Cedula { get; set; }

        [Column("NOMBRES")]
        public string Nombres { get; set; }

        [Column("APELLIDOS")]
        public string Apellidos { get; set; }

        [Column("CIUDADANIA")]
        public string Ciudadania { get; set; }

        [Column("FECHA_NACIMIENTO")]
        public DateTime FechaNacimiento { get; set; }

        [Column("ESTADO_CIVIL")]
        public string EstadoCivil { get; set; }

        [Column("PROFESION")]
        public string Profesion { get; set; }

        [Column("NIVEL_ESTUDIOS")]
        public string NivelEstudios { get; set; }

        [Column("ES_CLIENTE")]
        public int EsCliente { get; set; }

        [Column("TIPO_PERSONA")]
        public string TipoPersona { get; set; }
    }
}
