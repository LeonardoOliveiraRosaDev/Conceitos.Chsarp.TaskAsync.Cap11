using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Conceitos.Chsarp.TaskAsync.Cap11
{
    internal class TestandoTasks
    {
        //definir um método para ser acessado a partir do arquivo principal
        // 1º Método
        //public static void ImprimirAlgunsDados()
        //{
        //    // Estabelecer um loop com  a tarefa e exibir um intervalo de valores
        //    for (int i = 1; i <= 4; i++)
        //    {
        //        Console.WriteLine("i vale: {0}", i);

        //    }

        //    Console.WriteLine("Este método é percebido, pelo contexto task, como uma tarefa-filha ou secundária.");
        //    Thread.Sleep(3000);
        //}

        /*
        // 2º Teste
        public static void MostrarPontinhos() 
        {
            for (int i = 0; i < 10 ; i++)
            {
                //exibir pontinhos
                Console.WriteLine(".");
               
            }
        } */

        /*
        //5º teste
        public static async Task<IEnumerable<string>> ListarNomes()
        {// definir uma prop
            var nomes = new List<string>()
            {
                "Renata", "Renato", "Leonardo", "Amanda", "Kauane", "Anderson", "Luis Renato"
            };

            // definir um loop para iterar sobre os valores da lista nomes
            foreach(var item in nomes) 
            {
                // definir uma estrutura de decisao para verificar a ocorrencia de um valor determinado
                if (item.Contains("e"))
                {
                    Console.WriteLine(item);
                    await Task.Delay(2000);
                }
            }
            // expressão de retorno
            return nomes;
 
        }*/

        // definir métodos para executar as operaçoes com as props 
        // da classe Colaborador

        // estipular uma tarefa assincrona com o objetivo de 
        // executar uma operação com as props que ja foram 
        // manipuladas pelo método InfosColaborador.
        public async static void UmNovoMetodo()
        {
            Colaborador col = await InfosColaborador();
            // definir a operação
            Console.WriteLine($"Id: {col.Id}\nNome: {col.Nome}\nSalario: {col.Salario}");
            Thread.Sleep(3000);
        }

        // implementar um método - tarefa usando de generics
        // este metodo define as props que estao sendo manipuladas
        public static Task<Colaborador> InfosColaborador()
        {
            Colaborador colab = new()
            {
                // definir valores das props da classe Colaborador
                Id = 01,
                Nome = "Horticlei",
                Salario = 1.752
            };
            Thread.Sleep(2000);
            return Task.FromResult(colab);
        }
    }
}
