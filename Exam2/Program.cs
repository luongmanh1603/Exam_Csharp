using Exam2;

class Program
{
    static void Main(string[] args)
    {
        Lion lion = new Lion(200, "Simba");
        Tiger tiger = new Tiger(150, "Rajah");

        Animal[] animals = { lion, tiger };

        foreach (var animal in animals)
        {
            animal.Show();
        }
    }
}