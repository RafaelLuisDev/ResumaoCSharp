using System;
using System.Collections.Generic;
using System.Text;

namespace ResumaoCSharp.Classes
{
    class Metodos
    {
        /****************************************************************************************
        *                                     MÉTODOS                                           *
        *                                                                                       *
        * Conforme visto na ClasseSimples...                                                    *
        *                                                                                       *
        * Métodos são os comportamentos, as funções, os algoritmos de uma classe!               *
        * Existem 4 tipos de métodos:                                                           *
        *       - Método sem retorno e sem parâmetro(s)                                         *
        *       - Método com retorno e sem parâmetro(s)                                         *
        *       - Método sem retorno e com parâmetro(s)                                         *
        *       - Método com retorno e com parâmetro(s)                                         *
        *                                                                                       *
        * Agora vamos aprender um pouco mais sobre métodos...                                   *
        *                                                                                       *
        * Todo método tem uma ASSINATURA DE MÉTODO!                                             *
        * Um método pode retornar a própria classe usando palavra reservada 'this',             *
        * isto permite o ENCADEAMENTO DE CHAMADAS DE MÉTODOS!                                   *
        *****************************************************************************************/
        public static void AssinaturaDeMetodo()
        {
            // VERIFIQUE A CLASSE!
            CalculadoraComum calculadoraComum = new CalculadoraComum();

            var resultado = calculadoraComum.Somar(5, 5); // resultado = 10
            resultado = calculadoraComum.Subtrair(2, 7); // resultado = -5
            resultado = calculadoraComum.Multiplicar(4, 4); // resultado = 16
            resultado = calculadoraComum.AoQuadrado(4); // resultado = 16
        }

        public static void EncadeamentoDeChamadasDeMetodos()
        {
            // VERIFIQUE A CLASSE!
            var calculadoraCadeia = new CalculadoraCadeia();

            var resultado = calculadoraCadeia.Resultado(); // resultado = 0
            resultado = calculadoraCadeia.Somar(3).Multiplicar(2).Resultado(); // resultado = 6
            resultado = calculadoraCadeia.Somar(10).Resultado().CompareTo(20); // resultado = -1
            /****************************************************************************
            * OBSERVAÇÃO:
            * 
            * Note que Resultado não retorna o tipo "CalculadoraCadeia" e 
            * por isto tem outros métodos após a chamada deles, métodos da classe 'int'!
            * Note também que 'calculadoraCadeia.Resultado()' retorna 0 pois
            * a variavel 'memoria' é do tipo 'int', que tem valor padrão 0! 
            *****************************************************************************/
        }
    }

    class CalculadoraComum
    {
        /****************************************************************************************
        *                                ASSINATURA DE MÉTODO                                   *
        *                                                                                       *
        * As assinaturas são determinadas pelo nome do método, pelos tipos e                    *
        * pela sua quantidade e ordem dos parâmetros!                                           *
        *****************************************************************************************/

        public int Somar(int a, int b) // Assinatura = Somar(int, int)
        {
            return a + b;
        }
        // Nome do método = Somar
        // Tipos dos parâmetros = inteiro e inteiro
        // Quantidade de parâmetros = 2
        // Ordem dos parâmetros = int, int

        public int Subtrair(int a, int b) // Assinatura = Subtrair(int, int)
        {
            return a - b;
        }

        public int Multiplicar(int a, int b) // Assinatura = Multiplicar(int, int)
        {
            return a * b;
        }

        public int AoQuadrado(int a) // Assinatura = AoQuadrado(int)
        {
            return (int) Math.Pow(a, 2);
        }
        /****************************************************************************
        * OBSERVAÇÃO:
        * 
        * Observe que o tipo de retorno do método não faz parte da assinatura!
        * Desta forma, não é possivel um método com mesma assinatura mas retornos diferentes
        * Exemplo:
        *       public int Somar(int a, int b) --- OK
        *       public double Somar(int c, int d) --- ERRO DE COMPILAÇÃO
        *       
        *****************************************************************************/

    }

    class CalculadoraCadeia
    {
        /****************************************************************************************
        *                       ENCADEAMENTO DE CHAMADAS DE MÉTODOS                             *
        *                                                                                       *
        * Um método pode referenciar sua instância atual (seu objeto) utilizando                *
        * a palavra reservada 'this', podendo então retornar sua instância atual e              *
        * permitindo que retorne o tipo da classe                                               *
        *****************************************************************************************/
        int memoria; // Implicitamente 'private' - assunto será abordado posteriormente...

        public CalculadoraCadeia Somar(int a) // Retorna um tipo que é a própria classe
        {
            memoria += a;
            return this; // Retornando a instância atual (que é um objeto do tipo 'CalculadoraCadeia')
        }

        public CalculadoraCadeia Multiplicar(int a)
        {
            memoria *= a;
            return this;
        }

        public CalculadoraCadeia Limpar()
        {
            memoria = 0;
            return this;
        }

        public int Resultado() // Retornando tipo interno
        {
            return memoria;
        }
    }
}
