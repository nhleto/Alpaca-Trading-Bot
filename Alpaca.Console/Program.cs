// See https://aka.ms/new-console-template for more information
using Microsoft.Extensions.Configuration;

Console.WriteLine("Hello, World!");

var builder = new ConfigurationBuilder()
  .AddJsonFile($"appsettings.json", true, true)
  .AddJsonFile("appsettings.local.json", true, true);

var config = builder.Build();
