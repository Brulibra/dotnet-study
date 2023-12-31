using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_study.Interface
{
    public interface ICalculadora
    {
        int Somar(int num1, int num2);
        int Subtrair(int num1, int num2);
        int Multiplicar(int num1, int num2);
        int Dividir(int num1, int num2)
        {
            return num1 / num2;
        }

        //Não tem public, private, os acessores
        //por padrão subentende que é publica
        //não tem implementação {}, só a descrição dos métodos
        //tipo de retorno INT, nome, e PARAMETROS

    }
}