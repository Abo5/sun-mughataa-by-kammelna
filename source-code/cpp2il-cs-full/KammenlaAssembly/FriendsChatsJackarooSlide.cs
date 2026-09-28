using System;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Newtonsoft.Json.Linq.JsonPath;
using TMPro;
using UnityEngine;
using UnityEngine.Purchasing.Telemetry;

public class FriendsChatsJackarooSlide : CommonJackarooSlide
{
	private RectTransform background;

	private RectTransform leftUser;

	private RectTransform leftMessage;

	private DisplayTextCharAnimation leftText;

	private RectTransform rightUser;

	private RectTransform rightMessage;

	private DisplayTextCharAnimation rightText;

	private Sequence sequence;

	private string leftUserMessage;

	private string rightUserMessage;

	private void Awake()
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected O, but got Unknown
		//IL_0033: Expected I, but got O
		//IL_006a: Expected O, but got I4
		//IL_01e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ea: Expected O, but got Unknown
		//IL_020c: Expected O, but got I
		//IL_0097: Expected O, but got I
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected O, but got Unknown
		//IL_00ed: Expected O, but got I
		//IL_0102: Expected O, but got I
		//IL_0116: Expected O, but got I4
		//IL_0126: Expected O, but got I
		//IL_0136: Expected O, but got I
		//IL_0179: Expected O, but got I
		//IL_0189: Expected O, but got I
		//IL_0199: Expected I, but got O
		//IL_01a9: Expected O, but got I
		//IL_01b9: Expected O, but got I
		string input = default(string);
		while (true)
		{
			DisplayTextCharAnimation displayTextCharAnimation = leftText;
			TextMeshProUGUI textField = displayTextCharAnimation.textField;
			object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2656;
			nint num = (nint)textField;
			string text = textField.text;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X8_v6+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			string text2 = LocalizationUtil.Localize(text);
			object obj4 = this + 144;
			obj4 = text2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X20_v7-10]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X8_v7+20]");
			object obj6 = 0;
			object obj7 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v114 @ X8_v8+548] (should have been resolved before IL gen)");
			string text3 = LocalizationUtil.Localize(input);
			object obj8 = this + 152;
			obj8 = text3;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X20_v9-30]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X8_v9+20]");
			object obj10 = 0;
			object obj11 = 153100288 + 1024;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X20_v11+90]");
			object obj12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X8_v10+B8]");
			object obj13 = 0;
			object obj14 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v124 @ X8_v12+558] (should have been resolved before IL gen)");
			DisplayTextCharAnimation displayTextCharAnimation2 = rightText;
			TextMeshProUGUI textField2 = displayTextCharAnimation2.textField;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X20_v11+90]");
			object obj15 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X8_v14+B8]");
			object obj16 = 0;
			object obj17 = obj16;
			nint num2 = (nint)textField2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X8_v16 (Il2CppClass<TMPro.TextMeshProUGUI>)+558]");
			object obj18 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X8_v16 (Il2CppClass<TMPro.TextMeshProUGUI>)+560]");
			object obj19 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v96 @ X3_v1 (should have been resolved before IL gen)");
		}
	}

	private void ClearText()
	{
		//IL_001e: Expected O, but got I4
		//IL_002e: Expected O, but got I
		//IL_003e: Expected O, but got I
		//IL_0081: Expected O, but got I
		//IL_0091: Expected O, but got I
		//IL_00a1: Expected I, but got O
		//IL_00b1: Expected O, but got I
		//IL_00c1: Expected O, but got I
		DisplayTextCharAnimation displayTextCharAnimation = leftText;
		object obj = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ X20_v3+90]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v3+B8]");
		object text = 0;
		displayTextCharAnimation.textField.text = (string)text;
		DisplayTextCharAnimation displayTextCharAnimation2 = rightText;
		TextMeshProUGUI textField = displayTextCharAnimation2.textField;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ X20_v3+90]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X8_v7+B8]");
		object obj4 = 0;
		object obj5 = obj4;
		nint num = (nint)textField;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X8_v9 (Il2CppClass<TMPro.TextMeshProUGUI>)+558]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X8_v9 (Il2CppClass<TMPro.TextMeshProUGUI>)+560]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v57 @ X3_v1 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}

	public override Sequence OnShow()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0201: Unknown result type (might be due to invalid IL or missing references)
		//IL_0206: Expected O, but got Unknown
		//IL_0212: Expected O, but got I
		//IL_021e: Expected O, but got I
		//IL_022a: Expected O, but got I
		//IL_0236: Expected O, but got I
		//IL_023c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0241: Expected O, but got Unknown
		//IL_0279: Expected O, but got I4
		//IL_00ca: Expected I, but got O
		//IL_0130: Expected I, but got O
		//IL_01d5: Expected I, but got O
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3848;
		object obj2 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2344;
		object obj3 = (nint)0 + (nint)2672;
		object obj4 = (nint)0 + (nint)2656;
		object obj5 = (nint)0 + (nint)2776;
		object obj6 = (nint)0 + (nint)2664;
		object t = this + 136;
		TweenExtensions.Kill((Tween)t);
		object obj7 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj8 = !flag;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Sequence sequence = DOTween.Sequence();
		this.sequence = sequence;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		TweenerCore<Vector3, Vector3, VectorOptions> t2 = ShortcutExtensions.DOScale(background, 1f, 0.2f);
		Sequence s = TweenSettingsExtensions.Append(this.sequence, t2);
		TweenerCore<Vector3, Vector3, VectorOptions> t3 = ShortcutExtensions.DOScale(leftUser, 1f, 0.3f);
		Sequence s2 = TweenSettingsExtensions.Append(s, t3);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TweenCallback tweenCallback = default(TweenCallback);
		tweenCallback..ctor(this, (IntPtr)obj3);
		Sequence s3 = TweenSettingsExtensions.AppendCallback(s2, tweenCallback);
		TweenerCore<Vector3, Vector3, VectorOptions> t4 = ShortcutExtensions.DOScale(leftMessage, 1f, 0.3f);
		Sequence s4 = TweenSettingsExtensions.Append(s3, t4);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TweenCallback tweenCallback2 = default(TweenCallback);
		tweenCallback2..ctor(this, (IntPtr)obj4);
		Sequence sequence2 = TweenSettingsExtensions.AppendCallback(s4, tweenCallback2);
		TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = ShortcutExtensions.DOScale(rightUser, 1f, 0.3f);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058C78");
		Tween t5 = default(Tween);
		Sequence s5 = TweenSettingsExtensions.Append(this.sequence, t5);
		TweenerCore<Vector3, Vector3, VectorOptions> t6 = ShortcutExtensions.DOScale(rightMessage, 1f, 0.3f);
		Sequence s6 = TweenSettingsExtensions.Append(s5, t6);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TweenCallback tweenCallback3 = default(TweenCallback);
		tweenCallback3..ctor(this, (IntPtr)obj6);
		Sequence sequence3 = TweenSettingsExtensions.AppendCallback(s6, tweenCallback3);
		return this.sequence;
	}

	public override void Hide()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01af: Expected O, but got Unknown
		//IL_01bb: Expected O, but got I
		//IL_01c7: Expected O, but got I
		//IL_01d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d8: Expected O, but got Unknown
		//IL_0210: Expected O, but got I4
		//IL_0093: Expected I, but got O
		//IL_0155: Expected I, but got O
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3848;
		object obj2 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2344;
		object obj3 = (nint)0 + (nint)2640;
		object obj4 = (nint)0 + (nint)2648;
		base.Hide();
		object t = this + 136;
		TweenExtensions.Kill((Tween)t);
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Sequence sequence = DOTween.Sequence();
		this.sequence = sequence;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		TweenerCore<Vector3, Vector3, VectorOptions> t2 = ShortcutExtensions.DOScale(rightMessage, 0f, 0.2f);
		Sequence s = TweenSettingsExtensions.Append(this.sequence, t2);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TweenCallback tweenCallback = default(TweenCallback);
		tweenCallback..ctor(this, (IntPtr)obj3);
		Sequence s2 = TweenSettingsExtensions.AppendCallback(s, tweenCallback);
		TweenerCore<Vector3, Vector3, VectorOptions> t3 = ShortcutExtensions.DOScale(rightUser, 0f, 0.2f);
		Sequence s3 = TweenSettingsExtensions.Append(s2, t3);
		TweenerCore<Vector3, Vector3, VectorOptions> t4 = ShortcutExtensions.DOScale(background, 0f, 0.080000006f);
		Sequence sequence2 = TweenSettingsExtensions.Join(s3, t4);
		TweenerCore<Vector3, Vector3, VectorOptions> t5 = ShortcutExtensions.DOScale(leftMessage, 0f, 0.2f);
		Sequence s4 = TweenSettingsExtensions.Append(this.sequence, t5);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TweenCallback tweenCallback2 = default(TweenCallback);
		tweenCallback2..ctor(this, (IntPtr)obj4);
		Sequence s5 = TweenSettingsExtensions.AppendCallback(s4, tweenCallback2);
		TweenerCore<Vector3, Vector3, VectorOptions> t6 = ShortcutExtensions.DOScale(leftUser, 0f, 0.2f);
		Sequence sequence3 = TweenSettingsExtensions.Append(s5, t6);
	}

	public override void SetHidden()
	{
		//IL_001b: Expected O, but got I4
		//IL_0030: Expected O, but got I4
		//IL_0045: Expected O, but got I4
		//IL_005a: Expected O, but got I4
		//IL_006f: Expected O, but got I4
		base.SetHidden();
		background.localScale = (Vector3)0;
		leftUser.localScale = (Vector3)0;
		leftMessage.localScale = (Vector3)0;
		rightUser.localScale = (Vector3)0;
		rightMessage.localScale = (Vector3)0;
	}

	public FriendsChatsJackarooSlide()
	{
		showTitleDelay = 0.17f;
		base.fadePivot = 1.25f;
		((MonoBehaviour)this)..ctor();
	}

	private void <OnShow>b__12_0()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected O, but got Unknown
		object obj = leftText + 48;
		obj = leftUserMessage;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		leftText.Display();
	}

	private void <OnShow>b__12_1()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected O, but got Unknown
		object obj = rightText + 48;
		obj = rightUserMessage;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		rightText.Display();
	}

	private void <Hide>b__13_0()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected O, but got Unknown
		object obj = rightText + 48;
		obj = rightUserMessage;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		rightText.Display();
	}

	private void <Hide>b__13_1()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected O, but got Unknown
		object obj = leftText + 48;
		obj = leftUserMessage;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		leftText.Display();
	}
}
