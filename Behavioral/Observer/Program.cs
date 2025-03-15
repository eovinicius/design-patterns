using System.Net.Http.Headers;
using Observer;

var binanceApi = new BinanceApi();
var newPrice = binanceApi.GetLastPrice();

var bitcoin = new Bitcoin();
bitcoin.AddObservers(new InvestorNotifier());

bitcoin.AddObservers(new NewsPlataform());

bitcoin.AddObservers(new BitcoinPriceLogger());

bitcoin.SetPrice(newPrice);
