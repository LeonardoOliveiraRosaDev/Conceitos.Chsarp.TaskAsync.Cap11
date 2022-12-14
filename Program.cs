// Tasks
using Conceitos.Chsarp.TaskAsync.Cap11;


// 1º Teste
Console.WriteLine();
Console.WriteLine(new string('_', 40));
Console.WriteLine();
Console.WriteLine("------------------Tasks-----------------");
Console.WriteLine(new string('_',40));
Console.WriteLine();
//TestandoTasks.ImprimirAlgunsDados();
//Task tarefaPrimer = new Task(TestandoTasks.ImprimirAlgunsDados);
//tarefaPrimer.Start();
//Thread.Sleep(3000);
//Console.WriteLine("Tarefa principal finalizada !");
//Console.ReadKey();


// 2º Teste

// Definir a nova Task
//usa como parametro de task o delegate Action
//Task ludicaPontinhos = new Task(new Action(TestandoTasks.MostrarPontinhos));


//// fazer uso e inicializar a Task
//ludicaPontinhos.Start();
//Thread.Sleep(3000);

//// estabelecer um novo loop
//for (int i = 0; i < 10; i++)
//{
//    Console.WriteLine("#");
//    Thread.Sleep(1000);
//}

// 3º teste


//Task criarUmaAssinc = Task.Run(() =>
//{
//    for (int i = 0; i < 5; i++)
//    {
//        Console.WriteLine(":D  ");
//        Thread.Sleep(5000);
//    }
//});

//// chamar a Task e e usar o método Wait()
//criarUmaAssinc.Wait();
//for (int i = 0; i < 5; i++)
//{
//      Console.WriteLine(":(   ");
//    Thread.Sleep(5000);
//}

/*
//4 º Teste
Task[] conjuntoTarefas = new Task[3]
{
    Task.Run(() => Console.WriteLine("Essa é a primeira tarefa")),
    Task.Run(() => Console.WriteLine("Essa é a segunda tarefa")),
    Task.Run(() => Console.WriteLine("Essa é a terceira tarefa"))
};
Thread.Sleep(3000);
Task[] conjuntoTarefas2 = new Task[3]
{
    Task.Run(() => Console.WriteLine("Essa é a primeira tarefa")),
    Task.Run(() => Console.WriteLine("Essa é a segunda tarefa")),
    Task.Run(() => Console.WriteLine("Essa é a terceira tarefa"))
};
// defini o uso do método embarcado WaitAll()
Task.WaitAll(conjuntoTarefas);
Console.WriteLine();
Task.WaitAll(conjuntoTarefas2);
Console.WriteLine();
Console.WriteLine("Fim da execução");
Console.ReadKey();
*/

/*
// executando o 5º teste
// definir uma variavel
var listinha = TestandoTasks.ListarNomes().Result;
Console.WriteLine();
int x = 1;
//definir um outro foreach()
foreach (var item in listinha)
{
    Console.WriteLine($"Nome na posição {x++}: "+ item);
} */


/*
//6º teste
Task<int> testecinco = Task.Run<int>(() =>
{
    int cont = 0;
    // definir um loop
    for (int i = 0; i < 5; i++)
    {
        cont += i;
    }
    return cont;
});

// exibir o resultado na tela
Console.WriteLine("Resultado " +testecinco.Result);
*/

// 7º Teste
Console.WriteLine($"Thread principal iniciada");
Console.WriteLine();
// fazer referencia a classe TestandoTasks e acessar o método UmNovoMetodo()
// Espera-se 2 segundos - manipulador de tempo dentro do método InfosColaborador()
// na sequencia , a exibicao dos valores das props
TestandoTasks.UmNovoMetodo();
Console.WriteLine();
// tarefa finalizada... espera-se 3 segundos para que o proximo auxiliar
//WriteLine() seja chamado - manipulador de tempo dentro do método UmNovoMetodo()
Console.WriteLine("Thread principal completada");
Console.ReadKey();

