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
    
    public partial class Signin
    {
        public int ID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string IDRole { get; set; }
    
        public virtual Role Role { get; set; }
    }
}
