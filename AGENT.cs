//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Demo_Student_DBConnection
{
    using System;
    using System.Collections.Generic;
    
    public partial class AGENT
    {
        public AGENT()
        {
            this.CUSTOMERs = new HashSet<CUSTOMER>();
        }
    
        public string AGENT_CODE { get; set; }
        public string AGENT_NAME { get; set; }
        public string WORKING_AREA { get; set; }
        public string COMMISSION { get; set; }
        public string PHONE_NO { get; set; }
        public string COUNTRY { get; set; }
    
        public virtual ICollection<CUSTOMER> CUSTOMERs { get; set; }
    }
}