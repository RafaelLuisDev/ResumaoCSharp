using System;
using System.Collections.Generic;
using System.Text;

namespace ResumaoCSharp.Classes
{
    class Construtores
    {
        /****************************************************************************************
        *                                 CONSTRUTORES                                          *
        *                                                                                       *
        * Construtores são métodos especiais que criam objetos/instâncias de uma classe         *
        *                                                                                       *
        * Todo construtor tem o mesmo nome da classe e não tem declaração de tipo de retorno,   *
        * visto que ele já retorna implicitamente um objeto/instância da própria classe         *
        *****************************************************************************************/

        public static void ConstrutorPadrao()
        {
            /****************************************************************************************
            *                                 CONSTRUTOR PADRÃO                                     *
            *                                                                                       *
            *   Quando nenhum construtor é declarado, implicitamente existe um construtor padrão    *
            *       Este construtor tem o mesmo nome da classe e não recebe nenhum parametro        *
            *****************************************************************************************/
            // VERIFIQUE A CLASSE!
            Pessoa pessoa1 = new Pessoa(); // Uso do construtor padrão, a classe Pessoa não tem construtores!
            pessoa1.Nome = "Nome da pessoa 1";
            pessoa1.Idade = 20;

            Pessoa pessoa2 = new Pessoa() // Forma alternativa de instanciar e inicializar/atribuir valores aos atributos
            {
                Idade = 40,
                Nome = "Nome da pessoa 2"
            };
            /****************************************************************************
            * OBSERVAÇÃO:
            * 
            * Ao criar construtores na classe, o construtor padrão deixa de existir implicitamente,
            * é preciso declarar EXPLICITAMENTE o construtor padrão, 
            * caso não seja explicitado ocorrerá um erro de compilação!
            * Note também que é possível sobreescrever o construtor padrão ao explicita-lo!!! :D 
            *****************************************************************************/
        }

        public static void MultiplosConstrutores()
        {
            /****************************************************************************************
            *                               MULTIPLOS CONSTRUTORES                                  *
            *                                                                                       *
            *                       Uma classe pode ter diversos construtores                       *
            *                 Mas estes construtores devem ter assinaturas diferentes               *
            *****************************************************************************************/
            // VERIFIQUE A CLASSE!
            Carro carro1 = new Carro("Corvette C6", "Chevrolet", 2015); // assinatura Carro(string, string, int)

            Carro carro2 = new Carro("Compass", 2019, "Jeep"); // assinatura Carro(string, int, string)

            Carro carro3 = new Carro(); // construtor padrão - assinatura Carro()
            carro3.Modelo = "Ka";
            carro3.Ano = 2020;
            carro3.Fabricante = "Ford";

            Carro carro4 = new Carro("Fusion", "Ford")  // assinatura Carro(string, string)
            {
                Ano = 2010
            };
            /****************************************************************************
            * OBSERVAÇÃO:
            * 
            * Note que o atributo Ano é inicializado pelo construtor
            * com o ano atual do sistema (DateTime.Now.Year),
            * mas ao instanciar o objeto, ele inicializa o atributo Ano com 2010, 
            * substituindo o Ano previamente atribuido pelo construtor (DateTime.Now.Year) 
            *****************************************************************************/

        }
    }

    class Pessoa
    {
        public string Nome; // Nome = null
        public int Idade; // Idade = 0
        /****************************************************************************
        * RELEMBRANDO:
        * 
        * Todos atributos de tipos básicos recebem valores padrão.
        * Ao criar uma instância/objeto da classe, estes atributos terão valores padrão.
        * No caso, string recebe valor 'null' e um int recebe valor 0.
        * 
        * CADA TIPO TEM SEU VALOR PADRÃO!
        *****************************************************************************/
    }

    class Carro
    {
        public string Modelo;
        public string Fabricante;
        public int Ano;

        public Carro() // Construtor padrão - declaração EXPLICITA
        {
            // ...
        }
        /****************************************************************************
        * OBSERVAÇÃO:
        * 
        * Note que é possível escrever código no construtor padrão!!!
        *****************************************************************************/

        public Carro(string modelo, string fabricante) // Construtor com 2 parâmetros
        {
            Modelo = modelo; 
            Fabricante = fabricante;
            Ano = DateTime.Now.Year; // Ano recebe o ano atual do sistema
        }

        public Carro(string modelo, string fabricante, int ano) // Construtor com 3 parâmetros
        {
            // A palavra reservada 'this' é uma referência a própria instância da classe
            this.Modelo = modelo;  // this => referência a própria instância, uso opcional
            Fabricante = fabricante;
            Ano = ano;
        }

        public Carro(string Modelo, int ano, string fabricante) // Construtor com 3 parâmetros, assinatura diferente
        {
            this.Modelo = Modelo; // this => referência a própria instância, uso obrigatorio pois nomes iguais
            Fabricante = fabricante;
            Ano = ano;
        }
        /****************************************************************************
        * OBSERVAÇÃO:
        * 
        * Os dois construtores acima tem assinaturas diferentes:
        *       - Assinatura construtor 1 => Carro(string, string, int) 
        *       - Assinatura construtor 2 => Carro(string, int, string)
        *****************************************************************************/
    }
}
