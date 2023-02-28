
//Punto 1: Declaracion de renta
using System; 

double impuesto=0;
Console.WriteLine("Ingresa la renta del primer trimestre");
double P1=double.Parse(Console.ReadLine());
Console.WriteLine("Ingresa la renta del segundo trimestre");
double P2=double.Parse(Console.ReadLine());
Console.WriteLine("Ingresa la renta del tercer trimestre");
double P3=double.Parse(Console.ReadLine());
Console.WriteLine("Ingresa la renta del cuarto trimestre");
double P4=double.Parse(Console.ReadLine());

double sumatoria=P1 + P2 + P3 + P4;
double total=0;

if(sumatoria < 10000){
 impuesto=sumatoria * 0.05;
 total=sumatoria-impuesto;

Console.WriteLine("Su renta anual sin impuesto es de:  " + sumatoria + "\n El total de impuesto a pagar es de: " + impuesto +
"\n" + "por lo tanto su renta anual es de: " + total);
Environment.Exit(1);

}if(sumatoria >10000 && sumatoria<20000){
 impuesto=sumatoria * 0.1;
 total=sumatoria-impuesto;

Console.WriteLine("Su renta anual sin impuesto es de:  " + sumatoria + "\n El total de impuesto a pagar es de: " + impuesto +
"\n" + "por lo tanto su renta anual es de: " + total);
Environment.Exit(1);
}if(sumatoria >20000 && sumatoria<35000){
 impuesto=sumatoria * 0.15;
 total=sumatoria-impuesto;

Console.WriteLine("Su renta anual sin impuesto es de:  " + sumatoria + "\n El total de impuesto a pagar es de: " + impuesto +
"\n" + "por lo tanto su renta anual es de: " + total);
Environment.Exit(1);
}if(sumatoria >35000 && sumatoria<45000){
 impuesto=sumatoria * 0.20;
 total=sumatoria-impuesto;

Console.WriteLine("Su renta anual sin impuesto es de:  " + sumatoria + "\n El total de impuesto a pagar es de: " + impuesto +
"\n" + "por lo tanto su renta anual es de: " + total);
Environment.Exit(1);
}if(sumatoria >45000){
 impuesto=sumatoria * 0.30;
 total=sumatoria-impuesto;

Console.WriteLine("Su renta anual sin impuesto es de:  " + sumatoria + "\n El total de impuesto a pagar es de: " + impuesto +
"\n" + "por lo tanto su renta anual es de: " + total);
Environment.Exit(1);
}
Console.WriteLine("Has ingresado una cantidad no válida");



//Punto 2: Ingreso Sala de Juegos
string name;
int age;
double entrada=15000, descuento=0;


Console.WriteLine("Ingresos PiviGames");
Console.WriteLine("-----------------------------");
Console.WriteLine("Ingrese su nombre completo");
name=Console.ReadLine();
Console.WriteLine("Ingrese su edad");
age=Int32.Parse(Console.ReadLine());

if(age<4){
    Console.WriteLine(name+" Estas muy cachorro, entra gratis");
}
else if(age>4 && age<=18){
    descuento=0.05;
    entrada=entrada-(entrada*descuento);
Console.WriteLine(name+" Su entrada tiene un costo de: "+ entrada);
}else{
    descuento=0.03;
    entrada=entrada-(entrada*descuento);
    Console.WriteLine(name+" Su entrada tiene un costo de: "+ entrada);
}
Console.WriteLine("Su descuento fue del " + descuento*100+'%');


//Punto 3: Pizzeria
//Pizzas el Fercho

Console.WriteLine ("pizzas: \n- no vegetariana \n- vegetariana \n ingrese la pizza deseada:\n");

string pizza = Console.ReadLine();    
int add = 0;
string ingredientes = "";   

if (pizza.Equals ("no vegetariana", StringComparison.CurrentCultureIgnoreCase)){

    Console.WriteLine ("elija un ingrediente para su pizza \n- ingrese 1 para Pepperoni \n- ingrese 2 para salami \n- ingrese 3 para pollo");
    add = Int32.Parse (Console.ReadLine());

    if (add ==  1) ingredientes = "pepperoni";    
    if (add ==  2) ingredientes = "salami";
    if (add == 3) ingredientes = "pollo";
}

if (pizza.Equals("vegetariana", StringComparison.CurrentCultureIgnoreCase)){

    Console.WriteLine("elija un ingrediente para su pizza \n- ingrese 1 para pimiento \n- ingrese 2 para champiñones");
    add = Int32.Parse(Console.ReadLine());

    if (add == 1) ingredientes = "Pimiento";
    if (add == 2) ingredientes = "Champiñones";
}

Console.WriteLine(" su pizza es: " + pizza + " \n ingredientes seleccionados: \n- tomate \n- mozzarella \n- " + ingredientes);

//Punto 4: Premiacion Empleados 
int dinero = 50000;
            Console.WriteLine("Ingrese su calificacion de rendimiento : (inaceptable/Aceptable/Meritorio) ");
            string calificacion = Console.ReadLine();
            switch (calificacion) {
                case "inaceptable":
                    Console.WriteLine($"Su nivel de evalucion fue {0.0} ==> Aceptable,El valor total de la bonificacion es : " +(0.0* dinero));
                break;

                case "aceptable":
                    Console.WriteLine($"Su puntuacion de evalucion fue {0.4} ==> Aceptable,El valor total de la bonificacion es : " + (0.4* dinero));
                break;

                case "meritorio":
                    Console.WriteLine($"Su nivel de evalucion fue {0.6} ==> Meritorio ,El valor total de la bonificacion es : " + (0.6 * dinero));
                break;

                default: Console.WriteLine("Digitaste una opcion incorrecta, vuelve a intentarlo"); break;
            }


/// Opcion 2


 double dinero2 = 50000;
            Console.WriteLine("INGRESE LA PUNTUACION DE SU EVALUCION : (0.0/0.4/0.6)" );
            double punto =double.Parse( Console.ReadLine());

            if (punto==0.0)
            {
                Console.WriteLine($"Su nivel de evalucion fue {0.0} ==> Aceptable ,El valor total de la bonificacion es : " + (0.0 * dinero2));
                Environment.Exit(1);
            }
            if (punto == 0.4)
            {
                Console.WriteLine($"Su nivel de evalucion fue {0.4} ==> Aceptable ,El valor total de la bonificacion es : " + (0.4 * dinero2));
                Environment.Exit(1);
            }
            if (punto == 0.6)
            {
                Console.WriteLine($"Su nivel de evalucion fue {0.6} ==> Aceptable ,El valor total de la bonificacion es : " + (0.6 * dinero2));
                Environment.Exit(1);
            }

            Console.WriteLine("Ingresaste una opcion incorrecta vuelve a intentarlo");
            

