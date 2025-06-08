// UEA
//JUAN ZURITA 
// TAREA SEMANA 2 TIPOS DE DATOS PRIMITIVOS 
using System;

class AREA
{
    static void Main(string[] args)    /////// IMPRIMIMOS EN CONSOLA 
    {

        Console.WriteLine("el perimetro de un cuadrado de lado 10CM es " + perimetroCuadrado(10));
        Console.WriteLine("el área de un cuadrado de lado 10CM es " + areaCuadrado(10));
        Console.WriteLine();

        Console.WriteLine("el perimetro de un rectángulo de base 4CM y altura 6CM es " + perimetroRectangulo(4, 6));
        Console.WriteLine("el área de un rectángulo de base 4CM y altura 6CM es " + areaRectangulo(4, 6));
    }

    static double perimetroCuadrado(double lado)////// COLOCALMOS EL PERIMETRO DEL CUADRADO 
    {
        return lado + lado + lado + lado;
    }

    static double areaCuadrado(double lado)    /// CONSEGUIMOIS EL AREA
    {
        return lado * lado;
    }

    static double perimetroRectangulo(double baseR, double altura)    //CONSEGUIMOS EL PERIMETRO DEL RECTANGULO 
    {
        return 2 * (baseR + altura);
    }

    static double areaRectangulo(double baseR, double altura) //// CONSEGUIMOS LA BASE DEL 
    {
        return baseR * altura;
    }
}
