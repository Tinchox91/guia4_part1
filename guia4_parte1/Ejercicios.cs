using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guia4_parte1
{
    internal class Ejercicios
    {
        public void numerosCorrelativos()
        {
            int num, cont;
            cont = 0;
            num = -1;
            while (num < 0)
            {

                Console.Write("Ingrese un numero positivo: ");
                num = int.Parse(Console.ReadLine());
                if (num < 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Ah ingresado un numero negativo! ");
                    Console.ResetColor();
                }

            }
            while (cont < num)
            {
                cont++;
                if (cont < num)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(cont + "-");
                }
                else
                {
                    Console.WriteLine(cont);
                }

            }
            Console.ReadKey();
        }
        public void sumaValores()
        {
            int suma, cont;
            suma = 0;
            cont = 0;
            while (cont < 10)
            {
                Console.Write($"Ingrese el valor  {cont + 1}: ");
                suma += int.Parse(Console.ReadLine());
                cont++;
                if (cont == 10)
                {
                    Console.WriteLine("-------------------------");
                }
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"El valor total de la suma es: {suma}");
            Console.ReadKey();
        }
        public void perfiles()
        {
            int perfiles, cont, aptos;
            double longitud;
            perfiles = 0;
            cont = 0;
            aptos = 0;
            Console.Write("Ingrese la cantidad de perfiles: ");
            perfiles += int.Parse(Console.ReadLine());
            while (cont < perfiles)
            {
                Console.Write($"Ingrese la longitur del perfil {cont + 1}: ");
                longitud = double.Parse(Console.ReadLine());
                if (longitud < 1.30 && longitud > 1.20)
                {
                    aptos++;
                }
                cont++;
            }
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("***************************************");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"La cantidad de perfiles aptos son {aptos}");
            Console.ReadKey();
        }
        public void notas()
        {
            int notas, cont, aprobados, desaprobados;
            cont = 0;
            aprobados = 0;
            desaprobados = 0;
            while (cont < 10)
            {
                Console.Write($"*{cont + 1}* Ingrese nota del alumno: ");
                notas = int.Parse(Console.ReadLine());
                if (notas < 7)
                {
                    desaprobados++;
                }
                else if (notas >= 7)
                {
                    aprobados++;
                }
                notas = 0;
                cont++;
            }
            Console.ForegroundColor = (ConsoleColor)ConsoleColor.DarkGray;
            Console.WriteLine("**************************************");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Los Aprobados total son: {aprobados}");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Los Desaprobados total son: {desaprobados}");
            Console.ReadKey();
        }
        public void alturaPromedio()
        {
            int cont, cantidad;
            double altura, promedio;
            cont = 0;
            altura = 0;
            Console.Write("Ingrese el 'n' cantidad de promedios: ");
            cantidad = int.Parse(Console.ReadLine());
            while (cont < cantidad)
            {
                Console.Write("Ingrese altura: ");
                altura += double.Parse(Console.ReadLine());
                cont++;
            }
            promedio = altura / cantidad;
            Console.ForegroundColor = (ConsoleColor)ConsoleColor.Green;
            Console.WriteLine($"El promedio total de las {cantidad} personas es: {promedio} ");
            Console.ReadKey();
        }
        public void lecturaSueldos()
        {
            double sueldo, gasto, cantidad1, cantidad2;
            cantidad1 = 0;
            cantidad2 =0;
            int cont = 0;
            gasto = 0;
            int cantidad_de_sueldos;
            Boolean val = true;
            Console.ForegroundColor = (ConsoleColor)ConsoleColor.Cyan;
            Console.Write("Ingrese la cantidad de suledos: ");
            Console.ForegroundColor = (ConsoleColor)ConsoleColor.White;
            cantidad_de_sueldos = int.Parse(Console.ReadLine());
            while (cont < cantidad_de_sueldos)
            {
                cont++;
                Console.ForegroundColor= (ConsoleColor)ConsoleColor.Green;
                Console.Write("Ingrese el sueldo " + cont + " : ");
                Console.ForegroundColor = (ConsoleColor)ConsoleColor.White;
                sueldo = double.Parse(Console.ReadLine());
                val =true;
                if (sueldo > 500 || sueldo < 100)
                {
                    while (val)
                    {
                        if (sueldo > 500 || sueldo < 100)
                        {

                            Console.ForegroundColor= (ConsoleColor)ConsoleColor.Red;
                            Console.WriteLine("El monto debe ser menor a $500 y mayor a $100");
                            Console.WriteLine("Ingrese de nuevo");
                            Console.ForegroundColor = (ConsoleColor)ConsoleColor.White;
                            sueldo = double.Parse(Console.ReadLine());
                            val = true;

                        }
                        else
                        {
                            val = false;
                        }
                    }


                }
if (sueldo >= 100 && sueldo <= 300)
                {
                    cantidad1++;
                }else if (sueldo > 300)
                {
                    cantidad2++;
                }

                gasto += sueldo;
            }
            Console.WriteLine("El total de empleados que ganan entre $100 y 300 son: " + cantidad1);
            Console.WriteLine("El total de empleados que ganan mas de 300 son: " + cantidad2);
            Console.ForegroundColor = (ConsoleColor)ConsoleColor.Cyan;
            Console.WriteLine("El gasto total de la empresa en sueldos son $" + gasto);

            Console.ReadKey();
        }
        public void terminosDeLaSerie()
        {
            int num = 0;
            while (num<275) {
                num += 11;
                
                if (num == 275)
                {
                    Console.Write(num);
                }
                else
                {
                    Console.Write(num + "-");
                }
            }
            Console.ReadKey();
        }
        public void multiposDeOcho()
        {
            int num = 0;
            while (num < 500)
            {
                num += 8;

                if (num < 500 && num != 496)
                {
                    Console.Write(num + "-");
                    
                }
                else if (num == 496)
                {
                    Console.Write(num);
                }
            }

            Console.ReadKey();
        }
        public void listaValores()
        {
            int valor1= 0;
            int valor2= 0;
            int cont=0;
            Console.ForegroundColor= ConsoleColor.Magenta;
            Console.WriteLine("Lista numero 1");
            while (cont<15) {
                cont++;
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write("Ingrese el "+cont+" valor: ");
                Console.ForegroundColor = ConsoleColor.White;
                valor1 += int.Parse(Console.ReadLine());             

                            }
            cont = 0;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Lista numero 2");
            while (cont < 15)
            {
                cont++;
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("Ingrese el " + cont + " valor: ");
                Console.ForegroundColor = ConsoleColor.White;
                valor2 += int.Parse(Console.ReadLine());

            }
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            if (valor1>valor2) {
                Console.WriteLine("La lista con mayo valor es la lista 1 con un valor de "+valor1);
            }
            else
            {
                Console.WriteLine("La lista con mayo valor es la lista 2 con un valor de "+valor2);
            }

            Console.ReadKey();}
        public void numerosPares()
        {
            int cont,n,numero,pares,impares;
            cont = 0;
            pares = 0;
            impares = 0;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write("Ingrese la cantidad de numeros ");
            Console.ForegroundColor = ConsoleColor.White;
            n =int.Parse(Console.ReadLine());
            while (n>cont) {
                numero = 0;
                cont++;
                Console.Write("Ingrese el "+cont+" numero: ");
                numero = int.Parse(Console.ReadLine());
                if (numero%2==0) {
                    pares++;
                }else { impares++; }
            }
            Console.ForegroundColor= ConsoleColor.DarkCyan;
            Console.WriteLine("El total de pares son: "+pares);
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("El total de impares son: " + impares);
            Console.ReadKey();

        }








     
    }
}