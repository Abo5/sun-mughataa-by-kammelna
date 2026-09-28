using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using Cpp2ILInjected;
using DataTracking;
using Kammelna.Server.Models.Clans;
using Sfs2X.Entities;
using Sfs2X.Entities.Data;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;

public class CatchButtons : MonoBehaviour
{
	private bool horizontal;

	private LinearLayoutGroup layout;

	private SlideAnimationHelper slider;

	private Button wrongSawa;

	private Button wrongEkka;

	private Button openCards;

	private GameEventsChannel gameEventsChannel;

	private BalootGame game;

	private Dictionary<BalootCatchButtonEnum, Button> _ballotCatchButtons;

	private void Awake()
	{
		FillCatchButtonsDictionary();
	}

	private void Start()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_003d: Expected I, but got O
		//IL_006f: Expected O, but got I
		//IL_0087: Expected I, but got O
		//IL_00b9: Expected O, but got I
		//IL_00d1: Expected I, but got O
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Expected O, but got Unknown
		//IL_00f6: Expected O, but got I
		//IL_0132: Expected O, but got I4
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0164: Expected O, but got Unknown
		//IL_01a0: Expected O, but got I
		//IL_01b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b9: Expected O, but got Unknown
		//IL_01c5: Expected O, but got I
		//IL_01f9: Expected I, but got O
		//IL_020d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0212: Expected O, but got Unknown
		//IL_021e: Expected O, but got I
		//IL_024a: Expected I, but got O
		//IL_025b: Expected O, but got I
		//IL_0287: Expected I, but got O
		//IL_0298: Expected O, but got I
		//IL_02c4: Expected I, but got O
		Button button = openCards;
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
		object obj2 = (nint)0 + (nint)3456;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction = default(UnityAction);
		unityAction..ctor(this, (IntPtr)obj2);
		button.m_OnClick.AddListener(unityAction);
		Button button2 = wrongSawa;
		object obj3 = (nint)0 + (nint)3480;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction2 = default(UnityAction);
		unityAction2..ctor(this, (IntPtr)obj3);
		button2.m_OnClick.AddListener(unityAction2);
		Button button3 = wrongEkka;
		object obj4 = (nint)0 + (nint)3472;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction3 = default(UnityAction);
		unityAction3..ctor(this, (IntPtr)obj4);
		object obj5 = typeof(MemberAchievementClanFeedData) + 2976;
		object obj6 = (nint)0 + (nint)8;
		button3.m_OnClick.AddListener(unityAction3);
		object obj7 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ X0_v13+E4]");
		bool flag = (nint)0 == 0;
		object obj8 = !flag;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE90D8");
		object obj9 = this + 88;
		object obj10 = default(object);
		obj9 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		LinearLayoutGroup.Orientation layoutOrientation = (LinearLayoutGroup.Orientation)((horizontal ? 1 : 0) ^ 1);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X20_v7-30]");
		((LinearLayoutGroup)0).LayoutOrientation = layoutOrientation;
		object obj11 = typeof(SqlSingle[]) + 2376;
		object obj12 = (nint)0 + (nint)3432;
		layout.childForceExpandWidth = horizontal;
		Clear();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj12);
		object obj13 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3368;
		object obj14 = (nint)0 + (nint)3448;
		game.OnGameStateUpdated += action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action2 = default(Action<object>);
		action2..ctor((object)this, (IntPtr)obj14);
		object obj15 = (nint)0 + (nint)3440;
		game.OnSawa += action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action3 = default(Action);
		action3..ctor(this, (IntPtr)obj15);
		object obj16 = (nint)0 + (nint)3464;
		game.OnRoundEnd += action3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action4 = default(Action);
		action4..ctor(this, (IntPtr)obj16);
		gameEventsChannel.ToggleCatchPanel += action4;
	}

	private void OnDestroy()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_004d: Expected I, but got O
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)3464;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		gameEventsChannel.ToggleCatchPanel -= action;
	}

	private void OnGameStateUpdated()
	{
		//IL_003b: Expected O, but got I4
		//IL_0180: Unknown result type (might be due to invalid IL or missing references)
		//IL_0185: Expected O, but got Unknown
		//IL_01e2: Expected O, but got I
		BalootGame balootGame = game;
		bool isBidding = ((CardGame)balootGame).<Stage>k__BackingField.IsBidding;
		bool flag = !isBidding;
		object obj = !flag;
		CardGame cardGame;
		if (obj == null)
		{
			cardGame = game;
			if (cardGame.<MoveNumber>k__BackingField != 1)
			{
				goto IL_0092;
			}
		}
		Clear();
		cardGame = game;
		goto IL_0092;
		IL_0092:
		CardGameLastActionInfo lastAction = cardGame.LastAction;
		KGame kGame = game;
		if (((LastActionInfo)lastAction).<ActionPlayer>k__BackingField == kGame.<MySeatIndex>k__BackingField)
		{
			SlideAnimationHelper slideAnimationHelper = slider;
			if (slideAnimationHelper.<IsShown>k__BackingField)
			{
				float preferredHeight = layout.preferredHeight;
				float slideDownDistance = default(float);
				slideAnimationHelper.slideDownDistance = slideDownDistance;
				slider.SlideOut();
				kGame = game;
			}
		}
		if (kGame.IsTutorial)
		{
			object obj2 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2296;
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ X8_v9+B8]");
			object obj4 = 0;
			object obj5 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X8_v11+48]");
			HandleCatchButtons((BalootCatchButtonEnum)0);
		}
		else
		{
			bool isSun = game.IsSun;
			bool enable = (byte)((isSun ? 1u : 0u) ^ 1u) != 0;
			UpdateHokomButtons(enable);
		}
	}

	private void UpdateHokomButtons(bool enable)
	{
		GameObject gameObject = wrongEkka.gameObject;
		gameObject.SetActive(enable);
		Room room = game.Room;
		bool interactable = SFSKammelnaRoomExtensions.IsCheatingAllowed(room);
		wrongEkka.interactable = interactable;
	}

	private void OpenCardsOnClick()
	{
		SendCatch(null);
	}

	private void WrongSawaOnClick()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object mode = "utf-32" + 1704;
		SendCatch((string)mode);
	}

	private void WrongEkkaOnClick()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object mode = "utf-32" + 1696;
		SendCatch((string)mode);
	}

	private void SendCatch(string mode)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected O, but got Unknown
		//IL_0053: Expected I, but got O
		//IL_0063: Expected O, but got I
		//IL_009e: Expected O, but got I
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Expected O, but got Unknown
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Expected O, but got Unknown
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Expected O, but got Unknown
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Expected O, but got Unknown
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Expected O, but got Unknown
		object obj = typeof(RegisteredWaitHandle) + 2040;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		SFSObject sFSObject = default(SFSObject);
		sFSObject..ctor();
		if (mode == null)
		{
			goto IL_011c;
		}
		object obj2 = typeof(System.IOAsyncCallback) + 976;
		object obj3 = "m_StencilDeferredPS" + 2232;
		object action = "Cannot populate JSON object onto type '{0}'." + 1872;
		nint num = (nint)sFSObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X8_v7 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+12E]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X8_v7 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_00df;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X8_v7 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+B0]");
		object obj5 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v196 @ X10_v7-8]");
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
			goto IL_00df;
		}
		object obj6 = obj5 + 39;
		object obj7 = num + obj6;
		object obj8 = obj7 + 312;
		goto IL_0180;
		IL_0180:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v239 @ X0_v8] (should have been resolved before IL gen)");
		FirebaseTrack.Event((string)action, mode);
		goto IL_011c;
		IL_011c:
		game.SendCatch(sFSObject);
		return;
		IL_00df:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_0180;
	}

	public void ToggleCatchPanel()
	{
		SlideAnimationHelper slideAnimationHelper = slider;
		if (slideAnimationHelper.<IsShown>k__BackingField)
		{
			float preferredHeight = layout.preferredHeight;
			float slideDownDistance = default(float);
			slideAnimationHelper.slideDownDistance = slideDownDistance;
			slider.SlideOut();
		}
		else
		{
			slideAnimationHelper.SlideIn();
		}
	}

	private void Show()
	{
		slider.SlideIn();
	}

	private void Hide()
	{
		SlideAnimationHelper slideAnimationHelper = slider;
		float preferredHeight = layout.preferredHeight;
		float slideDownDistance = default(float);
		slideAnimationHelper.slideDownDistance = slideDownDistance;
		slider.SlideOut();
	}

	private void Clear()
	{
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_0079: Expected O, but got I4
		wrongSawa.interactable = false;
		SlideAnimationHelper slideAnimationHelper = slider;
		RectTransform rectTransform = UIExtensions.rectTransform(this);
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 3512;
		Rect rect = rectTransform.rect;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X0_v8+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		float slideDownDistance = default(float);
		slideAnimationHelper.slideDownDistance = slideDownDistance;
		slider.HideImmediate();
	}

	private void OnSawa(SawaInfo sawaInfo)
	{
		//IL_005e: Expected O, but got I4
		int sawaPlayer = sawaInfo.SawaPlayer;
		int playerTeam = game.GetPlayerTeam(sawaPlayer);
		CardGame cardGame = game;
		int playerTeam2 = game.GetPlayerTeam(((KGame)cardGame).<MySeatIndex>k__BackingField);
		object obj = playerTeam - playerTeam2;
		bool flag = obj == null;
		bool interactable = !flag;
		wrongSawa.interactable = interactable;
	}

	private void OnRoundEnd()
	{
		Clear();
	}

	private void DisableSawaButton()
	{
		wrongSawa.interactable = false;
	}

	private void EnableSawaButton()
	{
		wrongSawa.interactable = true;
	}

	private void FillCatchButtonsDictionary()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0026: Expected O, but got I
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Expected O, but got Unknown
		object obj = typeof(ConditionalWeakTable<System.Net.HttpWebRequest, Mono.Http.NtlmSession>.CreateValueCallback) + 368;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Dictionary<System.Int32Enum, object> dictionary = default(Dictionary<System.Int32Enum, object>);
		dictionary..ctor();
		object obj2 = (nint)0 + (nint)1648;
		dictionary.Add((System.Int32Enum)1, wrongSawa);
		dictionary.Add((System.Int32Enum)2, wrongEkka);
		dictionary.Add((System.Int32Enum)4, openCards);
		object obj3 = this + 96;
		obj3 = dictionary;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	private unsafe void HandleCatchButtons(BalootCatchButtonEnum balootCatchButtonEnum)
	{
		//IL_0178: Expected O, but got I4
		//IL_0013: Expected O, but got I
		//IL_001f: Expected O, but got I
		//IL_0119: Expected I4, but got O
		//IL_00ba: Expected O, but got I4
		//IL_00c3: Expected O, but got I4
		//IL_006a: Expected O, but got I4
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Expected O, but got Unknown
		bool flag = _ballotCatchButtons == null;
		Dictionary<System.Int32Enum, object>.Enumerator enumerator = (Dictionary<System.Int32Enum, object>.Enumerator)0;
		CatchButtons catchButtons = this;
		Dictionary<System.Int32Enum, object>.Enumerator enumerator3 = default(Dictionary<System.Int32Enum, object>.Enumerator);
		BalootCatchButtonEnum balootCatchButtonEnum2 = default(BalootCatchButtonEnum);
		if (!flag)
		{
			object obj = (nint)0 + (nint)1936;
			catchButtons = (CatchButtons)((nint)0 + (nint)984);
			Dictionary<System.Int32Enum, object>.Enumerator enumerator2 = ((Dictionary<System.Int32Enum, object>)(object)_ballotCatchButtons).GetEnumerator();
			KeyValuePair<System.Int32Enum, object> keyValuePair = default(KeyValuePair<System.Int32Enum, object>);
			System.Int32Enum key;
			while (true)
			{
				if (enumerator3.MoveNext())
				{
					keyValuePair.Deconstruct(out key, out var value);
					if (value == null)
					{
						break;
					}
					object obj2 = ~balootCatchButtonEnum2;
					object obj3 = key & obj2;
					bool interactable = obj3 == null;
					((Selectable)value).interactable = interactable;
					continue;
				}
				enumerator3.Dispose();
				return;
			}
			NullReferenceException ex = new NullReferenceException();
			enumerator = (Dictionary<System.Int32Enum, object>.Enumerator)0;
			object obj4 = 0;
			balootCatchButtonEnum2 = (BalootCatchButtonEnum)(int)(&key);
		}
		NullReferenceException ex2 = new NullReferenceException();
		bool flag2 = balootCatchButtonEnum2 != BalootCatchButtonEnum.wrongSawa;
		NullReferenceException ex3 = ex2;
		if (!flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			balootCatchButtonEnum2 = (BalootCatchButtonEnum)catchButtons;
			enumerator3.Dispose();
			object obj5 = default(object);
			if (obj5 == null)
			{
				return;
			}
			OutOfMemoryException ex4 = new OutOfMemoryException();
			object obj4 = obj5;
			ex3 = (NullReferenceException)(object)ex4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223830C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
	}
}
