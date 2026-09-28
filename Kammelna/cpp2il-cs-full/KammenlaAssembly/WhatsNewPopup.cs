using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Data.SqlTypes;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem.XR;
using UnityEngine.Purchasing.Telemetry;

public class WhatsNewPopup : MonoBehaviour
{
	private MainMenuEventsChannel _mainMenuEventsChannel;

	private JackarooWhatsNewPopupUI _popupExtraGameObject;

	private void Start()
	{
		//IL_0016: Expected O, but got I
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Expected O, but got Unknown
		//IL_010a: Expected O, but got I
		//IL_0124: Expected O, but got I4
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_005d: Expected O, but got I
		//IL_016a: Expected O, but got I4
		//IL_01bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c4: Expected O, but got Unknown
		//IL_024a: Expected O, but got I4
		//IL_0267: Unknown result type (might be due to invalid IL or missing references)
		//IL_026c: Expected O, but got Unknown
		//IL_0296: Expected O, but got I4
		//IL_02bf: Expected O, but got I
		//IL_0311: Unknown result type (might be due to invalid IL or missing references)
		//IL_0316: Expected O, but got Unknown
		//IL_032c: Expected O, but got I
		//IL_033a: Expected I, but got O
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E63CB]");
		object obj = (nint)0 & (nint)1;
		object obj2;
		object obj4;
		if (obj != null)
		{
			obj2 = typeof(System.Buffers.Text.ParserHelpers) + 1624;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E63CC]");
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
			obj2 = typeof(System.Buffers.Text.ParserHelpers) + 1624;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E63CC]");
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X0_v22+E4]");
		bool flag3 = (nint)0 == 0;
		object obj8 = !flag3;
		if (obj8 != null)
		{
			goto IL_00af;
		}
		goto IL_0178;
		IL_01b0:
		object obj9 = typeof(UsageHint) + 72;
		object obj10 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X0_v3+E4]");
		if ((nint)0 != 0)
		{
			if (UserInfo.SawWhatsNewForJackaroo)
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool sawWhatsNewForJackaroo = UserInfo.SawWhatsNewForJackaroo;
			bool flag4 = !sawWhatsNewForJackaroo;
			object obj11 = !flag4;
			if (obj11 != null)
			{
				return;
			}
		}
		object obj12 = typeof(Queue<string>) + 792;
		object obj13 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X0_v5+E4]");
		bool flag5 = (nint)0 == 0;
		object obj14 = !flag5;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj15 = (nint)0 + (nint)2104;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		NotificationsManager notificationsManager = default(NotificationsManager);
		List<Notification> activeForcedNotifications = notificationsManager.ActiveForcedNotifications;
		if (activeForcedNotifications._size != 0)
		{
			object obj16 = typeof(SqlSingle[]) + 2376;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj17 = (nint)0 + (nint)1680;
			Action action = default(Action);
			action..ctor(this, (IntPtr)obj17);
			_mainMenuEventsChannel.OnForcedNotificationsClosed += action;
		}
		else
		{
			ShowWhatsNewPopup();
		}
		return;
		IL_00af:
		Games currentGame = Preferences.CurrentGame;
		if (currentGame != Games.Jackaroo)
		{
			return;
		}
		goto IL_01b0;
		IL_0178:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Games currentGame2 = Preferences.CurrentGame;
		if (currentGame2 == Games.Jackaroo)
		{
			goto IL_01b0;
		}
		return;
		IL_0082:
		obj7 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X0_v22+E4]");
		if ((nint)0 != 0)
		{
			goto IL_00af;
		}
		goto IL_0178;
	}

	private void OnDestroy()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_004d: Expected I, but got O
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)1680;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		_mainMenuEventsChannel.OnForcedNotificationsClosed -= action;
	}

	private void OnForcedNotificationsClosed()
	{
		ShowWhatsNewPopup();
	}

	private static bool PreConditionsMet()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_0144: Expected O, but got I4
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Expected O, but got Unknown
		//IL_00db: Expected O, but got I4
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 1624;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E63CC]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v3+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Games currentGame = Preferences.CurrentGame;
		if (currentGame == Games.Jackaroo)
		{
			goto IL_009d;
		}
		goto IL_0187;
		IL_009d:
		object obj5 = typeof(UsageHint) + 72;
		object obj6 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X0_v15+E4]");
		bool flag2 = (nint)0 == 0;
		object obj7 = !flag2;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool sawWhatsNewForJackaroo = UserInfo.SawWhatsNewForJackaroo;
		return (byte)((sawWhatsNewForJackaroo ? 1u : 0u) ^ 1u) != 0;
		IL_0187:
		return false;
		IL_0074:
		Games currentGame2 = Preferences.CurrentGame;
		if (currentGame2 == Games.Jackaroo)
		{
			goto IL_009d;
		}
		goto IL_0187;
	}

	private void ShowWhatsNewPopup()
	{
		//IL_0016: Expected O, but got I
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Expected O, but got Unknown
		//IL_010a: Expected O, but got I
		//IL_0124: Expected O, but got I4
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_005d: Expected O, but got I
		//IL_016a: Expected O, but got I4
		//IL_01bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c4: Expected O, but got Unknown
		//IL_024a: Expected O, but got I4
		//IL_0267: Unknown result type (might be due to invalid IL or missing references)
		//IL_026c: Expected O, but got Unknown
		//IL_0296: Expected O, but got I4
		//IL_02bf: Expected O, but got I
		//IL_02eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f0: Expected O, but got Unknown
		//IL_02fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ff: Expected O, but got Unknown
		//IL_0307: Expected I, but got O
		//IL_0317: Expected O, but got I
		//IL_03c1: Expected O, but got I4
		//IL_040d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0412: Expected O, but got Unknown
		//IL_041e: Expected O, but got I
		//IL_0436: Expected O, but got I
		//IL_0352: Expected O, but got I
		//IL_04e0: Expected O, but got I4
		//IL_0471: Expected O, but got I
		//IL_03dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e1: Expected O, but got Unknown
		//IL_03ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ef: Expected O, but got Unknown
		//IL_053e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0543: Expected O, but got Unknown
		//IL_055b: Expected O, but got I
		//IL_0360: Unknown result type (might be due to invalid IL or missing references)
		//IL_0365: Expected O, but got Unknown
		//IL_036e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0373: Expected O, but got Unknown
		//IL_05f1: Expected O, but got I
		//IL_0615: Expected O, but got I4
		//IL_0509: Unknown result type (might be due to invalid IL or missing references)
		//IL_050e: Expected O, but got Unknown
		//IL_0688: Expected O, but got I
		//IL_0596: Expected O, but got I
		//IL_047f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0484: Expected O, but got Unknown
		//IL_048d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0492: Expected O, but got Unknown
		//IL_071e: Expected O, but got I
		//IL_0738: Expected O, but got I
		//IL_075a: Expected O, but got I4
		//IL_0763: Expected O, but got I4
		//IL_07dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e2: Expected O, but got Unknown
		//IL_07f8: Expected O, but got I
		//IL_0806: Expected I, but got O
		//IL_06c3: Expected O, but got I
		//IL_0631: Unknown result type (might be due to invalid IL or missing references)
		//IL_0636: Expected O, but got Unknown
		//IL_064c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0651: Expected O, but got Unknown
		//IL_0661: Expected O, but got I
		//IL_0820: Expected O, but got I
		//IL_05a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a9: Expected O, but got Unknown
		//IL_05b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b7: Expected O, but got Unknown
		//IL_077f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0784: Expected O, but got Unknown
		//IL_079a: Unknown result type (might be due to invalid IL or missing references)
		//IL_079f: Expected O, but got Unknown
		//IL_07af: Expected O, but got I
		//IL_07c9: Expected O, but got I
		//IL_06d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d6: Expected O, but got Unknown
		//IL_06df: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e4: Expected O, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E63CD]");
		object obj = (nint)0 & (nint)1;
		object obj2;
		object obj4;
		if (obj != null)
		{
			obj2 = typeof(System.Buffers.Text.ParserHelpers) + 1624;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E63CC]");
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
			obj2 = typeof(System.Buffers.Text.ParserHelpers) + 1624;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E63CC]");
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X0_v47+E4]");
		bool flag3 = (nint)0 == 0;
		object obj8 = !flag3;
		if (obj8 != null)
		{
			goto IL_00af;
		}
		goto IL_0178;
		IL_0821:
		throw new NullReferenceException();
		IL_051d:
		Component component = default(Component);
		GameObject gameObject = component.gameObject;
		object obj9 = typeof(System.IOAsyncCallback) + 368;
		object obj11 = default(object);
		object obj10 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v550 @ X8_v25+12E]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v550 @ X8_v25+12E]");
		if ((nint)0 == 0)
		{
			goto IL_05d7;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v550 @ X8_v25+B0]");
		object obj13 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v312 @ X10_v14-8]");
			if (0 == (nint)obj9)
			{
				break;
			}
			obj13 += 16;
			obj12--;
			if ((nint)obj12 != 1)
			{
				continue;
			}
			goto IL_05d7;
		}
		object obj14 = obj13 + 1;
		object obj15 = obj10 + obj14;
		object obj16 = obj15 + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v585 @ X0_v30+8]");
		object obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v585 @ X0_v30] (should have been resolved before IL gen)");
		goto IL_0670;
		IL_04b2:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v527 @ X0_v33] (should have been resolved before IL gen)");
		bool flag4 = (object)component == null;
		object obj18 = !flag4;
		if (obj18 != null)
		{
			goto IL_051d;
		}
		goto IL_0821;
		IL_0082:
		obj7 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X0_v47+E4]");
		if ((nint)0 != 0)
		{
			goto IL_00af;
		}
		goto IL_0178;
		IL_0178:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Games currentGame = Preferences.CurrentGame;
		if (currentGame == Games.Jackaroo)
		{
			goto IL_01b0;
		}
		return;
		IL_00af:
		Games currentGame2 = Preferences.CurrentGame;
		if (currentGame2 != Games.Jackaroo)
		{
			return;
		}
		goto IL_01b0;
		IL_01b0:
		object obj19 = typeof(UsageHint) + 72;
		object obj20 = obj19;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X0_v3+E4]");
		if ((nint)0 != 0)
		{
			if (UserInfo.SawWhatsNewForJackaroo)
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool sawWhatsNewForJackaroo = UserInfo.SawWhatsNewForJackaroo;
			bool flag5 = !sawWhatsNewForJackaroo;
			object obj21 = !flag5;
			if (obj21 != null)
			{
				return;
			}
		}
		object obj22 = typeof(MemberAchievementClanFeedData) + 2976;
		object obj23 = obj22;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v251 @ X0_v5+E4]");
		bool flag6 = (nint)0 == 0;
		object obj24 = !flag6;
		if (obj24 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj25 = (nint)0 + (nint)384;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE9A80");
		IPopupWindowBuilderNeedsTitle popupWindowBuilderNeedsTitle = PopupWindowBuilder.Create(PopupWindow.MessageType.Action);
		object obj26 = typeof(System.IOAsyncCallback) + 392;
		object obj27 = "Invalid serialized DateTime data. Unable to find 'ticks' or 'dateData'." + 3024;
		nint num = (nint)popupWindowBuilderNeedsTitle;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v284 @ X8_v17 (Il2CppClass<IPopupWindowBuilderNeedsTitle>)+12E]");
		object obj28 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v284 @ X8_v17 (Il2CppClass<IPopupWindowBuilderNeedsTitle>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0393;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v284 @ X8_v17 (Il2CppClass<IPopupWindowBuilderNeedsTitle>)+B0]");
		object obj29 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v307 @ X10_v24-8]");
			if (0 == (nint)obj26)
			{
				break;
			}
			obj29 += 16;
			obj28--;
			if ((nint)obj28 != 1)
			{
				continue;
			}
			goto IL_0393;
		}
		object obj30 = num + obj29;
		object obj31 = obj30 + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v442 @ X8_v46] (should have been resolved before IL gen)");
		goto IL_03fe;
		IL_07ce:
		object obj32 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj33 = (nint)0 + (nint)1512;
		UnityAction unityAction = default(UnityAction);
		unityAction..ctor(null, (IntPtr)obj33);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v645 @ X8_v28+100]");
		((UnityEvent)0).AddListener(unityAction);
		return;
		IL_03fe:
		object obj34 = typeof(System.IOAsyncCallback) + 384;
		object obj35 = (nint)0 + (nint)2000;
		object obj37 = default(object);
		object obj36 = obj37;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v509 @ X8_v23+12E]");
		object obj38 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v509 @ X8_v23+12E]");
		if ((nint)0 == 0)
		{
			goto IL_04b2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v509 @ X8_v23+B0]");
		object obj39 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v309 @ X10_v19-8]");
			if (0 == (nint)obj34)
			{
				break;
			}
			obj39 += 16;
			obj38--;
			if ((nint)obj38 != 1)
			{
				continue;
			}
			goto IL_04b2;
		}
		object obj40 = obj36 + obj39;
		object obj41 = obj40 + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v444 @ X8_v43] (should have been resolved before IL gen)");
		goto IL_051d;
		IL_0393:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v470 @ X0_v37] (should have been resolved before IL gen)");
		bool flag7 = obj37 == null;
		object obj42 = !flag7;
		if (obj42 != null)
		{
			goto IL_03fe;
		}
		goto IL_0821;
		IL_0670:
		object obj44 = default(object);
		object obj43 = obj44;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v604 @ X8_v27+12E]");
		object obj45 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v604 @ X8_v27+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0704;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v604 @ X8_v27+B0]");
		object obj46 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v314 @ X10_v9-8]");
			if (0 == (nint)obj9)
			{
				break;
			}
			obj46 += 16;
			obj45--;
			if ((nint)obj45 != 1)
			{
				continue;
			}
			goto IL_0704;
		}
		object obj47 = obj46 + 9;
		object obj48 = obj43 + obj47;
		object obj49 = obj48 + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v640 @ X8_v36+8]");
		object obj50 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v640 @ X8_v36] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ X0_v8 (UnityEngine.Component)+20]");
		object obj51 = 0;
		goto IL_07ce;
		IL_05d7:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v568 @ X0_v27+8]");
		obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v568 @ X0_v27] (should have been resolved before IL gen)");
		bool flag8 = obj44 == null;
		object obj52 = !flag8;
		if (obj52 != null)
		{
			goto IL_0670;
		}
		goto IL_0821;
		IL_0704:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v621 @ X0_v22+8]");
		obj50 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v621 @ X0_v22] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ X0_v8 (UnityEngine.Component)+20]");
		obj51 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ X0_v8 (UnityEngine.Component)+20]");
		bool flag9 = (nint)0 == 0;
		object obj53 = !flag9;
		obj17 = 9;
		if (obj53 != null)
		{
			goto IL_07ce;
		}
		goto IL_0821;
	}
}
