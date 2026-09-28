using System;
using System.Diagnostics;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using Spine;
using UnityEngine;
using UnityEngine.UI;

public class SportTeamColorizer : MonoBehaviour
{
	private sealed class <>c__DisplayClass6_0
	{
		public SportTeam sportTeam;

		internal void <Initialize>b__0(Graphic image)
		{
			//IL_001c: Expected I, but got O
			//IL_002c: Expected O, but got I
			//IL_003c: Expected O, but got I
			Color color = sportTeam.ColorOne();
			nint num = (nint)image;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X8_v1 (Il2CppClass<UnityEngine.UI.Graphic>)+2A8]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X8_v1 (Il2CppClass<UnityEngine.UI.Graphic>)+2B0]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v38 @ X2_v1 (should have been resolved before IL gen)");
			/*Error: End of method reached without returning.*/;
		}

		internal void <Initialize>b__1(Graphic image)
		{
			//IL_001c: Expected I, but got O
			//IL_002c: Expected O, but got I
			//IL_003c: Expected O, but got I
			Color color = sportTeam.ColorTwo();
			nint num = (nint)image;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X8_v1 (Il2CppClass<UnityEngine.UI.Graphic>)+2A8]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X8_v1 (Il2CppClass<UnityEngine.UI.Graphic>)+2B0]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v38 @ X2_v1 (should have been resolved before IL gen)");
			/*Error: End of method reached without returning.*/;
		}
	}

	private Image teamLogo;

	private Image teamIcon;

	private Graphic[] colorOneImages;

	private Graphic[] colorTwoImages;

	private GameObject solidColorTwo;

	private Color defaultColor;

	public void Initialize(SportTeam sportTeam)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		//IL_009f: Expected O, but got I4
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Expected O, but got Unknown
		//IL_0139: Expected O, but got I
		//IL_0145: Expected O, but got I
		//IL_0151: Expected O, but got I
		//IL_016c: Expected I, but got O
		//IL_01a0: Expected I, but got O
		//IL_01a8: Expected I4, but got O
		//IL_01cc: Expected O, but got I
		//IL_01e7: Expected O, but got I
		//IL_02b5: Expected I4, but got O
		//IL_0428: Expected O, but got I4
		//IL_025f: Expected O, but got I4
		//IL_03c3: Expected O, but got I4
		object obj = typeof(SkeletonBinary.SkeletonInput) + 888;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(MemberAchievementClanFeedData) + 2976;
		object obj4 = obj2 + 16;
		obj4 = sportTeam;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X0_v8+E4]");
		bool flag3;
		if ((nint)0 != 0)
		{
			bool flag = solidColorTwo;
			bool flag2 = !flag;
			object obj6 = !flag2;
			if (obj6 != null)
			{
				goto IL_00fb;
			}
			flag3 = false;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag4 = solidColorTwo;
			bool flag5 = !flag4;
			flag3 = false;
			if (!flag5)
			{
				goto IL_00fb;
			}
		}
		goto IL_0119;
		IL_02cd:
		UnityEngine.Object obj7;
		if (obj7 != null)
		{
			goto IL_02f4;
		}
		return;
		IL_02f4:
		UIExtensions.LoadSportTeamImage(teamIcon, (SportTeam)obj4, ImageCacher.SportTeamImageType.Celebration);
		return;
		IL_00fb:
		solidColorTwo.SetActive(value: true);
		flag3 = true;
		goto IL_0119;
		IL_03f5:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		UnityEngine.Object obj8;
		bool flag6 = obj8 != null;
		bool flag7 = !flag6;
		object obj9 = !flag7;
		if (obj9 == null)
		{
			return;
		}
		goto IL_02f4;
		IL_0119:
		object obj10 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2184;
		object obj11 = (nint)0 + (nint)776;
		object obj12 = (nint)0 + (nint)2168;
		object obj13 = (nint)0 + (nint)784;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor(obj2, (IntPtr)obj11);
		ArraysExtensions.ForEach(colorOneImages, action);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action2 = default(Action<object>);
		action2..ctor(obj2, (IntPtr)obj13);
		ImageCacher.ItemImageType itemImageType = (ImageCacher.ItemImageType)obj12;
		ArraysExtensions.ForEach(colorTwoImages, action2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v3 (System.Object)+10]");
		object obj14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X8_v5+20]");
		object obj15 = (nint)0 & (nint)1;
		bool flag8 = obj15 == null;
		UnityEngine.Object obj16 = (UnityEngine.Object)(object)action2;
		if (flag8)
		{
			goto IL_027b;
		}
		object obj17 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v223 @ X8_v13+E4]");
		if ((nint)0 != 0)
		{
			bool flag9 = teamLogo != null;
			bool flag10 = !flag9;
			object obj18 = !flag10;
			itemImageType = ImageCacher.ItemImageType.InGame;
			obj16 = null;
			if (obj18 == null)
			{
				goto IL_027b;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag11 = teamLogo != null;
			bool flag12 = !flag11;
			itemImageType = ImageCacher.ItemImageType.InGame;
			obj16 = null;
			if (flag12)
			{
				goto IL_027b;
			}
		}
		int? num = default(int?);
		int value = num.Value;
		UIExtensions.LoadItemImage(teamLogo, value, ImageCacher.ItemImageType.StoreTitle);
		obj7 = teamIcon;
		object obj19 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v282 @ X8_v7+E4]");
		bool flag13 = (nint)0 == 0;
		object obj20 = !flag13;
		FilterMode filterMode = FilterMode.Point;
		itemImageType = ImageCacher.ItemImageType.StoreTitle;
		int num2 = value;
		obj8 = teamIcon;
		if (obj20 != null)
		{
			goto IL_02cd;
		}
		goto IL_03f5;
		IL_027b:
		obj7 = teamIcon;
		obj19 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v282 @ X8_v7+E4]");
		bool flag14 = (nint)0 == 0;
		filterMode = FilterMode.Point;
		num2 = (int)obj16;
		obj8 = teamIcon;
		if (!flag14)
		{
			goto IL_02cd;
		}
		goto IL_03f5;
	}

	public void resetUI()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_010a: Expected O, but got I4
		//IL_00b4: Expected O, but got I4
		//IL_018d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0192: Expected O, but got Unknown
		//IL_019e: Expected O, but got I
		//IL_01aa: Expected O, but got I
		//IL_01b6: Expected O, but got I
		//IL_01ce: Expected I, but got O
		//IL_01ff: Expected I, but got O
		object obj = 152985600;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6D47]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj6;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X0_v11+E4]");
			bool flag = (nint)0 == 0;
			obj5 = solidColorTwo;
			obj6 = solidColorTwo;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			obj5 = solidColorTwo;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X0_v11+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj6 = solidColorTwo;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = obj6;
		bool flag4 = !flag3;
		bool flag5 = false;
		if (!flag4)
		{
			goto IL_0160;
		}
		goto IL_017e;
		IL_017e:
		object obj8 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2184;
		object obj9 = (nint)0 + (nint)1976;
		object obj10 = (nint)0 + (nint)2168;
		object obj11 = (nint)0 + (nint)1984;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj9);
		ArraysExtensions.ForEach(colorOneImages, action);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action2 = default(Action<object>);
		action2..ctor((object)this, (IntPtr)obj11);
		ArraysExtensions.ForEach(colorTwoImages, action2);
		return;
		IL_0160:
		solidColorTwo.SetActive(value: false);
		flag5 = false;
		goto IL_017e;
		IL_0091:
		bool flag6 = obj5;
		bool flag7 = !flag6;
		object obj12 = !flag7;
		if (obj12 != null)
		{
			goto IL_0160;
		}
		flag5 = false;
		goto IL_017e;
	}

	private void <resetUI>b__7_0(Graphic image)
	{
		//IL_0010: Expected O, but got I
		//IL_0020: Expected O, but got I
		//IL_003a: Expected O, but got I
		//IL_0042: Expected I, but got O
		//IL_0052: Expected O, but got I
		//IL_0062: Expected O, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (SportTeamColorizer)+50]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (SportTeamColorizer)+54]");
		object obj2 = 0;
		Color color = defaultColor;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (SportTeamColorizer)+4C]");
		object obj3 = 0;
		nint num = (nint)image;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v7 @ X8_v1 (Il2CppClass<UnityEngine.UI.Graphic>)+2A8]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v7 @ X8_v1 (Il2CppClass<UnityEngine.UI.Graphic>)+2B0]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v8 @ X2_v1 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}

	private void <resetUI>b__7_1(Graphic image)
	{
		//IL_0010: Expected O, but got I
		//IL_0020: Expected O, but got I
		//IL_003a: Expected O, but got I
		//IL_0042: Expected I, but got O
		//IL_0052: Expected O, but got I
		//IL_0062: Expected O, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (SportTeamColorizer)+50]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (SportTeamColorizer)+54]");
		object obj2 = 0;
		Color color = defaultColor;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (SportTeamColorizer)+4C]");
		object obj3 = 0;
		nint num = (nint)image;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v7 @ X8_v1 (Il2CppClass<UnityEngine.UI.Graphic>)+2A8]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v7 @ X8_v1 (Il2CppClass<UnityEngine.UI.Graphic>)+2B0]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v8 @ X2_v1 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}
}
