using System;
using System.Buffers.Text;
using System.Collections.Generic;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TournamentInfoIcons : MonoBehaviour
{
	[Serializable]
	private class FormattedLabel
	{
		private TextMeshProUGUI label;

		private NumberFormatter formatter;

		public void Format(int value)
		{
			//IL_0021: Expected I, but got O
			//IL_0031: Expected O, but got I
			//IL_0041: Expected O, but got I
			NumberFormatter numberFormatter = formatter;
			TextMeshProUGUI textMeshProUGUI = label;
			nint num = (nint)numberFormatter;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v7 @ X8_v2 (Il2CppClass<NumberFormatter>)+178]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v7 @ X8_v2 (Il2CppClass<NumberFormatter>)+180]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v8 @ X4_v1 (should have been resolved before IL gen)");
			/*Error: End of method reached without returning.*/;
		}
	}

	private const string Cheating = "cheating";

	private const string NotCheating = "not cheating";

	private RoomInfoSprites roomInfoSprites;

	private Image cheatingIcon;

	private TextMeshProUGUI cheatingText;

	private FormattedLabel[] bestOfLabels;

	private FormattedLabel[] seatsLabels;

	private Image speedIcon;

	private GameObject cheatingIconObj;

	private GameObject voiceChatIcon;

	private GameObject clusterIcon;

	public void Initialize(TournamentData tournament)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0113: Expected O, but got I4
		//IL_00b4: Expected O, but got I4
		//IL_00bd: Expected O, but got I4
		//IL_0191: Unknown result type (might be due to invalid IL or missing references)
		//IL_0196: Expected O, but got Unknown
		//IL_00d4: Expected O, but got I4
		//IL_015b: Expected O, but got I4
		//IL_0164: Expected O, but got I4
		//IL_073a: Expected O, but got I4
		//IL_078b: Expected O, but got I
		//IL_084b: Expected O, but got I4
		//IL_0220: Unknown result type (might be due to invalid IL or missing references)
		//IL_0225: Expected O, but got Unknown
		//IL_022e: Expected O, but got I4
		//IL_07fa: Expected O, but got I4
		//IL_037e: Expected O, but got I
		//IL_0a1c: Expected O, but got I
		//IL_08b6: Expected O, but got I4
		//IL_0539: Expected O, but got I4
		//IL_02da: Unknown result type (might be due to invalid IL or missing references)
		//IL_02df: Expected O, but got Unknown
		//IL_02e8: Expected O, but got I4
		//IL_0243: Expected O, but got I
		//IL_08cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_08d2: Expected O, but got Unknown
		//IL_08dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_08e1: Expected O, but got Unknown
		//IL_0900: Expected O, but got I4
		//IL_0811: Expected O, but got I4
		//IL_088b: Expected O, but got I4
		//IL_03ed: Expected O, but got I4
		//IL_0a31: Expected O, but got I
		//IL_0260: Expected O, but got I
		//IL_0273: Unknown result type (might be due to invalid IL or missing references)
		//IL_0278: Expected O, but got Unknown
		//IL_05c6: Expected O, but got I4
		//IL_05cf: Expected O, but got I4
		//IL_05d8: Expected O, but got I4
		//IL_02fd: Expected O, but got I
		//IL_0a4c: Expected O, but got I
		//IL_0476: Expected O, but got I4
		//IL_0428: Expected O, but got I4
		//IL_043b: Expected O, but got I4
		//IL_031a: Expected O, but got I
		//IL_032d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0332: Expected O, but got Unknown
		//IL_09b3: Expected O, but got I4
		//IL_069e: Expected O, but got I4
		//IL_06a7: Expected O, but got I4
		//IL_06f9: Expected O, but got I4
		object obj = 152985600;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6DE8]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj6;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v99+E4]");
			bool flag = (nint)0 == 0;
			obj5 = cheatingIconObj;
			obj6 = cheatingIconObj;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			obj5 = cheatingIconObj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v99+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj6 = cheatingIconObj;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = obj6;
		bool flag4 = !flag3;
		object obj8 = 152985600;
		object obj9 = 152985600;
		if (!flag4)
		{
			goto IL_0172;
		}
		goto IL_01e9;
		IL_0956:
		if (!cheatingText)
		{
			goto IL_01e9;
		}
		goto IL_09f8;
		IL_04ce:
		UnityEngine.Object obj10;
		if ((bool)obj10)
		{
			goto IL_04f4;
		}
		return;
		IL_06c7:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		UnityEngine.Object obj11;
		bool flag5 = obj11;
		bool flag6 = !flag5;
		object obj12 = !flag6;
		if (obj12 == null)
		{
			return;
		}
		goto IL_04f4;
		IL_0091:
		bool flag7 = obj5;
		bool flag8 = !flag7;
		object obj13 = !flag8;
		obj8 = 152985600;
		if (obj13 != null)
		{
			goto IL_0172;
		}
		obj9 = 152985600;
		goto IL_01e9;
		IL_0172:
		cheatingIconObj.SetActive(value: false);
		object obj14 = typeof(System.Buffers.Text.ParserHelpers) + 1624;
		object obj15 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v323 @ X0_v60+E4]");
		if ((nint)0 != 0)
		{
			if (Preferences.CurrentGame != Games.Baloot)
			{
				goto IL_01e9;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Games currentGame = Preferences.CurrentGame;
			bool flag9 = currentGame == Games.Baloot;
			object obj16 = !flag9;
			if (obj16 != null)
			{
				goto IL_01e9;
			}
		}
		cheatingIconObj.SetActive(value: true);
		Sprite sprite = roomInfoSprites.GetCheatingIcon(tournament.<CheatingAllowed>k__BackingField);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X24_v6+DEA]");
		object obj17 = (nint)0 & (nint)1;
		if (obj17 != null)
		{
			object obj18 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v514 @ X0_v82+E4]");
			if ((nint)0 != 0)
			{
				goto IL_07d5;
			}
		}
		else
		{
			_ = 1;
			object obj18 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v514 @ X0_v82+E4]");
			bool flag10 = (nint)0 == 0;
			object obj19 = !flag10;
			if (obj19 != null)
			{
				goto IL_07d5;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag11 = cheatingIcon;
		bool flag12 = !flag11;
		object obj20 = 0;
		Sprite sprite2 = null;
		if (!flag12)
		{
			goto IL_089e;
		}
		goto IL_08c3;
		IL_0400:
		object obj21 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v552 @ X0_v21+E4]");
		bool flag13 = (nint)0 == 0;
		object obj22 = 0;
		UnityEngine.Object obj23 = voiceChatIcon;
		object obj24 = 0;
		UnityEngine.Object obj25 = voiceChatIcon;
		if (!flag13)
		{
			goto IL_0453;
		}
		goto IL_05f8;
		IL_01e9:
		FormattedLabel[] array = bestOfLabels;
		if (array.Length >= 1)
		{
			object obj26 = array + 32;
			object obj27 = 0;
			do
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X26_v7+v135 @ X25_v11*8]");
				object obj28 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ X8_v35+18]");
				object obj29 = 0;
				object obj30 = obj29;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v436 @ X8_v36+180]");
				object obj31 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v436 @ X8_v36+178] (should have been resolved before IL gen)");
				obj27++;
			}
			while ((nint)obj27 < array.Length);
		}
		FormattedLabel[] array2 = seatsLabels;
		int allowedSeats = tournament.AllowedSeats;
		if (array2.Length >= 1)
		{
			object obj32 = array2 + 32;
			object obj33 = 0;
			do
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X26_v6+v137 @ X25_v8*8]");
				object obj34 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v268 @ X8_v31+18]");
				object obj35 = 0;
				object obj36 = obj35;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v467 @ X8_v32+180]");
				object obj31 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v467 @ X8_v32+178] (should have been resolved before IL gen)");
				obj33++;
			}
			while ((nint)obj33 < array2.Length);
		}
		Sprite sprite3 = roomInfoSprites.GetSpeedIcon(tournament.<Timer>k__BackingField);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6DEA]");
		object obj37 = (nint)0 & (nint)1;
		if (obj37 != null)
		{
			object obj38 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v488 @ X0_v28+E4]");
			if ((nint)0 != 0)
			{
				goto IL_03c8;
			}
		}
		else
		{
			_ = 1;
			object obj38 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v488 @ X0_v28+E4]");
			bool flag14 = (nint)0 == 0;
			object obj39 = !flag14;
			if (obj39 != null)
			{
				goto IL_03c8;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag15 = speedIcon;
		bool flag16 = !flag15;
		Sprite sprite4 = null;
		if (flag16)
		{
			goto IL_0400;
		}
		goto IL_0583;
		IL_09f8:
		object text;
		TextMeshProExtensions.Localize(cheatingText, (string)text);
		goto IL_01e9;
		IL_063e:
		bool flag17 = ((Dictionary<System.Int32Enum, object>)(object)tournament.Addons).ContainsKey((System.Int32Enum)2);
		voiceChatIcon.SetActive(flag17);
		obj10 = clusterIcon;
		object obj40 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v612 @ X8_v10+E4]");
		bool flag18 = (nint)0 == 0;
		object obj41 = !flag18;
		obj22 = 0;
		bool flag19 = flag17;
		obj11 = clusterIcon;
		if (obj41 != null)
		{
			goto IL_04ce;
		}
		goto IL_06c7;
		IL_0583:
		speedIcon.sprite = sprite3;
		obj23 = voiceChatIcon;
		obj21 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v552 @ X0_v21+E4]");
		bool flag20 = (nint)0 == 0;
		object obj42 = !flag20;
		obj22 = 0;
		obj24 = 0;
		sprite4 = sprite3;
		obj25 = voiceChatIcon;
		if (obj42 != null)
		{
			goto IL_0453;
		}
		goto IL_05f8;
		IL_05f8:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag21 = obj25;
		bool flag22 = !flag21;
		obj22 = obj24;
		flag19 = false;
		if (flag22)
		{
			goto IL_048d;
		}
		goto IL_063e;
		IL_07d5:
		bool flag23 = cheatingIcon;
		bool flag24 = !flag23;
		object obj43 = !flag24;
		if (obj43 != null)
		{
			goto IL_089e;
		}
		obj20 = 0;
		sprite2 = null;
		goto IL_08c3;
		IL_089e:
		cheatingIcon.sprite = sprite;
		obj20 = 0;
		sprite2 = sprite;
		goto IL_08c3;
		IL_048d:
		obj10 = clusterIcon;
		obj40 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v612 @ X8_v10+E4]");
		bool flag25 = (nint)0 == 0;
		obj11 = clusterIcon;
		if (!flag25)
		{
			goto IL_04ce;
		}
		goto IL_06c7;
		IL_08c3:
		text = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 3112;
		object obj44 = "not" + 32;
		bool flag26 = !tournament.<CheatingAllowed>k__BackingField;
		object obj45 = !flag26;
		object obj46 = ~obj45;
		if (obj46 != null)
		{
			text = obj44;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6DE9]");
		object obj47 = (nint)0 & (nint)1;
		if (obj47 != null)
		{
			object obj48 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v644 @ X0_v68+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0956;
			}
		}
		else
		{
			_ = 1;
			object obj48 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v644 @ X0_v68+E4]");
			bool flag27 = (nint)0 == 0;
			object obj49 = !flag27;
			if (obj49 != null)
			{
				goto IL_0956;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		if (!cheatingText)
		{
			goto IL_01e9;
		}
		goto IL_09f8;
		IL_04f4:
		clusterIcon.SetActive(tournament.<IsCluster>k__BackingField);
		return;
		IL_0453:
		bool flag28 = obj23;
		bool flag29 = !flag28;
		object obj50 = !flag29;
		flag19 = false;
		if (obj50 == null)
		{
			goto IL_048d;
		}
		goto IL_063e;
		IL_03c8:
		bool flag30 = speedIcon;
		bool flag31 = !flag30;
		object obj51 = !flag31;
		sprite4 = null;
		if (obj51 == null)
		{
			goto IL_0400;
		}
		goto IL_0583;
	}

	private static void LocalizeText(TextMeshProUGUI label, string text)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00d8: Expected O, but got I4
		//IL_0118: Expected O, but got I4
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6DE9]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v2+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag2 = label;
		bool flag3 = !flag2;
		object obj5 = !flag3;
		if (obj5 == null)
		{
			return;
		}
		goto IL_009a;
		IL_009a:
		TextMeshProExtensions.Localize(label, text);
		return;
		IL_0074:
		if ((bool)label)
		{
			goto IL_009a;
		}
	}

	private static void FormatLabels(FormattedLabel[] formattedLabels, int value)
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0036: Expected O, but got I4
		//IL_009f: Expected O, but got I
		//IL_004b: Expected O, but got I
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected O, but got Unknown
		if (formattedLabels.Length >= 1)
		{
			object obj = formattedLabels + 32;
			object obj2 = 0;
			do
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X22_v4+v47 @ X21_v5*8]");
				object obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X8_v5+18]");
				object obj4 = 0;
				obj2++;
				object obj5 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v163 @ X8_v6+178] (should have been resolved before IL gen)");
			}
			while ((nint)obj2 < formattedLabels.Length);
		}
	}

	private static void SetSprite(Image icon, Sprite sprite)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00d8: Expected O, but got I4
		//IL_0118: Expected O, but got I4
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6DEA]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v2+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag2 = icon;
		bool flag3 = !flag2;
		object obj5 = !flag3;
		if (obj5 == null)
		{
			return;
		}
		goto IL_009a;
		IL_009a:
		icon.sprite = sprite;
		return;
		IL_0074:
		if ((bool)icon)
		{
			goto IL_009a;
		}
	}
}
