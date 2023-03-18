
using ACTIVIDADSEMANA8.Models;



Console.WriteLine("Bienvenido ami programa");



AlmacenContext db = new AlmacenContext();
Producto producto = new Producto();

Console.WriteLine();

Console.Write("Ingresa el nombre del producto mi estimado: ");
producto.Nombre = Console.ReadLine();
Console.Write("Ingrese la descripción del producto: ");
producto.Descripción = Console.ReadLine();
Console.Write("Ingrese el presio de el producto: ");
producto.Precio = Convert.ToDecimal(Console.ReadLine());
Console.Write("Ingrese la cantidad de productos: ");
producto.Stock = Convert.ToInt32(Console.ReadLine());

db.Productos.Add(producto);
db.SaveChanges();

Console.WriteLine();

Console.WriteLine("             # # # # # # # # # # # # # # # # # # # # #                   ");
Console.WriteLine("             PRODUCTOS REGISTRADOS EN LA BASE DE DATOS                  ");
Console.WriteLine("             # # # # # # # # # # # # # # # # # # # # #                  ");

Console.WriteLine();

var LisProducto = db.Productos.ToList();
foreach (var usu in LisProducto)
{
    Console.WriteLine($"Id: {usu.Id}, NOMBRE: {usu.Nombre}, DESCRIPCION: {usu.Descripción}, PRECIO: {usu.Precio}, STOCK: {usu.Stock}");
}

Console.WriteLine();

Console.Write("FINALIZADO");

Console.WriteLine();

