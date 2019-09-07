using System;
using System.ComponentModel.DataAnnotations;

namespace multinacional_company.models{

    public class reporte{
        public int id {get;set;}
        public String producto {get;set;}
        public String categoria {get;set;}
        public String nacionalidad {get;set;}
        public String precio {get;set;}
        public Double precioT {get;set;}
    }
}