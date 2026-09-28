using System;
using System.Buffers.Text;
using System.Data;
using System.Diagnostics;
using Cpp2ILInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using GoogleMobileAds.Ump.Api;
using Spine;
using TMPro;
using UnityEngine;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;

public class Toast : MonoBehaviour
{
	private sealed class <>c__DisplayClass7_0
	{
		public LocalizableText text;

		public Vector2 displacement;

		public float duration;

		internal void <Show>b__0(Toast instance)
		{
			//IL_0019: Expected F4, but got O
			//IL_0019: Expected O, but got I
			IntPtr intPtr = default(IntPtr);
			instance.MakeAndShow(text, (Vector2)(nint)intPtr, (float)displacement);
		}
	}

	private static readonly AddressReference<Toast> Address;

	private Image container;

	private TextMeshProUGUI MessageLabel;

	private Vector2 defaultPosition;

	private void Awake()
	{
		RectTransform rectTransform = UIExtensions.rectTransform(this);
		Vector2 anchoredPosition = rectTransform.anchoredPosition;
		Vector2 vector = default(Vector2);
		defaultPosition = vector;
		UIExtensions.SetAlpha(container, 0f);
		UIExtensions.SetAlpha(MessageLabel, 0f);
	}

	public static void Show(string message, Vector2 displacement = default(Vector2), float duration = 4f)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_005f: Expected O, but got I4
		//IL_007f: Expected O, but got I4
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1240;
		string text2 = default(string);
		LocalizableText text = TextMeshProExtensions.Localize(text2);
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X8_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Show(text, (Vector2)0, duration);
	}

	public static void Debug(string message, Vector2 displacement = default(Vector2), float duration = 4f)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_005f: Expected O, but got I4
		//IL_007f: Expected O, but got I4
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1240;
		string text2 = default(string);
		LocalizableText text = TextMeshProExtensions.FixOnly(text2);
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X8_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Show(text, (Vector2)0, duration);
	}

	public static void Show(LocalizableText text, Vector2 displacement = default(Vector2), float duration = 4f)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		//IL_004d: Expected O, but got I
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected O, but got Unknown
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected O, but got Unknown
		//IL_00ba: Expected O, but got I4
		//IL_011d: Expected O, but got I
		//IL_012d: Expected O, but got I
		//IL_0148: Expected I, but got O
		//IL_0172: Expected O, but got I4
		object obj = typeof(SkeletonBinary.SkeletonInput) + 3224;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1240;
		object obj4 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3712;
		object obj5 = (nint)0 + (nint)3448;
		object obj6 = typeof(System.Buffers.Text.ParserHelpers) + 1616;
		object obj7 = obj2 + 16;
		obj7 = text;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj8 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X0_v8+E4]");
		bool flag = (nint)0 == 0;
		object obj9 = !flag;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj8 = obj3;
		}
		object obj10 = (nint)0 + (nint)2392;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X0_v8+B8]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor(obj2, (IntPtr)obj5);
		object obj12 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X0_v11+E4]");
		bool flag2 = (nint)0 == 0;
		object obj13 = !flag2;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2F80C64");
	}

	private void MakeAndShow(LocalizableText text, Vector2 displacement, float duration)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_007b: Expected O, but got I4
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Expected O, but got Unknown
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected O, but got Unknown
		//IL_00f0: Expected O, but got I4
		//IL_01ee: Expected O, but got I
		//IL_0204: Expected O, but got I
		//IL_0129: Expected O, but got I
		//IL_013f: Expected O, but got I
		//IL_0159: Expected O, but got I4
		object obj = "___# Content push apply failed [{0}]: {1}" + 1240;
		object obj2 = "<ds.DataTable.OnColumnChanging|INFO> {0}" + 880;
		object obj3 = typeof(DataRelation) + 856;
		string text2 = (string)obj + text.Text + (string)obj2;
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X8_v6+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		object message = text2;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			message = text2;
		}
		UnityEngine.Debug.Log(message);
		TextMeshProExtensions.Localize(MessageLabel, text);
		RectTransform rectTransform = UIExtensions.rectTransform(this);
		object obj6 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1240;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Toast)+34]");
		object obj8 = default(object);
		object obj7 = obj8 + 0;
		float num = duration + (float)defaultPosition;
		rectTransform.anchoredPosition = (Vector2)0;
		object obj9 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ X0_v10+E4]");
		object obj10;
		object obj13;
		if ((nint)0 != 0)
		{
			obj10 = (nint)0 + (nint)2736;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7B7F]");
			object obj11 = (nint)0 & (nint)1;
			bool flag2 = obj11 == null;
			object obj12 = !flag2;
			obj13 = obj10;
			if (obj12 == null)
			{
				goto IL_016f;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj10 = (nint)0 + (nint)2736;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7B7F]");
			object obj14 = (nint)0 & (nint)1;
			if (obj14 == null)
			{
				goto IL_016f;
			}
			obj13 = obj10;
		}
		goto IL_0255;
		IL_0255:
		int num2 = ShortcutExtensions.DOKill(container);
		UIExtensions.SetAlpha(container, 0f);
		TweenerCore<Color, Color, ColorOptions> tweenerCore = DOTweenModuleUI.DOFade((Graphic)container, 0.7f, 0.3f);
		TweenerCore<Color, Color, ColorOptions> tweenerCore2 = DOTweenModuleUI.DOFade((Graphic)container, 0f, 0.3f);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058C78");
		int num3 = ShortcutExtensions.DOKill(MessageLabel);
		UIExtensions.SetAlpha(MessageLabel, 0f);
		TweenerCore<Color, Color, ColorOptions> tweenerCore3 = DOTweenModuleUI.DOFade(MessageLabel, 0.7f, 0.3f);
		TweenerCore<Color, Color, ColorOptions> tweenerCore4 = DOTweenModuleUI.DOFade(MessageLabel, 0f, 0.3f);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058C78");
		return;
		IL_016f:
		_ = 1;
		obj13 = obj10;
		goto IL_0255;
	}

	private static void ShowAnimation(Graphic image, float duration)
	{
		//IL_000c: Expected O, but got I
		object obj = (nint)0 + (nint)2736;
		int num = ShortcutExtensions.DOKill(image);
		UIExtensions.SetAlpha(image, 0f);
		TweenerCore<Color, Color, ColorOptions> tweenerCore = DOTweenModuleUI.DOFade(image, 0.7f, 0.3f);
		TweenerCore<Color, Color, ColorOptions> tweenerCore2 = DOTweenModuleUI.DOFade(image, 0f, 0.3f);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058C78");
	}

	public void TestPopup(string testPopupString)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_013e: Expected O, but got I4
		//IL_008a: Expected O, but got I
		//IL_016c: Expected O, but got I
		//IL_0186: Expected O, but got I4
		//IL_01d6: Expected O, but got I4
		//IL_01df: Expected O, but got I4
		//IL_01e8: Expected O, but got I4
		//IL_00dc: Expected O, but got I4
		//IL_00e5: Expected O, but got I4
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1240;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7B80]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v11+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v11+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7B7C]");
		object obj5 = (nint)0 & (nint)1;
		bool flag2 = obj5 == null;
		object obj6 = !flag2;
		if (obj6 != null)
		{
			goto IL_00a7;
		}
		goto IL_0194;
		IL_00fb:
		LocalizableText localizableText;
		Vector2 displacement;
		Show(localizableText, displacement, 0f);
		return;
		IL_01fe:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Vector2 vector;
		displacement = vector;
		LocalizableText localizableText2;
		localizableText = localizableText2;
		goto IL_00fb;
		IL_00a7:
		localizableText = TextMeshProExtensions.Localize(testPopupString);
		object obj7 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X8_v2+E4]");
		bool flag3 = (nint)0 == 0;
		displacement = (Vector2)0;
		vector = (Vector2)0;
		localizableText2 = localizableText;
		if (!flag3)
		{
			goto IL_00fb;
		}
		goto IL_01fe;
		IL_0074:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7B7C]");
		object obj8 = (nint)0 & (nint)1;
		if (obj8 != null)
		{
			goto IL_00a7;
		}
		goto IL_0194;
		IL_0194:
		_ = 1;
		localizableText = TextMeshProExtensions.Localize(testPopupString);
		obj7 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X8_v2+E4]");
		bool flag4 = (nint)0 == 0;
		object obj9 = !flag4;
		displacement = (Vector2)0;
		vector = (Vector2)0;
		localizableText2 = localizableText;
		if (obj9 != null)
		{
			goto IL_00fb;
		}
		goto IL_01fe;
	}

	static Toast()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		object obj = "ThisIsFakeReceiptData" + 536;
		object obj2 = typeof(ConsentForm.<Show>c__AnonStorey2.<Show>c__AnonStorey3) + 3208;
		object obj3 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1240;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4933C3C");
		object obj4 = obj3;
		object obj6 = default(object);
		object obj5 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}
}
