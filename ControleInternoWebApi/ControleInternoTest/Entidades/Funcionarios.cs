using ControleInternoDomain;
using NUnit.Framework;

namespace ControleInternoTest
{
    public class Tests
    {

        [Test]
        public void CadastrarFuncionarioComCargoValido()
        {
            var funcionario = new Funcionario("Maria", ControleInternoDomain.Enums.ECargos.Caixa);
            var cargo = ControleInternoDomain.Enums.ECargos.Caixa;
            Assert.AreEqual(funcionario.Cargos, cargo);
        }

        /*ToDo
        [Test]
        public void CadastrarFuncionarioComSucesso()
        {

            Assert.Pass();
        }*/
    }
}