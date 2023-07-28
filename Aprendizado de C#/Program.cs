string primeiraApresentacao = "Seja bem vindo ao MusicSharp";


//Fazendo uma lista 
List<string> Musicas = new List<string>();
void ChamandoApresentacao()
{

    //Titulo do programa
    Console.WriteLine(@"
    
███╗░░░███╗██╗░░░██╗░██████╗██╗░█████╗░░██████╗██╗░░██╗░█████╗░██████╗░
████╗░████║██║░░░██║██╔════╝██║██╔══██╗██╔════╝██║░░██║██╔══██╗██╔══██╗
██╔████╔██║██║░░░██║╚█████╗░██║██║░░╚═╝╚█████╗░███████║███████║██████╔╝
██║╚██╔╝██║██║░░░██║░╚═══██╗██║██║░░██╗░╚═══██╗██╔══██║██╔══██║██╔═══╝░
██║░╚═╝░██║╚██████╔╝██████╔╝██║╚█████╔╝██████╔╝██║░░██║██║░░██║██║░░░░░
╚═╝░░░░░╚═╝░╚═════╝░╚═════╝░╚═╝░╚════╝░╚═════╝░╚═╝░░╚═╝╚═╝░░╚═╝╚═╝░░░░░
");
    Console.WriteLine(primeiraApresentacao);
}


void Comandos()
{

    Console.WriteLine("\n1- Registro de musica");
    Console.WriteLine("2- Mostra a musica");
    Console.WriteLine("3- Avaliacao da musica");
    Console.WriteLine("4- Autor da musica");
    Console.WriteLine("5- Sair");




    Console.Write("\nEscolha um das opcoes assima: ");


    string opcaoEscolhida = Console.ReadLine();
    int EscolhaDeComandoNumerica = int.Parse(opcaoEscolhida)!;

   


    switch (EscolhaDeComandoNumerica)
    {
        case 1:
            RegistroDeMuscia();
        break;
        case 2:
            MostraMusicas();
            break;
        default:
            break;





            void RegistroDeMuscia()
            {
               
                    Console.Clear();
                    Console.WriteLine("**********************");
                    Console.WriteLine("Registro de musicas");
                    Console.WriteLine("**********************\n");
                    Console.Write("Digite a musica que deseja registrar: ");
                    string nomeDamusica = Console.ReadLine()!;
                    Musicas.Add(nomeDamusica);
                    Console.WriteLine($"A musica {nomeDamusica} foi registrada com sucesso!");
                    Thread.Sleep(2000);
                    Console.Clear();
                    Comandos();

            }


            void MostraMusicas()
            {

                Console.Clear();
                Console.WriteLine("************************************");
                Console.WriteLine("Exibindo todas as musicas registradas");
                Console.WriteLine("************************************\n");

                for (int i = 0; i < Musicas.Count; i++)
                {
                Console.WriteLine($"Banda: {Musicas[i]}");
                }

                /*
                ///outra forma de fazer o for para o registro da musica
                foreach (string nomedaMusica in Musicas)
                {
                    Console.WriteLine($"Banda: {nomedaMusica}");
                }
                */


                Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
                Console.ReadKey();
                Console.Clear();
                Comandos();
            }

    }
}




ChamandoApresentacao();
Comandos(); 



