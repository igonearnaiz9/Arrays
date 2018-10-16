using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //Escribir el nombre al revés

            //string nombre = "igone";
            //char[] array = nombre.ToCharArray(); //inicio el array  y copia los caracteres del nombre y
            //                                    //nos asigna una letra a cada posición del array
            //// es un array de chars =char[]array= nombre.ToCharArray();
            //Array.Reverse(array);

            //Console.Write(array);// write para que me salga en una sola línea
            //Esto sólo funciona así si declaro el array como char

            //Console.ReadLine();

            //Crear un array de 10 ints.Asignar un valor a cada uno de las 10 posiciones.Mostrar los 10 valores en pantalla.

            //int[] valores = { 1, 2, 3, 5, 7, 11, 13, 17, 19, 23 };

            //for(int i=0; i<valores.Length;i++)// bucle que me recorre todos los valores paso a paso,si ponemos<= nos daría un error
            // porque empieza de 0(entonces serían 11 valores, no 10)
            //Console.Write(valores[i]+" "); // me coge todas las posiciones
            //Console.ReadLine();


            //Crear un array de 3 strings.Pedir al usuario 3 veces que escriba un string.
            //Guardar cada uno de esos strings en la posición 0 , 1 y 2.
            //Mostrar en pantalla en el orden: primero posición 1, después posición 2 y por último posicion 0.

            //string[] palabras = new string[3]; //iniciamos el array
            //Console.WriteLine("Escribe una palabra");
            //palabras[0] = Console.ReadLine(); // la primera posición será la respuesta a la primera pregunta
            //Console.WriteLine("Escribe otra palabra");
            //palabras[1] = Console.ReadLine();
            //Console.WriteLine("Escribe otra palabra");
            //palabras[2] = Console.ReadLine();

            //Console.Write(palabras[1]+" " + palabras[2]+" "+ palabras[0]);

            //Console.ReadLine();


            //Crear un array de 10 ints. Usar un for para asignar los valores de 20 a 11 a las 10 posiciones 
            //(en orden descendente). Usar un for para mostrar los 10 valores en pantalla.

            //int [] valores1 = new int[10];
            //int cuenta = 20;

            //for (int i = 0; i < valores1.Length; i++)// recorremos el array
            //{
            //    valores1[i] = cuenta; // las posiciones del array son cuenta( en este caso 20)
            //    cuenta--; //le voy restando a cuenta
            //    if (i != valores1.Length - 1)
            //    {
            //        Console.Write(valores1[i] + " , ");
            //    }
            //    else
            //    {
            //        Console.Write(valores1[i]); // de esta forma no nos sale una coma al final de la línea
            //    }
            //}

            //Console.ReadLine();



            //Crear un array de 3 ints. Usar un for para pedir al usuario que introduzca valores a cada una de las posiciones.
            //Usar otro for para mostrarlos en pantalla.


            //int[] valores2 = new int[3];


            //for (int i = 0; i < valores2.Length; i++)
            //{
            //    Console.WriteLine("Dame un número");
            //    valores2[i] = Convert.ToInt32(Console.ReadLine());

            //}
            //for(int i = 0; i < valores2.Length; i++)
            //{
            //        Console.Write(valores2[i] + " " );
            //}

            //  Console.ReadLine();


            // Crear un array de 3 ints. Usar un for para pedir al usuario que introduzca valores a cada una de las posiciones.
            // Mirar los valores del array una vez tenga los 3 valores y mostrar en pantalla el más grande.


            //int[] valores3 = new int[3];
            //int max=0;// esto implica que no puedo meter valores negativos para este caso

            //Si quiero el min le dare a min un valor muy grande

            //for (int i = 0; i < valores3.Length; i++)
            //{
            //    Console.WriteLine("Dame un número");
            //    valores3[i] = Convert.ToInt32(Console.ReadLine());
            //
            //
            //    if (max<valores3[i])      //if(min>valores3[i])
            //    {
            //        max = valores3[i];// como le he dado un valor a max, compara el primer valor que me encuentro con este max
            //                          // si es mayor, será el nuevo max, luego entra el segundo valor y vuelve a hacer la comparación
            //                           //y se queda de nuevo con el max de los 2
            //    }
            //}
            //  Console.WriteLine(max);

            // también hay una funcion valores3.Min() que te saca el valor min del array

            //  Console.ReadLine();



            //Poner los nombres de los meses en un array de 12. Cuando el usuario introduce un número del 1 al 12, 
            //mostrar el nombre de ese mes en pantalla.


            //string [] meses = { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" } ;

            //int mes;

            //    Console.WriteLine("Dame un número del 1 al 12");
            //    mes = Convert.ToInt32(Console.ReadLine());

            //while (mes <= 0 || mes > 12)
            //{
            //    Console.WriteLine("introduce un mes correcto");
            //    mes = Convert.ToInt32(Console.ReadLine());
            //}

            //Console.WriteLine(meses[mes - 1]);

            //Console.ReadLine();


            //Hacer la media de 10 valores utilizando un array.

            //int[] arraymedia = new int[10];

            //int suma=0;

            //for (int i = 0; i < arraymedia.Length; i++)
            //{
            //    Console.WriteLine("Dame un número");
            //    arraymedia[i] = Convert.ToInt32(Console.ReadLine());
            //    suma= suma+ arraymedia[i];// esto me va sumando las posiciones del array
            //}

            //Console.WriteLine(suma / arraymedia.Length);// de esta forma si cambia el numero de valores del array la peración es automática

            //Console.ReadLine();




            //Crear un array de 11 ints. Usar un for para asignar 0 a cada posición. (Para 0 no hace falta)
            //Pedir al usuario que introduzca valores entre 0 y 10.
            //Cada vez que introduzca un dígito, añadir uno al valor en esa posición del array. 
            //Si por ejemplo introduce un 3, sumar uno a la posición 3. Mostrar en pantalla los valores. 
            //Si introduce un número mayor que 10, decir que ese número es incorrecto. 
            //Si introduce un número negativo, mostrar en pantalla el número de cada posición y el valor que contiene. 
            //Por ejemplo, si introduce 7, 7, 7, 5, 6, 5, 9, 9, 10, -1 mostrar:
            //0   0
            //1   0
            //2   0
            //3   0
            //4   0
            //5   2
            //6   1
            //7   3
            //8   0
            //9   2
            //10  1

            //int[] array10 = new int[11];//en el caso de  que los valores sean 0 no hace falta hacer un for
            //                            //porque es el valor que coge por defecto
            //int peras;


            //for (int i = 0; i < array10.Length; i++)
            //{
            //    array10[i] = 0;
            //}

            //do // haz un bucle mientras se cumplan las siguientes condiciones:
            //{
            //   Console.WriteLine("Introduce peras del 0 al 10");// si introduzco 9
            //   peras = Convert.ToInt32(Console.ReadLine());
            //   if (peras >= 0 && peras <= 10)//cumple esta condición
            //   {
            //       array10[peras]++;//por lo que me suma 1 a cada valor del array
            //   }
            //   else if (peras > 10)// si introduzco 11
            //   {
            //       Console.WriteLine("Las peras son incorrectas");//vuelve a pedirme
            //   }
            //   else if (peras < 0)// si introduzco -1
            //   {
            //       for (int i = 0; i < array10.Length; i++)//muestra en pantalla
            //       {
            //           Console.Write(i + " " + array10[i] + "\n");
            //       }
            //   }

            //} while (peras >= 0) ;// 


            //Console.ReadLine();



            // Crear un array de 10 valores.Poner el valor 1 en cada una de la posición. 
            //Pedir al usuario que introduzca un número entre 0 y 9.Cada vez que introduzca un valor entre 0 y 9, 
            //mostrar el valor de esa posición del array, y modificarlo multiplicando por 2.


            //int[] array11 = new int[10];
            //int manzanas;

            //for (int i = 0; i < array11.Length; i++)
            //{
            //    array11[i] = 1;
            //}
            //Console.WriteLine("Introduce manzanas del 0 al 9");// tiene que ir antes de la condición
            //manzanas = Convert.ToInt32(Console.ReadLine());
            //if(manzanas>=0 &&manzanas<=9)
            //{
            //    Console.WriteLine(array11[manzanas]+" "+array11[manzanas] * 2);
            //}
            //Console.ReadLine();



            //Programa que lee las edades de 20 alumnos (validado entre 18 y 35), 
            //las almacena en un array y calcula y escribe su media (para probar, se pueden generar aleatoriamente entre 18 y 35). 


            int[] arrayedades = new int[4];
            int edad=0;
            double sumaedad = 0;

            for (int i = 0; i < arrayedades.Length; i++)
            {
                do
                {
                    Console.WriteLine("Introduce tu edad");
                    edad = Convert.ToInt32(Console.ReadLine());
                    if (edad >= 18 && edad <= 35)
                    {
                        arrayedades[i] = edad;
                        sumaedad = sumaedad + arrayedades[i];
                    }
                    else
                    {
                        Console.WriteLine("La edad no está en el rango");
                    }
                } while (edad < 18 || edad > 35);
            }

            Console.WriteLine("La media de edades es: "+ sumaedad / arrayedades.Length);
            Console.ReadLine();



            //David
            //int[] arrayedades = new int[4];
            //int edad;
            //double sumaedad=0;
            //bool primera;

            //for (int i = 0; i < arrayedades.Length; i++)
            //{
            //    edad = 0;
            //    primera = true;
            //    do
            //    {
            //        if (primera)
            //        {
            //            Console.WriteLine("Introduce tu edad para el elemento " + i.ToString());
            //        }
            //        else
            //        {
            //            Console.WriteLine("La edad no está en el rango, introduce de nuevo el elemento " + i.ToString());
            //        }
            //        edad = Convert.ToInt32(Console.ReadLine());
            //        if (edad < 18 || edad > 35)
            //        {
            //            primera = false;
            //        }
            //     } while (edad < 18 || edad > 35);

            //    arrayedades[i] = edad;

            //    sumaedad = sumaedad + arrayedades[i];       //sumaedad += arrayedades[i];

            //}
            //Console.WriteLine("La media de edades del array es " + (sumaedad / arrayedades.Length));

            //Console.ReadLine();

            {

            }
            


        }
    }
}
