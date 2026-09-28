using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Threading;
using Cpp2ILInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using DataTracking;
using Features.GameReplay;
using HuaweiMobileServices.Location.Location;
using Kammelna.Server;
using Kammelna.Server.Models.Clans;
using Microsoft.Extensions.DependencyInjection.ServiceLookup;
using Newtonsoft.Json.Linq.JsonPath;
using Server.Models;
using Sfs2X.Entities;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.InputSystem.XR;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.Rendering;
using UnityEngine.TextCore;
using UnityEngine.UI;

public class GameEndPopup : MonoBehaviour
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Action<GameEndWidget> <>9__27_0;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(DebugUI.BitField) + 3976;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal void <Animate>b__27_0(GameEndWidget w)
		{
			//IL_0008: Expected I, but got O
			//IL_0018: Expected O, but got I
			//IL_0028: Expected O, but got I
			nint num = (nint)w;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2 @ X8_v1 (Il2CppClass<GameEndWidget>)+1B8]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2 @ X8_v1 (Il2CppClass<GameEndWidget>)+1C0]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v3 @ X2_v1 (should have been resolved before IL gen)");
			/*Error: End of method reached without returning.*/;
		}
	}

	private sealed class <>c__DisplayClass27_0
	{
		public CardGameEndScores rankReport;

		internal bool <Animate>b__1(GameEndWidget w)
		{
			//IL_0067: Expected I4, but got O
			//IL_002f: Expected I, but got O
			//IL_003f: Expected O, but got I
			//IL_004f: Expected O, but got I
			if ((object)w != null)
			{
				CardGameEndScores cardGameEndScores = rankReport;
				nint num = (nint)w;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4 @ X9_v1 (Il2CppClass<GameEndWidget>)+1A8]");
				object obj = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4 @ X9_v1 (Il2CppClass<GameEndWidget>)+1B0]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v5 @ X3_v1 (should have been resolved before IL gen)");
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private sealed class <>c__DisplayClass47_0
	{
		public bool skipAd;

		internal void <PlayRanked>b__3()
		{
			SFS.RankedMatch(skipAd);
		}
	}

	private PopupUI popup;

	private GameEndWidget gameScoreWidget;

	private GameEndWidget[] Widgets;

	protected GameEventsChannel gameEventsChannel;

	private GenericSoundAlbum soundAlbum;

	public LayoutElement AvatarSection;

	public RectTransform BodySection;

	public LayoutElement ButtonsSection;

	public LayoutElement CongratsSection;

	public RankedPlayManager playManager;

	public Button nextGameButton;

	public Button leaveButton;

	protected Button saveGameButton;

	private DiscreteProgressIndicator replayFreeTrailsIndicator;

	private PrefabInitializer gameSavedPopup;

	private BaseToggler saveButtonTextToggler;

	protected HintsPopup hintsPopup;

	private AssetReferenceGameObject notEnoughAcesToPlayRankedRef;

	protected CardGame game;

	private Sequence animationSequence;

	private int Team1Score;

	private int Team2Score;

	private int TestPointsBefore;

	private int TestPointsAfter;

	private int TestHighlightsCount;

	private int TestAchievementsCount;

	private int TestStreakPercentage;

	private TournamentEndGameReport tReport;

	private PlayerPerformance playerPerformance;

	private CheatingPerformance cheatingPerformance;

	private PlayerPerformance overallPerformance;

	private bool IsFriendly
	{
		get
		{
			//IL_00ac: Expected I4, but got O
			//IL_002e: Expected I4, but got O
			if ((object)game != null)
			{
				bool flag = (byte)(int)game.Room != 0;
				if (!flag)
				{
					return flag;
				}
				if ((object)game != null)
				{
					Room room = game.Room;
					GameType gameType = SFSKammelnaRoomExtensions.GetGameType(room);
					return GameTypeExtensions.IsFriendly(gameType);
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private bool AnimateAvatarSection
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0067: Expected O, but got I4
			object obj = typeof(MemberAchievementClanFeedData) + 2976;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			return AvatarSection != null;
		}
	}

	protected virtual void Start()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0173: Expected O, but got I
		//IL_017f: Expected O, but got I
		//IL_018e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0193: Expected O, but got Unknown
		//IL_01bd: Expected O, but got I4
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected O, but got Unknown
		//IL_008f: Expected I, but got O
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Expected O, but got Unknown
		//IL_00ca: Expected O, but got I
		//IL_00f4: Expected I, but got O
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Expected O, but got Unknown
		//IL_0137: Expected O, but got I
		//IL_014f: Expected I, but got O
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		object obj2 = (nint)0 + (nint)24;
		object obj3 = (nint)0 + (nint)104;
		object obj4 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1376;
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE90D8");
		object obj7 = this + 176;
		object obj8 = default(object);
		obj7 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE90D8");
		object obj9 = this + 160;
		object obj10 = default(object);
		obj9 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		nint num = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X8_v4 (Il2CppClass<GameEndPopup>)+190]");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)0);
		object obj11 = typeof(SqlSingle[]) + 2376;
		object obj12 = (nint)0 + (nint)184;
		((CardGame)obj7).OnCardGameEnd += action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action2 = default(Action);
		action2..ctor(this, (IntPtr)obj12);
		gameEventsChannel.CloseEndGamePopup += action2;
		Button button = saveGameButton;
		object obj13 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
		object obj14 = (nint)0 + (nint)200;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction = default(UnityAction);
		unityAction..ctor(this, (IntPtr)obj14);
		button.m_OnClick.AddListener(unityAction);
	}

	protected virtual void OnGameEnd(CardGameEndScores rankReport)
	{
		//IL_003e: Expected O, but got I4
		saveButtonTextToggler.ToggleManual(isON: false);
		bool isFastTrackGame = game.IsFastTrackGame;
		bool flag = !isFastTrackGame;
		object obj = !flag;
		if (obj != null)
		{
			return;
		}
		Room room = game.Room;
		if (room != null)
		{
			Room room2 = game.Room;
			if (!SFSKammelnaRoomExtensions.IsOffline(room2))
			{
				Popup(rankReport);
			}
		}
	}

	protected void Popup(CardGameEndScores rankReport)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		popup.PopFromCenter();
		Animate(rankReport);
		ITrackEvent trackEvent = TrackerLibrary.EndGamePopupViewed();
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X8_v3+E4]");
		if ((nint)0 != 0)
		{
			Tracker.DesignEvent(trackEvent);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Tracker.DesignEvent(trackEvent);
	}

	private unsafe void Animate(CardGameEndScores rankReport)
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected O, but got Unknown
		//IL_0087: Expected O, but got I4
		//IL_1af3: Expected O, but got I
		//IL_1b02: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b07: Expected O, but got Unknown
		//IL_1b13: Expected O, but got I
		//IL_1b1f: Expected O, but got I
		//IL_1b3f: Expected O, but got I
		//IL_1b61: Expected O, but got I4
		//IL_267f: Expected I, but got O
		//IL_013d: Expected I, but got O
		//IL_00bc: Expected O, but got I
		//IL_00de: Expected O, but got I4
		//IL_1b7e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b83: Expected O, but got Unknown
		//IL_1b99: Expected O, but got I
		//IL_1baa: Expected I, but got O
		//IL_1baa: Expected O, but got I
		//IL_1bb2: Expected I, but got O
		//IL_1bc8: Expected O, but got I
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_019f: Expected O, but got Unknown
		//IL_01a7: Expected I, but got O
		//IL_01b7: Expected O, but got I
		//IL_011f: Expected O, but got I
		//IL_0286: Expected I, but got O
		//IL_1c3e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c43: Expected O, but got Unknown
		//IL_1c52: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c57: Expected O, but got Unknown
		//IL_1c66: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c6b: Expected O, but got Unknown
		//IL_1c7a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c7f: Expected O, but got Unknown
		//IL_1c8f: Expected O, but got I
		//IL_01f2: Expected O, but got I
		//IL_1bef: Expected O, but got I
		//IL_1c01: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c06: Expected O, but got Unknown
		//IL_17b0: Expected O, but got I4
		//IL_029b: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a0: Expected O, but got Unknown
		//IL_02a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ae: Expected O, but got Unknown
		//IL_02cb: Expected I, but got O
		//IL_02db: Expected O, but got I
		//IL_0208: Unknown result type (might be due to invalid IL or missing references)
		//IL_020d: Expected O, but got Unknown
		//IL_0223: Expected O, but got I
		//IL_022e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0233: Expected O, but got Unknown
		//IL_03aa: Expected I, but got O
		//IL_1cfe: Expected I, but got O
		//IL_1d0e: Expected O, but got I
		//IL_1d21: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d26: Expected O, but got Unknown
		//IL_0316: Expected O, but got I
		//IL_1cb6: Expected O, but got I
		//IL_1cc8: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ccd: Expected O, but got Unknown
		//IL_1e08: Expected O, but got I4
		//IL_1e11: Expected O, but got I4
		//IL_03bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c4: Expected O, but got Unknown
		//IL_03cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d2: Expected O, but got Unknown
		//IL_058b: Expected I, but got O
		//IL_059b: Expected O, but got I
		//IL_17e8: Expected O, but got I4
		//IL_032c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0331: Expected O, but got Unknown
		//IL_0347: Expected O, but got I
		//IL_0352: Unknown result type (might be due to invalid IL or missing references)
		//IL_0357: Expected O, but got Unknown
		//IL_0646: Expected I, but got O
		//IL_040c: Expected I, but got O
		//IL_041c: Expected O, but got I
		//IL_1e60: Expected I, but got O
		//IL_1e70: Expected O, but got I
		//IL_05d6: Expected O, but got I
		//IL_04eb: Expected I, but got O
		//IL_1e34: Expected O, but got I
		//IL_1d9b: Expected I, but got O
		//IL_1dab: Expected O, but got I
		//IL_0457: Expected O, but got I
		//IL_065b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0660: Expected O, but got Unknown
		//IL_0669: Unknown result type (might be due to invalid IL or missing references)
		//IL_066e: Expected O, but got Unknown
		//IL_1820: Expected O, but got I4
		//IL_1d53: Expected O, but got I
		//IL_1d65: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d6a: Expected O, but got Unknown
		//IL_05ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f1: Expected O, but got Unknown
		//IL_0607: Expected O, but got I
		//IL_0538: Expected I, but got O
		//IL_0548: Expected O, but got I
		//IL_0500: Unknown result type (might be due to invalid IL or missing references)
		//IL_0505: Expected O, but got Unknown
		//IL_050e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0513: Expected O, but got Unknown
		//IL_046d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0472: Expected O, but got Unknown
		//IL_0488: Expected O, but got I
		//IL_0493: Unknown result type (might be due to invalid IL or missing references)
		//IL_0498: Expected O, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E679B]");
		nint num = 0;
		object obj = typeof(DebugUI.BitField) + 3984;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		bool flag = obj2 == null;
		object obj3 = null;
		Func<object, bool> func = null;
		object obj4 = obj2;
		object obj6;
		object obj5;
		object obj11;
		object obj10;
		Transform transform;
		bool flag8 = default(bool);
		nint num2;
		if (!flag)
		{
			obj5 = typeof(DebugUI.BitField) + 3976;
			obj6 = obj2 + 16;
			obj6 = rankReport;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj7 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v343 @ X0_v33+E4]");
			bool flag2 = (nint)0 == 0;
			object obj8 = !flag2;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj7 = obj5;
			}
			object obj9 = (nint)0 + (nint)2152;
			obj10 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 1320;
			obj11 = (nint)0 + (nint)1496;
			transform = (Transform)((nint)0 + (nint)3456);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v343 @ X0_v33+B8]");
			num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v423 @ X8_v3 (Il2CppClass<UnityEngine.UI.LayoutElement>)+8]");
			Action<object> action = (Action<object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v423 @ X8_v3 (Il2CppClass<UnityEngine.UI.LayoutElement>)+8]");
			bool flag3 = (nint)0 == 0;
			object obj12 = !flag3;
			bool flag5;
			if (obj12 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v343 @ X0_v33+E4]");
				object obj13 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v343 @ X0_v33+E4]");
				bool flag4 = (nint)0 == 0;
				object obj14 = !flag4;
				if (obj14 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					object obj15 = obj5;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v483 @ X8_v188+B8]");
					num = 0;
				}
				object obj16 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2072;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj17 = (nint)0 + (nint)1488;
				Action<object> action2 = default(Action<object>);
				action2..ctor((object)num, (IntPtr)obj17);
				num = (nint)obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v423 @ X8_v3 (Il2CppClass<UnityEngine.UI.LayoutElement>)+B8]");
				object obj18 = (nint)0 + (nint)8;
				obj18 = action2;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				transform = (Transform)((nint)0 + (nint)3456);
				flag5 = false;
				action = action2;
			}
			ArraysExtensions.ForEach(Widgets, action);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Func<object, bool> func2 = default(Func<object, bool>);
			func2..ctor(obj2, (IntPtr)obj11);
			num2 = (nint)transform;
			IEnumerable<object> enumerable = Enumerable.Where(Widgets, func2);
			bool flag6 = enumerable == null;
			obj3 = null;
			flag5 = false;
			func = func2;
			obj4 = obj2;
			if (!flag6)
			{
				object obj19 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 3200;
				nint num3 = (nint)enumerable;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v518 @ X8_v20 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+12E]");
				object obj13 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v518 @ X8_v20 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_0277;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v518 @ X8_v20 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+B0]");
				object obj20 = (nint)0 + (nint)8;
				bool flag7 = flag8;
				object obj23;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v691 @ X10_v58-8]");
					object obj21 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v691 @ X10_v58-8]");
					object obj22 = 0 - obj19;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v691 @ X10_v58-8]");
					if (0 == (nint)obj19)
					{
						break;
					}
					obj23 = obj20 + 16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v518 @ X8_v20 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+12E]");
					obj13 = -1;
					obj22 = obj13 - 1;
					bool flag9 = obj22 == null;
					flag8 = (nint)obj13 != 1;
					flag7 = flag8;
					obj20 = obj23;
					if (flag8)
					{
						continue;
					}
					goto IL_0277;
				}
				obj13 = obj20;
				object obj24 = num3 + obj20;
				object obj25 = obj24 + 312;
				flag8 = flag7;
				obj23 = obj20;
				goto IL_1c2f;
			}
		}
		goto IL_1adc;
		IL_1c2f:
		obj5 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2528;
		obj11 = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 576;
		obj10 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2344;
		transform = (Transform)(typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3848);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v832 @ X0_v40+8]");
		func = (Func<object, bool>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v832 @ X0_v40] (should have been resolved before IL gen)");
		num = (nint)(&obj3);
		object obj26 = default(object);
		object obj29 = default(object);
		object obj31 = default(object);
		object obj33 = default(object);
		object obj36 = default(object);
		UIBehaviour uIBehaviour = default(UIBehaviour);
		while (true)
		{
			object obj23;
			object obj13;
			if (obj26 != null)
			{
				nint num4 = (nint)obj26;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v916 @ X8_v26 (Il2CppClass<System.Object>)+12E]");
				obj13 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v916 @ X8_v26 (Il2CppClass<System.Object>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_039b;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v916 @ X8_v26 (Il2CppClass<System.Object>)+B0]");
				object obj27 = (nint)0 + (nint)8;
				bool flag10 = flag8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v964 @ X10_v53-8]");
					object obj21 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v964 @ X10_v53-8]");
					object obj22 = 0 - obj5;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v964 @ X10_v53-8]");
					if (0 == (nint)obj5)
					{
						break;
					}
					obj23 = obj27 + 16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v916 @ X8_v26 (Il2CppClass<System.Object>)+12E]");
					obj13 = -1;
					obj22 = obj13 - 1;
					bool flag9 = obj22 == null;
					flag8 = (nint)obj13 != 1;
					flag10 = flag8;
					obj27 = obj23;
					if (flag8)
					{
						continue;
					}
					goto IL_039b;
				}
				obj13 = obj27;
				object obj28 = num4 + obj27;
				obj29 = obj28 + 312;
				flag8 = flag10;
				obj23 = obj27;
				goto IL_1cf6;
			}
			NullReferenceException ex = new NullReferenceException();
			nint num5 = (nint)(&obj3);
			obj3 = obj26;
			object obj30 = 0;
			bool flag5 = false;
			obj4 = obj26;
			break;
			IL_1def:
			num5 = (nint)(&obj3);
			obj3 = obj26;
			obj30 = 0;
			object obj9 = 5;
			flag5 = false;
			obj4 = null;
			throw new OutOfMemoryException();
			IL_0637:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			num2 = unchecked((nint)null);
			goto IL_1e58;
			IL_1e58:
			num = (nint)obj31;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1187 @ X0_v218+8]");
			func = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1187 @ X0_v218] (should have been resolved before IL gen)");
			goto IL_1def;
			IL_04dc:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			num2 = unchecked((nint)null);
			goto IL_1d93;
			IL_039b:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			num2 = unchecked((nint)null);
			goto IL_1cf6;
			IL_1cf6:
			num = (nint)obj29;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1039 @ X0_v46+8]");
			func = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1039 @ X0_v46] (should have been resolved before IL gen)");
			object obj32 = obj33 & 1;
			if (obj32 != null)
			{
				if (obj26 != null)
				{
					nint num6 = (nint)obj26;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1047 @ X8_v175 (Il2CppClass<System.Object>)+12E]");
					obj13 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1047 @ X8_v175 (Il2CppClass<System.Object>)+12E]");
					if ((nint)0 == 0)
					{
						goto IL_04dc;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1047 @ X8_v175 (Il2CppClass<System.Object>)+B0]");
					object obj34 = (nint)0 + (nint)8;
					bool flag11 = flag8;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1141 @ X10_v48-8]");
						object obj21 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1141 @ X10_v48-8]");
						object obj22 = 0 - obj11;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1141 @ X10_v48-8]");
						if (0 == (nint)obj11)
						{
							break;
						}
						obj23 = obj34 + 16;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1047 @ X8_v175 (Il2CppClass<System.Object>)+12E]");
						obj13 = -1;
						obj22 = obj13 - 1;
						bool flag9 = obj22 == null;
						flag8 = (nint)obj13 != 1;
						flag11 = flag8;
						obj34 = obj23;
						if (flag8)
						{
							continue;
						}
						goto IL_04dc;
					}
					obj13 = obj34;
					object obj35 = num6 + obj34;
					obj36 = obj35 + 312;
					flag8 = flag11;
					obj23 = obj34;
					goto IL_1d93;
				}
				NullReferenceException ex2 = new NullReferenceException();
				num5 = (nint)(&obj3);
				obj3 = obj26;
				obj30 = 0;
				flag5 = false;
				obj4 = obj26;
				break;
			}
			if (obj26 == null)
			{
				goto IL_1def;
			}
			nint num7 = (nint)obj26;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1051 @ X8_v171 (Il2CppClass<System.Object>)+12E]");
			obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1051 @ X8_v171 (Il2CppClass<System.Object>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0637;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1051 @ X8_v171 (Il2CppClass<System.Object>)+B0]");
			object obj37 = (nint)0 + (nint)8;
			bool flag12 = flag8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1162 @ X10_v42-8]");
				object obj21 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1162 @ X10_v42-8]");
				if (0 == (nint)obj10)
				{
					break;
				}
				obj23 = obj37 + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1051 @ X8_v171 (Il2CppClass<System.Object>)+12E]");
				obj13 = -1;
				flag8 = (nint)obj13 != 1;
				flag12 = flag8;
				obj37 = obj23;
				if (flag8)
				{
					continue;
				}
				goto IL_0637;
			}
			obj13 = obj37;
			object obj38 = num7 + obj37;
			obj31 = obj38 + 312;
			flag8 = flag12;
			obj23 = obj37;
			goto IL_1e58;
			IL_1d93:
			num = (nint)obj36;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1179 @ X0_v225+8]");
			func = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1179 @ X0_v225] (should have been resolved before IL gen)");
			if ((object)uIBehaviour != null)
			{
				func = (Func<object, bool>)obj6;
				num = (nint)uIBehaviour;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v423 @ X8_v3 (Il2CppClass<UnityEngine.UI.LayoutElement>)+178]");
				obj13 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v423 @ X8_v3 (Il2CppClass<UnityEngine.UI.LayoutElement>)+180]");
				num2 = 0;
				uIBehaviour.Awake();
				continue;
			}
			NullReferenceException ex3 = new NullReferenceException();
			num5 = (nint)(&obj3);
			obj3 = obj26;
			obj30 = 0;
			flag5 = false;
			obj4 = obj26;
			break;
		}
		goto IL_1adc;
		IL_1adc:
		throw new NullReferenceException();
		IL_0277:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		num2 = unchecked((nint)null);
		goto IL_1c2f;
	}

	public void SetSequenceSpeed(float speed)
	{
		Sequence sequence = animationSequence;
		if (animationSequence != null)
		{
			sequence.timeScale = speed;
		}
	}

	public void AnimatePointsSliderTest()
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_004a: Expected O, but got I
		//IL_005d: Expected O, but got I4
		PopupUI popupUI = popup;
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 336;
		object obj2 = typeof(UsageHint) + 816;
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X8_v9+B8]");
		object obj4 = 0;
		popupUI.content.localScale = (Vector3)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		CardGameEndScores cardGameEndScores = default(CardGameEndScores);
		cardGameEndScores..ctor();
		cardGameEndScores.TestPopulate(Team1Score, Team2Score, TestPointsBefore, TestPointsAfter, TestHighlightsCount, TestAchievementsCount, TestStreakPercentage, PlayerPerformance.Weak, CheatingPerformance.Focus, PlayerPerformance.Weak);
		Popup(cardGameEndScores);
	}

	private void EnableButtons()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_010a: Expected O, but got I4
		//IL_00b4: Expected O, but got I4
		//IL_03d4: Expected O, but got I4
		//IL_03dd: Expected O, but got I4
		//IL_00cb: Expected O, but got I4
		//IL_0152: Expected O, but got I4
		//IL_0250: Expected O, but got I4
		//IL_0259: Expected O, but got I4
		//IL_049d: Expected O, but got I4
		//IL_04b3: Expected O, but got I4
		//IL_04c9: Expected O, but got I4
		//IL_04d2: Expected O, but got I4
		//IL_0425: Expected O, but got I4
		//IL_02db: Expected O, but got I4
		//IL_01e7: Expected O, but got I4
		//IL_0557: Unknown result type (might be due to invalid IL or missing references)
		//IL_055c: Expected O, but got Unknown
		//IL_0590: Expected O, but got I4
		//IL_05a1: Expected O, but got I4
		//IL_037a: Expected O, but got I4
		//IL_0309: Unknown result type (might be due to invalid IL or missing references)
		//IL_030e: Expected O, but got Unknown
		//IL_05fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0603: Expected O, but got Unknown
		//IL_060f: Expected O, but got I
		//IL_0646: Expected O, but got I4
		//IL_06f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f6: Expected O, but got Unknown
		//IL_0720: Expected O, but got I4
		object obj = 152985600;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6768]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj6;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v66+E4]");
			bool flag = (nint)0 == 0;
			obj5 = playManager;
			obj6 = playManager;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			obj5 = playManager;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v66+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj6 = playManager;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = obj6;
		bool flag4 = !flag3;
		object obj8 = 0;
		if (!flag4)
		{
			goto IL_0160;
		}
		goto IL_01ec;
		IL_0538:
		leaveButton.interactable = true;
		object obj9 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2160;
		Button button = saveGameButton;
		object obj10 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v320 @ X0_v21+E4]");
		bool flag5 = (nint)0 == 0;
		object obj11 = !flag5;
		double num2;
		double num = num2;
		object obj12 = 0;
		bool flag6 = true;
		Button button2 = saveGameButton;
		if (obj11 != null)
		{
			goto IL_0357;
		}
		goto IL_05c2;
		IL_02b8:
		UnityEngine.Object obj13;
		bool flag7 = obj13;
		bool flag8 = !flag7;
		object obj14 = !flag8;
		flag6 = false;
		num2 = num;
		if (obj14 == null)
		{
			goto IL_02fa;
		}
		goto IL_0538;
		IL_04ea:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		UnityEngine.Object obj15;
		bool flag9 = obj15;
		bool flag10 = !flag9;
		num = num2;
		object obj16;
		obj12 = obj16;
		flag6 = false;
		if (flag10)
		{
			goto IL_02fa;
		}
		goto IL_0538;
		IL_0091:
		bool flag11 = obj5;
		bool flag12 = !flag11;
		object obj17 = !flag12;
		if (obj17 != null)
		{
			goto IL_0160;
		}
		obj8 = 0;
		goto IL_01ec;
		IL_0160:
		Room room = game.Room;
		if (room != null)
		{
			Room room2 = game.Room;
			GameType gameType = SFSKammelnaRoomExtensions.GetGameType(room2);
			if (GameTypeExtensions.IsFriendly(gameType))
			{
				playManager.ShowFriendlyState();
				obj8 = 0;
				goto IL_01ec;
			}
		}
		playManager.ShowRankedState();
		UnityEngine.Object obj18 = nextGameButton;
		object obj19 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ X8_v19+E4]");
		bool flag13 = (nint)0 == 0;
		object obj20 = !flag13;
		obj8 = 0;
		UnityEngine.Object obj21 = nextGameButton;
		if (obj20 != null)
		{
			goto IL_022d;
		}
		goto IL_03f5;
		IL_0357:
		bool saveExists = GameReplayManager.SaveExists;
		bool flag14 = (object)button == null;
		object obj22 = !flag14;
		Selectable selectable = button;
		if (obj22 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_05ef;
		IL_05c2:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		saveExists = GameReplayManager.SaveExists;
		num = num2;
		selectable = button2;
		goto IL_05ef;
		IL_05ef:
		object obj23 = typeof(Queue<string>) + 848;
		object obj24 = (nint)0 + (nint)2200;
		selectable.interactable = saveExists;
		object obj25 = obj23;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v337 @ X0_v5+E4]");
		bool flag15 = (nint)0 == 0;
		object obj26 = !flag15;
		if (obj26 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel = default(SessionModel);
		User localUser = sessionModel.LocalUser;
		if (SFSKammelnaUserExtensions.IsSubscribed(localUser))
		{
			GameObject gameObject = replayFreeTrailsIndicator.gameObject;
			gameObject.SetActive(value: false);
			return;
		}
		replayFreeTrailsIndicator.MaxProgress = 2;
		object obj27 = typeof(System.Buffers.Text.ParserHelpers) + 1624;
		object obj28 = obj27;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v349 @ X0_v12+E4]");
		bool flag16 = (nint)0 == 0;
		object obj29 = !flag16;
		if (obj29 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		int usedReplayTrails = Preferences.UsedReplayTrails;
		int currentProgress = 2 - usedReplayTrails;
		replayFreeTrailsIndicator.CurrentProgress = currentProgress;
		replayFreeTrailsIndicator.ManualInit();
		return;
		IL_02fa:
		object obj30 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2160;
		button = saveGameButton;
		obj10 = obj30;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v320 @ X0_v21+E4]");
		bool flag17 = (nint)0 == 0;
		num2 = num;
		button2 = saveGameButton;
		if (!flag17)
		{
			goto IL_0357;
		}
		goto IL_05c2;
		IL_01ec:
		obj18 = nextGameButton;
		obj19 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ X8_v19+E4]");
		bool flag18 = (nint)0 == 0;
		obj21 = nextGameButton;
		if (!flag18)
		{
			goto IL_022d;
		}
		goto IL_03f5;
		IL_03f5:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag19 = obj21;
		bool flag20 = !flag19;
		object obj31 = 0;
		if (flag20)
		{
			goto IL_0267;
		}
		goto IL_0433;
		IL_022d:
		bool flag21 = obj18;
		bool flag22 = !flag21;
		object obj32 = !flag22;
		obj31 = 0;
		if (obj32 == null)
		{
			goto IL_0267;
		}
		goto IL_0433;
		IL_0433:
		nextGameButton.interactable = true;
		Button button3 = nextGameButton;
		UIExtensions.SetAlpha(((Selectable)button3).m_TargetGraphic, 1f);
		obj13 = leaveButton;
		object obj33 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v280 @ X8_v15+E4]");
		bool flag23 = (nint)0 == 0;
		object obj34 = !flag23;
		num = 1.0;
		obj12 = 0;
		num2 = 1.0;
		obj16 = 0;
		obj31 = 0;
		obj15 = leaveButton;
		if (obj34 != null)
		{
			goto IL_02b8;
		}
		goto IL_04ea;
		IL_0267:
		obj13 = leaveButton;
		obj33 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v280 @ X8_v15+E4]");
		bool flag24 = (nint)0 == 0;
		num2 = num;
		obj16 = obj12;
		obj15 = leaveButton;
		if (!flag24)
		{
			goto IL_02b8;
		}
		goto IL_04ea;
	}

	private void DisableButtons()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_021e: Expected O, but got I4
		//IL_00b4: Expected O, but got I4
		//IL_00bd: Expected O, but got I4
		//IL_02ed: Expected O, but got I4
		//IL_02f6: Expected F4, but got I4
		//IL_02ff: Expected F4, but got I4
		//IL_0308: Expected O, but got I4
		//IL_0311: Expected F4, but got I4
		//IL_031a: Expected F4, but got I4
		//IL_0323: Expected O, but got I4
		//IL_032c: Expected O, but got I4
		//IL_0270: Expected O, but got I4
		//IL_0147: Expected O, but got I4
		//IL_0150: Expected O, but got I4
		//IL_03d9: Expected O, but got I4
		//IL_03fa: Expected O, but got I4
		//IL_038c: Expected O, but got I4
		//IL_0444: Expected O, but got I4
		object obj = 152985600;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6769]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj6;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v21+E4]");
			bool flag = (nint)0 == 0;
			obj5 = nextGameButton;
			obj6 = nextGameButton;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v21+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj5 = nextGameButton;
			obj6 = nextGameButton;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = obj6;
		bool flag4 = !flag3;
		object obj8 = 0;
		if (flag4)
		{
			goto IL_00cb;
		}
		goto IL_027e;
		IL_01dd:
		leaveButton.interactable = false;
		return;
		IL_01b7:
		UnityEngine.Object obj9;
		if ((bool)obj9)
		{
			goto IL_01dd;
		}
		return;
		IL_0412:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		UnityEngine.Object obj10;
		bool flag5 = obj10;
		bool flag6 = !flag5;
		object obj11 = !flag6;
		if (obj11 == null)
		{
			return;
		}
		goto IL_01dd;
		IL_0091:
		bool flag7 = obj5;
		bool flag8 = !flag7;
		object obj12 = !flag8;
		obj8 = 0;
		if (obj12 == null)
		{
			goto IL_00cb;
		}
		goto IL_027e;
		IL_027e:
		nextGameButton.interactable = false;
		Button button = nextGameButton;
		TweenerCore<Color, Color, ColorOptions> tweenerCore = DOTweenModuleUI.DOFade(((Selectable)button).m_TargetGraphic, 0f, 0.3f);
		UnityEngine.Object obj13 = playManager;
		object obj14 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X0_v12+E4]");
		bool flag9 = (nint)0 == 0;
		object obj15 = !flag9;
		float num = 0f;
		float num2 = 1.0502537E+09f;
		object obj16 = 0;
		float num3 = 0f;
		float num4 = 1.0502537E+09f;
		object obj17 = 0;
		obj8 = 0;
		UnityEngine.Object obj18 = playManager;
		if (obj15 != null)
		{
			goto IL_0124;
		}
		goto IL_0344;
		IL_00cb:
		obj14 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X0_v12+E4]");
		bool flag10 = (nint)0 == 0;
		obj13 = playManager;
		num3 = num;
		num4 = num2;
		obj17 = obj16;
		obj18 = playManager;
		if (!flag10)
		{
			goto IL_0124;
		}
		goto IL_0344;
		IL_0344:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag11 = obj18;
		bool flag12 = !flag11;
		num = num3;
		num2 = num4;
		obj16 = obj17;
		object obj19 = 0;
		if (flag12)
		{
			goto IL_0176;
		}
		goto IL_039a;
		IL_0124:
		bool flag13 = obj13;
		bool flag14 = !flag13;
		object obj20 = !flag14;
		obj19 = 0;
		num3 = num;
		num4 = num2;
		obj17 = obj16;
		if (obj20 == null)
		{
			goto IL_0176;
		}
		goto IL_039a;
		IL_039a:
		playManager.ShowFriendlyState();
		obj9 = leaveButton;
		object obj21 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v226 @ X8_v4+E4]");
		bool flag15 = (nint)0 == 0;
		object obj22 = !flag15;
		num = num3;
		num2 = num4;
		obj16 = obj17;
		obj19 = 0;
		obj10 = leaveButton;
		if (obj22 != null)
		{
			goto IL_01b7;
		}
		goto IL_0412;
		IL_0176:
		obj9 = leaveButton;
		obj21 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v226 @ X8_v4+E4]");
		bool flag16 = (nint)0 == 0;
		obj10 = leaveButton;
		if (!flag16)
		{
			goto IL_01b7;
		}
		goto IL_0412;
	}

	public void OnExitRoomClick()
	{
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected O, but got Unknown
		game.ExitGame();
		PopupUI popupUI = popup;
		popupUI.animationSpeed = 0.3f;
		popupUI.ShrinkToParent();
		PopupUI popupUI2 = popup;
		popupUI2.animationSpeed = popupUI.animationSpeed;
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		bool isSpectator = game.IsSpectator;
		bool isPlayer = (byte)((isSpectator ? 1u : 0u) ^ 1u) != 0;
		ITrackEvent trackEvent = TrackerLibrary.EndGameExitClicked(isPlayer);
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X8_v7+E4]");
		if ((nint)0 != 0)
		{
			Tracker.DesignEvent(trackEvent);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Tracker.DesignEvent(trackEvent);
	}

	public void OnClosePopupClick()
	{
		PopupUI popupUI = popup;
		popupUI.animationSpeed = 0.3f;
		popupUI.ShrinkToParent();
		PopupUI popupUI2 = popup;
		popupUI2.animationSpeed = popupUI.animationSpeed;
	}

	public void OnPlayerNextGameClick()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00da: Expected O, but got I
		//IL_0104: Expected O, but got I4
		//IL_00b5: Expected O, but got I4
		//IL_005c: Expected O, but got I
		//IL_0194: Expected O, but got I4
		//IL_01e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e6: Expected O, but got Unknown
		//IL_01ee: Expected I, but got O
		//IL_01fe: Expected O, but got I
		//IL_0297: Unknown result type (might be due to invalid IL or missing references)
		//IL_029c: Expected O, but got Unknown
		//IL_0239: Expected O, but got I
		//IL_03cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d1: Expected O, but got Unknown
		//IL_03d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03de: Expected O, but got Unknown
		//IL_03e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ec: Expected O, but got Unknown
		//IL_03ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0404: Expected O, but got Unknown
		//IL_041e: Expected O, but got I4
		//IL_0247: Unknown result type (might be due to invalid IL or missing references)
		//IL_024c: Expected O, but got Unknown
		//IL_0255: Unknown result type (might be due to invalid IL or missing references)
		//IL_025a: Expected O, but got Unknown
		//IL_0387: Unknown result type (might be due to invalid IL or missing references)
		//IL_038c: Expected O, but got Unknown
		object obj = 152985600;
		object obj2 = typeof(Queue<string>) + 848;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E676B]");
		object obj3 = (nint)0 & (nint)1;
		object obj6;
		object obj4;
		if (obj3 != null)
		{
			obj4 = (nint)0 + (nint)2200;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v35+E4]");
			bool flag = (nint)0 == 0;
			obj6 = obj4;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			obj4 = (nint)0 + (nint)2200;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v35+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj6 = obj4;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		obj4 = obj6;
		goto IL_0140;
		IL_042c:
		game.ExitGame();
		return;
		IL_02b9:
		Room room = game.Room;
		if (room != null)
		{
			Room room2 = game.Room;
			GameType gameType = SFSKammelnaRoomExtensions.GetGameType(room2);
			if (GameTypeExtensions.IsFriendly(gameType))
			{
				Restart();
				goto IL_0349;
			}
		}
		PlayRanked();
		goto IL_0349;
		IL_027a:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v275 @ X0_v30] (should have been resolved before IL gen)");
		object obj9 = default(object);
		object obj8 = obj9 & 1;
		if (obj8 != null)
		{
			goto IL_02b9;
		}
		goto IL_042c;
		IL_0091:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel = default(SessionModel);
		bool flag3 = (object)sessionModel == null;
		object obj10 = !flag3;
		if (obj10 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_0140;
		IL_0140:
		Room currentRoom = sessionModel.CurrentRoom;
		if (currentRoom != null)
		{
			object obj11 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ X0_v7+E4]");
			bool flag4 = (nint)0 == 0;
			object obj12 = !flag4;
			if (obj12 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			SessionModel sessionModel2 = default(SessionModel);
			Room currentRoom2 = sessionModel2.CurrentRoom;
			object obj13 = typeof(RegisteredWaitHandle) + 1376;
			nint num = (nint)currentRoom2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v258 @ X8_v8 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
			object obj14 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v258 @ X8_v8 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_027a;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v258 @ X8_v8 (Il2CppClass<Sfs2X.Entities.Room>)+B0]");
			object obj15 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ X10_v7-8]");
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
				goto IL_027a;
			}
			object obj16 = obj15 + 6;
			object obj17 = num + obj16;
			object obj18 = obj17 + 312;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v201 @ X8_v15] (should have been resolved before IL gen)");
			object obj20 = default(object);
			object obj19 = obj20 & 1;
			bool flag5 = obj19 == null;
			object obj21 = !flag5;
			if (obj21 != null)
			{
				goto IL_02b9;
			}
		}
		goto IL_042c;
		IL_0349:
		bool isSpectator = game.IsSpectator;
		bool isPlayer = (byte)((isSpectator ? 1u : 0u) ^ 1u) != 0;
		ITrackEvent trackEvent = TrackerLibrary.EndGamePlayMoreClicked(isPlayer);
		object obj22 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		object obj23 = obj22;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ X8_v12+E4]");
		if ((nint)0 != 0)
		{
			Tracker.DesignEvent(trackEvent);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Tracker.DesignEvent(trackEvent);
	}

	private void LoadGame(bool isWaitingForAd, bool isDisableCancelButton, Action matchMethod)
	{
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Expected O, but got Unknown
		//IL_0094: Expected O, but got I
		//IL_00d6: Expected O, but got I4
		playManager.DisablePlayButton();
		PopupUI popupUI = popup;
		popupUI.animationSpeed = 0.3f;
		popupUI.ShrinkToParent();
		PopupUI popupUI2 = popup;
		popupUI2.animationSpeed = popupUI.animationSpeed;
		hintsPopup.Open(isWaitingForAd, isDisableCancelButton);
		object obj = typeof(RegisteredWaitHandle) + 3136;
		object obj2 = (nint)0 + (nint)2424;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CFF124");
		SingleSound singleSound = default(SingleSound);
		SoundChannel.PlaySFXSound(singleSound);
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X0_v10+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		ScreenManager.AnimateTransitionOut(matchMethod);
	}

	private void PlayRanked()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0040: Expected O, but got I
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected O, but got Unknown
		//IL_0060: Expected O, but got I
		//IL_00c5: Expected I, but got O
		//IL_0073: Expected I, but got O
		//IL_0090: Expected I, but got O
		object obj = typeof(RankedPlayManager.<>c__DisplayClass36_0) + 16;
		object obj2 = (nint)0 + (nint)160;
		object obj3 = typeof(RankedPlayManager.<>c__DisplayClass36_0) + 32;
		object obj4 = (nint)0 + (nint)168;
		object obj5 = typeof(RankedPlayManager.<>c__DisplayClass36_0) + 24;
		object obj6 = (nint)0 + (nint)176;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		RankedPlayManager.PlayRankedGameCallback playRankedGameCallback = default(RankedPlayManager.PlayRankedGameCallback);
		playRankedGameCallback..ctor(this, (IntPtr)obj2);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		RankedPlayManager.PlayRankedGameShowAdLoading playRankedGameShowAdLoading = default(RankedPlayManager.PlayRankedGameShowAdLoading);
		playRankedGameShowAdLoading..ctor(this, (IntPtr)obj4);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		RankedPlayManager.PlayRankedGameErrorCallback playRankedGameErrorCallback = default(RankedPlayManager.PlayRankedGameErrorCallback);
		playRankedGameErrorCallback..ctor(this, (IntPtr)obj6);
		playManager.PlayRanked(playRankedGameCallback, playRankedGameShowAdLoading, playRankedGameErrorCallback);
	}

	private void Restart(bool _ = false)
	{
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		//IL_006b: Expected O, but got I
		KGame.RestartGame();
		DisableButtons();
		Room room = game.Room;
		if (SFSKammelnaRoomExtensions.IsPrivate(room))
		{
			object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1184;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X8_v10+B8]");
			object obj3 = 0;
			((KammelnaLobbyServerConnector)obj3).ShowPanelIfNeeded();
		}
		PopupUI popupUI = popup;
		popupUI.animationSpeed = 0.3f;
		popupUI.ShrinkToParent();
		PopupUI popupUI2 = popup;
		popupUI2.animationSpeed = popupUI.animationSpeed;
	}

	private void ErrorCallback(RankedPlayManager.PlayError error)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		//IL_006b: Expected O, but got I4
		//IL_00ee: Expected O, but got I4
		//IL_012d: Expected O, but got I4
		PopupUI popupUI = popup;
		object obj = typeof(SqlSingle[]) + 3912;
		object obj2 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1176;
		object obj3 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1240;
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		AnimationExtensions.ErrorFeedback(popupUI.content);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		Enum enumeration = default(Enum);
		string friendlyName = EnumExtensions.GetFriendlyName(enumeration);
		object obj6 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X8_v6+E4]");
		bool flag2 = (nint)0 == 0;
		object obj7 = !flag2;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Toast.Show(friendlyName, (Vector2)0, 0f);
	}

	public void OnShowRoundboardClick()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_010c: Expected O, but got I4
		//IL_0095: Expected O, but got I
		//IL_00a5: Expected O, but got I
		//IL_00c2: Expected O, but got I
		//IL_00d2: Expected O, but got I
		//IL_0144: Expected O, but got I
		//IL_0154: Expected O, but got I
		//IL_0176: Expected O, but got I4
		object obj = 152985600;
		object obj2 = typeof(RegisteredWaitHandle) + 1520;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E676F]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 == null)
		{
			goto IL_00dc;
		}
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v12+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = obj4;
		if (!flag)
		{
			goto IL_0085;
		}
		goto IL_0122;
		IL_0122:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj6 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X0_v5+B8]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X8_v4+40]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X8_v4+40]");
		bool flag2 = (nint)0 == 0;
		object obj9 = !flag2;
		if (obj9 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_00aa;
		IL_0085:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v12+B8]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v10+40]");
		obj8 = 0;
		goto IL_00aa;
		IL_00aa:
		object obj11 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X8_v8+1E8]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X8_v8+1F0]");
		object obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v59 @ X2_v1 (should have been resolved before IL gen)");
		goto IL_00dc;
		IL_00dc:
		_ = 1;
		obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v12+E4]");
		bool flag3 = (nint)0 == 0;
		object obj14 = !flag3;
		obj5 = obj4;
		if (obj14 != null)
		{
			goto IL_0085;
		}
		goto IL_0122;
	}

	public void Close()
	{
		PopupUI popupUI = popup;
		popupUI.animationSpeed = 0.3f;
		popupUI.ShrinkToParent();
		PopupUI popupUI2 = popup;
		popupUI2.animationSpeed = popupUI.animationSpeed;
	}

	private void PlayNewGameSound()
	{
		//IL_0011: Expected O, but got I
		object obj = (nint)0 + (nint)2424;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CFF124");
		SingleSound singleSound = default(SingleSound);
		SoundChannel.PlaySFXSound(singleSound);
	}

	protected void SaveGameClick()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0176: Expected O, but got I4
		//IL_01b2: Expected O, but got I4
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Expected O, but got Unknown
		//IL_00fd: Expected O, but got I4
		object obj = 152985600;
		object obj2 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2160;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6770]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v2+E4]");
			if ((nint)0 != 0)
			{
				goto IL_007d;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 != null)
			{
				goto IL_007d;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag2 = GameReplayManager.SaveGameReplayGame();
		bool flag3 = !flag2;
		object obj6 = !flag3;
		if (obj6 == null)
		{
			return;
		}
		goto IL_009f;
		IL_009f:
		gameSavedPopup.Initialize();
		saveButtonTextToggler.ToggleManual(isON: true);
		object obj7 = typeof(System.Buffers.Text.ParserHelpers) + 1624;
		object obj8 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X0_v18+E4]");
		bool flag4 = (nint)0 == 0;
		object obj9 = !flag4;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		int usedReplayTrails = Preferences.UsedReplayTrails;
		int currentProgress = 2 - usedReplayTrails;
		replayFreeTrailsIndicator.CurrentProgress = currentProgress;
		return;
		IL_007d:
		if (GameReplayManager.SaveGameReplayGame())
		{
			goto IL_009f;
		}
	}

	public GameEndPopup()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [7252CC0]");
		Team1Score = 0;
		base..ctor();
	}

	private void <PlayRanked>b__47_0(bool skipAd)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0059: Expected I, but got O
		object obj = typeof(DebugUI.BitField) + 3992;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(SqlSingle[]) + 2376;
		object obj4 = (nint)0 + (nint)1504;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(obj2, (IntPtr)obj4);
		LoadGame(isWaitingForAd: false, isDisableCancelButton: false, action);
	}

	private void <PlayRanked>b__47_1()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_003e: Expected I, but got O
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)2480;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(null, (IntPtr)obj2);
		LoadGame(isWaitingForAd: true, isDisableCancelButton: true, action);
	}

	private void <PlayRanked>b__47_2(RankedPlayManager.PlayError error)
	{
		//IL_0016: Expected O, but got I
		//IL_00a9: Expected O, but got I4
		//IL_0076: Expected O, but got I4
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Expected O, but got Unknown
		//IL_00f5: Expected O, but got I4
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Expected O, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6773]");
		object obj = (nint)0 & (nint)1;
		if (obj != null)
		{
			if (error != RankedPlayManager.PlayError.NotEnoughAces)
			{
				goto IL_0050;
			}
		}
		else
		{
			_ = 1;
			bool flag = error == RankedPlayManager.PlayError.NotEnoughAces;
			object obj2 = !flag;
			if (obj2 != null)
			{
				goto IL_0050;
			}
		}
		object obj3 = typeof(System.Buffers.Text.ParserHelpers) + 1616;
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v10+E4]");
		bool flag2 = (nint)0 == 0;
		object obj5 = !flag2;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		PrefabInitializer.InitializePrefab(notEnoughAcesToPlayRankedRef, CanvasLayer.SecondaryCanvas);
		RankedPlayManager rankedPlayManager = playManager;
		goto IL_0131;
		IL_0050:
		rankedPlayManager = playManager;
		bool flag3 = (object)playManager == null;
		object obj6 = !flag3;
		if (obj6 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_0131;
		IL_0131:
		rankedPlayManager.EnablePlayButton();
		object obj7 = typeof(RegisteredWaitHandle) + 3136;
		hintsPopup.Close();
		object obj8 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X0_v5+E4]");
		if ((nint)0 != 0)
		{
			ScreenManager.AnimateTransitionIn();
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		ScreenManager.AnimateTransitionIn();
	}
}
