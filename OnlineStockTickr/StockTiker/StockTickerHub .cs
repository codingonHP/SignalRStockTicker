﻿using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;
using OnlineStockTickr.Models;
using System.Collections.Generic;

namespace OnlineStockTickr.StockTiker
{
	[HubName("stockTickerMini")]
	public class StockTickerHub : Hub
	{
		private readonly StockTicker _stockTicker;

		public StockTickerHub() : this(StockTicker.Instance) { }

		public StockTickerHub(StockTicker stockTicker)
		{
			_stockTicker = stockTicker;
		}

		public IEnumerable<Stock> GetAllStocks()
		{
			return _stockTicker.GetAllStocks();
		}
	}
}