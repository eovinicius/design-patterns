using Facade;

var order = new Order { Customer = "Jose da Silva", TotalAmount = 199.99M };

var orderFacade = new OrderFacade();
orderFacade.ProcessOrder(order);
