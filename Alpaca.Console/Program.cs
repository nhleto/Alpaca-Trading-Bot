using Microsoft.Extensions.Configuration;

var config = new ConfigurationBuilder()
  .SetBasePath(Directory.GetCurrentDirectory())
  .AddJsonFile($"appsettings.json", true, true)
  .AddJsonFile("appsettings.local.json", true, true)
  .Build();

var alpacaApi = config.GetSection("AlpacaApi:Endpoint");

