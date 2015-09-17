<Query Kind="Expression">
  <Connection>
    <ID>c1aef02f-b6e3-443a-b747-6ea666629fb1</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>eRestaurant</Database>
  </Connection>
</Query>

//view waiter data
Waiters

//query to also view waiter data
from item in Waiters
select item

//method syntax to view waiter data
Waiters.select (item=>item)

//alter the query syntax into a c# statement
var results = from item in Waiters
				select item;
results.Dump();

public List<pocoObject> SomeBLLMethodName()
{
	//Content to your DAL object : var contextvariable do your query
	
	var results = from item in contextvariable.Waiters
					select item;
		return results.ToList();
}

//list all tables that hold more than 3 people
from row in Tables
where row.Capacity > 3
select row

//list all items that have more than 500 calories and selling for more than 10.00
from row in Items
where row.Calories > 500 && row.CurrentPrice > 10.00m
select row


//list all items that have more than 500 calories and are ENTREES on the menu
from row in Items
where row.Calories > 500 &&
		row.MenuCategory.Description.Equals("Entree")
select row

//Orderby

from food in Items
orderby food.Description
select food

from food in Items
orderby food.CurrentPrice descending
select food

//orderby and where 
from food in Items
orderby food.CurrentPrice descending, food.Calories ascending
where food.MenuCategory.Description.Equals("Entree")
select food

//grouping
from food in Items
group food by food.MenuCategory.Description

//requires the creation of an anonymus type
from food in Items
group food by new {food.MenuCategory.Description, food.CurrentPrice}

from food in Items
where food.MenuCategory.Description.Equals("Entree") &&
		food.Active
orderby food.CurrentPrice  descending
select new FoodMargin()
	{
		Description = food.Description,
		CurrentPrice = food.CurrenPrice,
		CurrentCost = food.CurrentCost,
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