using System;

namespace JogaDados
{
    class Program
    {
        static void Main(string[] args)
        {



          voltaGeral:

            Random dado = new Random();
            int[] giro = new int[100] { 01, 02, 03, 04, 05, 06, 07, 08, 09, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25,26,27,28,29,30,
                                      31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,54,55,56,57,58,59,60,61,62,63,64,65,66,67,68,69
            ,70,71,72,73,74,75,76,77,78,79,80,81,82,83,84,85,86,87,88,89,90,91,92,93,94,95,96,97,98,99,100};
            int[] recebe_giro = new int[100];

            int lance;
            int cont = 0; //--------------------------------------------------------------------ficar de olho no cont para que seje igual ao GIRO
            lance = dado.Next(0, 50);


            //******************************************************************************** inicio
            Console.WriteLine("\n"+ giro[lance]);
           

            for (int i = 0; i < giro.Length; i++)
            {
                cont++;
                switch (giro[lance])
                {
                    case 1:
                        giro[0] = 0;
                        break;
                    case 2:
                        giro[1] = 0;
                        break;
                    case 3:
                        giro[2] = 0;
                        break;
                    case 4:
                        giro[3] = 0;
                        break;
                    case 5:
                        giro[4] = 0;
                        break;
                    case 6:
                        giro[5] = 0;
                        break;
                    case 7:
                        giro[6] = 0;
                        break;
                    case 8:
                        giro[7] = 0;
                        break;
                    case 9:
                        giro[8] = 0;
                        break;
                    case 10:
                        giro[9] = 0;
                        break;
                    case 11:
                        giro[10] = 0;
                        break;
                    case 12:
                        giro[11] = 0;
                        break;
                    case 13:
                        giro[12] = 0;
                        break;
                    case 14:
                        giro[13] = 0;
                        break;
                    case 15:
                        giro[14] = 0;
                        break;
                    case 16:
                        giro[15] = 0;
                        break;
                    case 17:
                        giro[16] = 0;
                        break;
                    case 18:
                        giro[17] = 0;
                        break;
                    case 19:
                        giro[18] = 0;
                        break;
                    case 20:
                        giro[19] = 0;
                        break;
                    case 21:
                        giro[20] = 0;
                        break;
                    case 22:
                        giro[21] = 0;
                        break;
                    case 23:
                        giro[22] = 0;
                        break;
                    case 24:
                        giro[23] = 0;
                        break;
                    case 25:
                        giro[24] = 0;
                        break;          
                    case 26:
                        giro[25] = 0;
                        break;
                    case 27:
                        giro[26] = 0;
                        break;
                    case 28:
                        giro[27] = 0;
                        break;
                    case 29:
                        giro[28] = 0;
                        break;
                    case 30:
                        giro[29] = 0;
                        break;
                    case 31:
                        giro[30] = 0;
                        break;
                    case 32:
                        giro[31] = 0;
                        break;
                    case 33:
                        giro[32] = 0;
                        break;
                    case 34:
                        giro[33] = 0;
                        break;
                    case 35:
                        giro[34] = 0;
                        break;
                    case 36:
                        giro[35] = 0;
                        break;
                    case 37:
                        giro[36] = 0;
                        break;
                    case 38:
                        giro[37] = 0;
                        break;
                   
                    case 39:
                        giro[38] = 0;
                        break;
                    case 40:
                        giro[39] = 0;
                        break;
                    case 41:
                        giro[40] = 0;
                        break;
                    case 42:
                        giro[41] = 0;
                        break;
                    case 43:
                        giro[42] = 0;
                        break;
                    case 44:
                        giro[43] = 0;
                        break;
                    case 45:
                        giro[44] = 0;
                        break;
                    case 46:
                        giro[45] = 0;
                        break;
                    case 47:
                        giro[46] = 0;
                        break;
                    case 48:
                        giro[47] = 0;
                        break;
                    case 49:
                        giro[48] = 0;
                        break;
                    case 50:
                        giro[49] = 0;
                        break;
                   
                    case 51:
                        giro[50] = 0;
                        break;
                    case 52:
                        giro[51] = 0;
                        break;
                    case 53:
                        giro[52] = 0;
                        break;
                    case 54:
                        giro[53] = 0;
                        break;
                    case 55:
                        giro[54] = 0;
                        break;
                    case 56:
                        giro[55] = 0;
                        break;
                    case 57:
                        giro[56] = 0;
                        break;
                    case 58:
                        giro[57] = 0;
                        break;
                    case 59:
                        giro[58] = 0;
                        break;
                    case 60:
                        giro[59] = 0;
                        break;
                    case 61:
                        giro[60] = 0;
                        break;
                    case 62:
                        giro[61] = 0;
                        break;
                    case 63:
                        giro[62] = 0;
                        break;
                    case 64:
                        giro[63] = 0;
                        break;
                    case 65:
                        giro[64] = 0;
                        break;
                    case 66:
                        giro[65] = 0;
                        break;
                    case 67:
                        giro[66] = 0;
                        break;
                    case 68:
                        giro[67] = 0;
                        break;
                    case 69:
                        giro[68] = 0;
                        break;
                    case 70:
                        giro[69] = 0;
                        break;
                    case 71:
                        giro[70] = 0;
                        break;
                    case 72:
                        giro[71] = 0;
                        break;
                    case 73:
                        giro[72] = 0;
                        break;
                    case 74:
                        giro[73] = 0;
                        break;
                    case 75:
                        giro[74] = 0;
                        break;
                    case 76:
                        giro[75] = 0;
                        break;
                    case 77:
                        giro[76] = 0;
                        break;
                    case 78:
                        giro[77] = 0;
                        break;
                    case 79:
                        giro[78] = 0;
                        break;
                    case 80:
                        giro[79] = 0;
                        break;
                    case 81:
                        giro[80] = 0;
                        break;
                    case 82:
                        giro[81] = 0;
                        break;
                    case 83:
                        giro[82] = 0;
                        break;
                    case 84:
                        giro[83] = 0;
                        break;
                    case 85:
                        giro[84] = 0;
                        break;
                    case 86:
                        giro[85] = 0;
                        break;
                    case 87:
                        giro[86] = 0;
                        break;
                    case 88:
                        giro[87] = 0;
                        break;

                    case 89:
                        giro[88] = 0;
                        break;
                    case 90:
                        giro[89] = 0;
                        break;
                    case 91:
                        giro[90] = 0;
                        break;
                    case 92:
                        giro[91] = 0;
                        break;
                    case 93:
                        giro[92] = 0;
                        break;
                    case 94:
                        giro[93] = 0;
                        break;
                    case 95:
                        giro[94] = 0;
                        break;
                    case 96:
                        giro[95] = 0;
                        break;
                    case 97:
                        giro[96] = 0;
                        break;
                    case 98:
                        giro[97] = 0;
                        break;
                    case 99:
                        giro[98] = 0;
                        break;
                    case 100:
                        giro[99] = 0;
                        break;

                }


              
                Console.ReadKey();
            jogada2:
                lance = dado.Next(0, 100);                       // neste momento foi subtraida uma opsição
                if (giro[lance] == 0)
                {
                  
                    goto jogada2;
                }

                Console.WriteLine(giro[lance]);
                recebe_giro[i] = giro[lance];
                if (cont ==99 )                             //finaliza laço
                {
                    break;
                }



            }                                                   //---------fim  do laço

            Console.ReadKey();
        voltaBingo:
            Console.WriteLine("digite a letra (B) para continuar");
            string escolha = Console.ReadLine();
            if (escolha!="b")
            {
                Console.Beep();
                goto voltaBingo;

            }
            
            Console.Clear();
            
            Console.WriteLine("              S U A   C A R T E L A   D E   B I N G O !!");
           Console.WriteLine("\n                   {0} {1} {2} {3} {4}",recebe_giro[0], recebe_giro[1], recebe_giro[2], recebe_giro[3], recebe_giro[4]);
           Console.WriteLine("\n                   {0} {1} {2} {3} {4}", recebe_giro[5], recebe_giro[6], recebe_giro[7], recebe_giro[8], recebe_giro[9]);
           Console.WriteLine("\n                   {0} {1}  ♦  {2} {3}", recebe_giro[10], recebe_giro[11], recebe_giro[12], recebe_giro[13]);
           Console.WriteLine("\n                   {0} {1} {2} {3} {4}", recebe_giro[14], recebe_giro[15], recebe_giro[16], recebe_giro[17], recebe_giro[18]);
           Console.WriteLine("\n                   {0} {1} {2} {3} {4} ", recebe_giro[19], recebe_giro[20], recebe_giro[21], recebe_giro[22],recebe_giro[23]);
            Console.ReadKey();









        }

    }
}

