namespace Banco_CarteiraClientes
{
    class TradeCategorizer
    {
        public List<string> CategorizeTrades(List<ITrade> portfolio)
        {
            List<string> tradeCategories = new List<string>();
            foreach (var trade in portfolio)
            {
                if (trade.Value < 1000000 && trade.ClientSector == "Public")
                    tradeCategories.Add("LOWRISK");
                else if (trade.Value >= 1000000 && trade.ClientSector == "Public")
                    tradeCategories.Add("MEDIUMRISK");
                else if (trade.Value >= 1000000 && trade.ClientSector == "Private")
                    tradeCategories.Add("HIGHRISK");
            }
            return tradeCategories;
        }
    }
}
