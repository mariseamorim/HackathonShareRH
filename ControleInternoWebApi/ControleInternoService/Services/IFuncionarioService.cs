using ControleInternoDomain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ControleInternoService.Services
{
    public interface IFuncionarioService
    {
        Task CadastrarFuncionario(Funcionario funcionario);
      //  Task AlterarFuncionario(Funcionario funcionario);
        //Funcionario ListarFuncionarios();
        Task<List<Funcionario>> ListarFuncionarios();
    }

}
