//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace entityBDD
{
    using System;
    using System.Collections.Generic;
    
    public partial class Notes
    {
        public int numNotes { get; set; }
        public Nullable<int> fknumMatiere { get; set; }
        public int note { get; set; }
        public int poidsNote { get; set; }
    
        public virtual Matieres Matieres { get; set; }
    }
}