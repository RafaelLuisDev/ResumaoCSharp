using System;
using System.Collections.Generic;
using System.Text;

namespace ResumaoCSharp.Classes
{
    class Atributos
    {
        public static void Readonly()
        {
            /****************************************************************************************
            *                                 ATRIBUTOS READONLY                                    *
            *                                                                                       *
            * Os atributos readonly são atributos que só podem ser inicializados e não podem        *
            * ser alterados durante a execução do programa,                                         *
            *****************************************************************************************/

            ClasseComReadonly classe1 = new ClasseComReadonly() { };
            string resultado = classe1.Nascimento.ToString();
            // resultado = "01/01/0001 00:00:00" --- VALOR PADRÃO DO DATETIME
            resultado = classe1.GetData().ToString(); // Acessando atributo privado somente leitura
            // resultado = "01/01/0001 00:00:00"

            /*
             * classe1.Nascimento = DateTime.Now; --- ERRO DE COMPILAÇÃO, 'Nascimento' é readonly
             */

            classe1 = new ClasseComReadonly("Teste nome", new DateTime(2015, 6, 19), new DateTime(2020, 12, 31));
            resultado = classe1.Nascimento.ToString();
            // resultado = "31/12/2020 00:00:00"
            resultado = classe1.GetData().ToString();
            // resultado = "19/06/2015 00:00:00"
        }
    }

    class ClasseComReadonly
    {
        public string Nome;
        readonly DateTime Data;
        public readonly DateTime Nascimento;
        const int Valor = 1;
        // const DateTime outraData; --- ERRO DE COMPILAÇÃO
        /****************************************************************************
        * OBSERVAÇÃO:
        * 
        * Nem todos tipos podem ser declarados como constante. Só para relembrar, 
        * 'const' exige que a declaração do valor ocorra junto 
        * da declaração do atributo. Além disso, 
        *****************************************************************************/

        public ClasseComReadonly(string nome, DateTime data, DateTime nasc)
        {
            Nome = nome;
            Data = data;
            Nascimento = nasc;
        }

        public ClasseComReadonly() { }

        public void AtribuiData(DateTime novaData)
        {
            //Data = novaData; --- IMPOSSIVEL FAZER UMA ATRIBUIÇÃO A UM ATRIBUTO READONLY
            //Nascimento = novaData; --- IMPOSSIVEL FAZER UMA ATRIBUIÇÃO A UM ATRIBUTO READONLY
        }

        public DateTime GetData()
        {
            return Data;
        }
    }
}
