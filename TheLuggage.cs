using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheLuggage
{
    public class TheLuggage : Mod
    {
        //public override void SetModInfo(out string name, ref ModProperties properties)
        //{
        //    name = "TheLuggage";
        //    properties.Autoload = true;
        //    properties.AutoloadGores = true;
        //    properties.AutoloadSounds = true;
        //}
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