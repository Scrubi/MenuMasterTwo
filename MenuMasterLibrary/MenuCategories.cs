using System;
using System.Collections.Generic;
using System.Text;

namespace MenuMasterLibrary
{
	public class MenuCategories
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

		public MenuCategories(string name)
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
					return SortDishesByName();
				case SortingMode.ByPrice:
					return SortDishesByPrice();
				default:
					return Dishes;
			}
		}

		public List<Dish> SortDishesByName()
		{
			List<Dish> newList = new List<Dish>(Dishes);
			newList.Sort((a, b) => a.Name.CompareTo(b.Name));
			return newList;
		}

		public List<Dish> SortDishesByPrice()
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