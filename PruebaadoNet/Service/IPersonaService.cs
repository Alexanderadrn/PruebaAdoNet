using PruebaadoNet.Dto;

namespace PruebaadoNet.Service
{
    public interface IPersonaService
    {
        public Task<List<PersonaDTO>> ObtenerPersona();
    }
}
