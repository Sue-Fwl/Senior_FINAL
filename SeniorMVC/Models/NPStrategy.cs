//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SeniorMVC.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class NPStrategy
    {
        public int NPID { get; set; }
        public string Username { get; set; }
        public int StrategyId { get; set; }
    
        public virtual GFStrategy GFStrategy { get; set; }
        public virtual NashPointProfile NashPointProfile { get; set; }
    }
}