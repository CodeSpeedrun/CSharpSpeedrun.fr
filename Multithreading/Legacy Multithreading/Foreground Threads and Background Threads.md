# Threads en premier plan et en arrière-plan

Les threads en premier plan ont la capacité d'empêcher la terminaison d'une application. En effet, le Runtime .NET Core ne permettra pas la fermeture d'une application tant que tous les threads en premier plan ne seront pas achevés.

D'autre part, les threads en arrière-plan, également connus sous le nom de threads démon, sont considérés comme des chemins d'exécution secondaires par le Runtime .NET Core. Ces threads peuvent être interrompus à tout moment, car ils sont jugés non essentiels pour le fonctionnement global de l'application.

```csharp
Console.WriteLine("***** Threads en arrière-plan *****\n");
Imprimante imprimante = new Imprimante();
Thread threadArrierePlan =
    new Thread(new ThreadStart(imprimante.ImprimerNombres));
// Définit le thread comme étant en arrière-plan.
threadArrierePlan.IsBackground = true;
threadArrierePlan.Start();
```

Dans cet exemple, nous utilisons une classe `Imprimante` avec une méthode `ImprimerNombres` qui simule l'impression de nombres. Nous créons ensuite un nouveau thread en arrière-plan en utilisant cette méthode comme point de départ. En définissant `IsBackground` sur `true`, nous indiquons explicitement au Runtime .NET Core que ce thread est secondaire et peut être ignoré lors de la terminaison de l'application principale.

## Utilisation des threads en arrière-plan

Les threads en arrière-plan sont souvent utilisés pour des tâches telles que la surveillance de l'état d'un système, la gestion de l'actualisation de données en arrière-plan ou l'exécution de tâches non critiques qui peuvent être interrompues sans compromettre le fonctionnement global de l'application.

Il est essentiel de comprendre que les threads en arrière-plan peuvent être arrêtés brusquement par le Runtime .NET Core à tout moment. Par conséquent, ils ne doivent être utilisés que pour des tâches qui peuvent être interrompues sans effet indésirable sur le système.

L'utilisation judicieuse des threads en arrière-plan peut contribuer à améliorer les performances globales de l'application, en permettant l'exécution de tâches secondaires sans impacter négativement la réactivité de l'interface utilisateur ou le fonctionnement principal de l'application.