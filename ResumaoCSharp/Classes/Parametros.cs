using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Text;

namespace ResumaoCSharp.Classes
{
    class Parametros
    {
        public static void ParametrosVariaveis()
        {
            /****************************************************************************************
            *                             PARÂMETROS VARIAVEIS                                      *
            *                                                                                       *
            * Utilizando a palavra-chave 'params', permite que um método receba                     *
            * uma quantidade variável de paramêtros, de 0 a infinito (limite da memória?)           *
            *****************************************************************************************/
            int resultado1 = ContarStrings("É Possivel", "Passar", "Quantos", "Parametros", "Quiser!");
            // resultado = 5

            resultado1 = ContarStrings();
            // resultado = 0

            resultado1 = ContarStringsESomarValor(10, "String", "vazia", 
                "também", "conta", "!", "", "", "");
            // resultado1 = "18"
            /****************************************************************************
            * OBSERVAÇÃO:
            * 
            * Pode-se usar outros parametros não variaveis junto de parametros variaveis,
            * contudo os parametros variaveis devem ser os ultimos na assinatura do método!
            * O uso do params só pode ser no ultimo argumento do método!
            * Exemplo:
            *       ContarStrings(int valor, bool estaAtivo, params int[] numeros) --- OK
            *       ContarStrings(int valor, params int[] numeros, bool estaAtivo) --- ERRO DE COMPILAÇÃO
            *       ContarStrings(params int[] numeros, bool estaAtivo, int valor) --- ERRO DE COMPILAÇÃO
            *****************************************************************************/
        }

        public static int ContarStrings(params string[] variasStrings)
        {
            int quantidadeStrings = 0;
            foreach (var umaString in variasStrings)
            {
                quantidadeStrings++;
            }

            return quantidadeStrings;
        }

        public static int ContarStringsESomarValor(int valor, params string[] strings)
        {
            return ContarStrings(strings) + valor;
        }

        public static void ParametrosNomeados()
        {
            /****************************************************************************************
            *                             PARÂMETROS NOMEADOS                                       *
            *                                                                                       *
            * Ao chamar um método, é possivel designar para cada um dos parametros                  *
            * o que você quer atribuir nesses, fazendo com que não seja necessário manter a ordem   *
            *****************************************************************************************/
            string resultado = DiaFormatado(segundos: 32, mes: 7, horas: 23, ano: 2020, dia: 5, minutos: 57);
            // resultado = ""23:57:32 - 05/07/2020""

            resultado = DiaFormatado(7, 59, ano: 2010, dia: 5, mes: 12, segundos: 3);
            // resultado = "07:59:03 - 05/12/2010"

            /****************************************************************************
            * OBSERVAÇÃO:
            * 
            * Uma vez declarado o nome de um parametro a ser atribuido um valor,
            * todas as próximas declarações (declarações a direita), devem ser nomeadas também!
            * Exemplo:
            *       DiaFormatado(7, 59, ano: 2010, dia: 5, mes: 12, segundos: 3); --- OK
            *       DiaFormatado(ano: 2020, 55, 54, 5, 12, horas: 17); --- ERRO DE COMPILAÇÃO
            *       DiaFormatado(5, 14, ano: 2020, dia: 5, 12, segundos: 57); --- ERRO DE COMPILAÇÃO
            *****************************************************************************/
        }

        public static string DiaFormatado(int horas, int minutos, int segundos, int dia, int mes, int ano)
        {
            return $"{horas:D2}:{minutos:D2}:{segundos:D2} - {dia:D2}/{mes:D2}/{ano}";
        }
    }
}
