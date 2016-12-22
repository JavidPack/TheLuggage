using Terraria.ModLoader;

namespace TheLuggage
{
	public class TheLuggagePlayer : ModPlayer
	{
		public bool theLuggagePet = false;

		public override void ResetEffects()
		{
			theLuggagePet = false;
		}
	}
}
