using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Linq;
using Cpp2ILInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Features.GameReplay;
using HuaweiMobileServices.Location.Location;
using Kammelna.Server;
using Kammelna.Server.Models.Clans;
using Newtonsoft.Json.Linq.JsonPath;
using Server.Models;
using Sfs2X.Entities;
using TMPro;
using Unity.Properties;
using UnityEngine;

public class GiftBombTopRecent : MonoBehaviour
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Func<NormalPlaceItem, int> <>9__14_0;

		public static Func<NormalPlaceItem, CanvasGroup> <>9__14_1;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(GameReplayController.<OnEndRoundEventIe>d__138) + 320;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal int <Awake>b__14_0(NormalPlaceItem item)
		{
			//IL_003d: Expected I4, but got O
			if ((object)item != null)
			{
				return item.GetInstanceID();
			}
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
		}

		internal CanvasGroup <Awake>b__14_1(NormalPlaceItem item)
		{
			//IL_0011: Expected O, but got I
			if ((object)item != null)
			{
				object obj = (nint)0 + (nint)3664;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
				CanvasGroup result = default(CanvasGroup);
				return result;
			}
			return (CanvasGroup)(object)new NullReferenceException();
		}
	}

	private ILeaderboardSource _weeklyLeaderboardSource;

	private NormalPlaceItem[] topWeeklyItems;

	private NormalPlaceItem recentItem;

	private GameObject background;

	private TextMeshProUGUI bombInfoText;

	private GameObject bombMessage;

	private TextMeshProUGUI bombMessageText;

	private const string BombInfoSubs = "Distributed subs of {0} days for {1} members";

	private const string BombInfoAces = "Distributed {0} aces for {1} members";

	private const string BombMessagePrefix = "Bomb Message: {0}";

	private const string SubDays = "Days";

	private List<LeaderBoardPlayer> _topPlayers;

	private GiftBombData _lastGiftBomb;

	private Dictionary<int, CanvasGroup> _canvasGroups;

	private void Awake()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0079: Expected O, but got I4
		//IL_00e4: Expected O, but got I
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Expected O, but got Unknown
		//IL_010a: Expected I, but got O
		//IL_045b: Expected O, but got I
		//IL_046b: Expected O, but got I
		//IL_048d: Expected O, but got I4
		//IL_015c: Expected O, but got I
		//IL_016c: Expected O, but got I
		//IL_04c5: Expected O, but got I4
		//IL_01f2: Expected O, but got I
		//IL_0201: Unknown result type (might be due to invalid IL or missing references)
		//IL_0206: Expected O, but got Unknown
		//IL_0212: Expected O, but got I
		//IL_0221: Unknown result type (might be due to invalid IL or missing references)
		//IL_0226: Expected O, but got Unknown
		//IL_0236: Expected O, but got I
		//IL_0246: Expected O, but got I
		//IL_0268: Expected O, but got I4
		//IL_0641: Unknown result type (might be due to invalid IL or missing references)
		//IL_0646: Expected O, but got Unknown
		//IL_065c: Expected O, but got I
		//IL_0664: Expected I, but got O
		//IL_0675: Expected I, but got O
		//IL_0693: Expected O, but got I
		//IL_02d9: Expected O, but got I
		//IL_02f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f9: Expected O, but got Unknown
		//IL_0524: Expected O, but got I4
		//IL_052d: Expected O, but got I4
		//IL_0546: Expected O, but got I4
		//IL_054e: Expected I, but got O
		//IL_04f5: Expected O, but got I
		//IL_0328: Expected I, but got O
		//IL_0298: Expected O, but got I4
		//IL_0360: Expected O, but got I4
		//IL_05c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ce: Expected O, but got Unknown
		//IL_05e4: Expected O, but got I
		//IL_05f5: Expected I, but got O
		//IL_0613: Expected O, but got I
		//IL_02c8: Expected O, but got I
		//IL_03da: Unknown result type (might be due to invalid IL or missing references)
		//IL_03df: Expected O, but got Unknown
		//IL_03f5: Expected O, but got I
		//IL_0403: Expected I, but got O
		//IL_0412: Unknown result type (might be due to invalid IL or missing references)
		//IL_0417: Expected O, but got Unknown
		GameObject gameObject = base.gameObject;
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		gameObject.SetActive(value: false);
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X0_v6+E4]");
		if ((nint)0 != 0)
		{
			bool flag = background;
			bool flag2 = !flag;
			object obj3 = !flag2;
			if (obj3 != null)
			{
				goto IL_00c3;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			if ((bool)background)
			{
				goto IL_00c3;
			}
		}
		goto IL_00d8;
		IL_01e6:
		object obj4 = (nint)0 + (nint)1696;
		object obj5 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3344;
		object obj6 = (nint)0 + (nint)3192;
		object obj7 = typeof(Queue<string>) + 848;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v243 @ X0_v25+B8]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v305 @ X8_v31+10]");
		Func<object, object> elementSelector = (Func<object, object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v305 @ X8_v31+10]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		object obj12;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v243 @ X0_v25+E4]");
			bool flag4 = (nint)0 == 0;
			object obj10 = !flag4;
			if (obj10 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj11 = obj12;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v321 @ X8_v37+B8]");
				obj8 = 0;
			}
			object obj13 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2536;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj14 = (nint)0 + (nint)2192;
			Func<object, object> func = default(Func<object, object>);
			func..ctor(obj8, (IntPtr)obj14);
			object obj15 = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v289 @ X8_v36+B8]");
			object obj16 = (nint)0 + (nint)16;
			obj16 = func;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			elementSelector = func;
		}
		object obj17 = (nint)0 + (nint)2200;
		IEnumerable<object> source;
		Func<object, int> func2;
		Dictionary<int, object> dictionary = Enumerable.ToDictionary(source, func2, elementSelector);
		object obj18 = this + 104;
		obj18 = dictionary;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj6);
		SFS.OnJoinRoom += action;
		object obj19 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v332 @ X0_v35+E4]");
		bool flag5 = (nint)0 == 0;
		object obj20 = !flag5;
		if (obj20 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel = default(SessionModel);
		if (sessionModel.IsInLobby)
		{
			GameObject go = base.gameObject;
			Room lobby = SFS.Lobby;
			object obj21 = typeof(SqlSingle[]) + 2376;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj22 = (nint)0 + (nint)3184;
			Action action2 = default(Action);
			action2..ctor(this, (IntPtr)obj22);
			object varName = "___# Content push apply failed [{0}]: {1}" + 2736;
			VariableBinderExtensions.Bind(go, lobby, (string)varName, action2);
		}
		LoadLeaderboard();
		return;
		IL_0574:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj23 = obj12;
		object obj25;
		object obj24 = obj25;
		nint num2;
		nint num = num2;
		object obj27;
		object obj26 = obj27;
		Func<object, int> func3;
		func2 = func3;
		goto IL_01e6;
		IL_00c3:
		background.SetActive(value: false);
		goto IL_00d8;
		IL_00d8:
		object obj28 = (nint)0 + (nint)2976;
		obj12 = typeof(GameReplayController.<OnEndRoundEventIe>d__138) + 320;
		obj26 = recentItem;
		num = (nint)obj28;
		source = Enumerable.Append((IEnumerable<object>)topWeeklyItems, (object)recentItem);
		obj23 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v243 @ X0_v25+E4]");
		object obj29;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v243 @ X0_v25+B8]");
			obj29 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v264 @ X8_v10+8]");
			func2 = (Func<object, int>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v264 @ X8_v10+8]");
			bool flag6 = (nint)0 == 0;
			object obj30 = obj23;
			if (!flag6)
			{
				goto IL_0199;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj23 = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v243 @ X0_v25+B8]");
			obj29 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v264 @ X8_v10+8]");
			func2 = (Func<object, int>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v264 @ X8_v10+8]");
			bool flag7 = (nint)0 == 0;
			object obj31 = !flag7;
			object obj30 = obj23;
			if (obj31 != null)
			{
				goto IL_0199;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ X0_v14+E4]");
		bool flag8 = (nint)0 == 0;
		object obj32 = !flag8;
		if (obj32 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj33 = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v296 @ X8_v17+B8]");
			obj29 = 0;
		}
		object obj34 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2544;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj35 = (nint)0 + (nint)2184;
		num = (nint)obj35;
		Func<object, int> func4 = default(Func<object, int>);
		func4..ctor(obj29, (IntPtr)obj35);
		object obj36 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v315 @ X8_v15+B8]");
		object obj37 = (nint)0 + (nint)8;
		obj37 = func4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj23 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v243 @ X0_v25+E4]");
		bool flag9 = (nint)0 == 0;
		object obj38 = !flag9;
		obj24 = 0;
		obj26 = func4;
		func2 = func4;
		obj25 = 0;
		num2 = (nint)obj35;
		obj27 = func4;
		func3 = func4;
		object obj39 = obj23;
		if (obj38 != null)
		{
			goto IL_01e6;
		}
		goto IL_0574;
		IL_0199:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v243 @ X0_v25+E4]");
		bool flag10 = (nint)0 == 0;
		obj25 = obj24;
		num2 = num;
		obj27 = obj26;
		func3 = func2;
		obj39 = obj23;
		if (!flag10)
		{
			goto IL_01e6;
		}
		goto IL_0574;
	}

	private void OnDestroy()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_003e: Expected I, but got O
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3344;
		object obj2 = (nint)0 + (nint)3192;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj2);
		SFS.OnJoinRoom -= action;
	}

	private void OnEnable()
	{
		LoadLeaderboard();
	}

	private void OnJoinRoom(Room room)
	{
		//IL_0009: Expected O, but got I4
		//IL_001f: Expected O, but got I
		//IL_005f: Expected O, but got I4
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Expected O, but got Unknown
		//IL_009c: Expected O, but got I
		//IL_00c3: Expected O, but got I
		//IL_01e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e5: Expected O, but got Unknown
		//IL_01f1: Expected O, but got I
		//IL_01fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0200: Expected O, but got Unknown
		//IL_02ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ef: Expected O, but got Unknown
		//IL_0323: Expected O, but got I4
		//IL_033b: Expected I, but got O
		//IL_0227: Expected I, but got O
		//IL_017e: Expected O, but got I
		//IL_0187: Expected O, but got I4
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Expected O, but got Unknown
		//IL_012e: Expected O, but got I
		//IL_0258: Unknown result type (might be due to invalid IL or missing references)
		//IL_025d: Expected O, but got Unknown
		//IL_0273: Expected O, but got I
		//IL_028d: Expected O, but got I4
		//IL_0296: Expected O, but got I4
		//IL_02a6: Expected I, but got O
		//IL_02b7: Expected O, but got I4
		//IL_03a5: Expected O, but got I4
		//IL_03be: Expected O, but got I4
		object obj = 152989696;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7765]");
		object obj2 = (nint)0 & (nint)1;
		Room room2 = default(Room);
		Room room3;
		if (obj2 != null)
		{
			bool flag = SFSKammelnaRoomExtensions.IsLobby(room2);
			bool flag2 = !flag;
			object obj3 = !flag2;
			room3 = null;
			if (obj3 == null)
			{
				goto IL_0072;
			}
		}
		else
		{
			_ = 1;
			bool flag3 = SFSKammelnaRoomExtensions.IsLobby(room2);
			bool flag4 = !flag3;
			room3 = null;
			if (flag4)
			{
				goto IL_0072;
			}
		}
		object obj4 = typeof(SqlSingle[]) + 2376;
		object obj5 = (nint)0 + (nint)3184;
		object obj6 = "___# Content push apply failed [{0}]: {1}" + 2736;
		GameObject go = base.gameObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj5);
		string text = (string)obj6;
		VariableBinderExtensions.Bind(go, room2, (string)obj6, action);
		object obj7 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1688;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E776A]");
		object obj8 = (nint)0 & (nint)1;
		bool flag5 = obj8 == null;
		object obj9 = !flag5;
		object obj10 = 0;
		Action action2 = action;
		nint num = (nint)obj6;
		room3 = room2;
		object obj11 = 0;
		Action action3 = action;
		object obj12 = obj7;
		if (obj9 != null)
		{
			goto IL_00d9;
		}
		goto IL_02d5;
		IL_0195:
		RecentGiftBombsManager.ResetModels();
		return;
		IL_03cc:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		RecentGiftBombsManager.ResetModels();
		return;
		IL_014e:
		ILeaderboardSource weeklyLeaderboardSource;
		LeaderBoardManager.InvalidateCache(weeklyLeaderboardSource);
		object obj14;
		object obj13 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ X0_v1+E4]");
		bool flag6 = (nint)0 == 0;
		text = (string)num;
		object obj15 = 0;
		if (!flag6)
		{
			goto IL_0195;
		}
		goto IL_03cc;
		IL_0072:
		obj7 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1688;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E776A]");
		object obj16 = (nint)0 & (nint)1;
		bool flag7 = obj16 == null;
		obj11 = obj10;
		action3 = action2;
		text = (string)num;
		obj12 = obj7;
		if (!flag7)
		{
			goto IL_00d9;
		}
		goto IL_02d5;
		IL_02d5:
		_ = 1;
		obj14 = typeof(System.Buffers.Text.ParserHelpers) + 3464;
		weeklyLeaderboardSource = _weeklyLeaderboardSource;
		object obj17 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X0_v4+E4]");
		bool flag8 = (nint)0 == 0;
		object obj18 = !flag8;
		obj10 = obj11;
		action2 = action3;
		num = (nint)text;
		room3 = room3;
		object obj19 = obj14;
		ILeaderboardSource weeklyLeaderboardSource2 = _weeklyLeaderboardSource;
		if (obj18 != null)
		{
			goto IL_014e;
		}
		goto IL_0363;
		IL_00d9:
		obj14 = typeof(System.Buffers.Text.ParserHelpers) + 3464;
		weeklyLeaderboardSource = _weeklyLeaderboardSource;
		obj17 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X0_v4+E4]");
		bool flag9 = (nint)0 == 0;
		obj11 = obj10;
		action3 = action2;
		text = (string)num;
		obj19 = obj14;
		weeklyLeaderboardSource2 = _weeklyLeaderboardSource;
		if (!flag9)
		{
			goto IL_014e;
		}
		goto IL_0363;
		IL_0363:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		LeaderBoardManager.InvalidateCache(weeklyLeaderboardSource2);
		obj13 = obj19;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ X0_v1+E4]");
		bool flag10 = (nint)0 == 0;
		object obj20 = !flag10;
		obj10 = obj11;
		action2 = action3;
		obj15 = 0;
		if (obj20 != null)
		{
			goto IL_0195;
		}
		goto IL_03cc;
	}

	private void OnBombCreated()
	{
		//IL_021c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0221: Expected O, but got Unknown
		//IL_0031: Expected I8, but got I4
		//IL_00de: Expected O, but got I4
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Expected O, but got Unknown
		//IL_0108: Expected O, but got I
		//IL_0254: Unknown result type (might be due to invalid IL or missing references)
		//IL_0259: Expected O, but got Unknown
		//IL_028d: Expected O, but got I4
		//IL_0058: Expected O, but got I
		//IL_01b3: Expected O, but got I4
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Expected O, but got Unknown
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected O, but got Unknown
		//IL_00bf: Expected O, but got I4
		//IL_033e: Expected O, but got I4
		//IL_02ef: Expected O, but got I4
		//IL_02f8: Expected O, but got I4
		Room lobby = SFS.Lobby;
		GiftBombData activeBombInfo = SFSKammelnaRoomExtensions.GetActiveBombInfo(lobby);
		if (activeBombInfo == null)
		{
			goto IL_0216;
		}
		GiftBombData lastGiftBomb = _lastGiftBomb;
		bool flag = _lastGiftBomb == null;
		object obj2 = default(object);
		object obj = obj2;
		long num = 0L;
		if (!flag)
		{
			num = lastGiftBomb.<Id>k__BackingField;
			object obj3 = (nint)0 + (nint)3184;
			obj = obj3;
			long? num2 = lastGiftBomb.<Id>k__BackingField;
			if (activeBombInfo.<Id>k__BackingField == 0)
			{
				object obj4 = (??)num2 & 1;
				bool flag2 = obj4 == null;
				object obj5 = !flag2;
				obj2 = obj3;
				if (obj5 != null)
				{
					goto IL_0216;
				}
			}
		}
		object obj6 = 152989696;
		object obj7 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1688;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E776A]");
		object obj8 = (nint)0 & (nint)1;
		object obj9;
		ILeaderboardSource weeklyLeaderboardSource;
		object obj11;
		ILeaderboardSource weeklyLeaderboardSource2;
		if (obj8 != null)
		{
			obj9 = typeof(System.Buffers.Text.ParserHelpers) + 3464;
			weeklyLeaderboardSource = _weeklyLeaderboardSource;
			object obj10 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ X0_v18+E4]");
			bool flag3 = (nint)0 == 0;
			obj11 = obj9;
			weeklyLeaderboardSource2 = _weeklyLeaderboardSource;
			if (!flag3)
			{
				goto IL_0182;
			}
		}
		else
		{
			_ = 1;
			obj9 = typeof(System.Buffers.Text.ParserHelpers) + 3464;
			weeklyLeaderboardSource = _weeklyLeaderboardSource;
			object obj10 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ X0_v18+E4]");
			bool flag4 = (nint)0 == 0;
			object obj12 = !flag4;
			obj11 = obj9;
			weeklyLeaderboardSource2 = _weeklyLeaderboardSource;
			if (obj12 != null)
			{
				goto IL_0182;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		LeaderBoardManager.InvalidateCache(weeklyLeaderboardSource2);
		object obj13 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v238 @ X0_v13+E4]");
		bool flag5 = (nint)0 == 0;
		object obj14 = !flag5;
		object obj15 = 0;
		if (obj14 != null)
		{
			goto IL_01c1;
		}
		goto IL_0306;
		IL_01c1:
		RecentGiftBombsManager.ResetModels();
		GameObject gameObject = base.gameObject;
		goto IL_01d5;
		IL_0182:
		LeaderBoardManager.InvalidateCache(weeklyLeaderboardSource);
		obj13 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v238 @ X0_v13+E4]");
		bool flag6 = (nint)0 == 0;
		obj15 = 0;
		if (!flag6)
		{
			goto IL_01c1;
		}
		goto IL_0306;
		IL_0306:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		RecentGiftBombsManager.ResetModels();
		gameObject = base.gameObject;
		bool flag7 = (object)gameObject == null;
		object obj16 = !flag7;
		if (obj16 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_01d5;
		IL_0216:
		object obj17 = this + 96;
		obj17 = activeBombInfo;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		PopulateRecentLoaded();
		return;
		IL_01d5:
		bool activeInHierarchy = gameObject.activeInHierarchy;
		bool flag8 = !activeInHierarchy;
		obj2 = obj;
		if (!flag8)
		{
			LoadLeaderboard();
			obj2 = obj;
		}
		goto IL_0216;
	}

	private void LoadLeaderboard()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_00b6: Expected I, but got O
		//IL_0063: Expected O, but got I4
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2536;
		object obj2 = (nint)0 + (nint)3200;
		object obj3 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1688;
		GameObject lifecycle = base.gameObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj2);
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X0_v6+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		LeaderBoardManager.GetLeaderBoard(lifecycle, _weeklyLeaderboardSource, action);
	}

	private void TopWeekLoaded(LeaderboardModel leaderboard)
	{
		//IL_0011: Expected O, but got I
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Expected O, but got Unknown
		//IL_00cc: Expected O, but got I4
		object obj = (nint)0 + (nint)2248;
		List<LeaderBoardPlayer> topPlayers = leaderboard.GetTopPlayers();
		object obj2 = this + 88;
		obj2 = topPlayers;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		if (!Enumerable.Any((IEnumerable<object>)obj2))
		{
			return;
		}
		object obj3 = typeof(MemberAchievementClanFeedData) + 2976;
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X0_v10+E4]");
		if ((nint)0 != 0)
		{
			bool flag = background;
			bool flag2 = !flag;
			object obj5 = !flag2;
			if (obj5 != null)
			{
				goto IL_0117;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			if ((bool)background)
			{
				goto IL_0117;
			}
		}
		goto IL_012c;
		IL_0117:
		background.SetActive(value: true);
		goto IL_012c;
		IL_012c:
		GameObject gameObject = base.gameObject;
		gameObject.SetActive(value: true);
		PopulateTopWeekly();
	}

	private void PopulateTopWeekly()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_026a: Expected I, but got O
		//IL_00c1: Expected O, but got I4
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Expected I4, but got Unknown
		//IL_00ef: Expected O, but got I4
		//IL_0133: Expected O, but got I
		//IL_01a6: Expected O, but got I4
		//IL_01ff: Expected O, but got I
		//IL_0208: Unknown result type (might be due to invalid IL or missing references)
		//IL_020d: Expected O, but got Unknown
		//IL_0216: Unknown result type (might be due to invalid IL or missing references)
		//IL_021b: Expected O, but got Unknown
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2808;
		object obj2 = (nint)0 + (nint)1952;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)null, (IntPtr)obj2);
		ArraysExtensions.ForEach(topWeeklyItems, action);
		NormalPlaceItem[] array = topWeeklyItems;
		if (topWeeklyItems != null)
		{
			IEnumerable<object> source = Enumerable.Take((IEnumerable<object>)_topPlayers, array.Length);
			List<object> list = Enumerable.ToList(source);
			if (list != null)
			{
				if (list._size < 1)
				{
					return;
				}
				object obj3 = 4;
				while (true)
				{
					NormalPlaceItem[] array2 = topWeeklyItems;
					if (topWeeklyItems == null)
					{
						break;
					}
					int num = obj3 - 4;
					bool flag = num < array2.Length;
					object obj4 = !flag;
					if (obj4 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ X8_v9 (NormalPlaceItem[])+v86 @ X24_v6*8]");
						if ((nint)0 == 0)
						{
							break;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ X8_v9 (NormalPlaceItem[])+v86 @ X24_v6*8]");
						GameObject gameObject = ((Component)0).gameObject;
						if ((object)gameObject == null)
						{
							break;
						}
						gameObject.SetActive(value: true);
						NormalPlaceItem[] array3 = topWeeklyItems;
						if (topWeeklyItems == null)
						{
							break;
						}
						bool flag2 = num < array3.Length;
						object obj5 = !flag2;
						if (obj5 == null)
						{
							object player = list.get_Item(num);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ X8_v10 (NormalPlaceItem[])+v86 @ X24_v6*8]");
							if ((nint)0 == 0)
							{
								break;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ X8_v10 (NormalPlaceItem[])+v86 @ X24_v6*8]");
							((NormalPlaceItem)0).Populate((LeaderBoardPlayer)player);
							obj3++;
							object obj6 = obj3 - 4;
							if ((nint)obj6 >= list._size)
							{
								return;
							}
							continue;
						}
					}
					goto IL_024b;
				}
			}
		}
		NullReferenceException ex = new NullReferenceException();
		goto IL_024b;
		IL_024b:
		throw new IndexOutOfRangeException();
	}

	private unsafe void PopulateRecentLoaded()
	{
		//IL_080f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0814: Expected O, but got Unknown
		//IL_0820: Expected O, but got I
		//IL_0257: Expected O, but got I
		//IL_0265: Expected I, but got O
		//IL_0011: Expected O, but got I
		//IL_0029: Expected I, but got O
		//IL_029b: Expected F4, but got I4
		//IL_02a4: Expected O, but got I4
		//IL_0083: Expected F4, but got I4
		//IL_008c: Expected O, but got I4
		//IL_02e1: Expected F4, but got I4
		//IL_02ea: Expected O, but got I4
		//IL_00cb: Expected F4, but got I4
		//IL_00d4: Expected O, but got I4
		//IL_0325: Expected F4, but got I4
		//IL_032e: Expected O, but got I4
		//IL_0116: Expected F4, but got I4
		//IL_011f: Expected O, but got I4
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_0146: Expected O, but got Unknown
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Expected O, but got Unknown
		//IL_0164: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Expected O, but got Unknown
		//IL_0390: Expected F4, but got I4
		//IL_0399: Expected O, but got I4
		//IL_03a2: Expected O, but got I4
		//IL_01c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ca: Expected O, but got Unknown
		//IL_01f4: Expected O, but got I4
		//IL_0201: Expected I8, but got I4
		//IL_0882: Unknown result type (might be due to invalid IL or missing references)
		//IL_0887: Expected O, but got Unknown
		//IL_03c8: Expected O, but got I4
		//IL_0226: Expected I8, but got I4
		//IL_0451: Expected F4, but got I4
		//IL_045a: Expected O, but got I4
		//IL_03de: Expected I, but got O
		//IL_03ee: Expected O, but got I
		//IL_0410: Expected F4, but got I4
		//IL_0419: Expected O, but got I4
		//IL_0429: Expected O, but got I
		//IL_0479: Unknown result type (might be due to invalid IL or missing references)
		//IL_047e: Expected O, but got Unknown
		//IL_04a0: Expected O, but got I4
		//IL_04c6: Expected O, but got Ref
		//IL_0549: Expected O, but got I8
		//IL_0561: Expected F4, but got I4
		//IL_056a: Expected O, but got I4
		//IL_04dc: Expected I, but got O
		//IL_04ec: Expected O, but got I
		//IL_050e: Expected F4, but got I4
		//IL_0517: Expected O, but got I4
		//IL_0527: Expected O, but got I
		//IL_0589: Unknown result type (might be due to invalid IL or missing references)
		//IL_058e: Expected O, but got Unknown
		//IL_05d5: Expected O, but got I4
		//IL_0791: Expected F4, but got I4
		//IL_0615: Expected F4, but got I4
		//IL_061e: Expected O, but got I4
		//IL_062f: Expected O, but got I4
		//IL_065a: Expected O, but got I4
		//IL_06eb: Expected F4, but got I4
		//IL_06f4: Expected O, but got I4
		//IL_0670: Expected I, but got O
		//IL_0680: Expected O, but got I
		//IL_06a2: Expected F4, but got I4
		//IL_06ab: Expected O, but got I4
		//IL_06c3: Expected O, but got I
		//IL_071b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0720: Expected O, but got Unknown
		//IL_0741: Unknown result type (might be due to invalid IL or missing references)
		//IL_0746: Expected O, but got Unknown
		//IL_0762: Expected O, but got I4
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2808;
		object obj2 = (nint)0 + (nint)2216;
		Room lobby = SFS.Lobby;
		GiftBombData activeBombInfo = SFSKammelnaRoomExtensions.GetActiveBombInfo(lobby);
		IndexOutOfRangeException ex = default(IndexOutOfRangeException);
		if (activeBombInfo != null)
		{
			object obj3 = (nint)0 + (nint)3176;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Action<object> action = default(Action<object>);
			action..ctor((object)this, (IntPtr)obj3);
			object[] array = (object[])obj2;
			ArraysExtensions.ForEach(topWeeklyItems, action);
			ShowItem(recentItem, 0.6f);
			LeaderBoardPlayer leaderBoardPlayer = ConvertModel(activeBombInfo);
			bool flag = (object)recentItem == null;
			float num = 1.0586423E+09f;
			object obj4 = 0;
			GiftBombData giftBombData = activeBombInfo;
			if (!flag)
			{
				recentItem.Populate(leaderBoardPlayer);
				bool flag2 = (object)bombInfoText == null;
				num = 1.0586423E+09f;
				obj4 = 0;
				array = null;
				giftBombData = (GiftBombData)(object)leaderBoardPlayer;
				if (!flag2)
				{
					GameObject gameObject = bombInfoText.gameObject;
					bool flag3 = (object)gameObject == null;
					num = 1.0586423E+09f;
					obj4 = 0;
					array = null;
					giftBombData = null;
					if (!flag3)
					{
						object obj5 = "DNQUALIFIER" + 3552;
						object obj6 = "DNQUALIFIER" + 3560;
						object obj7 = typeof(TypeConverter<ushort, char>) + 3400;
						gameObject.SetActive(value: true);
						object obj8 = ((activeBombInfo.<Category>k__BackingField != GiftBombType.Subscription) ? obj6 : obj5);
						string text;
						if (activeBombInfo.<Category>k__BackingField == GiftBombType.Subscription)
						{
							object obj9 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2656;
							object obj10 = obj9;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v387 @ X0_v58+E4]");
							bool flag4 = (nint)0 == 0;
							object obj11 = !flag4;
							long quantity = activeBombInfo.<CurrencyPerShard>k__BackingField;
							if (obj11 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								quantity = activeBombInfo.<CurrencyPerShard>k__BackingField;
							}
							object input = "DNQUALIFIER" + 1456;
							text = LocalizationUtil.Localize((string)input, quantity);
							array = null;
						}
						else
						{
							int num2 = default(int);
							text = num2.ToString();
							array = null;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
						object[] array2 = default(object[]);
						bool flag5 = array2 == null;
						num = 1.0586423E+09f;
						obj4 = 0;
						giftBombData = (GiftBombData)2;
						if (!flag5)
						{
							bool flag6 = text == null;
							GiftBombData giftBombData2 = (GiftBombData)2;
							if (!flag6)
							{
								nint num3 = (nint)array2;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v301 @ X8_v30 (Il2CppClass<System.Object[]>)+40]");
								giftBombData2 = (GiftBombData)0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
								bool flag7 = ex == null;
								num = 1.0586423E+09f;
								obj4 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v301 @ X8_v30 (Il2CppClass<System.Object[]>)+40]");
								giftBombData = (GiftBombData)0;
								if (flag7)
								{
									goto IL_07ea;
								}
							}
							bool flag8 = array2.Length == 0;
							num = 1.0586423E+09f;
							obj4 = 0;
							giftBombData = giftBombData2;
							if (!flag8)
							{
								object obj12 = array2 + 32;
								obj12 = text;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
								object obj13 = 153100288 + 1024;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
								object obj14 = default(object);
								bool flag9 = obj14 == null;
								int num4 = default(int);
								GiftBombData giftBombData3 = (GiftBombData)(&num4);
								if (!flag9)
								{
									nint num5 = (nint)array2;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v302 @ X8_v29 (Il2CppClass<System.Object[]>)+40]");
									giftBombData3 = (GiftBombData)0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
									bool flag10 = ex == null;
									num = 1.0586423E+09f;
									obj4 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v302 @ X8_v29 (Il2CppClass<System.Object[]>)+40]");
									giftBombData = (GiftBombData)0;
									if (flag10)
									{
										goto IL_07ea;
									}
								}
								object obj15 = array2.Length & 0xFFFFFFFEL;
								bool flag11 = obj15 == null;
								num = 1.0586423E+09f;
								obj4 = 0;
								giftBombData = giftBombData3;
								if (!flag11)
								{
									object obj16 = array2 + 40;
									obj16 = obj14;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
									TextMeshProExtensions.Localize(bombInfoText, (string)obj8, array2);
									bool flag12 = activeBombInfo.<Message>k__BackingField == null;
									obj4 = 0;
									array = array2;
									giftBombData = (GiftBombData)obj8;
									if (!flag12)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
										object[] array3 = default(object[]);
										bool flag13 = array3 == null;
										num = 1.0586423E+09f;
										obj4 = 0;
										array = array2;
										giftBombData = (GiftBombData)1;
										if (flag13)
										{
											goto IL_07ce;
										}
										bool flag14 = activeBombInfo.<Message>k__BackingField == null;
										GiftBombData giftBombData4 = (GiftBombData)1;
										if (!flag14)
										{
											nint num6 = (nint)array3;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v303 @ X8_v28 (Il2CppClass<System.Object[]>)+40]");
											giftBombData4 = (GiftBombData)0;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
											bool flag15 = ex == null;
											num = 1.0586423E+09f;
											obj4 = 0;
											array = array2;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v303 @ X8_v28 (Il2CppClass<System.Object[]>)+40]");
											giftBombData = (GiftBombData)0;
											if (flag15)
											{
												goto IL_07ea;
											}
										}
										bool flag16 = array3.Length == 0;
										num = 1.0586423E+09f;
										obj4 = 0;
										array = array2;
										giftBombData = giftBombData4;
										if (flag16)
										{
											goto IL_07dc;
										}
										object obj17 = array3 + 32;
										obj17 = activeBombInfo.<Message>k__BackingField;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
										object obj18 = "AvailableVoices" + 2408;
										TextMeshProExtensions.Localize(bombMessageText, (string)obj18, array3);
										obj4 = 0;
										array = array3;
										giftBombData = (GiftBombData)obj18;
									}
									bool flag17 = (object)bombMessage == null;
									num = 1.0586423E+09f;
									if (!flag17)
									{
										bool flag18 = activeBombInfo.<Message>k__BackingField == null;
										bool active = !flag18;
										bombMessage.SetActive(active);
										return;
									}
									goto IL_07ce;
								}
							}
							goto IL_07dc;
						}
					}
				}
			}
		}
		else
		{
			HideItem(recentItem, 0.3f);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj19 = (nint)0 + (nint)3168;
			Action<object> action2 = default(Action<object>);
			action2..ctor((object)this, (IntPtr)obj19);
			object[] array = (object[])obj2;
			ArraysExtensions.ForEach(topWeeklyItems, action2);
			bool flag19 = (object)bombInfoText == null;
			float num = 1.0502537E+09f;
			object obj4 = 0;
			GiftBombData giftBombData = (GiftBombData)(object)action2;
			if (!flag19)
			{
				GameObject gameObject2 = bombInfoText.gameObject;
				bool flag20 = (object)gameObject2 == null;
				num = 1.0502537E+09f;
				obj4 = 0;
				giftBombData = null;
				if (!flag20)
				{
					gameObject2.SetActive(value: false);
					bool flag21 = (object)bombMessage == null;
					num = 1.0502537E+09f;
					obj4 = 0;
					array = null;
					giftBombData = null;
					if (!flag21)
					{
						bombMessage.SetActive(value: false);
						return;
					}
				}
			}
		}
		goto IL_07ce;
		IL_07ce:
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_07dc;
		IL_07dc:
		ex = new IndexOutOfRangeException();
		goto IL_07ea;
		IL_07ea:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		throw new OutOfMemoryException();
	}

	private void ShowItem(NormalPlaceItem item, float delay = 0f)
	{
		//IL_0096: Expected O, but got I
		int instanceID = item.GetInstanceID();
		object obj = ((Dictionary<int, object>)(object)_canvasGroups).get_Item(instanceID);
		if (!((CanvasGroup)obj).interactable)
		{
			((CanvasGroup)obj).interactable = true;
			((CanvasGroup)obj).blocksRaycasts = true;
			((CanvasGroup)obj).alpha = 0f;
			object obj2 = (nint)0 + (nint)2752;
			int num = ShortcutExtensions.DOKill((Component)obj);
			TweenerCore<float, float, FloatOptions> tweenerCore = DOTweenModuleUI.DOFade((CanvasGroup)obj, 1f, 0.4f);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058C78");
		}
	}

	private void HideItem(NormalPlaceItem item, float delay = 0f)
	{
		//IL_0095: Expected O, but got I
		int instanceID = item.GetInstanceID();
		object obj = ((Dictionary<int, object>)(object)_canvasGroups).get_Item(instanceID);
		if (((CanvasGroup)obj).interactable)
		{
			((CanvasGroup)obj).interactable = false;
			((CanvasGroup)obj).blocksRaycasts = false;
			((CanvasGroup)obj).alpha = 1f;
			object obj2 = (nint)0 + (nint)2752;
			int num = ShortcutExtensions.DOKill((Component)obj);
			TweenerCore<float, float, FloatOptions> tweenerCore = DOTweenModuleUI.DOFade((CanvasGroup)obj, 0f, 0.4f);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058C78");
		}
	}

	private void SetCanvasGroupVisibility(CanvasGroup canvas, bool isVisible)
	{
		//IL_0039: Expected O, but got I4
		//IL_0059: Expected F4, but got I4
		canvas.interactable = isVisible;
		canvas.blocksRaycasts = isVisible;
		bool flag = !isVisible;
		object obj = !flag;
		object obj2 = ~obj;
		float alpha = ((obj2 != null) ? 1f : 0f);
		canvas.alpha = alpha;
	}

	private void FadeCanvas(CanvasGroup canvas, float endValue, float delay)
	{
		//IL_000c: Expected O, but got I
		object obj = (nint)0 + (nint)2752;
		int num = ShortcutExtensions.DOKill(canvas);
		TweenerCore<float, float, FloatOptions> tweenerCore = DOTweenModuleUI.DOFade(canvas, endValue, 0.4f);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058C78");
	}

	private LeaderBoardPlayer ConvertModel(GiftBombData data)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected O, but got Unknown
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Expected O, but got Unknown
		object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1696;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		LeaderBoardPlayer leaderBoardPlayer = default(LeaderBoardPlayer);
		leaderBoardPlayer..ctor();
		if (data != null && leaderBoardPlayer != null)
		{
			leaderBoardPlayer.LastPoints = data.<TotalCost>k__BackingField;
			PlayerInfo <Creator>k__BackingField = data.<Creator>k__BackingField;
			if (data.<Creator>k__BackingField != null)
			{
				object obj2 = leaderBoardPlayer + 48;
				obj2 = <Creator>k__BackingField.<Name>k__BackingField;
				_ = <Creator>k__BackingField.<DBID>k__BackingField;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				PlayerInfo <Creator>k__BackingField2 = data.<Creator>k__BackingField;
				if (data.<Creator>k__BackingField != null)
				{
					object obj3 = leaderBoardPlayer + 64;
					obj3 = <Creator>k__BackingField2.<ActiveGameTitle>k__BackingField;
					_ = <Creator>k__BackingField2.<ActiveCardBack>k__BackingField;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					PlayerInfo <Creator>k__BackingField3 = data.<Creator>k__BackingField;
					if (data.<Creator>k__BackingField != null)
					{
						leaderBoardPlayer.AvatarDate = <Creator>k__BackingField3.<AvatarDate>k__BackingField;
						PlayerInfo <Creator>k__BackingField4 = data.<Creator>k__BackingField;
						if (data.<Creator>k__BackingField != null)
						{
							leaderBoardPlayer.IsSubscribed = <Creator>k__BackingField4.<IsSubscribed>k__BackingField;
							return leaderBoardPlayer;
						}
					}
				}
			}
		}
		return (LeaderBoardPlayer)(object)new NullReferenceException();
	}

	private void InvalidateBomberLeaderboards()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Expected O, but got Unknown
		//IL_0140: Expected O, but got I4
		//IL_00de: Expected O, but got I4
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected O, but got Unknown
		//IL_01a2: Expected O, but got I4
		//IL_01ab: Expected O, but got I4
		object obj = 152989696;
		object obj2 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1688;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E776A]");
		object obj3 = (nint)0 & (nint)1;
		object obj4;
		ILeaderboardSource weeklyLeaderboardSource;
		object obj6;
		ILeaderboardSource weeklyLeaderboardSource2;
		if (obj3 != null)
		{
			obj4 = typeof(System.Buffers.Text.ParserHelpers) + 3464;
			weeklyLeaderboardSource = _weeklyLeaderboardSource;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v4+E4]");
			bool flag = (nint)0 == 0;
			obj6 = obj4;
			weeklyLeaderboardSource2 = _weeklyLeaderboardSource;
			if (!flag)
			{
				goto IL_00ad;
			}
		}
		else
		{
			_ = 1;
			obj4 = typeof(System.Buffers.Text.ParserHelpers) + 3464;
			weeklyLeaderboardSource = _weeklyLeaderboardSource;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v4+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj6 = obj4;
			weeklyLeaderboardSource2 = _weeklyLeaderboardSource;
			if (obj7 != null)
			{
				goto IL_00ad;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		LeaderBoardManager.InvalidateCache(weeklyLeaderboardSource2);
		object obj8 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X0_v1+E4]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		object obj10 = 0;
		if (obj9 != null)
		{
			goto IL_00ec;
		}
		goto IL_01b9;
		IL_00ec:
		RecentGiftBombsManager.ResetModels();
		return;
		IL_01b9:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		RecentGiftBombsManager.ResetModels();
		return;
		IL_00ad:
		LeaderBoardManager.InvalidateCache(weeklyLeaderboardSource);
		obj8 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X0_v1+E4]");
		bool flag4 = (nint)0 == 0;
		obj10 = 0;
		if (!flag4)
		{
			goto IL_00ec;
		}
		goto IL_01b9;
	}

	private void <PopulateRecentLoaded>b__22_0(NormalPlaceItem weeklyItem)
	{
		ShowItem(weeklyItem, 0.6f);
	}

	private void <PopulateRecentLoaded>b__22_1(NormalPlaceItem weeklyItem)
	{
		HideItem(weeklyItem, 0.3f);
	}
}
