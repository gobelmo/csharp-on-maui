using CsharpOnMaui.BusinessLogic;
using Microsoft.Maui.Layouts;

namespace CsharpOnMaui;

public partial class MainPage : ContentPage
{
	int count = 0;

	Car car1;
	Car car2;

	bool finish = false;
	public MainPage()
	{
		InitializeComponent();
		car1 = new Car("Ferrary", 2);
		car2 = new Car("Lumborghini", 4);
	}


	private async void Button_Clicked(object sender, EventArgs e)
	{
		if (!finish)
		{
			// Move image from left to right
			var screenWidth = Application.Current.MainPage.Width; // Get the screen width as distance
			Car1Run(screenWidth);
			Car2Run(screenWidth);
			finish = true;
		}
		else
		{
			await ImageCar1.TranslateTo(0, 0, 0, Easing.Linear);
			await ImageCar2.TranslateTo(0, 0, 0, Easing.Linear);
			finish = false;
		}
	}

	private async void Car1Run(double distance)
	{
		var car1TimeUse = car1.TimeUseForRunWithDistance(distance);
		await ImageCar1.TranslateTo(distance - 100, 0, car1TimeUse * 10, Easing.Linear);
	}

	private async void Car2Run(double distance)
	{
		var car2TimeUse = car2.TimeUseForRunWithDistance(distance);
		await ImageCar2.TranslateTo(distance - 100, 0, car2TimeUse * 10, Easing.Linear);
	}




}

