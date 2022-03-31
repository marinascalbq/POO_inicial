namespace ExemploPOO.Models
{
    public class Aluno : Pessoa
    {
        public int Nota { get; set; }   

        public override void Apresentar()
        {
            System.Console.WriteLine($"Olá eu tirei nota {Nota} na prov");
        }
    }
}