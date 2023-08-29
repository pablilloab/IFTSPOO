//El precio de los productos no tiene incluido el incremento del 15% que representa la ganancia del negocio, por lo tanto,
//el algoritmo debe calcular el precio final a abonar por un cliente.
//Se ingresa el precio del producto y como resultado muestra el precio de venta.

//const int AUMENTO = 15;

//Console.WriteLine("Ingrese el precio del producto");
//float precio = float.Parse(Console.ReadLine());

//precio += (15 * precio) / 100;

//Console.WriteLine("El precio con aumento es " + precio);


//En el campeonato estudiantil llegan a la última etapa los participantes que superen los 80 puntos. 
//    El algoritmo pide el nombre de cada participante y la puntuación de los 3 jurados. 
//    Debe mostrar el nombre y el puntaje total de cada participante.        
//    Nota: cuando se ingrese "FIN" en el nombre del participante finaliza nuestro programa

//string nombre = "";
//float totalPuntos = 0;

//Console.WriteLine("Ingrese el nombre (fin para salir) ");
//nombre = Console.ReadLine();

//while (nombre != "fin")
//{
//    for (int i = 0; i < 3; i++)
//    {
//        Console.WriteLine("Ingrese la nota del jurado " + (i + 1));
//        totalPuntos += float.Parse(Console.ReadLine()); 
//    }

//    Console.WriteLine("El total de puntos para " + nombre + " es de " + totalPuntos);
//    Console.WriteLine("Ingrese el nombre (fin para salir) ");
//    nombre = Console.ReadLine();
//    totalPuntos = 0;

//}

//Modifica la salida de la resolución del punto 2. 
//Se pide mostrar un mensaje que indique si cada participante llegó a la última etapa o no.

//string nombre = "";
//float totalPuntos = 0;

//Console.WriteLine("Ingrese el nombre (fin para salir) ");
//nombre = Console.ReadLine();

//while (nombre != "fin")
//{
//    for (int i = 0; i < 3; i++)
//    {
//        Console.WriteLine("Ingrese la nota del jurado " + (i + 1));
//        totalPuntos += float.Parse(Console.ReadLine());
//    }

//    Console.WriteLine("El total de puntos para " + nombre + " es de " + totalPuntos);
//    if (totalPuntos < 80)
//    {
//        Console.WriteLine("Este participante no llego a la última etapa");
//    }
//    Console.WriteLine("Ingrese el nombre (fin para salir) ");
//    nombre = Console.ReadLine();
//    totalPuntos = 0;

//}

//Se trata de implementar un programa que sume los dígitos de un número entero no negativo de 4 dígitos. 
//Por ejemplo, la suma de los dígitos del 3433 es 13. 
//Para darle un poco más de emoción, el programa no se limitará a escribir el resultado de la suma,
//sino que también escribirá todos los sumandos utilizados: 3 + 4 + 3 + 3 = 13.
//Resolver la consiga del punto 4 con la particularidad que el número puede tener cualquier cantidad de dígitos, 
//es decir, puede ser un número de dos dígitos como un número de 6 dígitos. 
//Tomá la codificación anterior e introducí los cambios que sean necesarios.

//int numeroIngresado = 0;
//int resto = 0;
//int sumaDigitos = 0;

//Console.WriteLine("Ingrese un numero mayor q cero");
//numeroIngresado = int.Parse(Console.ReadLine());

//if (numeroIngresado < 0 )
//{
//    Console.WriteLine("Numero ingresado negativo, bye");
//}else
//{
//    resto = numeroIngresado % 10;
    
//    while (resto != 0)
//    {
//        Console.Write(resto + " + ");
//        sumaDigitos += resto;
//        numeroIngresado /= 10;
//        resto = (numeroIngresado % 10) ;        
//    }
//    Console.Write( " = " + sumaDigitos);

//}

