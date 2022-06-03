using System;
class E_secundaria:Estudiante
{
public int nivel {set; get;}
public int precio_fijo {set; get;}

public E_secundaria(int nivel,int precio_fijo, string nombre, string apellido, string institucion, int cedula) base(nombre, apellido, institucion, cedula)
 {
     this.nivel=nivel;
     this.precio_fijo=precio_fijo;
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
        Resultado=nivel*precio_fijo;
        Console.WriteLine("Valor de matricula anual es:"+ Resultado);

    }
}
    
