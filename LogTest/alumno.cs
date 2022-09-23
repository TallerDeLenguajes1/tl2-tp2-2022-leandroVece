public class Alumno
{
    private int id;
    private string nombre;
    private string apellido;
    private int dni;
    private int curso;

    public int Id { get => id; set => id = value; }
    public string Nombre { get => nombre; set => nombre = value; }
    public string Apellido { get => apellido; set => apellido = value; }
    public int Dni { get => dni; set => dni = value; }
    public int Curso { get => curso; set => curso = value; }


    public Alumno(int id, string name, string surname, int dni, int curso){
        this.Id = id;
        this.Nombre = name;
        this.Apellido = surname;
        this.Dni = dni;
        this.Curso = curso;
    }
    public Alumno(int id, string name, string surname, int dni){
        this.Id = id;
        this.Nombre = name;
        this.Apellido = surname;
        this.Dni = dni;
        this.Curso = curso;
    }

    

}