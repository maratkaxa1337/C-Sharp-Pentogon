//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace My_City_Car_Driver.Context
{
    using System;
    using System.Collections.Generic;
    
    public partial class Product
    {
        public int ID { get; set; }
        public int IDComputer { get; set; }
        public string IDCoutryManufacture { get; set; }
    
        public virtual Computer Computer { get; set; }
        public virtual CoutryManufacture CoutryManufacture { get; set; }
    }
}