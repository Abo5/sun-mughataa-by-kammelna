using System;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using TMPro;
using UnityEngine;

public class TweeterValidationStep : MonoBehaviour
{
	private TextMeshProUGUI label;

	private string defaultText;

	private GameObject inactiveState;

	private TextMeshProUGUI progressStateText;

	private GameObject successState;

	private GameObject failureState;

	public void SetText(string text, object[] formattedArguments)
	{
		TextMeshProExtensions.Localize(label, text, formattedArguments);
	}

	public void ResetState()
	{
		ResetAllStates();
		inactiveState.SetActive(value: true);
		UIExtensions.SetAlpha(label, 0.7f);
		TextMeshProExtensions.Localize(label, defaultText);
	}

	public void SetProgressState()
	{
		//IL_0042: Expected O, but got I
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Expected O, but got Unknown
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected O, but got Unknown
		//IL_0076: Expected O, but got I
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected O, but got Unknown
		//IL_0096: Expected O, but got I
		//IL_00a2: Expected O, but got I
		//IL_00ae: Expected O, but got I
		//IL_00ba: Expected O, but got I
		//IL_00c2: Expected I, but got O
		//IL_00f9: Expected O, but got I4
		//IL_013c: Expected I, but got O
		//IL_0159: Expected I, but got O
		ResetAllStates();
		GameObject gameObject = progressStateText.gameObject;
		gameObject.SetActive(value: true);
		TextMeshProUGUI textMeshProUGUI = progressStateText;
		object text = (nint)0 + (nint)2000;
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3848;
		object obj2 = typeof(ConditionalWeakTable<System.Net.HttpWebRequest, Mono.Http.NtlmSession>.CreateValueCallback) + 32;
		object obj3 = (nint)0 + (nint)3376;
		object obj4 = typeof(ConditionalWeakTable<System.Net.HttpWebRequest, Mono.Http.NtlmSession>.CreateValueCallback) + 112;
		object obj5 = (nint)0 + (nint)3384;
		object obj6 = (nint)0 + (nint)2912;
		object obj7 = (nint)0 + (nint)3256;
		object obj8 = (nint)0 + (nint)3064;
		nint num = (nint)textMeshProUGUI;
		textMeshProUGUI.text = (string)text;
		object obj9 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ X0_v9+E4]");
		bool flag = (nint)0 == 0;
		object obj10 = !flag;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Sequence s = DOTween.Sequence();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		DOGetter<int> dOGetter = default(DOGetter<int>);
		dOGetter..ctor((object)this, (IntPtr)obj3);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		DOSetter<int> dOSetter = default(DOSetter<int>);
		dOSetter..ctor((object)this, (IntPtr)obj5);
		TweenerCore<int, int, NoOptions> t = DOTween.To(dOGetter, dOSetter, 3, 4f);
		Sequence s2 = TweenSettingsExtensions.Append(s, t);
		Sequence sequence = TweenSettingsExtensions.AppendInterval(s2, 0.3f);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @305951C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @30593E4");
		UIExtensions.SetAlpha(label, 1f);
	}

	public void SetSuccessState()
	{
		ResetAllStates();
		successState.SetActive(value: true);
		UIExtensions.SetAlpha(label, 1f);
	}

	public void SetFailureState()
	{
		ResetAllStates();
		failureState.SetActive(value: true);
		UIExtensions.SetAlpha(label, 1f);
	}

	public void SetNoFailState()
	{
		ResetAllStates();
		inactiveState.SetActive(value: true);
		UIExtensions.SetAlpha(label, 1f);
	}

	private void ResetAllStates()
	{
		inactiveState.SetActive(value: false);
		GameObject gameObject = progressStateText.gameObject;
		gameObject.SetActive(value: false);
		int num = ShortcutExtensions.DOKill(progressStateText);
		successState.SetActive(value: false);
		failureState.SetActive(value: false);
	}

	private int <SetProgressState>b__8_0()
	{
		//IL_0063: Expected I4, but got O
		if ((object)progressStateText != null)
		{
			string text = progressStateText.text;
			if (text != null)
			{
				return text._stringLength;
			}
		}
		NullReferenceException ex = new NullReferenceException();
		return (int)ex;
	}

	private void <SetProgressState>b__8_1(int newLength)
	{
		//IL_002a: Expected I, but got O
		//IL_003a: Expected O, but got I
		//IL_004a: Expected O, but got I
		TextMeshProUGUI textMeshProUGUI = progressStateText;
		string text = ((string)null).CreateString('.', newLength);
		nint num = (nint)textMeshProUGUI;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ X8_v1 (Il2CppClass<TMPro.TextMeshProUGUI>)+558]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ X8_v1 (Il2CppClass<TMPro.TextMeshProUGUI>)+560]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v21 @ X3_v2 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}
}
