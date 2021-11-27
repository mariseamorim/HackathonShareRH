using ControleInternoDomain;
using ControleInternoInfrastrutura.Contexto;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleInternoService.Services
{
        public class FuncionarioService : IFuncionarioService
        {
        private readonly DataContext _dbContext; 

        public FuncionarioService(DataContext dbContext)
        {
            this._dbContext = dbContext;
        }

 
        public async Task CadastrarFuncionario(Funcionario funcionario)
        {
            await _dbContext.Funcionarios.AddAsync(funcionario);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<List<Funcionario>> ListarFuncionarios()
        {
            return await _dbContext.Funcionarios.ToListAsync();
        }

        //public async Task AlterarFuncionario(double salario)
        //{
        //    var funDate = _dbContext.Funcionario.ToList().Find(_ => _.Salario.Equals(salario));
        //    funDate.Salario = salario;
        //    await _dbContext.Funcionarios.AlterarAsync(funcionario);
        //    await _dbContext.SaveChangesAsync();
        //}

    }
}