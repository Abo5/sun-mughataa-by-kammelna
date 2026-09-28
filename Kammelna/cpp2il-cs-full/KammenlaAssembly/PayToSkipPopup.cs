using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Runtime.Remoting.Messaging;
using System.Threading;
using Cpp2ILInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Kammelna.Server;
using Kammelna.Server.Models.Clans;
using Sfs2X.Entities;
using TMPro;
using Unity.Properties;
using UnityEngine;
using UnityEngine.InputSystem.XR;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;

public class PayToSkipPopup : MonoBehaviour
{
	private PopupUI popup;

	private GameObject defaultView;

	private GameObject getAcesView;

	private GameObject watchAdContainer;

	private GameObject acesToPayContainer;

	private TextMeshProUGUI acesToPayText;

	private Button playButtonCover;

	private Sprite watchAdSprite;

	private GameObject playButton;

	private Transform _originalParent;

	private Action _watchAdAction;

	private Action _payCoinsAction;

	private Image _buttonImageClone;

	private RectTransform _buttonBounds;

	private void Awake()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_00b8: Expected O, but got I
		//IL_00ec: Expected O, but got I4
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected O, but got Unknown
		//IL_0057: Expected O, but got I
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Expected O, but got Unknown
		//IL_0090: Expected I, but got O
		object obj = typeof(Queue<string>) + 848;
		object obj2 = (nint)0 + (nint)2200;
		GameObject go = base.gameObject;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		object obj5 = typeof(SqlSingle[]) + 2376;
		object obj6 = (nint)0 + (nint)3024;
		object varName = "not" + 3704;
		SessionModel sessionModel = default(SessionModel);
		User localUser = sessionModel.LocalUser;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj6);
		VariableBinderExtensions.Bind(go, localUser, (string)varName, action);
	}

	private void RefreshUi()
	{
		SetupLabel();
		SetVisibleButton();
	}

	public void Popup(GameObject button, RectTransform buttonBounds, Image image, Action watchAdAction, Action payCoinsAction)
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected O, but got Unknown
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected O, but got Unknown
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected O, but got Unknown
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Expected O, but got Unknown
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Expected O, but got Unknown
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Expected O, but got Unknown
		//IL_0142: Expected O, but got I
		//IL_0161: Expected O, but got I
		//IL_01c0: Expected O, but got I
		//IL_01de: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e3: Expected O, but got Unknown
		//IL_021f: Expected O, but got I4
		//IL_02d7: Expected O, but got I4
		//IL_02f7: Expected O, but got I4
		//IL_0317: Expected O, but got I4
		//IL_0337: Expected O, but got I4
		//IL_0352: Expected O, but got I
		//IL_039a: Unknown result type (might be due to invalid IL or missing references)
		//IL_039f: Expected O, but got Unknown
		//IL_03b4: Expected O, but got I
		//IL_03ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bf: Expected O, but got Unknown
		//IL_0493: Expected O, but got I4
		//IL_049c: Expected O, but got I4
		//IL_0410: Expected O, but got I4
		//IL_0419: Expected O, but got I4
		//IL_0422: Expected O, but got I4
		//IL_044f: Expected O, but got I4
		//IL_04d9: Expected O, but got I4
		//IL_052a: Expected O, but got I
		//IL_0561: Expected O, but got I4
		//IL_05bf: Expected O, but got I
		//IL_05ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d3: Expected O, but got Unknown
		//IL_05df: Expected O, but got I
		//IL_0613: Expected O, but got I4
		//IL_06ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_06bf: Expected O, but got Unknown
		//IL_06dd: Expected O, but got I
		//IL_06a1: Expected O, but got I4
		//IL_0703: Unknown result type (might be due to invalid IL or missing references)
		//IL_0708: Expected O, but got Unknown
		//IL_0720: Expected O, but got I
		//IL_072e: Expected O, but got I4
		//IL_073f: Expected O, but got I
		//IL_074b: Expected O, but got I
		//IL_07c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c5: Expected O, but got Unknown
		//IL_07d1: Expected O, but got I
		//IL_07e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e5: Expected O, but got Unknown
		//IL_0814: Expected I, but got O
		//IL_083e: Expected O, but got I4
		defaultView.SetActive(value: true);
		getAcesView.SetActive(value: false);
		object obj = this + 120;
		obj = payCoinsAction;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj2 = this + 112;
		obj2 = watchAdAction;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj3 = this + 96;
		obj3 = button;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj4 = this + 136;
		obj4 = buttonBounds;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		SetupLabel();
		SetVisibleButton();
		Transform transform = ((GameObject)obj3).transform;
		object obj5 = typeof(System.Buffers.Text.ParserHelpers) + 3600;
		object obj12;
		object obj13;
		if (transform == obj5)
		{
			Transform parent = transform.parent;
			object obj6 = this + 104;
			obj6 = parent;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v271 @ X24_v5-48]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v226 @ X8_v8+28]");
			((Transform)0).SetParent(transform, worldPositionStays: true);
			Transform transform2 = base.transform;
			UIExtensions.AttachToCanvas(transform2, CanvasLayer.SecondaryCanvas);
			Component component = popup;
			Transform parent2 = popup.transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ X0_v30 (UnityEngine.Component)+28]");
			((Transform)0).SetParent(parent2, worldPositionStays: true);
			PopupUI popupUI = popup;
			object obj8 = typeof(SqlSingle[]) + 3912;
			transform.SetParent(popupUI.blocker);
			object obj9 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v416 @ X0_v34+E4]");
			bool flag = (nint)0 == 0;
			object obj10 = !flag;
			if (obj10 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			AnimationExtensions.AnimPulsing((Transform)obj4, 0.7f, 1.04f, 1f);
			GameObject gameObject = playButtonCover.gameObject;
			gameObject.SetActive(value: true);
			RectTransform rectTransform = UIExtensions.rectTransform(playButtonCover);
			Transform parent3 = buttonBounds.parent;
			rectTransform.SetParent(parent3);
			Vector2 anchoredPosition = buttonBounds.anchoredPosition;
			rectTransform.anchoredPosition = (Vector2)0;
			Vector2 sizeDelta = buttonBounds.sizeDelta;
			rectTransform.sizeDelta = (Vector2)0;
			Vector2 anchorMin = buttonBounds.anchorMin;
			rectTransform.anchorMin = (Vector2)0;
			Vector2 anchorMax = buttonBounds.anchorMax;
			rectTransform.anchorMax = (Vector2)0;
			PopupUI popupUI2 = popup;
			object obj11 = (nint)0 + (nint)3872;
			rectTransform.SetParent(popupUI2.blocker);
			rectTransform.SetAsLastSibling();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
			obj12 = typeof(MemberAchievementClanFeedData) + 2976;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ X0_v61+D8]");
			Image image2 = default(Image);
			image2.sprite = (Sprite)0;
			obj13 = this + 128;
			object obj14 = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v463 @ X0_v63+E4]");
			object obj17;
			object obj16;
			if ((nint)0 != 0)
			{
				bool flag2 = (UnityEngine.Object)obj13 != null;
				bool flag3 = !flag2;
				object obj15 = !flag3;
				obj16 = 0;
				obj17 = 0;
				UnityEngine.Object obj18 = null;
				if (obj15 == null)
				{
					goto IL_0435;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				bool flag4 = (UnityEngine.Object)obj13 != null;
				bool flag5 = !flag4;
				obj16 = 0;
				obj17 = 0;
				UnityEngine.Object obj18 = null;
				if (flag5)
				{
					goto IL_0435;
				}
			}
			object obj19 = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v482 @ X0_v113+E4]");
			bool flag6 = (nint)0 == 0;
			object obj20 = !flag6;
			if (obj20 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			UnityEngine.Object.Destroy((UnityEngine.Object)obj13);
			obj16 = obj17;
			goto IL_050c;
		}
		throw new InvalidCastException();
		IL_0435:
		bool flag7 = (object)image == null;
		object obj21 = !flag7;
		if (obj21 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_050c;
		IL_050c:
		Transform transform3 = image.transform;
		object obj22 = (nint)0 + (nint)936;
		Transform parent4 = transform3.parent;
		object obj23 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v494 @ X0_v68+E4]");
		bool flag8 = (nint)0 == 0;
		object obj24 = !flag8;
		if (obj24 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE9DE4");
		object obj25 = default(object);
		obj13 = obj25;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		((Image)obj13).sprite = watchAdSprite;
		object obj26 = (nint)0 + (nint)288;
		object obj27 = typeof(Queue<string>) + 848;
		object obj28 = (nint)0 + (nint)2200;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3120C");
		object obj29 = obj27;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v509 @ X0_v77+E4]");
		bool flag9 = (nint)0 == 0;
		object obj30 = !flag9;
		if (obj30 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel = default(SessionModel);
		User localUser = sessionModel.LocalUser;
		RankedPlayCondition playingCondition = SFSKammelnaUserExtensions.GetPlayingCondition(localUser);
		if (playingCondition == RankedPlayCondition.ShouldPay)
		{
			bool flag10 = CanPayToJoinGame();
			bool flag11 = !flag10;
			object obj31 = !flag11;
			if (obj31 != null)
			{
				goto IL_06d2;
			}
		}
		object text = "Unsupported map type" + 3672;
		TextMeshProUGUI textMeshProUGUI = default(TextMeshProUGUI);
		TextMeshProExtensions.Localize(textMeshProUGUI, (string)text);
		goto IL_06d2;
		IL_06d2:
		textMeshProUGUI.color = (Color)0;
		Transform transform4 = ((Component)obj13).transform;
		object obj32 = typeof(UsageHint) + 816;
		object obj33 = obj32;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v554 @ X8_v34+B8]");
		object obj34 = 0;
		transform4.localScale = (Vector3)0;
		object obj35 = (nint)0 + (nint)2776;
		object obj36 = (nint)0 + (nint)2904;
		Transform target = ((Component)obj13).transform;
		TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = ShortcutExtensions.DOScale(target, 1f, 0.3f);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058C78");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
		playButtonCover.targetGraphic = _buttonImageClone;
		PopupUI popupUI3 = popup;
		object obj37 = typeof(SqlSingle[]) + 2376;
		object obj38 = (nint)0 + (nint)3016;
		object obj39 = typeof(RegisteredWaitHandle) + 3136;
		GameObject gameObject2 = popupUI3.content.gameObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj38);
		object obj40 = obj39;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v579 @ X0_v99+E4]");
		bool flag12 = (nint)0 == 0;
		object obj41 = !flag12;
		if (obj41 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		ScreenManager.PushPopup(gameObject2, action);
		popup.PopFromCenter();
	}

	public void Hide()
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0066: Expected O, but got I4
		Transform transform = playButton.transform;
		object obj = typeof(SqlSingle[]) + 3912;
		transform.SetParent(_originalParent);
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X0_v6+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		AnimationExtensions.AnimEndAnimation(_buttonBounds);
		TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = ShortcutExtensions.DOScale(_buttonBounds, 1f, 0.1f);
		GameObject gameObject = playButtonCover.gameObject;
		gameObject.SetActive(value: false);
		Transform target = _buttonImageClone.transform;
		int num = ShortcutExtensions.DOKill(target);
		Transform target2 = _buttonImageClone.transform;
		TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore2 = ShortcutExtensions.DOScale(target2, 0f, 0.1f);
		popup.ShrinkToParent();
	}

	public void PayAcesClicked()
	{
		if (CanPayToJoinGame())
		{
			Hide();
			Action payCoinsAction = _payCoinsAction;
			if (_payCoinsAction == null)
			{
				return;
			}
			IntPtr invoke_impl = ((Delegate)payCoinsAction).invoke_impl;
			IntPtr method_code = ((Delegate)payCoinsAction).method_code;
			IntPtr method = ((Delegate)payCoinsAction).method;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v23 @ X2_v1 (System.IntPtr) (should have been resolved before IL gen)");
		}
		ShowNotEnoughAces();
	}

	private static bool CanPayToJoinGame()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00da: Expected O, but got I
		//IL_0104: Expected O, but got I4
		//IL_00b5: Expected O, but got I4
		//IL_005c: Expected O, but got I
		//IL_0230: Expected I4, but got O
		//IL_01ca: Expected O, but got I4
		//IL_01ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f3: Expected I4, but got Unknown
		object obj = 152985600;
		object obj2 = typeof(Queue<string>) + 848;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E635D]");
		object obj3 = (nint)0 & (nint)1;
		object obj6;
		object obj4;
		if (obj3 != null)
		{
			obj4 = (nint)0 + (nint)2200;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v11+E4]");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v11+E4]");
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
		SessionModel sessionModel = default(SessionModel);
		bool flag3 = (object)sessionModel == null;
		obj4 = obj6;
		if (!flag3)
		{
			goto IL_0158;
		}
		goto IL_0222;
		IL_0222:
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
		IL_0158:
		User localUser = sessionModel.LocalUser;
		int aces = SFSKammelnaUserExtensions.GetAces(localUser);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel2 = default(SessionModel);
		if ((object)sessionModel2 != null)
		{
			User localUser2 = sessionModel2.LocalUser;
			int joinRankedGamePrice = SFSKammelnaUserExtensions.GetJoinRankedGamePrice(localUser2);
			object obj8 = aces - joinRankedGamePrice;
			bool flag4 = (nint)obj8 < 0;
			int num = aces ^ joinRankedGamePrice;
			int num2 = aces ^ obj8;
			int num3 = num & num2;
			bool flag5 = num3 < 0;
			return flag4 == flag5;
		}
		goto IL_0222;
		IL_0091:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		bool flag6 = (object)sessionModel == null;
		object obj9 = !flag6;
		if (obj9 != null)
		{
			goto IL_0158;
		}
		goto IL_0222;
	}

	private unsafe void SetupLabel()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_01ea: Expected O, but got I
		//IL_021e: Expected O, but got I4
		//IL_005e: Expected O, but got I4
		//IL_009a: Expected O, but got I4
		//IL_00bb: Expected O, but got Ref
		//IL_00e0: Expected O, but got Ref
		//IL_00f6: Expected I, but got O
		//IL_0106: Expected O, but got I
		//IL_012f: Expected O, but got I
		//IL_016e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0173: Expected O, but got Unknown
		//IL_017c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Expected O, but got Unknown
		object obj = typeof(TypeConverter<ushort, char>) + 3400;
		object obj2 = typeof(Queue<string>) + 848;
		object obj3 = (nint)0 + (nint)2200;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel = default(SessionModel);
		bool flag2 = (object)sessionModel == null;
		object obj6 = 1;
		IndexOutOfRangeException ex = default(IndexOutOfRangeException);
		if (!flag2)
		{
			User localUser = sessionModel.LocalUser;
			int joinRankedGamePrice = SFSKammelnaUserExtensions.GetJoinRankedGamePrice(localUser);
			object obj7 = 153100288 + 1024;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
			object[] array = default(object[]);
			bool flag3 = array == null;
			int num = default(int);
			obj6 = (object)(&num);
			if (!flag3)
			{
				object obj8 = default(object);
				bool flag4 = obj8 == null;
				object obj9 = (object)(&num);
				if (!flag4)
				{
					nint num2 = (nint)array;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X8_v11 (Il2CppClass<System.Object[]>)+40]");
					obj9 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag5 = ex == null;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X8_v11 (Il2CppClass<System.Object[]>)+40]");
					obj6 = 0;
					if (flag5)
					{
						goto IL_01c8;
					}
				}
				bool flag6 = array.Length == 0;
				obj6 = obj9;
				if (!flag6)
				{
					object text = "October" + 3600;
					object obj10 = array + 32;
					obj10 = obj8;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					TextMeshProExtensions.Localize(acesToPayText, (string)text, array);
					return;
				}
				goto IL_01ba;
			}
		}
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_01ba;
		IL_01ba:
		ex = new IndexOutOfRangeException();
		goto IL_01c8;
		IL_01c8:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		throw new OutOfMemoryException();
	}

	private void SetVisibleButton()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00da: Expected O, but got I
		//IL_0104: Expected O, but got I4
		//IL_00b5: Expected O, but got I4
		//IL_005c: Expected O, but got I
		object obj = 152985600;
		object obj2 = typeof(Queue<string>) + 848;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E635F]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = (nint)0 + (nint)2200;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v10+E4]");
			bool flag = (nint)0 == 0;
			object obj6 = obj4;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			object obj4 = (nint)0 + (nint)2200;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v10+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			object obj6 = obj4;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		goto IL_0133;
		IL_0133:
		SessionModel sessionModel = default(SessionModel);
		User localUser = sessionModel.LocalUser;
		RankedPlayCondition playingCondition = SFSKammelnaUserExtensions.GetPlayingCondition(localUser);
		bool flag4;
		if (playingCondition == RankedPlayCondition.ShouldPay)
		{
			bool flag3 = CanPayToJoinGame();
			flag4 = flag3;
		}
		else
		{
			flag4 = false;
		}
		watchAdContainer.SetActive(flag4);
		bool active = (byte)((flag4 ? 1u : 0u) ^ 1u) != 0;
		acesToPayContainer.SetActive(active);
		return;
		IL_0091:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		bool flag5 = (object)sessionModel == null;
		object obj8 = !flag5;
		if (obj8 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_0133;
	}

	private void ShowNotEnoughAces()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00e6: Expected O, but got I4
		//IL_00a3: Expected O, but got I4
		//IL_0127: Expected O, but got I
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Expected O, but got Unknown
		//IL_0147: Expected O, but got I
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Expected O, but got Unknown
		//IL_0222: Expected O, but got I
		//IL_025d: Expected O, but got I8
		//IL_0279: Expected O, but got I4
		//IL_0178: Expected I, but got O
		//IL_01f3: Expected O, but got I
		//IL_02b5: Expected O, but got I
		//IL_02e9: Expected O, but got I4
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3848;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6360]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v35+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v35+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Sequence s = DOTween.Sequence();
		PopupUI popupUI = popup;
		goto IL_011b;
		IL_011b:
		object obj5 = (nint)0 + (nint)2848;
		object obj6 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2344;
		object obj7 = (nint)0 + (nint)3008;
		object obj8 = typeof(UsageHint) + 816;
		object obj9 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X8_v6+B8]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X8_v7+18]");
		object obj11 = default(object);
		float duration = 0f * (float)obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X8_v7+20]");
		object obj12 = 0 * 3266576384L;
		TweenerCore<Quaternion, Vector3, QuaternionOptions> tweenerCore = ShortcutExtensions.DOLocalRotate(popupUI.content, (Vector3)0, duration);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
		Tween t = default(Tween);
		Sequence s2 = TweenSettingsExtensions.Append(s, t);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TweenCallback tweenCallback = default(TweenCallback);
		tweenCallback..ctor(this, (IntPtr)obj7);
		Sequence s3 = TweenSettingsExtensions.AppendCallback(s2, tweenCallback);
		TweenCallback callback = TweenHelpers.Disable(defaultView);
		Sequence s4 = TweenSettingsExtensions.AppendCallback(s3, callback);
		TweenCallback callback2 = TweenHelpers.Enable(getAcesView);
		Sequence s5 = TweenSettingsExtensions.AppendCallback(s4, callback2);
		PopupUI popupUI2 = popup;
		object obj13 = (nint)0 + (nint)2912;
		object obj14 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ X8_v14+B8]");
		object obj15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ X8_v15+18]");
		float duration2 = 0f * 0f;
		TweenerCore<Quaternion, Vector3, QuaternionOptions> tweenerCore2 = ShortcutExtensions.DOLocalRotate(popupUI2.content, (Vector3)0, duration2);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
		Tween t2 = default(Tween);
		Sequence sequence = TweenSettingsExtensions.Append(s5, t2);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
		return;
		IL_0074:
		s = DOTween.Sequence();
		popupUI = popup;
		bool flag2 = (object)popup == null;
		object obj16 = !flag2;
		if (obj16 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_011b;
	}

	public void WatchAdAnyway()
	{
		Hide();
		Action watchAdAction = _watchAdAction;
		if (_watchAdAction != null)
		{
			IntPtr invoke_impl = ((Delegate)watchAdAction).invoke_impl;
			IntPtr method_code = ((Delegate)watchAdAction).method_code;
			IntPtr method = ((Delegate)watchAdAction).method;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v15 @ X2_v1 (System.IntPtr) (should have been resolved before IL gen)");
		}
	}

	public void OnMainButtonClicked()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_019b: Expected O, but got I
		//IL_01c5: Expected O, but got I4
		//IL_005c: Expected O, but got I
		//IL_00d3: Expected I, but got O
		//IL_020e: Expected O, but got I4
		//IL_011e: Expected I, but got O
		//IL_017a: Expected O, but got I4
		object obj = 152985600;
		object obj2 = typeof(Queue<string>) + 848;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6361]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = (nint)0 + (nint)2200;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v7+E4]");
			bool flag = (nint)0 == 0;
			object obj6 = obj4;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			object obj4 = (nint)0 + (nint)2200;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v7+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			object obj6 = obj4;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel = default(SessionModel);
		bool flag3 = (object)sessionModel == null;
		object obj8 = !flag3;
		if (obj8 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_00a0;
		IL_0256:
		Action action;
		IntPtr invoke_impl = ((Delegate)action).invoke_impl;
		IntPtr method_code = ((Delegate)action).method_code;
		IntPtr method = ((Delegate)action).method;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v148 @ X2_v1 (System.IntPtr) (should have been resolved before IL gen)");
		goto IL_0287;
		IL_00a0:
		User localUser = sessionModel.LocalUser;
		RankedPlayCondition playingCondition = SFSKammelnaUserExtensions.GetPlayingCondition(localUser);
		bool flag4 = playingCondition == RankedPlayCondition.ShouldWatchAds;
		nint num = unchecked((nint)null);
		if (!flag4)
		{
			if (playingCondition != RankedPlayCondition.ShouldPay)
			{
				return;
			}
			bool flag5 = CanPayToJoinGame();
			bool flag6 = !flag5;
			num = unchecked((nint)null);
			if (!flag6)
			{
				if (CanPayToJoinGame())
				{
					Hide();
					action = _payCoinsAction;
					bool flag7 = _payCoinsAction == null;
					object obj9 = !flag7;
					if (obj9 == null)
					{
						return;
					}
					goto IL_0256;
				}
				goto IL_0287;
			}
		}
		Hide();
		action = _watchAdAction;
		if (_watchAdAction == null)
		{
			return;
		}
		goto IL_0256;
		IL_0091:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		goto IL_00a0;
		IL_0287:
		ShowNotEnoughAces();
	}

	private void <ShowNotEnoughAces>b__22_0()
	{
		//IL_0031: Expected O, but got I4
		PopupUI popupUI = popup;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
		popupUI.content.localEulerAngles = (Vector3)0;
	}
}
