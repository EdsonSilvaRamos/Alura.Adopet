﻿namespace Alura.Adopet.Console
{
    public class Help
    {
        public void ListaComandos(string[] args)
        {
            System.Console.WriteLine("Lista de comandos.");
            // se não passou mais nenhum argumento mostra help de todos os comandos
            if (args.Length == 1)
            {
                System.Console.WriteLine("adopet help <parametro> ous simplemente adopet help  " +
                     "comando que exibe informações de ajuda dos comandos.");
                System.Console.WriteLine("Adopet (1.0) - Aplicativo de linha de comando (CLI).");
                System.Console.WriteLine("Realiza a importação em lote de um arquivos de pets.");
                System.Console.WriteLine("Comando possíveis: ");
                System.Console.WriteLine($" adopet import <arquivo> comando que realiza a importação do arquivo de pets.");
                System.Console.WriteLine($" adopet show   <arquivo> comando que exibe no terminal o conteúdo do arquivo importado." + "\n\n\n\n");
                System.Console.WriteLine("Execute 'adopet.exe help [comando]' para obter mais informações sobre um comando." + "\n\n\n");
            }
            // exibe o help daquele comando específico
            else if (args.Length == 2)
            {
                var comandoAhSerExibido = args[1];
                if (comandoAhSerExibido.Equals("import"))
                {
                    System.Console.WriteLine(" adopet import <arquivo> " +
                        "comando que realiza a importação do arquivo de pets.");
                }
                if (comandoAhSerExibido.Equals("show"))
                {
                    System.Console.WriteLine(" adopet show <arquivo>  comando que " +
                        "exibe no terminal o conteúdo do arquivo importado.");
                }
                if (comandoAhSerExibido.Equals("list"))
                {
                    System.Console.WriteLine($"adopet list comando que exibe no terminal o conteúdo ");
                }
            }
        }
    }
}
