//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication6.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Assign
    {
        public int Assign_Id { get; set; }
        public int Request_Id { get; set; }
        public string Manager_Id { get; set; }
        public int Dept_Id { get; set; }
        public int Team_Id { get; set; }
        public string Emp_Id { get; set; }
    
        public virtual Dept Dept { get; set; }
        public virtual Request Request { get; set; }
        public virtual Team Team { get; set; }
    }
}
