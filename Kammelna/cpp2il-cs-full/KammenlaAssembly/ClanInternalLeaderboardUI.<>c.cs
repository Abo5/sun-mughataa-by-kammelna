using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Threading;
using Cpp2ILInjected;
using HuaweiMobileServices.Location.Location;
using Kammelna.Server;
using Kammelna.Server.Models.Clans;
using Newtonsoft.Json.Linq.JsonPath;
using Server.Models;
using Sfs2X.Entities;
using TMPro;
using Unity.Properties;
using UnityEngine;

public class ClanInternalLeaderboardUI : MonoBehaviour
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Func<LeaderBoardPlayer, int> <>9__13_0;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(CardUtils.<>c) + 800;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal int <PopulateLeaderboard>b__13_0(LeaderBoardPlayer p)
		{
			//IL_0035: Expected I4, but got O
			if (p != null)
			{
				return p.LastPoints;
			}
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
		}
	}

	private TextMeshProUGUI descriptionLabel;

	private TextMeshProUGUI totalPointsLabel;

	private TopPlayersList leaderboard;

	private GameObject myPlaceItem;

	private int _clanTopXCount = 10;

	private ClanModel _clan;

	private void Awake()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_00a8: Expected I, but got O
		//IL_0063: Expected O, but got I4
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)1128;
		object obj3 = typeof(RegisteredWaitHandle) + 56;
		ApplyConfig();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v5+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		RemoteConfig.OnChanged += action;
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
		object obj2 = (nint)0 + (nint)1128;
		object obj3 = typeof(RegisteredWaitHandle) + 56;
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
		RemoteConfig.OnChanged -= action;
	}

	private unsafe void ApplyConfig()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00da: Expected O, but got I4
		//IL_0097: Expected O, but got I4
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Expected O, but got Unknown
		//IL_01db: Expected O, but got I4
		//IL_01e4: Expected O, but got I4
		//IL_0193: Expected O, but got I4
		//IL_0232: Unknown result type (might be due to invalid IL or missing references)
		//IL_0237: Expected O, but got Unknown
		//IL_0251: Expected O, but got I4
		//IL_02b2: Expected I, but got O
		//IL_0329: Unknown result type (might be due to invalid IL or missing references)
		//IL_032e: Expected O, but got Unknown
		//IL_034a: Unknown result type (might be due to invalid IL or missing references)
		//IL_034f: Expected O, but got Unknown
		object obj = typeof(RegisteredWaitHandle) + 56;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8691]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v30+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v30+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		RemoteConfigModel current = RemoteConfig.Current;
		if (current != null)
		{
			goto IL_011d;
		}
		goto IL_0398;
		IL_03b4:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		throw new OutOfMemoryException();
		IL_03a6:
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		goto IL_03b4;
		IL_0398:
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_03a6;
		IL_0074:
		current = RemoteConfig.Current;
		bool flag2 = current == null;
		object obj5 = !flag2;
		if (obj5 != null)
		{
			goto IL_011d;
		}
		goto IL_0398;
		IL_011d:
		object obj6 = typeof(MemberAchievementClanFeedData) + 2976;
		ClanConfigsResponse <Clans>k__BackingField = current.<Clans>k__BackingField;
		object obj7 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X0_v9+E4]");
		if ((nint)0 != 0)
		{
			bool flag3 = descriptionLabel == null;
			bool flag4 = !flag3;
			object obj8 = 0;
			if (!flag4)
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag5 = descriptionLabel == null;
			bool flag6 = !flag5;
			object obj9 = !flag6;
			object obj8 = 0;
			if (obj9 != null)
			{
				return;
			}
		}
		if (current.<Clans>k__BackingField == null)
		{
			return;
		}
		_clanTopXCount = <Clans>k__BackingField.InterClanTopXCount;
		object obj10 = typeof(TypeConverter<ushort, char>) + 3400;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		object obj11 = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object[] array = default(object[]);
		bool flag7 = array == null;
		int num2 = default(int);
		nint num = (nint)(&num2);
		if (flag7)
		{
			goto IL_0398;
		}
		object obj12 = default(object);
		bool flag8 = obj12 == null;
		nint num3 = (nint)(&num2);
		if (!flag8)
		{
			nint num4 = (nint)array;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X8_v20 (Il2CppClass<System.Object[]>)+40]");
			num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
			bool flag9 = ex == null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X8_v20 (Il2CppClass<System.Object[]>)+40]");
			num = 0;
			if (flag9)
			{
				goto IL_03b4;
			}
		}
		bool flag10 = array.Length == 0;
		num = num3;
		if (!flag10)
		{
			object obj13 = array + 32;
			obj13 = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object text = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 3712;
			TextMeshProExtensions.Localize(descriptionLabel, (string)text, array);
			if (_clan != null)
			{
				UpdateMyPlace();
				UpdateLeaderboard();
			}
			return;
		}
		goto IL_03a6;
	}

	public void Populate(ClanModel clan)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		object obj = this + 72;
		obj = clan;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		UpdateMyPlace();
		UpdateLeaderboard();
	}

	private void RefreshUI()
	{
		UpdateMyPlace();
		UpdateLeaderboard();
	}

	private void UpdateMyPlace()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_004f: Expected O, but got I4
		//IL_00ac: Expected O, but got I4
		ClanModel clan = _clan;
		object obj = typeof(Queue<string>) + 848;
		object obj2 = (nint)0 + (nint)2200;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel = default(SessionModel);
		User localUser = sessionModel.LocalUser;
		int clanId = SFSKammelnaUserExtensions.GetClanId(localUser);
		object obj5 = clan.ClanId - clanId;
		bool active = obj5 == null;
		myPlaceItem.SetActive(active);
	}

	private void UpdateLeaderboard()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected O, but got Unknown
		//IL_005a: Expected O, but got I
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		//IL_00a4: Expected I, but got O
		//IL_00d3: Expected O, but got I4
		ClanModel clan = _clan;
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 1152;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		ClanContributionLeaderboardSource clanContributionLeaderboardSource = default(ClanContributionLeaderboardSource);
		clanContributionLeaderboardSource..ctor(clan.ClanId);
		object obj2 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2536;
		object obj3 = (nint)0 + (nint)1136;
		object obj4 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1688;
		leaderboard.SetSource(clanContributionLeaderboardSource);
		GameObject lifecycle = base.gameObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj3);
		object obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X0_v11+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		LeaderBoardManager.GetLeaderBoard(lifecycle, clanContributionLeaderboardSource, action);
	}

	private void PopulateLeaderboard(LeaderboardModel leaderboardModel)
	{
		//IL_0011: Expected O, but got I
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected O, but got Unknown
		//IL_00f2: Expected O, but got I
		//IL_0102: Expected O, but got I
		//IL_0112: Expected O, but got I
		//IL_0134: Expected O, but got I4
		//IL_0076: Expected O, but got I
		//IL_0086: Expected O, but got I
		//IL_0096: Expected O, but got I
		//IL_00b8: Expected O, but got I4
		//IL_016c: Expected O, but got I4
		//IL_0202: Unknown result type (might be due to invalid IL or missing references)
		//IL_0207: Expected O, but got Unknown
		//IL_021d: Expected O, but got I
		//IL_022e: Expected I, but got O
		//IL_024c: Expected O, but got I
		//IL_019c: Expected O, but got I
		if (leaderboardModel == null)
		{
			return;
		}
		object obj = (nint)0 + (nint)856;
		object obj2 = typeof(CardUtils.<>c) + 800;
		IEnumerable<object> source = Enumerable.Take((IEnumerable<object>)leaderboardModel.<PlayersList>k__BackingField, _clanTopXCount);
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ X0_v9+E4]");
		object obj5;
		Func<object, int> selector;
		object obj7;
		object obj4;
		if ((nint)0 != 0)
		{
			obj4 = (nint)0 + (nint)728;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ X0_v9+B8]");
			obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ X8_v8+8]");
			selector = (Func<object, int>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ X8_v8+8]");
			bool flag = (nint)0 == 0;
			object obj6 = !flag;
			if (obj6 == null)
			{
				obj7 = obj4;
				goto IL_014a;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj3 = obj2;
			obj7 = (nint)0 + (nint)728;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ X0_v9+B8]");
			obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ X8_v8+8]");
			selector = (Func<object, int>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ X8_v8+8]");
			bool flag2 = (nint)0 == 0;
			object obj8 = !flag2;
			obj4 = obj7;
			if (obj8 == null)
			{
				goto IL_014a;
			}
		}
		goto IL_01a1;
		IL_01a1:
		int number = Enumerable.Sum(source, selector);
		TextMeshProExtensions.SetNumber(totalPointsLabel, number, useCommas: true);
		return;
		IL_014a:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ X0_v9+E4]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj10 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X8_v14+B8]");
			obj5 = 0;
		}
		object obj11 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2256;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj12 = (nint)0 + (nint)3808;
		Func<object, int> func = default(Func<object, int>);
		func..ctor(obj5, (IntPtr)obj12);
		object obj13 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X8_v13+B8]");
		object obj14 = (nint)0 + (nint)8;
		obj14 = func;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj4 = obj7;
		selector = func;
		goto IL_01a1;
	}
}
