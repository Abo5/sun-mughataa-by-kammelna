using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Linq;
using Cpp2ILInjected;
using DG.Tweening;
using Features.GameReplay;
using HuaweiMobileServices.Location.Location;
using Kammelna.Server.Models.Clans;
using TMPro;
using Unity.Properties;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;

public class InputFieldTMProUGUI : MonoBehaviour, ISelectHandler, IEventSystemHandler, IBeginDragHandler, IEndDragHandler, IDragHandler, IPointerClickHandler
{
	private sealed class <>c__DisplayClass48_0
	{
		public InputFieldTMProUGUI <>4__this;

		public Vector2 pointerPos;

		internal bool <OnDeselect>b__0(Camera cam)
		{
			//IL_00a6: Expected I4, but got O
			//IL_0033: Expected O, but got I
			//IL_0042: Unknown result type (might be due to invalid IL or missing references)
			//IL_0047: Expected O, but got Unknown
			//IL_007b: Expected O, but got I4
			InputFieldTMProUGUI inputFieldTMProUGUI = <>4__this;
			if ((object)<>4__this != null && (object)inputFieldTMProUGUI.clear != null)
			{
				object obj = (nint)0 + (nint)4040;
				object obj2 = typeof(System.Buffers.Text.ParserHelpers) + 3608;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
				object obj3 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X8_v6+E4]");
				bool flag = (nint)0 == 0;
				object obj4 = !flag;
				if (obj4 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				RectTransform rect = default(RectTransform);
				return RectTransformUtility.RectangleContainsScreenPoint(rect, (Vector2)cam, null);
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private sealed class <>c__DisplayClass56_0
	{
		public InputFieldTMProUGUI <>4__this;

		public int target;

		public Action onComplete;

		internal unsafe void <AnimateValueChange>b__0()
		{
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0015: Expected I4, but got Unknown
			InputFieldTMProUGUI inputFieldTMProUGUI = <>4__this;
			int num = this + 24;
			string text = ((int*)num)->ToString();
			inputFieldTMProUGUI.input.text = text;
			Action action = onComplete;
			if (onComplete != null)
			{
				IntPtr invoke_impl = ((Delegate)action).invoke_impl;
				IntPtr method_code = ((Delegate)action).method_code;
				IntPtr method = ((Delegate)action).method;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v47 @ X2_v2 (System.IntPtr) (should have been resolved before IL gen)");
			}
		}
	}

	private TextMeshProUGUI text;

	private TextMeshProUGUI placeholder;

	private InputField input;

	private Button clear;

	private ScrollRect _scrollRect;

	private bool _isDragging;

	public UnityEvent<InputField> onSelect;

	public UnityEvent<InputField> onDeselect;

	private Action<string> m_OnValueChanged;

	private Action<string> m_OnEndEdit;

	private InputField.OnValidateInput m_OnValidateInput;

	public string Text
	{
		get
		{
			InputField inputField = input;
			if ((object)input != null)
			{
				return inputField.m_Text;
			}
			return (string)(object)new NullReferenceException();
		}
		set
		{
			input.text = value;
		}
	}

	public bool Interactable
	{
		get
		{
			//IL_0041: Expected I4, but got O
			InputField inputField = input;
			if ((object)input != null)
			{
				return ((Selectable)inputField).m_Interactable;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
		set
		{
			input.interactable = value;
		}
	}

	public bool Selected
	{
		get
		{
			//IL_0041: Expected I4, but got O
			InputField inputField = input;
			if ((object)input != null)
			{
				return inputField.m_AllowInput;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	public Color TextColor
	{
		get
		{
			//IL_0031: Expected I, but got O
			TextMeshProUGUI textMeshProUGUI = text;
			if ((object)text != null)
			{
				nint num = (nint)textMeshProUGUI;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: [v3 @ X8_v1 (Il2CppClass<TMPro.TextMeshProUGUI>)+298] (should have been resolved before IL gen)");
			}
			return (Color)new NullReferenceException();
		}
		set
		{
			//IL_0017: Expected I, but got O
			//IL_0027: Expected O, but got I
			//IL_0037: Expected O, but got I
			TextMeshProUGUI textMeshProUGUI = text;
			nint num = (nint)textMeshProUGUI;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ X8_v1 (Il2CppClass<TMPro.TextMeshProUGUI>)+2A8]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ X8_v1 (Il2CppClass<TMPro.TextMeshProUGUI>)+2B0]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v4 @ X2_v1 (should have been resolved before IL gen)");
			/*Error: End of method reached without returning.*/;
		}
	}

	public InputField.ContentType ContentType
	{
		get
		{
			//IL_0041: Expected I4, but got O
			InputField inputField = input;
			if ((object)input != null)
			{
				return inputField.m_ContentType;
			}
			NullReferenceException ex = new NullReferenceException();
			return (InputField.ContentType)ex;
		}
		set
		{
			input.contentType = value;
		}
	}

	public float FontSize
	{
		get
		{
			TextMeshProUGUI textMeshProUGUI = text;
			return ((TMP_Text)textMeshProUGUI).m_fontSize;
		}
		set
		{
			text.fontSize = value;
		}
	}

	public float CharacterSpacing
	{
		get
		{
			TextMeshProUGUI textMeshProUGUI = text;
			return ((TMP_Text)textMeshProUGUI).m_characterSpacing;
		}
		set
		{
			text.characterSpacing = value;
		}
	}

	public event Action<string> OnValueChanged
	{
		add
		{
			//IL_0096: Unknown result type (might be due to invalid IL or missing references)
			//IL_009b: Expected O, but got Unknown
			//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a6: Expected O, but got Unknown
			//IL_000e: Expected O, but got I4
			//IL_0065: Expected O, but got I4
			object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3576;
			object obj2 = this + 96;
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
			object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3576;
			object obj2 = this + 96;
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

	public event Action<string> OnEndEdit
	{
		add
		{
			//IL_0096: Unknown result type (might be due to invalid IL or missing references)
			//IL_009b: Expected O, but got Unknown
			//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a6: Expected O, but got Unknown
			//IL_000e: Expected O, but got I4
			//IL_0065: Expected O, but got I4
			object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3576;
			object obj2 = this + 104;
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
			object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3576;
			object obj2 = this + 104;
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

	public event InputField.OnValidateInput OnValidateInput
	{
		add
		{
			//IL_0098: Unknown result type (might be due to invalid IL or missing references)
			//IL_009d: Expected O, but got Unknown
			//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a8: Expected O, but got Unknown
			object obj = typeof(GameReplayController.<OnEndRoundEventIe>d__138) + 3456;
			object obj2 = this + 112;
			Delegate obj3 = (Delegate)obj2;
			bool flag;
			Delegate obj5 = default(Delegate);
			do
			{
				Delegate obj4 = Delegate.Combine(obj3, value);
				if ((object)obj4 == null || obj4 == obj)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
					flag = (object)obj5 == obj3;
					obj3 = obj5;
					continue;
				}
				throw new InvalidCastException();
			}
			while (!flag);
		}
		remove
		{
			//IL_0098: Unknown result type (might be due to invalid IL or missing references)
			//IL_009d: Expected O, but got Unknown
			//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a8: Expected O, but got Unknown
			object obj = typeof(GameReplayController.<OnEndRoundEventIe>d__138) + 3456;
			object obj2 = this + 112;
			Delegate obj3 = (Delegate)obj2;
			bool flag;
			Delegate obj5 = default(Delegate);
			do
			{
				Delegate obj4 = Delegate.Remove(obj3, value);
				if ((object)obj4 == null || obj4 == obj)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
					flag = (object)obj5 == obj3;
					obj3 = obj5;
					continue;
				}
				throw new InvalidCastException();
			}
			while (!flag);
		}
	}

	private void Awake()
	{
		//IL_000c: Expected O, but got I
		//IL_02b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bc: Expected O, but got Unknown
		//IL_02de: Expected O, but got I
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected O, but got Unknown
		//IL_0031: Expected O, but got I
		//IL_0049: Expected I, but got O
		//IL_005a: Expected O, but got I
		//IL_006f: Expected O, but got I
		//IL_008a: Expected O, but got I
		//IL_00a2: Expected I, but got O
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Expected O, but got Unknown
		//IL_00e8: Expected O, but got I
		//IL_0100: Expected I, but got O
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Expected O, but got Unknown
		//IL_0223: Expected O, but got I4
		//IL_01cb: Expected O, but got I4
		//IL_01d5: Expected O, but got I4
		//IL_0254: Unknown result type (might be due to invalid IL or missing references)
		//IL_0259: Expected O, but got Unknown
		//IL_026f: Expected O, but got I
		//IL_027d: Expected I, but got O
		object obj = (nint)0 + (nint)504;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D31634");
		object obj2 = this + 64;
		object obj3 = default(object);
		obj2 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X20_v3-10]");
		object obj4 = 0;
		object obj5 = typeof(TypeConverter<ushort, char>) + 464;
		object obj6 = (nint)0 + (nint)1016;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction<object> unityAction = default(UnityAction<object>);
		unityAction..ctor((object)this, (IntPtr)obj6);
		object obj7 = (nint)0 + (nint)1208;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X8_v3+148]");
		((UnityEvent<object>)0).AddListener(unityAction);
		InputField inputField = input;
		object obj8 = (nint)0 + (nint)1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction<object> unityAction2 = default(UnityAction<object>);
		unityAction2..ctor((object)this, (IntPtr)obj8);
		((UnityEvent<object>)(object)inputField.m_OnDidEndEdit).AddListener(unityAction2);
		InputField inputField2 = input;
		object obj9 = typeof(GameReplayController.<OnEndRoundEventIe>d__138) + 3456;
		object obj10 = (nint)0 + (nint)1048;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		InputField.OnValidateInput onValidateInput = default(InputField.OnValidateInput);
		onValidateInput..ctor(this, (IntPtr)obj10);
		Delegate obj11 = Delegate.Combine(inputField2.m_OnValidateInput, onValidateInput);
		if ((object)obj11 == null || obj11 == obj9)
		{
			object obj12 = typeof(MemberAchievementClanFeedData) + 2976;
			inputField2.onValidateInput = (InputField.OnValidateInput)obj11;
			object obj13 = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v247 @ X8_v8+E4]");
			if ((nint)0 != 0)
			{
				bool flag = clear != null;
				bool flag2 = !flag;
				object obj14 = !flag2;
				object obj15 = 0;
				UnityEngine.Object obj16 = null;
				if (obj14 == null)
				{
					goto IL_01e8;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				bool flag3 = clear != null;
				bool flag4 = !flag3;
				object obj15 = 0;
				UnityEngine.Object obj16 = null;
				if (flag4)
				{
					goto IL_01e8;
				}
			}
			Button button = clear;
			object obj17 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj18 = (nint)0 + (nint)1032;
			UnityAction unityAction3 = default(UnityAction);
			unityAction3..ctor(this, (IntPtr)obj18);
			button.m_OnClick.AddListener(unityAction3);
			SetText();
			return;
		}
		throw new InvalidCastException();
		IL_01e8:
		SetText();
	}

	private void OnDisable()
	{
		int num = ShortcutExtensions.DOKill(text, complete: true);
	}

	public void Select()
	{
		//IL_0017: Expected I, but got O
		//IL_0027: Expected O, but got I
		//IL_0037: Expected O, but got I
		InputField inputField = input;
		nint num = (nint)inputField;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ X8_v1 (Il2CppClass<UnityEngine.UI.InputField>)+398]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ X8_v1 (Il2CppClass<UnityEngine.UI.InputField>)+3A0]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v4 @ X2_v1 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}

	private void SetText()
	{
		//IL_0018: Expected O, but got I4
		//IL_003f: Expected O, but got I4
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_0067: Expected O, but got I4
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Expected O, but got Unknown
		//IL_0178: Expected O, but got I4
		//IL_0215: Expected O, but got I4
		InputField inputField = input;
		object obj = inputField.m_ContentType - 7;
		string text = inputField.m_Text;
		bool flag = (nint)obj < 1;
		object obj2 = !flag;
		object obj3 = obj - 1;
		bool flag2 = obj3 == null;
		object obj4 = !flag2;
		object obj5 = obj2 & obj4;
		if (obj5 == null)
		{
			object element = "{0} color encoding is currently unsupported for outputting to HDR." + 2792;
			IEnumerable<object> enumerable = Enumerable.Repeat(element, text._stringLength);
			string text2 = string.Concat((IEnumerable<string>)enumerable);
			this.text.text = text2;
		}
		else
		{
			TextMeshProExtensions.FixArabic(this.text, text);
		}
		InputField inputField2 = input;
		string text3 = inputField2.m_Text;
		Component component;
		if (text3._stringLength != 0)
		{
			GameObject gameObject = this.text.gameObject;
			gameObject.SetActive(value: true);
			ShowClearButton();
			component = placeholder;
			bool flag3 = (object)placeholder == null;
			object obj6 = !flag3;
			if (obj6 == null)
			{
				throw new NullReferenceException();
			}
		}
		else
		{
			GameObject gameObject2 = placeholder.gameObject;
			gameObject2.SetActive(value: true);
			HideClearButton();
			component = this.text;
		}
		GameObject gameObject3 = component.gameObject;
		gameObject3.SetActive(value: false);
		InputField inputField3 = input;
		bool flag4 = !inputField3.m_AllowInput;
		object obj7 = !flag4;
		if (obj7 == null)
		{
			HideClearButton();
			inputField3 = input;
		}
		Actions.SafeInvoke((Action<object>)this.OnValueChanged, inputField3.m_Text);
	}

	public void SetPlaceholder(string newPlaceholder)
	{
		LocalizableText localizableText = TextMeshProExtensions.Localize(newPlaceholder);
		TextMeshProExtensions.Localize(placeholder, localizableText);
	}

	public void SetPlaceholder(LocalizableText newPlaceholder)
	{
		TextMeshProExtensions.Localize(placeholder, newPlaceholder);
	}

	private void ShowClearButton()
	{
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_00fb: Expected O, but got I4
		InputField inputField = input;
		string text = inputField.m_Text;
		if (text._stringLength < 1)
		{
			return;
		}
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X0_v5+E4]");
		if ((nint)0 != 0)
		{
			if (!(clear != null))
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag = clear != null;
			bool flag2 = !flag;
			object obj3 = !flag2;
			if (obj3 == null)
			{
				return;
			}
		}
		GameObject gameObject = clear.gameObject;
		gameObject.SetActive(value: true);
	}

	private void HideClearButton()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_010b: Expected O, but got I4
		//IL_0160: Expected O, but got I4
		object obj = 152989696;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7ABA]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj6;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			obj5 = clear;
			obj6 = clear;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v2+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj5 = clear;
			obj6 = clear;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = obj6 != null;
		bool flag4 = !flag3;
		object obj8 = !flag4;
		if (obj8 == null)
		{
			return;
		}
		goto IL_00b8;
		IL_00b8:
		GameObject gameObject = clear.gameObject;
		gameObject.SetActive(value: false);
		return;
		IL_0091:
		if (obj5 != null)
		{
			goto IL_00b8;
		}
	}

	public void ClearInput()
	{
		//IL_0011: Expected O, but got I
		object obj = (nint)0 + (nint)2000;
		input.text = (string)obj;
		GameObject gameObject = placeholder.gameObject;
		gameObject.SetActive(value: true);
		HideClearButton();
		GameObject gameObject2 = text.gameObject;
		gameObject2.SetActive(value: false);
	}

	public void AddNumericValue(int value)
	{
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected O, but got Unknown
		//IL_009d: Expected O, but got I4
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Expected O, but got Unknown
		InputField inputField = input;
		if (inputField.m_ContentType == InputField.ContentType.IntegerNumber)
		{
			int num = int.Parse(inputField.m_Text);
			int num2 = default(int);
			string text = num2.ToString();
			input.text = text;
			return;
		}
		object obj = typeof(DataRelation) + 856;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object message = "COORDINATE_TYPE_GCJ_02" + 1304;
		Debug.Log(message);
	}

	public void OnSelect(BaseEventData e)
	{
		ShowClearButton();
	}

	private void OnDeselect()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0051: Expected O, but got I
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Expected O, but got Unknown
		//IL_0121: Expected O, but got I4
		//IL_00cc: Expected O, but got I4
		//IL_00d5: Expected O, but got I4
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Expected O, but got Unknown
		//IL_0180: Expected O, but got I
		//IL_0191: Expected I, but got O
		//IL_01a2: Expected O, but got I
		//IL_01c4: Expected O, but got I
		//IL_01dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e2: Expected O, but got Unknown
		//IL_026a: Expected O, but got I4
		//IL_0280: Expected O, but got I4
		//IL_021d: Expected O, but got I4
		//IL_022e: Expected O, but got I4
		//IL_02f1: Expected O, but got I4
		object obj = typeof(GameReplayController.<OnEndRoundEventIe>d__138) + 3472;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = obj2 + 16;
		obj3 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		InputField inputField = input;
		object obj4 = (nint)0 + (nint)2336;
		object obj5 = typeof(MemberAchievementClanFeedData) + 2976;
		Actions.SafeInvoke((Action<object>)this.OnEndEdit, inputField.m_Text);
		object obj6 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ X0_v10+E4]");
		if ((nint)0 != 0)
		{
			bool flag = clear != null;
			bool flag2 = !flag;
			object obj7 = !flag2;
			object obj8 = 0;
			UnityEngine.Object obj9 = null;
			if (obj7 != null)
			{
				goto IL_0135;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag3 = clear != null;
			bool flag4 = !flag3;
			object obj8 = 0;
			UnityEngine.Object obj9 = null;
			if (!flag4)
			{
				goto IL_0135;
			}
		}
		goto IL_0300;
		IL_02a2:
		if (!InputUtil.PointerHeld)
		{
			goto IL_0300;
		}
		ClearInput();
		UnityEvent<object> unityEvent = (UnityEvent<object>)(object)onDeselect;
		bool flag5 = onDeselect == null;
		object obj10 = !flag5;
		if (obj10 == null)
		{
			return;
		}
		goto IL_032f;
		IL_032f:
		unityEvent.Invoke(input);
		return;
		IL_0135:
		Vector2 pointerPosition = InputUtil.PointerPosition;
		Camera[] allCameras = Camera.allCameras;
		object obj11 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 368;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj12 = (nint)0 + (nint)832;
		Func<object, bool> func = default(Func<object, bool>);
		func..ctor(obj2, (IntPtr)obj12);
		object obj13 = (nint)0 + (nint)2488;
		bool flag6 = Enumerable.Any(allCameras, func);
		object obj14 = (nint)0 + (nint)4040;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
		object obj15 = typeof(System.Buffers.Text.ParserHelpers) + 3608;
		object obj16 = obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v330 @ X8_v21+E4]");
		RectTransform rect = default(RectTransform);
		if ((nint)0 != 0)
		{
			bool flag7 = RectTransformUtility.RectangleContainsScreenPoint(rect, (Vector2)0);
			object obj17 = flag6 || flag7;
			if ((nint)obj17 == 1)
			{
				goto IL_02a2;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag8 = RectTransformUtility.RectangleContainsScreenPoint(rect, (Vector2)0);
			object obj18 = flag6 || flag8;
			if ((nint)obj18 == 1)
			{
				goto IL_02a2;
			}
		}
		goto IL_0300;
		IL_0300:
		HideClearButton();
		unityEvent = (UnityEvent<object>)(object)onDeselect;
		if (onDeselect == null)
		{
			return;
		}
		goto IL_032f;
	}

	private char ValidatorCallback(string s, int charindex, char addedchar)
	{
		InputField.OnValidateInput onValidateInput = this.OnValidateInput;
		if (this.OnValidateInput != null)
		{
			IntPtr invoke_impl = ((Delegate)onValidateInput).invoke_impl;
			IntPtr method_code = ((Delegate)onValidateInput).method_code;
			IntPtr method = ((Delegate)onValidateInput).method;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v3 @ X5_v1 (System.IntPtr) (should have been resolved before IL gen)");
		}
		return addedchar;
	}

	public void FocusInput()
	{
		UIExtensions.ShowKeyboard(input);
	}

	public void OnBeginDrag(PointerEventData data)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0110: Expected O, but got I4
		//IL_00b5: Expected O, but got I4
		//IL_00be: Expected O, but got I4
		//IL_0159: Expected O, but got I4
		//IL_024f: Expected O, but got I4
		//IL_0201: Unknown result type (might be due to invalid IL or missing references)
		//IL_0206: Expected O, but got Unknown
		object obj = 152989696;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7ABE]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object scrollRect;
		UnityEngine.Object scrollRect2;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v15+E4]");
			bool flag = (nint)0 == 0;
			scrollRect = _scrollRect;
			scrollRect2 = _scrollRect;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			scrollRect = _scrollRect;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v15+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			scrollRect2 = _scrollRect;
			if (obj5 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = scrollRect2 != null;
		bool flag4 = !flag3;
		object obj6 = 0;
		UnityEngine.Object obj7 = null;
		if (!flag4)
		{
			goto IL_016c;
		}
		return;
		IL_016c:
		object obj8 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X0_v3+E4]");
		if ((nint)0 != 0)
		{
			if (!(input != null))
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag5 = input != null;
			bool flag6 = !flag5;
			object obj9 = !flag6;
			if (obj9 == null)
			{
				return;
			}
		}
		_isDragging = true;
		input.DeactivateInputField();
		input.enabled = false;
		object methodName = "October" + 296;
		_scrollRect.SendMessage((string)methodName, data);
		return;
		IL_0091:
		bool flag7 = scrollRect != null;
		bool flag8 = !flag7;
		object obj10 = !flag8;
		obj6 = 0;
		obj7 = null;
		if (obj10 == null)
		{
			return;
		}
		goto IL_016c;
	}

	public void OnEndDrag(PointerEventData data)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0110: Expected O, but got I4
		//IL_00b5: Expected O, but got I4
		//IL_00be: Expected O, but got I4
		//IL_0159: Expected O, but got I4
		//IL_022a: Expected O, but got I4
		//IL_01dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e1: Expected O, but got Unknown
		object obj = 152989696;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7ABF]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object scrollRect;
		UnityEngine.Object scrollRect2;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v12+E4]");
			bool flag = (nint)0 == 0;
			scrollRect = _scrollRect;
			scrollRect2 = _scrollRect;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			scrollRect = _scrollRect;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v12+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			scrollRect2 = _scrollRect;
			if (obj5 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = scrollRect2 != null;
		bool flag4 = !flag3;
		object obj6 = 0;
		UnityEngine.Object obj7 = null;
		if (!flag4)
		{
			goto IL_016c;
		}
		return;
		IL_016c:
		object obj8 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X0_v3+E4]");
		if ((nint)0 != 0)
		{
			if (!(input != null))
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag5 = input != null;
			bool flag6 = !flag5;
			object obj9 = !flag6;
			if (obj9 == null)
			{
				return;
			}
		}
		_isDragging = false;
		object methodName = "October" + 384;
		_scrollRect.SendMessage((string)methodName, data);
		return;
		IL_0091:
		bool flag7 = scrollRect != null;
		bool flag8 = !flag7;
		object obj10 = !flag8;
		obj6 = 0;
		obj7 = null;
		if (obj10 == null)
		{
			return;
		}
		goto IL_016c;
	}

	public void OnDrag(PointerEventData data)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0110: Expected O, but got I4
		//IL_00b5: Expected O, but got I4
		//IL_00be: Expected O, but got I4
		//IL_0159: Expected O, but got I4
		//IL_021a: Expected O, but got I4
		//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d1: Expected O, but got Unknown
		object obj = 152989696;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7AC0]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object scrollRect;
		UnityEngine.Object scrollRect2;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v12+E4]");
			bool flag = (nint)0 == 0;
			scrollRect = _scrollRect;
			scrollRect2 = _scrollRect;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			scrollRect = _scrollRect;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v12+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			scrollRect2 = _scrollRect;
			if (obj5 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = scrollRect2 != null;
		bool flag4 = !flag3;
		object obj6 = 0;
		UnityEngine.Object obj7 = null;
		if (!flag4)
		{
			goto IL_016c;
		}
		return;
		IL_016c:
		object obj8 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X0_v3+E4]");
		if ((nint)0 != 0)
		{
			if (!(input != null))
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag5 = input != null;
			bool flag6 = !flag5;
			object obj9 = !flag6;
			if (obj9 == null)
			{
				return;
			}
		}
		object methodName = "October" + 368;
		_scrollRect.SendMessage((string)methodName, data);
		return;
		IL_0091:
		bool flag7 = scrollRect != null;
		bool flag8 = !flag7;
		object obj10 = !flag8;
		obj6 = 0;
		obj7 = null;
		if (obj10 == null)
		{
			return;
		}
		goto IL_016c;
	}

	public void OnPointerClick(PointerEventData data)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0110: Expected O, but got I4
		//IL_00b5: Expected O, but got I4
		//IL_00be: Expected O, but got I4
		//IL_0159: Expected O, but got I4
		//IL_02cd: Expected O, but got I4
		//IL_01de: Expected O, but got I4
		//IL_020b: Expected O, but got I4
		object obj = 152989696;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7AC1]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object scrollRect;
		UnityEngine.Object scrollRect2;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v19+E4]");
			bool flag = (nint)0 == 0;
			scrollRect = _scrollRect;
			scrollRect2 = _scrollRect;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			scrollRect = _scrollRect;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v19+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			scrollRect2 = _scrollRect;
			if (obj5 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = scrollRect2 != null;
		bool flag4 = !flag3;
		object obj6 = 0;
		UnityEngine.Object obj7 = null;
		if (!flag4)
		{
			goto IL_016c;
		}
		goto IL_02db;
		IL_01c2:
		bool flag5 = !_isDragging;
		object obj8 = !flag5;
		if (obj8 != null)
		{
			return;
		}
		bool flag6 = !data.<dragging>k__BackingField;
		object obj9 = !flag6;
		if (obj9 == null)
		{
			if (onSelect != null)
			{
				((UnityEvent<object>)(object)onSelect).Invoke((object)input);
			}
			if (input.shouldActivateOnSelect)
			{
				input.enabled = true;
				input.ActivateInputField();
			}
		}
		return;
		IL_02db:
		if (onSelect != null)
		{
			((UnityEvent<object>)(object)onSelect).Invoke((object)input);
		}
		return;
		IL_016c:
		object obj10 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X0_v5+E4]");
		if ((nint)0 != 0)
		{
			if (input != null)
			{
				goto IL_01c2;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag7 = input != null;
			bool flag8 = !flag7;
			object obj11 = !flag8;
			if (obj11 != null)
			{
				goto IL_01c2;
			}
		}
		goto IL_02db;
		IL_0091:
		bool flag9 = scrollRect != null;
		bool flag10 = !flag9;
		object obj12 = !flag10;
		obj6 = 0;
		obj7 = null;
		if (obj12 != null)
		{
			goto IL_016c;
		}
		goto IL_02db;
	}

	public void Mask(LocalizableText localizableText)
	{
		TextMeshProExtensions.Localize(text, localizableText);
	}

	public void AnimateValueChange(int target, float duration, float delay = 0f, Action onComplete = null)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_0059: Expected O, but got I
		//IL_0065: Expected O, but got I
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected O, but got Unknown
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected O, but got Unknown
		//IL_00ea: Expected O, but got I4
		//IL_015f: Expected I, but got O
		object obj = typeof(GameReplayController.<OnEndRoundEventIe>d__138) + 3480;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(SqlSingle[]) + 3912;
		object obj4 = (nint)0 + (nint)2800;
		object obj5 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2344;
		object obj6 = (nint)0 + (nint)840;
		object obj7 = (nint)0 + (nint)2528;
		object obj8 = obj2 + 16;
		obj8 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj9 = obj2 + 32;
		obj9 = onComplete;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		int num = ShortcutExtensions.DOKill(text, complete: true);
		object obj10 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X0_v12+E4]");
		bool flag = (nint)0 == 0;
		object obj11 = !flag;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		TextMeshProUGUI target2 = text;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X23_v4-8]");
		Tweener tweener = AnimationExtensions.DONumber(target2, 0, duration);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058C78");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TweenCallback tweenCallback = default(TweenCallback);
		tweenCallback..ctor(obj2, (IntPtr)obj6);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058630");
	}

	private void DOKill()
	{
		int num = ShortcutExtensions.DOKill(text, complete: true);
	}

	public void ShowKeyboard()
	{
		UIExtensions.ShowKeyboard(input);
	}

	public bool IsSubmitted()
	{
		return UIExtensions.IsSubmitted(input);
	}

	private void <Awake>b__37_0(string _)
	{
		SetText();
	}

	private void <Awake>b__37_1(string _)
	{
		OnDeselect();
	}
}
