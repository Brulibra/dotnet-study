using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_study.Models.ModuleTwo
{
    public class ErrorHandler
    {
        public void ExceptionsTest()
        {
            //Para leitura de arquivos, cada linha pode ser entendida como um string
            //File.ReadAllLines é um método que faz essa conversão


            try
            {
                string[] lines = File.ReadAllLines("Files/readingFile.txt");

                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            catch (FileNotFoundException error)
            {
                Console.WriteLine($"O arquivo não foi encontrado  {error.Message}");
            }
            catch (DirectoryNotFoundException error)
            {
                Console.WriteLine($"Caminho não encontrado  {error.Message}");
            }
            catch (UnauthorizedAccessException error)
            {
                Console.WriteLine($"Você não tem autorização para ler o arquivo  {error.Message}");
            }
            catch (Exception error)
            {
                Console.WriteLine($"Não foi possível abrir o arquivo  {error.Message}");
            }
            finally
            {
                Console.WriteLine("Obrigada pela Leitura!");
            }
        }
        public void methodOne()
        {
            methodTwo();
        }
        public void methodTwo()
        {

            try
            {

                methodThree();
            }
            catch (Exception error)
            {

                Console.WriteLine(error.Message);
            }
        }
        public void methodThree()
        {

            methodFour();
        }
        public void methodFour()
        {
            throw new Exception("Ocorreu uma exceção");
        }

    }

}