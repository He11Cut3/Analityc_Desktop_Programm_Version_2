//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Analytic
{
    using System;
    using System.Collections.Generic;
    
    public partial class Analytic_Stock_Main
    {
        public int Analytic_Stock_Main_id { get; set; }
        public Nullable<int> Analityc_Stock_id { get; set; }
        public Nullable<int> Analityc_Plan_id { get; set; }
        public Nullable<int> Analityc_Order_id { get; set; }
        public Nullable<int> Analityc_Finished_Products_id { get; set; }
    
        public virtual Analityc_Finished_Products Analityc_Finished_Products { get; set; }
        public virtual Analityc_Order Analityc_Order { get; set; }
        public virtual Analityc_Plan Analityc_Plan { get; set; }
        public virtual Analityc_Stock Analityc_Stock { get; set; }
    }
}
