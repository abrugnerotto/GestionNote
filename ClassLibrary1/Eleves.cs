//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace nsLibraryDB
{
    using System;
    using System.Collections.Generic;
    
    public partial class Eleves
    {
        public int numEleve { get; set; }
        public string nomEleve { get; set; }
        public string motDePasse { get; set; }
        public Nullable<int> fknumModule { get; set; }
    
        public virtual Modules Modules { get; set; }
    }
}
