
var repuestos = new List<string>()
 {
        "Filtro de aire",
        "Bujias",
        "Aceite de motor",
        "Pastillas de freno"

 };

var almacenRepuestos = new Almacen<string>();

foreach (var repuesto in repuestos)
{
    almacenRepuestos.Agregar(repuesto);
}


Console.WriteLine("Almacen de Repuestos...................................:\n");
almacenRepuestos.Mostrardatos();
var rateFilter = almacenRepuestos.ObtenerDatos(0);
Console.WriteLine($"Repuesto filtrado.......................:  {rateFilter}\n");

var Motos = new List<Moto>()
{
     new Moto{Marca = "Akt",Modelo = 2025,Nombre = "Nkd"},
     new Moto{Marca = "Akt",Modelo = 2026,Nombre = "Cr4 150"},
     new Moto{Marca = "Akt",Modelo = 2023,Nombre = "TTR 200"},
     new Moto{Marca = "Akt",Modelo = 2021,Nombre = "TTR 125"}
};
var Parqueadero = new Almacen<Moto>();

foreach (var moto in Motos)
{
 Parqueadero.Agregar(moto);
}

Console.WriteLine("Parqueadero de motos de motos.......................:");

Parqueadero.Mostrardatos();
var motoFiltrada = Parqueadero.ObtenerDatos(1);
Console.WriteLine($"Moto filtrada..: {motoFiltrada}\n");


public class  Almacen<T>
{
    List<T> _items = new List <T> ();

    public void Agregar(T item)
    {
        _items.Add(item);
    }
    public T ObtenerDatos(int index)
    {
        return _items[index];
    }

    public void Mostrardatos()
    {
        foreach (var item in _items)
        {
            Console.WriteLine($"Item......:\t{item,40}\n");

        }
    }

}

public class Moto
{
    public int Modelo { get; set; }
    public string Marca { get; set; } = null!;
    public string Nombre { get; set; } = null!;



    public override string ToString()
    {
            return $" Modelo: {Modelo}, Marca: {Marca}, Nombre: {Nombre}";
    }
}

