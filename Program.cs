﻿// Tasks
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


// 4º Teste
Task[] conjuntoTarefas = new Task[3]
{
    Task.Run(() => Console.WriteLine("Essa é a primeira tarefa")),
    Task.Run(() => Console.WriteLine("Essa é a segunda tarefa")),
    Task.Run(() => Console.WriteLine("Essa é a terceira tarefa"))
};

// defini o uso do método embarcado WaitAll()
Task.WaitAll(conjuntoTarefas);
Console.WriteLine();
Console.WriteLine("Fim da execução");
Console.ReadKey();
