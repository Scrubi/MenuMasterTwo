using System;
using System.Collections.Generic;
using System.Text;

namespace MenuMasterLibrary
{
	public class MenuCategory
	{
		private List<Dish> dishes = new List<Dish>();

		
		public string Name { get; set; }

	
		public List<Dish> Dishes
		{
			get { return dishes; }
		}

		public enum SortingMode
		{
			Default = 1,
			ByName,
			ByPrice
		}

		public MenuCategory(string name)
		{
			this.Name = name;
		}

		public void AddDish(Dish dish)
		{
			dishes.Add(dish);
		}

		public List<Dish> GetDishes(SortingMode sorting)
		{
			switch (sorting)
			{
				case SortingMode.ByName:
					return GetDishesSortedByName();
				case SortingMode.ByPrice:
					return GetDishesSortedByPrice();
				default:
					return Dishes;
			}
		}

		public List<Dish> GetDishesSortedByName()
		{
			List<Dish> newList = new List<Dish>(Dishes);
			newList.Sort((a, b) => a.Name.CompareTo(b.Name));
			return newList;
		}

		public List<Dish> GetDishesSortedByPrice()
		{
			List<Dish> newList = new List<Dish>(Dishes);
			newList.Sort((a, b) => a.Price.CompareTo(b.Price));
			return newList;
		}

		public bool RemoveDish(int index)
		{
			if (index >= 0 && index < dishes.Count)
			{
				dishes.RemoveAt(index);
				return true;
			}
			return false;
		}

	}
}