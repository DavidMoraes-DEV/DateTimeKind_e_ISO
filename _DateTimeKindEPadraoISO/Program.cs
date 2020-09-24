using System;

namespace _DateTimeKindEPadraoISO
{
    class Program
    {
        static void Main(string[] args)
        {
            
            /* * DateTimeKind é um tipo enumerado especial que define três valores possíveis para a localidade da data:
               - Local (Fuso horário do sistema. Exemplo: São Paulo = GMT -3)
               - Utc (Fuso horário GMT (Greenwich Mean Time(Horário de Londres(CONSIDERADA O HORÁRIO PADRÃO)))
               - Unspecifield (Não Especificado)

               * BOA PRÁTICA:
               - Armazenar em formato UTC (texto: BS / Json / XML)
               - Instanciar e mostrar em formato local.

               * Para converter um DateTime para Local ou Utc, deve-se usar:
               - myDate.ToLocalTime()
               - myDate.ToUniversalTime()
            */

            DateTime d1 = new DateTime(2000, 8, 15, 13, 5, 57, DateTimeKind.Local); /*Após instânciar a data formatamos o tipo da data para local com o .DateTimeKind.Local*/

            DateTime d2 = new DateTime(2001, 9, 16, 14, 6, 58, DateTimeKind.Utc); /*Instância a data e formata ela para o tipo Universal com o DateTimeKind.Utc*/

            DateTime d3 = new DateTime(2002, 10, 17, 15, 7, 59); /*Sem formatção de Tipo Local ou Utc*/

            Console.WriteLine("Data formata para Local: " + d1); /*Não terá diferença entre as três pois o C# mostra conforme foi declara apenas o formato armazenado que mudará*/
            Console.WriteLine("Data formata para Utc: " + d2);
            Console.WriteLine("Data sem formatação Local ou Utc: " + d3);

            Console.WriteLine();
            Console.WriteLine("Mostrando qual é o Kind(Tipo de Fuso Horário) da data d1 usando o .Kind: " + d1.Kind); /*Mostra o tipo que a data esta instanciada (Local/Utc)*/
            Console.WriteLine("Convertendo a data d1 para Local com o .ToLocalTime(): " + d1.ToLocalTime()); /*Converte o fuso horário da data para Local (No brasil o fuo horário é três horas a menos que o horário Universal)*/
            Console.WriteLine("Convertendo a data d1 para Utc(Universal) com o .ToUniversalTime(): " + d1.ToUniversalTime()); /*Converte o fuso horário da data para Universal*/
            
            Console.WriteLine();
            Console.WriteLine("Mostrando qual é o Kind(Tipo de Fuso Horário) da data d2 usando o .Kind: " + d2.Kind); /*Mostra o tipo que a data esta instanciada (Local/Utc)*/
            Console.WriteLine("Convertendo a data d2 para Local com o .ToLocalTime(): " + d2.ToLocalTime()); /*Converte o fuso horário da data para Local (No brasil o fuso horário é três horas a menos que o horário Universal)*/
            Console.WriteLine("Convertendo a data d2 para Utc(Universal) com o .ToUniversalTime(): " + d2.ToUniversalTime()); /*Converte o fuso horário da data para Universal*/

            Console.WriteLine();
            /*Quando a Data é Unspecified(NÃO ESPECIFICADA) o C# converte para Local subtraindo 3 horas apartir da data instânciada e soma três horas apartir da data instância pois ele não sabe com o tipo original da data então da esse erro pois o horario fica com uma data incorreta dando uma diferença de 6 horas entra os dois tipos Local/Utc*/
            Console.WriteLine("Mostrando qual é o Kind(Tipo de Fuso Horário) da data d2 usando o .Kind: " + d3.Kind); /*Mostra o tipo que a data esta instanciada (Local/Utc)*/
            Console.WriteLine("Convertendo a data d3 para Local com o .ToLocalTime(): " + d3.ToLocalTime()); /*Converte o fuso horário da data para Local (No brasil o fuso horário é três horas a menos que o horário Universal)*/
            Console.WriteLine("Convertendo a data d3 para Utc(Universal) com o .ToUniversalTime(): " + d3.ToUniversalTime()); /*Converte o fuso horário da data para Universal*/

        }
    }
}