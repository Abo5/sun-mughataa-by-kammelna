using System;
using System.Collections.Generic;

namespace Kammelna.Server.Models.Clans;

[Serializable]
public class ClanSearchResponse
{
	public List<ClanSummaryModel> Results;

	public int Page;

	public int PageSize;

	public ClanSearchSort Sort;
}
