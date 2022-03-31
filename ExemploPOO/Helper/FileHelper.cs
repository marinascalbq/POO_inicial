using System.IO;
using System.Collections.Generic;

namespace ExemploPOO.Helper
{
    public class FileHelper
    {
        public void ListarDiretorios(string caminho)
        {
            var retornoCaminho = Directory.GetDirectories(caminho,"*", SearchOption.AllDirectories);
            
            foreach (var retorno in retornoCaminho)
            {
                System.Console.WriteLine(retorno);
            }
        }

        public void ListarArquivosDiretorios( string caminho)
        {
            var retornoArquivos = Directory.GetFiles(caminho, "*2*", SearchOption.AllDirectories);
            
            foreach (var retorno in retornoArquivos)
            {
                System.Console.WriteLine(retorno);
            }            
        }

        public void CriarDiretorio(string caminho)
        {
           var retorno =  Directory.CreateDirectory(caminho);
           System.Console.WriteLine(retorno.FullName);
        }

        public void ApagarDiretorio (string caminho, bool ApagarArquivos)
        {
            Directory.Delete(caminho, ApagarArquivos);
        }

        public void CriarArquivoTexto (string caminho, string conteudo)
        {
            if (!File.Exists(caminho))
            {
                File.WriteAllText(caminho, conteudo);
            }
        }

        public void CriarArquivoTextoStream(string caminho, List<string> conteudo)
        {
            using (var stream = File.CreateText(caminho))
            {
                foreach (var linha in conteudo)
                {
                  stream.WriteLine(linha);
                }
            }   
        }
        public void adicionarTexto( string caminho, string conteudo)
        {
            File.AppendAllText(caminho, conteudo);
        }

        public void AdicionarTextoStream(string caminho, List<string> conteudo)
        {
            using (var stream = File.AppendText(caminho))
            {
                foreach (var linha in conteudo)
                {
                  stream.WriteLine(linha);
                }
            }   
        }

        public void LerArquivo(string caminho)
        {
           var conteudo = File.ReadAllLines(caminho);

           foreach (var linha in conteudo)
           {
               System.Console.WriteLine(linha);
           } 
        }

        public void LerArquivoStream (string caminho)
        {
            string linha = string.Empty;

            using (var stream = File.OpenText(caminho) )
            {
                while ((linha = stream.ReadLine()) !=null)
                {
                    System.Console.WriteLine(linha);
                }                
            }
        }

        public void MoverArquivo (string caminho, string NovoCaminho, bool sobrescrever)
        {
            File.Move(caminho, NovoCaminho);
        }

        public void CopiarArquivo(string caminho, string NovoCaminho, bool sobrescrever)
        {
            File.Copy(caminho, NovoCaminho, sobrescrever);
        }

        public void DeletarArquivo( string caminho)
        {
            File.Delete(caminho);
        }
    }
}