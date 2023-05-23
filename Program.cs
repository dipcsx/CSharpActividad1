string op;
do{
    Console.Clear();
    Console.BackgroundColor = ConsoleColor.Green;
    Console.ForegroundColor = ConsoleColor.Black;
    Console.WriteLine("\n«MENU - ACTIVIDAD NRO 1»");
    Console.ForegroundColor = ConsoleColor.Gray;
    Console.BackgroundColor = ConsoleColor.Black;
    
    for(int i=1;i<=10;i++) Console.WriteLine($"[{i}] Ejercicio {i}");
    Console.WriteLine("[11] Salir \n");
    Console.Write("Presione [numero] correspondiente, para ejecutar el ejercicio: ");
    op = Console.ReadLine() ?? "";
    
    switch(op){
        case "1":
            ejecutarPrograma1();
            break;
        case "2":
            ejecutarPrograma2();
            break;
        case "3":
            ejecutarPrograma3();
            break;
        case "4":
            ejecutarPrograma4();
            break;
        case "5":
            ejecutarPrograma5();
            break;
        case "6":
            ejecutarPrograma6();
            break;
        case "7":
            ejecutarPrograma7();
            break;
        case "8":
            ejecutarPrograma8();
            break;    
        default:
            break;
    }
    
}while(op != "11");
Console.ReadLine();

static void maqueta(int numEjercicio){
        Console.Clear();        
        Console.WriteLine($"\n«« EJERCICIO {numEjercicio} »»");        
        Console.BackgroundColor=ConsoleColor.Yellow;
        Console.ForegroundColor=ConsoleColor.Black;
        Console.WriteLine("*Ingreso de datos*");
        Console.ForegroundColor=ConsoleColor.Gray;
        Console.BackgroundColor=ConsoleColor.Black;
}
static void ejecutarPrograma1(){
    //Ejercicio 1
    const int jorTrab=48; //variable constante jornada laboral
    string opcion;
    //Bucle Peticion de Datos y resultados.
    do{
        maqueta(1); //Maqueta de presentacion
        //programa principal
        //Peticion de datos
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"\n«« La jornada de trabajo laboral ACTUAL es: {jorTrab} horas »»");
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.Write("Ingresa pago x hora laboral:S/ "); //Solicitud de Pago por hora
        double pagoh=Convert.ToDouble(Console.ReadLine());
        Console.Write("Ingrese horas/semana trabajadas: "); //Solicitud de horas trabajadas semanales
        int horast=Convert.ToInt32(Console.ReadLine());

        //Invocamos la funcion que devolvera el salario y las horas extras.
        //Y las almacenamos en dos variables
        var (salario,hextras) = calcularDetalleSalario(pagoh,horast,jorTrab);

        //Resultado mostrado en consola
        Console.WriteLine($"** Horas Extras laboradas es: {hextras} **");
        Console.WriteLine("****************************************");
        Console.WriteLine($"El salario para el trabajador es: S/ {salario}");
        Console.WriteLine("****************************************");
        
        //Funcion que se encarga de preguntar si desea volver a ejecutar el programa actual y validar la opcion.
        opcion=volverAejecutar();
    }while(opcion!="N" && opcion!="n");
    Console.ReadLine();
}
static void ejecutarPrograma2(){
    //Ejercicio 2
    string opcion;
    do{
        maqueta(2); //Maqueta de presentacion
        //programa principal
        Console.Write("Nombre de Cliente: ");
        Console.ReadLine();
        Console.Write("# articulos comprados: ");
        int cantidadArt = Convert.ToInt32(Console.ReadLine());
        string formaPago = evaluarFormaDePago(cantidadArt);
        Console.WriteLine("*********************");
        Console.Write("La forma de pago será en ");
        Console.BackgroundColor = ConsoleColor.Gray;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.WriteLine($"*{formaPago}*");
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.BackgroundColor = ConsoleColor.Black;
        Console.WriteLine("*********************");
        
        //Funcion que se encarga de preguntar si desea volver a ejecutar el programa actual y validar la opcion.
        opcion=volverAejecutar();
    }while(opcion!="N" && opcion!="n");
    Console.ReadLine();
}
static void ejecutarPrograma3(){
    //Ejercicio 3
    const int criterioDscto = 80;
    const double oferDscto = 10;
    const int costoDocena = 48;
    int costoUnidad = costoDocena /12;
    int cantCuadernos;
    string opcion;
    do{
        maqueta(3); //Maqueta de presentacion
        //programa principal
        Console.Write("Ingrese # de cuadernos: ");
        cantCuadernos = Convert.ToInt32(Console.ReadLine());
        var (pagoF, dscto) = calcularPagoFinal(cantCuadernos, criterioDscto, oferDscto, costoUnidad);
        if(dscto==0) Console.WriteLine("* No tiene Dscto.");
        else Console.WriteLine($"* Felicidades obtiene un Dscto. de: {dscto}");
        Console.WriteLine("*********************");
        Console.WriteLine($"El pago total es: S/ {pagoF}");
        Console.WriteLine("*********************");
        //Funcion que se encarga de preguntar si desea volver a ejecutar el programa actual y validar la opcion.
        opcion=volverAejecutar();
    }while(opcion!="N" && opcion!="n");
    Console.ReadLine();
}
static void ejecutarPrograma4(){
    string opcion;
    do{
        maqueta(4); //Maqueta de presentacion
        //programa principal
        Console.Write("Cantidad de numero a ingresar:");
        int cant = Convert.ToInt32(Console.ReadLine());
        //Lamamos la funcion que arrojara el maximo y minimo de N numeros.
        var (max, min) = MaxMin(cant);
        Console.WriteLine("*********************");                
        if(max==min) Console.WriteLine("* Debe ingresar al menos dos numeros diferentes *");
        else{
            Console.WriteLine($"El mayor numero es: {max}");
            Console.WriteLine($"El menor numero es: {min}");
        }
        Console.WriteLine("*********************");
        //Funcion que se encarga de preguntar si desea volver a ejecutar el programa actual y validar la opcion.
        opcion=volverAejecutar();
    }while(opcion!="N" && opcion!="n");
    Console.ReadLine();
}
static void ejecutarPrograma5(){
    string opcion, nombre, fechaNac;
    string dia="", mes="", anio="";
    bool esValido; 
    do{
        maqueta(5);
        Console.Write("Ingrese su Nombre: ");
        nombre = Console.ReadLine() ?? "";
        Console.Write("Ingrese su fecha de Nac.[dd/mm/aaaa]: ");
        fechaNac = Console.ReadLine() ?? "";
        if(fechaNac.Length==10){
            dia = fechaNac.Substring(0,2);
            mes = fechaNac.Substring(3,2);
            anio = fechaNac.Substring(6,4); 
            esValido=validarFecha(dia,mes,anio);
        
        }else esValido=false;

        Console.WriteLine("***************************************");
        if(esValido){
            string signo = obtenerSigno(dia,mes);
            Console.WriteLine($"{nombre} tu Signo Zodiacal es: {signo}");
            
        }else Console.WriteLine("!!! Ingrese formato de fecha correcta.");
                
        Console.WriteLine("***************************************");
        
        opcion=volverAejecutar();
    }while(opcion!="N" && opcion!="n");
    Console.ReadLine();
}
static void ejecutarPrograma6(){
    string nombre, opcion;
    double promedio;
    int nota;
    do{
        double suma=0;
        maqueta(6);        
        Console.Write("Ingrese Nombre de Alumno: ");
        nombre = Console.ReadLine() ?? "";
        Console.WriteLine("Ingrese 4 notas:");
        for(int i=1;i<=4;i++){
            Console.Write($"[{i}]: ");
            nota = Convert.ToInt32(Console.ReadLine());
            suma = suma + nota;
        }
        promedio = suma/4;
        Console.WriteLine("***************************************");
        Console.Write($"El alumno \"{nombre}\", se encuentra ");
        if(promedio>10) {
            Console.ForegroundColor=ConsoleColor.Green;
            Console.WriteLine("APROBADO.");
            Console.ForegroundColor=ConsoleColor.Gray;
        }
        else {
            Console.ForegroundColor=ConsoleColor.Red;
            Console.WriteLine("DESAPROBADO.");
            Console.ForegroundColor=ConsoleColor.Gray;
        }   
        Console.WriteLine("***************************************");
        opcion=volverAejecutar();
    }while(opcion!="N" && opcion!="n");
    Console.ReadLine();

}
static void ejecutarPrograma7(){
    double num1,num2;
    string opcion;
    do{
        
        maqueta(7);        
        Console.Write("Ingresar primer numero: ");
        //una forma de validar,es declarando como string, y luego condicional:
        // si se puede convertir a numero,en caso no, mensaje de advertencia y sale del programa.
        num1 = Convert.ToDouble(Console.ReadLine() ?? ""); 
        Console.Write("Ingresar segundo numero: ");
        num2 = Convert.ToDouble(Console.ReadLine());
        var(suma,resta,producto,division) = OperarBas(num1,num2);
        
        Console.WriteLine("***************************************");
        Console.WriteLine($"[Suma] : {suma}");
        Console.WriteLine($"[Resta] : {resta}");
        Console.WriteLine($"[Multiplicación] : {producto}");
        if (num2==0) Console.WriteLine($"[División] : No se puede dividir entre 0.");
        else Console.WriteLine($"[División] : {division}");
        if(producto>=20) {
            producto=producto-resta;
            Console.WriteLine($"\nProducto es >= 20, se restará {resta} = {producto}");
        }
        else{
            producto=producto+suma;
            Console.WriteLine($"\nProducto es < 20, se sumara {suma} = {producto}");
        } 
        Console.WriteLine("***************************************");
        opcion=volverAejecutar();
    }while(opcion!="N" && opcion!="n");
    Console.ReadLine();
}
static void ejecutarPrograma8(){
    string opcion;
    int num;
    do{
        maqueta(8);        
        Console.Write("Ingrese un numero del 1-10: ");
        num=Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("***************************************");
        GenerarTablaMulti(num);
        Console.WriteLine("***************************************");
        
        opcion=volverAejecutar();
    }while(opcion!="N" && opcion!="n");
    Console.ReadLine();
}
//Metodo para generar tabla de multiplicacion
static void GenerarTablaMulti(int num){
    int producto;
    for (int i=1;i<=10;i++){
            producto=i*num;
            Console.WriteLine($"{num} x {i} = {producto}");
        }
}
//Funcion para calcular el salario y las horas extras/Ejercicio 1
static (double,int) calcularDetalleSalario(double pagoh, int horast, int jorTrab){
    double salario; int hextras=0;
    if (horast <= jorTrab){
        salario = pagoh * horast;
    }else{
        hextras = horast - jorTrab;
        //salario = (valorh * 48) + hextras*valorh*2; //FACTORIZAMOS:
        salario = pagoh * (hextras*2 + 48);
    }
    return (salario, hextras);
}
//Funcion para evaluar la forma de pago segun le cantidad de articulos/Ejercicio 2
static string evaluarFormaDePago(int cantidadArt){
    string formaPago;
    if(cantidadArt<=30) formaPago = "EFECTIVO";
    else if(cantidadArt>30 && cantidadArt<=60) formaPago = "TARJETA";
    else formaPago = "CHEQUE";
    return formaPago;
}
//Funcion para calular el pago final y el dscto por promocion./Ejercicio 3
static (double, double) calcularPagoFinal(int cantCuadernos, int criterioDscto, double oferDscto, double costoUnidad){
    double pagoF; double dscto;    
    if(cantCuadernos/12 < criterioDscto){
        dscto = 0;
        pagoF = costoUnidad * cantCuadernos;
    }else{
        dscto = (costoUnidad * cantCuadernos) * (oferDscto/100);
        pagoF = (costoUnidad * cantCuadernos) - dscto;
    }    
return (pagoF, dscto);
}
//Funcion para hallar el maximo y minimo de n cantidad de # ingresados/Ejercicio 4
static (int, int) MaxMin(int cantidadNumeros){
    int num; int mayor=0; int menor=0;
    Console.WriteLine($"Ingrese {cantidadNumeros} numeros: ");
    for(int i=1;i<=cantidadNumeros;i++) {
        Console.Write($"[{i}] : ");
        num = Convert.ToInt32(Console.ReadLine());
        if(i==1){
            mayor=num;
            menor=num;
        }
        else
        {
            if (num>mayor) mayor=num;
            if (num<menor) menor=num;    
        }            
    }
return (mayor,menor);
}
//Funcion para solicitar sI desea volver a ejecutar el ejercicio actual /Todos los Ejercicios
static string volverAejecutar(){
    string opcion;
    Console.Write("Desea realizar otro calculo.(Y/N): ");
    opcion = Console.ReadLine() ?? "";
    if (opcion!="Y" && opcion!="y" && opcion!="N" && opcion!="n"){
        Console.ForegroundColor=ConsoleColor.Red;
        Console.WriteLine("!!! Debe Ingresar una opcion válida...");
        Console.WriteLine("*El programa terminará...");
        Console.ForegroundColor=ConsoleColor.Gray;
        return "N";
    }
    return opcion;
}
//Funcion decir si es Bisiesto
static bool esBisiesto(int numanio){
    bool esBiciesto=true;
    if(numanio%4!=0) esBiciesto=false;
    else{
        esBiciesto=true;
        if(numanio%100==0) esBiciesto=false;
        if(numanio%400==0 && numanio%100==0) esBiciesto=true;
    }    
    return esBiciesto;
}
//Funcion para validez del rango de fecha
static bool validarFecha(string dia, string mes, string anio){
    bool fechaValida;
    int numdia, nummes, numanio;
    if(int.TryParse(dia, out numdia) && int.TryParse(mes,out nummes) && int.TryParse(anio,out numanio)){
        fechaValida=true;
        if(nummes>=1 && nummes<=12) {
            fechaValida=true;
            if(nummes==1 || nummes==3 || nummes==5 || nummes==7 || nummes==8 || nummes==10 || nummes==12){
                if(numdia>0 && numdia<=31) fechaValida=true;
                else fechaValida=false;
            }else if(nummes==4 || nummes==6 || nummes==9 || nummes==11){
                if(numdia>0 && numdia<=30) fechaValida=true;
                else fechaValida=false;
            }else{
                if(esBisiesto(numanio)){
                    if(numdia>0 && numdia<=29) fechaValida=true;
                    else fechaValida=false;
                } 
                else{
                    if(numdia>0 && numdia<=28) fechaValida=true;
                    else fechaValida=false;
                } 
            }
        }
        else fechaValida=false;
    }   
    else fechaValida=false;

    return fechaValida;
}
//Funcion para obtener el signo
static string obtenerSigno(string dia, string mes){
    int numdia, nummes;
    //string signo="";
    int.TryParse(dia, out numdia);
    int.TryParse(mes,out nummes);

    if(numdia>=21 && nummes==3 || numdia<=20 && nummes==4) return "ARIES";
    else if(numdia>=21 && nummes==4 || numdia<=21 && nummes==5) return "TAURO";
    else if(numdia>=22 && nummes==5 || numdia<=21 && nummes==6) return "GEMINIS";
    else if(numdia>=22 && nummes==6 || numdia<=22 && nummes==7) return "CANCER";
    else if(numdia>=23 && nummes==7 || numdia<=23 && nummes==8) return "LEO";
    else if(numdia>=24 && nummes==8 || numdia<=23 && nummes==9) return "VIRGO";
    else if(numdia>=24 && nummes==9 || numdia<=23 && nummes==10) return "LIBRA";
    else if(numdia>=24 && nummes==10 || numdia<=22 && nummes==11) return "ESCORPIO";
    else if(numdia>=23 && nummes==11 || numdia<=21 && nummes==12) return "SAGITARIO";
    else if(numdia>=22 && nummes==12 || numdia<=20 && nummes==1) return "CAPRICORNIO";
    else if(numdia>=21 && nummes==1 || numdia<=18 && nummes==2) return "ACUARIO";
    else if(numdia>=19 && nummes==2 || numdia<=20 && nummes==3) return "PICIS";
    else return "NO SE ENCONTRO EL SIGNO";
}
//Funcion para obtener las operacion basicas de dos numeros.
static (double,double,double,double) OperarBas(double num1, double num2){
    double suma = num1+num2;
    double resta = num1-num2;
    double producto = num1*num2;
    double division = num1/num2;
    return (suma,resta,producto,division);

}

