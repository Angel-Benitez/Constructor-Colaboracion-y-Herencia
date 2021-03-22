//1. Crear una clase Persona que tenga como atributos el 
// "cedula, nombre, apellido y la edad (definir las propiedades 
// para poder acceder a dichos atributos)". Definir como responsabilidad 
// un método para mostrar ó imprimir. Crear una segunda clase Profesor 
// que herede de la clase Persona. Añadir un atributo sueldo (y su propiedad) 
// y el método para imprimir su sueldo. Definir un objeto de la clase Persona
// y llamar a sus métodos y propiedades. También crear un objeto de la clase 
// Profesor y llamar a sus métodos y propiedades.

// using System;
// namespace Constructor__Colaboracion_y_Herencia
// {
//     class Persona
//     {
//         private string nom;
//         private string ape;
//         private string  ced;
//         private int edad;
//         public Persona ()
//         {
//             Console.Write("Digite su nombre: ");            
//             nom = Console.ReadLine();            
//             Console.Write("Digite su apellido: ");            
//             ape = Console.ReadLine();            
//             Console.Write("Digite su cedula: ");            
//             ced = Console.ReadLine();            
//             Console.Write("Digite su edad: ");            
//             string ed = Console.ReadLine();            
//             edad = int.Parse(ed); 
//         }
//         public void imprimir ()
//         {
//             Console.Clear();          
//             Console.WriteLine("Su nombre es: {0} {1}",nom, ape);           
//             Console.WriteLine("Cedula: " + ced);            
//             Console.WriteLine("Edad: " + edad);
//         }
//         class Profesor
//         {
//             private double sueldo;            
//             public Profesor()
//             {
//                 sueldo = 5000;
//             }
//             public void imprimir()            
//             {                
//                 Console.WriteLine("Su sueldo es de: " + sueldo);
//             }

//         }

//         static void Main(string[] args)
//         {
//             Persona person = new Persona();            
//             Profesor prof = new Profesor();            
//             person.imprimir();            
//             prof.imprimir();
//         }
//     }
// }
//___________________________________________________________________________

// 2. Crear una clase Contacto. Esta clase deberá tener los atributos 
// "nombre, apellidos, telefono y direccion". También deberá tener 
// un método "SetContacto", de tipo void y con los parámetros string, 
// que permita cambiar el valor de los atributos. También tendrá un 
// método "Saludar", que escribirá en pantalla "Hola, soy " seguido 
// de sus datos. Crear también una clase llamada ProbarContacto. 
// Esta clase deberá contener sólo la función Main, que creará dos 
// objetos de tipo Contacto, les asignará los datos del contacto y 
// les pedirá que saluden.

// using System;
// namespace Constructor__Colaboracion_y_Herencia
// {
//     public class contacto    
//     {        
//         private string nom;        
//         private string ape;        
//         private string direc;        
//         private int tel; 
//         public contacto ()
//         {     
//             Console.Write("Digite su nombre: ");            
//             nom = Console.ReadLine();            
//             Console.Write("Digite su apellido: ");            
//             ape = Console.ReadLine();            
//             Console.Write("Digite su dirección: ");            
//             direc = Console.ReadLine();            
//             Console.Write("Digite su telefono: ");            
//             string num = Console.ReadLine();            
//             tel = int.Parse(num);       
//         }
//         public void imprimir()            
//         {                
//             Console.Clear();          
//             Console.WriteLine("Su nombre es: {0} {1}",nom, ape);           
//             Console.WriteLine("Dirección: " + direc);            
//             Console.WriteLine("Telefono: " + tel);
//         }
//     }
//     public class ProbarContacto    
//     {        
//         static void Main(string[] args)
//         {            
//             contacto cont = new contacto();            
//             cont.imprimir();  
//             Console.ReadKey();           
//         } 
//     } 
// }
//______________________________________________________________________________

//3. Crear tres clases ClaseA, ClaseB, ClaseC que ClaseB herede de ClaseA 
//y ClaseC herede de ClaseB. Definir un constructor a cada clase que 
//muestre un mensaje. Luego definir un objeto de la clase ClaseC.

// using System;
// namespace Constructor__Colaboracion_y_Herencia
// {
//     public class A    
//     {        
//         public A()        
//         {            
//             Console.WriteLine("Constructor de la clase A");        
//         }    
//     }   
//     public class B: A    
//     {        
//         public B()        
//         {            
//             Console.WriteLine("Constructor de la clase B");        
//         }    
//     }    
//     public class C: B    
//     {        
//         public C()        
//         {            
//             Console.WriteLine("Constructor de la clase C");        
//         }    
//     }    
//     class Objeto    
//     {        
//         static void Main (string[] args)        
//         {            
//             C obj = new C();            
//             Console.ReadKey();        
//         }   
//     } 
// }