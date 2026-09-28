using System.Collections.Generic;
using Cpp2ILInjected;
using DG.Tweening;
using Kammelna.Server.Models.Clans;
using ListView;
using Newtonsoft.Json.Linq.JsonPath;
using TMPro;
using UnityEngine;

public class ClanEventStrip_Vote : ClanEventStrip
{
	private voteOptionComponent optionStripTemplate;

	private Transform layout;

	private TextMeshProUGUI voteText;

	private TextMeshProUGUI voterCount;

	private List<voteOptionComponent> _strips;

	private VoteModel _voteModel;

	private bool _isVoted;

	public override void Initialize(ClanFeedModel model)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Expected O, but got Unknown
		//IL_00dd: Expected O, but got I4
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected O, but got Unknown
		object obj = 152993792;
		object obj2 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1144;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E85D6]");
		object obj3 = (nint)0 & (nint)1;
		object obj4;
		object obj6;
		if (obj3 != null)
		{
			obj4 = "Cannot populate JSON object onto type '{0}'." + 2936;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v1+E4]");
			bool flag = (nint)0 == 0;
			obj6 = obj4;
			if (!flag)
			{
				goto IL_0094;
			}
		}
		else
		{
			_ = 1;
			obj4 = "Cannot populate JSON object onto type '{0}'." + 2936;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v1+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj6 = obj4;
			if (obj7 != null)
			{
				goto IL_0094;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		KLogger.LogWarning(obj6);
		return;
		IL_0094:
		KLogger.LogWarning(obj4);
	}

	public ClanEventStrip_Vote()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected O, but got Unknown
		object obj = typeof(List<Tween>) + 512;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list = default(List<object>);
		list..ctor();
		object obj2 = this + 184;
		obj2 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		((ListViewItem<object, int>)(object)this)..ctor();
	}
}
