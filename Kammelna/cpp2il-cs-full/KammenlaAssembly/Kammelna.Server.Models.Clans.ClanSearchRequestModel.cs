using System;

namespace Kammelna.Server.Models.Clans;

[Serializable]
public class ClanSearchRequestModel
{
	public string Query;

	public ClanSearchSort Sort;

	public int Page;

	public int PageSize;

	public Games Game;
}
