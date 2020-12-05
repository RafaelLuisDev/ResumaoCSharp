using System;
using System.Collections.Generic;
using System.Text;

namespace ResumaoCSharp.Classes
{
    /****************************************************************************************
    * Dentro de um namespace, pode-se ter várias classes                                    *
    * Cada arquivo '.cs' pode ter uma ou mais classes dentro                                *
    * Ou seja, pode-se ter uma classe por arquivo ou um único arquivo com várias classes    *
    *                                                                                       *
    * ISSO É UMA QUESTÃO DE ORGANIZAÇÃO DE CÓDIGO!                                          *
    *****************************************************************************************/
    class ClasseSimples
    {
        public static void EntendendoClasses()
        {
            // A palavra-chave 'new' instancia um objeto da classe
            ClasseQualquer classe1 = new ClasseQualquer(); // 'classe1' é uma instância, um objeto de 'ClasseSimples']
            classe1.Nome = "Rafael Luis";
            classe1.Numero = 1;
            var textoRetornadoDoMetodo = classe1.InformacoesDaClasseSimples();
            // textoRetornadoDoMetodo = "Rafael Luis 1"

            classe1.Nome = "Trocou o nome!";
            classe1.SomarAoNumero(10);
            textoRetornadoDoMetodo = classe1.InformacoesDaClasseSimples();
            // textoRetornadoDoMetodo = "Trocou o nome! 11"

            classe1.LimparAtributos();
            textoRetornadoDoMetodo = classe1.InformacoesDaClasseSimples();
            // textoRetornadoDoMetodo = " 0"

            textoRetornadoDoMetodo = classe1.MensagemRepetida("BBBlabla", 3);
            // textoRetornadoDoMetodo = "BBBlablaBBBlablaBBBlabla"
        }
    }

    class ClasseQualquer
    {
        /****************************************************************************************
        * Os membros de uma classe são basicamente divididos em atributos e métodos             *
        *****************************************************************************************/

        #region Atributos
        /****************************************************************************************
        * Atributos são basicamente os dados de uma classe                                      *
        *****************************************************************************************/
        public string Nome;
        public int Numero;
        #endregion

        #region Métodos
        /****************************************************************************************
        * Métodos são os comportamentos, as funções, os algoritmos de uma classe                *
        * Existem 4 tipos de métodos:                                                           *
        *       - Método sem retorno e sem parâmetro(s)                                         *
        *       - Método com retorno e sem parâmetro(s)                                         *
        *       - Método sem retorno e com parâmetro(s)                                         *
        *       - Método com retorno e com parâmetro(s)                                         *
        *****************************************************************************************/

        // Método sem retorno (retorna void) e sem parâmetro(s)
        public void LimparAtributos()
        {
            Nome = "";
            Numero = 0;
        }

        // Método com retorno (retorna string) e sem parâmetro(s)
        public string InformacoesDaClasseSimples()
        {
            return $"{Nome} {Numero}";
        }

        // Método sem retorno e com parâmetro(s) (parâmetro int num)
        public void SomarAoNumero(int num)
        {
            Numero += num;
        }

        // Método com retorno (retorna string) e com parâmetro(s) (parametros string msg e int repeticoes)
        public string MensagemRepetida(string msg, int repeticoes)
        {
            string mensagemRetornada = "";
            if (repeticoes <= 0)
                mensagemRetornada = "Repetições deve ser positivo";
            else
                for (int i = 0; i < repeticoes; i++)
                {
                    mensagemRetornada += msg;
                }

            return mensagemRetornada;
        }
        #endregion
    }
}