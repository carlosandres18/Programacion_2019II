using System;
using Microsoft.AspNetCore.Mvc;
using multinacional_company.models;

namespace multinacional_company.controller{
    public class HomeController:Controller{
        private readonly DatabaseContext _context;
        public HomeController(DatabaseContext context){
            _context=context;
        }
        public IActionResult Index(){
            Console.WriteLine("Index");
            return View();
        }
        public IActionResult Calculo(reporte reporte){
            Console.WriteLine("Calculo");

            double precio = double.Parse(reporte.precio);
            double precioT;

            if((reporte.nacionalidad)=="0.30"){
                if((reporte.categoria)=="0.05"){
                    precioT=precio*1.35;
                }else{
                    precioT=precio*1.33;
                }
            }else{
                if((reporte.categoria)=="0.05"){
                    precioT=precio*1.15;
                }else{
                    precioT=precio*1.13;
                }
            }

            reporte.precioT = precioT;

            _context.Add(reporte);
            _context.SaveChanges();

            return View(reporte);
        }
    }
}