using Terraria;
using Terraria.ModLoader;

namespace TheLuggage.Buffs
{
	public class TheLuggageBuff : ModBuff
	{
		public override void SetDefaults()
		{
			Main.buffNoTimeDisplay[Type] = true;
			DisplayName.SetDefault("The Luggage");
			Description.SetDefault("Half suitcase, half homicidal maniac");
			Main.vanityPet[Type] = true;
		}

		public override void Update(Player player, ref int buffIndex)
		{
			player.buffTime[buffIndex] = 18000;
			TheLuggagePlayer modPlayer = player.GetModPlayer<TheLuggagePlayer>();
			modPlayer.theLuggagePet = true;
			//player.truffle = true;
			bool theLuggageNotSpawned = true;

			if (player.ownedProjectileCounts[mod.ProjectileType<Projectiles.TheLuggagePet>()] > 0)
			{
				theLuggageNotSpawned = false;
			}
			if (theLuggageNotSpawned && player.whoAmI == Main.myPlayer)
			{
				Projectile.NewProjectile(player.position.X + (float)(player.width / 2) * 2, player.position.Y + (float)(player.height / 2), 0f, 0f, mod.ProjectileType<Projectiles.TheLuggagePet>(), 0, 0f, player.whoAmI, 0f, 0f);
			}
		}
	}
}
