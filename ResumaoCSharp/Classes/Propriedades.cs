using System;
using System.Collections.Generic;
using System.Text;

namespace ResumaoCSharp.Classes
{
    class Propriedades
    {
        /****************************************************************************************
        *                                    PROPRIEDADES                                       *
        *                                                                                       *
        * Basicamente, uma propriedade é um método PÚBLICO que serve para ler um atributo       *
        * e/ou gravar em um atributo PRIVADO, utilizando um conceito de orientação a            *
        * objetos chamado ENCAPSULAMENTO (assunto abordado depois com mais profundidade).       *
        * A vantagem de usar propriedades é impedir o acesso direto ao um atributo              *
        * (o atributo fica privado e quem tem acesso é somente a classe) e poder fazer um       *
        * processamento e/ou validação ao ler/atribuir algo no atributo.                        *
        *****************************************************************************************/
        public static void GettersSetters()
        {
            /****************************************************************************************
            *                                  GETTERS E SETTERS                                    *
            *                                                                                       *
            * Getters são métodos públicos que servem para ler atributos privados, bem como         *
            * setters são métodos públicos que servem para atribuir em atributos privados.          *
            * Estes métodos podem ou não fazer processamentos/validações antes de ler/atribuir.     *
            *****************************************************************************************/

            // * CONSTRUTOR PADRÃO E SETTERS *
            ClasseComGettersSetters classe1 = new ClasseComGettersSetters();
            classe1.SetNumero(10);
            classe1.SetNome("Teste de nome");
            classe1.SetEstaFuncionando(true);
            string resultado = $"{classe1.GetNumero()}, {classe1.GetNome()}, {classe1.GetEstaFuncionando()}";
            // resultado = "10, Este é o nome: Teste de nome, True"

            classe1.SetNome(""); //OBSERVE A IMPLEMENTAÇÃO DO SETTER DO NOME!!!
            resultado = $"{classe1.GetNumero()}, {classe1.GetNome()}, {classe1.GetEstaFuncionando()}";
            // resultado = "10, Este é o nome: Nenhum nome atribuido!, True"

            //CONSTRUTOR COM INICIALIZAÇÃO POR SETTERS DENTRO DO CONSTRUTOR
            ClasseComGettersSetters classe2 = new ClasseComGettersSetters("Salamandra", false, 240);
            resultado = $"{classe2.GetNumero()}, {classe2.GetNome()}, {classe2.GetEstaFuncionando()}";
            //resultado = "240, Este é o nome: Salamandra, False"
        }

        public static void FuncionamentoDasPropriedades()
        {
            DeclaracoesDePropriedades testandoPropriedades = new DeclaracoesDePropriedades();
            string resultado;

            // ACESSAR ATRIBUTO PRIVADO
            /*
             * testesDePropriedades.valor; --- ERRO, não pode acessar atributo privado!
             */

            // ACESSAR PROPRIEDADE IMPLEMENTADA BÁSICA
            resultado = testandoPropriedades.Palavra; // resultado = null
            testandoPropriedades.Palavra = "Palavra foi setada!";
            resultado = testandoPropriedades.Palavra; // resultado = "Palavra foi setada!"
            
            // ACESSAR PROPRIEDADE IMPLEMENTADA PERSONALIZADA
            resultado = testandoPropriedades.Nome123; // resultado = "Nome: "
            testandoPropriedades.Nome123 = "";
            resultado = testandoPropriedades.Nome123; // resultado = "Nome: SEM NOME!"
            testandoPropriedades.Nome123 = "Nome setado!";
            resultado = testandoPropriedades.Nome123; // resultado = "Nome: Nome setado!"

            // ACESSAR PROPRIEDADE AUTOIMPLEMENTADA
            resultado = testandoPropriedades.Nome; // resultado = null
            testandoPropriedades.Nome = "Propriedade 'Nome' é diferente de propriedade 'Nome123'";
            resultado = testandoPropriedades.Nome; // resultado = "Propriedade 'Nome' é diferente de propriedade 'Nome123'"
            resultado = testandoPropriedades.Nome123; // resultado = "Nome: Nome setado!"
            
            // ACESSAR PROPRIEDADE AUTOIMPLEMENTADA
            resultado = testandoPropriedades.Numero.ToString(); // resultado = "0"
            testandoPropriedades.Numero = 123.23;
            resultado = testandoPropriedades.Numero.ToString(); // resultado = "123,23"

            // ACESSAR PROPRIEDADE SOMENTE LEITURA
            resultado = testandoPropriedades.ValorConcatenadoAoNome; // resultado = "VALOR: 5,1 - Nome: Nome setado!"
        }
    }

    public class ClasseComGettersSetters
    {
        /****************************************************************************************
        *                                  ATRIBUTOS PRIVATE                                    *
        *                                                                                       *
        * A palavra reservada 'private' indica que o atributo só pode ser acessado de dentro    *
        * da própria classe, sendo inacessivel por elementos fora da classe como                *
        * instâncias da classe, outras classes, etc... (Private será abordado posteriormente)   *
        *****************************************************************************************/

        private string Nome; //atributo private, só pode ser acessado de dentro da própria classe
        private bool EstaFuncionando;
        int Numero; // private por padrão!
        /****************************************************************************
        * OBSERVAÇÃO:
        * 
        * Quando não há declaração do tipo de acesso (public, private, etc)
        * a um atributo, este atributo é private por padrão!
        *****************************************************************************/

        public ClasseComGettersSetters(string Nome, bool estaFuncionando, int num)
        {
            //É POSSIVEL USAR OS PRÓPRIOS SETTERS DA CLASSE PARA ATRIBUIR OS VALORES!
            //Nome = Nome;
            //Numero = num;
            //EstaFuncionando = estaFuncionando;
      
            SetNome(Nome);
            SetNumero(num);
            SetEstaFuncionando(estaFuncionando);
        }

        public ClasseComGettersSetters() { }

        public string GetNome()
        {
            return $"Este é o nome: {Nome}";
        }

        public void SetNome(string nome)
        {
            if (nome != String.Empty)
                Nome = nome;
            else
                Nome = "Nenhum nome atribuido!";
        }

        public bool GetEstaFuncionando()
        {
            return EstaFuncionando;
        }

        public void SetEstaFuncionando(bool boolean)
        {
            EstaFuncionando = boolean;
        }

        public int GetNumero()
        {
            return Numero;
        }

        public void SetNumero(int num)
        {
            Numero = num;
        }

        /****************************************************************************
        * OBSERVAÇÃO:
        * 
        * Veja que é possivel fazer processamentos dentro dos métodos get/set!
        * Observe o get/set do atributo Nome!!!
        *****************************************************************************/
    }
    
    public class DeclaracoesDePropriedades
    {
        // ATRIBUTO SIMPLES
        double valor = 5.1; // ATRIBUTO => private por padrão

        // PROPRIEDADE IMPLEMENTADA BÁSICA (NENHUMA IMPLEMENTAÇÃO)
        string palavra;
        public string Palavra
        {
            get { return palavra; }
            set { palavra = value; }
        }

        // PROPRIEDADE IMPLEMENTADA PERSONALIZADA
        string nome;
        public string Nome123
        {
            get
            {
                return $"Nome: {nome}";
            }
            set
            {
                if (value != string.Empty)
                    nome = value;
                else
                    nome = "SEM NOME!";
            }
        }
        /****************************************************************************
        * OBSERVAÇÃO:
        * 
        * Ao implementar uma propriedade, a propriedade e o atributo que ela acessa
        * não obrigatoriamente precisam ter o mesmo nome!
        * 
        * USAR O MESMO NOME É UMA CONVENÇÃO!!!
        *****************************************************************************/

        // PROPRIEDADE AUTOIMPLEMENTADA
        public string Nome { get; set; }
        public double Numero { get; set; }
        /****************************************************************************
        * OBSERVAÇÃO:
        * 
        * Ao usar propriedades autoimplementadas, não há necessidade de declarar uma
        * variavel com mesmo nome. Por trás dos panos, o compilador cria um 
        * campo privado e anônimo que é acessado por meio do get/set da propriedade.
        * 
        * Note que mesmo usando uma propriedade autoimplementada com mesmo nome de um
        * atributo, ela não acessa o atributo, e sim, seu próprio campo privado e anônimo.
        * OBSERVE QUE A PROPRIEDADE "Nome" NÃO ACESSA O ATRIBUTO "nome"!!!
        *****************************************************************************/

        //PROPRIEDADE SOMENTE LEITURA
        public string ValorConcatenadoAoNome
        {
            get => $"VALOR: {valor} - " + Nome123;
            // set não declarado, logo, somente leitura
        }

    }
}
