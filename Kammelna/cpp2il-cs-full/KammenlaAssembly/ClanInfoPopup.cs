using Cpp2ILInjected;
using DataTracking;
using Kammelna.Server.Models.Clans;
using TMPro;
using UnityEngine;
using UnityEngine.Purchasing.Telemetry;

public class ClanInfoPopup : MonoBehaviour
{
	private ClanCard card;

	private TextMeshProUGUI clanName;

	public void Initialize(ClanModel model)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_00c8: Expected O, but got I4
		//IL_007a: Expected O, but got I4
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Expected O, but got Unknown
		//IL_0118: Expected O, but got I
		//IL_00f3: Expected O, but got I4
		//IL_0161: Expected O, but got I4
		//IL_0091: Expected O, but got I4
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		card.Initialize(model);
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X0_v5+E4]");
		object obj4;
		if ((nint)0 != 0)
		{
			bool flag = clanName;
			bool flag2 = !flag;
			object obj3 = !flag2;
			if (obj3 != null)
			{
				goto IL_00d6;
			}
			obj4 = 0;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag3 = clanName;
			bool flag4 = !flag3;
			obj4 = 0;
			if (!flag4)
			{
				goto IL_00d6;
			}
		}
		goto IL_00f8;
		IL_00f8:
		object obj5 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		object obj6 = (nint)0 + (nint)56;
		bool isMember = ClanModelExtensions.ContainsMe(model);
		ITrackEvent trackEvent = TrackerLibrary.ClanInfoViewed(isMember);
		object obj7 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X8_v5+E4]");
		bool flag5 = (nint)0 == 0;
		object obj8 = !flag5;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Tracker.DesignEvent(trackEvent);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
		SlideAnimationHelper slideAnimationHelper = default(SlideAnimationHelper);
		slideAnimationHelper.SlideIn();
		return;
		IL_00d6:
		TextMeshProExtensions.FixArabic(clanName, model.Name);
		obj4 = 0;
		goto IL_00f8;
	}
}
