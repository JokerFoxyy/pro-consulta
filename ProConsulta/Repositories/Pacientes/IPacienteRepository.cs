using ProConsulta.Models;

namespace ProConsulta.Repositories.Pacientes
{
    public interface IPacienteRepository
    {
        Task AddAsync(Paciente paciente);
        Task UpdateAsync(Paciente paciente);
        Task DeleteByIdAsync(int id);
        Task<List<Paciente>> GetAllAsync();
        Task<Paciente?> GetByIdAsync(int id);
        
    }
}
