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
    
    public partial class Использование_материалов
    {
        public int ID_Использования { get; set; }
        public Nullable<int> ID_Здания { get; set; }
        public Nullable<int> ID_Материала { get; set; }
        public Nullable<int> Количество_использованных { get; set; }
    
        public virtual Здания Здания { get; set; }
        public virtual Материалы Материалы { get; set; }
    }
}
