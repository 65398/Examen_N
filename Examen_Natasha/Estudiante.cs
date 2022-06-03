using System;
class Estudiante{
     string nombre {set; get;}
     string apellido {set; get;}
     string nombre_institucion {set; get;}
     int cedula {set; get;}

    public Estudiante (string nombre, string apellido, string institucion, int cedula)
    {
        this.nombre=nombre;
        this.apellido=apellido;
        this.nombre_institucion=institucion;
        this.cedula=cedula;

    }

  


}