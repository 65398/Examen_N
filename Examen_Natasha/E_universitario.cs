using System;
class E_universitario:Estudiante
{
    public int cantidad_creditos{set; get;}
    public int precio_credito{set; get;}

    public E_universitario(int credito,int precio_credito, string nombre, string apellido, string institucion, int cedula) base(nombre, apellido, institucion, cedula)
 {
     this.cantidad_credito=credito;
     this.precio_credito=precio_credito;
 }



     public void imprimir(){

        Console.WriteLine("Nombre:"+ nombre);
        Console.WriteLine("--------------");
        Console.WriteLine("Apellido:"+ apellido);
        Console.WriteLine("--------------");
        Console.WriteLine("Nombre de institucion"+ institucion);
        Console.WriteLine("--------------");
        Console.WriteLine("Cedula de identidad"+ cedula);
    }

    public void calcular(){
        int Resultado=0;
        Resultado=credito*precio_credito;
        Console.WriteLine("Valor de matricula anual es:"+ Resultado);

    }
}