//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace AutoLotDataAccessLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class Order
    {
        public int OrderID { get; set; }
        public Nullable<int> CustID { get; set; }
        public Nullable<int> CarID { get; set; }
    
        public virtual Cutstomer Cutstomer { get; set; }
        public virtual Inventory Inventory { get; set; }
    }
}
