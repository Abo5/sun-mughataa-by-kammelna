using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Formats.Asn1;
using System.Threading;
using Cpp2ILInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Features.GameReplay;
using Kammelna.Server.Models.Clans;
using Server.Models;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;

public class CurrencyBombAnnouncementPopup : MonoBehaviour
{
	private PopupUI popup;

	private RectTransform panel;

	private AvatarInitializer avatar;

	private TextMeshProUGUI messageText;

	private TextMeshProUGUI defaultMessageText;

	private Button claimButton;

	private GameObject claimedState;

	private Button dismissButton;

	private TextMeshProUGUI amount;

	private TextMeshProUGUI amountReceived;

	private SwipeCaptcha swipeCaptcha;

	private GiftBombEventsChannel giftBombEvents;

	private GenericSoundAlbum soundAlbum;

	private GiftBombManager _bombManager;

	private bool IsEid
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_002a: Expected O, but got I
			//IL_00da: Expected O, but got I4
			//IL_0097: Expected O, but got I4
			//IL_0164: Expected I4, but got O
			object obj = typeof(RegisteredWaitHandle) + 56;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7750]");
			object obj2 = (nint)0 & (nint)1;
			if (obj2 != null)
			{
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v5+E4]");
				if ((nint)0 != 0)
				{
					goto IL_0074;
				}
			}
			else
			{
				_ = 1;
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v5+E4]");
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
			goto IL_0156;
			IL_0156:
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
			IL_011d:
			VisualsConfig <Visuals>k__BackingField = current.<Visuals>k__BackingField;
			if (current.<Visuals>k__BackingField != null)
			{
				return <Visuals>k__BackingField.<IsEid>k__BackingField;
			}
			goto IL_0156;
			IL_0074:
			current = RemoteConfig.Current;
			bool flag2 = current == null;
			object obj5 = !flag2;
			if (obj5 != null)
			{
				goto IL_011d;
			}
			goto IL_0156;
		}
	}

	private void Start()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0078: Expected O, but got I
		//IL_00a2: Expected O, but got I4
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		object obj2 = (nint)0 + (nint)80;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE90D8");
		object obj5 = this + 136;
		object obj6 = default(object);
		obj5 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		ChangeSkinForEid();
		RegisterEvents();
		AddButtonsActions();
	}

	private void OnDestroy()
	{
		UnRegisterEvents();
	}

	private void ChangeSkinForEid()
	{
		//IL_0016: Expected O, but got I
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Expected O, but got Unknown
		//IL_0115: Expected O, but got I
		//IL_012f: Expected O, but got I4
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_005d: Expected O, but got I
		//IL_0175: Expected O, but got I4
		//IL_00d2: Expected O, but got I4
		//IL_01dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e1: Expected O, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7751]");
		object obj = (nint)0 & (nint)1;
		object obj2;
		object obj4;
		if (obj != null)
		{
			obj2 = typeof(RegisteredWaitHandle) + 56;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7750]");
			object obj3 = (nint)0 & (nint)1;
			bool flag = obj3 == null;
			obj4 = obj2;
			if (!flag)
			{
				goto IL_0082;
			}
		}
		else
		{
			_ = 1;
			obj2 = typeof(RegisteredWaitHandle) + 56;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7750]");
			object obj5 = (nint)0 & (nint)1;
			bool flag2 = obj5 == null;
			object obj6 = !flag2;
			obj4 = obj2;
			if (obj6 != null)
			{
				goto IL_0082;
			}
		}
		_ = 1;
		object obj7 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X0_v5+E4]");
		bool flag3 = (nint)0 == 0;
		object obj8 = !flag3;
		if (obj8 != null)
		{
			goto IL_00af;
		}
		goto IL_0183;
		IL_019b:
		RemoteConfigModel current;
		VisualsConfig <Visuals>k__BackingField = current.<Visuals>k__BackingField;
		if (<Visuals>k__BackingField.<IsEid>k__BackingField)
		{
			object text = "Added Tournament Prizes And Features" + 912;
			TextMeshProExtensions.Localize(defaultMessageText, (string)text);
		}
		return;
		IL_00af:
		current = RemoteConfig.Current;
		bool flag4 = current == null;
		object obj9 = !flag4;
		if (obj9 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_019b;
		IL_0183:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		current = RemoteConfig.Current;
		goto IL_019b;
		IL_0082:
		obj7 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X0_v5+E4]");
		if ((nint)0 != 0)
		{
			goto IL_00af;
		}
		goto IL_0183;
	}

	private void RegisterEvents()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_01b4: Expected I, but got O
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		//IL_0045: Expected O, but got I
		//IL_0071: Expected I, but got O
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected O, but got Unknown
		//IL_0096: Expected O, but got I
		//IL_00c2: Expected I, but got O
		//IL_00d3: Expected O, but got I
		//IL_00ff: Expected I, but got O
		//IL_0110: Expected O, but got I
		//IL_013c: Expected I, but got O
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Expected O, but got Unknown
		//IL_0161: Expected O, but got I
		//IL_018d: Expected I, but got O
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2128;
		object obj2 = (nint)0 + (nint)1144;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj2);
		object obj3 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3576;
		object obj4 = (nint)0 + (nint)1136;
		giftBombEvents.OnShardClaimed += action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action2 = default(Action<object>);
		action2..ctor((object)this, (IntPtr)obj4);
		object obj5 = typeof(GameReplayController.<OnEndRoundEventIe>d__138) + 296;
		object obj6 = (nint)0 + (nint)1152;
		giftBombEvents.OnClaimFail += action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		GiftBombEventsChannel.BombEventDel bombEventDel = default(GiftBombEventsChannel.BombEventDel);
		bombEventDel..ctor(this, (IntPtr)obj6);
		object obj7 = (nint)0 + (nint)1128;
		giftBombEvents.OnBombDrop += bombEventDel;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		GiftBombEventsChannel.BombEventDel bombEventDel2 = default(GiftBombEventsChannel.BombEventDel);
		bombEventDel2..ctor(this, (IntPtr)obj7);
		object obj8 = (nint)0 + (nint)1112;
		giftBombEvents.OnBombClaimed += bombEventDel2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		GiftBombEventsChannel.BombEventDel bombEventDel3 = default(GiftBombEventsChannel.BombEventDel);
		bombEventDel3..ctor(this, (IntPtr)obj8);
		object obj9 = typeof(SqlSingle[]) + 2376;
		object obj10 = (nint)0 + (nint)1088;
		giftBombEvents.OnBombCleared += bombEventDel3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action3 = default(Action);
		action3..ctor(this, (IntPtr)obj10);
		ChatHandler.OnChatActivated += action3;
	}

	private void UnRegisterEvents()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_01b4: Expected I, but got O
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		//IL_0045: Expected O, but got I
		//IL_0071: Expected I, but got O
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected O, but got Unknown
		//IL_0096: Expected O, but got I
		//IL_00c2: Expected I, but got O
		//IL_00d3: Expected O, but got I
		//IL_00ff: Expected I, but got O
		//IL_0110: Expected O, but got I
		//IL_013c: Expected I, but got O
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Expected O, but got Unknown
		//IL_0161: Expected O, but got I
		//IL_018d: Expected I, but got O
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2128;
		object obj2 = (nint)0 + (nint)1144;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj2);
		object obj3 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3576;
		object obj4 = (nint)0 + (nint)1136;
		giftBombEvents.OnShardClaimed -= action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action2 = default(Action<object>);
		action2..ctor((object)this, (IntPtr)obj4);
		object obj5 = typeof(GameReplayController.<OnEndRoundEventIe>d__138) + 296;
		object obj6 = (nint)0 + (nint)1152;
		giftBombEvents.OnClaimFail -= action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		GiftBombEventsChannel.BombEventDel bombEventDel = default(GiftBombEventsChannel.BombEventDel);
		bombEventDel..ctor(this, (IntPtr)obj6);
		object obj7 = (nint)0 + (nint)1128;
		giftBombEvents.OnBombDrop -= bombEventDel;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		GiftBombEventsChannel.BombEventDel bombEventDel2 = default(GiftBombEventsChannel.BombEventDel);
		bombEventDel2..ctor(this, (IntPtr)obj7);
		object obj8 = (nint)0 + (nint)1112;
		giftBombEvents.OnBombClaimed -= bombEventDel2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		GiftBombEventsChannel.BombEventDel bombEventDel3 = default(GiftBombEventsChannel.BombEventDel);
		bombEventDel3..ctor(this, (IntPtr)obj8);
		object obj9 = typeof(SqlSingle[]) + 2376;
		object obj10 = (nint)0 + (nint)1088;
		giftBombEvents.OnBombCleared -= bombEventDel3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action3 = default(Action);
		action3..ctor(this, (IntPtr)obj10);
		ChatHandler.OnChatActivated -= action3;
	}

	private void AddButtonsActions()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_003d: Expected I, but got O
		//IL_006f: Expected O, but got I
		//IL_0087: Expected I, but got O
		Button button = claimButton;
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
		object obj2 = (nint)0 + (nint)1096;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction = default(UnityAction);
		unityAction..ctor(this, (IntPtr)obj2);
		button.m_OnClick.AddListener(unityAction);
		Button button2 = dismissButton;
		object obj3 = (nint)0 + (nint)1120;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction2 = default(UnityAction);
		unityAction2..ctor(this, (IntPtr)obj3);
		button2.m_OnClick.AddListener(unityAction2);
	}

	private void OnShardClaim(GiftBombData giftBomb)
	{
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Expected O, but got Unknown
		//IL_01b2: Expected O, but got I4
		//IL_0057: Expected O, but got I
		//IL_005f: Expected I, but got O
		//IL_0095: Expected O, but got I8
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Expected O, but got Unknown
		//IL_00cd: Expected O, but got I8
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Expected O, but got Unknown
		//IL_0105: Expected O, but got I
		//IL_0113: Expected I, but got O
		//IL_01e2: Expected O, but got I
		//IL_01fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0200: Expected O, but got Unknown
		//IL_022a: Expected O, but got I4
		//IL_0162: Expected O, but got I4
		//IL_0167: Expected I, but got O
		//IL_0241: Expected O, but got I4
		//IL_0249: Expected I, but got O
		GiftBombManager bombManager = _bombManager;
		GiftBombData currentGiftBomb = bombManager._currentGiftBomb;
		bool flag = bombManager._currentGiftBomb == null;
		Action action = (Action)(object)giftBomb;
		object obj6;
		if (!flag)
		{
			object obj = (nint)0 + (nint)3184;
			nint num = (nint)obj;
			long? num2 = currentGiftBomb.<Id>k__BackingField;
			bool flag2 = giftBomb.<Id>k__BackingField != 0;
			action = (Action)currentGiftBomb.<Id>k__BackingField;
			if (!flag2)
			{
				object obj2 = (??)num2 & 1;
				bool flag3 = obj2 == null;
				action = (Action)currentGiftBomb.<Id>k__BackingField;
				if (!flag3)
				{
					object obj3 = typeof(SqlSingle[]) + 2376;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					object obj4 = (nint)0 + (nint)1104;
					Action action2 = default(Action);
					action2..ctor(this, (IntPtr)obj4);
					PopupUI popupUI = popup;
					object obj8;
					if (!popupUI.<IsCurrentlyShown>k__BackingField)
					{
						action = (Action)(nint)((Delegate)action2).method;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v240.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
						object obj5 = typeof(System.Buffers.Text.ParserHelpers) + 1432;
						obj6 = obj5;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X0_v6+E4]");
						bool flag4 = (nint)0 == 0;
						object obj7 = !flag4;
						if (obj7 == null)
						{
							obj8 = 0;
							num = (nint)obj4;
							goto IL_01c0;
						}
						goto IL_01cf;
					}
					popupUI.SlideToRight(action2);
					obj8 = 0;
					num = unchecked((nint)null);
					action = action2;
				}
			}
		}
		object obj9 = typeof(System.Buffers.Text.ParserHelpers) + 1432;
		obj6 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X0_v6+E4]");
		bool flag5 = (nint)0 == 0;
		object obj10 = !flag5;
		if (obj10 == null)
		{
			goto IL_01c0;
		}
		goto IL_01cf;
		IL_01c0:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		goto IL_01cf;
		IL_01cf:
		PopupWindow.DismissMessage();
	}

	private void OnClaimFail(string msg)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Expected O, but got Unknown
		//IL_00e2: Expected O, but got I
		//IL_010c: Expected O, but got I4
		//IL_004f: Expected I, but got O
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 1432;
		Action action = default(Action);
		PopupUI popupUI;
		while (true)
		{
			object obj2 = typeof(SqlSingle[]) + 2376;
			object obj3 = (nint)0 + (nint)1104;
			object obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			PopupWindow.ShowError(msg);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			action..ctor(this, (IntPtr)obj3);
			popupUI = popup;
			if (popupUI.<IsCurrentlyShown>k__BackingField)
			{
				break;
			}
			IntPtr invoke_impl = ((Delegate)action).invoke_impl;
			IntPtr method_code = ((Delegate)action).method_code;
			IntPtr method = ((Delegate)action).method;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v119 @ X2_v3 (System.IntPtr) (should have been resolved before IL gen)");
		}
		popupUI.SlideToRight(action);
	}

	public void Dismiss()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_008f: Expected I, but got O
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)1104;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		PopupUI popupUI = popup;
		if (popupUI.<IsCurrentlyShown>k__BackingField)
		{
			popupUI.SlideToRight(action);
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v48.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		}
		_bombManager.DismissBomb();
	}

	private void ClaimClicked()
	{
		ShowSwipeArea();
	}

	public void TryClaim(List<Vector2> captchaSolution)
	{
		_bombManager.TryClaim(captchaSolution);
	}

	private void ShowCurrentGiftBomb(GiftBombData giftBomb)
	{
		//IL_0062: Expected O, but got I4
		//IL_009e: Expected O, but got I
		if (giftBomb.<Category>k__BackingField != GiftBombType.Currency)
		{
			return;
		}
		Clear();
		Populate(giftBomb);
		Show();
		if (giftBomb.<CurrencyPerShard>k__BackingField != 0)
		{
			bool flag = !giftBomb.<IsClaimed>k__BackingField;
			object obj = !flag;
			if (obj == null && ChatHandler.ChatActive)
			{
				object obj2 = (nint)0 + (nint)2424;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CFF124");
				SingleSound singleSound = default(SingleSound);
				SoundChannel.PlaySFXSound(singleSound);
			}
		}
	}

	private void PlaySound(GiftBombData giftBomb)
	{
		//IL_0046: Expected O, but got I4
		//IL_0082: Expected O, but got I
		if (giftBomb.<CurrencyPerShard>k__BackingField != 0)
		{
			bool flag = !giftBomb.<IsClaimed>k__BackingField;
			object obj = !flag;
			if (obj == null && ChatHandler.ChatActive)
			{
				object obj2 = (nint)0 + (nint)2424;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CFF124");
				SingleSound singleSound = default(SingleSound);
				SoundChannel.PlaySFXSound(singleSound);
			}
		}
	}

	private void GiftBombClaimed(GiftBombData giftBomb)
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected O, but got Unknown
		//IL_0068: Expected O, but got I4
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Expected O, but got Unknown
		//IL_00e7: Expected O, but got I4
		//IL_0117: Expected O, but got I4
		//IL_017f: Expected O, but got I4
		if (giftBomb.<IsClaimed>k__BackingField)
		{
			object obj = typeof(DataRelation) + 712;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X0_v8+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			DateTime now = DateTime.Now;
			TimeSpan timeSpan = now - giftBomb.<DateCreated>k__BackingField;
			object obj4 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1032;
			object obj5 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X0_v13+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj7 = giftBomb.<NumberOfShards>k__BackingField * 1374389535;
			object obj8 = obj7 >> 36;
			object obj9 = obj8 + obj8;
			double value = (double)obj9 + 2.0;
			TimeSpan timeSpan2 = TimeSpan.FromMinutes(value);
			bool flag3 = timeSpan > timeSpan2;
			bool flag4 = !flag3;
			object obj10 = !flag4;
			if (obj10 != null)
			{
				return;
			}
		}
		Populate(giftBomb);
		PopupUI popupUI = popup;
		if (!popupUI.<IsCurrentlyShown>k__BackingField)
		{
			Show();
		}
	}

	private void ClearGiftBomb(GiftBombData giftBomb)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_00b6: Expected I, but got O
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)1104;
		Action action = default(Action);
		PopupUI popupUI;
		while (true)
		{
			SetAsClaimed();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			action..ctor(this, (IntPtr)obj2);
			popupUI = popup;
			if (popupUI.<IsCurrentlyShown>k__BackingField)
			{
				break;
			}
			IntPtr invoke_impl = ((Delegate)action).invoke_impl;
			IntPtr method_code = ((Delegate)action).method_code;
			IntPtr method = ((Delegate)action).method;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v99 @ X2_v2 (System.IntPtr) (should have been resolved before IL gen)");
		}
		popupUI.SlideToRight(action);
	}

	private void CheckIfBombExist()
	{
		GiftBombManager bombManager = _bombManager;
		if (bombManager._currentGiftBomb != null && !bombManager.CurrentBombIsAlreadyClaimed())
		{
			GiftBombManager bombManager2 = _bombManager;
			ShowCurrentGiftBomb(bombManager2._currentGiftBomb);
		}
	}

	private void Show()
	{
		//IL_0059: Expected F4, but got I4
		//IL_0072: Expected O, but got I4
		if (ChatHandler.ChatActive)
		{
			int num = UnityEngine.Random.Range(200, 740);
			UIExtensions.MoveTo(y: num, gObject: panel, isWorldPositions: false, x: (float?)(object)0);
			popup.SlideFromRight();
		}
	}

	private void RandomizePanelPosition()
	{
		//IL_0027: Expected F4, but got I4
		//IL_0040: Expected O, but got I4
		int num = UnityEngine.Random.Range(200, 740);
		UIExtensions.MoveTo(y: num, gObject: panel, isWorldPositions: false, x: (float?)(object)0);
	}

	private void Populate(GiftBombData giftBombData)
	{
		AvatarData data = giftBombData.<Creator>k__BackingField;
		avatar.Initialize(data);
		SetMessage(giftBombData.<Message>k__BackingField);
		ShowEffect(giftBombData);
		SetAmountOnButton(giftBombData.<CurrencyPerShard>k__BackingField);
		if (_bombManager.CurrentBombIsAlreadyClaimed())
		{
			SetAsClaimed();
		}
		else if (giftBombData.<CaptchaPath>k__BackingField != null)
		{
			swipeCaptcha.InitPath(giftBombData.<CaptchaPath>k__BackingField);
		}
	}

	private void SetMessage(string msg)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_0103: Expected O, but got I4
		//IL_0151: Expected O, but got I4
		object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 2536;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E765D]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v6+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v6+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag2 = StringsExtensions.IsNullOrEmpty(msg);
		Component component = messageText;
		bool flag3 = !flag2;
		object obj5 = !flag3;
		Component component2 = messageText;
		if (obj5 != null)
		{
			goto IL_00b2;
		}
		goto IL_0169;
		IL_00b2:
		GameObject gameObject = component.gameObject;
		gameObject.SetActive(value: false);
		return;
		IL_0169:
		GameObject gameObject2 = component2.gameObject;
		gameObject2.SetActive(value: true);
		TextMeshProExtensions.FixArabic(messageText, msg);
		return;
		IL_0074:
		bool flag4 = StringsExtensions.IsNullOrEmpty(msg);
		component = messageText;
		bool flag5 = !flag4;
		component2 = messageText;
		if (!flag5)
		{
			goto IL_00b2;
		}
		goto IL_0169;
	}

	private void ShowEffect(GiftBombData giftBomb)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_00d9: Expected O, but got I4
		if (giftBomb == null)
		{
			return;
		}
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		object obj2 = (nint)0 + (nint)48;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X0_v3+E4]");
		UnityEngine.Object obj5;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE90D8");
			UnityEngine.Object obj4 = default(UnityEngine.Object);
			bool flag = obj4;
			bool flag2 = !flag;
			obj5 = obj4;
			if (flag2)
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE90D8");
			UnityEngine.Object obj6 = default(UnityEngine.Object);
			bool flag3 = obj6;
			bool flag4 = !flag3;
			object obj7 = !flag4;
			obj5 = obj6;
			if (obj7 == null)
			{
				return;
			}
		}
		((CurrencyParticleEffect)obj5).StartEffect(giftBomb);
	}

	private void SetAmountOnButton(int shardPrice)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object obj = "Material with texture name \"" + 3224;
		int num = default(int);
		string text = num.ToString((string)obj);
		amountReceived.text = text;
		string text2 = num.ToString((string)obj);
		amount.text = text2;
	}

	private void ShowUserMessage(string msg)
	{
		GameObject gameObject = messageText.gameObject;
		gameObject.SetActive(value: true);
		TextMeshProExtensions.FixArabic(messageText, msg);
	}

	private void HideUserMessage()
	{
		GameObject gameObject = messageText.gameObject;
		gameObject.SetActive(value: false);
	}

	private void SetAsClaimed()
	{
		GameObject gameObject = claimButton.gameObject;
		gameObject.SetActive(value: false);
		claimedState.SetActive(value: true);
		swipeCaptcha.Interactable = false;
	}

	private void Clear()
	{
		//IL_0087: Expected O, but got I4
		//IL_0097: Expected O, but got I
		//IL_00a7: Expected O, but got I
		GameObject gameObject = claimButton.gameObject;
		gameObject.SetActive(value: true);
		claimButton.interactable = true;
		claimedState.SetActive(value: false);
		GameObject gameObject2 = messageText.gameObject;
		gameObject2.SetActive(value: false);
		object obj = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X8_v3+90]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X8_v4+B8]");
		object text = 0;
		messageText.text = (string)text;
		avatar.Clear();
		HideSwipeArea();
	}

	private void Hide(Action onComplete)
	{
		PopupUI popupUI = popup;
		if (popupUI.<IsCurrentlyShown>k__BackingField)
		{
			popupUI.SlideToRight(onComplete);
			return;
		}
		IntPtr invoke_impl = ((Delegate)onComplete).invoke_impl;
		IntPtr method_code = ((Delegate)onComplete).method_code;
		IntPtr method = ((Delegate)onComplete).method;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v61 @ X2_v1 (System.IntPtr) (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}

	private void ShowSwipeArea()
	{
		//IL_00a2: Expected O, but got I4
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_0031: Expected O, but got I
		//IL_0078: Expected I, but got O
		TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore = DOTweenModuleUI.DOSizeDelta(panel, (Vector2)0, 1315f);
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2344;
		object obj2 = (nint)0 + (nint)1080;
		object obj3 = (nint)0 + (nint)2504;
		Transform target = swipeCaptcha.transform;
		TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore2 = ShortcutExtensions.DOScaleY(target, 1f, 0.4f);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TweenCallback tweenCallback = default(TweenCallback);
		tweenCallback..ctor(this, (IntPtr)obj2);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058630");
	}

	private void HideSwipeArea()
	{
		//IL_0015: Expected O, but got I4
		//IL_0054: Expected O, but got I4
		//IL_0054: Expected O, but got I4
		panel.sizeDelta = (Vector2)0;
		Transform transform = swipeCaptcha.transform;
		float? y = 0f;
		UIExtensions.Scale(transform, (float?)(object)0, y, (float?)(object)0);
		swipeCaptcha.Clear();
	}

	private void <ShowSwipeArea>b__43_0()
	{
		swipeCaptcha.ShowPathStart();
	}
}
