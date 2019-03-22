using System;

namespace NPCPerks
{
    class Program
    {
        static void Main(string[] args)
        {
            //declarar variaveis
            int NumNpcs;
            int npcCarac;
            Caracteristicas[] caract;
            char answer;
            


            //Perguntar npcs ao utilizador
            Console.WriteLine("How many Npc's do you want");
            NumNpcs = Convert.ToInt32(Console.ReadLine());

            caract = new Caracteristicas[NumNpcs];
            // ciclo for
            for (int i = 0; i < NumNpcs; i++)
            {
                
                for (int i = 0; i <= NumNpcs; i++)
                {

                    Console.WriteLine("Would you like to have Stealth?");
                    
                    answer = Convert.ToChar(Console.ReadLine());

                    if (answer == 'y')
                    {
                        caract[i] |= Caracteristicas.Stealth;
                    }
                    Console.WriteLine("Would you like to have Combat?");
                    else if (answer == 'y')
                    {
                        caract[i] |= Caracteristicas.Combat;
                    }
                    else if (answer == 'y')
                    {
                        caract[i] |= Caracteristicas.Lockpick;
                    }
                    else if (answer == 3)
                    {
                        caract[i] |= Caracteristicas.Luck;
                    }

                }
                
            }

            for (int i = 0; i < NumNpcs; i++)
            {
                Console.WriteLine(caract[i]);
            }
            //guardar characteristicas num array

            //Imprimir Npcs mais caracteristica

        }
}
}
