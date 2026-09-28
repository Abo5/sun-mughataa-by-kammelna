using System;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using TMPro;
using Unity.Properties;
using UnityEngine;

public class TournamentEmptyStateMessage : MonoBehaviour
{
	private TextMeshProUGUI messageTxt;

	private TextMeshProUGUI warning;

	private const string NoTournaments = "No active tournaments found";

	private const string NoPublicTournaments = "No active public tournaments found";

	private const string NoOfficialTournaments = "Anticipate official tournaments";

	private const string NoPrivateTournaments = "No active friendly tournaments found";

	private const string PrivateTournamentsCount = "Active Tournaments {1}";

	private const string PrivateTournamentsWarning = "Friendly tournaments appear only for friends";

	public unsafe void ShowMessage(TournamentType type, int filteredCount, int totalCount)
	{
		//IL_0016: Expected O, but got I
		//IL_007a: Expected O, but got I4
		//IL_05f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_05fa: Expected O, but got Unknown
		//IL_0091: Expected O, but got I4
		//IL_00ef: Expected O, but got I4
		//IL_0246: Unknown result type (might be due to invalid IL or missing references)
		//IL_024b: Expected O, but got Unknown
		//IL_02bf: Expected O, but got I4
		//IL_0385: Unknown result type (might be due to invalid IL or missing references)
		//IL_038a: Expected O, but got Unknown
		//IL_03a3: Expected O, but got I4
		//IL_02d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02dd: Expected O, but got Unknown
		//IL_0319: Expected O, but got I4
		//IL_03d2: Expected O, but got Ref
		//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01db: Expected O, but got Unknown
		//IL_0217: Expected O, but got I4
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Expected O, but got Unknown
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Expected O, but got Unknown
		//IL_03f7: Expected O, but got Ref
		//IL_0653: Expected O, but got I4
		//IL_040d: Expected I, but got O
		//IL_041d: Expected O, but got I
		//IL_044f: Expected O, but got I
		//IL_0496: Unknown result type (might be due to invalid IL or missing references)
		//IL_049b: Expected O, but got Unknown
		//IL_04d3: Expected O, but got Ref
		//IL_054d: Expected O, but got I8
		//IL_04e9: Expected I, but got O
		//IL_04f9: Expected O, but got I
		//IL_052b: Expected O, but got I
		//IL_0584: Unknown result type (might be due to invalid IL or missing references)
		//IL_0589: Expected O, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6CE4]");
		object obj = (nint)0 & (nint)1;
		if (obj != null)
		{
			HidePrivateWarning();
			if (type != TournamentType.Private)
			{
				goto IL_0056;
			}
		}
		else
		{
			_ = 1;
			HidePrivateWarning();
			if (type != TournamentType.Private)
			{
				goto IL_0056;
			}
		}
		ShowPrivateWarning();
		GameObject gameObject = base.gameObject;
		bool flag = (object)gameObject == null;
		object obj2 = 0;
		if (!flag)
		{
			goto IL_00fd;
		}
		goto IL_05b4;
		IL_0339:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		UnityEngine.Object obj3;
		bool flag2 = obj3;
		bool flag3 = !flag2;
		string text2;
		string text = text2;
		if (flag3)
		{
			return;
		}
		goto IL_0376;
		IL_01cc:
		object obj4 = "Network Authentication Required" + 504;
		text = (string)obj4;
		UnityEngine.Object obj5 = messageTxt;
		object obj7;
		object obj6 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v360 @ X0_v30+E4]");
		bool flag4 = (nint)0 == 0;
		object obj8 = !flag4;
		if (obj8 != null)
		{
			goto IL_029c;
		}
		obj3 = messageTxt;
		text2 = (string)obj4;
		goto IL_0339;
		IL_029c:
		bool flag5 = obj5;
		bool flag6 = !flag5;
		object obj9 = !flag6;
		if (obj9 == null)
		{
			return;
		}
		goto IL_0376;
		IL_0056:
		gameObject = base.gameObject;
		bool flag7 = (object)gameObject == null;
		object obj10 = !flag7;
		if (obj10 != null)
		{
			goto IL_00fd;
		}
		obj2 = 0;
		goto IL_05b4;
		IL_00fd:
		gameObject.SetActive(value: true);
		obj7 = typeof(MemberAchievementClanFeedData) + 2976;
		int num = default(int);
		if (type != TournamentType.Public)
		{
			if (type != TournamentType.Official)
			{
				if (type != TournamentType.Private)
				{
					goto IL_01cc;
				}
				object obj11 = "<ds.DataTable.OnColumnChanging|INFO> {0}" + 3600;
				object obj12 = "Network Authentication Required" + 488;
				if (totalCount == 0)
				{
					obj11 = obj12;
				}
				text = (string)obj11;
				obj5 = messageTxt;
				obj6 = obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v360 @ X0_v30+E4]");
				bool flag8 = (nint)0 == 0;
				object obj13 = !flag8;
				if (obj13 != null)
				{
					goto IL_029c;
				}
				obj3 = messageTxt;
				text2 = (string)obj11;
			}
			else
			{
				if (num != 0)
				{
					goto IL_01cc;
				}
				object obj14 = "Added Tournament Prizes And Features" + 1712;
				text = (string)obj14;
				obj5 = messageTxt;
				obj6 = obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v360 @ X0_v30+E4]");
				bool flag9 = (nint)0 == 0;
				object obj15 = !flag9;
				obj3 = messageTxt;
				text2 = (string)obj14;
				if (obj15 != null)
				{
					goto IL_029c;
				}
			}
		}
		else
		{
			object obj16 = "Network Authentication Required" + 496;
			text = (string)obj16;
			obj6 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v360 @ X0_v30+E4]");
			bool flag10 = (nint)0 == 0;
			obj5 = messageTxt;
			obj3 = messageTxt;
			text2 = (string)obj16;
			if (!flag10)
			{
				goto IL_029c;
			}
		}
		goto IL_0339;
		IL_0376:
		object obj17 = typeof(TypeConverter<ushort, char>) + 3400;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		object obj18 = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object[] array = default(object[]);
		bool flag11 = array == null;
		num = 0;
		int num2 = default(int);
		obj2 = (object)(&num2);
		if (flag11)
		{
			goto IL_05b4;
		}
		object obj19 = default(object);
		bool flag12 = obj19 == null;
		object obj20 = (object)(&num2);
		IndexOutOfRangeException ex = default(IndexOutOfRangeException);
		if (!flag12)
		{
			nint num3 = (nint)array;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ X8_v17 (Il2CppClass<System.Object[]>)+40]");
			obj20 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
			bool flag13 = ex == null;
			num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ X8_v17 (Il2CppClass<System.Object[]>)+40]");
			obj2 = 0;
			if (flag13)
			{
				goto IL_05d0;
			}
		}
		bool flag14 = array.Length == 0;
		num = 0;
		obj2 = obj20;
		if (!flag14)
		{
			object obj21 = array + 32;
			obj21 = obj19;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
			object obj22 = default(object);
			bool flag15 = obj22 == null;
			int num4 = default(int);
			object obj23 = (object)(&num4);
			if (!flag15)
			{
				nint num5 = (nint)array;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v249 @ X8_v16 (Il2CppClass<System.Object[]>)+40]");
				obj23 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
				bool flag16 = ex == null;
				num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v249 @ X8_v16 (Il2CppClass<System.Object[]>)+40]");
				obj2 = 0;
				if (flag16)
				{
					goto IL_05d0;
				}
			}
			object obj24 = array.Length & 0xFFFFFFFEL;
			bool flag17 = obj24 == null;
			num = 0;
			obj2 = obj23;
			if (!flag17)
			{
				object obj25 = array + 40;
				obj25 = obj22;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				TextMeshProExtensions.Localize(messageTxt, text, array);
				return;
			}
		}
		goto IL_05c2;
		IL_05c2:
		ex = new IndexOutOfRangeException();
		goto IL_05d0;
		IL_05d0:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		throw new OutOfMemoryException();
		IL_05b4:
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_05c2;
	}

	public void HideMessage()
	{
		GameObject gameObject = base.gameObject;
		gameObject.SetActive(value: false);
	}

	private void ShowPrivateWarning()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0137: Expected O, but got I4
		//IL_0181: Expected O, but got I4
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Expected O, but got Unknown
		object obj = 152985600;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6C18]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj6;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			obj5 = warning;
			obj6 = warning;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			obj5 = warning;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v2+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj6 = warning;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = obj6;
		bool flag4 = !flag3;
		object obj8 = !flag4;
		if (obj8 == null)
		{
			return;
		}
		goto IL_00b7;
		IL_00b7:
		GameObject gameObject = warning.gameObject;
		gameObject.SetActive(value: true);
		object text = "FilterFunction '{0}' expects {1} parameters but only {2} were provided. Missing parameters will be set to their default values." + 1480;
		TextMeshProExtensions.Localize(warning, (string)text);
		return;
		IL_0091:
		if ((bool)obj5)
		{
			goto IL_00b7;
		}
	}

	private void HidePrivateWarning()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_010a: Expected O, but got I4
		//IL_015e: Expected O, but got I4
		object obj = 152985600;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6C19]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj6;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			obj5 = warning;
			obj6 = warning;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v2+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj5 = warning;
			obj6 = warning;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = obj6;
		bool flag4 = !flag3;
		object obj8 = !flag4;
		if (obj8 == null)
		{
			return;
		}
		goto IL_00b7;
		IL_00b7:
		GameObject gameObject = warning.gameObject;
		gameObject.SetActive(value: false);
		return;
		IL_0091:
		if ((bool)obj5)
		{
			goto IL_00b7;
		}
	}

	private static string GetMessageFromType(TournamentType t, int filteredCount, int totalCount)
	{
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Expected O, but got Unknown
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Expected O, but got Unknown
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Expected O, but got Unknown
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected O, but got Unknown
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected O, but got Unknown
		if (t != TournamentType.Public)
		{
			switch (t)
			{
			case TournamentType.Private:
			{
				object result = "<ds.DataTable.OnColumnChanging|INFO> {0}" + 3600;
				object obj = "Network Authentication Required" + 488;
				if (totalCount == 0)
				{
					result = obj;
				}
				return (string)result;
			}
			case TournamentType.Official:
				if (filteredCount == 0)
				{
					return "Added Tournament Prizes And Features" + 1712;
				}
				goto default;
			default:
				return "Network Authentication Required" + 504;
			}
		}
		return "Network Authentication Required" + 496;
	}
}
