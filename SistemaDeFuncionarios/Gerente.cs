namespace SistemaDeFuncionarios;

public class Gerente : Funcionario
{
    // Propeties
    protected string Departamento { get; set; }
    
    // Constructor
    public Gerente(string nome, int idade, double salario, string departamento) : base(nome, idade, salario)
    {
        Departamento = departamento;
    }
    
    // Methods
    public override void Trabalhar()
    {
        Console.WriteLine($"O Gerente {Nome} está gerenciando o departamento {Departamento}");
    }
    
    public override void ReceberSalario()
    {
        Console.WriteLine($"O salario foi pago ao gerente {Nome}! R${Salario} Foram depositas a conta.");
    }
}