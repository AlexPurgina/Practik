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
    
    public partial class Card_work
    {
        public int Key_card { get; set; }
        public int Num_product { get; set; }
        public int Code_post { get; set; }
        public int Num_operation { get; set; }
        public int Order_operation { get; set; }
        public int Time_spent { get; set; }
    
        public virtual Nomencloture Nomencloture { get; set; }
        public virtual Operation Operation { get; set; }
        public virtual Post Post { get; set; }
    }
}
