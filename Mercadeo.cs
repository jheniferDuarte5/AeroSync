using System;

public class Mercadeo : AreasEmpresas // herencia
{
	public string lineaMercadeo { get; set; }

    public int totalMercadeo { get; set; }


    public Mercadeo() { 
    
    }

    public Mercadeo(string lineaMercadeo, int totalMercadeo)
    {
        this.lineaMercadeo = lineaMercadeo;
        this.totalMercadeo = totalMercadeo;
    }

    // metodos polimorficos

    public override void mostrarAreas()
    {
        base.mostrarAreas();
        Console.WriteLine($" la linea de mercado es : {lineaMercadeo} y el total de productos es : {totalMercadeo}");
    }
}
