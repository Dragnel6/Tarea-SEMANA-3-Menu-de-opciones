usando el  sistema ;

espacio de nombres  semana3_estructuras_de_control
{
     programa de clase
    {
        static void Main(cadena[] argumentos)
{

    principal();

}

principal vacío  estático ()
        {
    int repetir_menu;
    Sistema.Consola.WriteLine(" \ n Estructuras de control en Visual C # ");
    Sistema.Consola.WriteLine(" 1. Menú de opciones ");
    Sistema.Consola.WriteLine(" 2. Salir ");

    Sistema.Consola.WriteLine(" Ingrese 1 para mostrar menú o 2 para salir. ");
    repetir_menu = Int32.Analizar(Consola.ReadLine());

    while (repetir_menu == 1)
    {
        opciones();
    }


}


opciones de vacío  estático ()
        {

    int opcion;

    Sistema.Consola.WriteLine(" \ n Ejemplos de estructuras de control ");
    Sistema.Consola.WriteLine(" 1- Mostrar los requisitos para instalar versiones de Windows ");
    Sistema.Consola.WriteLine(" 2- Mostrar programa de incio de sesion ");
    Sistema.Consola.WriteLine(" 3- Mostrar programa de calculadora ");
    Sistema.Consola.WriteLine(" 4- Mostrar programa de cálculo promedio ");

    Sistema.Consola.WriteLine(" Ingrese la opción: ");
    opcion = Int32.Analizar(Consola.ReadLine());

    interruptor(opcion)
            {
        caso  1 :
                    programa1();
        romper;
        caso  2 :
                    programa2();
        romper;
        caso  3 :
                    programa3();
        romper;
        caso  4 :
                    programa4();
        romper;
        por defecto :
                    Sistema.Consola.WriteLine(" Opción equivocada ");
        romper;
    }
    // System.Console.ReadKey ();
    principal();

}

programa1 vacío  estático ()
        {
    Sistema.Consola.WriteLine(" \ n Versiones de Windows ");
    Sistema.Consola.WriteLine(" Windows 7 ");
    Sistema.Consola.WriteLine(" Procesador de 1 gigahercio ghz " +
                             " o más rápido de 32 bits x86 o de 64 bits x64 " +
                             " 1 GB de RAM 32 bits o 2 GB de RAM x64 " +
                             " 16 GB de espacio disponible en el disco duro x32 bits 20 GB x64 bits " +
                             " Tarjeta gráfica DirectX 9 con controlador WDDM 1.0 o superior. ");
    Sistema.Consola.WriteLine(" Windows 8 ");
    Sistema.Consola.WriteLine(" Procesador Intel® Celeron® 847, 1,10 GHz o superior " +
        " Tarjeta gráfica: Dispositivo gráfico Directx 9 con controlador WDDM de 1.0 o mayor. " +
        " Procesador de 1GHz o de mayor velocidad " +
        " Tarjeta gráfica: Dispositivo gráfico Directx 9 con controlador WDDM de 1.0 o mayor. " +
        " Memoria RAM: 1 GB (32 bits) o 2 GB (64 bits) " +
        " Espacio de disco duro: 16GB (32 bits) o 20GB (64 bits) ");
    Sistema.Consola.WriteLine(" Windows 10 ");
    Sistema.Consola.WriteLine(" Procesador a 1 GHz o más rápido o sistema en un chip (SoC) " +
        " 1 GB para 32 bits o 2 GB para 64 bits " +
        " 16 GB para SO de 32 bits; 32 GB para SO de 64 bits " +
        " DirectX 9 o posterior con controlador WDDM 1.0 " +
        " Resolucio 800x600 ");
    Sistema.Consola.WriteLine(" Windows 11 ");
    Sistema.Consola.WriteLine(" Procesador: 1 giga Hertz (GHz) o más rápido con 2 o más núcleos en un procesador de 64 bits compatible o sistema en un chip (SoC) " +
        " RAM: 4 gigabytes (GB) " +
        " Almacenamiento: Dispositivo de almacenamiento de 64 GB o más " +
        " Tarjeta gráfica: Compatible con DirectX 12 o posterior con controlador WDDM 2.0 " +
        " Pantalla: Pantalla de alta definición (720p) de más de 9 ″ en diagonal, con canal de 8 bits por color ");



}

programa2 vacío  estático ()
        {
    Sistema.Consola.WriteLine(" \ n Programa de inicio de sesión ");
    // programa que pide un usuario y contraseña Básicamente un programa de inicio de sesión.

    cadena nom, contra;
    Consola.WriteLine(" Ingrese su código de usuario: ");
    nom = Consola.ReadLine();


    while (nom! = " SMIS133220 ")
    {

        Consola.WriteLine(" \ n Usuario incorrecto ");
        Consola.WriteLine(" \ n Ingrese de nuevo el usuario ");
        nom = Consola.ReadLine();

    }
    Consola.WriteLine(" \ n Ingrese su contraseña: ");
    contra = Consola.ReadLine();


    while (contra! = " UsulutanUGB ")
    {
        Consola.WriteLine(" \ n Contraseña incorrecta ");
        Consola.WriteLine(" \ n Ingrese de nuevo su contraseña ");
        contra = Consola.ReadLine();


    }

    Consola.WriteLine(" \ n Usuario y contraseña correctos. ");

    if (nom == " SMIS133220 " && contra == " UsulutanUGB ")
    {
        Consola.WriteLine(" \ n Bienvenido, usuario " + nom);
    }


}

programa3 vacío  estático ()
        {
    Sistema.Consola.WriteLine(" \ n Programa de calculadora ");
    char opcion;
    cadena continuar;
    doble sumar;
    doble restar;
    multiplicador doble;
    doble dividir;

    hacer
            {
        Consola.WriteLine(" | ******************************************* *** | ");
        Consola.WriteLine(" | * * | ");
        Consola.WriteLine(" | * 1.-Suma dos numeros (A + B) * | ");
        Consola.WriteLine(" | * 2.-reste dos numeros (A - B) * | ");
        Consola.WriteLine(" | * 3.-Multiplique dos numeros (A * B) * | ");
        Consola.WriteLine(" | * 4.-Divida dos numeros (A / B) * | ");
        Consola.WriteLine(" | * 5.-Todas las Operaciones * | ");
        Consola.WriteLine(" | * * | ");
        Consola.WriteLine(" | * 0.-salir * | ");
        Consola.WriteLine(" | * * | ");
        Consola.WriteLine(" | * * | ");
        Consola.Escribir(" \ n ");
        Consola.Write(" Dime una opcion:    ");

        hacer
                {
            opcion = Consola.ReadKey(verdadero).KeyChar;
        }
        while (opcion < '0' || opcion > '5') ;
        interruptor(opcion)
                {
            caso  '0' :
                        {
                opciones();
            }
            romper;
            caso  '1' :
                        {
                Consola.Escribir(" {0} \ n ", opción);
                Consola.WriteLine(" -------------------- ");

                Consola.Write(" ingrese el numero (A): ");
                doble numeroA = doble.Analizar(Consola.ReadLine());

                Consola.Write(" ingrese el numero (B): ");
                doble numeroB = doble.Analizar(Consola.ReadLine());

                Consola.WriteLine(" ------------------------ ");
                sumar = (numeroA + numeroB);
                Consola.WriteLine(" El resultado de la suma es: " + sumar);

            }
            romper;
            caso  '2' :
                        {
                Consola.Escribir(" {0} \ n ", opción);
                Consola.WriteLine(" -------------------- ");

                Consola.Write(" ingrese el numero (A): ");
                doble numeroA = doble.Analizar(Consola.ReadLine());

                Consola.Write(" ingrese el numero (B): ");
                doble numeroB = doble.Analizar(Consola.ReadLine());

                Consola.WriteLine(" ------------------------ ");
                restar = (numeroA - numeroB);
                Consola.WriteLine(" El resultado de la resta es: " + restar);

            }
            romper;
            caso  '3' :

                        {
                Consola.Escribir(" {0} \ n ", opción);
                Consola.WriteLine(" -------------------- ");

                Consola.Write(" ingrese el numero (A): ");
                doble numeroA = doble.Analizar(Consola.ReadLine());

                Consola.Write(" ingrese el numero (B): ");
                doble numeroB = doble.Analizar(Consola.ReadLine());

                Consola.WriteLine(" ------------------------ ");
                multiplicar = (numeroA * numeroB);
                Consola.WriteLine(" El resultado de la Multiplicacion es: " + multiplicar);

            }

            romper;
            caso  '4' :

                        {
                Consola.Escribir(" {0} \ n ", opción);
                Consola.WriteLine(" -------------------- ");

                Consola.Write(" ingrese el numero (A): ");
                doble numeroA = doble.Analizar(Consola.ReadLine());

                Consola.Write(" ingrese el numero (B): ");
                doble numeroB = doble.Analizar(Consola.ReadLine());

                Consola.WriteLine(" ------------------------ ");
                dividir = (numeroA / numeroB);
                Consola.WriteLine(" El resultado de la division es: " + dividir);

            }

            romper;

            caso  '5' :

                        {

                Consola.Escribir(" {0} \ n ", opción);
                Consola.WriteLine(" -------------------- ");

                Consola.Write(" ingrese el numero (A): ");
                doble numeroA = doble.Analizar(Consola.ReadLine());

                Consola.Write(" ingrese el numero (B): ");
                doble numeroB = doble.Analizar(Consola.ReadLine());

                Consola.WriteLine(" ------------------------ ");
                sumar = (numeroA + numeroB);
                restar = (numeroA - numeroB);
                multiplicar = (numeroA * numeroB);
                dividir = (numeroA / numeroB);

                Consola.WriteLine(" El resultado de la suma es: " + sumar);
                Consola.WriteLine(" El resultado de la resta es: " + restar);
                Consola.WriteLine(" El resultado de la Multiplicacion es: " + multiplicar);
                Consola.WriteLine(" El resultado de la division es: " + dividir);

            }
            romper;
        }
        Consola.WriteLine(" ******************************** ");
        Consola.Write(" ¿desea continuar? Si / No ");
        continuar = Consola.ReadLine();
        Consola.WriteLine(" \ n ");
        Consola.Borrar();
    }
    while (continuar! = " n ") ;

}

programa4 vacío  estático ()
        {
    Sistema.Consola.WriteLine(" \ n Programa de cálculo promedio ");
    // Programa que calcula el promedio de 3 numeros
    // Variables
    doble n1 = 0. 0;
    doble n2 = 0. 0;
    doble n3 = 0. 0;
    doble Promedio = 0. 0;
    String dato = " ";

    Consola.WriteLine(" Dame un numero ");
    dato = Consola.ReadLine();
    n1 = Convertir.ToDouble(dato);

    Consola.WriteLine(" Dame el siguiente numero ");
    dato = Consola.ReadLine();
    n2 = Convertir.ToDouble(dato);

    Consola.WriteLine(" otro numero por favor ");
    dato = Consola.ReadLine();
    n3 = Convertir.ToDouble(dato);

    Promedio = (n1 + n2 + n3) / 3. 0;

    Consola.WriteLine(" El Promedio es {0} ", Promedio);

    si(Promedio > = 6)
            {
        Consola.WriteLine(" Ha aprobado ");
    }
    demás
            {
        Consola.WriteLine(" Tiene reprobado ");
    }
}

    }
}
