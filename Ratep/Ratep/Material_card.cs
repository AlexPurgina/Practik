//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Ratep
{
    using System;
    using System.Collections.Generic;
    
    public partial class Material_card
    {
        public int Num_product { get; set; }
        public int Num_material { get; set; }
        public int Num_card { get; set; }
        public int Num_piece { get; set; }
        public double Consumption_rate { get; set; }
        public Nullable<int> Provider_workshop { get; set; }
        public Nullable<int> Consumer_workshop { get; set; }
    
        public virtual Material Material { get; set; }
        public virtual Nomencloture Nomencloture { get; set; }
        public virtual Work_piece Work_piece { get; set; }
        public virtual Workshop Workshop { get; set; }
        public virtual Workshop Workshop1 { get; set; }
    }
}
