using personagem;

internal class Program
{
    private static void Main(string[] args)
    {
        Personagem p1 = new Personagem();
        Console.WriteLine($"Digite o nome do seu personagem:");
        p1.nome = Console.ReadLine();
        Console.WriteLine($"Digite a idade do seu personagem:");
        p1.idade = int.Parse(Console.ReadLine());
        Console.WriteLine($"Digite o nome da armadura do seu personagem:");
        p1.armadura = Console.ReadLine();
        Console.WriteLine($"Informe a I.A que o personagem utiliza:");
        Console.WriteLine(@$"
{p1.nome}
{p1.idade}
{p1.armadura}
{p1.ia}
");
        p1.Atacar();
        Console.WriteLine(p1.Defender());
        p1.RestaurarArmadura();
    }
}