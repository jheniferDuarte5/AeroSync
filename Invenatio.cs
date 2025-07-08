using System;

public class Invenatio : AreasEmpresas
{
	public int totalStock { get; set; }
    public DateTime fechaInventario { get; set; }
    public string ubicacionStock { get; set; }

    public Invenatio()
	{

	}

    public Invenatio(int totalStock, DateTime fechaInventario, string ubicacionStock)
    {
		this.totalStock = totalStock;
		this.fechaInventario = fechaInventario;
		this.ubicacionStock = ubicacionStock;

    }
    public override void mostrarAreas()
    {
        base.mostrarAreas();
		Console.WriteLine($"el total de stock es : {totalStock}, la fecha del invemtario es : {fechaInventario: dd/MM/yyyy}, y su ubicacion es : {ubicacionStock}");
    }

}
