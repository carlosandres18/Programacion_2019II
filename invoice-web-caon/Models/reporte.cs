using System;
using System.ComponentModel.DataAnnotations;

namespace invoice_web_caon.models{

    public class reporte{
        public int id {get;set;}
        public String cliente {get;set;}
        public String producto {get;set;}
        public String cantidad {get;set;}
        [DataType(DataType.Date)]
        public DateTime Date {get;set;}
        public int numero {get;set;}
        public int subTotal {get;set;}
        public double total {get;set;}
    }
}