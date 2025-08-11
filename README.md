Demonstração de Programação Assíncrona em C#

Este projeto é uma aplicação de desktop simples, desenvolvida com Windows Forms, para demonstrar de forma prática e visual a programação assíncrona em C# usando o padrão async/await. O objetivo é mostrar como a interface do usuário (UI) permanece responsiva enquanto várias tarefas de longa duração são executadas em segundo plano.


Como Funciona

A aplicação simula quatro tarefas que levam diferentes períodos de tempo para serem concluídas (1, 8, 4 e 2 segundos). Ao clicar no botão "Iniciar", todas as tarefas são disparadas simultaneamente. O segredo está em como o código aguarda os resultados:

O método Task.WhenAny é usado em um loop while para identificar a primeira tarefa que termina.

Assim que uma tarefa é concluída, seu resultado é imediatamente exibido em um ListBox, sem esperar pelas outras.

Esse processo se repete até que todas as tarefas tenham sido finalizadas.

Essa abordagem garante que a UI nunca "congele" e que as informações sejam apresentadas ao usuário assim que estiverem disponíveis, demonstrando o verdadeiro poder da programação assíncrona.

Ferramentas e Tecnologias
Linguagem de Programação: C#

Framework: .NET (utilizando o .NET Framework para Windows Forms)

Conceitos: Programação Assíncrona, async/await, Task.Delay, Task.WhenAny, Windows Forms.


English

Asynchronous Programming Demo in C#

This is a simple Windows Forms desktop application designed to provide a practical and visual demonstration of asynchronous programming in C# using the async/await pattern. The project aims to show how a user interface (UI) can remain responsive while multiple long-running tasks are executed in the background.

How It Works
The application simulates four tasks that take different amounts of time to complete (1, 8, 4, and 2 seconds). When the "Start" button is clicked, all tasks are initiated simultaneously. The key to the project's logic lies in how it handles the results:

The Task.WhenAny method is used within a while loop to identify and await the first task that completes.

As soon as a task finishes, its result is immediately displayed in a ListBox, without waiting for the others.

This process repeats until all tasks have been finalized.

This approach ensures the UI never "freezes" and that information is presented to the user as soon as it becomes available, highlighting the true power of asynchronous programming.

Tools and Technologies
Programming Language: C#

Framework: .NET (using .NET Framework for Windows Forms)

Concepts: Asynchronous Programming, async/await, Task.Delay, Task.WhenAny, Windows Forms.


Español

Demostración de Programación Asíncrona en C#

Este es una aplicación de escritorio simple, desarrollada con Windows Forms, para demostrar de manera práctica y visual la programación asíncrona en C# utilizando el patrón async/await. El objetivo es mostrar cómo la interfaz de usuario (UI) se mantiene receptiva mientras varias tareas de larga duración se ejecutan en segundo plano.

Cómo Funciona
La aplicación simula cuatro tareas que tardan diferentes períodos de tiempo en completarse (1, 8, 4 y 2 segundos). Al hacer clic en el botón "Iniciar", todas las tareas se inician simultáneamente. El punto clave del proyecto es cómo maneja los resultados:

Se utiliza el método Task.WhenAny dentro de un bucle while para identificar y esperar la primera tarea que finaliza.

Tan pronto como una tarea se completa, su resultado se muestra inmediatamente en un ListBox, sin esperar a las demás.

Este proceso se repite hasta que todas las tareas han sido finalizadas.

Este enfoque asegura que la UI nunca se "congele" y que la información se presente al usuario tan pronto como esté disponible, demostrando el verdadero poder de la programación asíncrona.

Herramientas y Tecnologías
Lenguaje de Programación: C#

Framework: .NET (utilizando .NET Framework para Windows Forms)

Conceptos: Programación Asíncrona, async/await, Task.Delay, Task.WhenAny, Windows Forms.
