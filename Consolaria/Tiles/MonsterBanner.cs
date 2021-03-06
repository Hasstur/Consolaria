using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.DataStructures;
using Terraria.Enums;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace Consolaria.Tiles
{
	public class MonsterBanner : ModTile
	{
		public override void SetDefaults()
		{
			Main.tileFrameImportant[Type] = true;
			Main.tileNoAttach[Type] = true;
			Main.tileLavaDeath[Type] = true;
			TileObjectData.newTile.CopyFrom(TileObjectData.Style1x2Top);
			TileObjectData.newTile.Height = 3;
			TileObjectData.newTile.CoordinateHeights = new[] { 16, 16, 16 };
			TileObjectData.newTile.StyleHorizontal = true;
			TileObjectData.newTile.AnchorTop = new AnchorData(AnchorType.SolidTile | AnchorType.SolidSide | AnchorType.SolidBottom, TileObjectData.newTile.Width, 0);
			TileObjectData.newTile.StyleWrapLimit = 111;
			TileObjectData.addTile(Type);
			dustType = -1;
			disableSmartCursor = true;
			ModTranslation name = CreateMapEntryName();
			name.SetDefault("Banner");
			AddMapEntry(new Color(13, 88, 130), name);
		}
		public override void KillMultiTile(int i, int j, int frameX, int frameY) {
			int style = frameX / 18;
			string item;
			switch (style) {
				case 0:
					item = "ArchWyvernBanner";
					break;
				case 1:
					item = "DragonSnatcherBanner";
					break;
				case 2:
					item = "SpectralElementalBanner";
					break;
				case 3:
					item = "SpectralGastropodBanner";
					break;
				case 4:
					item = "ShadowMummyBanner";
					break;
				case 5:
					item = "ShadowHammerBanner";
					break;
				case 6:
					item = "VampireMinerBanner";
					break;
				case 7:
					item = "OrcaBanner";
					break;
				case 8:
					item = "AlbinoAntlionBanner";
					break;
				case 9:
					item = "SpectralMummyBanner";
					break;
				case 10:
					item = "DragonHornetBanner";
					break;
				case 11:
					item = "ArchDemonBanner";
					break;
				case 12:
					item = "ShadowSlimeBanner";
					break;
				case 13:
					item = "DisasterBunnyBanner";
					break;
				case 14:
					item = "MythicalWyvernBanner";
					break;
				case 15:
					item = "DragonSkullBanner";
					break;
				default:
					return;
			}
			Item.NewItem(i * 16, j * 16, 16, 48, mod.ItemType(item));
		}

		public override void NearbyEffects(int i, int j, bool closer)
		{
			if (closer) {
				Player player = Main.LocalPlayer;
				int style = Main.tile[i, j].frameX / 18;
				string type;
				switch (style) {
					case 0:
						type = "ArchWyvernBanner";
						break;
					case 1:
						type = "DragonSnatcherBanner";
						break;
					case 2:
						type = "SpectralElementalBanner";
						break;
					case 3:
						type = "SpectralGastropodBanner";
						break;
					case 4:
						type = "ShadowMummyBanner";
						break;
					case 5:
						type = "ShadowHammerBanner";
						break;
					case 6:
						type = "VampireMinerBanner";
						break;
					case 7:
						type = "OrcaBanner";
						break;
					case 8:
						type = "AlbinoAntlionBanner";
						break;
					case 9:
						type = "SpectralMummyBanner";
						break;
					case 10:
						type = "DragonHornetBanner";
						break;
					case 11:
						type = "ArchDemonBanner";
						break;
					case 12:
						type = "ShadowSlimeBanner";
						break;
					case 13:
						type = "DisasterBunnyBanner";
						break;
					case 14:
						type = "MythicalWyvernBanner";
						break;
					case 15:
						type = "DragonSkullBanner";
						break;
					default:
						return;
				}
				player.NPCBannerBuff[mod.NPCType(type)] = true;
				player.hasBanner = true;
			}
		}
		public override void SetSpriteEffects(int i, int j, ref SpriteEffects spriteEffects)
		{
			if (i % 2 == 1)
			{
				spriteEffects = SpriteEffects.FlipHorizontally;
			}
		}
	}
}
