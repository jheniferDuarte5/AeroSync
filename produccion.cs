using System;

public class produccion : AreasEmpresas
{
	public string lineaProduccion;
	public int totalProduccion;
	
	public produccion()
	{

	}
	public produccion(string lineaProduccion, int totalProduccion)
	{
		this.lineaProduccion = lineaProduccion;
		this.totalProduccion= totalProduccion;	

	}
    public override void mostrarAreas()
    {
        base.mostrarAreas();
		Console.WriteLine($"la linea de produccion es : {lineaProduccion} y el total de producto es {totalProduccion}");
    }
}
