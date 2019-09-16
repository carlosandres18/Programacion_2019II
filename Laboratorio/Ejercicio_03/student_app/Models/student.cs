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
        public Int credito {get;set;}
        public Double total {get;set;}
    }
}