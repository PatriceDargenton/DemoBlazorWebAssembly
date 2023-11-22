using Microsoft.AspNetCore.Components;

namespace BlazorAppWA.Pages
{
	// D'après :
	// [TUTORIAL POUR DÉBUTANT] Découverte de BLAZOR - Créer des applications web DE FOLIE
	// https://www.youtube.com/watch?v=bPJOASSGKrQ

	public class NombreMagiqueBase : ComponentBase
    {
        protected const int NbLifesMax = 5;
		protected const int NbMax = 10;

		protected int value;

		protected int nbMagic;
		protected int nbRemainingLifes;
		protected bool? gameWon;

		protected override void OnInitialized()
		{
			ReinitGame();
			base.OnInitialized();
		}

		protected void ReinitGame()
		{
			var random = new Random();
			nbMagic = random.Next(NbMax);
			nbRemainingLifes = NbLifesMax;
			gameWon = null;
			value = 0;
		}

		protected void TestNumber() 
		{ 
			if (value == nbMagic)
			{
				gameWon = true;
			}
            else
            {
				nbRemainingLifes--;
				if (nbRemainingLifes == 0)
				{
					gameWon = false;
				}
            }
        }
	}
}
