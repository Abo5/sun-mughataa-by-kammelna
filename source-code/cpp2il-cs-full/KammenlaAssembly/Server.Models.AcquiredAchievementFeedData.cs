using System;
using System.Data.SqlTypes;
using Cpp2ILInjected;
using Managers.Achievemenets;
using Newtonsoft.Json.Linq.JsonPath;
using Unity.Properties;

namespace Server.Models;

[Serializable]
public class AcquiredAchievementFeedData : UserFeedData
{
	private string <AchievementId>k__BackingField;

	private int <LevelId>k__BackingField;

	public string AchievementId
	{
		get
		{
			return <AchievementId>k__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 24;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public int LevelId
	{
		get
		{
			return <LevelId>k__BackingField;
		}
		set
		{
			<LevelId>k__BackingField = value;
		}
	}

	public override bool HasPreview => true;

	public override bool ForcedPreview => true;

	public AcquiredAchievementFeedData()
	{
	}

	public AcquiredAchievementFeedData(string achievementId, int levelId)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		object obj = this + 24;
		obj = achievementId;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	public override LocalizableText GetTitle()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_016b: Expected O, but got I4
		//IL_00ad: Expected O, but got I4
		//IL_01dc: Expected O, but got I
		//IL_01f4: Expected O, but got I
		//IL_0399: Expected O, but got I
		//IL_03a9: Expected O, but got I
		//IL_03bf: Expected O, but got I
		//IL_03c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cd: Expected O, but got Unknown
		//IL_03e7: Expected O, but got I4
		//IL_03f7: Expected O, but got I
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Expected O, but got Unknown
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Expected O, but got Unknown
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Expected O, but got Unknown
		//IL_01b9: Expected O, but got I4
		//IL_01c2: Expected O, but got I4
		//IL_0229: Expected O, but got I
		//IL_023f: Expected O, but got I
		//IL_0248: Unknown result type (might be due to invalid IL or missing references)
		//IL_024d: Expected O, but got Unknown
		//IL_026c: Expected O, but got I
		//IL_0459: Expected O, but got I
		//IL_0469: Expected O, but got I
		//IL_047f: Expected O, but got I
		//IL_0488: Unknown result type (might be due to invalid IL or missing references)
		//IL_048d: Expected O, but got Unknown
		//IL_0431: Expected O, but got I4
		//IL_02af: Expected O, but got I
		//IL_02bf: Expected O, but got I
		//IL_02d5: Expected O, but got I
		//IL_02de: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e3: Expected O, but got Unknown
		//IL_02fd: Expected O, but got I4
		//IL_030d: Expected O, but got I
		//IL_033a: Expected O, but got I
		//IL_0349: Unknown result type (might be due to invalid IL or missing references)
		//IL_034e: Expected O, but got Unknown
		//IL_0364: Expected O, but got I
		//IL_04ba: Expected O, but got I
		object obj = typeof(SqlSingle[]) + 2360;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7BD2]");
		object obj2 = (nint)0 & (nint)1;
		string achievementId;
		string achievementId2;
		if (obj2 != null)
		{
			achievementId = <AchievementId>k__BackingField;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v20+E4]");
			bool flag = (nint)0 == 0;
			achievementId2 = <AchievementId>k__BackingField;
			if (!flag)
			{
				goto IL_0088;
			}
		}
		else
		{
			_ = 1;
			achievementId = <AchievementId>k__BackingField;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v20+E4]");
			bool flag2 = (nint)0 == 0;
			object obj4 = !flag2;
			achievementId2 = <AchievementId>k__BackingField;
			if (obj4 != null)
			{
				goto IL_0088;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		GameAchievementViewModel achievement = AchievementsManager.GetAchievement(achievementId2);
		bool flag3 = achievement == null;
		object obj5 = !flag3;
		object obj6 = 0;
		if (obj5 != null)
		{
			goto IL_00bb;
		}
		goto IL_01d0;
		IL_032a:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ X0_v10+B8]");
		object arguments = 0;
		object obj7 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2640;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object text = (nint)0 + (nint)2000;
		LocalizableText localizableText = default(LocalizableText);
		localizableText..ctor((string)text, (object[])arguments);
		return localizableText;
		IL_043f:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X19_v3+38]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ X8_v7+10]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ X8_v7+10]");
		object obj10 = (nint)0 + (nint)309;
		object obj11 = obj10 & 1;
		if (obj11 == null)
		{
			goto IL_031b;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ X8_v7+10]");
		object obj12 = 0;
		goto IL_032a;
		IL_027a:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X0_v2+E4]");
		if ((nint)0 != 0)
		{
			goto IL_029f;
		}
		goto IL_043f;
		IL_0088:
		achievement = AchievementsManager.GetAchievement(achievementId);
		bool flag4 = achievement == null;
		obj6 = 0;
		if (!flag4)
		{
			goto IL_00bb;
		}
		goto IL_01d0;
		IL_01d0:
		object obj13 = (nint)0 + (nint)3232;
		object obj14 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X19_v3+38]");
		object obj15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X19_v3+38]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X8_v5+10]");
			object obj16 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X8_v5+10]");
			object obj17 = (nint)0 + (nint)309;
			object obj18 = obj17 & 1;
			bool flag5 = obj18 == null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X8_v5+10]");
			object obj19 = 0;
			if (!flag5)
			{
				goto IL_027a;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CD24");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X19_v3+38]");
			object obj20 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X8_v12+10]");
			object obj16 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X8_v12+10]");
			object obj21 = (nint)0 + (nint)309;
			object obj22 = obj21 & 1;
			bool flag6 = obj22 == null;
			object obj23 = !flag6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X8_v12+10]");
			object obj19 = 0;
			if (obj23 != null)
			{
				goto IL_027a;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X0_v2+E4]");
		bool flag7 = (nint)0 == 0;
		object obj24 = !flag7;
		if (obj24 != null)
		{
			goto IL_029f;
		}
		goto IL_043f;
		IL_00bb:
		object text2 = "ThisIsFakeReceiptData" + 392;
		object obj25 = "ThisIsFakeReceiptData" + 1960;
		object obj26 = "<ds.DataTable.OnColumnChanging|INFO> {0}" + 3360;
		if (achievement.<type>k__BackingField != AchievementType.Trophy)
		{
			obj25 = obj26;
		}
		if (achievement.<type>k__BackingField != AchievementType.Title)
		{
			text2 = obj25;
		}
		return TextMeshProExtensions.Localize((string)text2);
		IL_029f:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X19_v3+38]");
		object obj27 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X8_v23+10]");
		obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X8_v23+10]");
		object obj28 = (nint)0 + (nint)309;
		object obj29 = obj28 & 1;
		bool flag8 = obj29 == null;
		object obj30 = !flag8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X8_v23+10]");
		obj12 = 0;
		if (obj30 == null)
		{
			goto IL_031b;
		}
		goto IL_032a;
		IL_031b:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		goto IL_032a;
	}

	public override LocalizableText GetDetails()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0261: Expected O, but got I4
		//IL_00b6: Expected O, but got I4
		//IL_02d2: Expected O, but got I
		//IL_02ea: Expected O, but got I
		//IL_048f: Expected O, but got I
		//IL_049f: Expected O, but got I
		//IL_04b5: Expected O, but got I
		//IL_04be: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c3: Expected O, but got Unknown
		//IL_04dd: Expected O, but got I4
		//IL_04ed: Expected O, but got I
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Expected O, but got Unknown
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Expected O, but got Unknown
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Expected O, but got Unknown
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Expected O, but got Unknown
		//IL_02af: Expected O, but got I4
		//IL_02b8: Expected O, but got I4
		//IL_031f: Expected O, but got I
		//IL_0335: Expected O, but got I
		//IL_033e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0343: Expected O, but got Unknown
		//IL_0362: Expected O, but got I
		//IL_054f: Expected O, but got I
		//IL_055f: Expected O, but got I
		//IL_0575: Expected O, but got I
		//IL_057e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0583: Expected O, but got Unknown
		//IL_0527: Expected O, but got I4
		//IL_03a5: Expected O, but got I
		//IL_03b5: Expected O, but got I
		//IL_03cb: Expected O, but got I
		//IL_03d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d9: Expected O, but got Unknown
		//IL_03f3: Expected O, but got I4
		//IL_0403: Expected O, but got I
		//IL_0430: Expected O, but got I
		//IL_043f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0444: Expected O, but got Unknown
		//IL_045a: Expected O, but got I
		//IL_05b0: Expected O, but got I
		//IL_05c7: Expected O, but got I4
		//IL_016b: Expected O, but got I4
		//IL_0181: Expected I, but got O
		//IL_0191: Expected O, but got I
		//IL_01ba: Expected O, but got I
		//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f5: Expected O, but got Unknown
		object obj = 152989696;
		object obj2 = typeof(SqlSingle[]) + 2360;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7BD3]");
		object obj3 = (nint)0 & (nint)1;
		string achievementId;
		string achievementId2;
		if (obj3 != null)
		{
			achievementId = <AchievementId>k__BackingField;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v20+E4]");
			bool flag = (nint)0 == 0;
			achievementId2 = <AchievementId>k__BackingField;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			achievementId = <AchievementId>k__BackingField;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v20+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			achievementId2 = <AchievementId>k__BackingField;
			if (obj5 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		GameAchievementViewModel achievement = AchievementsManager.GetAchievement(achievementId2);
		bool flag3 = achievement == null;
		object obj6 = !flag3;
		object obj7 = 0;
		if (obj6 != null)
		{
			goto IL_00c4;
		}
		goto IL_02c6;
		IL_0395:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X19_v3+38]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ X8_v23+10]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ X8_v23+10]");
		object obj10 = (nint)0 + (nint)309;
		object obj11 = obj10 & 1;
		bool flag4 = obj11 == null;
		object obj12 = !flag4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ X8_v23+10]");
		object obj13 = 0;
		if (obj12 == null)
		{
			goto IL_0411;
		}
		goto IL_0420;
		IL_0420:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ X0_v10+B8]");
		object arguments = 0;
		object obj14 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2640;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object text = (nint)0 + (nint)2000;
		LocalizableText localizableText = default(LocalizableText);
		localizableText..ctor((string)text, (object[])arguments);
		return localizableText;
		IL_0535:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X19_v3+38]");
		object obj15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ X8_v7+10]");
		obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ X8_v7+10]");
		object obj16 = (nint)0 + (nint)309;
		object obj17 = obj16 & 1;
		if (obj17 == null)
		{
			goto IL_0411;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ X8_v7+10]");
		obj13 = 0;
		goto IL_0420;
		IL_0091:
		achievement = AchievementsManager.GetAchievement(achievementId);
		bool flag5 = achievement == null;
		obj7 = 0;
		if (!flag5)
		{
			goto IL_00c4;
		}
		goto IL_02c6;
		IL_02c6:
		object obj18 = (nint)0 + (nint)3232;
		object obj19 = obj18;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X19_v3+38]");
		object obj20 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X19_v3+38]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X8_v5+10]");
			object obj21 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X8_v5+10]");
			object obj22 = (nint)0 + (nint)309;
			object obj23 = obj22 & 1;
			bool flag6 = obj23 == null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X8_v5+10]");
			object obj24 = 0;
			if (!flag6)
			{
				goto IL_0370;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CD24");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X19_v3+38]");
			object obj25 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X8_v12+10]");
			object obj21 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X8_v12+10]");
			object obj26 = (nint)0 + (nint)309;
			object obj27 = obj26 & 1;
			bool flag7 = obj27 == null;
			object obj28 = !flag7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X8_v12+10]");
			object obj24 = 0;
			if (obj28 != null)
			{
				goto IL_0370;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ X0_v2+E4]");
		bool flag8 = (nint)0 == 0;
		object obj29 = !flag8;
		if (obj29 != null)
		{
			goto IL_0395;
		}
		goto IL_0535;
		IL_05e2:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		return (LocalizableText)(object)new OutOfMemoryException();
		IL_0411:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		goto IL_0420;
		IL_00c4:
		object text2 = "___# Content push apply failed [{0}]: {1}" + 3040;
		object obj30 = "___# Content push apply failed [{0}]: {1}" + 3048;
		object obj31 = "___# Content push apply failed [{0}]: {1}" + 3032;
		object obj32 = typeof(TypeConverter<ushort, char>) + 3400;
		if (achievement.<type>k__BackingField != AchievementType.Trophy)
		{
			obj30 = obj31;
		}
		if (achievement.<type>k__BackingField != AchievementType.Title)
		{
			text2 = obj30;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		object[] array = default(object[]);
		object obj33;
		IndexOutOfRangeException ex = default(IndexOutOfRangeException);
		object obj34;
		if (array != null)
		{
			bool flag9 = achievement.<name>k__BackingField == null;
			obj33 = 1;
			if (!flag9)
			{
				nint num = (nint)array;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ X8_v41 (Il2CppClass<System.Object[]>)+40]");
				obj33 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
				bool flag10 = ex == null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ X8_v41 (Il2CppClass<System.Object[]>)+40]");
				obj34 = 0;
				if (flag10)
				{
					goto IL_05e2;
				}
			}
			if (array.Length != 0)
			{
				object obj35 = array + 32;
				obj35 = achievement.<name>k__BackingField;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				return TextMeshProExtensions.LocalizeWith((string)text2, array);
			}
		}
		else
		{
			NullReferenceException ex2 = new NullReferenceException();
			obj33 = 1;
		}
		ex = new IndexOutOfRangeException();
		obj34 = obj33;
		goto IL_05e2;
		IL_0370:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ X0_v2+E4]");
		if ((nint)0 != 0)
		{
			goto IL_0395;
		}
		goto IL_0535;
	}

	public override void ShowPreview(Action markSeen)
	{
		//IL_010d: Expected O, but got I4
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected O, but got Unknown
		//IL_0062: Expected O, but got I4
		bool flag = string.IsNullOrEmpty(<AchievementId>k__BackingField);
		bool flag2 = !flag;
		object obj = !flag2;
		if (obj == null && <LevelId>k__BackingField >= 1)
		{
			object obj2 = typeof(SqlSingle[]) + 2304;
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X0_v5+E4]");
			bool flag3 = (nint)0 == 0;
			object obj4 = !flag3;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			AchievementClaimPopup.Enqueue(<AchievementId>k__BackingField, <LevelId>k__BackingField, markSeen);
		}
		else if (markSeen != null)
		{
			IntPtr invoke_impl = ((Delegate)markSeen).invoke_impl;
			IntPtr method_code = ((Delegate)markSeen).method_code;
			IntPtr method = ((Delegate)markSeen).method;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v88 @ X2_v1 (System.IntPtr) (should have been resolved before IL gen)");
		}
	}

	public override bool IsValid()
	{
		//IL_009c: Expected O, but got I4
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Expected I4, but got Unknown
		if (string.IsNullOrEmpty(<AchievementId>k__BackingField))
		{
			return false;
		}
		bool flag = <LevelId>k__BackingField < 0;
		bool flag2 = <LevelId>k__BackingField == 0;
		int num = <LevelId>k__BackingField ^ <LevelId>k__BackingField;
		int num2 = <LevelId>k__BackingField & num;
		bool flag3 = num2 < 0;
		bool flag4 = flag == flag3;
		object obj = !flag2;
		return (byte)((flag4 & obj) ? 1 : 0) != 0;
	}
}
