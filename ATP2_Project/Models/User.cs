//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ATP2_Project.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class User
    {
        public int id { get; set; }
        public string User_Pass { get; set; }
        public string User_Type { get; set; }
        public string User_Permission { get; set; }
        public int Info_Id { get; set; }
    
        public virtual Information Information { get; set; }
    }
}
