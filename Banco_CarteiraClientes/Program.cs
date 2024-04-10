// See https://aka.ms/new-console-template for more information
using Banco_CarteiraClientes;


    List<ITrade> portfolio = new List<ITrade>
        {
            new Trade { Value = 2000000, ClientSector = "Private" },
            new Trade { Value = 400000, ClientSector = "Public" },
            new Trade { Value = 500000, ClientSector = "Public" },
            new Trade { Value = 3000000, ClientSector = "Public" }
        };

    TradeCategorizer categorizer = new TradeCategorizer();
    List<string> tradeCategories = categorizer.CategorizeTrades(portfolio);

    foreach (var category in tradeCategories)
    {
        Console.WriteLine(category);
    }

