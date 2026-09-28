using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Spine;
using TMPro;
using Unity.Properties;
using UnityEngine;
using UnityEngine.UI;

public abstract class SlideShowCommonsPage : AbstractSlideShowPage
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Action<Graphic> <>9__10_0;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(SkeletonBinary.SkeletonInput) + 248;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal void <SetHidden>b__10_0(Graphic g)
		{
			UIExtensions.SetAlpha(g, 0f);
		}
	}

	private TextMeshProUGUI title;

	private TextMeshProUGUI subTitle;

	private TextMeshProUGUI description;

	private Image background;

	private DG.Tweening.Sequence _mainSequence;

	private bool _isVisible;

	public override bool isVisible => _isVisible;

	public override void Show()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_031a: Unknown result type (might be due to invalid IL or missing references)
		//IL_031f: Expected O, but got Unknown
		//IL_035d: Expected O, but got I4
		//IL_006c: Expected O, but got I4
		//IL_0109: Expected O, but got I4
		//IL_01c7: Expected O, but got I4
		//IL_0268: Expected O, but got I4
		//IL_0279: Expected O, but got I
		//IL_0285: Expected O, but got I
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3848;
		object t = this + 64;
		_ = 1;
		TweenExtensions.Kill((Tween)t);
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		DG.Tweening.Sequence mainSequence = DOTween.Sequence();
		_mainSequence = mainSequence;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		RectTransform rectTransform = background.rectTransform;
		rectTransform.pivot = (Vector2)0;
		TweenerCore<Color, Color, ColorOptions> t2 = DOTweenModuleUI.DOFade(background, 0.2f, 0.3f);
		DG.Tweening.Sequence s = TweenSettingsExtensions.Append(_mainSequence, t2);
		RectTransform rectTransform2 = background.rectTransform;
		TweenerCore<Vector2, Vector2, VectorOptions> t3 = DOTweenModuleUI.DOPivotX(rectTransform2, 0.5f, 0.3f);
		DG.Tweening.Sequence sequence = TweenSettingsExtensions.Join(s, t3);
		RectTransform rectTransform3 = title.rectTransform;
		rectTransform3.pivot = (Vector2)0;
		RectTransform rectTransform4 = title.rectTransform;
		TweenerCore<Vector2, Vector2, VectorOptions> t4 = DOTweenModuleUI.DOPivotX(rectTransform4, 0.5f, 0.4f);
		DG.Tweening.Sequence s2 = TweenSettingsExtensions.Join(_mainSequence, t4);
		TweenerCore<Color, Color, ColorOptions> t5 = ShortcutExtensionsTMPText.DOFade(title, 1f, 0.3f);
		DG.Tweening.Sequence sequence2 = TweenSettingsExtensions.Join(s2, t5);
		Tween t6 = AnimateShowElements();
		DG.Tweening.Sequence sequence3 = TweenSettingsExtensions.Append(_mainSequence, t6);
		RectTransform rectTransform5 = subTitle.rectTransform;
		rectTransform5.pivot = (Vector2)0;
		RectTransform rectTransform6 = subTitle.rectTransform;
		TweenerCore<Vector2, Vector2, VectorOptions> t7 = DOTweenModuleUI.DOPivotY(rectTransform6, 0.5f, 0.3f);
		DG.Tweening.Sequence s3 = TweenSettingsExtensions.Append(_mainSequence, t7);
		TweenerCore<Color, Color, ColorOptions> t8 = ShortcutExtensionsTMPText.DOFade(subTitle, 1f, 0.3f);
		DG.Tweening.Sequence sequence4 = TweenSettingsExtensions.Join(s3, t8);
		RectTransform rectTransform7 = subTitle.rectTransform;
		rectTransform7.pivot = (Vector2)0;
		object obj4 = (nint)0 + (nint)2784;
		object obj5 = (nint)0 + (nint)2408;
		RectTransform rectTransform8 = description.rectTransform;
		TweenerCore<Vector2, Vector2, VectorOptions> t9 = DOTweenModuleUI.DOPivotY(rectTransform8, 0.5f, 0.3f);
		DG.Tweening.Sequence s4 = TweenSettingsExtensions.Append(_mainSequence, t9);
		TweenerCore<Color, Color, ColorOptions> t10 = ShortcutExtensionsTMPText.DOFade(description, 1f, 0.3f);
		DG.Tweening.Sequence sequence5 = TweenSettingsExtensions.Join(s4, t10);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058C78");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3050858");
	}

	public override void Hide()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0249: Unknown result type (might be due to invalid IL or missing references)
		//IL_024e: Expected O, but got Unknown
		//IL_0286: Expected O, but got I4
		//IL_0197: Expected O, but got I
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3848;
		object t = this + 64;
		TweenExtensions.Kill((Tween)t);
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		DG.Tweening.Sequence mainSequence = DOTween.Sequence();
		_mainSequence = mainSequence;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		_isVisible = false;
		TweenerCore<Color, Color, ColorOptions> t2 = DOTweenModuleUI.DOFade(background, 0f, 0.3f);
		DG.Tweening.Sequence sequence = TweenSettingsExtensions.Join(_mainSequence, t2);
		RectTransform rectTransform = title.rectTransform;
		TweenerCore<Vector2, Vector2, VectorOptions> t3 = DOTweenModuleUI.DOPivotX(rectTransform, 0f, 0.4f);
		DG.Tweening.Sequence s = TweenSettingsExtensions.Join(_mainSequence, t3);
		TweenerCore<Color, Color, ColorOptions> t4 = ShortcutExtensionsTMPText.DOFade(title, 0f, 0.3f);
		DG.Tweening.Sequence sequence2 = TweenSettingsExtensions.Join(s, t4);
		RectTransform rectTransform2 = subTitle.rectTransform;
		TweenerCore<Vector2, Vector2, VectorOptions> t5 = DOTweenModuleUI.DOPivotY(rectTransform2, 1f, 0.3f);
		DG.Tweening.Sequence s2 = TweenSettingsExtensions.Join(_mainSequence, t5);
		TweenerCore<Color, Color, ColorOptions> t6 = ShortcutExtensionsTMPText.DOFade(subTitle, 0f, 0.3f);
		DG.Tweening.Sequence sequence3 = TweenSettingsExtensions.Join(s2, t6);
		Tween t7 = AnimateHideElements();
		DG.Tweening.Sequence sequence4 = TweenSettingsExtensions.Join(_mainSequence, t7);
		object obj4 = (nint)0 + (nint)2408;
		RectTransform rectTransform3 = description.rectTransform;
		TweenerCore<Vector2, Vector2, VectorOptions> t8 = DOTweenModuleUI.DOPivotY(rectTransform3, 0.8f, 0.3f);
		DG.Tweening.Sequence s3 = TweenSettingsExtensions.Join(_mainSequence, t8);
		TweenerCore<Color, Color, ColorOptions> t9 = ShortcutExtensionsTMPText.DOFade(description, 0f, 0.3f);
		DG.Tweening.Sequence sequence5 = TweenSettingsExtensions.Join(s3, t9);
		GameObject gameObject = base.gameObject;
		TweenCallback callback = TweenHelpers.Disable(gameObject);
		DG.Tweening.Sequence sequence6 = TweenSettingsExtensions.AppendCallback(_mainSequence, callback);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3050858");
	}

	public override void SetHidden()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0033: Expected O, but got I4
		//IL_0049: Expected I, but got O
		//IL_0059: Expected O, but got I
		//IL_0082: Expected O, but got I
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Expected O, but got Unknown
		//IL_0169: Expected O, but got I8
		//IL_0108: Expected I, but got O
		//IL_0118: Expected O, but got I
		//IL_0141: Expected O, but got I
		//IL_018f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0194: Expected O, but got Unknown
		//IL_0242: Expected O, but got I4
		//IL_0258: Expected O, but got I
		//IL_0278: Unknown result type (might be due to invalid IL or missing references)
		//IL_027d: Expected O, but got Unknown
		//IL_01d9: Expected I, but got O
		//IL_01e9: Expected O, but got I
		//IL_0212: Expected O, but got I
		//IL_0294: Unknown result type (might be due to invalid IL or missing references)
		//IL_0299: Expected O, but got Unknown
		//IL_033f: Expected O, but got I8
		//IL_02de: Expected I, but got O
		//IL_02ee: Expected O, but got I
		//IL_0317: Expected O, but got I
		//IL_036b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0370: Expected O, but got Unknown
		//IL_0379: Unknown result type (might be due to invalid IL or missing references)
		//IL_037e: Expected O, but got Unknown
		//IL_0456: Expected O, but got I
		//IL_0466: Expected O, but got I
		//IL_0476: Expected O, but got I
		//IL_0498: Expected O, but got I4
		//IL_04b0: Expected O, but got I
		//IL_03cb: Expected O, but got I
		//IL_03db: Expected O, but got I
		//IL_03eb: Expected O, but got I
		//IL_040d: Expected O, but got I4
		//IL_04e0: Expected O, but got I4
		//IL_058b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0590: Expected O, but got Unknown
		//IL_05a6: Expected O, but got I
		//IL_05b7: Expected I, but got O
		//IL_05d5: Expected O, but got I
		//IL_0433: Expected O, but got I
		//IL_0510: Expected O, but got I
		object obj = typeof(TypeConverter<ushort, char>) + 2632;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		bool flag = (object)title == null;
		TextMeshProUGUI textMeshProUGUI = (TextMeshProUGUI)4;
		IEnumerable<object> enumerable = default(IEnumerable<object>);
		IndexOutOfRangeException ex = default(IndexOutOfRangeException);
		TextMeshProUGUI textMeshProUGUI2;
		if (!flag)
		{
			nint num = (nint)enumerable;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X8_v30 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+40]");
			textMeshProUGUI = (TextMeshProUGUI)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
			bool flag2 = ex == null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X8_v30 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+40]");
			textMeshProUGUI2 = (TextMeshProUGUI)0;
			if (flag2)
			{
				goto IL_0540;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v3 (System.Collections.Generic.IEnumerable`1<System.Object>)+18]");
		object obj11;
		object obj15;
		Action<object> action;
		object obj17;
		object obj14;
		if ((nint)0 != 0)
		{
			object obj2 = enumerable + 32;
			obj2 = title;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			bool flag3 = (object)subTitle == null;
			textMeshProUGUI = title;
			if (!flag3)
			{
				nint num2 = (nint)enumerable;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ X8_v29 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+40]");
				textMeshProUGUI = (TextMeshProUGUI)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
				bool flag4 = ex == null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ X8_v29 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+40]");
				textMeshProUGUI2 = (TextMeshProUGUI)0;
				if (flag4)
				{
					goto IL_0540;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v3 (System.Collections.Generic.IEnumerable`1<System.Object>)+18]");
			object obj3 = 0 & 0xFFFFFFFEL;
			if (obj3 != null)
			{
				object obj4 = enumerable + 40;
				obj4 = subTitle;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				bool flag5 = (object)description == null;
				textMeshProUGUI = subTitle;
				if (!flag5)
				{
					nint num3 = (nint)enumerable;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v223 @ X8_v28 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+40]");
					textMeshProUGUI = (TextMeshProUGUI)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag6 = ex == null;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v223 @ X8_v28 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+40]");
					textMeshProUGUI2 = (TextMeshProUGUI)0;
					if (flag6)
					{
						goto IL_0540;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v3 (System.Collections.Generic.IEnumerable`1<System.Object>)+18]");
				bool flag7 = (nint)0 < (nint)2;
				object obj5 = !flag7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v3 (System.Collections.Generic.IEnumerable`1<System.Object>)+18]");
				object obj6 = -2;
				bool flag8 = obj6 == null;
				object obj7 = ~obj5;
				object obj8 = obj7 | flag8;
				if (obj8 == null)
				{
					object obj9 = enumerable + 48;
					obj9 = description;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					bool flag9 = (object)background == null;
					textMeshProUGUI = description;
					if (!flag9)
					{
						nint num4 = (nint)enumerable;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X8_v27 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+40]");
						textMeshProUGUI = (TextMeshProUGUI)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
						bool flag10 = ex == null;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X8_v27 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+40]");
						textMeshProUGUI2 = (TextMeshProUGUI)0;
						if (flag10)
						{
							goto IL_0540;
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v3 (System.Collections.Generic.IEnumerable`1<System.Object>)+18]");
					object obj10 = 0 & 0xFFFFFFFCL;
					if (obj10 != null)
					{
						obj11 = typeof(SkeletonBinary.SkeletonInput) + 248;
						object obj12 = enumerable + 56;
						obj12 = background;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						object obj13 = obj11;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v286 @ X0_v30+E4]");
						if ((nint)0 != 0)
						{
							obj14 = (nint)0 + (nint)2168;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v286 @ X0_v30+B8]");
							obj15 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v292 @ X8_v17+8]");
							action = (Action<object>)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v292 @ X8_v17+8]");
							bool flag11 = (nint)0 == 0;
							object obj16 = !flag11;
							if (obj16 == null)
							{
								obj17 = obj14;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v292 @ X8_v17+8]");
								Action<object> action2 = (Action<object>)0;
								goto IL_04be;
							}
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							obj13 = obj11;
							obj17 = (nint)0 + (nint)2168;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v286 @ X0_v30+B8]");
							obj15 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v292 @ X8_v17+8]");
							Action<object> action2 = (Action<object>)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v292 @ X8_v17+8]");
							bool flag12 = (nint)0 == 0;
							object obj18 = !flag12;
							obj14 = obj17;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v292 @ X8_v17+8]");
							action = (Action<object>)0;
							if (obj18 == null)
							{
								goto IL_04be;
							}
						}
						goto IL_056e;
					}
				}
			}
		}
		ex = new IndexOutOfRangeException();
		textMeshProUGUI2 = textMeshProUGUI;
		goto IL_0540;
		IL_056e:
		ArraysExtensions.ForEach(enumerable, action);
		return;
		IL_0540:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		OutOfMemoryException ex2 = new OutOfMemoryException();
		throw new NullReferenceException();
		IL_04be:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v286 @ X0_v30+E4]");
		bool flag13 = (nint)0 == 0;
		object obj19 = !flag13;
		if (obj19 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj20 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v298 @ X8_v23+B8]");
			obj15 = 0;
		}
		object obj21 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2184;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj22 = (nint)0 + (nint)3920;
		Action<object> action3 = default(Action<object>);
		action3..ctor(obj15, (IntPtr)obj22);
		object obj23 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v279 @ X8_v22+B8]");
		object obj24 = (nint)0 + (nint)8;
		obj24 = action3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj14 = obj17;
		action = action3;
		goto IL_056e;
	}

	protected abstract Tween AnimateShowElements();

	protected abstract Tween AnimateHideElements();
}
