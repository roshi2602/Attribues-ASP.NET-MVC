//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AttributesInMVC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Web.Mvc;

    //attributes in MVC
    //attributes are indicated by square brackets over class, methods, properties
  
    public class STUDENT       
    {
        [DisplayName("student name")]   //used as label to display on webpage
        [UIHint("open in new window")]   //specifies template use to display data field
        public string name { get; set; }
        [DisplayName("student age")]   //used as label to display on webpage
        [DataType(DataType.Text)]   // to set the type of data allowed in this property
        public int age { get; set; }
        [DisplayFormat(NullDisplayText ="gender not specified")]
        [DisplayName("student gender")]
        public string gender { get; set; }
        [HiddenInput(DisplayValue =false)]  //id should be hidden and not displayed on web page
        public int id { get; set; }
    }
   
}
