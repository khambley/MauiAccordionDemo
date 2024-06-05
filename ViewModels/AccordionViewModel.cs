using System;
using CommunityToolkit.Mvvm.ComponentModel;

namespace MauiAccordionExpanderDemo.ViewModels
{
	public class Person : Tuple<string, string>
	{
		public Person(string item1, string item2) : base(item1, item2) { }
	}

	public partial class AccordionViewModel : ObservableObject
	{
		[ObservableProperty]
		List<Person>? people;

		public AccordionViewModel()
		{
			People = new List<Person>
			{
				new("Jane", "Wants to be an actress"),
				new("John", "Wants to be a rock musician"),
				new("Jasmine", "Wants to be a heart surgeon")
			};
		}
	}
}

