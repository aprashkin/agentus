using System;
using System.Collections.Generic;

namespace agentus.Models;

public class Sell
{
    public string AgentName { get; set; }
    public int CountSells { get; set; }
    public DateTime DateSell { get; set; }
}

public class SellsList
{
    public List<Sell> ListSellsList = new List<Sell>();
}