// приветствие по особенному 
Console.Write("Введите имя ");
String username=Console.ReadLine();
if (username.ToLower()=="надя")
{
    Console.WriteLine("Пипец, это же Надя!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}