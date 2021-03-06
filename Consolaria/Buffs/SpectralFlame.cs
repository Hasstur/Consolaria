using Terraria;
using Terraria.ModLoader;

namespace Consolaria.Buffs
{
	public class SpectralFlame : ModBuff
	{
		public override void SetDefaults()
		{
			DisplayName.SetDefault("Spectral Flames");
			Description.SetDefault("Losing life");
			Main.debuff[Type] = true;
			Main.pvpBuff[Type] = true;
			Main.buffNoSave[Type] = true;
			longerExpertDebuff = true;
		}

		public override void Update(Player player, ref int buffIndex)
		{
			player.GetModPlayer<CPlayer>().sFlames = true;
		}

		public override void Update(NPC npc, ref int buffIndex)
		{
			npc.GetGlobalNPC<CGlobalNPC>().sFlames = true;
		}
	}
}
