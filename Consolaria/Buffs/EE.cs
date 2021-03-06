using Terraria;
using Terraria.ModLoader;

namespace Consolaria.Buffs
{
	public class EE : ModBuff
	{
		public override void SetDefaults()
		{
			DisplayName.SetDefault("Eye of Eternity");
			Description.SetDefault("Eye of Eternity will fight for you");
			Main.buffNoSave[Type] = true;
			Main.buffNoTimeDisplay[Type] = true;
		}

		public override void Update(Player player, ref int buffIndex)
		{
			CPlayer modPlayer = (CPlayer)player.GetModPlayer(mod, "CPlayer");
			if (player.ownedProjectileCounts[mod.ProjectileType("EternityStaffPro")] > 0)
			{
				modPlayer.eternityEye = true;
			}
			if (!modPlayer.eternityEye)
			{
				player.DelBuff(buffIndex);
				buffIndex--;
			}
			else
			{
				player.buffTime[buffIndex] = 18000;
			}
		}
	}
}