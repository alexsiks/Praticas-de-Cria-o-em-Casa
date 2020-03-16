using System;

namespace CSharp_Shell
    {

    public static class Program
        {
        public static void Main()



            {

            int alternativa;
            double nu1, nu2, soma, menuinicial;
            string opcao;


            do
                {

                Console.WriteLine(" Operaçao Validas:");

                Console.WriteLine("\t\t\t1-Soma=-------------[ 1 ]\n\t\t\t2-Subtração=--------[ 2 ]\n\t\t\t3-Divisão=----------[ 3 ]");
                alternativa = Convert.ToInt32(Console.ReadLine());


                Console.Write("Opção Digitada = ");
                Console.WriteLine(alternativa);





                switch (alternativa)
                    {

                    case 1:

                        //Soma dos Numeros//

                        Console.WriteLine("Digite o Primeiro Numero a Somar: ");
                        nu1 = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Digite o segundo Numero a Somar: ");
                        nu2 = Convert.ToDouble(Console.ReadLine());

                        soma = nu1 + nu2;

                        Console.WriteLine($" A Soma do Numero {nu1} + {nu2} e igual a {soma}. ");

                        break;

                    case 2:

                        //Subtraçao dos Numeros//


                        Console.WriteLine("Digite o Primeiro Numero a Subtrair: ");
                        nu1 = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Digite o segundo Numero a Subtrair: ");
                        nu2 = Convert.ToDouble(Console.ReadLine());

                        soma = nu1 - nu2;

                        Console.WriteLine($" A Subtraçao do Numero {nu1} - {nu2} e igual a {soma}. ");

                        break;

                    case 3:

                        //Multiplicaçao dos Numeros//

                        Console.WriteLine("Voce digitou o Numero 2");

                        break;

                    case 4:

                        //Divisao dos Numeros//

                        Console.WriteLine("Voce digitou o Numero 2");

                        break;

                    case 5:

                        // Case de Porcentagem//

                        Console.WriteLine("Digite o Valor R$: ");
                        nu1 = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Digite a %: ");
                        nu2 = Convert.ToDouble(Console.ReadLine());

                        soma = nu1 - (nu1 * 100 / 7);

                        Console.WriteLine($" A porcentagem e {soma} ");


                        break;

                    default:

                        Console.WriteLine(" A informaçao nao consta na tabela.");
                        break;






                    }

                Console.WriteLine(
               "\n\t\t\t1-Soma=-----------------------[ 1 ]" +
               "\n\t\t\t2-Subtração=------------------[ 2 ]" +
               "\n\t\t\t3-Divisão=--------------------[ 3 ]" +
               "\n\t\t\t4-Voltar ao Menu Inicial=-----[ 5 ]" +
               "\n\t\t\t5-Fim do Progama=-------------[ 6 ]"
               );


                menuinicial = Convert.ToDouble(Console.ReadLine());

                if (menuinicial == 6)
                    {
                    Console.WriteLine(" Deseja Finalizar o Propgama ?\n\n" +
                        "Para fechar o progama escreva, [sim].\n" +
                        "Para Voltar ao menu inicial digite, [nao].");
                    opcao = Convert.ToString(Console.ReadLine());

                    if (opcao == "sim")
                        {
                        Console.WriteLine("Voce digitou sim no if opção");
                        }

                    if (opcao == "nao")
                        {
                        return { menuinicial};
                        }


                    }


                } while (menuinicial == 5);







            }
        }
    }
