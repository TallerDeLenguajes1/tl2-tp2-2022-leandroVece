public class helpArchivo
{
    private static readonly NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();

    //ingresa los alumnos en un archivo csv
    public static void save(string path, Alumno alumno){

        try
        {
            if(!File.Exists(path)){
                FileStream Archivo = new FileStream(path, FileMode.OpenOrCreate);
                    using (StreamWriter strWrite = new StreamWriter(Archivo))
                    {
                        strWrite.WriteLine("{0},{1},{2},{3}",alumno.Id,alumno.Nombre,alumno.Apellido,alumno.Dni);
                        strWrite.Close();
                    }              
            }
            else
            {
                 FileStream Archivo = new FileStream(path, FileMode.Append);
                    using (StreamWriter strWrite = new StreamWriter(Archivo))
                    {
                        strWrite.WriteLine("{0},{1},{2},{3}",alumno.Id,alumno.Nombre,alumno.Apellido,alumno.Dni);
                        strWrite.Close();
                    }
            }
             Logger.Info("ingresado a la base de datos el alumno {0} de materia {1}",alumno.Nombre,alumno.Curso);           
        }
        catch (System.Exception ex)
        {
            Logger.Error(ex.Message);            
        }
    }

    public static void delete(string path, List<Alumno> alumnos){

    try
    {
        //Console.WriteLine(alumnos[0].Nombre);
        if(File.Exists(path)){
            FileStream Archivo = new FileStream(path, FileMode.Truncate);
                using (StreamWriter strWrite = new StreamWriter(Archivo))
                {
                    foreach (var item in alumnos)
                    {
                        Console.WriteLine("{0},{1},{2},{3}",item.Id,item.Nombre,item.Apellido,item.Dni);
                        strWrite.WriteLine("{0},{1},{2},{3}",item.Id,item.Nombre,item.Apellido,item.Dni);
                        
                    }
                    Logger.Info("Elinimado de la base de datos");
                    strWrite.Close();
                }              
        }          
    }
    catch (System.Exception ex)
    {
        Logger.Error(ex.Message);            
    }
    }

    //eimina al alumnos del archivo csv
    public static List<Alumno> read(string path,int id){

        
        List<Alumno> lista = new List<Alumno>();
        try
        {
            if(File.Exists(path)){

                string[] lines = File.ReadAllLines(path);

                foreach (string line in lines)
                {
                    string [] array = line.Split(',');
                    //Console.WriteLine(line);
                    if (id != Convert.ToInt32(array[0]))
                    {
                        Alumno aux = new Alumno(Convert.ToInt32(array[0]),array[1],array[2],Convert.ToInt32(array[3]));
                        lista.Add(aux);
                    }
                }
               return lista;
            }
            return lista;
        }
        catch (System.Exception ex)
        {
            Logger.Error(ex.Message);
            return null;
        }
    }
}