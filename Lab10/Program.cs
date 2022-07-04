using System;
using System.Linq;

namespace Lab10
{
    class Program
    {
        static void Main(string[] args)
        {
            NorthwindDataContext context = new NorthwindDataContext();

            /*var query = from p in context.Products
                        select p;

            var query2 = from p in context.Products
                        where p.Categories.CategoryName == "Beverages"
                        select p;

            var query3 = from p in context.Products
                        where p.UnitPrice <20
                        select p;
            
            //tareas

            //1
            var query4 = from p in context.Products
                         where SqlMethods.Like(p.ProductName, "%Queso%")
                         select p;
            //2
            var query5 = from p in context.Products
                         where SqlMethods.Like(p.QuantityPerUnit, "%pkg%")
                         select p;
            //3
            var query6 = from p in context.Products
                         where SqlMethods.Like(p.ProductName, "A%")
                         select p;*/

            //Ingresar datos
            /*Products p = new Products();
            p.ProductName = "Peruvian Coffe";
            p.SupplierID = 20;
            p.CategoryID = 1;
            p.QuantityPerUnit = "10 pkgs";
            p.UnitPrice = 25;

            context.Products.InsertOnSubmit(p);
            context.SubmitChanges();

            Categories c = new Categories();
            c.CategoryName = "Clothes";
            c.Description = "T-Shirts, Shirts, pants";
            context.Categories.InsertOnSubmit(c);
            context.SubmitChanges();*/

            //Editar datos
            /*
            var product = (from p in context.Products
                           where p.ProductName == "Tofu"
                           select p).FirstOrDefault();

            product.UnitPrice = 100;
            product.UnitsInStock = 15;
            product.Discontinued = true;

            context.SubmitChanges()*/

            //Eliminar datos
            /*
            var product = (from p in context.Products
                           where p.ProductID == 78
                           select p).FirstOrDefault();

            context.Products.DeleteOnSubmit(product);
            context.SubmitChanges();*/

            /*var query7 = from p in context.Products
                         join s in context.Suppliers on p.SupplierID equals s.SupplierID
                         join c in context.Categories on p.CategoryID equals c.CategoryID
                         where c.CategoryName == "Dairy Products"
                         select new
                         {
                             ID = p.ProductID,
                             producto = p.ProductName,
                             proveedor = s.CompanyName,
                         };

            Console.WriteLine("actividad 1");
            foreach (var prod in query7)
            {
                Console.WriteLine("ID={0} \t Producto={1} \t Proveedor={2}",
                    prod.ID, prod.producto, prod.proveedor);

            }*/

            /*var query8 = from p in context.Products
                         join s in context.Suppliers on p.SupplierID equals s.SupplierID
                         where s.Country == "USA"
                         select new
                         {
                             ID = p.ProductID,
                             producto = p.ProductName,
                             proveedor = s.CompanyName,
                         };

            Console.WriteLine("actividad 1");
            foreach (var prod in query8)
            {
                Console.WriteLine("ID={0} \t Producto={1} \t Proveedor={2}",
                    prod.ID, prod.producto, prod.proveedor);

            }*/

            /*---Tarea 1---
            foreach (var prod in query4)
            {
                Console.WriteLine("ID={0} \t Name={1}",
                    prod.ProductID, prod.ProductName);
            }

            ---Tarea 2---
            foreach (var prod in query5)
            {
                Console.WriteLine("ID={0} \t Name={1} \t Presentacion={2}",
                    prod.ProductID, prod.ProductName, prod.QuantityPerUnit);
            }

            ---Tarea 3---
            foreach (var prod in query6)
            {
                Console.WriteLine("ID={0} \t Price={1} \t Name={2}",
                    prod.ProductID, prod.UnitPrice, prod.ProductName);
            }

            ---Ejercicio 1---
            foreach ( var prod in query)
            {
                Console.WriteLine("ID={0} \t Name={1}",
                    prod.ProductID, prod.ProductName);
            }

            ---Ejercicio 2---
            foreach (var prod in query2)
            {
                Console.WriteLine("ID={0} \t Name={1}", prod.ProductID, prod.ProductName);
            }

            ---Ejercicio 3---
            foreach (var prod in query3)
            {
                Console.WriteLine("ID={0} \t Price={1} \t Name={2}",
                    prod.ProductID, prod.UnitPrice, prod.ProductName);
            }*/
            Console.ReadKey();
        }
    }
}
