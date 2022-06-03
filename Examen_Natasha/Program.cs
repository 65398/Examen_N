using System;
namespace EXAMEN_NATASHA{
    class program{
        static void Main(string [] args){

            E_primaria primaria=new E_primaria (100, "Gema Monserrate", "Mero Zambrano", "12 de Octubre", 145678432);
            primaria imprimir();
            primaria calcular();

             E_secundaria secundaria=new E_secundaria (20, "Emely Nayeli", "Lopez Intriago", "Manta", 235635782);
            secundaria imprimir();
            secundaria calcular();

             E_universitario universitario=new E_universitario (7, "Lady Vanessa", "Tejena Macias", "Uleam", 145762954);
             universitario imprimir();
            universitario calcular();


        }

    }
}
