using System;
using System.IO;
using ExemploPOO.Helper;
using ExemploPOO.Models;

namespace ExamploPOO
{
    class Program
    {
        static void Main (string[] args) 
        {
            var caminho = "C:\\TrabalhandoComArquivos";
            var caminhoPathCombine = Path.Combine(caminho, "Pasta teste 1");
            var caminhoArquivo = Path.Combine(caminho, "Arquivo-teste-stream.txt");
            var caminhoArquivoTeste = Path.Combine(caminho, "Arquivo-teste.txt");
            var caminhoArquivoTesteCopia = Path.Combine(caminho, "Arquivo-teste-bkp.txt");
            var novoCaminhoArquivo = Path.Combine(caminho,"Pasta teste 2", "Arquivo-teste-stream.txt");
            var listaString = new List<string> {"Linha 1", "Linha 2", "Linha 3" };
            var listaStringContinuacao = new List<string> {"Linha 4", "Linha 5", "Linha 6" };
            

            FileHelper helper = new FileHelper();
            //helper.ListarDiretorios(caminho);
            //helper.ListarArquivosDiretorios(caminho);
            //helper.CriarDiretorio(caminhoPathCombine);
            //helper.ApagarDiretorio(caminhoPathCombine, true);
            //helper.CriarArquivoTexto(caminhoArquivo, "Marina é linda e esse é um teste de escrita de arquivo");
            // helper.CriarArquivoTextoStream(caminhoArquivo, listaString);
            // helper.AdicionarTextoStream(caminhoArquivo, listaStringContinuacao);
            //helper.LerArquivoStream(caminhoArquivo);
            //helper.MoverArquivo(caminhoArquivo, novoCaminhoArquivo, false);
            //helper.CopiarArquivo(caminhoArquivoTeste, caminhoArquivoTesteCopia, false);
            helper.DeletarArquivo(caminhoArquivoTesteCopia);

            

            // iCalculadora calc = new Calculadora();
            // System.Console.WriteLine(calc.Somar(10,20));

            // Computador comput = new Computador();
            // System.Console.WriteLine(comput.ToString());

            // Corrente c = new Corrente();
            // c.Creditar(100);
            // c.ExibirSaldo();
         
            // Calculadora calc = new Calculadora();
            // System.Console.WriteLine("Resultado da soma de 2 números: " + calc.Somar(10,10));
            // System.Console.WriteLine("Resultado da soma de 3 números: " + calc.Somar(10,10,10));

            // Aluno p1 = new Aluno();
            // p1.Nota = 10;
            // p1.Nome = "Marina";
            // p1.Documento = "132132";
            // p1.Idade = 28;
            // p1.Apresentar();

            // Professor p2 = new Professor();
            // p2.Nome= "Marina Professora";
            // p2.Documento = "969875";
            // p2.Idade = 35;
            // p2.Salario = 3000;
            // p2.Apresentar();

            // //valores válidos
            // Retangulo r = new Retangulo ();
            // r.DefinirMedidas (30,30);
            // System.Console.WriteLine($"A área do retangulo é {r.ObterArea()}");
           
            // //valores inválidos
            // Retangulo r2 = new Retangulo ();
            // r.DefinirMedidas (0,-3);
            // System.Console.WriteLine($"A área do retangulo é {r2.ObterArea()}");


            // Pessoa p1 = new Pessoa ();
            // p1.Nome = "Marina";
            // p1.Idade = 27;
            // p1.Apresentar ();
        }
    } 


}