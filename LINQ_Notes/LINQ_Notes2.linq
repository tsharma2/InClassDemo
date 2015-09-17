<Query Kind="Program">
  <Connection>
    <ID>c1aef02f-b6e3-443a-b747-6ea666629fb1</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>eRestaurant</Database>
  </Connection>
</Query>

void Main()
{
	var results = from food in Items
	
		where food.MenuCategory.Description.Equals("Entree") &&
				food.Active
		orderby food.CurrentPrice  descending
		select new FoodMargin()
			{
				Description = food.Description,
				Price = food.CurrentPrice,
				Cost = food.CurrentCost,
				Profit =  food.CurrentPrice - food.CurrentCost
			};
		results.Dump();
		
	var result2 = from orders in Bills
		where orders.PaidStatus &&
					(orders.BillDate.Month == 9 && orders.BillDate.Year == 2014)
					orderby orders.Waiter.LastName, orders.Waiter.FirstName
					select new BillOrders()
					{	
						BillID = orders.BillID,
						Waiter = orders.Waiter.LastName + "," + orders.Waiter.FirstName,
						Order = orders.BillItems
					};
		result2.Dump();
	}				
			
		//Defing methods and class
		//sample of poco type class 
		public class FoodMargin
		{
			public string Description {get;set;}
			public decimal Price {get;set;}
			public decimal Cost {get;set;}
			public decimal Profit {get;set;}
		}
		
		
		//Sample of a DTO type class : flat data set with possible structures
		public class BillOrders
		{
			public int BillID{get;set;}
			public string Waiter {get;set;}
			public IEnumerable Order {get;set;}
		}



