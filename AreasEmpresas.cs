using System;

public class AreasEmpresas
{
	public int idArea { get; set; }
	public string nombreArea { get; set; }
	public string responsableArea { get; set; }

	public AreasEmpresas() {


	}
	public AreasEmpresas(int idArea, string nombreArea, string responsableArea) {

		this.idArea = idArea;
		this.nombreArea = nombreArea;
		this.responsableArea = responsableArea;

	}

	// metodos 

	public virtual void mostrarAreas() {
		Console.WriteLine($"el id del area es: {idArea} el nombre es {nombreArea} el responsable es : {responsableArea}");
			}

    public virtual void reporteFinanciero()
    {
		Console.WriteLine("el siguiente es el reporte financiero (graficas)");

            }
    public virtual void informacionFinanciera()
    {
        Console.WriteLine("el siguiente es la informacion financiera");

    }
}


