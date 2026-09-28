using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using HuaweiMobileServices.Location.Location;
using Kammelna.Server.Models.Clans;
using UnityEngine;
using UnityEngine.AdaptivePerformance;

public class ChallengesHistoryPanel : MonoBehaviour
{
	private GameObject historyStripPrefab;

	private Transform stripSpawnArea;

	private GameObject noChallenges;

	private GameObject loadingIndicator;

	private ChallengeConnector _connector;

	private List<ChallengeStateData> _data;

	private List<ChallengeHistoryStrip> _strips;

	private int _idForCurrentlyShownUser;

	private PlayerInfo historyOwnerInfo;

	public void SetHistoryOwnerInfo(PlayerInfo player)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		object obj = this + 96;
		obj = player;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	public void SetUserId(int userID)
	{
		_idForCurrentlyShownUser = userID;
	}

	private void Awake()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_00c0: Expected O, but got I
		//IL_00ea: Expected O, but got I4
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Expected O, but got Unknown
		//IL_0081: Expected O, but got I
		//IL_0099: Expected I, but got O
		//IL_00b3: Expected O, but got I
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		object obj2 = (nint)0 + (nint)40;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE90D8");
		object obj5 = this + 64;
		object obj6 = default(object);
		obj5 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj7 = obj5;
		object obj8 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 960;
		object obj9 = (nint)0 + (nint)3600;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj9);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X8_v4+20]");
		((ChallengeEventsChannel)0).OnChallengeDataReceived += action;
	}

	private void OnEnable()
	{
		//IL_0031: Expected I, but got O
		//IL_0041: Expected O, but got I
		//IL_0051: Expected O, but got I
		loadingIndicator.SetActive(value: true);
		ChallengeConnector connector = _connector;
		int idForCurrentlyShownUser = _idForCurrentlyShownUser;
		nint num = (nint)connector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X8_v1 (Il2CppClass<ChallengeConnector>)+1A8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X8_v1 (Il2CppClass<ChallengeConnector>)+1B0]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v40 @ X3_v1 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}

	private void OnDestroy()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_003d: Expected I, but got O
		ChallengeConnector connector = _connector;
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 960;
		object obj2 = (nint)0 + (nint)3600;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj2);
		connector._events.OnChallengeDataReceived -= action;
	}

	private void OnDataReceived(FriendlyChallengeEntryModel[] challenges)
	{
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		loadingIndicator.SetActive(value: false);
		if (challenges != null)
		{
			List<ChallengeStateData> list = ConvertEntriesToChallengeStates(challenges);
			object obj = this + 72;
			obj = list;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
		Clear();
		List<ChallengeStateData> data = _data;
		if (data._size != 0)
		{
			CreateStipsFromData();
		}
		else
		{
			noChallenges.SetActive(value: true);
		}
	}

	private List<ChallengeStateData> ConvertEntriesToChallengeStates(FriendlyChallengeEntryModel[] challenges)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_0051: Expected I, but got O
		object obj = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 1232;
		object obj2 = (nint)0 + (nint)3592;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Func<object, object> func = default(Func<object, object>);
		func..ctor((object)this, (IntPtr)obj2);
		IEnumerable<object> source = Enumerable.Select(challenges, func);
		return (List<ChallengeStateData>)(object)Enumerable.ToList(source);
	}

	private ChallengeStateData CreateChallengeState(FriendlyChallengeEntryModel entry)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Expected O, but got Unknown
		//IL_00c7: Expected I4, but got I8
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Expected O, but got Unknown
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Expected O, but got Unknown
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Expected O, but got Unknown
		//IL_018c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Expected O, but got Unknown
		//IL_01c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ca: Expected O, but got Unknown
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 560;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		if (obj2 != null)
		{
			object obj3 = typeof(System.Buffers.Text.ParserHelpers) + 936;
			object obj4 = obj2 + 16;
			obj4 = historyOwnerInfo;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			PlayerInfo playerInfo = default(PlayerInfo);
			playerInfo..ctor();
			if (entry != null && playerInfo != null)
			{
				object obj5 = typeof(System.Buffers.Text.ParserHelpers) + 1064;
				playerInfo.<DBID>k__BackingField = (int)entry.<DefenderId>k__BackingField;
				object obj6 = playerInfo + 24;
				obj6 = entry.<UserName>k__BackingField;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				playerInfo.<AvatarDate>k__BackingField = entry.<AvatarTimestamp>k__BackingField;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [entry @ X1 (FriendlyChallengeEntryModel)+34]");
				playerInfo.<ActiveCardBack>k__BackingField = 0;
				object obj7 = playerInfo + 64;
				obj7 = entry.<ActiveTitle>k__BackingField;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				PlayerRank playerRank = default(PlayerRank);
				playerRank..ctor(entry.<Points>k__BackingField);
				object obj8 = playerInfo + 32;
				obj8 = playerRank;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				object obj9 = obj2 + 24;
				obj9 = playerInfo;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				_ = entry.<ChallengeLevel>k__BackingField;
				_ = entry.<IsLocked>k__BackingField;
				object obj10 = obj2 + 40;
				obj10 = entry.<History>k__BackingField;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				return (ChallengeStateData)obj2;
			}
		}
		return (ChallengeStateData)(object)new NullReferenceException();
	}

	public void RequestChallengeData()
	{
		//IL_0031: Expected I, but got O
		//IL_0041: Expected O, but got I
		//IL_0051: Expected O, but got I
		loadingIndicator.SetActive(value: true);
		ChallengeConnector connector = _connector;
		int idForCurrentlyShownUser = _idForCurrentlyShownUser;
		nint num = (nint)connector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X8_v1 (Il2CppClass<ChallengeConnector>)+1A8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X8_v1 (Il2CppClass<ChallengeConnector>)+1B0]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v40 @ X3_v1 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}

	private void ShowLoading()
	{
		loadingIndicator.SetActive(value: true);
	}

	private void HideLoading()
	{
		loadingIndicator.SetActive(value: false);
	}

	private void RefreshPanel()
	{
		Clear();
		List<ChallengeStateData> data = _data;
		if (data._size != 0)
		{
			CreateStipsFromData();
		}
		else
		{
			noChallenges.SetActive(value: true);
		}
	}

	private void ShowNoChallenges()
	{
		noChallenges.SetActive(value: true);
	}

	private void HideNoChallenges()
	{
		noChallenges.SetActive(value: false);
	}

	private void Clear()
	{
		//IL_0245: Unknown result type (might be due to invalid IL or missing references)
		//IL_024a: Expected O, but got Unknown
		//IL_0013: Expected O, but got I
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		//IL_0048: Expected O, but got I
		//IL_0071: Expected I, but got O
		//IL_00f9: Expected I, but got O
		//IL_010c: Expected O, but got I4
		//IL_01d7: Expected I, but got O
		//IL_0156: Expected I, but got O
		//IL_0189: Expected O, but got I4
		object obj = this + 80;
		object obj5 = default(object);
		List<object>.Enumerator enumerator2 = default(List<object>.Enumerator);
		nint num = default(nint);
		if (obj != null)
		{
			object obj2 = (nint)0 + (nint)3848;
			object obj3 = typeof(MemberAchievementClanFeedData) + 2976;
			object obj4 = typeof(List<AdaptivePerformanceScaler>) + 432;
			obj5 = (nint)0 + (nint)3840;
			List<object>.Enumerator enumerator = ((List<object>)obj).GetEnumerator();
			num = (nint)obj2;
			object obj6;
			if (!enumerator2.MoveNext())
			{
				num = (nint)obj5;
				enumerator2.Dispose();
				obj6 = 0;
				goto IL_0111;
			}
			NullReferenceException ex = new NullReferenceException();
			obj6 = 0;
		}
		goto IL_0267;
		IL_0267:
		NullReferenceException ex2 = new NullReferenceException();
		bool flag = num != 1;
		OutOfMemoryException ex3 = (OutOfMemoryException)(object)ex2;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			num = (nint)obj5;
			enumerator2.Dispose();
			object obj7 = default(object);
			bool flag2 = obj7 == null;
			object obj6 = obj7;
			if (flag2)
			{
				goto IL_0111;
			}
			ex3 = new OutOfMemoryException();
			obj6 = obj7;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223E740");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
		return;
		IL_0111:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list = default(List<object>);
		list..ctor();
		_strips = (List<ChallengeHistoryStrip>)(object)list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		bool flag3 = (object)noChallenges == null;
		num = (nint)list;
		if (!flag3)
		{
			noChallenges.SetActive(value: false);
			return;
		}
		goto IL_0267;
	}

	private void CreateStipsFromData()
	{
		//IL_0009: Expected O, but got I4
		object obj = 152993792;
		List<object>.Enumerator enumerator2 = default(List<object>.Enumerator);
		if (_data != null)
		{
			List<object>.Enumerator enumerator = ((List<object>)(object)_data).GetEnumerator();
			while (enumerator2.MoveNext())
			{
				CreateStrip(null);
			}
			enumerator2.Dispose();
			return;
		}
		NullReferenceException ex = new NullReferenceException();
		IntPtr intPtr = default(IntPtr);
		bool flag = intPtr != (IntPtr)1;
		NullReferenceException ex2 = ex;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			enumerator2.Dispose();
			object obj2 = default(object);
			if (obj2 == null)
			{
				return;
			}
			OutOfMemoryException ex3 = new OutOfMemoryException();
			object obj3 = obj2;
			ex2 = (NullReferenceException)(object)ex3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223E780");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
	}

	private void CreateStrip(ChallengeStateData data)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_010a: Expected O, but got I
		//IL_0148: Expected O, but got I4
		//IL_00e5: Expected O, but got I4
		//IL_005c: Expected O, but got I
		//IL_019f: Expected O, but got I
		//IL_020c: Expected O, but got I4
		//IL_0247: Unknown result type (might be due to invalid IL or missing references)
		//IL_024c: Expected O, but got Unknown
		//IL_0255: Unknown result type (might be due to invalid IL or missing references)
		//IL_025a: Expected O, but got Unknown
		object obj = 152993792;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8A24]");
		object obj3 = (nint)0 & (nint)1;
		object obj4;
		object obj6;
		if (obj3 != null)
		{
			obj4 = (nint)0 + (nint)544;
			GameObject gameObject = historyStripPrefab;
			Transform transform = stripSpawnArea;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X0_v11+E4]");
			bool flag = (nint)0 == 0;
			Transform transform2 = stripSpawnArea;
			obj6 = obj4;
			GameObject gameObject2 = historyStripPrefab;
			if (!flag)
			{
				goto IL_00b9;
			}
		}
		else
		{
			_ = 1;
			obj4 = (nint)0 + (nint)544;
			GameObject gameObject = historyStripPrefab;
			Transform transform = stripSpawnArea;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X0_v11+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			Transform transform2 = stripSpawnArea;
			obj6 = obj4;
			GameObject gameObject2 = historyStripPrefab;
			if (obj7 != null)
			{
				goto IL_00b9;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj8 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE9D50");
		goto IL_0193;
		IL_0193:
		object obj9 = (nint)0 + (nint)1176;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E32EDC");
		List<object> strips = (List<object>)(object)_strips;
		int version = strips._version + 1;
		strips._version = version;
		object[] items = strips._items;
		bool flag3 = strips._size < items.Length;
		object obj10 = !flag3;
		object obj13 = default(object);
		if (obj10 == null)
		{
			int size = strips._size + 1;
			strips._size = size;
			object obj11 = items + strips._size;
			object obj12 = obj11 + 32;
			obj12 = obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
		else
		{
			strips.AddWithResize(obj13);
		}
		((ChallengeHistoryStrip)obj13).Populate(data, interactable: true);
		return;
		IL_00b9:
		obj8 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE9D50");
		object obj14 = default(object);
		bool flag4 = obj14 == null;
		object obj15 = !flag4;
		if (obj15 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_0193;
	}

	public ChallengesHistoryPanel()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Expected O, but got Unknown
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		object obj = typeof(List<AdaptivePerformanceScaler>) + 440;
		object obj2 = typeof(List<AdaptivePerformanceScaler>) + 432;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list = default(List<object>);
		list..ctor();
		object obj3 = this + 72;
		obj3 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list2 = default(List<object>);
		list2..ctor();
		object obj4 = this + 80;
		obj4 = list2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		base..ctor();
	}
}
