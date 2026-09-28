using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Linq;
using Cpp2ILInjected;
using HuaweiMobileServices.Location.Location;
using Newtonsoft.Json.Linq.JsonPath;
using Sfs2X.Entities.Data;
using Unity.Properties;
using UnityEngine;
using UnityEngine.AdaptivePerformance;
using UnityEngine.TextCore;

[Serializable]
public class MatchData
{
	public enum Status
	{
		Waiting,
		Started,
		Finished
	}

	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Func<PlayerInfo, bool> <>9__72_0;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 3232;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal bool <HasPlayers>b__72_0(PlayerInfo info)
		{
			//IL_003d: Expected I4, but got O
			if (info != null)
			{
				return info.IsHuman;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private sealed class <>c__DisplayClass66_0
	{
		public int dbId;

		internal bool <HasPlayer>b__0(PlayerInfo info)
		{
			//IL_0057: Expected O, but got I4
			if (info != null)
			{
				bool flag = info.IsHuman;
				if (flag)
				{
					object obj = info.<DBID>k__BackingField - dbId;
					bool flag2 = obj == null;
					flag = flag2;
				}
				return flag;
			}
			return false;
		}
	}

	private const string Id = "id";

	private const string Player1 = "p1";

	private const string Player2 = "p2";

	private const string Player3 = "p3";

	private const string Player4 = "p4";

	private const string Team1Wins = "w1";

	private const string Team2Wins = "w2";

	private const string Team1Points = "s1";

	private const string Team2Points = "s2";

	private const string Team1Player1Points = "s1p1";

	private const string Team1Player2Points = "s1p2";

	private const string Team2PLayer1Points = "s2p1";

	private const string Team2PLayer2Points = "s2p2";

	private const string STATUS = "s";

	private int <ID>k__BackingField;

	private List<PlayerInfo> <Players>k__BackingField;

	private int <team1Score>k__BackingField;

	private int <team2Score>k__BackingField;

	private int <team1Points>k__BackingField;

	private int <team2Points>k__BackingField;

	private int <team1Player1Points>k__BackingField;

	private int <team1Player2Points>k__BackingField;

	private int <team2Player1Points>k__BackingField;

	private int <team2PLayer2Points>k__BackingField;

	private Status <State>k__BackingField;

	public int ID
	{
		get
		{
			return <ID>k__BackingField;
		}
		set
		{
			<ID>k__BackingField = value;
		}
	}

	public List<PlayerInfo> Players
	{
		get
		{
			return <Players>k__BackingField;
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

	public int team1Score
	{
		get
		{
			return <team1Score>k__BackingField;
		}
		set
		{
			<team1Score>k__BackingField = value;
		}
	}

	public int team2Score
	{
		get
		{
			return <team2Score>k__BackingField;
		}
		set
		{
			<team2Score>k__BackingField = value;
		}
	}

	public int team1Points
	{
		get
		{
			return <team1Points>k__BackingField;
		}
		set
		{
			<team1Points>k__BackingField = value;
		}
	}

	public int team2Points
	{
		get
		{
			return <team2Points>k__BackingField;
		}
		set
		{
			<team2Points>k__BackingField = value;
		}
	}

	public int team1Player1Points
	{
		get
		{
			return <team1Player1Points>k__BackingField;
		}
		set
		{
			<team1Player1Points>k__BackingField = value;
		}
	}

	public int team1Player2Points
	{
		get
		{
			return <team1Player2Points>k__BackingField;
		}
		set
		{
			<team1Player2Points>k__BackingField = value;
		}
	}

	public int team2Player1Points
	{
		get
		{
			return <team2Player1Points>k__BackingField;
		}
		set
		{
			<team2Player1Points>k__BackingField = value;
		}
	}

	public int team2PLayer2Points
	{
		get
		{
			return <team2PLayer2Points>k__BackingField;
		}
		set
		{
			<team2PLayer2Points>k__BackingField = value;
		}
	}

	public Status State
	{
		get
		{
			return <State>k__BackingField;
		}
		set
		{
			<State>k__BackingField = value;
		}
	}

	public MatchData()
	{
	}

	public MatchData(int id)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected O, but got Unknown
		//IL_0070: Expected I4, but got I8
		//IL_0081: Expected O, but got I
		//IL_00db: Expected O, but got I4
		//IL_0158: Expected O, but got I
		//IL_0168: Expected O, but got I
		//IL_0178: Expected O, but got I
		//IL_01ba: Expected I4, but got I8
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Expected O, but got Unknown
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Expected O, but got Unknown
		//IL_0219: Expected O, but got I4
		//IL_0296: Expected O, but got I
		//IL_02a6: Expected O, but got I
		//IL_02b6: Expected O, but got I
		//IL_02f8: Expected I4, but got I8
		//IL_0254: Unknown result type (might be due to invalid IL or missing references)
		//IL_0259: Expected O, but got Unknown
		//IL_0262: Unknown result type (might be due to invalid IL or missing references)
		//IL_0267: Expected O, but got Unknown
		//IL_0357: Expected O, but got I4
		//IL_03d4: Expected O, but got I
		//IL_03e4: Expected O, but got I
		//IL_03f4: Expected O, but got I
		//IL_0436: Expected I4, but got I8
		//IL_0392: Unknown result type (might be due to invalid IL or missing references)
		//IL_0397: Expected O, but got Unknown
		//IL_03a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a5: Expected O, but got Unknown
		//IL_0495: Expected O, but got I4
		//IL_050a: Expected O, but got I
		//IL_051a: Expected O, but got I
		//IL_052a: Expected O, but got I
		//IL_0542: Unknown result type (might be due to invalid IL or missing references)
		//IL_0547: Expected O, but got Unknown
		//IL_04d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d5: Expected O, but got Unknown
		//IL_04de: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e3: Expected O, but got Unknown
		object obj = typeof(List<AdaptivePerformanceScaler>) + 2688;
		object obj2 = (nint)0 + (nint)1920;
		object obj3 = typeof(System.Buffers.Text.ParserHelpers) + 936;
		object obj4 = ", stale={0}" + 120;
		base..ctor();
		<ID>k__BackingField = id;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list = default(List<object>);
		list..ctor();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		string text = (string)obj4;
		PlayerInfo playerInfo = default(PlayerInfo);
		playerInfo..ctor(-1, (string)obj4);
		object obj5 = (nint)0 + (nint)1928;
		object obj6 = obj5;
		list._version++;
		object[] items = list._items;
		if ((object)(list._size >= items.Length) == null)
		{
			list._size++;
			object obj7 = (object)(items + list._size) + 32;
			obj7 = playerInfo;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj8 = playerInfo;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X8_v4+20]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ X8_v21+C0]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ X8_v22+70]");
			text = (string)0;
			list.AddWithResize((object)playerInfo);
			object obj8 = playerInfo;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		string text2 = (string)obj4;
		PlayerInfo playerInfo2 = default(PlayerInfo);
		playerInfo2..ctor(-1, (string)obj4);
		object obj11 = obj5;
		list._version++;
		object[] items2 = list._items;
		if ((object)(list._size >= items2.Length) == null)
		{
			list._size++;
			object obj12 = (object)(items2 + list._size) + 32;
			obj12 = playerInfo2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj13 = playerInfo2;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ X8_v6+20]");
			object obj14 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v251 @ X8_v18+C0]");
			object obj15 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v252 @ X8_v19+70]");
			text2 = (string)0;
			list.AddWithResize((object)playerInfo2);
			object obj13 = playerInfo2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		string text3 = (string)obj4;
		PlayerInfo playerInfo3 = default(PlayerInfo);
		playerInfo3..ctor(-1, (string)obj4);
		object obj16 = obj5;
		list._version++;
		object[] items3 = list._items;
		if ((object)(list._size >= items3.Length) == null)
		{
			list._size++;
			object obj17 = (object)(items3 + list._size) + 32;
			obj17 = playerInfo3;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj18 = playerInfo3;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ X8_v8+20]");
			object obj19 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ X8_v15+C0]");
			object obj20 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v270 @ X8_v16+70]");
			text3 = (string)0;
			list.AddWithResize((object)playerInfo3);
			object obj18 = playerInfo3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		string text4 = (string)obj4;
		PlayerInfo playerInfo4 = default(PlayerInfo);
		playerInfo4..ctor(-1, (string)obj4);
		object obj21 = obj5;
		list._version++;
		object[] items4 = list._items;
		if ((object)(list._size >= items4.Length) == null)
		{
			list._size++;
			object obj22 = (object)(items4 + list._size) + 32;
			obj22 = playerInfo4;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ X8_v10+20]");
			object obj23 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v287 @ X8_v12+C0]");
			object obj24 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v288 @ X8_v13+70]");
			text4 = (string)0;
			list.AddWithResize((object)playerInfo4);
		}
		object obj25 = this + 24;
		obj25 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	public MatchData(ISFSObject data)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected O, but got Unknown
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Expected O, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected O, but got Unknown
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Expected O, but got Unknown
		//IL_0160: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Expected O, but got Unknown
		//IL_0192: Expected O, but got I4
		//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a6: Expected O, but got Unknown
		//IL_01c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c7: Expected O, but got Unknown
		//IL_01d3: Expected O, but got I
		object varName = "https://www.kammelna.com/Home/Terms" + 328;
		object varName2 = "utf-32" + 1104;
		object varName3 = "utf-32" + 1112;
		object varName4 = "rightCtrl" + 800;
		object varName5 = "rightCtrl" + 824;
		object varName6 = "rightCtrl" + 808;
		object varName7 = "rightCtrl" + 816;
		base..ctor();
		int num = SFSExtensions.Get(data, (string)varName, 0);
		<ID>k__BackingField = num;
		int num2 = SFSExtensions.Get(data, (string)varName2, 0);
		<team1Score>k__BackingField = num2;
		<team2Score>k__BackingField = SFSExtensions.Get(data, (string)varName3, 0);
		<team1Points>k__BackingField = SFSExtensions.Get(data, (string)varName4, 0);
		<team2Points>k__BackingField = SFSExtensions.Get(data, (string)varName5, 0);
		<team1Player1Points>k__BackingField = SFSExtensions.Get(data, (string)varName6, 0);
		<team1Player2Points>k__BackingField = SFSExtensions.Get(data, (string)varName7, 0);
		<team2Player1Points>k__BackingField = SFSExtensions.Get(data, "rightCtrl" + 832, 0);
		List<PlayerInfo> playersFromSfsObject = ((MatchData)(<team2PLayer2Points>k__BackingField = SFSExtensions.Get(data, "rightCtrl" + 840, 0))).GetPlayersFromSfsObject(data);
		object obj = this + 24;
		obj = playersFromSfsObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj2 = "rightCtrl" + 768;
		object obj3 = (nint)0 + (nint)256;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @301ECBC");
	}

	public List<MatchData> CreateMatchDataFromSfs(ISFSObject data)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_0045: Expected I, but got O
		//IL_0055: Expected O, but got I
		//IL_00eb: Expected O, but got I
		//IL_010f: Expected O, but got I4
		//IL_0191: Unknown result type (might be due to invalid IL or missing references)
		//IL_0196: Expected O, but got Unknown
		//IL_01a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01aa: Expected O, but got Unknown
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01be: Expected O, but got Unknown
		//IL_01ca: Expected O, but got I
		//IL_01d3: Expected O, but got I4
		//IL_0090: Expected O, but got I
		//IL_053c: Expected O, but got I
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Expected O, but got Unknown
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Expected O, but got Unknown
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Expected O, but got Unknown
		//IL_015b: Expected O, but got I
		//IL_0323: Expected O, but got I
		//IL_0243: Expected O, but got I
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Expected O, but got Unknown
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Expected O, but got Unknown
		//IL_05b9: Expected O, but got I
		//IL_035e: Expected O, but got I
		//IL_02c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c7: Expected O, but got Unknown
		//IL_02dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e2: Expected O, but got Unknown
		//IL_0251: Unknown result type (might be due to invalid IL or missing references)
		//IL_0256: Expected O, but got Unknown
		//IL_025f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0264: Expected O, but got Unknown
		//IL_03b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bc: Expected O, but got Unknown
		//IL_03d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d7: Expected O, but got Unknown
		//IL_036c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0371: Expected O, but got Unknown
		//IL_037a: Unknown result type (might be due to invalid IL or missing references)
		//IL_037f: Expected O, but got Unknown
		//IL_0453: Expected O, but got I4
		//IL_01e8: Expected O, but got I
		//IL_01f8: Expected O, but got I
		//IL_0208: Expected O, but got I
		//IL_0223: Unknown result type (might be due to invalid IL or missing references)
		//IL_0228: Expected O, but got Unknown
		//IL_0493: Unknown result type (might be due to invalid IL or missing references)
		//IL_0498: Expected O, but got Unknown
		//IL_04a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a6: Expected O, but got Unknown
		object obj = typeof(List<AdaptivePerformanceScaler>) + 2256;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list = default(List<object>);
		list..ctor();
		object obj10 = default(object);
		object obj9;
		if (data != null)
		{
			object obj2 = typeof(System.IOAsyncCallback) + 976;
			object obj3 = "m_StencilDeferredPS" + 616;
			nint num = (nint)data;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X8_v6 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X8_v6 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_00d1;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X8_v6 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
			object obj5 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ X10_v21-8]");
				if (0 == (nint)obj2)
				{
					break;
				}
				obj5 += 16;
				obj4--;
				if ((nint)obj4 != 1)
				{
					continue;
				}
				goto IL_00d1;
			}
			object obj6 = obj5 + 28;
			object obj7 = num + obj6;
			object obj8 = obj7 + 312;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v281 @ X0_v35+8]");
			obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v281 @ X0_v35] (should have been resolved before IL gen)");
			if (obj10 != null)
			{
				goto IL_0182;
			}
		}
		goto IL_04c2;
		IL_0182:
		object obj11 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 1616;
		object obj12 = typeof(System.IOAsyncCallback) + 960;
		object obj13 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 3856;
		object obj14 = (nint)0 + (nint)3920;
		object obj15 = 0;
		object obj22 = default(object);
		MatchData matchData = default(MatchData);
		ISFSObject data2 = default(ISFSObject);
		object obj35 = default(object);
		while (true)
		{
			object obj16 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v342 @ X8_v9+12E]");
			object obj17 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v342 @ X8_v9+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0284;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v342 @ X8_v9+B0]");
			object obj18 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v383 @ X10_v16-8]");
				if (0 == (nint)obj11)
				{
					break;
				}
				obj18 += 16;
				obj17--;
				if ((nint)obj17 != 1)
				{
					continue;
				}
				goto IL_0284;
			}
			object obj19 = obj18 + 1;
			object obj20 = obj16 + obj19;
			object obj21 = obj20 + 312;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v413 @ X0_v28] (should have been resolved before IL gen)");
			if (obj15 < obj22)
			{
				goto IL_030b;
			}
			goto IL_04bd;
			IL_030b:
			object obj23 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v445 @ X8_v12+12E]");
			object obj24 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v445 @ X8_v12+12E]");
			if ((nint)0 == 0)
			{
				goto IL_039f;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v445 @ X8_v12+B0]");
			object obj25 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v488 @ X10_v11-8]");
				if (0 == (nint)obj12)
				{
					break;
				}
				obj25 += 16;
				obj24--;
				if ((nint)obj24 != 1)
				{
					continue;
				}
				goto IL_039f;
			}
			object obj26 = obj25 + 51;
			object obj27 = obj23 + obj26;
			object obj28 = obj27 + 312;
			goto IL_05a9;
			IL_05a9:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v505 @ X0_v11+8]");
			obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v505 @ X0_v11] (should have been resolved before IL gen)");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			matchData..ctor(data2);
			if (list == null)
			{
				break;
			}
			object obj29 = obj14;
			int version = list._version + 1;
			list._version = version;
			object[] items = list._items;
			if (list._items == null)
			{
				break;
			}
			bool flag = list._size < items.Length;
			object obj30 = !flag;
			if (obj30 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X8_v15+20]");
				object obj31 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v519 @ X8_v18+C0]");
				object obj32 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v520 @ X8_v19+70]");
				obj9 = 0;
				list.AddWithResize((object)matchData);
			}
			else
			{
				int size = list._size + 1;
				list._size = size;
				object obj33 = list._items + list._size;
				object obj34 = obj33 + 32;
				obj34 = matchData;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			}
			obj15++;
			continue;
			IL_039f:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			goto IL_05a9;
			IL_0284:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v372 @ X0_v25] (should have been resolved before IL gen)");
			if (obj15 < obj35)
			{
				goto IL_030b;
			}
			goto IL_04bd;
			IL_04bd:
			return (List<MatchData>)(object)list;
		}
		goto IL_04c2;
		IL_04c2:
		return (List<MatchData>)(object)new NullReferenceException();
		IL_00d1:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ X0_v32+8]");
		obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v200 @ X0_v32] (should have been resolved before IL gen)");
		bool flag2 = obj10 == null;
		object obj36 = !flag2;
		if (obj36 != null)
		{
			goto IL_0182;
		}
		goto IL_04c2;
	}

	private List<PlayerInfo> GetPlayersFromSfsObject(ISFSObject data)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected O, but got Unknown
		object obj = typeof(List<AdaptivePerformanceScaler>) + 2688;
		object index = "not" + 2928;
		object index2 = "not" + 2936;
		object index3 = "not" + 2944;
		object index4 = "not" + 2952;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list = default(List<object>);
		list..ctor();
		AddPlayerInfo(data, (List<PlayerInfo>)(object)list, (string)index);
		AddPlayerInfo(data, (List<PlayerInfo>)(object)list, (string)index2);
		AddPlayerInfo(data, (List<PlayerInfo>)(object)list, (string)index3);
		AddPlayerInfo(data, (List<PlayerInfo>)(object)list, (string)index4);
		return (List<PlayerInfo>)(object)list;
	}

	private static void AddPlayerInfo(ISFSObject data, List<PlayerInfo> players, string index)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0021: Expected I, but got O
		//IL_0031: Expected O, but got I
		//IL_024f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0254: Expected O, but got Unknown
		//IL_006c: Expected O, but got I
		//IL_014c: Expected O, but got I
		//IL_02a4: Expected I4, but got I8
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Expected O, but got Unknown
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected O, but got Unknown
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Expected O, but got Unknown
		//IL_0120: Expected O, but got I4
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected O, but got Unknown
		//IL_01a4: Expected O, but got I4
		//IL_01df: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e4: Expected O, but got Unknown
		//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f2: Expected O, but got Unknown
		object obj = typeof(System.IOAsyncCallback) + 976;
		nint num = (nint)data;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X8_v6 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X8_v6 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_00ad;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X8_v6 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
		object obj3 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ X10_v7-8]");
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
		object obj4 = obj3 + 29;
		object obj5 = num + obj4;
		object obj6 = obj5 + 312;
		goto IL_0240;
		IL_00ad:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_0240;
		IL_0240:
		object obj7 = typeof(System.Buffers.Text.ParserHelpers) + 936;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v249 @ X0_v4] (should have been resolved before IL gen)");
		ISFSObject iSFSObject = default(ISFSObject);
		PlayerInfo playerInfo2;
		if (iSFSObject != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			PlayerInfo playerInfo = default(PlayerInfo);
			playerInfo..ctor(iSFSObject);
			bool flag = players == null;
			object obj8 = !flag;
			string text = null;
			playerInfo2 = playerInfo;
			if (obj8 == null)
			{
				throw new NullReferenceException();
			}
		}
		else
		{
			object obj9 = (nint)0 + (nint)3488;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			string text = (string)obj9;
			PlayerInfo playerInfo3 = default(PlayerInfo);
			playerInfo3..ctor(-1, (string)obj9);
			playerInfo2 = playerInfo3;
		}
		int version = players._version + 1;
		players._version = version;
		PlayerInfo[] items = players._items;
		bool flag2 = players._size < items.Length;
		object obj10 = !flag2;
		if (obj10 == null)
		{
			int size = players._size + 1;
			players._size = size;
			object obj11 = items + players._size;
			object obj12 = obj11 + 32;
			obj12 = playerInfo2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
		else
		{
			((List<object>)(object)players).AddWithResize((object)playerInfo2);
		}
	}

	private static PlayerInfo GetEmptyPlayer()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_0045: Expected I4, but got I8
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 936;
		object name = (nint)0 + (nint)3488;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		PlayerInfo playerInfo = default(PlayerInfo);
		playerInfo..ctor(-1, (string)name);
		return playerInfo;
	}

	public bool HasPlayer(int dbId)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0085: Expected I4, but got O
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_005a: Expected I, but got O
		object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 3240;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		if (obj2 != null)
		{
			object obj3 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2672;
			object obj4 = (nint)0 + (nint)1096;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Func<object, bool> func = default(Func<object, bool>);
			func..ctor(obj2, (IntPtr)obj4);
			return Enumerable.Any(<Players>k__BackingField, func);
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	public int GetTeamId(int dbId)
	{
		//IL_0113: Expected I4, but got O
		bool flag = HasPlayer(dbId);
		bool flag2 = !flag;
		int result = (flag ? 1 : 0);
		if (!flag2)
		{
			if (<Players>k__BackingField != null)
			{
				object obj = ((List<object>)(object)<Players>k__BackingField).get_Item(0);
				if (obj != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X0_v8 (System.Object)+10]");
					if ((nint)0 == dbId)
					{
						goto IL_00f1;
					}
					if (<Players>k__BackingField != null)
					{
						object obj2 = ((List<object>)(object)<Players>k__BackingField).get_Item(2);
						if (obj2 != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X0_v12 (System.Object)+10]");
							if ((nint)0 == dbId)
							{
								goto IL_00f1;
							}
							return 2;
						}
					}
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
		}
		goto IL_0142;
		IL_00f1:
		result = 1;
		goto IL_0142;
		IL_0142:
		return result;
	}

	public PlayerInfo[] GetTeamPlayers(int team)
	{
		//IL_0225: Unknown result type (might be due to invalid IL or missing references)
		//IL_022a: Expected O, but got Unknown
		//IL_0268: Expected O, but got I
		//IL_0270: Expected I, but got O
		//IL_04d0: Expected O, but got I
		//IL_04e8: Expected O, but got I
		//IL_064d: Expected O, but got I
		//IL_065d: Expected O, but got I
		//IL_0673: Expected O, but got I
		//IL_067c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0681: Expected O, but got Unknown
		//IL_069b: Expected O, but got I4
		//IL_06ab: Expected O, but got I
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		//IL_051d: Expected O, but got I
		//IL_0533: Expected O, but got I
		//IL_053c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0541: Expected O, but got Unknown
		//IL_0560: Expected O, but got I
		//IL_070d: Expected O, but got I
		//IL_071d: Expected O, but got I
		//IL_0733: Expected O, but got I
		//IL_073c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0741: Expected O, but got Unknown
		//IL_06e5: Expected O, but got I4
		//IL_0077: Expected O, but got I
		//IL_007f: Expected I, but got O
		//IL_02d8: Expected I, but got O
		//IL_05a3: Expected O, but got I
		//IL_05b3: Expected O, but got I
		//IL_05c9: Expected O, but got I
		//IL_05d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d7: Expected O, but got Unknown
		//IL_05f1: Expected O, but got I4
		//IL_0601: Expected O, but got I
		//IL_034f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0354: Expected O, but got Unknown
		//IL_037f: Expected I4, but got O
		//IL_062e: Expected O, but got I
		//IL_076e: Expected O, but got I
		//IL_0395: Expected I, but got O
		//IL_03d0: Expected I, but got O
		//IL_00e7: Expected I, but got O
		//IL_0472: Expected O, but got I8
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Expected O, but got Unknown
		//IL_018e: Expected I4, but got O
		//IL_03ff: Expected I, but got O
		//IL_04a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ad: Expected O, but got Unknown
		//IL_01a4: Expected I, but got O
		//IL_01d2: Expected O, but got I4
		//IL_01f8: Expected I, but got O
		object obj19;
		PlayerInfo[] array2;
		nint num5;
		int num6;
		object obj20;
		PlayerInfo[] array3;
		nint num2;
		int num;
		IndexOutOfRangeException ex = default(IndexOutOfRangeException);
		if (team != 2)
		{
			if (team != 1)
			{
				object obj = (nint)0 + (nint)3272;
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X19_v9+38]");
				object obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X19_v9+38]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X8_v17+10]");
					object obj4 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X8_v17+10]");
					object obj5 = (nint)0 + (nint)309;
					object obj6 = obj5 & 1;
					bool flag = obj6 == null;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X8_v17+10]");
					object obj7 = 0;
					if (!flag)
					{
						goto IL_056e;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CD24");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X19_v9+38]");
					object obj8 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ X8_v24+10]");
					object obj4 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ X8_v24+10]");
					object obj9 = (nint)0 + (nint)309;
					object obj10 = obj9 & 1;
					bool flag2 = obj10 == null;
					object obj11 = !flag2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ X8_v24+10]");
					object obj7 = 0;
					if (obj11 != null)
					{
						goto IL_056e;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ X0_v29+E4]");
				bool flag3 = (nint)0 == 0;
				object obj12 = !flag3;
				if (obj12 != null)
				{
					goto IL_0593;
				}
				goto IL_06f3;
			}
			object obj13 = typeof(TypeConverter<ushort, char>) + 3504;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
			bool flag4 = <Players>k__BackingField == null;
			num = 2;
			if (!flag4)
			{
				object obj14 = (nint)0 + (nint)1968;
				num2 = (nint)obj14;
				object obj15 = ((List<object>)(object)<Players>k__BackingField).get_Item(0);
				PlayerInfo[] array = default(PlayerInfo[]);
				bool flag5 = array == null;
				num = 0;
				if (!flag5)
				{
					bool flag6 = obj15 == null;
					int num3 = 0;
					if (!flag6)
					{
						nint num4 = (nint)array;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v249 @ X8_v42 (Il2CppClass<PlayerInfo[]>)+40]");
						num3 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
						bool flag7 = ex == null;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v249 @ X8_v42 (Il2CppClass<PlayerInfo[]>)+40]");
						num = 0;
						if (flag7)
						{
							goto IL_078f;
						}
					}
					bool flag8 = array.Length == 0;
					num = num3;
					if (flag8)
					{
						goto IL_0781;
					}
					object obj16 = array + 32;
					obj16 = obj15;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					bool flag9 = <Players>k__BackingField == null;
					num = (int)obj15;
					if (!flag9)
					{
						num2 = (nint)obj14;
						object obj17 = ((List<object>)(object)<Players>k__BackingField).get_Item(2);
						bool flag10 = obj17 == null;
						object obj18 = !flag10;
						obj19 = obj17;
						array2 = array;
						if (obj18 != null)
						{
							goto IL_03f7;
						}
						num5 = (nint)obj14;
						num6 = 2;
						obj20 = obj17;
						array3 = array;
						goto IL_045e;
					}
				}
			}
		}
		else
		{
			object obj21 = typeof(TypeConverter<ushort, char>) + 3504;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
			bool flag11 = <Players>k__BackingField == null;
			num = 2;
			if (!flag11)
			{
				object obj22 = (nint)0 + (nint)1968;
				num2 = (nint)obj22;
				object obj23 = ((List<object>)(object)<Players>k__BackingField).get_Item(1);
				PlayerInfo[] array4 = default(PlayerInfo[]);
				bool flag12 = array4 == null;
				num = 1;
				if (!flag12)
				{
					bool flag13 = obj23 == null;
					int num7 = 1;
					if (!flag13)
					{
						nint num8 = (nint)array4;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v250 @ X8_v14 (Il2CppClass<PlayerInfo[]>)+40]");
						num7 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
						bool flag14 = ex == null;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v250 @ X8_v14 (Il2CppClass<PlayerInfo[]>)+40]");
						num = 0;
						if (flag14)
						{
							goto IL_078f;
						}
					}
					bool flag15 = array4.Length == 0;
					num = num7;
					if (flag15)
					{
						goto IL_0781;
					}
					object obj24 = array4 + 32;
					obj24 = obj23;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					bool flag16 = <Players>k__BackingField == null;
					num = (int)obj23;
					if (!flag16)
					{
						num2 = (nint)obj22;
						object obj25 = ((List<object>)(object)<Players>k__BackingField).get_Item(3);
						bool flag17 = obj25 == null;
						obj19 = obj25;
						array2 = array4;
						num5 = (nint)obj22;
						num6 = 3;
						obj20 = obj25;
						array3 = array4;
						if (!flag17)
						{
							goto IL_03f7;
						}
						goto IL_045e;
					}
				}
			}
		}
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_0781;
		IL_061e:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v267 @ X0_v37+B8]");
		return (PlayerInfo[])0;
		IL_056e:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ X0_v29+E4]");
		if ((nint)0 != 0)
		{
			goto IL_0593;
		}
		goto IL_06f3;
		IL_03f7:
		nint num9 = (nint)array2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v251 @ X8_v9 (Il2CppClass<PlayerInfo[]>)+40]");
		num6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
		bool flag18 = ex == null;
		num5 = num2;
		obj20 = obj19;
		array3 = array2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v251 @ X8_v9 (Il2CppClass<PlayerInfo[]>)+40]");
		num = 0;
		if (!flag18)
		{
			goto IL_045e;
		}
		goto IL_078f;
		IL_045e:
		object obj26 = array3.Length & 0xFFFFFFFEL;
		bool flag19 = obj26 == null;
		num2 = num5;
		num = num6;
		if (!flag19)
		{
			object obj27 = array3 + 40;
			obj27 = obj20;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			return array3;
		}
		goto IL_0781;
		IL_0593:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X19_v9+38]");
		object obj28 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ X8_v31+10]");
		object obj29 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ X8_v31+10]");
		object obj30 = (nint)0 + (nint)309;
		object obj31 = obj30 & 1;
		bool flag20 = obj31 == null;
		object obj32 = !flag20;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ X8_v31+10]");
		object obj33 = 0;
		if (obj32 == null)
		{
			goto IL_060f;
		}
		goto IL_061e;
		IL_0781:
		ex = new IndexOutOfRangeException();
		goto IL_078f;
		IL_078f:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		return (PlayerInfo[])(object)new OutOfMemoryException();
		IL_060f:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		goto IL_061e;
		IL_06f3:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X19_v9+38]");
		object obj34 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v279 @ X8_v19+10]");
		obj29 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v279 @ X8_v19+10]");
		object obj35 = (nint)0 + (nint)309;
		object obj36 = obj35 & 1;
		if (obj36 == null)
		{
			goto IL_060f;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v279 @ X8_v19+10]");
		obj33 = 0;
		goto IL_061e;
	}

	public int GetLosingTeamIndex()
	{
		//IL_0011: Expected O, but got I4
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected I4, but got Unknown
		//IL_0084: Expected O, but got I4
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Expected O, but got Unknown
		object obj = <team1Score>k__BackingField - <team2Score>k__BackingField;
		bool flag = (nint)obj < 0;
		bool flag2 = obj == null;
		int num = <team1Score>k__BackingField ^ <team2Score>k__BackingField;
		int num2 = <team1Score>k__BackingField ^ obj;
		int num3 = num & num2;
		bool flag3 = num3 < 0;
		bool flag4 = flag == flag3;
		object obj2 = !flag2;
		object obj3 = flag4 & obj2;
		object obj4 = ~obj3;
		int result = ((obj4 == null) ? 2 : 0);
		if (<team1Score>k__BackingField >= <team2Score>k__BackingField)
		{
			return result;
		}
		return 1;
	}

	public int GetWinningTeamIndex()
	{
		//IL_0011: Expected O, but got I4
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected I4, but got Unknown
		//IL_0084: Expected O, but got I4
		//IL_00eb: Expected O, but got I4
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Expected O, but got Unknown
		object obj = <team1Score>k__BackingField - <team2Score>k__BackingField;
		bool flag = (nint)obj < 0;
		bool flag2 = obj == null;
		int num = <team1Score>k__BackingField ^ <team2Score>k__BackingField;
		int num2 = <team1Score>k__BackingField ^ obj;
		int num3 = num & num2;
		bool flag3 = num3 < 0;
		bool flag4 = flag == flag3;
		object obj2 = !flag4;
		object obj3 = ~obj2;
		int result = ((obj3 == null) ? 2 : 0);
		bool flag5 = flag == flag3;
		object obj4 = !flag5;
		object obj5 = obj4 | flag2;
		object obj6 = ~obj5;
		if (obj6 == null)
		{
			return result;
		}
		return 1;
	}

	public bool HasEmptyTeam()
	{
		//IL_01e6: Expected I4, but got O
		//IL_005e: Expected O, but got I4
		if (<Players>k__BackingField != null)
		{
			object obj = ((List<object>)(object)<Players>k__BackingField).get_Item(0);
			if (obj != null)
			{
				bool isHuman = ((PlayerInfo)obj).IsHuman;
				bool flag = !isHuman;
				object obj2 = !flag;
				if (obj2 != null)
				{
					goto IL_00e2;
				}
				if (<Players>k__BackingField != null)
				{
					object obj3 = ((List<object>)(object)<Players>k__BackingField).get_Item(2);
					if (obj3 != null)
					{
						if (((PlayerInfo)obj3).IsHuman)
						{
							goto IL_00e2;
						}
						return true;
					}
				}
			}
		}
		goto IL_01d8;
		IL_00e2:
		if (<Players>k__BackingField != null)
		{
			object obj4 = ((List<object>)(object)<Players>k__BackingField).get_Item(1);
			if (obj4 != null)
			{
				if (((PlayerInfo)obj4).IsHuman)
				{
					return false;
				}
				if (<Players>k__BackingField != null)
				{
					object obj5 = ((List<object>)(object)<Players>k__BackingField).get_Item(3);
					if (obj5 != null)
					{
						bool isHuman2 = ((PlayerInfo)obj5).IsHuman;
						return (byte)((isHuman2 ? 1u : 0u) ^ 1u) != 0;
					}
				}
			}
		}
		goto IL_01d8;
		IL_01d8:
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	public bool HasPlayers()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_014c: Expected O, but got I4
		//IL_00a5: Expected O, but got I
		//IL_00b5: Expected O, but got I
		//IL_00c5: Expected O, but got I
		//IL_00e7: Expected O, but got I4
		//IL_018a: Expected O, but got I
		//IL_019a: Expected O, but got I
		//IL_01aa: Expected O, but got I
		//IL_01cc: Expected O, but got I4
		//IL_0214: Expected O, but got I4
		//IL_026e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0273: Expected O, but got Unknown
		//IL_0289: Expected O, but got I
		//IL_029a: Expected I, but got O
		//IL_02b8: Expected O, but got I
		//IL_0244: Expected O, but got I
		object obj = 152985600;
		object obj2 = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 3232;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6C16]");
		object obj3 = (nint)0 & (nint)1;
		List<PlayerInfo> list;
		List<PlayerInfo> list2;
		object obj4;
		if (obj3 != null)
		{
			list = <Players>k__BackingField;
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X0_v4+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = obj4;
			list2 = <Players>k__BackingField;
			if (!flag)
			{
				goto IL_0099;
			}
		}
		else
		{
			_ = 1;
			list = <Players>k__BackingField;
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X0_v4+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			object obj5 = obj4;
			list2 = <Players>k__BackingField;
			if (obj6 != null)
			{
				goto IL_0099;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj4 = obj2;
		object obj7 = (nint)0 + (nint)2736;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X0_v4+B8]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X8_v4+8]");
		Func<object, bool> predicate = (Func<object, bool>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X8_v4+8]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		IEnumerable<object> enumerable = list2;
		object obj10 = obj7;
		IEnumerable<object> source = list2;
		if (obj9 == null)
		{
			goto IL_01f2;
		}
		goto IL_0249;
		IL_01f2:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X0_v4+E4]");
		bool flag4 = (nint)0 == 0;
		object obj11 = !flag4;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj12 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X8_v10+B8]");
			obj8 = 0;
		}
		object obj13 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2672;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj14 = (nint)0 + (nint)1088;
		Func<object, bool> func = default(Func<object, bool>);
		func..ctor(obj8, (IntPtr)obj14);
		object obj15 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X8_v9+B8]");
		object obj16 = (nint)0 + (nint)8;
		obj16 = func;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj10 = obj7;
		predicate = func;
		source = enumerable;
		goto IL_0249;
		IL_0249:
		return Enumerable.Any(source, predicate);
		IL_0099:
		obj10 = (nint)0 + (nint)2736;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X0_v4+B8]");
		obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X8_v4+8]");
		predicate = (Func<object, bool>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X8_v4+8]");
		bool flag5 = (nint)0 == 0;
		object obj17 = !flag5;
		source = list;
		if (obj17 == null)
		{
			obj7 = obj10;
			enumerable = list;
			goto IL_01f2;
		}
		goto IL_0249;
	}

	public void Update(MatchData newMatch)
	{
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected O, but got Unknown
		if (newMatch != null && newMatch.<ID>k__BackingField == <ID>k__BackingField)
		{
			object obj = this + 24;
			obj = newMatch.<Players>k__BackingField;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			_ = newMatch.<team1Score>k__BackingField;
			_ = newMatch.<team1Player1Points>k__BackingField;
			_ = newMatch.<State>k__BackingField;
		}
	}
}
