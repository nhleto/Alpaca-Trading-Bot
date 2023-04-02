using Alpaca.Markets;
using Microsoft.Extensions.Configuration;
using Candlesticks.Models;

var config = new ConfigurationBuilder()
  .SetBasePath(Directory.GetCurrentDirectory())
  .AddJsonFile($"appsettings.json", true, true)
  .AddJsonFile("appsettings.local.json", true, true)
  .Build();

var endpoint = config.GetSection("AlpacaApi:Endpoint").Value ??= string.Empty;;
var key = config.GetSection("AlpacaApi:Key").Value ??= string.Empty;;
var secret = config.GetSection("AlpacaApi:Secret").Value ??= string.Empty;

var alpacaApi = new AlpacaApi
{
  Endpoint = endpoint,
  Key = key,
  Secret = secret
};

var client = Environments.Paper.GetAlpacaTradingClient(new SecretKey(alpacaApi.Key, alpacaApi.Secret));

var account = await client.GetAccountAsync();

Console.WriteLine(account.ToString());