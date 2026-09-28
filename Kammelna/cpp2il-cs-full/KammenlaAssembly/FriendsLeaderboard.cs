using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Formats.Asn1;
using System.Linq;
using Cpp2ILInjected;
using HuaweiMobileServices.Location.Location;
using Kammelna.Server;
using Kammelna.Server.Models.Clans;
using ListView;
using Microsoft.Extensions.DependencyInjection.ServiceLookup;
using Sfs2X.Entities;
using TMPro;
using UnityEngine;
using UnityEngine.AdaptivePerformance;
using UnityEngine.Rendering;
using UnityEngine.TextCore;

public class FriendsLeaderboard : MonoBehaviour
{
	private FriendsLeaderboardView listView;

	private GameObject placeholder;

	private TextMeshProUGUI counter;

	private InputFieldTMProUGUI filterInput;

	private LeaderboardFriendListItem myPlace;

	private bool _isTournamentPointView;

	private readonly List<FriendLeaderboardModel> _friends;

	private bool didSend;

	public void SwitchView()
	{
		bool isTournamentPointView = (byte)((_isTournamentPointView ? 1u : 0u) ^ 1u) != 0;
		_isTournamentPointView = isTournamentPointView;
		AssignPlacements();
		IEnumerable<FriendLeaderboardModel> friendsAfterFilterAndOrder = GetFriendsAfterFilterAndOrder();
		listView.SetData(friendsAfterFilterAndOrder, _isTournamentPointView);
		HandlePlaceHolder();
		UpdateListCounter();
	}

	private void Start()
	{
		RegisterEvents();
	}

	private void OnEnable()
	{
		//IL_001c: Expected O, but got I4
		bool flag = !didSend;
		object obj = !flag;
		if (obj == null)
		{
			PopulateList();
			didSend = true;
		}
	}

	private void OnDestroy()
	{
		UnregisterEvents();
	}

	private void PopulateList()
	{
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Expected O, but got Unknown
		//IL_00a7: Expected O, but got I
		//IL_00da: Expected I, but got O
		List<FriendLeaderboardModel> friends = _friends;
		int version = friends._version + 1;
		friends._size = 0;
		friends._version = version;
		bool flag = friends._size < 1;
		IntPtr intPtr = default(IntPtr);
		int num = (int)(nint)intPtr;
		if (!flag)
		{
			Array.Clear(friends._items, 0, friends._size);
			num = 0;
		}
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 360;
		object obj2 = (nint)0 + (nint)2704;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj2);
		KammelnaRequests.GetFriendsLeaderboardList(action);
		AddMyself();
	}

	private void AddMyFriends()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_003e: Expected I, but got O
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 360;
		object obj2 = (nint)0 + (nint)2704;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj2);
		KammelnaRequests.GetFriendsLeaderboardList(action);
	}

	private void AddMyself()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_006b: Expected I, but got O
		//IL_0095: Expected O, but got I4
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3000;
		object obj2 = (nint)0 + (nint)2712;
		object obj3 = typeof(System.Buffers.Text.ParserHelpers) + 1056;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj2);
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		PlayerProfilesHandler.RequestMyProfile(action);
	}

	private void RegisterEvents()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_01bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c1: Expected O, but got Unknown
		//IL_01d9: Expected I, but got O
		//IL_014b: Expected O, but got I4
		//IL_00a4: Expected O, but got I4
		//IL_0195: Expected O, but got I4
		//IL_019e: Expected O, but got I4
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected O, but got Unknown
		//IL_00d2: Expected O, but got I
		//IL_00ea: Expected I, but got O
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)2752;
		object obj3 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1528;
		object obj4 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		object obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v4+E4]");
		UnityEngine.Object obj7;
		UnityEngine.Object obj8;
		if ((nint)0 != 0)
		{
			FriendsManager.OnFriendListUpdated += action;
			object obj6 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X0_v6+E4]");
			bool flag = (nint)0 == 0;
			obj7 = filterInput;
			obj8 = filterInput;
			if (!flag)
			{
				goto IL_0083;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			FriendsManager.OnFriendListUpdated += action;
			obj7 = filterInput;
			object obj6 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X0_v6+E4]");
			bool flag2 = (nint)0 == 0;
			object obj9 = !flag2;
			obj8 = filterInput;
			if (obj9 != null)
			{
				goto IL_0083;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = obj8;
		bool flag4 = !flag3;
		object obj10 = !flag4;
		object obj11 = 0;
		if (obj10 == null)
		{
			return;
		}
		goto IL_00b2;
		IL_00b2:
		object obj12 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3576;
		object obj13 = (nint)0 + (nint)2744;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action2 = default(Action<object>);
		action2..ctor((object)this, (IntPtr)obj13);
		filterInput.OnValueChanged += action2;
		return;
		IL_0083:
		bool flag5 = obj7;
		bool flag6 = !flag5;
		obj11 = 0;
		if (!flag6)
		{
			goto IL_00b2;
		}
	}

	private void UnregisterEvents()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0074: Expected I, but got O
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)2752;
		object obj3 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1528;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v4+E4]");
		if ((nint)0 != 0)
		{
			FriendsManager.OnFriendListUpdated -= action;
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		FriendsManager.OnFriendListUpdated -= action;
	}

	private void FilterUpdated(string newVal)
	{
		IEnumerable<FriendLeaderboardModel> friendsAfterFilterAndOrder = GetFriendsAfterFilterAndOrder();
		listView.SetData(friendsAfterFilterAndOrder, _isTournamentPointView);
		HandlePlaceHolder();
		UpdateListCounter();
	}

	private void UpdateUI(bool updatePlacements = true)
	{
		if (updatePlacements)
		{
			AssignPlacements();
		}
		IEnumerable<FriendLeaderboardModel> friendsAfterFilterAndOrder = GetFriendsAfterFilterAndOrder();
		listView.SetData(friendsAfterFilterAndOrder, _isTournamentPointView);
		HandlePlaceHolder();
		UpdateListCounter();
	}

	private IEnumerable<FriendLeaderboardModel> GetFriendsAfterFilterAndOrder()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002c: Expected O, but got I
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected O, but got Unknown
		//IL_024f: Expected I, but got O
		//IL_0097: Expected O, but got I4
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Expected O, but got Unknown
		//IL_01be: Expected O, but got I4
		//IL_01c7: Expected O, but got I4
		//IL_0175: Expected O, but got I4
		//IL_01e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e9: Expected O, but got Unknown
		//IL_01ff: Expected O, but got I
		//IL_020d: Expected I, but got O
		object obj = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 1168;
		object obj2 = (nint)0 + (nint)2728;
		object obj3 = (nint)0 + (nint)2400;
		object obj4 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Func<object, long> func = default(Func<object, long>);
		func..ctor((object)this, (IntPtr)obj2);
		IOrderedEnumerable<object> orderedEnumerable = Enumerable.OrderByDescending(_friends, func);
		object obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X0_v6+E4]");
		if ((nint)0 != 0)
		{
			bool flag = filterInput;
			bool flag2 = !flag;
			object obj6 = !flag2;
			if (obj6 != null)
			{
				goto IL_00e1;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			if ((bool)filterInput)
			{
				goto IL_00e1;
			}
		}
		goto IL_0183;
		IL_0183:
		return (IEnumerable<FriendLeaderboardModel>)orderedEnumerable;
		IL_00e1:
		if ((object)filterInput != null)
		{
			string text = filterInput.Text;
			object obj7 = typeof(System.Formats.Asn1.SetOfValueComparer) + 2536;
			object obj8 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X8_v7+E4]");
			if ((nint)0 != 0)
			{
				bool flag3 = StringsExtensions.IsNullOrEmpty(text);
				bool flag4 = !flag3;
				object obj9 = 0;
				if (!flag4)
				{
					goto IL_0183;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				bool flag5 = StringsExtensions.IsNullOrEmpty(text);
				bool flag6 = !flag5;
				object obj10 = !flag6;
				object obj9 = 0;
				if (obj10 != null)
				{
					goto IL_0183;
				}
			}
			object obj11 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 1160;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj12 = (nint)0 + (nint)2736;
			Func<object, bool> func2 = default(Func<object, bool>);
			func2..ctor((object)this, (IntPtr)obj12);
			return (IEnumerable<FriendLeaderboardModel>)Enumerable.Where(orderedEnumerable, func2);
		}
		return (IEnumerable<FriendLeaderboardModel>)new NullReferenceException();
	}

	private void AssignPlacements()
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		//IL_0021: Expected O, but got I
		//IL_002d: Expected O, but got I
		//IL_0744: Expected I, but got O
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected O, but got Unknown
		//IL_007b: Expected I, but got O
		//IL_008b: Expected O, but got I
		//IL_0165: Expected O, but got I
		//IL_0189: Expected O, but got I4
		//IL_019b: Expected O, but got I4
		//IL_01a4: Expected O, but got I4
		//IL_028b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0290: Expected O, but got Unknown
		//IL_029f: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a4: Expected O, but got Unknown
		//IL_02ad: Expected O, but got I4
		//IL_00c6: Expected O, but got I
		//IL_08c7: Expected O, but got I
		//IL_01c5: Expected O, but got I4
		//IL_01d6: Expected O, but got I4
		//IL_0782: Unknown result type (might be due to invalid IL or missing references)
		//IL_0787: Expected O, but got Unknown
		//IL_0368: Expected O, but got I4
		//IL_01e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e9: Expected O, but got Unknown
		//IL_01f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f7: Expected O, but got Unknown
		//IL_020f: Expected O, but got I
		//IL_023a: Expected O, but got I4
		//IL_025d: Expected O, but got I4
		//IL_0802: Expected O, but got I
		//IL_0815: Unknown result type (might be due to invalid IL or missing references)
		//IL_081a: Expected O, but got Unknown
		//IL_02d0: Expected O, but got I
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Expected O, but got Unknown
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Expected O, but got Unknown
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Expected O, but got Unknown
		//IL_0554: Expected O, but got I4
		//IL_07c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c8: Expected O, but got Unknown
		//IL_038b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0390: Expected O, but got Unknown
		//IL_0906: Expected O, but got I4
		//IL_02e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02eb: Expected O, but got Unknown
		//IL_0301: Expected O, but got I
		//IL_030c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0311: Expected O, but got Unknown
		//IL_0568: Unknown result type (might be due to invalid IL or missing references)
		//IL_056d: Expected O, but got Unknown
		//IL_0585: Expected O, but got I
		//IL_03da: Expected O, but got I
		//IL_0624: Expected O, but got I4
		//IL_04ad: Expected O, but got I4
		//IL_0948: Expected O, but got I
		//IL_05c0: Expected O, but got I
		//IL_0888: Expected O, but got I
		//IL_0415: Expected O, but got I
		//IL_084a: Unknown result type (might be due to invalid IL or missing references)
		//IL_084f: Expected O, but got Unknown
		//IL_0647: Unknown result type (might be due to invalid IL or missing references)
		//IL_064c: Expected O, but got Unknown
		//IL_04f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04fd: Expected O, but got Unknown
		//IL_0517: Expected O, but got I4
		//IL_04d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d5: Expected O, but got Unknown
		//IL_05ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d3: Expected O, but got Unknown
		//IL_05e9: Expected O, but got I
		//IL_042b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0430: Expected O, but got Unknown
		//IL_0446: Expected O, but got I
		//IL_0451: Unknown result type (might be due to invalid IL or missing references)
		//IL_0456: Expected O, but got Unknown
		object obj = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 1168;
		object obj2 = (nint)0 + (nint)2720;
		object obj3 = (nint)0 + (nint)2400;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Func<object, long> func = default(Func<object, long>);
		func..ctor((object)this, (IntPtr)obj2);
		object obj4 = obj3;
		IOrderedEnumerable<object> orderedEnumerable = Enumerable.OrderByDescending(_friends, func);
		bool flag = orderedEnumerable == null;
		Func<object, long> func2 = func;
		Func<object, long> func3 = func;
		object obj7;
		bool flag3 = default(bool);
		object obj13 = default(object);
		object obj16;
		object obj9 = default(object);
		object obj12;
		object obj14;
		object obj15;
		if (!flag)
		{
			object obj5 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 3176;
			nint num = (nint)orderedEnumerable;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X8_v15 (Il2CppClass<System.Linq.IOrderedEnumerable`1<System.Object>>)+12E]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X8_v15 (Il2CppClass<System.Linq.IOrderedEnumerable`1<System.Object>>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0143;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X8_v15 (Il2CppClass<System.Linq.IOrderedEnumerable`1<System.Object>>)+B0]");
			obj7 = (nint)0 + (nint)8;
			bool flag2 = flag3;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X10_v11-8]");
				object obj8 = 0 - obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X10_v11-8]");
				if (0 == (nint)obj5)
				{
					break;
				}
				obj9 = obj7 + 16;
				obj6--;
				obj8 = obj6 - 1;
				bool flag4 = obj8 == null;
				flag3 = (nint)obj6 != 1;
				flag2 = flag3;
				obj7 = obj9;
				if (flag3)
				{
					continue;
				}
				goto IL_0143;
			}
			object obj10 = num + obj7;
			object obj11 = obj10 + 312;
			obj12 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ X8_v31+8]");
			func2 = (Func<object, long>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v266 @ X8_v31] (should have been resolved before IL gen)");
			bool flag5 = obj13 == null;
			obj14 = obj13;
			obj15 = 0;
			flag3 = flag2;
			obj9 = obj7;
			obj14 = obj13;
			obj15 = 0;
			obj16 = obj4;
			func3 = func;
			if (!flag5)
			{
				goto IL_027c;
			}
			goto IL_053d;
		}
		goto IL_0764;
		IL_027c:
		object obj17 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2528;
		func3 = (Func<object, long>)(typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 552);
		object obj18 = 1;
		object obj19 = obj13;
		object obj25 = default(object);
		object obj37 = default(object);
		object obj38 = default(object);
		while (true)
		{
			object obj20 = obj19;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v376 @ X8_v20+12E]");
			obj12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v376 @ X8_v20+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0355;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v376 @ X8_v20+B0]");
			object obj21 = (nint)0 + (nint)8;
			bool flag6 = flag3;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v447 @ X10_v25-8]");
				object obj8 = 0 - obj17;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v447 @ X10_v25-8]");
				if (0 == (nint)obj17)
				{
					break;
				}
				obj9 = obj21 + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v376 @ X8_v20+12E]");
				obj12 = -1;
				obj8 = obj12 - 1;
				bool flag4 = obj8 == null;
				flag3 = (nint)obj12 != 1;
				flag6 = flag3;
				obj21 = obj9;
				if (flag3)
				{
					continue;
				}
				goto IL_0355;
			}
			obj12 = obj21;
			object obj22 = obj20 + obj21;
			object obj23 = obj22 + 312;
			flag3 = flag6;
			obj9 = obj21;
			goto IL_07f1;
			IL_07f1:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v463 @ X0_v31+8]");
			func2 = (Func<object, long>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v463 @ X0_v31] (should have been resolved before IL gen)");
			object obj24 = obj25 & 1;
			if (obj24 != null)
			{
				if (obj14 == null)
				{
					break;
				}
				object obj26 = obj14;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v550 @ X8_v23+12E]");
				obj12 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v550 @ X8_v23+12E]");
				if ((nint)0 == 0)
				{
					goto IL_049a;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v550 @ X8_v23+B0]");
				object obj27 = (nint)0 + (nint)8;
				bool flag7 = flag3;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v642 @ X10_v20-8]");
					object obj8 = 0 - func3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v642 @ X10_v20-8]");
					if (0 == (nint)func3)
					{
						break;
					}
					obj9 = obj27 + 16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v550 @ X8_v23+12E]");
					obj12 = -1;
					obj8 = obj12 - 1;
					bool flag4 = obj8 == null;
					flag3 = (nint)obj12 != 1;
					flag7 = flag3;
					obj27 = obj9;
					if (flag3)
					{
						continue;
					}
					goto IL_049a;
				}
				obj12 = obj27;
				object obj28 = obj26 + obj27;
				object obj29 = obj28 + 312;
				flag3 = flag7;
				obj9 = obj27;
				goto IL_0878;
			}
			object obj30 = 0;
			while (true)
			{
				if (obj14 == null)
				{
					goto IL_08ec;
				}
				object obj31 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2344;
				object obj32 = obj14;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v492 @ X8_v7+12E]");
				obj12 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v492 @ X8_v7+12E]");
				if ((nint)0 == 0)
				{
					goto IL_0611;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v492 @ X8_v7+B0]");
				object obj33 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v621 @ X10_v7-8]");
					if (0 == (nint)obj31)
					{
						break;
					}
					obj9 = obj33 + 16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v492 @ X8_v7+12E]");
					obj12 = -1;
					bool flag8 = (nint)obj12 != 1;
					obj33 = obj9;
					if (flag8)
					{
						continue;
					}
					goto IL_0611;
				}
				obj12 = obj33;
				object obj34 = obj32 + obj33;
				object obj35 = obj34 + 312;
				obj9 = obj33;
				goto IL_0938;
				IL_08ec:
				bool flag9 = obj30 == null;
				object obj36 = !flag9;
				if (obj36 == null)
				{
					return;
				}
				OutOfMemoryException ex = new OutOfMemoryException();
				if ((nint)func2 != 1)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
				obj30 = obj37;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
				obj15 = obj37;
				continue;
				IL_0611:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
				obj4 = 0;
				goto IL_0938;
				IL_0938:
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v657 @ X0_v8+8]");
				func2 = (Func<object, long>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v657 @ X0_v8] (should have been resolved before IL gen)");
				goto IL_08ec;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C99C14");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
			return;
			IL_049a:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			obj4 = 0;
			goto IL_0878;
			IL_0878:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v664 @ X0_v35+8]");
			func2 = (Func<object, long>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v664 @ X0_v35] (should have been resolved before IL gen)");
			if (obj38 != null)
			{
				obj3 = obj18 + 1;
				bool flag10 = obj14 == null;
				object obj39 = !flag10;
				obj7 = obj9;
				obj16 = obj4;
				obj19 = obj14;
				if (obj39 != null)
				{
					continue;
				}
				goto IL_053d;
			}
			goto IL_065a;
			IL_0355:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			obj4 = 0;
			goto IL_07f1;
		}
		NullReferenceException ex2 = new NullReferenceException();
		obj7 = obj9;
		obj16 = obj4;
		goto IL_0696;
		IL_065a:
		NullReferenceException ex3 = new NullReferenceException();
		obj7 = obj9;
		obj16 = obj4;
		goto IL_0696;
		IL_053d:
		NullReferenceException ex4 = new NullReferenceException();
		goto IL_0696;
		IL_0764:
		throw new NullReferenceException();
		IL_0696:
		obj9 = obj7;
		obj4 = obj16;
		goto IL_0764;
		IL_0143:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		object obj40 = default(object);
		obj12 = obj40;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X0_v45+8]");
		func2 = (Func<object, long>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v178 @ X0_v45] (should have been resolved before IL gen)");
		bool flag11 = obj13 == null;
		object obj41 = !flag11;
		obj14 = obj13;
		obj15 = 0;
		obj4 = 0;
		if (obj41 != null)
		{
			goto IL_027c;
		}
		obj14 = obj13;
		obj15 = 0;
		obj7 = obj9;
		obj16 = 0;
		goto IL_053d;
	}

	private void HandlePlaceHolder()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0131: Expected O, but got I4
		//IL_017b: Expected O, but got I4
		object obj = 152985600;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E617B]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj6;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			obj5 = placeholder;
			obj6 = placeholder;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			obj5 = placeholder;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v2+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj6 = placeholder;
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
		IEnumerable<object> data = listView.data;
		bool flag5 = Enumerable.Any(data);
		bool active = (byte)((flag5 ? 1u : 0u) ^ 1u) != 0;
		placeholder.SetActive(active);
		return;
		IL_0091:
		if ((bool)obj5)
		{
			goto IL_00b7;
		}
	}

	private void UpdateListCounter()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00fe: Expected O, but got I4
		//IL_00b5: Expected O, but got I4
		object obj = 152985600;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E617C]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj6;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v10+E4]");
			bool flag = (nint)0 == 0;
			obj5 = counter;
			obj6 = counter;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			obj5 = counter;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v10+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj6 = counter;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		if (!(obj6 != null))
		{
			return;
		}
		goto IL_014c;
		IL_014c:
		List<IListViewItemData<int>> data = listView.data;
		int num = default(int);
		string text = num.ToString();
		counter.text = text;
		return;
		IL_0091:
		bool flag3 = obj5 != null;
		bool flag4 = !flag3;
		object obj8 = !flag4;
		if (obj8 == null)
		{
			return;
		}
		goto IL_014c;
	}

	private void OnFriendListUpdated()
	{
		GameObject gameObject = base.gameObject;
		if (gameObject.activeInHierarchy)
		{
			PopulateList();
		}
		else
		{
			didSend = false;
		}
	}

	public FriendsLeaderboard()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		object obj = typeof(List<AdaptivePerformanceScaler>) + 1104;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list = default(List<object>);
		list..ctor();
		object obj2 = this + 80;
		obj2 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		base..ctor();
	}

	private void <AddMyFriends>b__13_0(KammelnaResponseModel<List<FriendLeaderboardModel>> response)
	{
		if (((KammelnaResponseModel<object>)(object)response).Succeeded)
		{
			((List<object>)(object)_friends).AddRange((IEnumerable<object>)response.<Model>k__BackingField);
		}
		AssignPlacements();
		IEnumerable<FriendLeaderboardModel> friendsAfterFilterAndOrder = GetFriendsAfterFilterAndOrder();
		listView.SetData(friendsAfterFilterAndOrder, _isTournamentPointView);
		HandlePlaceHolder();
		UpdateListCounter();
	}

	private void <AddMyself>b__14_0(PlayerProfileModel model)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_03b9: Expected O, but got I
		//IL_0400: Expected O, but got I4
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Expected O, but got Unknown
		//IL_02f6: Expected O, but got I4
		//IL_0331: Unknown result type (might be due to invalid IL or missing references)
		//IL_0336: Expected O, but got Unknown
		//IL_033f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0344: Expected O, but got Unknown
		object obj = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1392;
		object obj2 = typeof(Queue<string>) + 848;
		PlayerRankingModel <ranking>k__BackingField = model.<ranking>k__BackingField;
		if (model.<ranking>k__BackingField != null)
		{
			int <currentMonthPoints>k__BackingField = <ranking>k__BackingField.<currentMonthPoints>k__BackingField;
		}
		else
		{
			int <currentMonthPoints>k__BackingField = 0;
		}
		object obj3 = (nint)0 + (nint)2200;
		List<object> friends = (List<object>)(object)_friends;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj4 = default(object);
		obj4..ctor();
		object obj5 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ X0_v6+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel = default(SessionModel);
		User localUser = sessionModel.LocalUser;
		string dbId = SFSKammelnaUserExtensions.GetDbId(localUser);
		int num = int.Parse(dbId);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel2 = default(SessionModel);
		User localUser2 = sessionModel2.LocalUser;
		string userName = SFSKammelnaUserExtensions.GetUserName(localUser2);
		object obj7 = obj4 + 24;
		obj7 = userName;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel3 = default(SessionModel);
		User localUser3 = sessionModel3.LocalUser;
		bool flag2 = SFSKammelnaUserExtensions.IsSubscribed(localUser3);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel4 = default(SessionModel);
		User localUser4 = sessionModel4.LocalUser;
		bool flag3 = SFSKammelnaUserExtensions.IsVerified(localUser4);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel5 = default(SessionModel);
		User localUser5 = sessionModel5.LocalUser;
		DateTime? avatarDate = SFSKammelnaUserExtensions.GetAvatarDate(localUser5);
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel6 = default(SessionModel);
		User localUser6 = sessionModel6.LocalUser;
		PlayerRank rank = SFSKammelnaUserExtensions.GetRank(localUser6);
		_ = rank.<IsNew>k__BackingField;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel7 = default(SessionModel);
		User localUser7 = sessionModel7.LocalUser;
		PlayerRank rank2 = SFSKammelnaUserExtensions.GetRank(localUser7);
		_ = rank2.<Points>k__BackingField;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel8 = default(SessionModel);
		User localUser8 = sessionModel8.LocalUser;
		int activeCardbackID = SFSKammelnaUserExtensions.GetActiveCardbackID(localUser8);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel9 = default(SessionModel);
		User localUser9 = sessionModel9.LocalUser;
		int tournamentPoints = SFSKammelnaUserExtensions.GetTournamentPoints(localUser9);
		int version = friends._version + 1;
		friends._version = version;
		object[] items = friends._items;
		bool flag4 = friends._size < items.Length;
		object obj8 = !flag4;
		if (obj8 == null)
		{
			int size = friends._size + 1;
			friends._size = size;
			object obj9 = items + friends._size;
			object obj10 = obj9 + 32;
			obj10 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
		else
		{
			friends.AddWithResize(obj4);
		}
		AssignPlacements();
		IEnumerable<FriendLeaderboardModel> friendsAfterFilterAndOrder = GetFriendsAfterFilterAndOrder();
		listView.SetData(friendsAfterFilterAndOrder, _isTournamentPointView);
		HandlePlaceHolder();
		UpdateListCounter();
	}

	private long <GetFriendsAfterFilterAndOrder>b__19_0(FriendLeaderboardModel o)
	{
		//IL_007b: Expected I8, but got O
		//IL_0046: Expected I8, but got I4
		if (_isTournamentPointView)
		{
			if (o != null)
			{
				return o.<tournamentPoints>k__BackingField;
			}
		}
		else if (o != null)
		{
			return o.<currentMonthPoints>k__BackingField;
		}
		NullReferenceException ex = new NullReferenceException();
		return (long)ex;
	}

	private bool <GetFriendsAfterFilterAndOrder>b__19_1(FriendLeaderboardModel friend)
	{
		//IL_00b7: Expected I4, but got O
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected O, but got Unknown
		//IL_0071: Expected O, but got I4
		if (friend != null && (object)filterInput != null)
		{
			object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 2536;
			string text = filterInput.Text;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v6+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			return StringsExtensions.ContainsIgnoreCase(friend.<userName>k__BackingField, text);
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	private long <AssignPlacements>b__20_0(FriendLeaderboardModel o)
	{
		//IL_007b: Expected I8, but got O
		//IL_0046: Expected I8, but got I4
		if (_isTournamentPointView)
		{
			if (o != null)
			{
				return o.<tournamentPoints>k__BackingField;
			}
		}
		else if (o != null)
		{
			return o.<currentMonthPoints>k__BackingField;
		}
		NullReferenceException ex = new NullReferenceException();
		return (long)ex;
	}
}
