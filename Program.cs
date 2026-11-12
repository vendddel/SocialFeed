namespace SocialFeed
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;

            TextPost textpost1 = new TextPost("hali a nevem herby", "Herby");
            TextPost textpost2 = new TextPost("hali a nevem asds és hosszú szöveg bla bla bla bla bla bla bla bla bla bla bla bla", "Herby");

            textpost1.Like();
            textpost1.Like();
            textpost1.Like();

            Console.WriteLine(textpost1.GetDescription());
            Console.WriteLine(textpost2.GetDescription());
        }
    }
}
