using System;
using System.Numerics;

public class Finanzas : AreasEmpresas
{


	public double ingresosFinancieros { get; set; }

	public double egresosFinancieros { get; set; }

	public double utilidadMeta { get; set; }

	public DateTime fechaFinanza{ get; set; }
    public Finanzas()
	{

	}

    public Finanzas(double ingresosFinancieros, double egresosFinancieros, double utilidadMeta, DateTime fechaFinanza)
    {

		this.ingresosFinancieros = ingresosFinancieros;
		this.egresosFinancieros=egresosFinancieros;
		this.utilidadMeta = utilidadMeta;
		this.fechaFinanza = fechaFinanza;
    }

    // metodos polimorfismo 


    public override void mostrarAreas()
    {
        base.mostrarAreas();
        Console.WriteLine($"fecha {fechaFinanza: dd/MM/yyyy} ");
        Console.WriteLine($"los ingresos a la fecha son {ingresosFinancieros}");
        Console.WriteLine($"los egresos a la fecha son {egresosFinancieros}");
        Console.WriteLine($"la utilidad  a la fecha es {utilidadMeta}");
    }
    

    public override void reporteFinanciero()
    {
        base.reporteFinanciero();
    }

    public override void informacionFinanciera()
    {
        base.informacionFinanciera();
    }

}
