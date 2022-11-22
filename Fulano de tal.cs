using System;

namespace exemploCliente

{

    class exemplo

    {

        public class Cliente

        {

            public string nome;

            public string sobrenome;

            public void EscreveNaConsole()

            {

                Console.WriteLine("Ola " + nome + " " + sobrenome);

                Console.WriteLine("Pressione qualquer tecla para sair");

                Console.ReadKey();

            }

        }

        static void Main()

        {

            Cliente objetoCliente = new Cliente();

            // Acessando as variáveis

            objetoCliente.nome = "Fulano";

            objetoCliente.sobrenome = "de tal";

            // Acessando o método

            objetoCliente.EscreveNaConsole();

        }

    }

}