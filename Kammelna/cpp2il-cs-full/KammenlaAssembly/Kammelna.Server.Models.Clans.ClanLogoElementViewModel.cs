using System;
using System.Collections.Generic;

namespace Kammelna.Server.Models.Clans;

[Serializable]
public class ClanLogoElementViewModel
{
	public int Id;

	public ClanLogoElementType Type;

	public string Label;

	public List<ClanLogoElementTierViewModel> Tiers;
}
