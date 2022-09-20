Console.Write("Введите имя: ");
string username = Console.ReadLine();
if (username.ToLower() == "саша")
{
    Console.WriteLine("Ура! Это ты?");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}