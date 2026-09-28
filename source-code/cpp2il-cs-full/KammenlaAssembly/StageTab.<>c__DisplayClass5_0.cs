using System;
using Cpp2ILInjected;
using Spine;
using TMPro;
using Unity.Properties;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class StageTab : MonoBehaviour
{
	private sealed class <>c__DisplayClass5_0
	{
		public Action action;

		internal void <SetToggle>b__0(bool a)
		{
			if (a)
			{
				Action action = this.action;
				IntPtr invoke_impl = ((Delegate)action).invoke_impl;
				IntPtr method_code = ((Delegate)action).method_code;
				IntPtr method = ((Delegate)action).method;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v5 @ X2_v1 (System.IntPtr) (should have been resolved before IL gen)");
			}
		}
	}

	private TextMeshProUGUI numText;

	private TextMeshProUGUI stageTitleText;

	private Image stageIcon;

	private Toggle _toggle;

	public void SetText(int index, bool isFinal = false)
	{
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Expected O, but got Unknown
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Expected O, but got Unknown
		int order = index + 1;
		int num = default(int);
		string text = num.ToString();
		numText.text = text;
		GameObject gameObject = numText.gameObject;
		bool active = (byte)((isFinal ? 1u : 0u) ^ 1u) != 0;
		gameObject.SetActive(active);
		GameObject gameObject2 = stageIcon.gameObject;
		gameObject2.SetActive(isFinal);
		if (isFinal)
		{
			object text2 = "fetch_products" + 256;
			TextMeshProExtensions.Localize(stageTitleText, (string)text2);
		}
		else
		{
			object text3 = "Network Authentication Required" + 3304;
			TextMeshProExtensions.LocalizeOrdinal(stageTitleText, (string)text3, order);
		}
	}

	public void SetToggle(Action action)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		//IL_0085: Expected O, but got I
		//IL_00a0: Expected I, but got O
		object obj = typeof(SkeletonBinary.SkeletonInput) + 1168;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = obj2 + 16;
		obj3 = action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Toggle toggle = _toggle;
		toggle.onValueChanged.RemoveAllListeners();
		Toggle toggle2 = _toggle;
		object obj4 = typeof(TypeConverter<ushort, char>) + 360;
		object obj5 = (nint)0 + (nint)1088;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction<bool> unityAction = default(UnityAction<bool>);
		unityAction..ctor(obj2, (IntPtr)obj5);
		toggle2.onValueChanged.AddListener(unityAction);
	}

	public void Toggle()
	{
		//IL_001d: Expected O, but got I4
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected I4, but got Unknown
		Toggle toggle = _toggle;
		object obj = ~(toggle.m_IsOn ? 1 : 0);
		bool isOn = (byte)(1 & obj) != 0;
		toggle.isOn = isOn;
	}
}
