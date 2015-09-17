<Query Kind="Expression">
  <Connection>
    <ID>c1aef02f-b6e3-443a-b747-6ea666629fb1</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>eRestaurant</Database>
  </Connection>
</Query>

from category in MenuCategories
select new
{
	Category = category.Description,
	Items =  category.Count()
}

from category in MenuCategories
select new
{
	Category = category.Description,
	Items = (from x in category.Items
				select x).Count()
}
//Average number of items per bill
(from customer in Bills
where customer.PaidStatus == true
select customer.BillItems.Count()).Average()