using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Formats.Asn1;
using System.Linq;
using Cpp2ILInjected;
using DG.Tweening;
using DataTracking;
using HuaweiMobileServices.Location.Location;
using Kammelna.Server;
using Kammelna.Server.Models.Clans;
using Newtonsoft.Json.Linq.JsonPath;
using Server.Models;
using Sfs2X.Entities;
using Spine;
using TMPro;
using Unity.Services.Authentication.Shared;
using UnityEngine;
using UnityEngine.AdaptivePerformance;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.TextCore;
using Util;

public class TopPlayersList : MonoBehaviour
{
	private sealed class <>c__DisplayClass23_0
	{
		public int myId;

		internal bool <Initialize>b__1(LeaderBoardPlayer p)
		{
			//IL_005e: Expected I4, but got O
			//IL_0031: Expected O, but got I4
			if (p != null)
			{
				object obj = p.Id - myId;
				bool flag = obj == null;
				return !flag;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private sealed class <>c__DisplayClass31_0
	{
		public int rankTier;

		internal bool <UpdateTier>b__0(LeaderBoardPlayerHolder holder)
		{
			//IL_0043: Expected O, but got I4
			LeaderBoardPlayer <Player>k__BackingField = holder.<Player>k__BackingField;
			if (holder.<Player>k__BackingField != null)
			{
				object obj = <Player>k__BackingField.RankTier - rankTier;
				return obj == null;
			}
			return false;
		}
	}

	private GameObject loader;

	private TextMeshProUGUI pointsTitle;

	private LeaderBoardListView list;

	private TopPlaceItem[] topPlaceItems;

	private GameObject topPlaceSection;

	private GameObject lastUpdatedSection;

	private GameObject recentBombersSection;

	private TournamentWinnersSection tournamentWinnersSection;

	private InputFieldTMProUGUI filterInput;

	private NormalPlaceItem myPlaceItem;

	private bool removeMyPlaceFromList = true;

	private DateTimeText lastUpdated;

	private ILeaderboardSource _source;

	private LeaderboardModel _model;

	private bool _isRequesting;

	private bool HasMyPlaceItem
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_002a: Expected O, but got I
			//IL_00ca: Expected O, but got I4
			object obj = typeof(MemberAchievementClanFeedData) + 2976;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E62CB]");
			object obj2 = (nint)0 & (nint)1;
			UnityEngine.Object obj4;
			UnityEngine.Object obj5;
			if (obj2 != null)
			{
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v1+E4]");
				bool flag = (nint)0 == 0;
				obj4 = myPlaceItem;
				obj5 = myPlaceItem;
				if (!flag)
				{
					goto IL_0088;
				}
			}
			else
			{
				_ = 1;
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v1+E4]");
				bool flag2 = (nint)0 == 0;
				object obj6 = !flag2;
				obj4 = myPlaceItem;
				obj5 = myPlaceItem;
				if (obj6 != null)
				{
					goto IL_0088;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			return obj5;
			IL_0088:
			return obj4;
		}
	}

	private void Awake()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_03a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03aa: Expected O, but got Unknown
		//IL_03c3: Expected I, but got O
		//IL_03ed: Expected O, but got I4
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Expected O, but got Unknown
		//IL_00bd: Expected O, but got I4
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Expected O, but got Unknown
		//IL_00e7: Expected I, but got O
		//IL_00f7: Expected O, but got I
		//IL_02e9: Expected O, but got I4
		//IL_02f2: Expected O, but got I4
		//IL_025a: Expected O, but got I4
		//IL_018d: Expected O, but got I
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a5: Expected O, but got Unknown
		//IL_01bf: Expected O, but got I4
		//IL_01c8: Expected O, but got I4
		//IL_01d8: Expected O, but got I
		//IL_01e1: Expected O, but got I4
		//IL_0277: Unknown result type (might be due to invalid IL or missing references)
		//IL_027c: Expected O, but got Unknown
		//IL_0292: Expected O, but got I
		//IL_02a0: Expected I, but got O
		//IL_0132: Expected O, but got I
		//IL_030a: Unknown result type (might be due to invalid IL or missing references)
		//IL_030f: Expected O, but got Unknown
		//IL_0317: Unknown result type (might be due to invalid IL or missing references)
		//IL_031c: Expected O, but got Unknown
		//IL_0325: Unknown result type (might be due to invalid IL or missing references)
		//IL_032a: Expected O, but got Unknown
		//IL_033a: Expected O, but got I
		//IL_034d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0352: Expected O, but got Unknown
		//IL_036a: Expected O, but got I4
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Expected O, but got Unknown
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Expected O, but got Unknown
		//IL_0388: Expected O, but got I
		//IL_0391: Expected O, but got I4
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2416;
		object obj2 = (nint)0 + (nint)232;
		object obj3 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1528;
		object obj4 = typeof(List<AdaptivePerformanceScaler>) + 2096;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<int> action = default(Action<int>);
		action..ctor((object)this, (IntPtr)obj2);
		object obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		FriendsManager.OnUserBlocked += action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list = default(List<object>);
		list..ctor();
		object obj7 = typeof(MemberAchievementClanFeedData) + 2976;
		this.list.SetData((List<LeaderBoardPlayer>)(object)list);
		ILeaderboardSource source = _source;
		bool flag2 = _source == null;
		List<LeaderBoardPlayer> list2 = (List<LeaderBoardPlayer>)(object)list;
		object obj8 = 0;
		List<LeaderBoardPlayer> list3;
		object obj17;
		if (!flag2)
		{
			object obj9 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 3464;
			nint num = (nint)source;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ X8_v13 (Il2CppClass<ILeaderboardSource>)+12E]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ X8_v13 (Il2CppClass<ILeaderboardSource>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0173;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ X8_v13 (Il2CppClass<ILeaderboardSource>)+B0]");
			object obj11 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ X10_v7-8]");
				if (0 == (nint)obj9)
				{
					break;
				}
				obj11 += 16;
				obj10--;
				if ((nint)obj10 != 1)
				{
					continue;
				}
				goto IL_0173;
			}
			object obj12 = obj11 + 2;
			object obj13 = num + obj12;
			object obj14 = obj13 + 312;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v315 @ X0_v30+8]");
			list3 = (List<LeaderBoardPlayer>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v315 @ X0_v30] (should have been resolved before IL gen)");
			object obj16 = default(object);
			object obj15 = obj16 & 1;
			bool flag3 = obj15 == null;
			obj17 = 0;
			if (flag3)
			{
				goto IL_01ef;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v315 @ X0_v30+8]");
			list2 = (List<LeaderBoardPlayer>)0;
			obj8 = 0;
		}
		goto IL_020a;
		IL_020a:
		object obj18 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X8_v6+E4]");
		if ((nint)0 != 0)
		{
			bool flag4 = filterInput;
			bool flag5 = !flag4;
			object obj19 = 0;
			if (flag5)
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag6 = filterInput;
			bool flag7 = !flag6;
			object obj20 = !flag7;
			object obj19 = 0;
			if (obj20 == null)
			{
				return;
			}
		}
		object obj21 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3576;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj22 = (nint)0 + (nint)224;
		Action<object> action2 = default(Action<object>);
		action2..ctor((object)this, (IntPtr)obj22);
		filterInput.OnValueChanged += action2;
		return;
		IL_01ef:
		Initialize();
		list2 = list3;
		obj8 = obj17;
		goto IL_020a;
		IL_0173:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v288 @ X0_v27+8]");
		list3 = (List<LeaderBoardPlayer>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v288 @ X0_v27] (should have been resolved before IL gen)");
		object obj24 = default(object);
		object obj23 = obj24 & 1;
		bool flag8 = obj23 == null;
		object obj25 = !flag8;
		obj17 = 2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v288 @ X0_v27+8]");
		list2 = (List<LeaderBoardPlayer>)0;
		obj8 = 2;
		if (obj25 == null)
		{
			goto IL_01ef;
		}
		goto IL_020a;
	}

	private void OnEnable()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0052: Expected O, but got I4
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Expected O, but got Unknown
		//IL_008b: Expected I, but got O
		//IL_009b: Expected O, but got I
		//IL_00d6: Expected O, but got I
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_015f: Expected O, but got Unknown
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Expected O, but got Unknown
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		//IL_017a: Expected O, but got Unknown
		//IL_019f: Expected O, but got I4
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Expected O, but got Unknown
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Expected O, but got Unknown
		if (_source == null)
		{
			return;
		}
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		ITrackEvent trackEvent = TrackerLibrary.CommunityLeaderboardViewed(_source);
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X8_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Tracker.DesignEvent(trackEvent);
		ILeaderboardSource source = _source;
		object obj4 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 3464;
		nint num = (nint)source;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X8_v7 (Il2CppClass<ILeaderboardSource>)+12E]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X8_v7 (Il2CppClass<ILeaderboardSource>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0117;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X8_v7 (Il2CppClass<ILeaderboardSource>)+B0]");
		object obj6 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ X10_v7-8]");
			if (0 == (nint)obj4)
			{
				break;
			}
			obj6 += 16;
			obj5--;
			if ((nint)obj5 != 1)
			{
				continue;
			}
			goto IL_0117;
		}
		object obj7 = obj6 + 2;
		object obj8 = num + obj7;
		object obj9 = obj8 + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v224 @ X0_v15] (should have been resolved before IL gen)");
		object obj10 = default(object);
		bool flag2 = obj10 == null;
		object obj11 = !flag2;
		if (obj11 != null)
		{
			goto IL_014a;
		}
		goto IL_01ae;
		IL_014a:
		RequestLeaderboard();
		return;
		IL_01ae:
		if (_model != null)
		{
			Initialize();
		}
		return;
		IL_0117:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v193 @ X0_v12] (should have been resolved before IL gen)");
		object obj12 = default(object);
		if (obj12 != null)
		{
			goto IL_014a;
		}
		goto IL_01ae;
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
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2416;
		object obj2 = (nint)0 + (nint)232;
		object obj3 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1528;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<int> action = default(Action<int>);
		action..ctor((object)this, (IntPtr)obj2);
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		FriendsManager.OnUserBlocked -= action;
	}

	public void SetSource(ILeaderboardSource source)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0031: Expected O, but got I4
		object obj = this + 128;
		obj = source;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj2 = this + 136;
		obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		if (base.isActiveAndEnabled)
		{
			Initialize();
		}
		UpdateTitle();
	}

	private void UpdateTitle()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0021: Expected I, but got O
		//IL_0031: Expected O, but got I
		//IL_006c: Expected O, but got I
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Expected O, but got Unknown
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected O, but got Unknown
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected O, but got Unknown
		ILeaderboardSource source = _source;
		object obj = typeof(UnityEngine.TextCore.HorizontalAlignment) + 3464;
		nint num = (nint)source;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X8_v5 (Il2CppClass<ILeaderboardSource>)+12E]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X8_v5 (Il2CppClass<ILeaderboardSource>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_00ad;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X8_v5 (Il2CppClass<ILeaderboardSource>)+B0]");
		object obj3 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X10_v5-8]");
			if (0 == (nint)obj)
			{
				break;
			}
			obj3 += 16;
			obj2--;
			if ((nint)obj2 != 1)
			{
				continue;
			}
			goto IL_00ad;
		}
		object obj4 = obj3 + 1;
		object obj5 = num + obj4;
		object obj6 = obj5 + 312;
		goto IL_011d;
		IL_00ad:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_011d;
		IL_011d:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v157 @ X0_v3] (should have been resolved before IL gen)");
		string text = default(string);
		TextMeshProExtensions.Localize(pointsTitle, text);
	}

	private void FilterUpdated(string newVal)
	{
		Initialize();
	}

	private void Initialize()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_00d7: Expected O, but got I4
		//IL_007a: Expected O, but got I4
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Expected O, but got Unknown
		//IL_013a: Expected O, but got I4
		//IL_0cae: Expected O, but got I4
		//IL_0cb7: Expected O, but got I4
		//IL_0091: Expected O, but got I4
		//IL_03fd: Expected O, but got I4
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Expected O, but got Unknown
		//IL_0181: Expected O, but got I
		//IL_018f: Expected I, but got O
		//IL_01a0: Expected O, but got I
		//IL_01bd: Expected O, but got I
		//IL_0367: Expected O, but got I4
		//IL_036f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0374: Expected I4, but got Unknown
		//IL_0244: Unknown result type (might be due to invalid IL or missing references)
		//IL_0249: Expected O, but got Unknown
		//IL_0259: Expected I, but got O
		//IL_0282: Expected O, but got I4
		//IL_03b6: Expected O, but got I4
		//IL_07c1: Expected O, but got I4
		//IL_02b6: Expected O, but got I
		//IL_0c1d: Expected O, but got I4
		//IL_0681: Expected O, but got I4
		//IL_05f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f6: Expected O, but got Unknown
		//IL_0606: Expected I, but got O
		//IL_062f: Expected O, but got I4
		//IL_06e6: Expected O, but got I4
		//IL_0977: Expected O, but got I
		//IL_0987: Unknown result type (might be due to invalid IL or missing references)
		//IL_098c: Expected O, but got Unknown
		//IL_09de: Expected O, but got I4
		//IL_04a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ab: Expected O, but got Unknown
		//IL_0922: Expected O, but got I4
		//IL_0510: Expected O, but got I
		//IL_0b03: Expected O, but got I4
		//IL_0771: Expected O, but got I4
		//IL_077a: Expected O, but got I4
		//IL_0892: Unknown result type (might be due to invalid IL or missing references)
		//IL_0897: Expected O, but got Unknown
		//IL_08a7: Expected I, but got O
		//IL_08d0: Expected O, but got I4
		//IL_0a32: Expected O, but got I
		//IL_0a42: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a47: Expected O, but got Unknown
		//IL_0a99: Expected O, but got I4
		//IL_04fa: Expected O, but got I
		//IL_0b42: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b47: Expected O, but got Unknown
		//IL_0b8e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b93: Expected O, but got Unknown
		//IL_0ba9: Expected O, but got I
		//IL_0bba: Expected I, but got O
		object obj;
		List<LeaderBoardPlayer> topPlayers;
		List<LeaderBoardPlayer> list;
		object obj4;
		if (_model != null)
		{
			obj = typeof(MemberAchievementClanFeedData) + 2976;
			topPlayers = _model.GetTopPlayers();
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X8_v3+E4]");
			if ((nint)0 != 0)
			{
				bool flag = filterInput;
				bool flag2 = !flag;
				object obj3 = !flag2;
				if (obj3 != null)
				{
					goto IL_00ed;
				}
				obj4 = 0;
				list = topPlayers;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				bool flag3 = filterInput;
				bool flag4 = !flag3;
				obj4 = 0;
				list = topPlayers;
				if (!flag4)
				{
					goto IL_00ed;
				}
			}
			goto IL_0c5a;
		}
		RequestLeaderboard();
		return;
		IL_074e:
		UnityEngine.Object obj5;
		bool flag5 = obj5;
		bool flag6 = !flag5;
		object obj6 = !flag6;
		object obj7 = 0;
		if (obj6 != null)
		{
			goto IL_0b11;
		}
		goto IL_0bf1;
		IL_0705:
		object obj8 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v749 @ X0_v24+E4]");
		bool flag7 = (nint)0 == 0;
		obj5 = myPlaceItem;
		bool flag9;
		bool flag8 = flag9;
		UnityEngine.Object obj9 = myPlaceItem;
		if (!flag7)
		{
			goto IL_074e;
		}
		goto IL_0acb;
		IL_0434:
		TopPlaceItem[] array;
		if (list != null)
		{
			int num = 0;
			while (num < array.Length)
			{
				object obj10 = array + num;
				if (num < list._size)
				{
					object player = ((List<object>)(object)list).get_Item(num);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v375 @ X8_v44+20]");
					((TopPlaceItem)0).Populate((LeaderBoardPlayer)player);
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v375 @ X8_v44+20]");
					GameObject gameObject = ((UnityEngine.Component)0).gameObject;
					gameObject.SetActive(value: false);
				}
				num++;
				array = topPlaceItems;
			}
		}
		else if (array.Length > 0)
		{
			goto IL_0c34;
		}
		goto IL_054b;
		IL_0381:
		bool active;
		topPlaceSection.SetActive(active);
		array = topPlaceItems;
		bool flag10 = topPlaceItems == null;
		object obj11 = !flag10;
		if (obj11 != null)
		{
			goto IL_0434;
		}
		goto IL_054b;
		IL_00ed:
		string text = filterInput.Text;
		object obj12 = typeof(System.Formats.Asn1.SetOfValueComparer) + 2536;
		object obj13 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ X8_v57+E4]");
		bool flag11 = (nint)0 == 0;
		object obj14 = !flag11;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag12 = StringsExtensions.IsNullOrEmpty(text);
		bool flag13 = !flag12;
		object obj15 = !flag13;
		obj4 = 0;
		list = topPlayers;
		if (obj15 == null)
		{
			object obj16 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2248;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj17 = (nint)0 + (nint)216;
			Func<object, bool> func = default(Func<object, bool>);
			func..ctor((object)this, (IntPtr)obj17);
			object obj18 = (nint)0 + (nint)3576;
			IEnumerable<object> source = Enumerable.Where(topPlayers, func);
			object obj19 = (nint)0 + (nint)2328;
			obj4 = obj19;
			List<object> list2 = Enumerable.ToList(source);
			list = (List<LeaderBoardPlayer>)(object)list2;
		}
		goto IL_0c5a;
		IL_085a:
		ILeaderboardSource source2 = _source;
		bool flag17;
		if (_source != null)
		{
			object obj20 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 3152;
			object obj21 = obj20;
			nint num2 = (nint)source2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v756 @ X9_v11 (Il2CppClass<ILeaderboardSource>)+130]");
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v755 @ X8_v27+130]");
			bool flag14 = num3 < 0;
			object obj22 = !flag14;
			if (obj22 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v756 @ X9_v11 (Il2CppClass<ILeaderboardSource>)+C8]");
				nint num4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v755 @ X8_v27+130]");
				object obj23 = num4 + 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v773 @ X9_v13-8]");
				object obj24 = 0 - obj21;
				bool flag15 = obj24 == null;
				recentBombersSection.SetActive(flag15);
				obj5 = myPlaceItem;
				obj8 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v749 @ X0_v24+E4]");
				bool flag16 = (nint)0 == 0;
				object obj25 = !flag16;
				flag9 = false;
				flag8 = false;
				obj9 = myPlaceItem;
				flag17 = flag15;
				if (obj25 != null)
				{
					goto IL_074e;
				}
				goto IL_0acb;
			}
		}
		recentBombersSection.SetActive(value: false);
		obj5 = myPlaceItem;
		obj8 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v749 @ X0_v24+E4]");
		bool flag18 = (nint)0 == 0;
		object obj26 = !flag18;
		flag9 = false;
		if (obj26 != null)
		{
			goto IL_074e;
		}
		flag8 = false;
		obj9 = myPlaceItem;
		flag17 = false;
		goto IL_0acb;
		IL_0c34:
		throw new NullReferenceException();
		IL_06b4:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		UnityEngine.Object obj27;
		bool flag19 = obj27;
		bool flag20 = !flag19;
		object obj28 = !flag20;
		bool flag21;
		flag9 = flag21;
		flag17 = false;
		if (obj28 == null)
		{
			goto IL_0705;
		}
		goto IL_085a;
		IL_05b9:
		ILeaderboardSource source3 = _source;
		UnityEngine.Object obj34;
		bool flag25;
		object obj35;
		if (_source != null)
		{
			object obj29 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1496;
			object obj30 = obj29;
			nint num5 = (nint)source3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v631 @ X9_v21 (Il2CppClass<ILeaderboardSource>)+130]");
			nint num6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v630 @ X8_v39+130]");
			bool flag22 = num6 < 0;
			object obj31 = !flag22;
			if (obj31 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v631 @ X9_v21 (Il2CppClass<ILeaderboardSource>)+C8]");
				nint num7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v630 @ X8_v39+130]");
				object obj32 = num7 + 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v649 @ X9_v23-8]");
				object obj33 = 0 - obj30;
				bool flag23 = obj33 == null;
				lastUpdatedSection.SetActive(flag23);
				obj34 = recentBombersSection;
				obj35 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v622 @ X0_v45+E4]");
				bool flag24 = (nint)0 == 0;
				object obj36 = !flag24;
				flag9 = false;
				if (obj36 == null)
				{
					flag21 = false;
					obj27 = recentBombersSection;
					flag25 = flag23;
					goto IL_06b4;
				}
				goto IL_082b;
			}
		}
		lastUpdatedSection.SetActive(value: false);
		obj27 = recentBombersSection;
		obj35 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v622 @ X0_v45+E4]");
		bool flag26 = (nint)0 == 0;
		object obj37 = !flag26;
		flag21 = false;
		flag25 = false;
		flag9 = false;
		obj34 = recentBombersSection;
		if (obj37 == null)
		{
			goto IL_06b4;
		}
		goto IL_082b;
		IL_0c5a:
		object obj38 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ X8_v5+E4]");
		if ((nint)0 != 0)
		{
			if ((bool)topPlaceSection)
			{
				goto IL_020c;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag27 = topPlaceSection;
			bool flag28 = !flag27;
			object obj39 = !flag28;
			if (obj39 != null)
			{
				goto IL_020c;
			}
		}
		array = topPlaceItems;
		if (topPlaceItems != null)
		{
			goto IL_0434;
		}
		goto IL_054b;
		IL_0acb:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag29 = obj9;
		bool flag30 = !flag29;
		flag9 = flag8;
		obj7 = 0;
		if (!flag30)
		{
			goto IL_0b11;
		}
		goto IL_0bf1;
		IL_0b11:
		if (removeMyPlaceFromList)
		{
			object obj40 = typeof(SkeletonBinary.SkeletonInput) + 3352;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj41 = default(object);
			obj41..ctor();
			User mySelf = SFS.MySelf;
			int intDbId = SFSKammelnaUserExtensions.GetIntDbId(mySelf);
			object obj42 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2248;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj43 = (nint)0 + (nint)3568;
			Func<object, bool> func2 = default(Func<object, bool>);
			func2..ctor(obj41, (IntPtr)obj43);
			IEnumerable<object> source4 = Enumerable.Where(list, func2);
			List<object> list3 = Enumerable.ToList(source4);
			list = (List<LeaderBoardPlayer>)(object)list3;
		}
		goto IL_0bf1;
		IL_0bf1:
		this.list.SetData(list);
		return;
		IL_020c:
		ILeaderboardSource source5 = _source;
		if (_source != null)
		{
			object obj44 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1496;
			object obj45 = obj44;
			nint num8 = (nint)source5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v427 @ X9_v32 (Il2CppClass<ILeaderboardSource>)+130]");
			nint num9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v371 @ X8_v53+130]");
			bool flag31 = num9 < 0;
			object obj46 = !flag31;
			object obj47 = ~obj46;
			if (obj47 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v427 @ X9_v32 (Il2CppClass<ILeaderboardSource>)+C8]");
				nint num10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v371 @ X8_v53+130]");
				object obj48 = num10 + 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v494 @ X9_v34-8]");
				if (0 == (nint)obj45)
				{
					bool flag32 = (object)topPlaceSection == null;
					object obj49 = !flag32;
					active = false;
					if (obj49 != null)
					{
						goto IL_0381;
					}
					goto IL_0c34;
				}
			}
		}
		List<LeaderBoardPlayer> topPlayers2 = _model.GetTopPlayers();
		bool flag33 = topPlayers2._size < 0;
		bool flag34 = topPlayers2._size == 0;
		int num11 = topPlayers2._size ^ topPlayers2._size;
		int num12 = topPlayers2._size & num11;
		bool flag35 = num12 < 0;
		bool flag36 = flag33 == flag35;
		object obj50 = !flag34;
		bool flag37 = (byte)((flag36 & obj50) ? 1 : 0) != 0;
		active = flag37;
		goto IL_0381;
		IL_054b:
		PopulateMonthlyWinners(0, animate: false);
		object obj51 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v500 @ X0_v10+E4]");
		if ((nint)0 != 0)
		{
			bool flag38 = lastUpdatedSection;
			bool flag39 = !flag38;
			flag25 = false;
			if (!flag39)
			{
				goto IL_05b9;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag40 = lastUpdatedSection;
			bool flag41 = !flag40;
			object obj52 = !flag41;
			flag25 = false;
			if (obj52 != null)
			{
				goto IL_05b9;
			}
		}
		obj35 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v622 @ X0_v45+E4]");
		bool flag42 = (nint)0 == 0;
		flag21 = false;
		obj27 = recentBombersSection;
		flag9 = false;
		obj34 = recentBombersSection;
		if (flag42)
		{
			goto IL_06b4;
		}
		goto IL_082b;
		IL_082b:
		bool flag43 = obj34;
		bool flag44 = !flag43;
		flag17 = false;
		if (flag44)
		{
			goto IL_0705;
		}
		goto IL_085a;
	}

	private void OnUserBlocked(int _)
	{
		//IL_002b: Expected I, but got O
		//IL_003b: Expected O, but got I
		//IL_00b0: Expected O, but got I
		//IL_01e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e5: Expected O, but got Unknown
		//IL_0237: Expected O, but got I4
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Expected O, but got Unknown
		//IL_0183: Expected O, but got I
		//IL_01a3: Expected O, but got I4
		//IL_0165: Expected O, but got I
		if (_model == null)
		{
			return;
		}
		LeaderBoardListView leaderBoardListView = list;
		List<LeaderBoardPlayerHolder> data = list.data;
		nint num = (nint)leaderBoardListView;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ X8_v7 (Il2CppClass<LeaderBoardListView>)+2B0]");
		object obj = 0;
		list.data = data;
		List<LeaderBoardPlayer> topPlayers = _model.GetTopPlayers();
		TopPlaceItem[] array = topPlaceItems;
		if (topPlaceItems == null)
		{
			return;
		}
		if (topPlayers != null)
		{
			object obj2 = (nint)0 + (nint)3112;
			int num2 = 0;
			LeaderBoardPlayer leaderBoardPlayer = null;
			while (num2 < array.Length)
			{
				object obj3 = array + num2;
				if (num2 < topPlayers._size)
				{
					obj = obj2;
					object obj4 = ((List<object>)(object)topPlayers).get_Item(num2);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ X8_v16+20]");
					((TopPlaceItem)0).Populate((LeaderBoardPlayer)obj4);
					leaderBoardPlayer = (LeaderBoardPlayer)obj4;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ X8_v16+20]");
					GameObject gameObject = ((UnityEngine.Component)0).gameObject;
					gameObject.SetActive(value: false);
					obj = 0;
					leaderBoardPlayer = null;
				}
				num2++;
				array = topPlaceItems;
			}
		}
		else
		{
			bool flag = array.Length > 0;
			LeaderBoardPlayer leaderBoardPlayer = null;
			if (flag)
			{
				throw new NullReferenceException();
			}
		}
		object obj5 = typeof(MemberAchievementClanFeedData) + 2976;
		object obj6 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X8_v12+E4]");
		if ((nint)0 != 0)
		{
			bool flag2 = this.tournamentWinnersSection;
			bool flag3 = !flag2;
			object obj7 = !flag3;
			if (obj7 == null)
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			if (!this.tournamentWinnersSection)
			{
				return;
			}
		}
		GameObject gameObject2 = this.tournamentWinnersSection.gameObject;
		if (gameObject2.activeSelf)
		{
			LeaderboardModel model = _model;
			TournamentWinnersSection tournamentWinnersSection = this.tournamentWinnersSection;
			this.tournamentWinnersSection.Populate(model.<MonthlyWinners>k__BackingField, tournamentWinnersSection.lastTier, animate: false);
		}
	}

	private void RequestLeaderboard()
	{
		//IL_02ea: Expected O, but got I4
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_005e: Expected O, but got I
		//IL_006c: Expected I, but got O
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected O, but got Unknown
		//IL_00af: Expected O, but got I4
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Expected O, but got Unknown
		//IL_0288: Expected O, but got I4
		//IL_0291: Expected O, but got I4
		//IL_0143: Expected O, but got I4
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Expected O, but got Unknown
		//IL_0185: Expected O, but got I
		//IL_0198: Expected I, but got O
		//IL_01ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b1: Expected O, but got Unknown
		//IL_01b9: Expected I, but got O
		//IL_01c9: Expected O, but got I
		//IL_0334: Expected O, but got I
		//IL_0204: Expected O, but got I
		//IL_02a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ae: Expected O, but got Unknown
		//IL_02b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bb: Expected O, but got Unknown
		//IL_02c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c9: Expected O, but got Unknown
		//IL_0212: Unknown result type (might be due to invalid IL or missing references)
		//IL_0217: Expected O, but got Unknown
		//IL_0220: Unknown result type (might be due to invalid IL or missing references)
		//IL_0225: Expected O, but got Unknown
		bool flag = !_isRequesting;
		object obj = !flag;
		if (obj != null)
		{
			return;
		}
		_isRequesting = true;
		loader.SetActive(value: true);
		GameObject lifecycle = base.gameObject;
		object obj2 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2536;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj3 = (nint)0 + (nint)240;
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj3);
		object obj4 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1688;
		object obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ X0_v10+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		LeaderBoardManager.GetLeaderBoard(lifecycle, _source, action);
		object obj7 = typeof(MemberAchievementClanFeedData) + 2976;
		object obj8 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X8_v16+E4]");
		if ((nint)0 != 0)
		{
			bool flag3 = myPlaceItem;
			bool flag4 = !flag3;
			object obj9 = 0;
			if (flag4)
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag5 = myPlaceItem;
			bool flag6 = !flag5;
			object obj10 = !flag6;
			object obj9 = 0;
			if (obj10 == null)
			{
				return;
			}
		}
		ILeaderboardSource source = _source;
		object obj11 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2528;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj12 = (nint)0 + (nint)3376;
		Action<object> action2 = default(Action<object>);
		action2..ctor((object)myPlaceItem, (IntPtr)obj12);
		object obj13 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 3464;
		nint num = (nint)source;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ X8_v23 (Il2CppClass<ILeaderboardSource>)+12E]");
		object obj14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ X8_v23 (Il2CppClass<ILeaderboardSource>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0245;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ X8_v23 (Il2CppClass<ILeaderboardSource>)+B0]");
		object obj15 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v262 @ X10_v5-8]");
			if (0 == (nint)obj13)
			{
				break;
			}
			obj15 += 16;
			obj14--;
			if ((nint)obj14 != 1)
			{
				continue;
			}
			goto IL_0245;
		}
		object obj16 = obj15 + 5;
		object obj17 = num + obj16;
		object obj18 = obj17 + 312;
		goto IL_031c;
		IL_031c:
		object obj19 = obj18;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v279 @ X0_v21+8]");
		object obj20 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v148 @ X3_v6 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
		IL_0245:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_031c;
	}

	private unsafe void Populate(LeaderboardModel leaderboardModel)
	{
		//IL_0270: Unknown result type (might be due to invalid IL or missing references)
		//IL_0275: Expected O, but got Unknown
		//IL_029f: Expected O, but got I4
		//IL_02c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cb: Expected O, but got Unknown
		//IL_005b: Expected O, but got Ref
		//IL_01b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b8: Expected O, but got Unknown
		//IL_01ed: Expected O, but got I4
		//IL_01fe: Expected O, but got I4
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Expected O, but got Unknown
		//IL_00a7: Expected O, but got I4
		//IL_0457: Expected O, but got I4
		//IL_0470: Expected O, but got I4
		//IL_023e: Expected O, but got I4
		//IL_00cd: Expected F8, but got I8
		//IL_00da: Expected O, but got I4
		//IL_00f0: Expected O, but got I
		//IL_062e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0633: Expected O, but got Unknown
		//IL_0487: Expected O, but got I4
		//IL_0496: Unknown result type (might be due to invalid IL or missing references)
		//IL_049b: Expected O, but got Unknown
		//IL_04b1: Expected O, but got I
		//IL_02eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f0: Expected O, but got Unknown
		//IL_031a: Expected O, but got I4
		//IL_0585: Expected O, but got I4
		//IL_0185: Expected O, but got I4
		//IL_018d: Expected F8, but got I8
		//IL_0196: Expected O, but got I4
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Expected O, but got Unknown
		//IL_0532: Expected O, but got I4
		//IL_03a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a5: Expected O, but got Unknown
		//IL_03dc: Expected O, but got I4
		//IL_03e4: Expected F8, but got I8
		//IL_03ed: Expected O, but got I4
		//IL_03f5: Expected F8, but got I8
		//IL_03fe: Expected O, but got I4
		//IL_036b: Expected F8, but got I8
		//IL_0374: Expected O, but got I4
		//IL_0623: Expected O, but got I4
		//IL_06c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_06cc: Expected O, but got Unknown
		//IL_06f6: Expected O, but got I4
		//IL_071d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0722: Expected O, but got Unknown
		_isRequesting = false;
		loader.SetActive(value: false);
		long result;
		DateTime dateTime2;
		UnityEngine.Object obj8;
		double num = default(double);
		DateTime dateTime;
		if (leaderboardModel != null)
		{
			bool flag = long.TryParse(leaderboardModel.<ETag>k__BackingField, out result);
			bool flag2 = !flag;
			dateTime = (DateTime)(&result);
			if (!flag2)
			{
				object obj = typeof(DataRelation) + 824;
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ X0_v47+E4]");
				bool flag3 = (nint)0 == 0;
				object obj3 = !flag3;
				if (obj3 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				dateTime2 = DateTimeUtil.FromTimeStamp(result);
				object obj4 = 152985600;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E63B0]");
				object obj5 = (nint)0 & (nint)1;
				UnityEngine.Object obj9;
				if (obj5 != null)
				{
					object obj6 = typeof(MemberAchievementClanFeedData) + 2976;
					object obj7 = obj6;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v267 @ X0_v54+E4]");
					bool flag4 = (nint)0 == 0;
					obj8 = lastUpdated;
					obj9 = lastUpdated;
					if (!flag4)
					{
						goto IL_0162;
					}
				}
				else
				{
					_ = 1;
					object obj10 = typeof(MemberAchievementClanFeedData) + 2976;
					object obj7 = obj10;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v267 @ X0_v54+E4]");
					bool flag5 = (nint)0 == 0;
					object obj11 = !flag5;
					obj8 = lastUpdated;
					obj9 = lastUpdated;
					if (obj11 != null)
					{
						goto IL_0162;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				bool flag6 = obj9;
				bool flag7 = !flag6;
				num = result;
				dateTime = (DateTime)0;
				if (!flag7)
				{
					goto IL_0382;
				}
			}
			goto IL_01a4;
		}
		object obj12 = typeof(System.Buffers.Text.ParserHelpers) + 1432;
		object obj13 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ X0_v5+E4]");
		bool flag8 = (nint)0 == 0;
		object obj14 = !flag8;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object message = "Index = {0} position = {1}" + 1736;
		PopupWindow.ShowError((string)message);
		return;
		IL_0162:
		bool flag9 = obj8;
		bool flag10 = !flag9;
		object obj15 = !flag10;
		num = result;
		dateTime = (DateTime)0;
		if (obj15 == null)
		{
			goto IL_01a4;
		}
		goto IL_0382;
		IL_0628:
		object obj16 = this + 136;
		obj16 = leaderboardModel;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		GameObject gameObject = base.gameObject;
		if (!gameObject.activeSelf)
		{
			return;
		}
		object obj17 = obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X8_v11+18]");
		if ((nint)0 != 0)
		{
			Initialize();
			return;
		}
		object obj18 = typeof(System.Buffers.Text.ParserHelpers) + 1432;
		object obj19 = obj18;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v332 @ X0_v18+E4]");
		bool flag11 = (nint)0 == 0;
		object obj20 = !flag11;
		if (obj20 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object message2 = "Index = {0} position = {1}" + 1736;
		PopupWindow.ShowError((string)message2);
		return;
		IL_050f:
		UnityEngine.Object obj21;
		bool flag12 = obj21;
		bool flag13 = !flag12;
		object obj22 = !flag13;
		if (obj22 != null)
		{
			goto IL_05ec;
		}
		double num2 = num;
		object obj24;
		object obj23 = obj24;
		goto IL_0628;
		IL_0219:
		string <Title>k__BackingField;
		bool flag14 = StringsExtensions.IsNullOrEmpty(<Title>k__BackingField);
		bool flag15 = !flag14;
		object obj25 = 0;
		if (flag15)
		{
			goto IL_047e;
		}
		num2 = num;
		obj23 = obj24;
		goto IL_0628;
		IL_0382:
		lastUpdated.SetDate(dateTime2);
		object obj26 = typeof(System.Formats.Asn1.SetOfValueComparer) + 2536;
		<Title>k__BackingField = leaderboardModel.<Title>k__BackingField;
		object obj27 = obj26;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v223 @ X0_v38+E4]");
		bool flag16 = (nint)0 == 0;
		object obj28 = !flag16;
		num = result;
		obj24 = 0;
		num2 = result;
		obj23 = 0;
		dateTime = dateTime2;
		string <Title>k__BackingField2 = leaderboardModel.<Title>k__BackingField;
		if (obj28 != null)
		{
			goto IL_0219;
		}
		goto IL_0421;
		IL_0421:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag17 = StringsExtensions.IsNullOrEmpty(<Title>k__BackingField2);
		bool flag18 = !flag17;
		object obj29 = !flag18;
		num = num2;
		obj24 = obj23;
		obj25 = 0;
		if (obj29 == null)
		{
			goto IL_047e;
		}
		goto IL_0628;
		IL_01a4:
		object obj30 = typeof(System.Formats.Asn1.SetOfValueComparer) + 2536;
		<Title>k__BackingField = leaderboardModel.<Title>k__BackingField;
		obj27 = obj30;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v223 @ X0_v38+E4]");
		bool flag19 = (nint)0 == 0;
		obj24 = 0;
		num2 = num;
		obj23 = 0;
		<Title>k__BackingField2 = leaderboardModel.<Title>k__BackingField;
		if (!flag19)
		{
			goto IL_0219;
		}
		goto IL_0421;
		IL_05ec:
		TournamentWinnersSection tournamentWinnersSection = this.tournamentWinnersSection;
		TextMeshProExtensions.FixArabic(tournamentWinnersSection.titleText, leaderboardModel.<Title>k__BackingField);
		num2 = num;
		obj23 = 0;
		goto IL_0628;
		IL_047e:
		object obj31 = 152985600;
		object obj32 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E63AF]");
		object obj33 = (nint)0 & (nint)1;
		UnityEngine.Object obj35;
		if (obj33 != null)
		{
			object obj34 = obj32;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v312 @ X0_v26+E4]");
			bool flag20 = (nint)0 == 0;
			obj21 = this.tournamentWinnersSection;
			obj35 = this.tournamentWinnersSection;
			if (!flag20)
			{
				goto IL_050f;
			}
		}
		else
		{
			_ = 1;
			object obj34 = obj32;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v312 @ X0_v26+E4]");
			bool flag21 = (nint)0 == 0;
			object obj36 = !flag21;
			obj21 = this.tournamentWinnersSection;
			obj35 = this.tournamentWinnersSection;
			if (obj36 != null)
			{
				goto IL_050f;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag22 = obj35;
		bool flag23 = !flag22;
		num2 = num;
		obj23 = obj24;
		if (!flag23)
		{
			goto IL_05ec;
		}
		goto IL_0628;
	}

	private void ShowLoadingMessage()
	{
		loader.SetActive(value: true);
	}

	private void HideLoadingMessage()
	{
		loader.SetActive(value: false);
	}

	private void PopulateMonthlyTournamentName(string title)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0109: Expected O, but got I4
		//IL_015d: Expected O, but got I4
		object obj = 152985600;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E63AF]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj6;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			obj5 = this.tournamentWinnersSection;
			obj6 = this.tournamentWinnersSection;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v2+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj5 = this.tournamentWinnersSection;
			obj6 = this.tournamentWinnersSection;
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
		TournamentWinnersSection tournamentWinnersSection = this.tournamentWinnersSection;
		TextMeshProExtensions.FixArabic(tournamentWinnersSection.titleText, title);
		return;
		IL_0091:
		if ((bool)obj5)
		{
			goto IL_00b7;
		}
	}

	private void PopulateLastUpdated(DateTime date)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00f7: Expected O, but got I4
		//IL_014b: Expected O, but got I4
		object obj = 152985600;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E63B0]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj6;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			obj5 = lastUpdated;
			obj6 = lastUpdated;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v2+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj5 = lastUpdated;
			obj6 = lastUpdated;
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
		lastUpdated.SetDate(date);
		return;
		IL_0091:
		if ((bool)obj5)
		{
			goto IL_00b7;
		}
	}

	public void UpdateTier(int tier)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0027: Expected O, but got I4
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected O, but got Unknown
		//IL_005b: Expected O, but got I
		//IL_0063: Expected I, but got O
		//IL_008b: Expected I, but got O
		//IL_00b4: Expected I4, but got I8
		//IL_00ce: Expected O, but got I4
		object obj = typeof(SkeletonBinary.SkeletonInput) + 3360;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		PopulateMonthlyWinners(tier, animate: true);
		object obj3 = tier + 1;
		LeaderBoardListView leaderBoardListView = list;
		object obj4 = typeof(List<Tween>) + 3312;
		object obj5 = (nint)0 + (nint)3576;
		nint num = (nint)leaderBoardListView;
		List<LeaderBoardPlayerHolder> data = leaderBoardListView.data;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Predicate<LeaderBoardPlayerHolder> predicate = default(Predicate<LeaderBoardPlayerHolder>);
		predicate..ctor(obj2, (IntPtr)obj5);
		int num2 = data.FindIndex(predicate);
		int num3 = (int)(num2 & 0x80000000L);
		bool flag = num3 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			((UiListView<LeaderBoardPlayerHolder, object>)(object)list).AnimateScrollTo(num2, 0.6f, (Action)null);
		}
	}

	private void PopulateMonthlyWinners(int tier, bool animate)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_006b: Expected O, but got I4
		LeaderboardModel model = _model;
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v4+E4]");
		if ((nint)0 != 0)
		{
			bool flag = tournamentWinnersSection;
			bool flag2 = !flag;
			object obj3 = !flag2;
			if (obj3 == null)
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			if (!tournamentWinnersSection)
			{
				return;
			}
		}
		if (!ArraysExtensions.IsNullOrEmpty((IEnumerable<object>)model.<MonthlyWinners>k__BackingField))
		{
			GameObject gameObject = tournamentWinnersSection.gameObject;
			gameObject.SetActive(value: true);
			tournamentWinnersSection.Populate(model.<MonthlyWinners>k__BackingField, tier, animate);
		}
	}

	private bool <Initialize>b__23_0(LeaderBoardPlayer p)
	{
		//IL_00b7: Expected I4, but got O
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected O, but got Unknown
		//IL_0071: Expected O, but got I4
		if (p != null && (object)filterInput != null)
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
			return StringsExtensions.ContainsIgnoreCase(p.Login, text);
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}
}
