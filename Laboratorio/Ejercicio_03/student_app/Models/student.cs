using System;
using System.ComponentModel.DataAnnotations;

namespace student_app.models{
    public class student{
        public int id {get;set;}
        public String nombre {get;set;}
        public int age {get;set;}
        
        [DataType(DataType.Date)]
        public DateTime birth {get;set;}

        public String hobbie {get;set;}
        public String curso {get;set;}
        public int credito {get;set;}
        public int total {get;set;}
    }
}