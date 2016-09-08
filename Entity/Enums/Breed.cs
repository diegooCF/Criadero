using System.ComponentModel;

namespace Entity.Enums
{
    //To get descripcion: string description = Enumerations.GetEnumDescription((Breed)value);
    public enum Breed
    {
        [Description("Caniche Toy")] CANICHE,
        [Description("Maltes")] MALTES,
        [Description("Bulldog Francés")] FRENCH_BULLDOG
    }
}
