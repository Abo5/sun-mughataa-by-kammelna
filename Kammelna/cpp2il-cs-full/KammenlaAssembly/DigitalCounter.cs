using System;
using System.Diagnostics;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DigitalCounter : MonoBehaviour
{
	private int minValue;

	private int maxValue = 2147483647;

	private int startingValue;

	private Button incrementButton;

	private Button decrementButton;

	private TMP_InputField counterText;

	private int _value;

	private Action<int> m_OnValueChanged;

	public unsafe int Value
	{
		get
		{
			return _value;
		}
		private set
		{
			//IL_0023: Expected O, but got I4
			//IL_0049: Unknown result type (might be due to invalid IL or missing references)
			//IL_004e: Expected I4, but got Unknown
			//IL_0083: Expected O, but got I4
			//IL_0146: Expected O, but got I4
			//IL_016a: Unknown result type (might be due to invalid IL or missing references)
			//IL_016f: Expected I4, but got Unknown
			//IL_01a4: Expected O, but got I4
			//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c6: Expected I4, but got Unknown
			//IL_010e: Expected O, but got I
			//IL_011e: Expected O, but got I
			//IL_012e: Expected O, but got I
			int num = minValue;
			int num2 = maxValue;
			object obj = value - maxValue;
			bool flag = (nint)obj < 0;
			int num3 = value ^ maxValue;
			int num4 = value ^ obj;
			int num5 = num3 & num4;
			bool flag2 = num5 < 0;
			bool flag3 = flag == flag2;
			object obj2 = !flag3;
			object obj3 = ~obj2;
			if (obj3 == null)
			{
				num2 = value;
			}
			object obj4 = value - num;
			bool flag4 = (nint)obj4 < 0;
			int num6 = value ^ num;
			int num7 = value ^ obj4;
			int num8 = num6 & num7;
			bool flag5 = num8 < 0;
			bool flag6 = flag4 == flag5;
			object obj5 = !flag6;
			object obj6 = ~obj5;
			if (obj6 != null)
			{
				num = num2;
			}
			int num9 = this + 72;
			((int*)num9)->m_value = num;
			UpdateButtonsInteractability();
			string text = ((int*)num9)->ToString();
			counterText.text = text;
			Action<int> onValueChanged = this.OnValueChanged;
			if (this.OnValueChanged != null)
			{
				int value2 = ((int*)num9)->m_value;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X8_v3 (System.Action`1<System.Int32>)+18]");
				object obj7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X8_v3 (System.Action`1<System.Int32>)+40]");
				object obj8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X8_v3 (System.Action`1<System.Int32>)+28]");
				object obj9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v77 @ X3_v1 (should have been resolved before IL gen)");
			}
		}
	}

	public event Action<int> OnValueChanged
	{
		add
		{
			//IL_0096: Unknown result type (might be due to invalid IL or missing references)
			//IL_009b: Expected O, but got Unknown
			//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a6: Expected O, but got Unknown
			//IL_000e: Expected O, but got I4
			//IL_0065: Expected O, but got I4
			object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2416;
			object obj2 = this + 80;
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
			object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2416;
			object obj2 = this + 80;
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

	private void UpdateButtonsInteractability()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0212: Expected O, but got I4
		//IL_00b5: Expected O, but got I4
		//IL_00be: Expected O, but got I4
		//IL_0289: Expected O, but got I4
		//IL_02b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b8: Expected I4, but got Unknown
		//IL_0330: Expected O, but got I4
		//IL_0339: Expected O, but got I4
		//IL_0102: Expected I4, but got O
		//IL_0265: Expected O, but got I4
		//IL_0152: Expected O, but got I4
		//IL_018b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0190: Expected I4, but got Unknown
		//IL_01c5: Expected O, but got I4
		//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d2: Expected I4, but got Unknown
		//IL_038c: Expected O, but got I4
		object obj = 152985600;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6529]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj6;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v11+E4]");
			bool flag = (nint)0 == 0;
			obj5 = incrementButton;
			obj6 = incrementButton;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v11+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj5 = incrementButton;
			obj6 = incrementButton;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = obj6 != null;
		bool flag4 = !flag3;
		object obj8 = 0;
		UnityEngine.Object obj9 = null;
		if (flag4)
		{
			goto IL_00d1;
		}
		goto IL_0278;
		IL_0141:
		object obj10 = _value - minValue;
		bool flag5 = (nint)obj10 < 0;
		bool flag6 = obj10 == null;
		int num = _value ^ minValue;
		int num2 = _value ^ obj10;
		int num3 = num & num2;
		bool flag7 = num3 < 0;
		bool flag8 = flag5 == flag7;
		object obj11 = !flag6;
		bool interactable = (byte)((flag8 & obj11) ? 1 : 0) != 0;
		decrementButton.interactable = interactable;
		return;
		IL_011a:
		UnityEngine.Object obj12;
		if (obj12 != null)
		{
			goto IL_0141;
		}
		return;
		IL_0359:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		UnityEngine.Object obj13;
		bool flag9 = obj13 != null;
		bool flag10 = !flag9;
		object obj14 = !flag10;
		if (obj14 == null)
		{
			return;
		}
		goto IL_0141;
		IL_0091:
		bool flag11 = obj5 != null;
		bool flag12 = !flag11;
		object obj15 = !flag12;
		obj8 = 0;
		obj9 = null;
		if (obj15 == null)
		{
			goto IL_00d1;
		}
		goto IL_0278;
		IL_0278:
		object obj16 = _value - maxValue;
		bool flag13 = (nint)obj16 < 0;
		int num4 = _value ^ maxValue;
		int num5 = _value ^ obj16;
		int num6 = num4 & num5;
		bool flag14 = num6 < 0;
		bool flag15 = flag13 == flag14;
		bool flag16 = !flag15;
		incrementButton.interactable = flag16;
		obj12 = decrementButton;
		object obj17 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X0_v4+E4]");
		bool flag17 = (nint)0 == 0;
		object obj18 = !flag17;
		obj8 = 0;
		bool flag18 = flag16;
		obj13 = decrementButton;
		if (obj18 != null)
		{
			goto IL_011a;
		}
		goto IL_0359;
		IL_00d1:
		obj17 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X0_v4+E4]");
		bool flag19 = (nint)0 == 0;
		obj12 = decrementButton;
		flag18 = (byte)(int)obj9 != 0;
		obj13 = decrementButton;
		if (!flag19)
		{
			goto IL_011a;
		}
		goto IL_0359;
	}

	public unsafe void AddValue(int value)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected I4, but got Unknown
		//IL_0036: Expected O, but got I4
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected I4, but got Unknown
		//IL_0096: Expected O, but got I4
		//IL_0165: Expected O, but got I4
		//IL_018b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0190: Expected I4, but got Unknown
		//IL_01c5: Expected O, but got I4
		//IL_012b: Expected O, but got I
		//IL_013b: Expected O, but got I
		//IL_014b: Expected O, but got I
		int num = this + 72;
		int num2 = ((int*)num)->m_value + value;
		int num3 = maxValue;
		object obj = num2 - maxValue;
		bool flag = (nint)obj < 0;
		int num4 = num2 ^ maxValue;
		int num5 = num2 ^ obj;
		int num6 = num4 & num5;
		bool flag2 = num6 < 0;
		bool flag3 = flag == flag2;
		object obj2 = !flag3;
		object obj3 = ~obj2;
		if (obj3 == null)
		{
			num3 = num2;
		}
		object obj4 = num2 - minValue;
		bool flag4 = (nint)obj4 < 0;
		int num7 = num2 ^ minValue;
		int num8 = num2 ^ obj4;
		int num9 = num7 & num8;
		bool flag5 = num9 < 0;
		bool flag6 = flag4 == flag5;
		object obj5 = !flag6;
		object obj6 = ~obj5;
		int value2 = ((obj6 != null) ? num3 : minValue);
		((int*)num)->m_value = value2;
		UpdateButtonsInteractability();
		string text = ((int*)num)->ToString();
		counterText.text = text;
		Action<int> onValueChanged = this.OnValueChanged;
		if (this.OnValueChanged != null)
		{
			int value3 = ((int*)num)->m_value;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X8_v4 (System.Action`1<System.Int32>)+18]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X8_v4 (System.Action`1<System.Int32>)+40]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X8_v4 (System.Action`1<System.Int32>)+28]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v79 @ X3_v1 (should have been resolved before IL gen)");
		}
	}

	public unsafe void SetValue(int value)
	{
		//IL_0023: Expected O, but got I4
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected I4, but got Unknown
		//IL_0083: Expected O, but got I4
		//IL_0146: Expected O, but got I4
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Expected I4, but got Unknown
		//IL_01a4: Expected O, but got I4
		//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c6: Expected I4, but got Unknown
		//IL_010e: Expected O, but got I
		//IL_011e: Expected O, but got I
		//IL_012e: Expected O, but got I
		int num = minValue;
		int num2 = maxValue;
		object obj = value - maxValue;
		bool flag = (nint)obj < 0;
		int num3 = value ^ maxValue;
		int num4 = value ^ obj;
		int num5 = num3 & num4;
		bool flag2 = num5 < 0;
		bool flag3 = flag == flag2;
		object obj2 = !flag3;
		object obj3 = ~obj2;
		if (obj3 == null)
		{
			num2 = value;
		}
		object obj4 = value - num;
		bool flag4 = (nint)obj4 < 0;
		int num6 = value ^ num;
		int num7 = value ^ obj4;
		int num8 = num6 & num7;
		bool flag5 = num8 < 0;
		bool flag6 = flag4 == flag5;
		object obj5 = !flag6;
		object obj6 = ~obj5;
		if (obj6 != null)
		{
			num = num2;
		}
		int num9 = this + 72;
		((int*)num9)->m_value = num;
		UpdateButtonsInteractability();
		string text = ((int*)num9)->ToString();
		counterText.text = text;
		Action<int> onValueChanged = this.OnValueChanged;
		if (this.OnValueChanged != null)
		{
			int value2 = ((int*)num9)->m_value;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X8_v3 (System.Action`1<System.Int32>)+18]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X8_v3 (System.Action`1<System.Int32>)+40]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X8_v3 (System.Action`1<System.Int32>)+28]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v77 @ X3_v1 (should have been resolved before IL gen)");
		}
	}

	public unsafe void ResetValue()
	{
		//IL_001b: Expected O, but got I4
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected I4, but got Unknown
		//IL_007f: Expected O, but got I4
		//IL_0152: Expected O, but got I4
		//IL_017c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Expected I4, but got Unknown
		//IL_01b6: Expected O, but got I4
		//IL_01d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d8: Expected I4, but got Unknown
		//IL_0116: Expected O, but got I
		//IL_0126: Expected O, but got I
		//IL_0136: Expected O, but got I
		int num = maxValue;
		object obj = startingValue - maxValue;
		bool flag = (nint)obj < 0;
		int num2 = startingValue ^ maxValue;
		int num3 = startingValue ^ obj;
		int num4 = num2 & num3;
		bool flag2 = num4 < 0;
		bool flag3 = flag == flag2;
		object obj2 = !flag3;
		object obj3 = ~obj2;
		if (obj3 == null)
		{
			num = startingValue;
		}
		object obj4 = startingValue - minValue;
		bool flag4 = (nint)obj4 < 0;
		int num5 = startingValue ^ minValue;
		int num6 = startingValue ^ obj4;
		int num7 = num5 & num6;
		bool flag5 = num7 < 0;
		bool flag6 = flag4 == flag5;
		object obj5 = !flag6;
		object obj6 = ~obj5;
		int value = ((obj6 != null) ? num : minValue);
		int num8 = this + 72;
		((int*)num8)->m_value = value;
		UpdateButtonsInteractability();
		string text = ((int*)num8)->ToString();
		counterText.text = text;
		Action<int> onValueChanged = this.OnValueChanged;
		if (this.OnValueChanged != null)
		{
			int value2 = ((int*)num8)->m_value;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X8_v3 (System.Action`1<System.Int32>)+18]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X8_v3 (System.Action`1<System.Int32>)+40]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X8_v3 (System.Action`1<System.Int32>)+28]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v78 @ X3_v1 (should have been resolved before IL gen)");
		}
	}

	public unsafe void SetValue(string value)
	{
		//IL_0168: Expected O, but got I4
		//IL_0170: Unknown result type (might be due to invalid IL or missing references)
		//IL_0175: Expected O, but got Unknown
		//IL_0043: Expected O, but got I4
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected I4, but got Unknown
		//IL_00a3: Expected O, but got I4
		//IL_0277: Unknown result type (might be due to invalid IL or missing references)
		//IL_027c: Expected I4, but got Unknown
		//IL_01f4: Expected O, but got I4
		//IL_021a: Unknown result type (might be due to invalid IL or missing references)
		//IL_021f: Expected I4, but got Unknown
		//IL_0254: Expected O, but got I4
		int value2;
		if (int.TryParse(value, out var result))
		{
			int num = maxValue;
			object obj = result - maxValue;
			bool flag = (nint)obj < 0;
			int num2 = result ^ maxValue;
			int num3 = result ^ obj;
			int num4 = num2 & num3;
			bool flag2 = num4 < 0;
			bool flag3 = flag == flag2;
			object obj2 = !flag3;
			object obj3 = ~obj2;
			if (obj3 == null)
			{
				num = result;
			}
			object obj4 = result - minValue;
			bool flag4 = (nint)obj4 < 0;
			int num5 = result ^ minValue;
			int num6 = result ^ obj4;
			int num7 = num5 & num6;
			bool flag5 = num7 < 0;
			bool flag6 = flag4 == flag5;
			object obj5 = !flag6;
			object obj6 = ~obj5;
			value2 = ((obj6 != null) ? num : minValue);
		}
		else
		{
			value2 = minValue;
			int num8 = maxValue & maxValue;
			bool flag7 = minValue < 0;
			bool flag8 = minValue == 0;
			int num9 = minValue ^ minValue;
			int num10 = minValue & num9;
			bool flag9 = num10 < 0;
			bool flag10 = flag7 == flag9;
			object obj7 = !flag8;
			object obj8 = flag10 & obj7;
			object obj9 = ~obj8;
			if (obj9 != null)
			{
				value2 = num8;
			}
		}
		int num11 = this + 72;
		((int*)num11)->m_value = value2;
		UpdateButtonsInteractability();
		string text = ((int*)num11)->ToString();
		counterText.text = text;
		Action<int> onValueChanged = this.OnValueChanged;
		if (this.OnValueChanged != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v117 @ X8_v3 (System.Action`1<System.Int32>)+18] (should have been resolved before IL gen)");
		}
	}
}
