using Structures;

Request request1 = new Request();

request1.articles.Add(new Article { articlePrice = 5 });
request1.articles.Add(new Article { articlePrice = 4});

Console.WriteLine(request1.OrdersAmount.ToString());


