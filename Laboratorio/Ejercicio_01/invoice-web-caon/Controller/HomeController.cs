using System;
using Microsoft.AspNetCore.Mvc;
using invoice_web_caon.models;
using System.Linq;

namespace invoice_web_caon.controller{
    public class HomeController:Controller{
        private readonly DatabaseContext _context;
        public HomeController(DatabaseContext context){
            _context=context;
        }
        public IActionResult Index(){
            return View(_context.reportes.ToList());
        }
        public IActionResult Create(){
            Console.WriteLine("Create");
            return View();
        }
        public IActionResult Calculo(reporte reporte){
            Console.WriteLine("Calculo");

            Random rdn = new Random();
            int num = rdn.Next();
            reporte.numero = num;

            int precio = int.Parse(reporte.producto);
            int cantidad = int.Parse(reporte.cantidad);
            int sub = precio*cantidad;
            reporte.subTotal = sub;

            double total = sub*1.18;
            reporte.total = total;

            _context.Add(reporte);
            _context.SaveChanges();

            return View(reporte);
        }
    }
}