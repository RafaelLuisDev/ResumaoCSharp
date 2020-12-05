using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Text;

namespace ResumaoCSharp.Classes
{
    class MembrosEstaticos
    {
        /****************************************************************************************
        *                               MEMBROS ESTÁTICOS                                       *
        *                                                                                       *
        * Basicamente, membros estáticos são atributos e métodos que não precisam de instância, *
        * Ou seja, são membros que pertencem a classe e não mais a instância da classe!         *
        * Não precisa criar uma instância, um objeto da classe para usar o atributo/método      *
        *****************************************************************************************/
        public static void MetodoEstatico()
        {
            /****************************************************************************************
            *                               MÉTODO ESTÁTICO                                         *
            *                                                                                       *
            * Os métodos estáticos são chamados diretamente atráves da classe,                      *
            * não precisam de uma instância, de um objeto da classe para serem chamados             *
            *****************************************************************************************/
            CalculadoraComMetodoStatic calc = new CalculadoraComMetodoStatic();
            var resultado = calc.Somar(2, 3); // resultado = 5
            
            resultado = CalculadoraComMetodoStatic.Multiplicar(2, 2); // resultado = 4
            /****************************************************************************
            * OBSERVAÇÃO:
            * 
            * Note que não é possivel usar o método 'Somar' sem ser pela instância da classe,
            * bem como também não é possivel usar o método 'Multiplicar' 
            * pelo objeto ('calc') da classe 'CalculadoraComMetodoStatic'
            *****************************************************************************/
        }

        public static void AtributoEstatico()
        {
            /****************************************************************************************
            *                               ATRIBUTO ESTÁTICO                                       *
            *                                                                                       *
            * Os atributos estáticos são chamados diretamente atráves da classe,                    *
            * ficando vinculados a classe e não as instâncias da classe,                            *
            * ou seja, todas alterações de um atributo estático, alteram todas instâncias da classe *
            *****************************************************************************************/
            ClasseComAtributoStatic classe1 = new ClasseComAtributoStatic();
            classe1.Nome = "Eu tenho Static";
            classe1.Numero = 0.9582;
            // classe1.Valor não pode ser acessado pela instância da classe!

            ClasseComAtributoStatic classe2 = new ClasseComAtributoStatic()
            {
                Nome = "Teste",
                Numero = 123.45
                // Valor não pode ser acessado pela instância da classe!
            };

            var info = classe1.InformacoesDaClasseComAtributoStatic();
            // info = "Nome: Eu tenho Static, Numero: 0,9582, Valor: 555"

            info = classe2.InformacoesDaClasseComAtributoStatic();
            // info = "Nome: Teste, Numero: 123,45, Valor: 555"

            ClasseComAtributoStatic.Valor = 98765; // Acessando valor diretamente pela classe

            info = classe1.InformacoesDaClasseComAtributoStatic();
            // info = "Nome: Eu tenho Static, Numero: 0,9582, Valor: 98765"
            info = classe2.InformacoesDaClasseComAtributoStatic();
            // info = "Nome: Teste, Numero: 123,45, Valor: 98765"
        }

        public static void Problematica_AcessarAtributoDaClasseComMetodoEstatico ()
        {
            // Como acessar um atributo de instância através de método estático?
            var info = AcessarAtributo.Acesso();
            // info = "Acessou atributo de instância!"
        }
    }

    public class CalculadoraComMetodoStatic
    {
        public static int Multiplicar(int a, int b) // Método de Classe ou Método estático!!!
        {
            return a * b;
        }

        public int Somar(int a, int b) // Método de instância!!!
        {
            return a + b;
        }
    }

    public class ClasseComAtributoStatic
    {
        public string Nome; // atributo de instância
        public double Numero; // atributo de instância
        public static int Valor = 555; // ATRIBUTO DE CLASSE (Não mais de instância)

        public string InformacoesDaClasseComAtributoStatic()
        {
            return $"Nome: {this.Nome}, Numero: {Numero}, Valor: {Valor}"; // this.Valor não existe!
        }

        /****************************************************************************
        * OBSERVAÇÃO:
        * 
        * Note que mesmo dentro de um método de instância ('InformacoesDaClasseComAtributoStatic'),
        * ainda é possivel acessar o atributo 'Valor' pois 'Valor' pertence a classe,
        * mesmo que 'Valor' seja compartilhado por todas as classes!
        * 
        * Note também que não é possivel usar a palavra-chave 'this' para referenciar o 
        * atributo 'Valor' pois 'this' faz referência a instância atual e  
        * 'Valor' não é um atributo de instância, e sim da classe!
        *****************************************************************************/
    }

    public class AcessarAtributo
    {
        public string Nome = "Acessou atributo de instância!"; // Atributo que pertence a instância

        public static string Acesso() // Método que pertence a classe
        {
            // return Nome; --- ERRO DE COMPILAÇÃO

            AcessarAtributo novoAcesso = new AcessarAtributo();
            return novoAcesso.Nome;
        }

        /****************************************************************************
        * OBSERVAÇÃO:
        * 
        * Um método que é vinculado a classe não pode acessar um atributo de instância!
        * Para contornar, cria-se uma instância da própria classe para poder acessar o atributo,
        * já que o acesso ao atributo só pode ser feito por uma instância da classe!
        *****************************************************************************/

    }
}
