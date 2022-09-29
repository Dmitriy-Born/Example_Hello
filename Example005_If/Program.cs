Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if (username.ToLower() == "маша")
{
    Console.Write("Отдельный привет для Маши");
}
else
{
    Console.Write("Имя пользователя: " + username);
}