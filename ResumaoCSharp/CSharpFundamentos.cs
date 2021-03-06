﻿using System;
using System.Dynamic;
using System.Globalization;

namespace ResumaoCSharp
{
    class CSharpFundamentos
    {
        /****************************************************************************
         *                                                                          *
         *    ESSE É UM RESUMÃO PRÁTICO E COMENTADOS SOBRE OS FUNDAMENTOS DO C#     *
         *                                                                          *
         *     CRIADO PARA REFERÊNCIAS RÁPIDAS, ABSORÇÃO E FIXAÇÃO DO CONTEÚDO      *
         *                                                                          *
         ****************************************************************************/
        static void Main(string[] args)
        {
            #region C# - Comentários
            //Isto aqui é um comentário simples - trecho que não será executado!

            /* Este é um 
             * comentário de
             * múltiplas linhas
             */

            /* Este TAMBÉM é um 
               comentário de
               múltiplas linhas... 

               Não há necessidade do colocar os '*' entre os delimitador de comentário
            */

            /// <summary>
            /// Este é um comentário XML - usado acima de métodos/classes/tipos
            /// <summary>
            /// <param name="args"></param>
            void MetodoExemploParaComentarioXML(string[] args) { }
            #endregion

            #region C# - Tipos Internos
            //bool => true ou false
            bool estaChovendo = true;

            //byte => 8 bits sem sinal, valores entre 0 e 255
            byte idade = 45;

            //sbyte => 8 bits com sinal, valores entre -128 e 127
            sbyte saldoDeGols = sbyte.MinValue;

            //short => 16 bits com sinal, valores entre -32768 e 32767
            short salario = short.MaxValue;

            //ushort => 16 bits sem sinal, valores entre 0 e 65535
            ushort menorUShort = ushort.MinValue;

            //int => 32 bits com sinal, valores entre -2147483648 e 2147483647.
            int menorValorInt = int.MinValue;

            //uint => 32 bits sem sinal, valores entre 0 e 4294967295.
            uint populacaoBrasileira = uint.MaxValue;

            //long => 64 bits com sinal, valores entre -9.223.372.036.854.775.808 e 9223372036854775807
            long menorValorLong = long.MinValue;

            //ulong => 64 bits sem sinal, valores entre 0 e 18446744073709551615.
            ulong populacaoMundial = 7_600_000_000;
            /****************************************************************************
             * OBSERVAÇÃO:
             * 
             * O uso de underscore/underline (_) nos números serve somente 
             * para dar clareza na leitura, é um separador de milhares.
             * 7_600_000_000 = 7600000000
             *****************************************************************************/


            //float => ponto flutuante de precisão de 32 bits
            float precoComputador = 1299.99f;
            /****************************************************************************
             * OBSERVAÇÃO:
             * 
             * Necessário colocar o 'f' ou 'F' ao final para informar que este número é um float, 
             * por padrão, todos valores com casas decimais são do tipo double!
             *****************************************************************************/

            //double => ponto flutuante de precisão de 64 bits
            double valorDeMercadoDaApple = 1_000_000_000_000.00;

            //decimal => valores realmente muito grandes, astronomicos
            decimal distanciaEntreEstrelas = decimal.MaxValue;

            //char => uma letra, somente UMA letra! (16 bits sem sinal correspondendo ao conjunto de caracteres UNICODE)
            char letra = 'b';

            //string => texto, cadeia de caracteres, herda de object!
            string texto = "Seja bem vindo ao Curso de C#!";

            #endregion

            #region C# - Tipo 'var' (Inferência)
            /****************************************************************************
             * Ao usar 'var', o C# automaticamente vai interpretar 
             * o tipo de acordo com o tipo inicializado, ele INFERE a partir da inicialização
             * 
             * Não é possivel iniciar um 'var' sem ser inicializado!
             *****************************************************************************/

            var variavelInt = 1; // var = int
            var variavelString = "Texto"; // var = string
            var variavelClass = new Object(); // var = Object

            // var variavelImpossivel; ====> var = ?; --- ERRO DE COMPILAÇÃO
            // var variavelImpossivel = null; ====> var = ? --- ERRO DE COMPILAÇÃO

            #endregion

            #region C# - Concatenação e Interpolação de Strings
            string nome = "Notebook";
            string marca = "Dell";
            double preco = 5999.99;

            string concatenacaoString = "O " + nome + " da marca " + marca + " custa " + preco + "."; // concatenacaoString = "O Notebook da marca Dell custa 5999,99."
            string formatacaoComposta = string.Format("O {0} da marca {1} custa {2}.", nome, marca, preco); // formatacaoComposta = "O Notebook da marca Dell custa 5999,99."
            string interpolacaoString = $"O {nome} da marca {marca} custa {preco}."; // interpolacaoString = "O Notebook da marca Dell custa 5999,99."
            string interpolacaoString2 = $"1 + 1 = {1 + 1}!"; // interpolacaoString2 = "1 + 1 = 2!"

            #endregion

            #region C# - Notação Ponto e Navegação Segura
            /****************************************************************************
             * Notação Ponto é basicamente a concatenação de chamadas de métodos e/ou atributos
             * 
             * Navegação segura é usa a interrogação (?) para evitar acessar coisas vazias (null)!
             *****************************************************************************/
            var saudacao = "olá".ToUpper().Insert(3, " World!").Replace("World!", "Mundo!"); // saudacao = "OLÁ Mundo!";

            string teste = null;
            // Este irá gerar um erro em tempo de execução
            // Não é possivel verificar o tamanho de null
            //string tamanhoTeste = $"O tamanho do teste é: {teste.Length}"; 

            // Este irá executar normalmente, gerando a frase "O tamanho do teste é: "
            // Não causará erro pois não executará o .Lenght
            string tamanhoTeste2 = $"O tamanho do teste é: {teste?.Length}";
            #endregion

            #region C# - Formatação
            /****************************************************************************
             * Formatação Docs: https://docs.microsoft.com/pt-br/dotnet/standard/base-types/formatting-types
             *****************************************************************************/
            double valor = 15.175;

            // formata as casas decimais (arredonda se necessario)
            string valorFixedPoint = valor.ToString("F1"); // valorFixedPoint = "15.2"

            // formata para valor monetário (de acordo com o Sistema Operacional)
            string valorCurrency = valor.ToString("C"); // valorCurrency = "R$ 15,18" 

            // formata para percentual (formata multiplicando por 100)
            string valorPercent = valor.ToString("P"); // valorPercent = "1.517,50%"

            // formata personalizado 
            string valorPersonalizado = valor.ToString("#.##"); // valorPersonalizado = "15,18"

            // formata de acordo com a cultura/pais/região
            CultureInfo culturaUS = new CultureInfo("en-US"); // Cultura Norte Americana
            CultureInfo culturaBR = new CultureInfo("pt-BR"); // Cultura Brasileira
            string valorCulturaUS = valor.ToString("C0", culturaUS); // valorCulturaUS = "$15"
            string valorCulturaBR = valor.ToString("C2", culturaBR); // valorCulturaBR = "R$ 15,18"

            // formata com zeros a esquerda
            int inteiro = 256;
            string zerosAEsquerda = inteiro.ToString("D10"); // zerosAEsquerda = "0000000256"


            #endregion

            #region C# - Conversões, Cast e Parse
            // Conversão implicita - O C# implicitamente converte pois 'int' cabe em 'double'
            int numInteiro = 10;
            double quebrado = numInteiro; // quebrado = 10

            // Conversão explicita - O C# não faz a conversão pois pode haver perder de informação
            // Assim, devemos explicitamente converter, fazer um CAST! 
            double nota = 9.7;
            int notaTruncada = (int)nota; // notaTruncada = 9

            // Conversão string para número
            string idadeString = "23";
            int idadeInteiro = int.Parse(idadeString); // idadeInteiro = 23
            int idadeInteiro2 = Convert.ToInt32(idadeString); // idadeInteiro = 23
            /****************************************************************************
             * OBSERVAÇÃO:
             * 
             * Se a string não for um número, ocorrerá um erro em tempo de execução!
             * Exemplo:
             *      string idadeString = "adsfasdfsfs";
             *****************************************************************************/

            // Conversão MAIS SEGURA string para número
            string palavra = "teste";
            int numero;

            // TryParse() => Tenta fazer um parse, se não conseguir, atribui valor padrão, no caso do int é 0
            // O 'out' serve para jogar o resultado dentro da variável numero
            int.TryParse(palavra, out numero);

            #endregion

            #region C# - Operadores Aritméticos (+ - * / %)
            var soma = 1 + 1; // soma = 2
            var soma2 = soma + 10.2; // soma2 = 12.2

            var sub = 1 - 5; // sub = -4
            var sub2 = soma2 - sub; // sub2 = 16.2

            var mult = 5 * 5; // mult = 25
            var mult2 = 2 * mult; // mult2 = 50

            var div = mult / soma; // div = 12 (truncado)
            var div2 = soma / 2; // div = 1

            var potencia = Math.Pow(soma, 2); // potencia = 4

            //Operador módulo - resto da divisão
            var par = 2 % 2; // par = 0
            var impar = 3 % 2; //impar = 1

            // Precedência de operadores - Primeiro módulo, depois divisão e multiplicação, depois soma e divisão
            var todosOperadoresAritmeticos = Math.Pow(10 + 50 / 5 - 10 * 3 % 3, 2);
            #endregion

            #region C# - Operadores Relacionais (> >= < <= == !=)
            double valorNumerico = 5;

            bool maiorQue = valorNumerico > 5; // maiorQue = false
            bool maiorOuIgualQue = valorNumerico >= 5; // maiorOuIgualQue = true 
            bool menorQue = valorNumerico < 5; // menorQue = false
            bool menorOuIgualQue = valorNumerico <= 5; // menorOuIgualQue = true 
            bool igualQue = valorNumerico == 5; // igualQue = true
            bool diferenteDe = valorNumerico != 5; // diferenteDe = false
            #endregion

            #region C# - Operadores Logicos (|| && ^ !)
            bool operando1 = true;
            bool operando2 = false;

            bool operadorNegacao = !operando1; // operadorNegacao = !true (= false)

            bool operadorE = operando1 && operando2; // operadorE = false
            bool operadorOu = operando1 || operando2; // operadorOu = true
            bool operadorOuExclusivo = operando1 ^ operando2; // operadorOuExclusivo = true
            #endregion

            #region C# - Operadores de Atribuição (= += -= *= /= ++ --)
            //atribuição simples e direta - cria variavel e inicializa atribuindo um literal
            var num1 = 50;
            
            //atribuição simples - variavel já existe, simplesmente atribui um literal
            num1 = 5;

            //atribuição aditiva - variavel recebe ela mesma e soma um literal
            num1 += 10; // num1 = num1 + 10
            
            //atribuição subtrativa - variavel recebe ela mesma e subtrai um literal
            num1 -= 10; // num1 = num1 - 10
            
            //atribuição multiplicativa - variavel recebe ela mesma e multiplica por um literal
            num1 *= 2; // num1 = num1 * 10
            
            //atribuição divisiva - variavel recebe ela mesma e é dividido por um literal
            num1 /= 2; // num1 = num1 / 10

            //atribuição incremental pós-fixada - atribuição ocorre após a operação
            num1++; // num1 = num1 + 1
            //atribuição incremental prefixada - atribuição ocorre antes da operação
            ++num1; // num1 = num1 + 1

            //atribuição decremental pós-fixada - atribuição ocorre após a operação
            num1--; // num1 = num1 - 1
            //atribuição decremental prefixada - atribuição ocorre antes da operação
            --num1; // num1 = num1 - 1
            /****************************************************************************
            * OBSERVAÇÃO:
            * 
            * Pós-fixada => ocorre depois da "leitura" da variavel
            * Prefixada => ocorre antes da "leitura" da variavel
            * 
            * Exemplo: 
            *       int x = 10;
            *       Console.WriteLine(x++) // x = 10
            *       Console.WriteLine(x) // x = 11
            *       x = 10;
            *       Console.WriteLine(++x) // x = 11
            *****************************************************************************/

            //atribuição de outra variavel - ATENÇÃO AO TIPO DE ATRIBUIÇÃO!!!
            var numA = num1; // ATRIBUIÇÃO POR CÓPIA | num1 = 5

            dynamic varA = new ExpandoObject();
            varA.nome = "String";

            dynamic varB = varA; // ATRIBUIÇÃO POR REFERÊNCIA
            varB.nome = "Mudou a string de varA!"; // varA.nome = "Mudou a string de varA"
            /****************************************************************************
            * OBSERVAÇÃO:
            * 
            * Existem dois tipos de atribuição quando se atribui de outra variavel:
            *       - Atribuição POR CÓPIA
            *       - Atribuição POR REFERÊNCIA
            * 
            * Este assunto será abordado posteriormente, o intuito aqui é mostrar que
            * é possivel se atribui a uma variavel outra variavel.
            *****************************************************************************/
            #endregion]

            #region C# - Operador de Inversão de Sinal e Operador Ternário (- ?)
            //Operador de Inversão de Sinal
            var numeroPositivo = 10;
            var numeroNegativo = -20;
            var inversaoDeSinal = -numeroPositivo; // inversaoDeSinal = -10;
            inversaoDeSinal = -numeroNegativo; // inversaoDeSinal = 20;

            //Operador Ternário - Se 'true', atribui primeiro valor, se 'false', atribui o segundo valor
            var operadorTernario = numeroPositivo > 5 ? "Primeiro" : "Segundo"; // operadorTernario = "Primeiro"
            operadorTernario = numeroPositivo > 20 ? "Primeiro" : "Segundo"; // operadorTernario = "Segundo"
            #endregion

            #region C# - Estruturas de Controle (If/Else Switch While Do/While For Foreach Break Continue)
            //Controle condicional If/Else
            var numC = 5;
            string resultadoIf;

            if (numC > 10) 
                resultadoIf = "numC maior que 10";
            else 
                resultadoIf = "numC não é maior que 10";

            //Controle condicional If/Else If
            if (numC > 5)
            {                                                                     
                resultadoIf = "numC ";
                resultadoIf += "maior que 5"; 
            }
            else if (numC > 10)
                resultadoIf = "numC maior que 10";
            else
            {
                resultadoIf = "numC não é maior que 10 mas é maior que 5";
            }
            /****************************************************************************
            * OBSERVAÇÃO:
            * 
            * Utilizar as chaves { } quando houver mais de uma 
            * sentença de código para ser executada dentro do If/Else.
            *****************************************************************************/

            //Controle condicional Switch
            switch (numC)
            {
                case 1:
                    resultadoIf = "numC é 1";
                    break;
                case 2:
                case 3:
                case 4:
                    resultadoIf = "numC é 2 ou 3 ou 4";
                    break;
                case 5:
                    resultadoIf = "numC é 5";
                    break;
                default:
                    resultadoIf = "numC é um numero diferente de 1, 2, 3, 4 e 5";
                    break;
            }

            //Controle de repetição While 
            bool chegouAoNum10 = false;
            while(chegouAoNum10) // CUIDADO COM LOOPS INFINITOS
            {
                if (numC == 10)
                    chegouAoNum10 = true;
                else if (numC > 10)
                    numC--;
                else
                    numC++;
            }

            //Controle de repetição Do/While
            numC = new Random().Next(0, 50); // número aleatório entre 0 e 50
            chegouAoNum10 = false;
            do
            {
                if (numC == 10)
                    chegouAoNum10 = true;
                else if (numC > 10)
                    numC--;
                else
                    numC++;
            }
            while (chegouAoNum10); // CUIDADO COM LOOPS INFINITOS

            //Controle de repetição For
            string resultado1 = "";
            for (int i = 0; i < 10; i++)// CUIDADO COM LOOPS INFINITOS
            {
                resultado1 += ($"{i}"); 
            }
            //resultado1 = "01233456789"

            string resultado2 = "";
            for (int i = 0, j = 1; i < 10 && j < 6; i++, j++) // pode ter multiplas variaveis de controle
            {
                resultado2 += ($"{i} {j}");
            }
            //resultado2 = "0 11 22 33 44 5"

            //Controle de repetição Foreach
            string resultado3 = "";
            string string1 = "esta string será percorrida caractere a caractere";
            foreach (char caractere in string1)
            {
                resultado3 += caractere;
            }
            //resultado3 = "esta string será percorrida caractere a caractere"

            string resultado4 = "";
            string[] arrayString = new string[] { "Foreach", "percorre", "elemento", "a", "elemento" };
            foreach (var elementoString in arrayString)
            {
                resultado4 += elementoString;
            }
            //resultado4 = "Foreachpercorreelementoaelemento"


            //Controle de Interrupção de repetição Break
            string resultado5 = "";
            for (int i = 0; i < 30; i++)
            {
                if (i > 18)
                    break;
                resultado5 += $"{i} ";
            }
            // resultado5 = "0 1 2 3 4 5 6 7 8 9 10 11 12 13 14 15 16 17 18 "

            //Controle de continuação de repetição Continue
            string resultado6 = "";
            for (int i = 0; i < 30; i++)
            {
                if (i > 8 &&  i < 20)
                    continue;
                resultado6 += $"{i} ";
            }
            // resultado5 = "0 1 2 3 4 5 6 7 8 20 21 22 23 24 25 26 27 28 29 "
            #endregion

            /****************************************************************************
             *                                                                          *
             *                 POO - PROGRAMAÇÃO ORIENTADA A OBJETOS                    *
             *                                                                          *
             ****************************************************************************/

            OrientacaoAObjetos.MainPOO();
        }
    } 
}   