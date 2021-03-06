﻿using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Consolaria.NPCs
{
	public class ShadowMummy : ModNPC
	{		
		public override void SetDefaults()
		{
			npc.width = 40;
			npc.height = 40;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath6;
			npc.damage = 60;
			npc.defense = 15;
			npc.lifeMax = 220;
			npc.value = Item.buyPrice(0, 0, 8, 0);
			npc.knockBackResist = 0.1f;
			npc.noGravity = false;
			npc.aiStyle = 3;
			npc.lavaImmune = false;
			Main.npcFrameCount[npc.type] = 15;
			aiType = 78;
			animationType = 78;
			banner = npc.type;
			bannerItem = mod.ItemType("ShadowMummyBanner");
		}
		
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Shadow Mummy");
		}
		
		public override void ScaleExpertStats(int numPlayers, float bossLifeScale)
		{
			npc.lifeMax = npc.lifeMax;
			npc.damage = npc.damage;
		}

		public override void HitEffect(int hitDirection, double damage)
		{
			Dust.NewDust(base.npc.position, base.npc.width, base.npc.height, 109, 2.5f * (float)hitDirection, -2.5f, 0, default(Color), 0.7f);
			if (base.npc.life <= 0)
			{
				Gore.NewGore(base.npc.position, base.npc.velocity / 2f, 99, 1f);
				Gore.NewGore(base.npc.position, base.npc.velocity / 2f, 99, 1f);
				Gore.NewGore(base.npc.position, base.npc.velocity / 2f, 99, 1f);
				for (int i = 0; i < 20; i++)
				{
					Dust.NewDust(base.npc.position, base.npc.width, base.npc.height, 109, 2.5f * (float)hitDirection, -2.5f, 0, default(Color), 1f);
				}
			}
		}
	
		public override float SpawnChance(NPCSpawnInfo spawnInfo)
		{
			int x = spawnInfo.spawnTileX;
			int y = spawnInfo.spawnTileY;
			int tile = (int)Main.tile[x, y].type;
			return (Consolaria.NormalSpawn(spawnInfo)  && spawnInfo.player.ZoneCorrupt && spawnInfo.player.ZoneUndergroundDesert && Main.hardMode && y < Main.rockLayer) ? 0.01f : 0f;
		}
	}
}
