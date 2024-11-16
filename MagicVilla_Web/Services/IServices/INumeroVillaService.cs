using MagicVilla_Web.Models.Dto;

namespace MagicVilla_Web.Services.IServices
{
    public interface INumeroVillaService
    {
        Task<T> ObtenerTodos<T>(string token);
        Task<T> Obtener<T>(int id, string token);
        Task<T> Crear<T>(NumeroVillaCreateDTO dto, string token);
        Task<T> Actualizar<T>(NumeroVillaUpdateDTO dto, string token);
        Task<T> Remover<T>(int id, string token);

    }
}
