using SistemaDeFuncionarios;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Sistema de Funcionarios");
        Console.WriteLine("-----------------------");
        Console.WriteLine(" ");
        
        var fun1 = new Funcionario("Pedro", 26, 2500);
        fun1.Trabalhar();
        fun1.ReceberSalario();
        
        Console.WriteLine("");
        Console.WriteLine("-----------------------");
        Console.WriteLine("");

        var gen1 = new Gerente("Rodolfo", 39, 8000, "Dep014");
        gen1.Trabalhar();
        gen1.ReceberSalario();
        
        Console.WriteLine("");
        Console.WriteLine("-----------------------");
        Console.WriteLine("");

        var dev1 = new Desenvolvedor("Renato", 19, 4600, "Java");
        dev1.Trabalhar();
        dev1.ReceberSalario();
        
        Console.WriteLine("");
        Console.WriteLine("-----------------------");
        Console.WriteLine("");
    }
}