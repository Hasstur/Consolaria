using Terraria;
using Terraria.ModLoader;

namespace Consolaria.Buffs
{
	public class GoldenTurtle : ModBuff
	{
		public override void SetDefaults()
		{
			DisplayName.SetDefault("Golden Turtle");
			Description.SetDefault("Rare turtle");
			Main.buffNoTimeDisplay[Type] = true;
			Main.vanityPet[Type] = true;
		}

		public override void Update(Player player, ref int buffIndex)
		{
			player.buffTime[buffIndex] = 18000;
			CPlayer modPlayer = (CPlayer)player.GetModPlayer(mod, "CPlayer");
			modPlayer.GTurtle = true;
			bool petProjectileNotSpawned = true;
			if (player.ownedProjectileCounts[mod.ProjectileType("GoldenTurtle")] > 0)
			{
				petProjectileNotSpawned = false;
			}
			if (petProjectileNotSpawned && player.whoAmI == Main.myPlayer)
			{
				Projectile.NewProjectile(player.position.X + player.width / 2, player.position.Y + player.height / 2, 0f, 0f, mod.ProjectileType("GoldenTurtle"), 0, 0f, player.whoAmI, 0f, 0f);
			}
		}
	}
}