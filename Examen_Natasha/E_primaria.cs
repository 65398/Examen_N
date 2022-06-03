using System;
class E_primaria:Estudiante
{
    int valor_fijo {get; set;}
 public E_primaria(int valor,string nombre, string apellido, string institucion, int cedula) base(nombre, apellido, institucion, cedula)
 {
     this.valor_fijo=valor;
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
        Console.WriteLine("Valor de matricula anual"+ valor_fijo);

    }
}

