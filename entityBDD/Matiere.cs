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
    
    public partial class Matiere
    {
        public Matiere()
        {
            this.Note = new HashSet<Note>();
        }
    
        public int numMatiere { get; set; }
        public Nullable<int> fknumModule { get; set; }
        public string nomMatiere { get; set; }
        public Nullable<int> nbNote { get; set; }
        public int poidsMatiere { get; set; }
    
        public virtual Module Module { get; set; }
        public virtual ICollection<Note> Note { get; set; }
    }
}