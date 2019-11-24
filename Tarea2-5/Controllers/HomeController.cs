using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tarea2_5.Models;

namespace Tarea2_5.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var Peliculas = new List<Pelicula>()
            {
                new Pelicula{Titulo="The GodFather",Director="Francis Ford Coppola",AutorPrincipal="Al pacino",numAutores=30,Duracion=2,Estreno=1994},
                new Pelicula{Titulo="The Shawshank",Director="Frank Darabont",AutorPrincipal="Morgan Freeman",numAutores=15,Duracion=3,Estreno=1972},
                new Pelicula{Titulo="The Matrix",Director="Lana Wachowski",AutorPrincipal="Keanu Reeves",numAutores=15,Duracion=2.30M,Estreno=1999},
                new Pelicula{Titulo="City od God",Director="Fernando Meirelles",AutorPrincipal="Alexandre Rodrigues",numAutores=10,Duracion=3,Estreno=2002},
                new Pelicula{Titulo="Star Wars: Episode IV",Director="George Lucas",AutorPrincipal="Harrison Ford",numAutores=20,Duracion=2.40M,Estreno=2007}

            };
            var resulPeliculas = from Pelicula in Peliculas where Pelicula.Titulo.Contains("The") select Pelicula;
            return View(Peliculas);
        }
        public ActionResult producto()
        {
            var Productos = new List<Producto>()
            {
                new Producto{Id =1, Descripcion="Boligrafo", Precio=8.35},
                new Producto{Id =2, Descripcion="Lapiz", Precio=5.00},
                new Producto{Id =3, Descripcion="Cuaderno Grande", Precio=35.00},
                new Producto{Id =4, Descripcion="Cuaderno Pequeño", Precio=28.35},
                new Producto{Id =5, Descripcion="Grapadora", Precio=15.35},
                new Producto{Id =6, Descripcion="Fordel", Precio=3.00},
                new Producto{Id =7, Descripcion="Lapicero", Precio=15.00},
                new Producto{Id =8, Descripcion="Borra pequeña", Precio=10.25},
                new Producto{Id =9, Descripcion="Borra grande", Precio=14.35},
                new Producto{Id =10, Descripcion="Saca punta", Precio=5.00},
            };
            var resulProducto = from Producto in Productos where Producto.Precio > 20.00 select Producto;
            return View(resulProducto);
        }

        
    }
}