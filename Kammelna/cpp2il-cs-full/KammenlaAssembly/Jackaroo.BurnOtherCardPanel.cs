using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Dynamic.Utils;
using System.Linq.Expressions;
using Cpp2ILInjected;
using DG.Tweening;
using GoogleMobileAds.Api.AdManager;
using Kammelna.Server.Models.Clans;
using UnityEngine;
using UnityEngine.AdaptivePerformance;
using UnityEngine.Events;
using UnityEngine.Pool;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;

namespace Jackaroo;

public class BurnOtherCardPanel : MonoBehaviour
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Action<Button> <>9__4_1;

		public static Action<Button> <>9__4_2;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 3448;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal void <Awake>b__4_1(Button button)
		{
			GameObject gameObject = button.gameObject;
			gameObject.SetActive(value: true);
			button.m_OnClick.RemoveAllListeners();
		}

		internal void <Awake>b__4_2(Button button)
		{
			GameObject gameObject = button.gameObject;
			gameObject.SetActive(value: false);
		}
	}

	private sealed class <>c__DisplayClass6_0
	{
		public Action onCardClicked;

		public BurnOtherCardPanel <>4__this;

		public UnityAction <>9__0;

		internal void <Show>b__0()
		{
			Action action = onCardClicked;
			if (onCardClicked != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v12.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
			}
			<>4__this.Dismiss();
		}
	}

	private DOTweenAnimation _animation;

	private Transform _parent;

	private Button _jackarooBurnCardPrefab;

	private ObjectPool<Button> _buttonsPool;

	private readonly List<Button> _buttons;

	private void Awake()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0361: Expected I, but got O
		//IL_036f: Expected I, but got O
		//IL_01ff: Expected O, but got I
		//IL_020f: Expected O, but got I
		//IL_0231: Expected O, but got I4
		//IL_00a6: Expected O, but got I4
		//IL_00b4: Expected O, but got I4
		//IL_0049: Expected O, but got I
		//IL_0059: Expected O, but got I
		//IL_0269: Expected O, but got I4
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Expected O, but got Unknown
		//IL_00ff: Expected O, but got I
		//IL_010f: Expected O, but got I
		//IL_011f: Expected O, but got I
		//IL_0141: Expected O, but got I4
		//IL_043c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0441: Expected O, but got Unknown
		//IL_0457: Expected O, but got I
		//IL_045f: Expected I, but got O
		//IL_0470: Expected I, but got O
		//IL_048e: Expected O, but got I
		//IL_02c8: Expected O, but got I4
		//IL_02d1: Expected O, but got I4
		//IL_02ea: Expected O, but got I4
		//IL_02fa: Expected I, but got O
		//IL_0299: Expected O, but got I
		//IL_01c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ca: Expected O, but got Unknown
		//IL_0171: Expected O, but got I4
		//IL_03ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b0: Expected O, but got Unknown
		//IL_03c6: Expected O, but got I
		//IL_03ce: Expected I, but got O
		//IL_03df: Expected I, but got O
		//IL_03fd: Expected O, but got I
		//IL_0418: Expected O, but got I4
		//IL_01a1: Expected O, but got I
		object obj = typeof(System.Dynamic.Utils.EmptyReadOnlyCollection<ParameterExpression>) + 2136;
		object obj2 = (nint)0 + (nint)1312;
		object obj3 = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 3448;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		nint num = (nint)obj2;
		Func<object> func = default(Func<object>);
		func..ctor((object)this, (IntPtr)obj2);
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X0_v19+E4]");
		object obj5;
		Action<object> action;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X0_v19+B8]");
			obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X8_v6+8]");
			action = (Action<object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X8_v6+8]");
			bool flag = (nint)0 == 0;
			object obj6 = obj4;
			if (!flag)
			{
				goto IL_0086;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj4 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X0_v19+B8]");
			obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X8_v6+8]");
			action = (Action<object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X8_v6+8]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			object obj6 = obj4;
			if (obj7 != null)
			{
				goto IL_0086;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X0_v8+E4]");
		bool flag3 = (nint)0 == 0;
		object obj8 = !flag3;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj9 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ X8_v13+B8]");
			obj5 = 0;
		}
		object obj10 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1320;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj11 = (nint)0 + (nint)2000;
		num = (nint)obj11;
		Action<object> action2 = default(Action<object>);
		action2..ctor(obj5, (IntPtr)obj11);
		object obj12 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v196 @ X8_v11+B8]");
		object obj13 = (nint)0 + (nint)8;
		obj13 = action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X0_v19+E4]");
		bool flag4 = (nint)0 == 0;
		object obj14 = !flag4;
		object obj15 = 0;
		object obj16 = action2;
		action = action2;
		object obj17 = 0;
		object obj18 = action2;
		nint num2 = (nint)obj11;
		object obj19 = obj4;
		Action<object> action3 = action2;
		if (obj14 != null)
		{
			goto IL_00df;
		}
		goto IL_0318;
		IL_0086:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X0_v19+E4]");
		bool flag5 = (nint)0 == 0;
		obj15 = 0;
		obj16 = this;
		obj17 = 0;
		obj18 = this;
		num2 = num;
		obj19 = obj4;
		action3 = action;
		if (!flag5)
		{
			goto IL_00df;
		}
		goto IL_0318;
		IL_0318:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj4 = obj3;
		obj15 = obj17;
		obj16 = obj18;
		num = num2;
		action = action3;
		goto IL_00df;
		IL_00df:
		object obj20 = typeof(List<Tween>) + 2664;
		object obj21 = (nint)0 + (nint)1352;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X0_v19+B8]");
		object obj22 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ X8_v20+10]");
		Action<object> action4 = (Action<object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ X8_v20+10]");
		bool flag6 = (nint)0 == 0;
		object obj23 = !flag6;
		if (obj23 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X0_v19+E4]");
			bool flag7 = (nint)0 == 0;
			object obj24 = !flag7;
			if (obj24 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj25 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ X8_v26+B8]");
				obj22 = 0;
			}
			object obj26 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1320;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj27 = (nint)0 + (nint)2008;
			num = (nint)obj27;
			Action<object> action5 = default(Action<object>);
			action5..ctor(obj22, (IntPtr)obj27);
			object obj28 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X8_v25+B8]");
			object obj29 = (nint)0 + (nint)16;
			obj29 = action5;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			obj15 = 0;
			obj16 = action5;
			action4 = action5;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3989138");
		object obj30 = this + 56;
		object obj31 = default(object);
		obj30 = obj31;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	public void Show(List<Card> cards, Userbox userbox, Action onCardClicked)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_088f: Expected O, but got I4
		//IL_089d: Expected O, but got I4
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0076: Expected O, but got I4
		//IL_0084: Expected O, but got I4
		//IL_00a7: Expected O, but got I
		//IL_00b3: Expected O, but got I
		//IL_00bf: Expected O, but got I
		//IL_00cb: Expected O, but got I
		//IL_00d7: Expected O, but got I
		//IL_00e3: Expected O, but got I
		//IL_0182: Expected O, but got I4
		//IL_012a: Expected O, but got I4
		//IL_01db: Expected O, but got I4
		//IL_01f6: Expected I4, but got O
		//IL_025f: Expected O, but got I4
		//IL_0291: Expected O, but got I4
		//IL_02c8: Expected O, but got I4
		//IL_0310: Expected O, but got I4
		//IL_0319: Expected O, but got I4
		//IL_044f: Expected O, but got I4
		//IL_046f: Expected O, but got I4
		//IL_04f1: Expected O, but got I
		//IL_0501: Expected O, but got I
		//IL_0511: Expected O, but got I
		//IL_04af: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b4: Expected O, but got Unknown
		//IL_04bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c2: Expected O, but got Unknown
		//IL_05e6: Expected O, but got I
		//IL_0608: Expected O, but got I4
		//IL_0632: Unknown result type (might be due to invalid IL or missing references)
		//IL_0637: Expected O, but got Unknown
		//IL_064d: Expected O, but got I
		//IL_065e: Expected I, but got O
		//IL_06f4: Expected O, but got I
		//IL_06fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0702: Expected O, but got Unknown
		//IL_0671: Unknown result type (might be due to invalid IL or missing references)
		//IL_0676: Expected O, but got Unknown
		object obj = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 3456;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		bool flag = obj2 == null;
		List<object>.Enumerator enumerator = (List<object>.Enumerator)0;
		BurnOtherCardPanel burnOtherCardPanel = null;
		UnityAction unityAction = (UnityAction)152989696;
		Userbox userbox3 = default(Userbox);
		Userbox userbox2 = userbox3;
		Action action = default(Action);
		object obj7 = default(object);
		object obj8 = default(object);
		object obj9 = default(object);
		Userbox userbox4;
		List<object>.Enumerator enumerator6;
		if (!flag)
		{
			object obj3 = obj2 + 16;
			obj3 = action;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj4 = obj2 + 24;
			obj4 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			bool flag2 = _buttons == null;
			enumerator = (List<object>.Enumerator)0;
			burnOtherCardPanel = this;
			unityAction = (UnityAction)152989696;
			userbox2 = userbox3;
			if (!flag2)
			{
				object obj5 = (nint)0 + (nint)3640;
				object obj6 = (nint)0 + (nint)1368;
				obj7 = (nint)0 + (nint)1360;
				obj8 = (nint)0 + (nint)2200;
				obj9 = (nint)0 + (nint)3872;
				unityAction = (UnityAction)((nint)0 + (nint)3632);
				List<object>.Enumerator enumerator2 = ((List<object>)(object)_buttons).GetEnumerator();
				userbox4 = userbox3;
				List<object>.Enumerator enumerator3 = default(List<object>.Enumerator);
				List<object>.Enumerator enumerator5;
				List<object>.Enumerator enumerator4 = default(List<object>.Enumerator);
				while (true)
				{
					burnOtherCardPanel = (BurnOtherCardPanel)obj5;
					if (!enumerator3.MoveNext())
					{
						break;
					}
					bool flag3 = _buttonsPool == null;
					enumerator = enumerator4;
					enumerator5 = enumerator4;
					enumerator4 = (List<object>.Enumerator)0;
					userbox2 = userbox3;
					if (!flag3)
					{
						userbox4 = (Userbox)obj6;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D498F4");
						continue;
					}
					goto IL_07b6;
				}
				burnOtherCardPanel = (BurnOtherCardPanel)(object)unityAction;
				enumerator3.Dispose();
				enumerator6 = enumerator4;
				enumerator5 = enumerator4;
				enumerator4 = (List<object>.Enumerator)0;
				userbox2 = userbox3;
				goto IL_018f;
			}
		}
		goto IL_07a0;
		IL_076d:
		bool flag4 = _animation == null;
		enumerator = enumerator6;
		if (!flag4)
		{
			_animation.DOPlayForward();
			return;
		}
		goto IL_07a0;
		IL_07b6:
		NullReferenceException ex = new NullReferenceException();
		bool flag5 = (nint)burnOtherCardPanel != 1;
		NullReferenceException ex2 = ex;
		if (!flag5)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			burnOtherCardPanel = (BurnOtherCardPanel)(object)unityAction;
			enumerator.Dispose();
			object obj10 = default(object);
			bool flag6 = obj10 == null;
			enumerator6 = enumerator;
			List<object>.Enumerator enumerator4 = (List<object>.Enumerator)obj10;
			if (flag6)
			{
				goto IL_018f;
			}
			OutOfMemoryException ex3 = new OutOfMemoryException();
			enumerator4 = (List<object>.Enumerator)obj10;
			ex2 = (NullReferenceException)(object)ex3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223828C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
		return;
		IL_07a0:
		NullReferenceException ex4 = new NullReferenceException();
		userbox4 = userbox3;
		goto IL_07b6;
		IL_018f:
		List<Button> buttons = _buttons;
		bool flag7 = _buttons == null;
		userbox3 = userbox4;
		enumerator = enumerator6;
		if (!flag7)
		{
			object[] array = (object[])(buttons._version + 1);
			buttons._size = 0;
			buttons._version = (int)array;
			if (buttons._size >= 1)
			{
				Array.Clear(buttons._items, 0, buttons._size);
				action = null;
				burnOtherCardPanel = null;
			}
			bool flag8 = (object)userbox2 == null;
			userbox3 = (Userbox)buttons._size;
			enumerator = enumerator6;
			if (!flag8)
			{
				bool flag9 = cards == null;
				userbox3 = (Userbox)buttons._size;
				enumerator = enumerator6;
				if (!flag9)
				{
					bool flag10 = cards._size < 1;
					userbox3 = (Userbox)buttons._size;
					if (flag10)
					{
						goto IL_076d;
					}
					userbox2 = (Userbox)(object)userbox2.<CurrentCardBack>k__BackingField;
					object obj12 = default(object);
					object obj11 = obj12;
					int num2 = default(int);
					int num = num2;
					Action action2 = action;
					object[] array2 = array;
					Userbox userbox5 = (Userbox)buttons._size;
					object obj13 = 0;
					BurnOtherCardPanel burnOtherCardPanel2 = burnOtherCardPanel;
					UnityAction unityAction2 = unityAction;
					object obj18 = default(object);
					Image image = default(Image);
					UnityAction unityAction3 = default(UnityAction);
					while (true)
					{
						bool flag11 = _buttonsPool == null;
						obj12 = obj11;
						num2 = num;
						action = action2;
						array = array2;
						userbox3 = userbox5;
						enumerator = enumerator6;
						object obj6 = obj13;
						burnOtherCardPanel = burnOtherCardPanel2;
						unityAction = unityAction2;
						if (flag11)
						{
							break;
						}
						burnOtherCardPanel = (BurnOtherCardPanel)obj7;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D49814");
						List<object> buttons2 = (List<object>)(object)_buttons;
						bool flag12 = _buttons == null;
						obj12 = obj11;
						num2 = num;
						action = action2;
						array = array2;
						userbox3 = userbox5;
						enumerator = enumerator6;
						obj6 = obj13;
						unityAction = unityAction2;
						if (flag12)
						{
							break;
						}
						object obj14 = obj8;
						int version = buttons2._version + 1;
						buttons2._version = version;
						array = buttons2._items;
						bool flag13 = buttons2._items == null;
						obj12 = obj11;
						num2 = num;
						action = action2;
						userbox3 = userbox5;
						enumerator = enumerator6;
						obj6 = obj13;
						unityAction = unityAction2;
						if (flag13)
						{
							break;
						}
						num2 = buttons2._size;
						obj12 = array.Length;
						bool flag14 = buttons2._size < array.Length;
						object obj15 = !flag14;
						if (obj15 == null)
						{
							int size = buttons2._size + 1;
							buttons2._size = size;
							object obj16 = buttons2._items + buttons2._size;
							object obj17 = obj16 + 32;
							obj17 = obj18;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							burnOtherCardPanel = (BurnOtherCardPanel)obj18;
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ X8_v11+20]");
							object obj19 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v485 @ X8_v19+C0]");
							object obj20 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v486 @ X8_v20+70]");
							userbox5 = (Userbox)0;
							((List<object>)(object)_buttons).AddWithResize(obj18);
							burnOtherCardPanel = (BurnOtherCardPanel)obj18;
						}
						bool flag15 = obj18 == null;
						action = action2;
						userbox3 = userbox5;
						enumerator = enumerator6;
						obj6 = obj13;
						unityAction = unityAction2;
						if (flag15)
						{
							break;
						}
						burnOtherCardPanel = (BurnOtherCardPanel)obj9;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
						bool flag16 = (object)image == null;
						action = action2;
						userbox3 = userbox5;
						enumerator = enumerator6;
						obj6 = obj13;
						unityAction = unityAction2;
						if (flag16)
						{
							break;
						}
						image.sprite = (Sprite)(object)userbox2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v3 (System.Object)+20]");
						unityAction = (UnityAction)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v3 (System.Object)+20]");
						bool flag17 = (nint)0 == 0;
						object obj21 = !flag17;
						userbox3 = null;
						burnOtherCardPanel = (BurnOtherCardPanel)(object)userbox2;
						if (obj21 == null)
						{
							object obj22 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
							object obj23 = (nint)0 + (nint)2016;
							unityAction3..ctor(obj2, (IntPtr)obj23);
							object obj24 = obj2 + 32;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							action2 = null;
							userbox3 = (Userbox)obj23;
							burnOtherCardPanel = (BurnOtherCardPanel)(object)unityAction3;
							unityAction = unityAction3;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v476 @ X0_v27 (System.Object)+100]");
						bool flag18 = (nint)0 == 0;
						action = action2;
						enumerator = enumerator6;
						obj6 = obj13;
						if (flag18)
						{
							break;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v476 @ X0_v27 (System.Object)+100]");
						((UnityEvent)0).AddListener(unityAction);
						obj6 = obj13 + 1;
						bool flag19 = (nint)obj6 < cards._size;
						action = action2;
						userbox3 = null;
						burnOtherCardPanel = (BurnOtherCardPanel)(object)unityAction;
						obj11 = obj12;
						num = num2;
						array2 = array;
						userbox5 = null;
						obj13 = obj6;
						burnOtherCardPanel2 = (BurnOtherCardPanel)(object)unityAction;
						unityAction2 = unityAction;
						if (flag19)
						{
							continue;
						}
						goto IL_076d;
					}
				}
			}
		}
		goto IL_07a0;
	}

	private void Dismiss()
	{
		//IL_000d: Expected I, but got O
		//IL_0055: Expected O, but got I
		//IL_0061: Expected O, but got I
		//IL_006d: Expected O, but got I
		//IL_01ce: Expected I, but got O
		//IL_025a: Expected I, but got O
		//IL_00b7: Expected I, but got O
		//IL_00ca: Expected O, but got I4
		//IL_017f: Expected O, but got I4
		DOTweenAnimation animation = _animation;
		nint num2 = default(nint);
		object obj3 = default(object);
		List<object>.Enumerator enumerator2 = default(List<object>.Enumerator);
		object obj4;
		if (_animation != null)
		{
			nint num = (nint)animation;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X8_v6 (Il2CppClass<DG.Tweening.DOTweenAnimation>)+190]");
			num2 = 0;
			_animation.DOPlayBackwards();
			if (_buttons != null)
			{
				object obj = (nint)0 + (nint)3640;
				object obj2 = (nint)0 + (nint)1368;
				obj3 = (nint)0 + (nint)3632;
				List<object>.Enumerator enumerator = ((List<object>)(object)_buttons).GetEnumerator();
				while (true)
				{
					num2 = (nint)obj;
					if (!enumerator2.MoveNext())
					{
						break;
					}
					if (_buttonsPool != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D498F4");
						continue;
					}
					goto IL_016b;
				}
				num2 = (nint)obj3;
				enumerator2.Dispose();
				obj4 = 0;
				goto IL_00d0;
			}
		}
		goto IL_0244;
		IL_0244:
		NullReferenceException ex = new NullReferenceException();
		bool flag = num2 != 1;
		NullReferenceException ex2 = ex;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			num2 = (nint)obj3;
			enumerator2.Dispose();
			object obj5 = default(object);
			bool flag2 = obj5 == null;
			obj4 = obj5;
			if (flag2)
			{
				goto IL_00d0;
			}
			OutOfMemoryException ex3 = new OutOfMemoryException();
			obj4 = obj5;
			ex2 = (NullReferenceException)(object)ex3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223828C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
		return;
		IL_00d0:
		List<Button> buttons = _buttons;
		if (_buttons != null)
		{
			int version = buttons._version + 1;
			buttons._size = 0;
			buttons._version = version;
			if (buttons._size >= 1)
			{
				Array.Clear(buttons._items, 0, buttons._size);
			}
			return;
		}
		goto IL_0244;
		IL_016b:
		NullReferenceException ex4 = new NullReferenceException();
		obj4 = 0;
		goto IL_0244;
	}

	public void Hide()
	{
		Dismiss();
	}

	public BurnOtherCardPanel()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected O, but got Unknown
		object obj = typeof(List<AdaptivePerformanceScaler>) + 344;
		object obj2 = (nint)0 + (nint)2192;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list = default(List<object>);
		list..ctor(5);
		object obj3 = this + 64;
		obj3 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		base..ctor();
	}

	private Button <Awake>b__4_0()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0043: Expected O, but got I
		//IL_0077: Expected O, but got I4
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		object obj2 = (nint)0 + (nint)488;
		Transform parent = _parent;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE9D50");
		Button result = default(Button);
		return result;
	}
}
