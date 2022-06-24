using System.Collections.Generic;

List<Tareas> TareasPendientes = new List<Tareas>();
List<Tareas> TareasRealizadas = new List<Tareas>();

//  Cargmos las tareas con sus respectiva información
string salida = "";
int numero = 0, auxiliar;
do
{
    Console.WriteLine("Ingrese la descripcion de la tarea: ");
    string DescTarea = Console.ReadLine();

    Tareas NuevaTarea = new Tareas();
    if (DescTarea == null){
        NuevaTarea.Descripcion = " ";
    } else {
        NuevaTarea.Descripcion = DescTarea;
    }
    NuevaTarea.IDTarea = numero++;
    NuevaTarea.Duracion = new Random().Next(0,100);
    TareasPendientes.Add(NuevaTarea);

    Console.WriteLine("Desea agregar otra tarea (s: si/n: no)?");
    salida = Console.ReadLine();
} while (salida != "n");

//Movemos las tareas realizadas
foreach (Tareas TareaX in TareasPendientes){
    Console.WriteLine("Se realizo la tarea: '"+TareaX.Descripcion+"' (0:Si,1:No)?");
    auxiliar = Convert.ToInt16(Console.ReadLine());
    if (auxiliar == 0){
        TareasRealizadas.Add(TareaX);
    }
}

//Ahora borramos la tareas ya realizadas de nuetras lista de pendientes
TareasPendientes = TareasPendientes.Except(TareasRealizadas).ToList();

//Buscador
Console.WriteLine("Ingrese la descripcion de la tarea pendiente que desea buscar: ");
string DescriptionBuscada = Console.ReadLine();
if (DescriptionBuscada == null){
    DescriptionBuscada = "";
}


foreach (Tareas TareaX in TareasPendientes){
    if (TareaX.Descripcion.ToLower().Contains(DescriptionBuscada.ToLower().Trim()));{
        TareaX.MostrarTareas();
    }
}

//Sumario de horas total trabajadas
int HorasTotal = 0;
foreach (Tareas TareaX in TareasRealizadas){
    HorasTotal += TareaX.Duracion;
}
Console.WriteLine("La cantidad de horas trabajadas por el empleado es de: "+HorasTotal);

//Mostramos las tareas pendientes
Console.WriteLine("Las tareas que quedan pendientes son: ");
foreach (Tareas TareaX in TareasPendientes){
    Console.WriteLine(TareaX.IDTarea+" - "+TareaX.Descripcion+" - "+TareaX.Duracion);
}

//Mostramos las tareas realizadas
Console.WriteLine("Las tareas que se realizaron son: ");
foreach (Tareas TareaX in TareasRealizadas){
    Console.WriteLine(TareaX.IDTarea+" - "+TareaX.Descripcion+" - "+TareaX.Duracion);
}
