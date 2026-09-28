using System;
using System.Buffers.Text;
using System.Diagnostics;
using System.Formats.Asn1;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Features.GameReplay;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;

public class PredictionCardTeam : MonoBehaviour
{
	private Image icon;

	private ElegantLoadingIndicator loadingIndicator;

	private TextMeshProUGUI teamName;

	private InputFieldTMProUGUI scorePrediction;

	private Button predictButton;

	private GameObject predictedScoreContainer;

	private TextMeshProUGUI predictedScoreText;

	private TextMeshProUGUI actualScoreText;

	private Image winStateNotch;

	private TextMeshProUGUI winStateText;

	private Sprite winStateIcon;

	private Sprite drawStateIcon;

	private Action<PredictionCardTeam> m_OnReadyStateChange;

	private Action<PredictionCardTeam> m_OnScoreChange;

	public bool IsReady
	{
		get
		{
			//IL_0096: Expected I4, but got O
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			if ((object)scorePrediction != null)
			{
				object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 2504;
				string text = scorePrediction.Text;
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X8_v3+E4]");
				if ((nint)0 != 0)
				{
					return StringUtil.IsNumber(text);
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				return StringUtil.IsNumber(text);
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	public unsafe int Score
	{
		get
		{
			//IL_0008: Expected O, but got Ref
			//IL_00c2: Expected I4, but got O
			//IL_007a: Expected O, but got I4
			object obj2 = default(object);
			object obj = (object)(&obj2);
			_ = 0;
			if ((object)scorePrediction != null)
			{
				string text = scorePrediction.Text;
				bool flag = int.TryParse(text, out System.Runtime.CompilerServices.Unsafe.As<object, int>(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 4)));
				bool flag2 = !flag;
				object obj3 = !flag2;
				object obj4 = ~obj3;
				if (obj4 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4 @ X29_v1-4]");
					return 0;
				}
				return 0;
			}
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
		}
		set
		{
			int num = default(int);
			string text = num.ToString();
			scorePrediction.Text = text;
		}
	}

	public event Action<PredictionCardTeam> OnReadyStateChange
	{
		add
		{
			//IL_0096: Unknown result type (might be due to invalid IL or missing references)
			//IL_009b: Expected O, but got Unknown
			//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a6: Expected O, but got Unknown
			//IL_000e: Expected O, but got I4
			//IL_0065: Expected O, but got I4
			object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3080;
			object obj2 = this + 128;
			Delegate obj3 = (Delegate)obj2;
			object obj6 = default(object);
			bool flag2;
			Delegate obj8 = default(Delegate);
			do
			{
				Delegate obj4 = Delegate.Combine(obj3, value);
				if ((object)obj4 == null)
				{
					object obj5 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag = obj6 == null;
					object obj7 = !flag;
					object obj5 = obj6;
					if (obj7 == null)
					{
						throw new InvalidCastException();
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				flag2 = (object)obj8 == obj3;
				obj3 = obj8;
			}
			while (!flag2);
		}
		remove
		{
			//IL_0096: Unknown result type (might be due to invalid IL or missing references)
			//IL_009b: Expected O, but got Unknown
			//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a6: Expected O, but got Unknown
			//IL_000e: Expected O, but got I4
			//IL_0065: Expected O, but got I4
			object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3080;
			object obj2 = this + 128;
			Delegate obj3 = (Delegate)obj2;
			object obj6 = default(object);
			bool flag2;
			Delegate obj8 = default(Delegate);
			do
			{
				Delegate obj4 = Delegate.Remove(obj3, value);
				if ((object)obj4 == null)
				{
					object obj5 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag = obj6 == null;
					object obj7 = !flag;
					object obj5 = obj6;
					if (obj7 == null)
					{
						throw new InvalidCastException();
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				flag2 = (object)obj8 == obj3;
				obj3 = obj8;
			}
			while (!flag2);
		}
	}

	public event Action<PredictionCardTeam> OnScoreChange
	{
		add
		{
			//IL_0096: Unknown result type (might be due to invalid IL or missing references)
			//IL_009b: Expected O, but got Unknown
			//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a6: Expected O, but got Unknown
			//IL_000e: Expected O, but got I4
			//IL_0065: Expected O, but got I4
			object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3080;
			object obj2 = this + 136;
			Delegate obj3 = (Delegate)obj2;
			object obj6 = default(object);
			bool flag2;
			Delegate obj8 = default(Delegate);
			do
			{
				Delegate obj4 = Delegate.Combine(obj3, value);
				if ((object)obj4 == null)
				{
					object obj5 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag = obj6 == null;
					object obj7 = !flag;
					object obj5 = obj6;
					if (obj7 == null)
					{
						throw new InvalidCastException();
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				flag2 = (object)obj8 == obj3;
				obj3 = obj8;
			}
			while (!flag2);
		}
		remove
		{
			//IL_0096: Unknown result type (might be due to invalid IL or missing references)
			//IL_009b: Expected O, but got Unknown
			//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a6: Expected O, but got Unknown
			//IL_000e: Expected O, but got I4
			//IL_0065: Expected O, but got I4
			object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3080;
			object obj2 = this + 136;
			Delegate obj3 = (Delegate)obj2;
			object obj6 = default(object);
			bool flag2;
			Delegate obj8 = default(Delegate);
			do
			{
				Delegate obj4 = Delegate.Remove(obj3, value);
				if ((object)obj4 == null)
				{
					object obj5 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag = obj6 == null;
					object obj7 = !flag;
					object obj5 = obj6;
					if (obj7 == null)
					{
						throw new InvalidCastException();
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				flag2 = (object)obj8 == obj3;
				obj3 = obj8;
			}
			while (!flag2);
		}
	}

	private void Start()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_013e: Expected I, but got O
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		//IL_0045: Expected O, but got I
		//IL_0071: Expected I, but got O
		//IL_0082: Expected O, but got I
		//IL_00ae: Expected I, but got O
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Expected O, but got Unknown
		//IL_00f1: Expected O, but got I
		//IL_010e: Expected I, but got O
		object obj = typeof(GameReplayController.<OnEndRoundEventIe>d__138) + 3456;
		object obj2 = (nint)0 + (nint)1872;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		InputField.OnValidateInput onValidateInput = default(InputField.OnValidateInput);
		onValidateInput..ctor(null, (IntPtr)obj2);
		object obj3 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3576;
		object obj4 = (nint)0 + (nint)1704;
		scorePrediction.OnValidateInput += onValidateInput;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj4);
		object obj5 = (nint)0 + (nint)1712;
		scorePrediction.OnValueChanged += action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action2 = default(Action<object>);
		action2..ctor((object)this, (IntPtr)obj5);
		scorePrediction.OnEndEdit += action2;
		Button button = predictButton;
		object obj6 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
		object obj7 = (nint)0 + (nint)1040;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction = default(UnityAction);
		unityAction..ctor(scorePrediction, (IntPtr)obj7);
		button.m_OnClick.AddListener(unityAction);
	}

	public void FocusInput()
	{
		scorePrediction.FocusInput();
	}

	public void Populate(SportTeam team)
	{
		//IL_0082: Expected O, but got I
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Expected O, but got Unknown
		//IL_00a2: Expected O, but got I
		//IL_00aa: Expected I, but got O
		//IL_00cf: Expected I, but got O
		TextMeshProExtensions.FixArabic(teamName, team.<name>k__BackingField);
		GameObject gameObject = icon.gameObject;
		gameObject.SetActive(value: false);
		GameObject gameObject2 = predictButton.gameObject;
		gameObject2.SetActive(value: true);
		TextMeshProUGUI textMeshProUGUI = actualScoreText;
		object text = (nint)0 + (nint)2000;
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1304;
		object obj2 = (nint)0 + (nint)1688;
		nint num = (nint)textMeshProUGUI;
		textMeshProUGUI.text = (string)text;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<bool> action = default(Action<bool>);
		action..ctor((object)this, (IntPtr)obj2);
		UIExtensions.LoadSportTeamImage(icon, team, ImageCacher.SportTeamImageType.Prediction, setNative: false, action, loadingIndicator);
	}

	public void SetState(PredictionTeamState state)
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0085: Expected O, but got I4
		//IL_0093: Expected O, but got I4
		//IL_00ad: Expected O, but got I4
		//IL_00db: Expected O, but got I4
		//IL_00ea: Expected O, but got I4
		//IL_00fa: Expected O, but got I
		//IL_010a: Expected O, but got I
		if (state != PredictionTeamState.None)
		{
			GameObject gameObject = winStateNotch.gameObject;
			object obj = typeof(System.Buffers.Text.ParserHelpers) + 1600;
			gameObject.SetActive(value: true);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
			Enum enumeration = default(Enum);
			string friendlyName = EnumExtensions.GetFriendlyName(enumeration);
			TextMeshProExtensions.Localize(winStateText, friendlyName);
			bool flag = state < PredictionTeamState.PredictedDraw;
			object obj2 = !flag;
			object obj3 = state - 4;
			bool flag2 = obj3 == null;
			object obj4 = !flag2;
			object obj5 = obj2 & obj4;
			Sprite sprite = null;
			if (obj5 == null)
			{
				object obj6 = state - 1;
				object obj7 = 119873536 + 2960;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ X9_v4+v151 @ X8_v5*8]");
				object obj8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (PredictionCardTeam)+v154 @ X8_v6]");
				sprite = (Sprite)0;
			}
			winStateNotch.sprite = sprite;
		}
		else
		{
			GameObject gameObject2 = winStateNotch.gameObject;
			gameObject2.SetActive(value: false);
		}
	}

	public void SetFinalScore(int predictedScore, int actualScore)
	{
		GameObject gameObject = predictButton.gameObject;
		gameObject.SetActive(value: false);
		predictedScoreContainer.SetActive(value: true);
		int num = default(int);
		string text = num.ToString();
		actualScoreText.text = text;
		int num2 = default(int);
		string text2 = num2.ToString();
		predictedScoreText.text = text2;
	}

	public void SetPredictedScore(int predictedScore)
	{
		//IL_004d: Expected O, but got I
		GameObject gameObject = predictButton.gameObject;
		gameObject.SetActive(value: false);
		predictedScoreContainer.SetActive(value: true);
		object text = (nint)0 + (nint)2000;
		actualScoreText.text = (string)text;
		int num = default(int);
		string text2 = num.ToString();
		predictedScoreText.text = text2;
	}

	private void OnPredictionChanged(string newValue)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0052: Expected O, but got I4
		//IL_007f: Expected O, but got I
		//IL_008f: Expected O, but got I
		//IL_009f: Expected O, but got I
		object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 2504;
		string text = scorePrediction.Text;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X8_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		string text2 = StringUtil.HinduToArabicNumber(text);
		scorePrediction.Text = text2;
		Action<PredictionCardTeam> onScoreChange = this.OnScoreChange;
		if (this.OnScoreChange != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X8_v4 (System.Action`1<PredictionCardTeam>)+18]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X8_v4 (System.Action`1<PredictionCardTeam>)+40]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X8_v4 (System.Action`1<PredictionCardTeam>)+28]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v69 @ X3_v1 (should have been resolved before IL gen)");
		}
	}

	private void OnPredictionEnd(string newValue)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0078: Expected O, but got I4
		//IL_00f9: Expected O, but got I
		//IL_0109: Expected O, but got I
		//IL_0119: Expected O, but got I
		object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 2504;
		string text = scorePrediction.Text;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X8_v3+E4]");
		if ((nint)0 != 0)
		{
			bool flag = StringUtil.IsNumber(text);
			bool flag2 = !flag;
			object obj3 = !flag2;
			if (obj3 == null)
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			if (!StringUtil.IsNumber(text))
			{
				return;
			}
		}
		Action<PredictionCardTeam> onReadyStateChange = this.OnReadyStateChange;
		if (this.OnReadyStateChange != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X8_v5 (System.Action`1<PredictionCardTeam>)+18]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X8_v5 (System.Action`1<PredictionCardTeam>)+40]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X8_v5 (System.Action`1<PredictionCardTeam>)+28]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v59 @ X3_v1 (should have been resolved before IL gen)");
		}
	}

	private Sprite GetIconSprite(PredictionTeamState state)
	{
		//IL_000e: Expected O, but got I4
		//IL_0028: Expected O, but got I4
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected O, but got Unknown
		//IL_0050: Expected O, but got I4
		//IL_007a: Expected O, but got I4
		//IL_008a: Expected O, but got I
		//IL_0097: Expected O, but got I
		object obj = state - 1;
		bool flag = (nint)obj < 3;
		object obj2 = !flag;
		object obj3 = obj - 3;
		bool flag2 = obj3 == null;
		object obj4 = !flag2;
		object obj5 = obj2 & obj4;
		if (obj5 == null)
		{
			object obj6 = 119873536 + 2960;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v14 @ X9_v2+v0 @ X8_v1*8]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (PredictionCardTeam)+v15 @ X8_v2]");
			return (Sprite)0;
		}
		return null;
	}

	private void <Populate>b__25_0(bool isSuccess)
	{
		GameObject gameObject = icon.gameObject;
		gameObject.SetActive(isSuccess);
	}
}
