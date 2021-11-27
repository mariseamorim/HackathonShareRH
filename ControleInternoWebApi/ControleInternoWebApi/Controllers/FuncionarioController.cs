using ControleInternoDomain;
using ControleInternoService.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace ControleInternoApplication.Controllers
{

    [ApiController]
    public class FuncionarioController : ControllerBase
    {
        private readonly IFuncionarioService _service;

        public FuncionarioController(IFuncionarioService service)
        {
            this._service = service;
        }

        [HttpPost("funcionario/")]
        public async Task<IActionResult> CadastrarFuncionario([FromBody] Funcionario funcionario)
        {
            try
            {
                await _service.CadastrarFuncionario(funcionario);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet("funcionario/")]
        public async Task<IActionResult> ListarFuncionarios()
        {
            try
            {
                return Ok(await _service.ListarFuncionarios());
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
