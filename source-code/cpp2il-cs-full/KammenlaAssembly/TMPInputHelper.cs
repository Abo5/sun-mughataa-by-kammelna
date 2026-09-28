using System;
using System.Buffers.Text;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using TMPro;
using Unity.Properties;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;

public class TMPInputHelper : MonoBehaviour
{
	private TMP_InputField input;

	public Button clear;

	private void Start()
	{
		//IL_000c: Expected O, but got I
		//IL_0289: Unknown result type (might be due to invalid IL or missing references)
		//IL_028e: Expected O, but got Unknown
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected O, but got Unknown
		//IL_0031: Expected O, but got I
		//IL_0049: Expected I, but got O
		//IL_005a: Expected O, but got I
		//IL_006f: Expected O, but got I
		//IL_0088: Expected O, but got I
		//IL_00a0: Expected I, but got O
		//IL_00ba: Expected O, but got I
		//IL_00d3: Expected O, but got I
		//IL_00eb: Expected I, but got O
		//IL_0105: Expected O, but got I
		//IL_011e: Expected O, but got I
		//IL_0136: Expected I, but got O
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Expected O, but got Unknown
		//IL_0164: Expected O, but got I
		//IL_025c: Expected O, but got I4
		//IL_0265: Expected O, but got I4
		//IL_01b5: Expected O, but got I4
		//IL_01e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01eb: Expected O, but got Unknown
		//IL_0201: Expected O, but got I
		//IL_020f: Expected I, but got O
		object obj = (nint)0 + (nint)104;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
		object obj2 = this + 32;
		object obj3 = default(object);
		obj2 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj4 = obj2;
		object obj5 = typeof(TypeConverter<ushort, char>) + 464;
		object obj6 = (nint)0 + (nint)3744;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction<object> unityAction = default(UnityAction<object>);
		unityAction..ctor((object)this, (IntPtr)obj6);
		object obj7 = (nint)0 + (nint)1208;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X8_v3+1B8]");
		((UnityEvent<object>)0).AddListener(unityAction);
		object obj8 = obj2;
		object obj9 = (nint)0 + (nint)3752;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction<object> unityAction2 = default(UnityAction<object>);
		unityAction2..ctor((object)this, (IntPtr)obj9);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X8_v5+1A0]");
		((UnityEvent<object>)0).AddListener(unityAction2);
		object obj10 = obj2;
		object obj11 = (nint)0 + (nint)3776;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction<object> unityAction3 = default(UnityAction<object>);
		unityAction3..ctor((object)this, (IntPtr)obj11);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X8_v6+1D0]");
		((UnityEvent<object>)0).AddListener(unityAction3);
		object obj12 = obj2;
		object obj13 = (nint)0 + (nint)3768;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction<object> unityAction4 = default(UnityAction<object>);
		unityAction4..ctor((object)this, (IntPtr)obj13);
		object obj14 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X8_v7+1B0]");
		((UnityEvent<object>)0).AddListener(unityAction4);
		object obj15 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v196 @ X8_v8+E4]");
		if ((nint)0 != 0)
		{
			bool flag = clear != null;
			bool flag2 = !flag;
			object obj16 = 0;
			UnityEngine.Object obj17 = null;
			if (flag2)
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag3 = clear != null;
			bool flag4 = !flag3;
			object obj18 = !flag4;
			object obj16 = 0;
			UnityEngine.Object obj17 = null;
			if (obj18 == null)
			{
				return;
			}
		}
		Button button = clear;
		object obj19 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj20 = (nint)0 + (nint)3760;
		UnityAction unityAction5 = default(UnityAction);
		unityAction5..ctor(this, (IntPtr)obj20);
		button.m_OnClick.AddListener(unityAction5);
	}

	private void SetText(string textVal)
	{
		ShowClearButton();
	}

	private void OnSelect(string textVal)
	{
		ShowClearButton();
	}

	private void ShowClearButton()
	{
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_00fb: Expected O, but got I4
		TMP_InputField tMP_InputField = input;
		string text = tMP_InputField.m_Text;
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7AF3]");
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

	private void ClearInput()
	{
		//IL_000f: Expected O, but got I4
		//IL_001f: Expected O, but got I
		//IL_002f: Expected O, but got I
		object obj = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4 @ X8_v2+90]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5 @ X8_v3+B8]");
		object text = 0;
		input.text = (string)text;
	}

	private void OnDeselect()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_010c: Expected O, but got I4
		//IL_00b5: Expected O, but got I4
		//IL_00be: Expected O, but got I4
		//IL_0170: Expected O, but got I
		//IL_0194: Expected O, but got I4
		//IL_01cc: Expected O, but got I
		//IL_0155: Expected O, but got I4
		//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f8: Expected O, but got Unknown
		//IL_02c7: Expected O, but got I4
		//IL_0260: Expected O, but got I4
		//IL_0270: Expected O, but got I
		//IL_0280: Expected O, but got I
		object obj = 152989696;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7AF4]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj6;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v22+E4]");
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
			obj5 = clear;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v22+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj6 = clear;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = obj6 != null;
		bool flag4 = !flag3;
		object obj8 = 0;
		if (!flag4)
		{
			goto IL_0164;
		}
		goto IL_02d6;
		IL_02d6:
		HideClearButton();
		return;
		IL_0251:
		object obj9 = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ X8_v13+90]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ X8_v14+B8]");
		object text = 0;
		input.text = (string)text;
		return;
		IL_0164:
		object obj11 = (nint)0 + (nint)400;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D31634");
		Camera camera = default(Camera);
		bool flag5 = (object)camera == null;
		object obj12 = !flag5;
		Camera screenPoint = camera;
		if (obj12 == null)
		{
			Camera main = Camera.main;
			screenPoint = main;
		}
		object obj13 = (nint)0 + (nint)4040;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
		Vector2 pointerPosition = InputUtil.PointerPosition;
		object obj14 = typeof(System.Buffers.Text.ParserHelpers) + 3608;
		object obj15 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ X0_v13+E4]");
		RectTransform rect = default(RectTransform);
		if ((nint)0 != 0)
		{
			if (RectTransformUtility.RectangleContainsScreenPoint(rect, (Vector2)screenPoint, null))
			{
				goto IL_0251;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag6 = RectTransformUtility.RectangleContainsScreenPoint(rect, (Vector2)screenPoint, null);
			bool flag7 = !flag6;
			object obj16 = !flag7;
			if (obj16 != null)
			{
				goto IL_0251;
			}
		}
		goto IL_02d6;
		IL_0091:
		bool flag8 = obj5 != null;
		bool flag9 = !flag8;
		object obj17 = !flag9;
		obj8 = 0;
		if (obj17 != null)
		{
			goto IL_0164;
		}
		goto IL_02d6;
	}

	private void <Start>b__2_0(string text)
	{
		HideClearButton();
	}

	private void <Start>b__2_1(string text)
	{
		OnDeselect();
	}
}
