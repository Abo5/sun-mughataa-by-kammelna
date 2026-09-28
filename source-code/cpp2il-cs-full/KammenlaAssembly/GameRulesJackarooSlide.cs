using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Features.GameReplay;
using UnityEngine;
using UnityEngine.InputSystem.XR;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;

public class GameRulesJackarooSlide : CommonJackarooSlide
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Action<RectTransform> <>9__9_0;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(GameReplayController.<OnEndRoundEventIe>d__138) + 96;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal void <SetHidden>b__9_0(RectTransform s)
		{
			//IL_0013: Expected O, but got I4
			s.localScale = (Vector3)0;
		}
	}

	private Image book;

	private RectTransform bookBorder;

	private List<RectTransform> suits;

	private RectTransform magnifier;

	private AnimationCurve bookBounceCurve;

	private AnimationCurve magnifierCurve;

	private Sequence sequence;

	public override Sequence OnShow()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_055c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0561: Expected O, but got Unknown
		//IL_0599: Expected O, but got I4
		//IL_0064: Expected O, but got I4
		//IL_00a1: Expected O, but got I4
		//IL_011e: Expected F4, but got I4
		//IL_0127: Expected O, but got I4
		//IL_01a7: Expected F4, but got I4
		//IL_01b0: Expected O, but got I4
		//IL_01d5: Expected O, but got I
		//IL_01e1: Expected O, but got I
		//IL_01ed: Expected O, but got I
		//IL_01f9: Expected O, but got I
		//IL_021e: Expected F4, but got I4
		//IL_0227: Expected O, but got I4
		//IL_034e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0353: Expected O, but got Unknown
		//IL_05e9: Expected O, but got I
		//IL_05fd: Expected F4, but got O
		//IL_05fd: Expected O, but got I4
		//IL_029a: Expected O, but got I4
		//IL_0382: Expected O, but got I4
		//IL_0270: Expected F4, but got I4
		//IL_0279: Expected O, but got I4
		//IL_03fb: Expected O, but got I4
		//IL_063b: Expected O, but got I
		//IL_064f: Expected F4, but got O
		//IL_064f: Expected O, but got I4
		//IL_0489: Expected O, but got I
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3848;
		object obj2 = this + 128;
		TweenExtensions.Kill((Tween)obj2);
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Sequence sequence = (this.sequence = DOTween.Sequence());
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		bool flag2 = (object)magnifier == null;
		object obj5 = 0;
		Sequence sequence2 = sequence;
		object obj9 = default(object);
		List<object>.Enumerator enumerator2 = default(List<object>.Enumerator);
		if (!flag2)
		{
			GameObject gameObject = magnifier.gameObject;
			bool flag3 = (object)gameObject == null;
			obj5 = 0;
			sequence2 = null;
			if (!flag3)
			{
				gameObject.SetActive(value: true);
				TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = ShortcutExtensions.DOScale(bookBorder, 1f, 0.3f);
				Sequence sequence3 = TweenSettingsExtensions.Append(this.sequence, tweenerCore);
				bool flag4 = (object)book == null;
				double num = 1.0;
				float num2 = 1.0502537E+09f;
				obj5 = 0;
				sequence2 = (Sequence)(object)tweenerCore;
				if (!flag4)
				{
					Transform target = book.transform;
					TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore2 = ShortcutExtensions.DOScale(target, 1f, 0.3f);
					Sequence sequence4 = TweenSettingsExtensions.Append(this.sequence, tweenerCore2);
					bool flag5 = suits == null;
					num = 1.0;
					num2 = 1.0502537E+09f;
					obj5 = 0;
					sequence2 = (Sequence)(object)tweenerCore2;
					if (!flag5)
					{
						object obj6 = (nint)0 + (nint)2896;
						object obj7 = (nint)0 + (nint)2872;
						object obj8 = (nint)0 + (nint)2760;
						obj9 = (nint)0 + (nint)544;
						List<object>.Enumerator enumerator = ((List<object>)(object)suits).GetEnumerator();
						num = 1.0;
						num2 = 1.0502537E+09f;
						obj5 = 0;
						while (enumerator2.MoveNext())
						{
							TweenerCore<Vector3, Vector3, VectorOptions> t = ShortcutExtensions.DOScale(null, 1f, 0.1f);
							Sequence sequence5 = TweenSettingsExtensions.Append((Sequence)obj2, t);
							num = 1.0;
							num2 = 1.03683194E+09f;
							obj5 = 0;
						}
						sequence2 = (Sequence)obj9;
						enumerator2.Dispose();
						object obj10 = 0;
						goto IL_02a0;
					}
				}
			}
		}
		goto IL_04ae;
		IL_04ae:
		NullReferenceException ex = new NullReferenceException();
		bool flag6 = (nint)sequence2 != 1;
		NullReferenceException ex2 = ex;
		if (!flag6)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			sequence2 = (Sequence)obj9;
			enumerator2.Dispose();
			object obj11 = default(object);
			bool flag7 = obj11 == null;
			object obj10 = obj11;
			if (flag7)
			{
				goto IL_02a0;
			}
			OutOfMemoryException ex3 = new OutOfMemoryException();
			obj10 = obj11;
			ex2 = (NullReferenceException)(object)ex3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2237EAC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
		Sequence result = default(Sequence);
		return result;
		IL_02a0:
		if ((object)book != null)
		{
			Transform target2 = book.transform;
			TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore3 = ShortcutExtensions.DOScale(target2, 1.2f, 0.21000001f);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058E14");
			Tween t2 = default(Tween);
			Sequence s = TweenSettingsExtensions.Append(this.sequence, t2);
			TweenerCore<Color, Color, ColorOptions> t3 = DOTweenModuleUI.DOFade(book, 1f, 0.15f);
			Sequence sequence6 = TweenSettingsExtensions.Join(s, t3);
			object obj12 = typeof(UsageHint) + 744;
			object obj13 = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v379 @ X8_v14+B8]");
			object obj14 = 0;
			TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore4 = DOTweenModuleUI.DOPivot(magnifier, (Vector2)0, (float)obj14);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
			Tween t4 = default(Tween);
			Sequence sequence7 = TweenSettingsExtensions.Append(this.sequence, t4);
			object obj15 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v394 @ X0_v41+E4]");
			bool flag8 = (nint)0 == 0;
			object obj16 = !flag8;
			if (obj16 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Sequence s2 = DOTween.Sequence();
			TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore5 = ShortcutExtensions.DOScale(magnifier, 1.2f, 2.4f);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058E14");
			Tween t5 = default(Tween);
			Sequence sequence8 = TweenSettingsExtensions.Append(s2, t5);
			TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore6 = DOTweenModuleUI.DOPivot(magnifier, (Vector2)0, 0.6f);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058C78");
			Tween t6 = default(Tween);
			Sequence sequence9 = TweenSettingsExtensions.Append(s2, t6);
			TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore7 = ShortcutExtensions.DOScale(magnifier, 1.2f, 2.2f);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058E14");
			Tween t7 = default(Tween);
			Sequence sequence10 = TweenSettingsExtensions.Append(s2, t7);
			object obj17 = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v466 @ X8_v31+B8]");
			object obj18 = 0;
			TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore8 = DOTweenModuleUI.DOPivot(magnifier, (Vector2)0, (float)obj18);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058C78");
			Tween t8 = default(Tween);
			Sequence sequence11 = TweenSettingsExtensions.Append(s2, t8);
			object obj19 = (nint)0 + (nint)3008;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3059384");
			Tween t9 = default(Tween);
			Sequence sequence12 = TweenSettingsExtensions.Append((Sequence)obj2, t9);
			return (Sequence)obj2;
		}
		goto IL_04ae;
	}

	public override void Hide()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_02f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f7: Expected O, but got Unknown
		//IL_030d: Expected I, but got O
		//IL_032f: Expected O, but got I4
		//IL_006d: Expected O, but got I4
		//IL_00cf: Expected O, but got I
		//IL_00db: Expected O, but got I
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Expected O, but got Unknown
		//IL_00fb: Expected O, but got I
		//IL_0107: Expected O, but got I
		//IL_012e: Expected I4, but got O
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		//IL_018e: Expected O, but got Unknown
		//IL_01b4: Expected O, but got I4
		//IL_02d6: Expected I, but got O
		Sequence sequence = (Sequence)(typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3848);
		base.Hide();
		object t = this + 128;
		TweenExtensions.Kill((Tween)t);
		nint num = (nint)sequence;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X0_v4 (Il2CppClass<DG.Tweening.Sequence>)+E4]");
		bool flag = (nint)0 == 0;
		object obj = !flag;
		if (obj == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Sequence sequence2 = DOTween.Sequence();
		this.sequence = sequence2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Sequence sequence3 = this.sequence;
		TweenerCore<Vector2, Vector2, VectorOptions> t2 = DOTweenModuleUI.DOPivot(magnifier, (Vector2)0, 4f);
		Sequence sequence4 = TweenSettingsExtensions.Append(this.sequence, t2);
		List<object> list = (List<object>)(object)suits;
		bool flag2 = suits == null;
		double num2 = 4.0;
		if (!flag2)
		{
			object obj2 = (nint)0 + (nint)2776;
			object obj3 = (nint)0 + (nint)2736;
			object obj4 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2344;
			object obj5 = (nint)0 + (nint)2392;
			object obj6 = (nint)0 + (nint)2512;
			double num3 = 4.0;
			Sequence sequence5 = null;
			Tween t3 = default(Tween);
			object obj7;
			Tween t4 = default(Tween);
			Tween t5 = default(Tween);
			TweenCallback tweenCallback = default(TweenCallback);
			do
			{
				bool flag3 = (nint)sequence5 >= list._size;
				num2 = num3;
				sequence3 = sequence5;
				if (!flag3)
				{
					object target = list.get_Item((int)sequence5);
					TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = ShortcutExtensions.DOScale((Transform)target, 0f, 0.05f);
					num2 = (double)sequence5 * 1028443341.0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058C78");
					Sequence sequence6 = TweenSettingsExtensions.Join(this.sequence, t3);
					sequence3 = (Sequence)(sequence5 + 1);
					list = (List<object>)(object)suits;
					bool flag4 = suits == null;
					obj7 = !flag4;
					num3 = num2;
					sequence5 = sequence3;
					continue;
				}
				if ((object)book == null)
				{
					break;
				}
				Transform target2 = book.transform;
				TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore2 = ShortcutExtensions.DOScale(target2, 0f, 0.12f);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058C78");
				Sequence s = TweenSettingsExtensions.Join(this.sequence, t4);
				TweenerCore<Color, Color, ColorOptions> tweenerCore3 = DOTweenModuleUI.DOFade(book, 0.2f, 0.12f);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058C78");
				Sequence s2 = TweenSettingsExtensions.Join(s, t5);
				TweenerCore<Vector3, Vector3, VectorOptions> t6 = ShortcutExtensions.DOScale(bookBorder, 0f, 0.21f);
				Sequence sequence7 = TweenSettingsExtensions.Join(s2, t6);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				tweenCallback..ctor(this, (IntPtr)obj5);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058630");
				return;
			}
			while (obj7 != null);
		}
		throw new NullReferenceException();
	}

	public override void SetHidden()
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_003b: Expected O, but got I4
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected O, but got Unknown
		//IL_006c: Expected O, but got I
		//IL_007c: Expected O, but got I4
		//IL_013f: Expected O, but got I
		//IL_014f: Expected O, but got I
		//IL_0171: Expected O, but got I4
		//IL_010a: Expected O, but got I4
		//IL_00b9: Expected O, but got I
		//IL_00c9: Expected O, but got I
		//IL_01a1: Expected O, but got I4
		//IL_0208: Expected O, but got I4
		//IL_023f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0244: Expected O, but got Unknown
		//IL_025a: Expected O, but got I
		//IL_026b: Expected I, but got O
		//IL_0289: Expected O, but got I
		//IL_01d1: Expected O, but got I
		base.SetHidden();
		Transform transform = book.transform;
		object obj = typeof(UsageHint) + 816;
		transform.localScale = (Vector3)0;
		object obj2 = typeof(GameReplayController.<OnEndRoundEventIe>d__138) + 96;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ X8_v10+B8]");
		object obj4 = 0;
		bookBorder.localScale = (Vector3)0;
		object obj5 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X0_v15+E4]");
		object obj6;
		Action<object> action;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X0_v15+B8]");
			obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ X8_v21+8]");
			action = (Action<object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ X8_v21+8]");
			if ((nint)0 != 0)
			{
				goto IL_00ee;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X0_v15+B8]");
			obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ X8_v21+8]");
			action = (Action<object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ X8_v21+8]");
			bool flag = (nint)0 == 0;
			object obj7 = !flag;
			if (obj7 != null)
			{
				goto IL_00ee;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X0_v15+E4]");
		bool flag2 = (nint)0 == 0;
		object obj8 = !flag2;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj9 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ X8_v27+B8]");
			obj6 = 0;
		}
		object obj10 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3256;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj11 = (nint)0 + (nint)1888;
		Action<object> action2 = default(Action<object>);
		action2..ctor(obj6, (IntPtr)obj11);
		object obj12 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X8_v26+B8]");
		object obj13 = (nint)0 + (nint)8;
		obj13 = action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		action = action2;
		goto IL_01e3;
		IL_00ee:
		bool flag3 = suits == null;
		object obj14 = !flag3;
		if (obj14 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_01e3;
		IL_01e3:
		((List<object>)(object)suits).ForEach(action);
		magnifier.pivot = (Vector2)0;
		UIExtensions.SetAlpha(book, 0.2f);
	}

	public GameRulesJackarooSlide()
	{
		showTitleDelay = 0.17f;
		base.fadePivot = 1.25f;
		((MonoBehaviour)this)..ctor();
	}

	private void <Hide>b__8_0()
	{
		GameObject gameObject = magnifier.gameObject;
		gameObject.SetActive(value: false);
	}
}
