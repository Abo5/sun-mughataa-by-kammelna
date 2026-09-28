using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Data;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using Newtonsoft.Json.Linq.JsonPath;
using UnityEngine;
using UnityEngine.AdaptivePerformance;
using UnityEngine.Purchasing.Telemetry;
using Util;

public class TournamentViewMockConnector : TournamentViewConnector
{
	public override void Init()
	{
		ReadyState.IsReady = true;
	}

	public override TournamentData GetTournamentData()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Expected O, but got Unknown
		//IL_011b: Expected O, but got I4
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected O, but got Unknown
		//IL_0057: Expected O, but got I
		//IL_00bb: Expected O, but got I4
		object obj = typeof(DataRelation) + 712;
		object obj2 = typeof(DataRelation) + 824;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj5 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1504;
		object obj6 = "{0} color encoding is currently unsupported for outputting to HDR." + 2352;
		object imageLink = (nint)0 + (nint)2000;
		DateTime now = DateTime.Now;
		DateTime dateTime2 = default(DateTime);
		DateTime dateTime = dateTime2.AddHours(2.0000000002328306);
		DateTime dateTime3 = dateTime2.AddMinutes(8.000000001396984);
		object obj7 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X8_v4+E4]");
		bool flag2 = (nint)0 == 0;
		object obj8 = !flag2;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		long timeToStartStamp = DateTimeUtil.ToUniversalTimestamp(dateTime3);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TournamentData tournamentData = default(TournamentData);
		tournamentData..ctor(1, (string)obj6, 1, 16, 5000, 2500, 1250, timeToStartStamp, (string)imageLink);
		return tournamentData;
	}

	public override List<MatchData> GetMatches()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_0872: Unknown result type (might be due to invalid IL or missing references)
		//IL_0877: Expected O, but got Unknown
		//IL_0883: Expected O, but got I
		//IL_088d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0892: Expected O, but got Unknown
		//IL_089c: Unknown result type (might be due to invalid IL or missing references)
		//IL_08a1: Expected O, but got Unknown
		//IL_08ad: Expected O, but got I
		//IL_08d1: Expected O, but got I4
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Expected O, but got Unknown
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Expected O, but got Unknown
		//IL_00f4: Expected O, but got I
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Expected O, but got Unknown
		//IL_01ce: Expected O, but got I4
		//IL_0250: Expected O, but got I
		//IL_0260: Expected O, but got I
		//IL_0270: Expected O, but got I
		//IL_029e: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a3: Expected O, but got Unknown
		//IL_020e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0213: Expected O, but got Unknown
		//IL_021c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0221: Expected O, but got Unknown
		//IL_0339: Expected O, but got I4
		//IL_03bb: Expected O, but got I
		//IL_03cb: Expected O, but got I
		//IL_03db: Expected O, but got I
		//IL_0379: Unknown result type (might be due to invalid IL or missing references)
		//IL_037e: Expected O, but got Unknown
		//IL_0387: Unknown result type (might be due to invalid IL or missing references)
		//IL_038c: Expected O, but got Unknown
		//IL_0495: Expected O, but got I4
		//IL_0517: Expected O, but got I
		//IL_0527: Expected O, but got I
		//IL_0537: Expected O, but got I
		//IL_04d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04da: Expected O, but got Unknown
		//IL_04e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e8: Expected O, but got Unknown
		//IL_05f1: Expected O, but got I4
		//IL_066b: Expected O, but got I
		//IL_067b: Expected O, but got I
		//IL_068b: Expected O, but got I
		//IL_0631: Unknown result type (might be due to invalid IL or missing references)
		//IL_0636: Expected O, but got Unknown
		//IL_063f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0644: Expected O, but got Unknown
		//IL_06c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c8: Expected O, but got Unknown
		//IL_07a3: Expected O, but got I4
		//IL_0035: Expected O, but got I
		//IL_0045: Expected O, but got I
		//IL_0055: Expected O, but got I
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected O, but got Unknown
		//IL_0088: Expected O, but got I4
		//IL_07e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e8: Expected O, but got Unknown
		//IL_07f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f6: Expected O, but got Unknown
		//IL_0811: Unknown result type (might be due to invalid IL or missing references)
		//IL_0816: Expected O, but got Unknown
		//IL_0831: Expected O, but got I4
		//IL_083a: Expected O, but got I4
		object obj = typeof(List<AdaptivePerformanceScaler>) + 2256;
		object obj2 = (nint)0 + (nint)3912;
		object obj3 = typeof(System.Buffers.Text.ParserHelpers) + 936;
		object obj4 = (nint)0 + (nint)1928;
		object obj5 = "Invalid serialized DateTime data. Unable to find 'ticks' or 'dateData'." + 2984;
		object obj6 = "Invalid serialized DateTime data. Unable to find 'ticks' or 'dateData'." + 3592;
		object obj7 = (nint)0 + (nint)3920;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj8 = obj2;
		List<object> list = default(List<object>);
		list..ctor();
		object obj9 = 7;
		MatchData matchData = default(MatchData);
		List<object> list2 = default(List<object>);
		PlayerInfo playerInfo = default(PlayerInfo);
		PlayerInfo playerInfo2 = default(PlayerInfo);
		PlayerInfo playerInfo3 = default(PlayerInfo);
		PlayerInfo playerInfo4 = default(PlayerInfo);
		while (true)
		{
			object obj10 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 3856;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			matchData..ctor();
			object obj11 = typeof(List<AdaptivePerformanceScaler>) + 2688;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj12 = (nint)0 + (nint)1920;
			list2..ctor();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj13 = "HH:mm:ss.ffZ" + 1048;
			string text = (string)obj13;
			playerInfo..ctor(1, (string)obj13);
			if (list2 == null)
			{
				break;
			}
			object obj14 = obj4;
			int version = list2._version + 1;
			list2._version = version;
			object[] items = list2._items;
			if (list2._items == null)
			{
				break;
			}
			bool flag = list2._size < items.Length;
			object obj15 = !flag;
			if (obj15 == null)
			{
				int size = list2._size + 1;
				list2._size = size;
				object obj16 = list2._items + list2._size;
				object obj17 = obj16 + 32;
				obj17 = playerInfo;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				object obj18 = playerInfo;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ X8_v13+20]");
				object obj19 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v297 @ X8_v37+C0]");
				object obj20 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v298 @ X8_v38+70]");
				text = (string)0;
				list2.AddWithResize((object)playerInfo);
				object obj18 = playerInfo;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj21 = "Invalid serialized DateTime data. Unable to find 'ticks' or 'dateData'." + 3320;
			string text2 = (string)obj21;
			playerInfo2..ctor(2, (string)obj21);
			object obj22 = obj4;
			int version2 = list2._version + 1;
			list2._version = version2;
			object[] items2 = list2._items;
			if (list2._items == null)
			{
				break;
			}
			bool flag2 = list2._size < items2.Length;
			object obj23 = !flag2;
			if (obj23 == null)
			{
				int size2 = list2._size + 1;
				list2._size = size2;
				object obj24 = list2._items + list2._size;
				object obj25 = obj24 + 32;
				obj25 = playerInfo2;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				object obj26 = playerInfo2;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v283 @ X8_v17+20]");
				object obj27 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v372 @ X8_v34+C0]");
				object obj28 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v373 @ X8_v35+70]");
				text2 = (string)0;
				list2.AddWithResize((object)playerInfo2);
				object obj26 = playerInfo2;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			string text3 = (string)obj5;
			playerInfo3..ctor(3, (string)obj5);
			object obj29 = obj4;
			int version3 = list2._version + 1;
			list2._version = version3;
			object[] items3 = list2._items;
			if (list2._items == null)
			{
				break;
			}
			bool flag3 = list2._size < items3.Length;
			object obj30 = !flag3;
			if (obj30 == null)
			{
				int size3 = list2._size + 1;
				list2._size = size3;
				object obj31 = list2._items + list2._size;
				object obj32 = obj31 + 32;
				obj32 = playerInfo3;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				object obj33 = playerInfo3;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v284 @ X8_v19+20]");
				object obj34 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v390 @ X8_v31+C0]");
				object obj35 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v391 @ X8_v32+70]");
				text3 = (string)0;
				list2.AddWithResize((object)playerInfo3);
				object obj33 = playerInfo3;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			string text4 = (string)obj6;
			playerInfo4..ctor(4, (string)obj6);
			object obj36 = obj4;
			int version4 = list2._version + 1;
			list2._version = version4;
			object[] items4 = list2._items;
			if (list2._items == null)
			{
				break;
			}
			bool flag4 = list2._size < items4.Length;
			object obj37 = !flag4;
			if (obj37 == null)
			{
				int size4 = list2._size + 1;
				list2._size = size4;
				object obj38 = list2._items + list2._size;
				object obj39 = obj38 + 32;
				obj39 = playerInfo4;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v285 @ X8_v21+20]");
				object obj40 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v408 @ X8_v28+C0]");
				object obj41 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v409 @ X8_v29+70]");
				text4 = (string)0;
				list2.AddWithResize((object)playerInfo4);
			}
			if (matchData == null)
			{
				break;
			}
			object obj42 = matchData + 24;
			obj42 = list2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			int num = UnityEngine.Random.Range(0, 150);
			int num2 = UnityEngine.Random.Range(0, 150);
			if (list == null)
			{
				break;
			}
			object obj43 = obj7;
			int version5 = list._version + 1;
			list._version = version5;
			object[] items5 = list._items;
			if (list._items == null)
			{
				break;
			}
			bool flag5 = list._size < items5.Length;
			object obj44 = !flag5;
			if (obj44 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v287 @ X8_v23+20]");
				object obj45 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v435 @ X8_v26+C0]");
				object obj46 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X8_v27+70]");
				object obj47 = 0;
				list.AddWithResize((object)matchData);
				obj9--;
				bool flag6 = (nint)obj9 == 1;
				object obj48 = 0;
				obj8 = matchData;
				if (!flag6)
				{
					continue;
				}
			}
			else
			{
				int size5 = list._size + 1;
				list._size = size5;
				object obj49 = list._items + list._size;
				object obj50 = obj49 + 32;
				obj50 = matchData;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				obj9--;
				bool flag7 = (nint)obj9 != 1;
				object obj48 = 0;
				object obj47 = 0;
				obj8 = matchData;
				if (flag7)
				{
					continue;
				}
			}
			return (List<MatchData>)(object)list;
		}
		return (List<MatchData>)(object)new NullReferenceException();
	}

	public override void OnJoinRoom(TournamentData data)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0042: Expected O, but got I
		object obj = typeof(MemberAchievementClanFeedData) + 2632;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		NotImplementedException ex = default(NotImplementedException);
		ex..ctor();
		object obj2 = (nint)0 + (nint)1600;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		throw new OutOfMemoryException();
	}

	public override void CheckParticipationStatus(Action<int> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0042: Expected O, but got I
		object obj = typeof(MemberAchievementClanFeedData) + 2632;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		NotImplementedException ex = default(NotImplementedException);
		ex..ctor();
		object obj2 = (nint)0 + (nint)1584;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		throw new OutOfMemoryException();
	}

	public override void ForceStart(Action<bool> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0042: Expected O, but got I
		object obj = typeof(MemberAchievementClanFeedData) + 2632;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		NotImplementedException ex = default(NotImplementedException);
		ex..ctor();
		object obj2 = (nint)0 + (nint)1592;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		throw new OutOfMemoryException();
	}

	public override void BanPlayer(int dbId)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0042: Expected O, but got I
		object obj = typeof(MemberAchievementClanFeedData) + 2632;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		NotImplementedException ex = default(NotImplementedException);
		ex..ctor();
		object obj2 = (nint)0 + (nint)1576;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		throw new OutOfMemoryException();
	}

	public TournamentViewMockConnector()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected O, but got Unknown
		object obj = typeof(MemberAchievementClanFeedData) + 3440;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		OneShotEvent oneShotEvent = default(OneShotEvent);
		oneShotEvent..ctor();
		object obj2 = this + 32;
		obj2 = oneShotEvent;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		((MonoBehaviour)this)..ctor();
	}
}
