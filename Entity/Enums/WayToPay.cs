using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Enums
{
    public enum WayToPay
    {
        [Description("Tarjeta de Credito")] CREDIT_CARD,
        [Description("Efectivo")] CASH
    }
}
