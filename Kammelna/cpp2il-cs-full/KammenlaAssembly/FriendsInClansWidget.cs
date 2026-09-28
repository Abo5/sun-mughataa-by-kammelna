using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Linq;
using Cpp2ILInjected;
using HuaweiMobileServices.Location.Location;
using Kammelna.Server.Models.Clans;
using Microsoft.Extensions.DependencyInjection.ServiceLookup;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.TextCore;

public class FriendsInClansWidget : MonoBehaviour, IWidget
{
	private RectTransform entriesContainer;

	private FriendInClanEntry entryPrefab;

	private void Awake()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_006a: Expected I, but got O
		//IL_0094: Expected O, but got I4
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)2696;
		object obj3 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1528;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		FriendsManager.OnFriendListUpdated += action;
	}

	private void OnDestroy()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_006a: Expected I, but got O
		//IL_0094: Expected O, but got I4
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)2696;
		object obj3 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1528;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		FriendsManager.OnFriendListUpdated -= action;
	}

	public void Populate()
	{
		Render();
	}

	private unsafe void Render()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_07f4: Expected I, but got O
		//IL_0804: Expected O, but got I
		//IL_0826: Expected O, but got I4
		//IL_0065: Expected O, but got I4
		//IL_00ac: Expected I, but got O
		//IL_00ce: Expected O, but got I4
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Expected O, but got Unknown
		//IL_0123: Expected O, but got I
		//IL_0131: Expected I, but got O
		//IL_013d: Expected O, but got I
		//IL_0173: Expected O, but got I4
		//IL_017c: Expected O, but got I4
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ae: Expected O, but got Unknown
		//IL_01b6: Expected I, but got O
		//IL_01c6: Expected O, but got I
		//IL_08b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b6: Expected O, but got Unknown
		//IL_08c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ca: Expected O, but got Unknown
		//IL_08d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_08de: Expected O, but got Unknown
		//IL_08ea: Expected O, but got I
		//IL_08fa: Expected O, but got Ref
		//IL_0201: Expected O, but got I
		//IL_0852: Unknown result type (might be due to invalid IL or missing references)
		//IL_0857: Expected O, but got Unknown
		//IL_0707: Expected O, but got I4
		//IL_02a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a7: Expected O, but got Unknown
		//IL_02b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b5: Expected O, but got Unknown
		//IL_075d: Expected O, but got I4
		//IL_0766: Expected O, but got I4
		//IL_02e2: Expected O, but got I
		//IL_0217: Unknown result type (might be due to invalid IL or missing references)
		//IL_021c: Expected O, but got Unknown
		//IL_0225: Unknown result type (might be due to invalid IL or missing references)
		//IL_022a: Expected O, but got Unknown
		//IL_0235: Unknown result type (might be due to invalid IL or missing references)
		//IL_023a: Expected O, but got Unknown
		//IL_0958: Expected O, but got I
		//IL_096b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0970: Expected O, but got Unknown
		//IL_031d: Expected O, but got I
		//IL_05e2: Expected O, but got I4
		//IL_05eb: Expected O, but got I4
		//IL_05f4: Expected O, but got I4
		//IL_0912: Unknown result type (might be due to invalid IL or missing references)
		//IL_0917: Expected O, but got Unknown
		//IL_03d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d9: Expected O, but got Unknown
		//IL_0a50: Expected O, but got I4
		//IL_0333: Unknown result type (might be due to invalid IL or missing references)
		//IL_0338: Expected O, but got Unknown
		//IL_034e: Expected O, but got I
		//IL_0359: Unknown result type (might be due to invalid IL or missing references)
		//IL_035e: Expected O, but got Unknown
		//IL_0608: Unknown result type (might be due to invalid IL or missing references)
		//IL_060d: Expected O, but got Unknown
		//IL_0625: Expected O, but got I
		//IL_0423: Expected O, but got I
		//IL_0a92: Expected O, but got I
		//IL_0660: Expected O, but got I
		//IL_0a0b: Expected O, but got I4
		//IL_045e: Expected O, but got I
		//IL_099f: Unknown result type (might be due to invalid IL or missing references)
		//IL_09a4: Expected O, but got Unknown
		//IL_06e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e8: Expected O, but got Unknown
		//IL_0515: Unknown result type (might be due to invalid IL or missing references)
		//IL_051a: Expected O, but got Unknown
		//IL_066e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0673: Expected O, but got Unknown
		//IL_0689: Expected O, but got I
		//IL_0474: Unknown result type (might be due to invalid IL or missing references)
		//IL_0479: Expected O, but got Unknown
		//IL_048f: Expected O, but got I
		//IL_049a: Unknown result type (might be due to invalid IL or missing references)
		//IL_049f: Expected O, but got Unknown
		//IL_059a: Expected O, but got I
		//IL_05cb: Expected O, but got I
		Func<object, bool> func = (Func<object, bool>)(typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1528);
		nint num = (nint)func;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v2 (Il2CppClass<System.Func`2<System.Object, System.Boolean>>)+E4]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v2 (Il2CppClass<System.Func`2<System.Object, System.Boolean>>)+E4]");
		bool flag = (nint)0 == 0;
		object obj2 = !flag;
		if (obj2 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		IEnumerable<FriendProfile> friendsList = FriendsManager.FriendsList;
		bool flag2 = Enumerable.Any((IEnumerable<object>)friendsList);
		GameObject gameObject = base.gameObject;
		bool flag3 = (object)gameObject == null;
		object obj3 = 0;
		Func<object, bool> func2 = null;
		Func<object, bool> func3 = default(Func<object, bool>);
		bool flag7 = default(bool);
		object obj14;
		ClanBadgeModel clanBadgeModel;
		object obj7;
		if (!flag3)
		{
			gameObject.SetActive(flag2);
			if (!flag2)
			{
				return;
			}
			ClearEntries();
			nint num2 = (nint)func;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v276 @ X0_v31 (Il2CppClass<System.Func`2<System.Object, System.Boolean>>)+E4]");
			bool flag4 = (nint)0 == 0;
			object obj4 = !flag4;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			IEnumerable<FriendProfile> friendsList2 = FriendsManager.FriendsList;
			object obj5 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 1192;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj6 = (nint)0 + (nint)2688;
			func3..ctor((object)null, (IntPtr)obj6);
			obj = (nint)0 + (nint)3432;
			clanBadgeModel = (ClanBadgeModel)obj;
			IEnumerable<object> enumerable = Enumerable.Where(friendsList2, func3);
			bool flag5 = enumerable == null;
			obj3 = 0;
			obj7 = 0;
			func2 = func3;
			func = func3;
			if (!flag5)
			{
				object obj8 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 3192;
				nint num3 = (nint)enumerable;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v417 @ X8_v24 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+12E]");
				object obj9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v417 @ X8_v24 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_027e;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v417 @ X8_v24 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+B0]");
				object obj10 = (nint)0 + (nint)8;
				bool flag6 = flag7;
				object obj12;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v509 @ X10_v30-8]");
					object obj11 = 0 - obj8;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v509 @ X10_v30-8]");
					if (0 == (nint)obj8)
					{
						break;
					}
					obj12 = obj10 + 16;
					obj9--;
					obj11 = obj9 - 1;
					bool flag8 = obj11 == null;
					flag7 = (nint)obj9 != 1;
					flag6 = flag7;
					obj10 = obj12;
					if (flag7)
					{
						continue;
					}
					goto IL_027e;
				}
				object obj13 = num3 + obj10;
				obj14 = obj13 + 312;
				flag7 = flag6;
				obj12 = obj10;
				goto IL_0880;
			}
		}
		goto IL_0834;
		IL_027e:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		clanBadgeModel = null;
		object obj15 = default(object);
		obj14 = obj15;
		goto IL_0880;
		IL_0880:
		object obj16 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v547 @ X8_v25+8]");
		int num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v547 @ X8_v25] (should have been resolved before IL gen)");
		object obj17 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2528;
		object obj18 = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 568;
		object obj19 = typeof(MemberAchievementClanFeedData) + 2976;
		object obj20 = (nint)0 + (nint)536;
		func = func3;
		obj = (object)(&obj3);
		object obj21 = default(object);
		object obj25 = default(object);
		object obj28 = default(object);
		FriendInClanEntry friendInClanEntry = default(FriendInClanEntry);
		object obj30 = default(object);
		object obj43 = default(object);
		object obj35;
		while (true)
		{
			if (obj21 != null)
			{
				object obj22 = obj21;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v597 @ X8_v29+12E]");
				obj16 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v597 @ X8_v29+12E]");
				if ((nint)0 == 0)
				{
					goto IL_03a2;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v597 @ X8_v29+B0]");
				object obj23 = (nint)0 + (nint)8;
				bool flag9 = flag7;
				object obj12;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v640 @ X10_v25-8]");
					object obj11 = 0 - obj17;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v640 @ X10_v25-8]");
					if (0 == (nint)obj17)
					{
						break;
					}
					obj12 = obj23 + 16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v597 @ X8_v29+12E]");
					obj16 = -1;
					obj11 = obj16 - 1;
					bool flag8 = obj11 == null;
					flag7 = (nint)obj16 != 1;
					flag9 = flag7;
					obj23 = obj12;
					if (flag7)
					{
						continue;
					}
					goto IL_03a2;
				}
				obj16 = obj23;
				object obj24 = obj22 + obj23;
				obj25 = obj24 + 312;
				flag7 = flag9;
				obj12 = obj23;
				goto IL_0940;
			}
			NullReferenceException ex = new NullReferenceException();
			func2 = (Func<object, bool>)num4;
			break;
			IL_03a2:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			clanBadgeModel = null;
			goto IL_0940;
			IL_09cd:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v726 @ X0_v48] (should have been resolved before IL gen)");
			func = (Func<object, bool>)(object)entryPrefab;
			object obj26 = obj19;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v732 @ X0_v51+E4]");
			bool flag10 = (nint)0 == 0;
			object obj27 = !flag10;
			if (obj27 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			clanBadgeModel = (ClanBadgeModel)obj20;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE9D50");
			if (obj28 != null)
			{
				if ((object)friendInClanEntry != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v731 @ X0_v50+48]");
					clanBadgeModel = (ClanBadgeModel)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v731 @ X0_v50+10]");
					num4 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v731 @ X0_v50+10]");
					nint num5 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v731 @ X0_v50+48]");
					friendInClanEntry.Populate((int)num5, (ClanBadgeModel)0);
					continue;
				}
				NullReferenceException ex2 = new NullReferenceException();
				func2 = (Func<object, bool>)(object)entriesContainer;
				break;
			}
			NullReferenceException ex3 = new NullReferenceException();
			func2 = (Func<object, bool>)(object)entriesContainer;
			break;
			IL_04e3:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			clanBadgeModel = null;
			goto IL_09cd;
			IL_0940:
			obj = obj25;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v663 @ X0_v44+8]");
			func2 = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v663 @ X0_v44] (should have been resolved before IL gen)");
			object obj29 = obj30 & 1;
			if (obj29 != null)
			{
				if (obj21 != null)
				{
					object obj31 = obj21;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v668 @ X8_v32+12E]");
					obj16 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v668 @ X8_v32+12E]");
					if ((nint)0 == 0)
					{
						goto IL_04e3;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v668 @ X8_v32+B0]");
					object obj32 = (nint)0 + (nint)8;
					bool flag11 = flag7;
					object obj12;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v710 @ X10_v20-8]");
						object obj11 = 0 - obj18;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v710 @ X10_v20-8]");
						if (0 == (nint)obj18)
						{
							break;
						}
						obj12 = obj32 + 16;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v668 @ X8_v32+12E]");
						obj16 = -1;
						obj11 = obj16 - 1;
						bool flag8 = obj11 == null;
						flag7 = (nint)obj16 != 1;
						flag11 = flag7;
						obj32 = obj12;
						if (flag7)
						{
							continue;
						}
						goto IL_04e3;
					}
					obj16 = obj32;
					object obj33 = obj31 + obj32;
					object obj34 = obj33 + 312;
					flag7 = flag11;
					obj12 = obj32;
					goto IL_09cd;
				}
				NullReferenceException ex4 = new NullReferenceException();
				break;
			}
			obj3 = obj21;
			obj35 = 0;
			obj7 = 0;
			object obj36 = 0;
			while (true)
			{
				if (obj3 == null)
				{
					goto IL_0a36;
				}
				object obj37 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2344;
				object obj38 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v393 @ X8_v8+12E]");
				obj16 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v393 @ X8_v8+12E]");
				if ((nint)0 == 0)
				{
					goto IL_06b1;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v393 @ X8_v8+B0]");
				object obj39 = (nint)0 + (nint)8;
				object obj12;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v488 @ X10_v7-8]");
					if (0 == (nint)obj37)
					{
						break;
					}
					obj12 = obj39 + 16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v393 @ X8_v8+12E]");
					obj16 = -1;
					bool flag12 = (nint)obj16 != 1;
					obj39 = obj12;
					if (flag12)
					{
						continue;
					}
					goto IL_06b1;
				}
				obj16 = obj39;
				object obj40 = obj38 + obj39;
				object obj41 = obj40 + 312;
				obj12 = obj39;
				goto IL_0a82;
				IL_0a36:
				bool flag13 = obj36 == null;
				object obj42 = !flag13;
				if (obj42 == null)
				{
					return;
				}
				OutOfMemoryException ex5 = new OutOfMemoryException();
				if ((nint)func2 != 1)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
				obj36 = obj43;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
				obj35 = obj43;
				continue;
				IL_06b1:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
				clanBadgeModel = null;
				goto IL_0a82;
				IL_0a82:
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v526 @ X0_v11+8]");
				func2 = (Func<object, bool>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v526 @ X0_v11] (should have been resolved before IL gen)");
				goto IL_0a36;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C99C14");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
			return;
		}
		obj3 = obj21;
		obj35 = 0;
		obj7 = 0;
		goto IL_0834;
		IL_0834:
		throw new NullReferenceException();
	}

	private static bool IsInClan(FriendProfile friend)
	{
		//IL_004f: Expected I4, but got O
		if (friend != null)
		{
			bool flag = friend.ActiveClan == null;
			return !flag;
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	private void ClearEntries()
	{
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected O, but got Unknown
		//IL_00d8: Expected O, but got I4
		int childCount = entriesContainer.childCount;
		if (childCount < 1)
		{
			return;
		}
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		int num = childCount;
		do
		{
			num--;
			Transform child = entriesContainer.GetChild(num);
			GameObject gameObject = child.gameObject;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ X8_v6+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			UnityEngine.Object obj4 = gameObject;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj4 = gameObject;
			}
			UnityEngine.Object.Destroy(obj4);
		}
		while (num > 0);
	}
}
