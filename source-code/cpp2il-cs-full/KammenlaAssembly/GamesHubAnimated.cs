using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Threading;
using Cpp2ILInjected;
using DG.Tweening;
using DataTracking;
using Microsoft.Extensions.DependencyInjection.ServiceLookup;
using UnityEngine;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.Rendering;
using UnityEngine.TextCore;
using UnityEngine.UI;

public class GamesHubAnimated : GamesHubBase
{
	private Image blocker;

	private TweenAnimation openAnim;

	private TweenAnimation hideAnim;

	protected override void Start()
	{
		//IL_0732: Expected O, but got I4
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		//IL_0022: Expected I, but got O
		//IL_0032: Expected O, but got I
		//IL_00d1: Expected O, but got I4
		//IL_006d: Expected O, but got I
		//IL_0683: Expected O, but got I4
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Expected O, but got Unknown
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Expected O, but got Unknown
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Expected O, but got Unknown
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Expected O, but got Unknown
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Expected O, but got Unknown
		//IL_01af: Expected O, but got I
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Expected O, but got Unknown
		//IL_0096: Expected O, but got I
		//IL_024e: Expected O, but got I4
		//IL_07f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f6: Expected O, but got Unknown
		//IL_01ea: Expected O, but got I
		//IL_04b7: Expected O, but got I4
		//IL_04d2: Expected O, but got I4
		//IL_0271: Unknown result type (might be due to invalid IL or missing references)
		//IL_0276: Expected O, but got Unknown
		//IL_08c2: Expected O, but got I4
		//IL_01f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fd: Expected O, but got Unknown
		//IL_0213: Expected O, but got I
		//IL_04e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04eb: Expected O, but got Unknown
		//IL_0503: Expected O, but got I
		//IL_02b8: Expected O, but got I
		//IL_05a2: Expected O, but got I4
		//IL_0357: Expected O, but got I4
		//IL_053e: Expected O, but got I
		//IL_02f3: Expected O, but got I
		//IL_05c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ca: Expected O, but got Unknown
		//IL_037a: Unknown result type (might be due to invalid IL or missing references)
		//IL_037f: Expected O, but got Unknown
		//IL_054c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0551: Expected O, but got Unknown
		//IL_0567: Expected O, but got I
		//IL_089a: Expected O, but got I4
		//IL_0301: Unknown result type (might be due to invalid IL or missing references)
		//IL_0306: Expected O, but got Unknown
		//IL_031c: Expected O, but got I
		//IL_03fb: Expected O, but got I4
		//IL_0646: Expected I, but got O
		//IL_066b: Expected I, but got O
		//IL_04a0: Expected I, but got O
		base.Start();
		GamesHubItem[] array = base.items;
		bool flag = base.items == null;
		object obj = 0;
		if (flag)
		{
			goto IL_0740;
		}
		object obj2 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 3224;
		nint num = (nint)array;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X8_v15 (Il2CppClass<GamesHubItem[]>)+12E]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X8_v15 (Il2CppClass<GamesHubItem[]>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_00be;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X8_v15 (Il2CppClass<GamesHubItem[]>)+B0]");
		object obj4 = (nint)0 + (nint)8;
		object obj5 = default(object);
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X10_v30-8]");
			if (0 == (nint)obj2)
			{
				break;
			}
			obj5 = obj4 + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X8_v15 (Il2CppClass<GamesHubItem[]>)+12E]");
			obj3 = -1;
			bool flag2 = (nint)obj3 != 1;
			obj4 = obj5;
			if (flag2)
			{
				continue;
			}
			goto IL_00be;
		}
		obj3 = obj4;
		object obj6 = num + obj4;
		object obj7 = obj6 + 312;
		obj5 = obj4;
		goto IL_0770;
		IL_05e6:
		NullReferenceException ex = new NullReferenceException();
		object obj9;
		object obj8 = obj9;
		object obj10;
		obj5 = obj10;
		goto IL_0670;
		IL_0670:
		object obj11 = default(object);
		obj = obj11;
		object obj12 = 0;
		goto IL_0740;
		IL_0740:
		throw new NullReferenceException();
		IL_0626:
		NullReferenceException ex2 = new NullReferenceException();
		obj8 = obj9;
		obj5 = obj10;
		nint num2 = unchecked((nint)null);
		goto IL_0670;
		IL_05d8:
		NullReferenceException ex3 = new NullReferenceException();
		goto IL_0670;
		IL_00be:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		obj8 = 0;
		goto IL_0770;
		IL_0770:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v253 @ X0_v23+8]");
		num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v253 @ X0_v23] (should have been resolved before IL gen)");
		if (obj11 == null)
		{
			goto IL_05d8;
		}
		object obj13 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2528;
		object obj14 = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 600;
		object obj15 = typeof(System.Buffers.Text.ParserHelpers) + 1624;
		obj9 = obj8;
		obj10 = obj5;
		object obj16 = obj11;
		object obj22 = default(object);
		object obj34 = default(object);
		UnityEngine.Component component = default(UnityEngine.Component);
		while (true)
		{
			object obj17 = obj16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v345 @ X8_v22+12E]");
			obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v345 @ X8_v22+12E]");
			if ((nint)0 == 0)
			{
				goto IL_023b;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v345 @ X8_v22+B0]");
			object obj18 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v432 @ X10_v25-8]");
				if (0 == (nint)obj13)
				{
					break;
				}
				obj10 = obj18 + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v345 @ X8_v22+12E]");
				obj3 = -1;
				bool flag3 = (nint)obj3 != 1;
				obj18 = obj10;
				if (flag3)
				{
					continue;
				}
				goto IL_023b;
			}
			obj3 = obj18;
			object obj19 = obj17 + obj18;
			object obj20 = obj19 + 312;
			obj10 = obj18;
			goto IL_07cd;
			IL_07cd:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v469 @ X0_v30+8]");
			num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v469 @ X0_v30] (should have been resolved before IL gen)");
			object obj21 = obj22 & 1;
			if (obj21 != null)
			{
				if (obj11 == null)
				{
					break;
				}
				object obj23 = obj11;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v563 @ X8_v25+12E]");
				obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v563 @ X8_v25+12E]");
				if ((nint)0 == 0)
				{
					goto IL_0344;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v563 @ X8_v25+B0]");
				object obj24 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v633 @ X10_v20-8]");
					if (0 == (nint)obj14)
					{
						break;
					}
					obj10 = obj24 + 16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v563 @ X8_v25+12E]");
					obj3 = -1;
					bool flag4 = (nint)obj3 != 1;
					obj24 = obj10;
					if (flag4)
					{
						continue;
					}
					goto IL_0344;
				}
				obj3 = obj24;
				object obj25 = obj23 + obj24;
				object obj26 = obj25 + 312;
				obj10 = obj24;
				goto IL_0838;
			}
			obj = obj11;
			obj12 = 0;
			obj8 = obj9;
			obj5 = obj10;
			object obj27 = 0;
			while (true)
			{
				if (obj == null)
				{
					goto IL_08a8;
				}
				object obj28 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2344;
				object obj29 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v476 @ X8_v7+12E]");
				obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v476 @ X8_v7+12E]");
				if ((nint)0 == 0)
				{
					goto IL_058f;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v476 @ X8_v7+B0]");
				object obj30 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v576 @ X10_v7-8]");
					if (0 == (nint)obj28)
					{
						break;
					}
					obj5 = obj30 + 16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v476 @ X8_v7+12E]");
					obj3 = -1;
					bool flag5 = (nint)obj3 != 1;
					obj30 = obj5;
					if (flag5)
					{
						continue;
					}
					goto IL_058f;
				}
				obj3 = obj30;
				object obj31 = obj29 + obj30;
				object obj32 = obj31 + 312;
				obj5 = obj30;
				goto IL_08f4;
				IL_08a8:
				bool flag6 = obj27 == null;
				object obj33 = !flag6;
				if (obj33 == null)
				{
					return;
				}
				OutOfMemoryException ex4 = new OutOfMemoryException();
				if (num2 != 1)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
				obj27 = obj34;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
				obj12 = obj34;
				continue;
				IL_058f:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
				obj8 = 0;
				goto IL_08f4;
				IL_08f4:
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v620 @ X0_v5+8]");
				num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v620 @ X0_v5] (should have been resolved before IL gen)");
				goto IL_08a8;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C99C14");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
			return;
			IL_0344:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			obj9 = 0;
			goto IL_0838;
			IL_0838:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v648 @ X0_v34+8]");
			num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v648 @ X0_v34] (should have been resolved before IL gen)");
			if ((object)component != null)
			{
				object obj35 = obj15;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v659 @ X0_v39+E4]");
				bool flag7 = (nint)0 == 0;
				object obj36 = !flag7;
				if (obj36 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Games currentGame = Preferences.CurrentGame;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v651 @ X0_v36 (UnityEngine.Component)+20]");
				if ((nint)currentGame == (nint)0)
				{
					object obj37 = obj15;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v669 @ X0_v43+E4]");
					bool flag8 = (nint)0 == 0;
					object obj38 = !flag8;
					if (obj38 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					if (Preferences.HasPreferredGame)
					{
						Transform transform = component.transform;
						if ((object)transform == null)
						{
							goto IL_0626;
						}
						Transform parent = transform.parent;
						if ((object)parent == null)
						{
							goto IL_064b;
						}
						parent.SetAsFirstSibling();
						num2 = unchecked((nint)null);
					}
				}
				bool flag9 = obj11 == null;
				obj16 = obj11;
				obj8 = obj9;
				obj5 = obj10;
				if (!flag9)
				{
					continue;
				}
				goto IL_05d8;
			}
			goto IL_05e6;
			IL_023b:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			obj9 = 0;
			goto IL_07cd;
		}
		NullReferenceException ex5 = new NullReferenceException();
		obj8 = obj9;
		obj5 = obj10;
		goto IL_0670;
		IL_064b:
		NullReferenceException ex6 = new NullReferenceException();
		obj8 = obj9;
		obj5 = obj10;
		num2 = unchecked((nint)null);
		goto IL_0670;
	}

	protected override void OnShowHub()
	{
		//IL_000d: Expected I, but got O
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected O, but got Unknown
		//IL_0078: Expected O, but got I
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Expected O, but got Unknown
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected O, but got Unknown
		//IL_00d6: Expected I, but got O
		//IL_0105: Expected O, but got I4
		//IL_020a: Unknown result type (might be due to invalid IL or missing references)
		//IL_020f: Expected O, but got Unknown
		//IL_0237: Expected O, but got I4
		//IL_0170: Unknown result type (might be due to invalid IL or missing references)
		//IL_0175: Expected O, but got Unknown
		//IL_01d6: Expected O, but got I4
		Image image = blocker;
		nint num = (nint)image;
		image.raycastTarget = true;
		if (hideAnim.IsPlaying())
		{
			hideAnim.Kill();
		}
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)2528;
		object obj3 = typeof(RegisteredWaitHandle) + 3136;
		object obj4 = typeof(System.Buffers.Text.ParserHelpers) + 1624;
		Sequence sequence = openAnim.PlaySequence();
		GameObject popup = base.gameObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		object obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ X0_v15+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		ScreenManager.PushPopup(popup, action);
		object obj7 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ X0_v18+E4]");
		object obj8;
		object obj9;
		if ((nint)0 != 0)
		{
			obj8 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
			bool hasPreferredGame = Preferences.HasPreferredGame;
			bool flag2 = !hasPreferredGame;
			obj9 = obj8;
			if (!flag2)
			{
				goto IL_01a3;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj8 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
			bool hasPreferredGame2 = Preferences.HasPreferredGame;
			bool flag3 = !hasPreferredGame2;
			object obj10 = !flag3;
			obj9 = obj8;
			if (obj10 != null)
			{
				goto IL_01a3;
			}
		}
		ITrackEvent trackEvent = TrackerLibrary.SwitchGameOnboardingViewed();
		object obj11 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X8_v7+E4]");
		bool flag4 = (nint)0 == 0;
		ITrackEvent trackEvent2 = trackEvent;
		if (!flag4)
		{
			goto IL_028b;
		}
		goto IL_0295;
		IL_0295:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Tracker.DesignEvent(trackEvent2);
		return;
		IL_028b:
		Tracker.DesignEvent(trackEvent);
		return;
		IL_01a3:
		trackEvent = TrackerLibrary.SwitchGameViewed();
		obj11 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X8_v7+E4]");
		bool flag5 = (nint)0 == 0;
		object obj12 = !flag5;
		if (obj12 != null)
		{
			goto IL_028b;
		}
		trackEvent2 = trackEvent;
		goto IL_0295;
	}

	protected override void OnHideHub()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_010b: Expected O, but got I4
		//IL_0114: Expected O, but got I4
		//IL_00be: Expected O, but got I4
		//IL_0079: Expected O, but got I4
		//IL_01b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b9: Expected O, but got Unknown
		//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cd: Expected O, but got Unknown
		//IL_01dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e1: Expected O, but got Unknown
		//IL_01e9: Expected I, but got O
		//IL_0221: Expected O, but got I4
		//IL_029f: Expected O, but got I4
		object obj = typeof(RegisteredWaitHandle) + 3136;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8C06]");
		object obj2 = (nint)0 & (nint)1;
		GameObject gameObject;
		GameObject go;
		if (obj2 != null)
		{
			gameObject = base.gameObject;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X8_v7+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = 0;
			go = gameObject;
			if (!flag)
			{
				goto IL_008f;
			}
		}
		else
		{
			_ = 1;
			gameObject = base.gameObject;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X8_v7+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			object obj4 = 0;
			go = gameObject;
			if (obj5 != null)
			{
				goto IL_008f;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		ScreenManager.RemovePopup(go);
		TweenAnimation tweenAnimation = openAnim;
		goto IL_0151;
		IL_0151:
		if (tweenAnimation.IsPlaying())
		{
			openAnim.Kill();
		}
		Sequence sequence = hideAnim.PlaySequence();
		Image image = blocker;
		object obj6 = typeof(System.Buffers.Text.ParserHelpers) + 1624;
		object obj7 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2232;
		object obj8 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		nint num = (nint)image;
		image.raycastTarget = false;
		object obj9 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ X0_v10+E4]");
		bool flag3 = (nint)0 == 0;
		object obj10 = !flag3;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Games currentGame = Preferences.CurrentGame;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		Enum enumeration = default(Enum);
		string friendlyName = EnumExtensions.GetFriendlyName(enumeration);
		ITrackEvent trackEvent = TrackerLibrary.SwitchGameBackClicked(friendlyName);
		object obj11 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X8_v6+E4]");
		bool flag4 = (nint)0 == 0;
		object obj12 = !flag4;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Tracker.DesignEvent(trackEvent);
		return;
		IL_008f:
		ScreenManager.RemovePopup(gameObject);
		tweenAnimation = openAnim;
		bool flag5 = openAnim == null;
		object obj13 = !flag5;
		if (obj13 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_0151;
	}

	protected override void HidePopup()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_0110: Expected O, but got I4
		//IL_0119: Expected O, but got I4
		//IL_0079: Expected O, but got I4
		//IL_00be: Expected O, but got I4
		//IL_01b2: Expected I, but got O
		//IL_01c2: Expected O, but got I
		//IL_01d2: Expected O, but got I
		object obj = typeof(RegisteredWaitHandle) + 3136;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8C07]");
		object obj2 = (nint)0 & (nint)1;
		GameObject gameObject;
		GameObject go;
		if (obj2 != null)
		{
			gameObject = base.gameObject;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X8_v5+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = 0;
			go = gameObject;
			if (!flag)
			{
				goto IL_008f;
			}
		}
		else
		{
			_ = 1;
			gameObject = base.gameObject;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X8_v5+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			object obj4 = 0;
			go = gameObject;
			if (obj5 != null)
			{
				goto IL_008f;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		ScreenManager.RemovePopup(go);
		TweenAnimation tweenAnimation = openAnim;
		goto IL_0156;
		IL_01dc:
		throw new NullReferenceException();
		IL_0156:
		if (tweenAnimation.IsPlaying())
		{
			openAnim.Kill();
		}
		Sequence sequence = hideAnim.PlaySequence();
		Image image = blocker;
		nint num = (nint)image;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X8_v4 (Il2CppClass<UnityEngine.UI.Image>)+2C8]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X8_v4 (Il2CppClass<UnityEngine.UI.Image>)+2D0]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v109 @ X3_v1 (should have been resolved before IL gen)");
		goto IL_01dc;
		IL_008f:
		ScreenManager.RemovePopup(gameObject);
		tweenAnimation = openAnim;
		bool flag3 = openAnim == null;
		object obj8 = !flag3;
		if (obj8 != null)
		{
			goto IL_0156;
		}
		goto IL_01dc;
	}
}
