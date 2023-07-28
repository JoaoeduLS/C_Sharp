
    internal class JogoDosNumeros
    {

    void JogoDeNumeroAleatorio()
    {
        ///titulo
        Console.WriteLine(@"
    
░░░░░██╗░█████╗░░██████╗░░█████╗░  ██████╗░░█████╗░░██████╗
░░░░░██║██╔══██╗██╔════╝░██╔══██╗  ██╔══██╗██╔══██╗██╔════╝
░░░░░██║██║░░██║██║░░██╗░██║░░██║  ██║░░██║██║░░██║╚█████╗░
██╗░░██║██║░░██║██║░░╚██╗██║░░██║  ██║░░██║██║░░██║░╚═══██╗
╚█████╔╝╚█████╔╝╚██████╔╝╚█████╔╝  ██████╔╝╚█████╔╝██████╔╝
░╚════╝░░╚════╝░░╚═════╝░░╚════╝░  ╚═════╝░░╚════╝░╚═════╝░

███╗░░██╗██╗░░░██╗███╗░░░███╗███████╗██████╗░░█████╗░░██████╗
████╗░██║██║░░░██║████╗░████║██╔════╝██╔══██╗██╔══██╗██╔════╝
██╔██╗██║██║░░░██║██╔████╔██║█████╗░░██████╔╝██║░░██║╚█████╗░
██║╚████║██║░░░██║██║╚██╔╝██║██╔══╝░░██╔══██╗██║░░██║░╚═══██╗
██║░╚███║╚██████╔╝██║░╚═╝░██║███████╗██║░░██║╚█████╔╝██████╔╝
╚═╝░░╚══╝░╚═════╝░╚═╝░░░░░╚═╝╚══════╝╚═╝░░╚═╝░╚════╝░╚═════╝░
");



        ///Para numeros aleatorios ,
        Random rand = new Random();
        int numeroAleatorio = rand.Next(1, 20);


        int resposta;


        do
        {
            Console.WriteLine("Escolha um número:");
            string numeroEscolhido = Console.ReadLine();


            ///Nem sempre o int se repete e tem que esta no mesmo lugar.
            resposta = int.Parse(numeroEscolhido);


            if (resposta == numeroAleatorio)
            {
                Console.WriteLine("parabens voce ganho o jogo");
            }
            else if (resposta > numeroAleatorio)
            {

                Console.WriteLine("voce passou direto maninho vai mais devaga e diminui ai");
            }
            else if (resposta < numeroAleatorio)
            {
                Console.WriteLine("chegou quase la em maninho mais almenta isso");
            }
            else
            {
                Console.WriteLine("digita um numero ai");
            }


        } while (
           ///enquanto for diferente a funcao vai se repetir.
           resposta != numeroAleatorio);
        {
            Console.WriteLine("parabens manito voce passou");
        }
    }
    JogoDeNumeroAleatorio();

}

