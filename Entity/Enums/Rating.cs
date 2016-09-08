using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Enums
{
    public enum Rating
    {
        [Description("Muy Malo")] VERY_BAD,
        [Description("Malo")] BAD,
        [Description("Regular")] REGULAR,
        [Description("Bueno")] GOOD,
        [Description("Excelente")] EXCELLENT
    }
}
