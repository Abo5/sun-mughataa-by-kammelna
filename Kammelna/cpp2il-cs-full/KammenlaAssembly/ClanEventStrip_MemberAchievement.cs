using System;
using System.Data.SqlTypes;
using System.Diagnostics;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using ListView;
using Managers.Achievemenets;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ClanEventStrip_MemberAchievement : ClanEventStrip
{
	private Image achievementImage;

	private GameObject loadingIndicator;

	private Transform achievementAnchor;

	private Transform trophyAnchor;

	public override void Initialize(ClanFeedModel model)
	{
		//IL_0052: Expected I, but got O
		//IL_007b: Expected O, but got I4
		//IL_00af: Expected O, but got I
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Expected O, but got Unknown
		//IL_0144: Expected O, but got I
		//IL_0152: Expected I, but got O
		//IL_017e: Expected O, but got I
		//IL_018d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0192: Expected O, but got Unknown
		//IL_01bc: Expected O, but got I4
		//IL_0326: Expected O, but got I
		//IL_0235: Expected O, but got I4
		//IL_0277: Expected O, but got I4
		//IL_02c1: Expected O, but got I
		//IL_02d1: Expected I, but got O
		//IL_02e1: Expected O, but got I
		//IL_02f1: Expected O, but got I
		ClanFeedData clanFeedData = model.Data;
		if (model.Data == null)
		{
			return;
		}
		object typeFromHandle = typeof(MemberAchievementClanFeedData);
		object obj = typeFromHandle;
		nint num = (nint)clanFeedData;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X9_v3 (Il2CppClass<Kammelna.Server.Models.Clans.ClanFeedData>)+130]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X8_v7+130]");
		bool flag = num2 < 0;
		object obj2 = !flag;
		object obj3 = ~obj2;
		if (obj3 != null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X9_v3 (Il2CppClass<Kammelna.Server.Models.Clans.ClanFeedData>)+C8]");
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X8_v7+130]");
		object obj4 = num3 + 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ X9_v5-8]");
		if (0 != (nint)obj)
		{
			return;
		}
		GameObject gameObject = achievementImage.gameObject;
		gameObject.SetActive(value: false);
		loadingIndicator.SetActive(value: true);
		InitializeAvatar(model);
		object obj5 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1304;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj6 = (nint)0 + (nint)968;
		Action<bool> action = default(Action<bool>);
		action..ctor((object)this, (IntPtr)obj6);
		Image img = achievementImage;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X24_v2 (Kammelna.Server.Models.Clans.ClanFeedData)+38]");
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X24_v2 (Kammelna.Server.Models.Clans.ClanFeedData)+40]");
		UIExtensions.LoadAchievementImage(img, (string)num4, 0, action);
		object obj7 = typeof(SqlSingle[]) + 2360;
		object obj8 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X8_v14+E4]");
		bool flag2 = (nint)0 == 0;
		object obj9 = !flag2;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X24_v2 (Kammelna.Server.Models.Clans.ClanFeedData)+38]");
		GameAchievementViewModel achievement = AchievementsManager.GetAchievement((string)0);
		Transform transform = achievementImage.transform;
		Transform transform2;
		if (achievement.<type>k__BackingField != AchievementType.Achievement)
		{
			transform2 = trophyAnchor;
			bool flag3 = (object)trophyAnchor == null;
			object obj10 = !flag3;
			if (obj10 == null)
			{
				throw new NullReferenceException();
			}
		}
		else
		{
			transform2 = achievementAnchor;
		}
		Vector3 position = transform2.position;
		transform.position = (Vector3)0;
		bool flag4 = string.IsNullOrEmpty(achievement.<description>k__BackingField);
		TextMeshProUGUI textMeshProUGUI = text;
		if (flag4)
		{
			object obj11 = (nint)0 + (nint)2000;
			object obj12 = obj11;
			nint num5 = (nint)textMeshProUGUI;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ X8_v19 (Il2CppClass<TMPro.TextMeshProUGUI>)+558]");
			object obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ X8_v19 (Il2CppClass<TMPro.TextMeshProUGUI>)+560]");
			object obj14 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v186 @ X3_v4 (should have been resolved before IL gen)");
		}
		TextMeshProExtensions.FixArabic(textMeshProUGUI, achievement.<description>k__BackingField);
	}

	private void ShowAchievementImage(bool val)
	{
		GameObject gameObject = achievementImage.gameObject;
		gameObject.SetActive(val);
		bool active = (byte)((val ? 1u : 0u) ^ 1u) != 0;
		loadingIndicator.SetActive(active);
	}

	public ClanEventStrip_MemberAchievement()
	{
		((ListViewItem<object, int>)(object)this)..ctor();
	}
}
