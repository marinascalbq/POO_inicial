namespace ExemploPOO.Models
{
    public class Professor : Pessoa
    {
        public double Salario { get; set; }
        
        public override void Apresentar()
        {
            System.Console.WriteLine($"Olá eu sou a professora e recebo R${Salario} por mês");
        }        
    }
}