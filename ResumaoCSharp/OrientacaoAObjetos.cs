using ResumaoCSharp.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace ResumaoCSharp
{
    class OrientacaoAObjetos
    {
        /****************************************************************************
         *                                                                          *
         *                 POO - PROGRAMAÇÃO ORIENTADA A OBJETOS                    *
         *                                                                          *
         *            ENTRE EM CADA CLASSSE E VERIFIQUE OS COMENTÁRIOS,             *
         *             LÁ ESTARÁ O CONTEÚDO ABORDADO POR AQUELA CLASSE              *
         *                                                                          *
         ****************************************************************************/
        public static void MainPOO()
        {
            ClasseSimples.EntendendoClasses(); // VERIFIQUE A CLASSE!
            Metodos.AssinaturaDeMetodo(); // VERIFIQUE A CLASSE!
            Metodos.EncadeamentoDeChamadasDeMetodos(); // VERIFIQUE A CLASSE!
            Atributos.Readonly(); // VERIFIQUE A CLASSE!
            Construtores.ConstrutorPadrao(); // VERIFIQUE A CLASSE!
            Construtores.MultiplosConstrutores(); // VERIFIQUE A CLASSE!
            MembrosEstaticos.MetodoEstatico(); // VERIFIQUE A CLASSE!
            MembrosEstaticos.AtributoEstatico(); // VERIFIQUE A CLASSE!
            MembrosEstaticos.Problematica_AcessarAtributoDaClasseComMetodoEstatico(); // VERIFIQUE A CLASSE!
            Parametros.ParametrosVariaveis(); // VERIFIQUE A CLASSE!
            Parametros.ParametrosNomeados(); // VERIFIQUE A CLASSE!
            Propriedades.GettersSetters(); // VERIFIQUE A CLASSE!
            Propriedades.FuncionamentoDasPropriedades(); // VERIFIQUE A CLASSE!
        }
    }
}