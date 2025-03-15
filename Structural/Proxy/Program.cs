using Proxy;
var reportGenereteProxy = new ReportGenereteProxy(new ReportGenerete());

//primeira chamada
var result = reportGenereteProxy.Generete();
Console.WriteLine(result);

//segunda chamada
var result2 = reportGenereteProxy.Generete();
Console.WriteLine(result2);