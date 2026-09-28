using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Formats.Asn1;
using System.Text;
using Cpp2ILInjected;
using DG.Tweening;
using DataTracking;
using Newtonsoft.Json.Linq.JsonPath;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;

namespace Jackaroo;

public class JackarooTipPanel : MonoBehaviour
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Action <>9__4_1;

		public static UnityAction <>9__4_0;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 888;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal void <Awake>b__4_0()
		{
			//IL_076a: Unknown result type (might be due to invalid IL or missing references)
			//IL_076f: Expected O, but got Unknown
			//IL_0777: Unknown result type (might be due to invalid IL or missing references)
			//IL_077c: Expected O, but got Unknown
			//IL_0785: Unknown result type (might be due to invalid IL or missing references)
			//IL_078a: Expected O, but got Unknown
			//IL_07a2: Expected O, but got I
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_0029: Expected O, but got Unknown
			//IL_0033: Unknown result type (might be due to invalid IL or missing references)
			//IL_0038: Expected O, but got Unknown
			//IL_0040: Expected I, but got O
			//IL_0050: Expected O, but got I
			//IL_0102: Expected O, but got I4
			//IL_017e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0183: Expected O, but got Unknown
			//IL_018d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0192: Expected O, but got Unknown
			//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a6: Expected O, but got Unknown
			//IL_01be: Expected O, but got I
			//IL_008b: Expected O, but got I
			//IL_0829: Unknown result type (might be due to invalid IL or missing references)
			//IL_082e: Expected O, but got Unknown
			//IL_01f9: Expected O, but got I
			//IL_012d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0132: Expected O, but got Unknown
			//IL_013b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0140: Expected I, but got Unknown
			//IL_036d: Expected O, but got I
			//IL_0397: Expected O, but got I4
			//IL_0099: Unknown result type (might be due to invalid IL or missing references)
			//IL_009e: Expected O, but got Unknown
			//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ac: Expected O, but got Unknown
			//IL_030e: Expected O, but got I4
			//IL_0317: Expected O, but got I4
			//IL_02a1: Expected O, but got I
			//IL_026f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0274: Expected O, but got Unknown
			//IL_0468: Unknown result type (might be due to invalid IL or missing references)
			//IL_046d: Expected O, but got Unknown
			//IL_0477: Unknown result type (might be due to invalid IL or missing references)
			//IL_047c: Expected O, but got Unknown
			//IL_0494: Expected O, but got I
			//IL_03d7: Expected O, but got I4
			//IL_0207: Unknown result type (might be due to invalid IL or missing references)
			//IL_020c: Expected O, but got Unknown
			//IL_0215: Unknown result type (might be due to invalid IL or missing references)
			//IL_021a: Expected O, but got Unknown
			//IL_032e: Expected O, but got I4
			//IL_0874: Unknown result type (might be due to invalid IL or missing references)
			//IL_0879: Expected O, but got Unknown
			//IL_088f: Expected O, but got I
			//IL_08a0: Expected I, but got O
			//IL_08a0: Expected O, but got I
			//IL_08a8: Expected I, but got O
			//IL_08be: Expected O, but got I
			//IL_0901: Expected I, but got O
			//IL_0936: Expected O, but got I4
			//IL_04cf: Expected O, but got I
			//IL_043a: Expected O, but got I4
			//IL_0443: Expected O, but got I4
			//IL_0567: Expected O, but got I
			//IL_053d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0542: Expected O, but got Unknown
			//IL_05fd: Expected I, but got O
			//IL_061f: Expected O, but got I4
			//IL_04dd: Unknown result type (might be due to invalid IL or missing references)
			//IL_04e2: Expected O, but got Unknown
			//IL_04eb: Unknown result type (might be due to invalid IL or missing references)
			//IL_04f0: Expected O, but got Unknown
			//IL_05a2: Expected O, but got I
			//IL_063d: Expected I, but got O
			//IL_064d: Expected O, but got I
			//IL_06eb: Expected O, but got I
			//IL_070b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0710: Expected O, but got Unknown
			//IL_0718: Expected I, but got O
			//IL_073c: Expected O, but got I4
			//IL_0745: Expected O, but got I4
			//IL_0688: Expected O, but got I
			//IL_05b0: Unknown result type (might be due to invalid IL or missing references)
			//IL_05b5: Expected O, but got Unknown
			//IL_05be: Unknown result type (might be due to invalid IL or missing references)
			//IL_05c3: Expected O, but got Unknown
			//IL_098f: Expected O, but got I4
			//IL_0696: Unknown result type (might be due to invalid IL or missing references)
			//IL_069b: Expected O, but got Unknown
			//IL_06a4: Unknown result type (might be due to invalid IL or missing references)
			//IL_06a9: Expected O, but got Unknown
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7FE2]");
			nint num = 0;
			object obj5 = default(object);
			object obj7 = default(object);
			NullReferenceException ex = default(NullReferenceException);
			object obj9 = default(object);
			object obj16 = default(object);
			IntPtr intPtr = default(IntPtr);
			object obj38 = default(object);
			object obj39 = default(object);
			object obj41 = default(object);
			Action action2 = default(Action);
			object obj50 = default(object);
			while (true)
			{
				IPopupWindowBuilderNeedsTitle popupWindowBuilderNeedsTitle = PopupWindowBuilder.Create(PopupWindow.MessageType.Action);
				object obj4;
				if (popupWindowBuilderNeedsTitle != null)
				{
					object obj = typeof(System.IOAsyncCallback) + 392;
					object obj2 = "Read object reference Id '{0}' for {1}." + 1656;
					nint num2 = (nint)popupWindowBuilderNeedsTitle;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X8_v9 (Il2CppClass<IPopupWindowBuilderNeedsTitle>)+12E]");
					object obj3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X8_v9 (Il2CppClass<IPopupWindowBuilderNeedsTitle>)+12E]");
					if ((nint)0 == 0)
					{
						goto IL_00d4;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X8_v9 (Il2CppClass<IPopupWindowBuilderNeedsTitle>)+B0]");
					obj4 = (nint)0 + (nint)8;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ X10_v12-8]");
						if (0 == (nint)obj)
						{
							break;
						}
						obj5 = obj4 + 16;
						obj3--;
						bool flag = (nint)obj3 != 1;
						obj4 = obj5;
						if (flag)
						{
							continue;
						}
						goto IL_00d4;
					}
					object obj6 = num2 + obj4;
					num = (nint)(obj6 + 312);
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v281 @ X8_v3 (Il2CppClass<System.NullReferenceException>)] (should have been resolved before IL gen)");
					bool flag2 = obj7 == null;
					obj5 = obj4;
					if (!flag2)
					{
						goto IL_016f;
					}
				}
				goto IL_0753;
				IL_0753:
				ex = new NullReferenceException();
				goto IL_0761;
				IL_06c9:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
				object obj8 = obj9;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v664 @ X0_v18+8]");
				object obj10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v328 @ X2_v13 (should have been resolved before IL gen)");
				goto IL_06f5;
				IL_0761:
				object obj11 = obj5 + 9;
				object obj12 = num + obj11;
				object obj13 = obj12 + 312;
				object obj14 = obj13;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v287 @ X8_v5+8]");
				object obj15 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v288 @ X2_v2 (should have been resolved before IL gen)");
				continue;
				IL_02de:
				string label;
				Action action;
				PopupButton popupButton = PopupButton.Positive(label, action, dismiss: true);
				bool flag3 = obj16 == null;
				object obj17 = !flag3;
				object obj18 = 0;
				if (obj17 != null)
				{
					goto IL_0459;
				}
				object obj19 = 0;
				obj5 = obj4;
				goto IL_0753;
				IL_00d4:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v243 @ X0_v47 (Il2CppClass<System.NullReferenceException>)] (should have been resolved before IL gen)");
				bool flag4 = obj7 == null;
				object obj20 = !flag4;
				obj4 = obj5;
				if (obj20 != null)
				{
					goto IL_016f;
				}
				num = intPtr;
				goto IL_0753;
				IL_06f5:
				object obj22;
				object obj21 = obj22 + obj5;
				object obj23 = obj21 + 312;
				num = (nint)obj23;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v630 @ X0_v24] (should have been resolved before IL gen)");
				bool flag5 = ex == null;
				object obj24 = !flag5;
				obj19 = 0;
				if (obj24 != null)
				{
					goto IL_0635;
				}
				goto IL_0753;
				IL_016f:
				object obj25 = typeof(System.IOAsyncCallback) + 384;
				object obj26 = "Read object reference Id '{0}' for {1}." + 1648;
				object obj27 = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 888;
				object obj28 = obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v395 @ X8_v13+12E]");
				object obj29 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v395 @ X8_v13+12E]");
				if ((nint)0 == 0)
				{
					goto IL_0242;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v395 @ X8_v13+B0]");
				object obj30 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v443 @ X10_v25-8]");
					if (0 == (nint)obj25)
					{
						break;
					}
					obj4 = obj30 + 16;
					obj29--;
					bool flag6 = (nint)obj29 != 1;
					obj30 = obj4;
					if (flag6)
					{
						continue;
					}
					goto IL_0242;
				}
				object obj31 = obj28 + obj30;
				object obj32 = obj31 + 312;
				obj4 = obj30;
				goto IL_081f;
				IL_0459:
				object obj33 = typeof(System.IOAsyncCallback) + 368;
				object label2 = "COORDINATE_TYPE_GCJ_02" + 1864;
				object obj34 = obj16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v520 @ X8_v17+12E]");
				object obj35 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v520 @ X8_v17+12E]");
				if ((nint)0 == 0)
				{
					goto IL_0518;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v520 @ X8_v17+B0]");
				object obj36 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v572 @ X10_v20-8]");
					if (0 == (nint)obj33)
					{
						break;
					}
					obj4 = obj36 + 16;
					obj35--;
					bool flag7 = (nint)obj35 != 1;
					obj36 = obj4;
					if (flag7)
					{
						continue;
					}
					goto IL_0518;
				}
				object obj37 = obj34 + obj36;
				obj38 = obj37 + 312;
				obj4 = obj36;
				goto IL_08f9;
				IL_05eb:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
				num = (nint)obj39;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v615 @ X0_v21] (should have been resolved before IL gen)");
				bool flag8 = ex == null;
				obj19 = 0;
				obj5 = obj4;
				if (!flag8)
				{
					goto IL_0635;
				}
				goto IL_0753;
				IL_0635:
				num = (nint)ex;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v281 @ X8_v3 (Il2CppClass<System.NullReferenceException>)+12E]");
				object obj40 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v281 @ X8_v3 (Il2CppClass<System.NullReferenceException>)+12E]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v281 @ X8_v3 (Il2CppClass<System.NullReferenceException>)+B0]");
					obj5 = (nint)0 + (nint)8;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v271 @ X10_v1-8]");
						bool flag9 = 0 == (nint)obj33;
						obj19 = 0;
						if (flag9)
						{
							break;
						}
						obj5 += 16;
						obj40--;
						if ((nint)obj40 != 1)
						{
							continue;
						}
						goto IL_06c9;
					}
					goto IL_0761;
				}
				goto IL_06c9;
				IL_0242:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
				obj32 = obj41;
				goto IL_081f;
				IL_081f:
				object obj42 = "Complete" + 256;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v467 @ X8_v14] (should have been resolved before IL gen)");
				object obj43 = obj27;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v492 @ X0_v30+E4]");
				string label3;
				nint num3;
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v492 @ X0_v30+B8]");
					num = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v281 @ X8_v3 (Il2CppClass<System.NullReferenceException>)+8]");
					action = (Action)0;
					label = (string)obj42;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v281 @ X8_v3 (Il2CppClass<System.NullReferenceException>)+8]");
					bool flag10 = (nint)0 == 0;
					label3 = (string)obj42;
					num3 = num;
					if (!flag10)
					{
						goto IL_02de;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj43 = obj27;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v492 @ X0_v30+B8]");
					num = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v281 @ X8_v3 (Il2CppClass<System.NullReferenceException>)+8]");
					action = (Action)0;
					label = (string)obj42;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v281 @ X8_v3 (Il2CppClass<System.NullReferenceException>)+8]");
					bool flag11 = (nint)0 == 0;
					object obj44 = !flag11;
					label3 = (string)obj42;
					num3 = num;
					if (obj44 != null)
					{
						goto IL_02de;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v492 @ X0_v30+E4]");
				bool flag12 = (nint)0 == 0;
				object obj45 = !flag12;
				if (obj45 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					object obj46 = obj27;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v523 @ X8_v35+B8]");
					num3 = 0;
				}
				object obj47 = typeof(SqlSingle[]) + 2376;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj48 = (nint)0 + (nint)2384;
				action2..ctor(num3, (IntPtr)obj48);
				num = (nint)obj27;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v281 @ X8_v3 (Il2CppClass<System.NullReferenceException>)+B8]");
				object obj49 = (nint)0 + (nint)8;
				obj49 = action2;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				popupButton = PopupButton.Positive(label3, action2, dismiss: true);
				bool flag13 = obj16 == null;
				obj18 = 0;
				obj19 = 0;
				obj5 = obj4;
				if (!flag13)
				{
					goto IL_0459;
				}
				goto IL_0753;
				IL_0518:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
				goto IL_08f9;
				IL_08f9:
				num = (nint)obj38;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v589 @ X0_v12] (should have been resolved before IL gen)");
				PopupButton popupButton2 = PopupButton.Neutral((string)label2, null, dismiss: true);
				bool flag14 = obj50 == null;
				obj19 = 0;
				obj5 = obj4;
				if (!flag14)
				{
					obj22 = obj50;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v597 @ X8_v20+12E]");
					object obj51 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v597 @ X8_v20+12E]");
					if ((nint)0 == 0)
					{
						goto IL_05eb;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v597 @ X8_v20+B0]");
					obj5 = (nint)0 + (nint)8;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v271 @ X10_v1-8]");
						if (0 == (nint)obj33)
						{
							break;
						}
						obj4 = obj5 + 16;
						obj51--;
						bool flag15 = (nint)obj51 != 1;
						obj5 = obj4;
						if (flag15)
						{
							continue;
						}
						goto IL_05eb;
					}
					goto IL_06f5;
				}
				goto IL_0753;
			}
		}

		internal void <Awake>b__4_1()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_009f: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a4: Expected O, but got Unknown
			//IL_00ce: Expected O, but got I4
			object obj = typeof(System.Buffers.Text.ParserHelpers) + 1624;
			object obj2 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Preferences.ShowJackarooTips = false;
			ITrackEvent trackEvent = TrackerLibrary.GameDontShowJackarooTipsToggled();
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X8_v4+E4]");
			if ((nint)0 != 0)
			{
				Tracker.DesignEvent(trackEvent);
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Tracker.DesignEvent(trackEvent);
		}
	}

	private DOTweenAnimation _animation;

	private TextMeshProUGUI _tipText;

	private Button _closeButton;

	private GameEventsChannel _gameEventsChannel;

	private readonly StringBuilder _stringBuilder;

	private const string OrString = "Or";

	private void Awake()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_023a: Expected I, but got O
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		//IL_0045: Expected O, but got I
		//IL_0071: Expected I, but got O
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Expected O, but got Unknown
		//IL_014f: Expected O, but got I
		//IL_015f: Expected O, but got I
		//IL_0181: Expected O, but got I4
		//IL_00e5: Expected O, but got I
		//IL_00f5: Expected O, but got I
		//IL_01b1: Expected O, but got I4
		//IL_024e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0253: Expected O, but got Unknown
		//IL_0269: Expected O, but got I
		//IL_027a: Expected I, but got O
		//IL_0298: Expected O, but got I
		//IL_0205: Expected O, but got I4
		//IL_01e1: Expected O, but got I
		object obj = typeof(Action<CriteriaSection.PerformanceCriteria>) + 288;
		object obj2 = (nint)0 + (nint)968;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object, System.Int32Enum> action = default(Action<object, System.Int32Enum>);
		action..ctor((object)this, (IntPtr)obj2);
		object obj3 = typeof(SqlSingle[]) + 2376;
		object obj4 = (nint)0 + (nint)960;
		_gameEventsChannel.DisplayCardTip += (Action<Card, JackarooAllowedRules>)(object)action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action2 = default(Action);
		action2..ctor(this, (IntPtr)obj4);
		_gameEventsChannel.HideCardTip += action2;
		Button closeButton = _closeButton;
		object obj5 = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 888;
		object obj6 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ X0_v11+E4]");
		object obj7;
		UnityAction call;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ X0_v11+B8]");
			obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ X8_v7+10]");
			call = (UnityAction)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ X8_v7+10]");
			if ((nint)0 != 0)
			{
				goto IL_011a;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj6 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ X0_v11+B8]");
			obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ X8_v7+10]");
			call = (UnityAction)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ X8_v7+10]");
			bool flag = (nint)0 == 0;
			object obj8 = !flag;
			if (obj8 != null)
			{
				goto IL_011a;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ X0_v11+E4]");
		bool flag2 = (nint)0 == 0;
		object obj9 = !flag2;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj10 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ X8_v13+B8]");
			obj7 = 0;
		}
		object obj11 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj12 = (nint)0 + (nint)2376;
		UnityAction unityAction = default(UnityAction);
		unityAction..ctor(obj7, (IntPtr)obj12);
		object obj13 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X8_v12+B8]");
		object obj14 = (nint)0 + (nint)16;
		obj14 = unityAction;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		bool flag3 = closeButton.m_OnClick == null;
		object obj15 = !flag3;
		call = unityAction;
		if (obj15 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_011a;
		IL_011a:
		closeButton.m_OnClick.AddListener(call);
	}

	private void OnDestroy()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_009e: Expected I, but got O
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		//IL_0045: Expected O, but got I
		//IL_0071: Expected I, but got O
		object obj = typeof(Action<CriteriaSection.PerformanceCriteria>) + 288;
		object obj2 = (nint)0 + (nint)968;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object, System.Int32Enum> action = default(Action<object, System.Int32Enum>);
		action..ctor((object)this, (IntPtr)obj2);
		object obj3 = typeof(SqlSingle[]) + 2376;
		object obj4 = (nint)0 + (nint)960;
		_gameEventsChannel.DisplayCardTip -= (Action<Card, JackarooAllowedRules>)(object)action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action2 = default(Action);
		action2..ctor(this, (IntPtr)obj4);
		_gameEventsChannel.HideCardTip -= action2;
	}

	private void ShowCardTipsPanel(Card card, JackarooAllowedRules allowedRules)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0141: Expected O, but got I4
		//IL_017d: Expected O, but got I4
		//IL_00e7: Expected I, but got O
		//IL_00f7: Expected O, but got I
		//IL_0107: Expected O, but got I
		object obj = 152989696;
		object obj2 = typeof(System.Buffers.Text.ParserHelpers) + 1624;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7FDE]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 == null)
		{
			goto IL_0111;
		}
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v2+E4]");
		if ((nint)0 != 0)
		{
			goto IL_007d;
		}
		goto IL_014f;
		IL_014f:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool showJackarooTips = Preferences.ShowJackarooTips;
		bool flag = !showJackarooTips;
		object obj5 = !flag;
		if (obj5 == null)
		{
			return;
		}
		goto IL_009f;
		IL_007d:
		if (Preferences.ShowJackarooTips)
		{
			goto IL_009f;
		}
		return;
		IL_009f:
		GenerateActionTips(card, allowedRules);
		string text = _stringBuilder.ToString();
		TextMeshProExtensions.FixArabic(_tipText, text);
		DOTweenAnimation animation = _animation;
		nint num = (nint)animation;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X8_v9 (Il2CppClass<DG.Tweening.DOTweenAnimation>)+198]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X8_v9 (Il2CppClass<DG.Tweening.DOTweenAnimation>)+1A0]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v96 @ X2_v4 (should have been resolved before IL gen)");
		goto IL_0111;
		IL_0111:
		_ = 1;
		obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v2+E4]");
		bool flag2 = (nint)0 == 0;
		object obj8 = !flag2;
		if (obj8 != null)
		{
			goto IL_007d;
		}
		goto IL_014f;
	}

	private void GenerateActionTips(Card card, JackarooAllowedRules allowedRules)
	{
		//IL_00a9: Expected O, but got I
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Expected O, but got Unknown
		//IL_00c6: Expected O, but got I4
		//IL_01ab: Expected O, but got I4
		//IL_01c5: Expected O, but got I4
		//IL_012e: Expected O, but got I4
		//IL_0148: Expected O, but got I4
		//IL_0644: Unknown result type (might be due to invalid IL or missing references)
		//IL_0649: Expected O, but got Unknown
		//IL_0652: Unknown result type (might be due to invalid IL or missing references)
		//IL_0657: Expected O, but got Unknown
		//IL_0671: Expected O, but got I4
		//IL_01e1: Expected O, but got I4
		//IL_00dd: Expected O, but got I4
		//IL_0601: Unknown result type (might be due to invalid IL or missing references)
		//IL_0606: Expected O, but got Unknown
		//IL_060f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0614: Expected O, but got Unknown
		//IL_062e: Expected O, but got I4
		//IL_0164: Expected O, but got I4
		//IL_037a: Unknown result type (might be due to invalid IL or missing references)
		//IL_037f: Expected O, but got Unknown
		//IL_0393: Unknown result type (might be due to invalid IL or missing references)
		//IL_0398: Expected O, but got Unknown
		//IL_03bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c2: Expected O, but got Unknown
		//IL_03da: Expected O, but got I
		//IL_03fc: Expected O, but got I4
		//IL_0232: Unknown result type (might be due to invalid IL or missing references)
		//IL_0237: Expected O, but got Unknown
		//IL_024b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0250: Expected O, but got Unknown
		//IL_0279: Expected O, but got I4
		//IL_0432: Unknown result type (might be due to invalid IL or missing references)
		//IL_0437: Expected O, but got Unknown
		//IL_0447: Expected O, but got I
		//IL_046f: Expected O, but got I4
		//IL_0696: Unknown result type (might be due to invalid IL or missing references)
		//IL_069b: Expected O, but got Unknown
		//IL_06b3: Expected O, but got I
		//IL_06d5: Expected O, but got I4
		//IL_02ab: Expected O, but got I8
		//IL_04ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b3: Expected O, but got Unknown
		//IL_04bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c0: Expected O, but got Unknown
		//IL_04d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04dc: Expected O, but got Unknown
		//IL_04e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ea: Expected O, but got Unknown
		//IL_0504: Expected O, but got I4
		//IL_0737: Expected I8, but got O
		//IL_02e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ec: Expected O, but got Unknown
		//IL_02fc: Expected O, but got I
		//IL_031c: Expected O, but got I4
		//IL_0543: Unknown result type (might be due to invalid IL or missing references)
		//IL_0548: Expected O, but got Unknown
		//IL_0572: Expected O, but got I4
		//IL_0599: Unknown result type (might be due to invalid IL or missing references)
		//IL_059e: Expected O, but got Unknown
		//IL_05b7: Expected O, but got I
		//IL_0343: Expected O, but got I4
		//IL_0354: Expected O, but got I4
		//IL_05f3: Expected O, but got I4
		StringBuilder stringBuilder = _stringBuilder.Clear();
		JackarooActions jackarooActions2;
		JackarooActions jackarooActions = ((!JackarooCardsMapper.IsCustomRule(card, allowedRules, out jackarooActions2)) ? JackarooCardsMapper.GetDefaultJackarooActions(card) : jackarooActions2);
		List<JackarooActions> list = JackarooActionsExtensions.ToList(jackarooActions);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X0_v9 (System.Collections.Generic.List`1<Jackaroo.JackarooActions>)+18]");
		if ((nint)0 < (nint)1)
		{
			return;
		}
		object obj = (nint)0 + (nint)1992;
		object obj2 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 208;
		object obj3 = 0;
		int num = 0;
		object arg = default(object);
		object arg2 = default(object);
		int num2;
		do
		{
			System.Int32Enum int32Enum = ((List<System.Int32Enum>)(object)list).get_Item(num);
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v352 @ X0_v14+E4]");
			bool flag4;
			if ((nint)0 != 0)
			{
				object obj5 = int32Enum & (System.Int32Enum)4032;
				bool flag = obj5 == null;
				object obj6 = !flag;
				bool flag2;
				if (obj6 == null)
				{
					object obj7 = int32Enum - 4096;
					flag2 = obj7 == null;
				}
				else
				{
					flag2 = true;
				}
				object obj8 = flag2 & obj3;
				object obj9 = obj8 & 1;
				bool flag3 = obj9 == null;
				object obj10 = !flag3;
				if (obj10 != null)
				{
					goto IL_00d4;
				}
				flag4 = flag2;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj11 = int32Enum & (System.Int32Enum)4032;
				bool flag5 = obj11 == null;
				object obj12 = !flag5;
				bool flag6;
				if (obj12 == null)
				{
					object obj13 = int32Enum - 4096;
					flag6 = obj13 == null;
				}
				else
				{
					flag6 = true;
				}
				object obj14 = flag6 & obj3;
				object obj15 = obj14 & 1;
				bool flag7 = obj15 == null;
				object obj16 = !flag7;
				flag4 = flag6;
				if (obj16 != null)
				{
					goto IL_00d4;
				}
			}
			object obj22;
			StringBuilder stringBuilder5;
			object obj24;
			object obj25;
			StringBuilder stringBuilder3;
			object obj20;
			if (int32Enum == (System.Int32Enum)1)
			{
				object obj17 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 128;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
				object format = "{0} color encoding is currently unsupported for outputting to HDR." + 1320;
				string input = string.Format((string)format, arg);
				StringBuilder stringBuilder2 = (StringBuilder)(card.<Rank>k__BackingField + 2);
				stringBuilder3 = ((card.<Rank>k__BackingField != Rank.FOUR) ? stringBuilder2 : ((StringBuilder)4294967292L));
				object obj18 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2656;
				object obj19 = obj18;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ X8_v40+E4]");
				obj20 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ X8_v40+E4]");
				bool flag8 = (nint)0 == 0;
				object obj21 = !flag8;
				if (obj21 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				string text = LocalizationUtil.Localize(input, (long)stringBuilder3);
				string text2 = LocalizationUtil.FixArabicOnly(text);
				StringBuilder stringBuilder4 = _stringBuilder.Append(text2);
				obj3 = flag4 | obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X0_v9 (System.Collections.Generic.List`1<Jackaroo.JackarooActions>)+18]");
				obj22 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X0_v9 (System.Collections.Generic.List`1<Jackaroo.JackarooActions>)+18]");
				bool flag9 = (nint)0 < (nint)2;
				object obj23 = 1;
				if (!flag9)
				{
					stringBuilder5 = stringBuilder3;
					obj24 = obj20;
					obj23 = 1;
					obj25 = obj3;
					object obj26 = 0;
					string text3 = text2;
					goto IL_04a5;
				}
			}
			else
			{
				stringBuilder5 = _stringBuilder;
				object obj27 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 128;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
				object format2 = "{0} color encoding is currently unsupported for outputting to HDR." + 1264;
				string input2 = string.Format((string)format2, arg2);
				object obj28 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2656;
				object obj29 = obj28;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ X8_v28+E4]");
				obj24 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ X8_v28+E4]");
				bool flag10 = (nint)0 == 0;
				object obj30 = !flag10;
				if (obj30 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				string text4 = LocalizationUtil.LocalizeAndFix(input2);
				StringBuilder stringBuilder6 = stringBuilder5.Append(text4);
				obj25 = flag4 | obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X0_v9 (System.Collections.Generic.List`1<Jackaroo.JackarooActions>)+18]");
				obj22 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X0_v9 (System.Collections.Generic.List`1<Jackaroo.JackarooActions>)+18]");
				bool flag11 = (nint)0 < (nint)2;
				System.Int32Enum int32Enum2 = int32Enum;
				object obj26 = 0;
				string text3 = text4;
				int32Enum2 = int32Enum;
				stringBuilder3 = stringBuilder5;
				obj20 = obj24;
				obj3 = obj25;
				if (!flag11)
				{
					goto IL_04a5;
				}
			}
			goto IL_06e3;
			IL_04a5:
			object obj31 = obj22 - 1;
			object obj32 = num - obj31;
			bool flag12 = obj32 == null;
			object obj33 = flag12 | obj25;
			object obj34 = obj33 & 1;
			bool flag13 = obj34 == null;
			object obj35 = !flag13;
			stringBuilder3 = stringBuilder5;
			obj20 = obj24;
			obj3 = obj25;
			if (obj35 == null)
			{
				stringBuilder3 = _stringBuilder;
				object obj36 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2656;
				object obj37 = obj36;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v561 @ X0_v18+E4]");
				bool flag14 = (nint)0 == 0;
				object obj38 = !flag14;
				if (obj38 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object input3 = "October" + 1336;
				string text5 = LocalizationUtil.LocalizeAndFix((string)input3);
				object obj39 = (nint)0 + (nint)3072;
				string value = (string)obj39 + text5 + (string)obj39;
				StringBuilder stringBuilder7 = stringBuilder3.Append(value);
				obj20 = obj24;
				obj3 = 0;
			}
			goto IL_06e3;
			IL_00d4:
			obj3 = 1;
			goto IL_06e3;
			IL_06e3:
			num++;
			num2 = num;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X0_v9 (System.Collections.Generic.List`1<Jackaroo.JackarooActions>)+18]");
		}
		while ((nint)num2 < (nint)0);
	}

	private void HideTipsPanel()
	{
		//IL_0017: Expected I, but got O
		//IL_0027: Expected O, but got I
		//IL_0037: Expected O, but got I
		DOTweenAnimation animation = _animation;
		nint num = (nint)animation;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ X8_v1 (Il2CppClass<DG.Tweening.DOTweenAnimation>)+188]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ X8_v1 (Il2CppClass<DG.Tweening.DOTweenAnimation>)+190]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v4 @ X2_v1 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}

	public JackarooTipPanel()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected O, but got Unknown
		object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 2344;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		StringBuilder stringBuilder = default(StringBuilder);
		stringBuilder..ctor();
		object obj2 = this + 64;
		obj2 = stringBuilder;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		base..ctor();
	}
}
