using System;
using Cpp2ILInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem.UI;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;

public class voteOptionComponent : MonoBehaviour
{
	private sealed class <>c__DisplayClass6_0
	{
		public Action<voteOptionComponent> onClick;

		public voteOptionComponent <>4__this;

		internal void <Initialize>b__0()
		{
			//IL_0029: Expected O, but got I
			//IL_0039: Expected O, but got I
			//IL_0049: Expected O, but got I
			Action<voteOptionComponent> action = onClick;
			voteOptionComponent voteOptionComponent2 = <>4__this;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (System.Action`1<voteOptionComponent>)+18]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (System.Action`1<voteOptionComponent>)+40]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (System.Action`1<voteOptionComponent>)+28]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v4 @ X3_v1 (should have been resolved before IL gen)");
			/*Error: End of method reached without returning.*/;
		}
	}

	private TextMeshProUGUI optionText;

	private TextMeshProUGUI percentage;

	private Button button;

	private Image fill;

	private Image selectedIndicator;

	private Color selectedColor;

	public VoteModel.Option model;

	public void Initialize(VoteModel.Option v, Action<voteOptionComponent> onClick)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Expected O, but got Unknown
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Expected O, but got Unknown
		//IL_00c0: Expected O, but got I
		//IL_00db: Expected I, but got O
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 3616;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = obj2 + 16;
		obj3 = onClick;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj4 = obj2 + 24;
		obj4 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj5 = this + 88;
		obj5 = v;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		optionText.SetText(v.Text);
		Button button = this.button;
		object obj6 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
		object obj7 = (nint)0 + (nint)568;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction = default(UnityAction);
		unityAction..ctor(obj2, (IntPtr)obj7);
		button.m_OnClick.AddListener(unityAction);
	}

	public void SetText(string text)
	{
		optionText.SetText(text);
	}

	public void ShowValue(float percent, bool isMyVote)
	{
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Expected O, but got Unknown
		//IL_00ac: Invalid comparison between F4 and I4
		//IL_004c: Expected O, but got I
		TweenerCore<float, float, FloatOptions> tweenerCore = DOTweenModuleUI.DOFillAmount(fill, percent, 0.3f);
		GameObject gameObject = selectedIndicator.gameObject;
		gameObject.SetActive(isMyVote);
		if (isMyVote)
		{
			fill.color = (Color)0;
		}
		object obj = " SDK from working.  If you would like to change it's implementation please override StartVivoxUnity method in " + 3912;
		float num = percent * 1.1204035E+09f;
		if (num == 2.139095E+09f)
		{
		}
		int num2 = default(int);
		string text = num2.ToString();
		string text2 = text + (string)obj;
		percentage.text = text2;
	}
}
