namespace Students_Entry
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Entre the arry size : ");
            int input = int.Parse(Console.ReadLine());
            students[] student = new students[input];
            for (int i = 0; i < input; i++)
            {
                student[i] = new students();
                Console.Write($"Entre the name of student {i + 1}: ");
                student[i].name = Console.ReadLine();
                Console.Write($"Entre the age of the student {i + 1}: ");
                student[i].age = int.Parse(Console.ReadLine());
                Console.Write($"Entre the id of student {i + 1}: ");
                student[i].id = int.Parse(Console.ReadLine());
            }
            foreach (var s in student)
            {
                Console.WriteLine(s.name);
                Console.WriteLine(s.age);
                Console.WriteLine(s.id);
                Console.WriteLine("----------------------------------------------------");
            }
        }
    }
}