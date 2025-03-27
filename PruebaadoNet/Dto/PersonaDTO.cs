namespace PruebaadoNet.Dto
{
    public class PersonaDTO
    {
        public string Cedula { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Ciudadania { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        public string EstadoCivil { get; set; }
        public string Profesion { get; set; }
        public string NivelEstudios { get; set; }
        public int? EsCliente { get; set; }
        public string TipoPersona { get; set; }
    }
}
