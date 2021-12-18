using Core.Abstractions;
using Core.Interfaces;
using HtmlAgilityPack;
using StatementModule.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatementModule.DataAccess
{
    public class StatementMt4Parser : Parser, IParser<Statement>
    {
        public Statement ParsedStatement { get; set; } = new Statement();

        public Statement GetData()
        {
            return ParsedStatement;
        }

        public override bool TryParse(string input)
        {
            var doc = new HtmlDocument();
            doc.LoadHtml(input);

            var rows = doc.DocumentNode.SelectNodes("//table//tr");
            foreach (var row in rows)
            {
                if (row.ChildNodes.Count == 14)
                {
                    if (row.ChildNodes[8].InnerText.Equals("&nbsp;")) continue;

                    try
                    {
                        Transaction trans = new Transaction();
                        trans.Ticket = int.Parse(row.ChildNodes[0].InnerText);
                        trans.TimeOpen = DateTime.Parse(row.ChildNodes[1].InnerText);
                        trans.Type = ParserTransactionType(row.ChildNodes[2].InnerText);
                        trans.Size = ParseDouble(row.ChildNodes[3].InnerText);
                        trans.Item = row.ChildNodes[4].InnerText;
                        trans.PriceOpen = ParseDouble(row.ChildNodes[5].InnerText);
                        trans.StopLoss = ParseDouble(row.ChildNodes[6].InnerText);
                        trans.TakeProfit = ParseDouble(row.ChildNodes[7].InnerText);
                        trans.TimeClose = DateTime.Parse(row.ChildNodes[8].InnerText);
                        trans.PriceClose = ParseDouble(row.ChildNodes[9].InnerText);
                        trans.Commision = ParseDouble(row.ChildNodes[10].InnerText);
                        trans.Taxes = ParseDouble(row.ChildNodes[11].InnerText);
                        trans.Swap = ParseDouble(row.ChildNodes[12].InnerText);
                        trans.Profit = ParseDouble(row.ChildNodes[13].InnerText);

                        ParsedStatement.ClosedTrades.Add(trans);
                    }
                    catch (Exception ex)
                    {
                        AddError(ex.Message);
                        throw;
                    }
                }
            }

            return true;
        }

        private double ParseDouble(string innerText)
        {
            string text = innerText.Replace('.', ',');

            double parsedDouble;
            if (double.TryParse(text, out parsedDouble))
            {
                return parsedDouble;
            }

            return 0D;
        }

        private TransactionType ParserTransactionType(string innerText)
        {
            string text = innerText.Trim().ToLower();

            if (text.Equals("sell"))
            {
                return TransactionType.Sell;
            }
            else if (text.Equals("buy"))
            {
                return TransactionType.Buy;
            }
            else if (text.Equals("sell limit"))
            {
                return TransactionType.SellLimit;
            }
            else if (text.Equals("buy limit"))
            {
                return TransactionType.BuyLimit;
            }
            else if (text.Equals("buy stop"))
            {
                return TransactionType.StopBuy;
            }
            else if (text.Equals("sell stop"))
            {
                return TransactionType.StopSell;
            }

            return TransactionType.Unrecognized;
        }
    }
}
