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
    
    public partial class Material
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Material()
        {
            this.Material_card = new HashSet<Material_card>();
        }
    
        public int Num_material { get; set; }
        public string Name_material { get; set; }
        public int Code_unit { get; set; }
        public int Num_groups { get; set; }
        public double Diametr { get; set; }
        public double Thick { get; set; }
        public int Width { get; set; }
        public int Length { get; set; }
        public Nullable<int> Num_stamp { get; set; }
        public Nullable<int> Num_profile { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Material_card> Material_card { get; set; }
        public virtual Profile Profile { get; set; }
        public virtual Rationing_groups Rationing_groups { get; set; }
        public virtual Stamp Stamp { get; set; }
        public virtual OKEI OKEI { get; set; }
    }
}