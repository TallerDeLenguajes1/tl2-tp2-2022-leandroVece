using System;
internal class Program
{
    private static readonly NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();
    private static void Main(string[] args)
    {
        /*string name, surname;
        int id, dni, curso;
        try
        {
            
            Console.WriteLine("Cargue los datos de Alumno\nIdentificador personal");
            id = int.Parse(Console.ReadLine());

            Console.WriteLine(" 1- nombre");        
            name = Console.ReadLine();

            Console.WriteLine("2- apellido");
            surname = Console.ReadLine();

            Console.WriteLine("3- DNI");
            dni = int.Parse(Console.ReadLine());

            Console.WriteLine("4- Curso incripto 1)Atletismo 2)Voley 3)Futbool");
            curso = int.Parse(Console.ReadLine());;

            Alumno alumno = new Alumno(id, name, surname, dni, curso);

            //selecciona la base de datos de acuerdo a un valor numerico en el curso del alumno
            switch (alumno.Curso)
            {
                case 1: 
                    helpArchivo.save(@"registros\Atletismo.csv",alumno);
                    break;
                case 2: 
                    helpArchivo.save(@"registros\Voley.csv",alumno);
                    break;
                case 3: 
                    helpArchivo.save(@"registros\Futbool.csv",alumno);
                    break;
                default:
                    break;
            }
        }
        catch (Exception ex)
        {
            Logger.Error(ex.Message);
        }*/

        try
        {

            List<Alumno> newList = helpArchivo.read(@"registros\Atletismo.csv",1);
            helpArchivo.delete(@"registros\Atletismo.csv",newList);
            
        }
        catch (System.Exception ex)
        {
            
            Logger.Error(ex.Message);
        }
        
    }
}