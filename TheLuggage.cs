using Terraria.ModLoader;

namespace TheLuggage
{
	public class TheLuggage : Mod
	{
		public TheLuggage()
		{
			Properties = new ModProperties()
			{
				Autoload = true,
				AutoloadGores = true,
				AutoloadSounds = true
			};
		}
	}
}