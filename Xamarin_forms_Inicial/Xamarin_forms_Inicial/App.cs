using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Xamarin_forms_Inicial
{
	public class App : Application
	{
		public App ()
		{
			// Pantalla principal
			MainPage = new ContentPage {
                //Contenido (PANEL) de la pantalla principal
				Content = new StackLayout {
                    //Seteo de controles en el PANEL
                    VerticalOptions = LayoutOptions.Center,
                    //Controles heredados del Layout
                    Children = {
						new Label {
							HorizontalTextAlignment = TextAlignment.Center,
							Text = "Welcome to Xamarin Forms! - El peluca sapbeee..!"
						}
					}
				}
			};
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
