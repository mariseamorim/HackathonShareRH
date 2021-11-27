using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleInternoDomain.Enums
{
    public enum ECargos
    {
        [Description("Gerente")]
        Gerente = 1,
        [Description("Caixa")]
        Caixa = 2,
        [Description("Cozinheiro")]
        Cozinheiro = 3,
        [Description("Serviços Gerais")]
        ServicosGerais = 4
    }
}
