using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine.Rendering;

namespace Kammelna.Server.Models.Clans;

[Serializable]
public class ClanLogoElementTierViewModel
{
	public int Tier;

	public List<ImageInfoModel<ImageCacher.ClanLogoElementImageType>> Images;

	public ClanLogoElementTierViewModel()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		object obj = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 3640;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list = default(List<object>);
		list..ctor();
		object obj2 = this + 24;
		obj2 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		base..ctor();
	}
}
