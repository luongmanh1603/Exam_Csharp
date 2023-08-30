using GeometryExample;

class Program
{
    static void Main(string[] args)
    {
        Cylinder cylinder = new Cylinder();

        Console.WriteLine("Ứng dụng tính diện tích và thể tích của xi lanh");
        Console.WriteLine("---------------------------------------------");

        cylinder.Process();
        cylinder.Result();
    }
}
