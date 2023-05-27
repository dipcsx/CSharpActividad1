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
            EjecutarPrograma1();
            break;
        case "2":
            EjecutarPrograma2();
            break;
        case "3":
            EjecutarPrograma3();
            break;
        case "4":
            EjecutarPrograma4();
            break;
        case "5":
            EjecutarPrograma5();
            break;
        case "6":
            EjecutarPrograma6();
            break;
        case "7":
            EjecutarPrograma7();
            break;
        case "8":
            EjecutarPrograma8();
            break;
        case "9":
            EjecutarPrograma9();
            break; 
        case "10":
            EjecutarPrograma10();
            break;   
        default:
            break;
    }
    
}while(op != "11");
Console.ReadLine();

static void Maqueta(int numEjercicio){
        Console.Clear();        
        Console.WriteLine($"\n«« EJERCICIO {numEjercicio} »»");        
        Console.BackgroundColor=ConsoleColor.Yellow;
        Console.ForegroundColor=ConsoleColor.Black;
        Console.WriteLine("*Ingreso de datos*");
        Console.ForegroundColor=ConsoleColor.Gray;
        Console.BackgroundColor=ConsoleColor.Black;
}
static void EjecutarPrograma1(){
    //Ejercicio 1
    const int jorTrab=48; //variable constante jornada laboral
    string opcion;
    //Bucle Peticion de Datos y resultados.
    do{
        Maqueta(1); //Maqueta de presentacion
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
        var (salario,hextras) = CalcularDetalleSalario(pagoh,horast,jorTrab);

        //Resultado mostrado en consola
        Console.WriteLine($"** Horas Extras laboradas es: {hextras} **");
        Console.WriteLine("****************************************");
        Console.WriteLine($"El salario para el trabajador es: S/ {salario}");
        Console.WriteLine("****************************************");
        
        //Funcion que se encarga de preguntar si desea volver a ejecutar el programa actual y validar la opcion.
        opcion=VolverAejecutar();
    }while(opcion!="N" && opcion!="n");
    Console.ReadLine();
}
static void EjecutarPrograma2(){
    //Ejercicio 2
    string opcion;
    do{
        Maqueta(2); //Maqueta de presentacion
        //programa principal
        Console.Write("Nombre de Cliente: ");
        Console.ReadLine();
        Console.Write("# articulos comprados: ");
        int cantidadArt = Convert.ToInt32(Console.ReadLine());
        string formaPago = EvaluarFormaDePago(cantidadArt);
        Console.WriteLine("*********************");
        Console.Write("La forma de pago será en ");
        Console.BackgroundColor = ConsoleColor.Gray;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.WriteLine($"*{formaPago}*");
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.BackgroundColor = ConsoleColor.Black;
        Console.WriteLine("*********************");
        
        //Funcion que se encarga de preguntar si desea volver a ejecutar el programa actual y validar la opcion.
        opcion=VolverAejecutar();
    }while(opcion!="N" && opcion!="n");
    Console.ReadLine();
}
static void EjecutarPrograma3(){
    //Ejercicio 3
    const int criterioDscto = 80;
    const double oferDscto = 10;
    const int costoDocena = 48;
    int costoUnidad = costoDocena /12;
    int cantCuadernos;
    string opcion;
    do{
        Maqueta(3); //Maqueta de presentacion
        //programa principal
        Console.Write("Ingrese # de cuadernos: ");
        cantCuadernos = Convert.ToInt32(Console.ReadLine());
        var (pagoF, dscto) = CalcularPagoFinal(cantCuadernos, criterioDscto, oferDscto, costoUnidad);
        if(dscto==0) Console.WriteLine("* No tiene Dscto.");
        else Console.WriteLine($"* Felicidades obtiene un Dscto. de: {dscto}");
        Console.WriteLine("*********************");
        Console.WriteLine($"El pago total es: S/ {pagoF}");
        Console.WriteLine("*********************");
        //Funcion que se encarga de preguntar si desea volver a ejecutar el programa actual y validar la opcion.
        opcion=VolverAejecutar();
    }while(opcion!="N" && opcion!="n");
    Console.ReadLine();
}
static void EjecutarPrograma4(){
    string opcion;
    do{
        Maqueta(4); //Maqueta de presentacion
        //programa principal
        Console.Write("Cantidad de numero a ingresar:");
        int cant = Convert.ToInt32(Console.ReadLine());
        //Lamamos la funcion que arrojara el maximo y minimo de N numeros.
        var (max, min, medio) = MaxMin(cant);
        Console.WriteLine("*********************");                
        if(max==min) Console.WriteLine("* Debe ingresar al menos dos numeros diferentes *");
        else{
            Console.WriteLine($"El mayor numero es: {max}");
            Console.WriteLine($"El menor numero es: {min}");
        }
        Console.WriteLine("*********************");
        //Funcion que se encarga de preguntar si desea volver a ejecutar el programa actual y validar la opcion.
        opcion=VolverAejecutar();
    }while(opcion!="N" && opcion!="n");
    Console.ReadLine();
}
static void EjecutarPrograma5(){
    string opcion, nombre, fechaNac;
    string dia="", mes="", anio="";
    bool esValido; 
    do{
        Maqueta(5);
        Console.Write("Ingrese su Nombre: ");
        nombre = Console.ReadLine() ?? "";
        Console.Write("Ingrese su fecha de Nac.[dd/mm/aaaa]: ");
        fechaNac = Console.ReadLine() ?? "";
        if(fechaNac.Length==10){
            dia = fechaNac.Substring(0,2);
            mes = fechaNac.Substring(3,2);
            anio = fechaNac.Substring(6,4); 
            esValido=ValidarFecha(dia,mes,anio);
        
        }else esValido=false;

        Console.WriteLine("***************************************");
        if(esValido){
            string signo = ObtenerSigno(dia,mes);
            Console.WriteLine($"{nombre} tu Signo Zodiacal es: {signo}");
            
        }else Console.WriteLine("!!! Ingrese formato de fecha correcta.");
                
        Console.WriteLine("***************************************");
        
        opcion=VolverAejecutar();
    }while(opcion!="N" && opcion!="n");
    Console.ReadLine();
}
static void EjecutarPrograma6(){
    string nombre, opcion;
    double promedio;
    int nota;
    do{
        double suma=0;
        Maqueta(6);        
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
        opcion=VolverAejecutar();
    }while(opcion!="N" && opcion!="n");
    Console.ReadLine();

}
static void EjecutarPrograma7(){
    double num1,num2;
    string opcion;
    do{
        
        Maqueta(7);        
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
        opcion=VolverAejecutar();
    }while(opcion!="N" && opcion!="n");
    Console.ReadLine();
}
static void EjecutarPrograma8(){
    string opcion;
    int num;
    do{
        Maqueta(8);        
        Console.Write("Ingrese un numero del 1-10: ");
        num=Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("***************************************");
        GenerarTablaMulti(num);
        Console.WriteLine("***************************************");

        opcion=VolverAejecutar();
    }while(opcion!="N" && opcion!="n");
    Console.ReadLine();
}
static void EjecutarPrograma9(){
    int num1,num2;
    string opcion;
    do{
        Maqueta(9); //Maqueta de presentacion
        //peticionde datos y validacion try
        try{
        Console.Write("Ingrese primer numero: ");
        num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Ingrese segundo numero: ");
        num2 = Convert.ToInt32(Console.ReadLine());
        ImprNumMediosValPar(num1,num2);              
        Console.WriteLine("*********************");
        }
        catch(System.FormatException ex)
        {
            Console.WriteLine("Debe ingresar numeros enteros naturales." + ex.Message);
        }
        Console.WriteLine("*********************");
        //Funcion que se encarga de preguntar si desea volver a ejecutar el programa actual y validar la opcion.
        opcion=VolverAejecutar();
    }while(opcion!="N" && opcion!="n");
    Console.ReadLine();
}
static void EjecutarPrograma10(){
    string opcion;
    do{
        Console.Clear();
        Maqueta(10); //Maqueta de presentacion
        //programa principal
        
        Console.WriteLine("*Ingreso de medidas de un Triángulo*");
        //tengo una funcion que ordena numeros y devulve el mayor y menor, del un ejercicio anterior, lo aprovechare.
        //intentare realizar sobrecarga de funciones
        var(mayor,menor,medio) = MaxMin(3); //en caso el parametro sea mayor a 3 la funcion devolvera como valor de medio=0
        //creacion una funcion que me validara si es un triangulo.True O False
        if(EsTriangulo(mayor,menor,medio)){
            string tipotriangulo=ObtenerTipoTriangulo(mayor,menor,medio);
            Console.WriteLine("*********************");
            Console.Write("El triangulo formado es:");
            Console.BackgroundColor=ConsoleColor.Green;
            Console.ForegroundColor=ConsoleColor.Black;
            Console.WriteLine($"{tipotriangulo}");
            Console.ForegroundColor=ConsoleColor.Gray;
            Console.BackgroundColor=ConsoleColor.Black;
            Console.WriteLine("*********************");
        }else{
            Console.WriteLine("No se puede formar un triángulo con los datos ingresados.");
            Console.WriteLine("*Recuerde que para que se pueda formar un triángulo se debe cumplir \"a-b < c < a+b\"");
            Console.WriteLine("*********************");
        }
        
        
        
        //Funcion que se encarga de preguntar si desea volver a ejecutar el programa actual y validar la opcion.
        opcion=VolverAejecutar();
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
//Metodo para imprimir numeros entre N1 Y N2 y calcular ctos pares hay.
static void ImprNumMediosValPar(int num1,int num2){
    int menor, mayor, contar=0,contpar=0;
    menor=num1;
    mayor=num2;
    if(num1>num2) {
        mayor=num1;
        menor=num2;
    }
    Console.WriteLine($"Los numeros entre {menor} y {mayor} son:");
    Console.Write("[");
    for(int i=menor+1;i<mayor;i++){
        Console.Write($"{i}");
        if(i<mayor-1) Console.Write(",");
        contar=contar+1;
        if(i%2==0) contpar=contpar+1; 
    }
    Console.WriteLine("]");
    Console.WriteLine($"\nExisten {contar} numeros entre {menor} y {mayor}.");
    Console.WriteLine($"De los cuales {contpar} son pares.");
}
//Funcion para calcular el salario y las horas extras/Ejercicio 1
static (double,int) CalcularDetalleSalario(double pagoh, int horast, int jorTrab){
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
static string EvaluarFormaDePago(int cantidadArt){
    string formaPago;
    if(cantidadArt<=30) formaPago = "EFECTIVO";
    else if(cantidadArt>30 && cantidadArt<=60) formaPago = "TARJETA";
    else formaPago = "CHEQUE";
    return formaPago;
}
//Funcion para calular el pago final y el dscto por promocion./Ejercicio 3
static (double, double) CalcularPagoFinal(int cantCuadernos, int criterioDscto, double oferDscto, double costoUnidad){
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
//Funcion para hallar el maximo y minimo y medio de n cantidad de # ingresados/Ejercicio 4 y 10
static (int, int, int) MaxMin(int cantidadNumeros){
    int num; int a=0; int b=0; int c = 0;
    int menor=0, mayor=0, medio;
    Console.WriteLine($"Ingrese {cantidadNumeros} numeros: ");
    //Solicitar y asignar numeros
    for(int i=1;i<=cantidadNumeros;i++) {
        Console.Write($"[{i}] : ");
        num = Convert.ToInt32(Console.ReadLine());
        //solo si la cantidad de numeros ingresados es 3
        if (cantidadNumeros==3){
            if(i==1) a=num;
            else if(i==2) b=num;
            else c=num;
        }else{
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

    }

if(cantidadNumeros==3){
    menor=a; medio=b; mayor=c;
    if(a>=b && a>=c){
        mayor=a;
        if(b>c){
            medio=b;
            menor=c;
        }else{
            medio=c;
            menor=b;
        }
    } 
    if(b>a && b>c){
        mayor=b;
        if(a>c){
            medio=a;
            menor=c;
        }else{
            medio=c;
            menor=a;
        }
    }
    if(c>=a && c>=b){
        mayor=c;
        if(a>b){
            medio=a;
            menor=b;
        }else{
            medio=b;
            menor=a;
        }
    }
return (mayor,menor,medio);
} 
else return (mayor,menor,0);
}
//Funcion para solicitar sI desea volver a ejecutar el ejercicio actual /Todos los Ejercicios
static string VolverAejecutar(){
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
static bool EsBisiesto(int numanio){
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
static bool ValidarFecha(string dia, string mes, string anio){
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
                if(EsBisiesto(numanio)){
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
static string ObtenerSigno(string dia, string mes){
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
static bool EsTriangulo(int mayor,int menor,int medio){
    if(medio-menor<mayor && medio+menor>mayor) return true;
    else return false;
}
static string ObtenerTipoTriangulo(int mayor, int menor, int medio){
    //isosceles si tiene dos de sus lados iguales
    //equilatero si tiene los 3 lados iguales
    //escaleno si tiene los 3 lados diferentes
    if(mayor==menor && menor==medio) return "EQUILATERO";
    else if(mayor!=menor && menor!=medio && mayor!=medio) return "ESCALENO";
    else return "ISOSCELES";
}
