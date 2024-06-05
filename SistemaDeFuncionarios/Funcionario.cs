namespace SistemaDeFuncionarios;

public class Funcionario
{
    // Propriedades
    protected string Nome { get; set; }
    protected int Idade { get; set; }
    protected double Salario { get; set; }
    
    // Construtor
    public Funcionario(string nome, int idade, double salario)
    {
        Nome = nome;
        Idade = idade;
        Salario = salario;
    }
    
    // Métodos
    public virtual void Trabalhar()
    {
        Console.WriteLine($"O Funcionario {Nome} iniciou o seu turno de trabalho!");
    }

    public virtual void ReceberSalario()
    {
        Console.WriteLine($"O salario foi pago ao funcionario {Nome}! R${Salario} Foram depositas a conta.");
    }
}