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
            Console.WriteLine($"Score: {textpost1.Score()}");

            Console.WriteLine(textpost1.GetDescription());
            Console.WriteLine(textpost2.GetDescription());

            Console.WriteLine("----------------------------------------------------------");
            ImagePost imagepost1 = new ImagePost(3, "Herby");
            imagepost1.Like();
            imagepost1.Like();
            imagepost1.Like();
            imagepost1.Like();
            imagepost1.Like();
            Console.WriteLine($"max score: {imagepost1.Score()}");
            Console.WriteLine(imagepost1.GetDescription());


            ImagePost imagepost2 = new ImagePost(15, "Vendel");
            Console.WriteLine(imagepost2.GetDescription());


        }
    }
}
