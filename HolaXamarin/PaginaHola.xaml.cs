using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace HolaXamarin
{
	public partial class PaginaHola : ContentPage
	{
		public PaginaHola ()
		{
			InitializeComponent ();
		}

		void btnSaludar_Clicked (object sender, EventArgs e)
		{
			string nombre = txtNombre.Text;
			string mensaje = String.Format ("Hola {0} desde Xamarin.Forms", nombre);

			DisplayAlert ("Saludos", mensaje, "OK");
		}
	}
}