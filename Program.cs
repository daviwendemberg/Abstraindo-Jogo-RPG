using rpg_friendly.src.Entities;

using static System.Console;

namespace dotnet__poo
{
  class Program
  {
    static void Main(string[] args)
    {

      WriteLine("\n\nEste é um joguinho básico na criação de um Heroi RPG.");
      while(true)
      {
        Write("\n\nVocê deseja criar um Heroi?(1 para sim 2 para não.): ");

        int opcao = int.Parse(ReadLine());
        if(opcao == 1){
          Write("Qual Classe você prefere?\n1-Knight\n2-Ninja\n3-WhiteWizzard\n4-BlackWizard\n");
          int ClassHero = int.Parse(ReadLine());
          if(ClassHero == 1)
          {
            Knight Arus = new Knight("Arus", 42, 72, 469);
            Write("\nNome do Heroi:" + Arus.Name + "\n" +"Level:" + Arus.Level + "\n" + "MP:"+ Arus.MP + "\n" +"HP:" + Arus.HP);
          }else if(ClassHero == 2)
          {
            Ninja Wedge = new Ninja("Wedge", 42, 72, 469);
            Write("\nNome do Heroi:" + Wedge.Name + "\n" +"Level:" + Wedge.Level + "\n" + "MP:"+ Wedge.MP + "\n" +"HP:" + Wedge.HP);
          }else if(ClassHero == 3)
          {
            WhiteWizard Jenica = new WhiteWizard("Jenica",42, 72, 469);
            Write("\nNome do Heroi:" + Jenica.Name + "\n" +"Level:" + Jenica.Level + "\n" + "MP:"+ Jenica.MP + "\n" +"HP:" + Jenica.HP);
          }else if(ClassHero == 4)
          {
            BlackWizard Topapa = new BlackWizard("Topapa",42, 72, 469);
            Write("\nNome do Heroi:" + Topapa.Name + "\n" +"Level:" + Topapa.Level + "\n" + "MP:"+ Topapa.MP + "\n" +"HP:" + Topapa.HP);
          }else{
            Write("\nClasse inexistente.");
            Write("\nJogo Finalizado.\n");
            break;
          }


        }else if(opcao == 2){
          Write("\nUma pena aventureiro, até a próxima!");
          Write("\nJogo Finalizado.");
          break;
        }else{
          Write("Algo inesperado aconteceu.");
          Write("Jogo finalizado.");
        }

         

      }

    }
  }

}