namespace SistemaDeFuncionarios;

public class Desenvolvedor : Funcionario
{
    
    // Propeties
    protected string Linguagem { get; set; }
    
    // Constructor
    public Desenvolvedor(string nome, int idade, double salario, string linguagem) : base(nome, idade, salario)
    {
        Linguagem = linguagem;
    }
    
    // Methods
    public override void Trabalhar()
    {
        Console.WriteLine($"O Desenvolvedor {Nome} iniciou o seu turno programando em {Linguagem}");
    }
    
    public override void ReceberSalario()
    {
        Console.WriteLine($"O salario foi pago ao Desenvolvedor {Nome}! R${Salario} Foram depositas na conta.");
    }
    
}