using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Dynamic.Utils;
using System.Linq;
using System.Linq.Expressions;
using Cpp2ILInjected;
using HuaweiMobileServices.Location.Location;
using Kammelna.Server.Models.Clans;
using UnityEngine;

public class MiniGameRewardList : MonoBehaviour
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Func<MiniGameRewardDescription, string> <>9__4_0;

		public static Func<IGrouping<string, MiniGameRewardDescription>, MiniGameRewardDescription> <>9__4_1;

		public static Func<MiniGameRewardDescription, int> <>9__4_2;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 3768;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal string <InitializeList>b__4_0(MiniGameRewardDescription description)
		{
			if (description != null)
			{
				return description.<Name>k__BackingField;
			}
			return (string)(object)new NullReferenceException();
		}

		internal MiniGameRewardDescription <InitializeList>b__4_1(IGrouping<string, MiniGameRewardDescription> grouping)
		{
			return (MiniGameRewardDescription)Enumerable.First((IEnumerable<object>)grouping);
		}

		internal int <InitializeList>b__4_2(MiniGameRewardDescription reward)
		{
			//IL_0035: Expected I4, but got O
			if (reward != null)
			{
				return reward.<Value>k__BackingField;
			}
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
		}
	}

	private RectTransform rewardsParent;

	private MiniGameRewardItem itemTemplate;

	private bool groupSimilarRewards;

	private void Start()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_01cb: Expected I, but got O
		//IL_00ec: Expected O, but got I
		//IL_0106: Expected O, but got I4
		//IL_004f: Expected O, but got I
		//IL_017c: Expected O, but got I
		//IL_019e: Expected O, but got I4
		//IL_0144: Expected O, but got I4
		//IL_00b1: Expected O, but got I
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)2800;
		object obj3 = typeof(MemberAchievementClanFeedData) + 824;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v4+E4]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E64BF]");
			object obj5 = (nint)0 & (nint)1;
			if (obj5 != null)
			{
				goto IL_006c;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E64BF]");
			object obj6 = (nint)0 & (nint)1;
			bool flag = obj6 == null;
			object obj7 = !flag;
			if (obj7 != null)
			{
				goto IL_006c;
			}
		}
		_ = 1;
		object obj8 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X0_v18+E4]");
		bool flag2 = (nint)0 == 0;
		object obj9 = !flag2;
		object obj10 = obj8;
		if (obj9 != null)
		{
			goto IL_00a1;
		}
		goto IL_015a;
		IL_00a1:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X0_v18+B8]");
		object obj11 = 0;
		OneShotEvent oneShotEvent = (OneShotEvent)obj11;
		goto IL_00be;
		IL_00be:
		oneShotEvent.CallWhenReady(action);
		return;
		IL_015a:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj12 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X0_v9+B8]");
		object obj13 = 0;
		oneShotEvent = (OneShotEvent)obj13;
		bool flag3 = obj13 == null;
		object obj14 = !flag3;
		if (obj14 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_00be;
		IL_006c:
		obj8 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X0_v18+E4]");
		bool flag4 = (nint)0 == 0;
		obj10 = obj8;
		if (!flag4)
		{
			goto IL_00a1;
		}
		goto IL_015a;
	}

	private void InitializeList()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_040e: Expected O, but got I4
		//IL_05f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_05fb: Expected O, but got Unknown
		//IL_060b: Expected O, but got I
		//IL_0627: Expected O, but got I
		//IL_0637: Expected O, but got I
		//IL_0446: Expected O, but got I4
		//IL_0651: Expected O, but got I
		//IL_0660: Unknown result type (might be due to invalid IL or missing references)
		//IL_0665: Expected O, but got Unknown
		//IL_0671: Expected O, but got I
		//IL_0682: Expected O, but got I
		//IL_0692: Expected O, but got I
		//IL_06b4: Expected O, but got I4
		//IL_00e4: Expected O, but got I
		//IL_00f4: Expected O, but got I
		//IL_0104: Expected O, but got I
		//IL_0126: Expected O, but got I4
		//IL_03d1: Expected I, but got O
		//IL_036e: Expected O, but got I4
		//IL_01a8: Expected O, but got I
		//IL_0069: Expected O, but got I
		//IL_0079: Expected O, but got I
		//IL_0089: Expected O, but got I
		//IL_00ab: Expected O, but got I4
		//IL_0575: Unknown result type (might be due to invalid IL or missing references)
		//IL_057a: Expected O, but got Unknown
		//IL_0590: Expected O, but got I
		//IL_05a1: Expected I, but got O
		//IL_05bf: Expected O, but got I
		//IL_05da: Expected O, but got I4
		//IL_0260: Expected O, but got I
		//IL_0270: Expected O, but got I
		//IL_0280: Expected O, but got I
		//IL_02a2: Expected O, but got I4
		//IL_015e: Expected O, but got I4
		//IL_039e: Expected O, but got I
		//IL_01e5: Expected O, but got I
		//IL_01f5: Expected O, but got I
		//IL_0205: Expected O, but got I
		//IL_0227: Expected O, but got I4
		//IL_0463: Unknown result type (might be due to invalid IL or missing references)
		//IL_0468: Expected O, but got Unknown
		//IL_047e: Expected O, but got I
		//IL_048f: Expected I, but got O
		//IL_04ad: Expected O, but got I
		//IL_04c8: Expected O, but got I4
		//IL_02da: Expected O, but got I4
		//IL_018e: Expected O, but got I
		//IL_04ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f1: Expected O, but got Unknown
		//IL_0507: Expected O, but got I
		//IL_0518: Expected I, but got O
		//IL_0536: Expected O, but got I
		//IL_0551: Expected O, but got I4
		//IL_030a: Expected O, but got I
		object obj = typeof(MemberAchievementClanFeedData) + 824;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		object obj4 = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 3768;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v3+B8]");
		object obj5 = 0;
		bool flag2 = !groupSimilarRewards;
		IntPtr intPtr = default(IntPtr);
		Func<object, object> func = (Func<object, object>)(nint)intPtr;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X8_v4+10]");
		IEnumerable<object> source = (IEnumerable<object>)0;
		object obj8;
		Func<object, object> keySelector;
		object obj10;
		object obj7;
		if (!flag2)
		{
			object obj6 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ X0_v40+E4]");
			if ((nint)0 != 0)
			{
				obj7 = (nint)0 + (nint)2960;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ X0_v40+B8]");
				obj8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X8_v34+8]");
				keySelector = (Func<object, object>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X8_v34+8]");
				bool flag3 = (nint)0 == 0;
				object obj9 = !flag3;
				if (obj9 == null)
				{
					obj10 = obj7;
					goto IL_013c;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj6 = obj4;
				obj10 = (nint)0 + (nint)2960;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ X0_v40+B8]");
				obj8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X8_v34+8]");
				keySelector = (Func<object, object>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X8_v34+8]");
				bool flag4 = (nint)0 == 0;
				object obj11 = !flag4;
				obj7 = obj10;
				if (obj11 == null)
				{
					goto IL_013c;
				}
			}
			goto IL_0193;
		}
		goto IL_041c;
		IL_013c:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ X0_v40+E4]");
		bool flag5 = (nint)0 == 0;
		object obj12 = !flag5;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj13 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v249 @ X8_v40+B8]");
			obj8 = 0;
		}
		object obj14 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2504;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj15 = (nint)0 + (nint)1912;
		Func<object, object> func2 = default(Func<object, object>);
		func2..ctor(obj8, (IntPtr)obj15);
		object obj16 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X8_v39+B8]");
		object obj17 = (nint)0 + (nint)8;
		obj17 = func2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj18 = 0;
		obj7 = obj10;
		keySelector = func2;
		goto IL_0193;
		IL_041c:
		object obj19 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X0_v6+E4]");
		bool flag6 = (nint)0 == 0;
		object obj20 = !flag6;
		if (obj20 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj19 = obj4;
		}
		object obj21 = (nint)0 + (nint)2432;
		object obj22 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2752;
		object obj23 = (nint)0 + (nint)2792;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X0_v6+B8]");
		object obj24 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ X8_v10+18]");
		Func<object, int> keySelector2 = (Func<object, int>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ X8_v10+18]");
		bool flag7 = (nint)0 == 0;
		object obj25 = !flag7;
		if (obj25 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X0_v6+E4]");
			bool flag8 = (nint)0 == 0;
			object obj26 = !flag8;
			if (obj26 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj27 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v238 @ X8_v16+B8]");
				obj24 = 0;
			}
			object obj28 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2496;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj29 = (nint)0 + (nint)1928;
			Func<object, int> func3 = default(Func<object, int>);
			func3..ctor(obj24, (IntPtr)obj29);
			object obj30 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v190 @ X8_v15+B8]");
			object obj31 = (nint)0 + (nint)24;
			obj31 = func3;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			obj18 = 0;
			keySelector2 = func3;
		}
		IOrderedEnumerable<object> enumeration = Enumerable.OrderByDescending(source, keySelector2);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj23);
		ArraysExtensions.ForEach(enumeration, action);
		return;
		IL_030f:
		ILookup<object, object> source2;
		Func<object, object> func4;
		IEnumerable<object> enumerable = Enumerable.Select(source2, func4);
		func = func4;
		source = enumerable;
		goto IL_041c;
		IL_0193:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X8_v4+10]");
		source2 = Enumerable.ToLookup((IEnumerable<object>)0, keySelector);
		object obj32 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v296 @ X0_v30+E4]");
		object obj34;
		object obj36;
		object obj33;
		if ((nint)0 != 0)
		{
			obj33 = (nint)0 + (nint)2720;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v296 @ X0_v30+B8]");
			obj34 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v306 @ X8_v23+10]");
			func4 = (Func<object, object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v306 @ X8_v23+10]");
			bool flag9 = (nint)0 == 0;
			object obj35 = !flag9;
			if (obj35 == null)
			{
				obj36 = obj33;
				goto IL_02b8;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj32 = obj4;
			obj36 = (nint)0 + (nint)2720;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v296 @ X0_v30+B8]");
			obj34 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v306 @ X8_v23+10]");
			func4 = (Func<object, object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v306 @ X8_v23+10]");
			bool flag10 = (nint)0 == 0;
			object obj37 = !flag10;
			obj33 = obj36;
			if (obj37 == null)
			{
				goto IL_02b8;
			}
		}
		goto IL_030f;
		IL_02b8:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v296 @ X0_v30+E4]");
		bool flag11 = (nint)0 == 0;
		object obj38 = !flag11;
		if (obj38 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj39 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v315 @ X8_v29+B8]");
			obj34 = 0;
		}
		object obj40 = typeof(System.Dynamic.Utils.EmptyReadOnlyCollection<ParameterExpression>) + 3344;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj41 = (nint)0 + (nint)1920;
		Func<object, object> func5 = default(Func<object, object>);
		func5..ctor(obj34, (IntPtr)obj41);
		object obj42 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v267 @ X8_v28+B8]");
		object obj43 = (nint)0 + (nint)16;
		obj43 = func5;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj18 = 0;
		obj33 = obj36;
		func4 = func5;
		goto IL_030f;
	}

	private void InitializeItem(MiniGameRewardDescription description)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_010d: Expected O, but got I
		//IL_0127: Expected O, but got I
		//IL_0151: Expected O, but got I4
		//IL_0169: Expected O, but got I
		//IL_0053: Expected O, but got I
		//IL_006d: Expected O, but got I
		//IL_00a4: Expected O, but got I
		//IL_00e1: Expected O, but got I
		//IL_00f1: Expected O, but got I
		//IL_01b2: Expected O, but got I4
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6413]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 == null)
		{
			goto IL_00fb;
		}
		object obj3 = (nint)0 + (nint)984;
		RectTransform rectTransform = rewardsParent;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X20_v7 (UnityEngine.RectTransform)+28]");
		object obj4 = 0;
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X20_v7 (UnityEngine.RectTransform)+28]");
		object obj7 = 0;
		RectTransform rectTransform2 = rectTransform;
		if (!flag)
		{
			goto IL_00ba;
		}
		goto IL_017f;
		IL_017f:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE9DE4");
		object obj8 = default(object);
		bool flag2 = obj8 == null;
		object obj9 = !flag2;
		if (obj9 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_00c9;
		IL_00ba:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE9DE4");
		goto IL_00c9;
		IL_00c9:
		object obj10 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X8_v7+178]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X8_v7+180]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v99 @ X3_v4 (should have been resolved before IL gen)");
		goto IL_00fb;
		IL_00fb:
		_ = 1;
		obj3 = (nint)0 + (nint)984;
		rectTransform = rewardsParent;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X20_v7 (UnityEngine.RectTransform)+28]");
		obj4 = 0;
		obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X0_v3+E4]");
		bool flag3 = (nint)0 == 0;
		object obj13 = !flag3;
		obj6 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X20_v7 (UnityEngine.RectTransform)+28]");
		obj7 = 0;
		rectTransform2 = rectTransform;
		if (obj13 != null)
		{
			goto IL_00ba;
		}
		goto IL_017f;
	}
}
