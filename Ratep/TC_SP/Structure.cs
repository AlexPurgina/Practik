//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TC_SP
{
    using System;
    using System.Collections.Generic;
    
    public partial class Structure
    {
        public int Num_product_where { get; set; }
        public int Num_product_what { get; set; }
        public int Quantity_product { get; set; }
    
        public virtual Nomencloture Nomencloture { get; set; }
        public virtual Nomencloture Nomencloture1 { get; set; }
    }
}
