//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FlightSearch.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class FLIGHT
    {
        public int FLIGHTID { get; set; }
        public Nullable<int> FLIGHTNUMBER { get; set; }
        public Nullable<int> AVAILABLESEATS { get; set; }
        public Nullable<int> AIRLINE { get; set; }
        public Nullable<decimal> PRICE { get; set; }
        public Nullable<int> ORIGIN { get; set; }
        public Nullable<int> DESTINATION { get; set; }
        public Nullable<System.DateTime> DEPRATUREDATE { get; set; }
        public Nullable<System.DateTime> ARRIVALDATE { get; set; }
        public string DURATION { get; set; }
    }
}
