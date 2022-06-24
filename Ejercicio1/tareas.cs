public class Tareas
{
    private int iDTarea;
    private string descripcion = "";
    private int duracion;

    public int IDTarea { get => iDTarea; set => iDTarea = value; }
    public string Descripcion { get => descripcion; set => descripcion = value; }
    public int Duracion { get => duracion; set => duracion = value; }

    public void MostrarTareas(){
        Console.WriteLine(Descripcion);
        Console.WriteLine("Numeracion de la tarea: "+IDTarea);
        Console.WriteLine("Duracion: "+Duracion);
    }
}
