//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Construction_Company
{
    using System;
    using System.Collections.Generic;
    
    public partial class Бригады
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Бригады()
        {
            this.Бригадиры = new HashSet<Бригадиры>();
            this.Рабочие = new HashSet<Рабочие>();
        }
    
        public int ID_Бригады { get; set; }
        public string Название_бригады { get; set; }
        public string Специализация { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Бригадиры> Бригадиры { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Рабочие> Рабочие { get; set; }
    }
}
