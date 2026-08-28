// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class Program
{
    //procedimiento sumar o imprimir
    public static void ImprimirSuma(int a, int b){ // a, b son los parametros
         int suma = a + b;
         Console.WriteLine(suma);   
    }

    public static void MostrarPotenciaX(double num1, double potencia){
        double result = Math.Pow( num1, potencia);
        Console.WriteLine($"La potencia de {num1} elevado a {potencia} es: {result}");
    }

    static void ModificarValor(int n){
        n = n + 1;
        Console.WriteLine($"Dentro del metodo: {n}");
    }


    
    public static void Main(string[] args){
        int x = 12, y = 3;

        ImprimirSuma(y, x); //y, x (argumjentos actuales)
        ImprimirSuma(1000, -1); //1000, -1 (argumentos literales)
        MostrarPotenciaX(x,y);

        int edad = 18;
        Console.WriteLine($"Antes del metodo: {edad}");
        ModificarValor(edad);
        Console.WriteLine($"Despues de Metodo: {edad}");


}
