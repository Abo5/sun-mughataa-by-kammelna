using System;
using System.Data.SqlTypes;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;

public class CustomButton : MonoBehaviour
{
	private TextMeshProUGUI <textInput>k__BackingField;

	private Color activeTextColor;

	private Color inactiveTextColor;

	private Button button;

	private bool _interactable;

	private Action m_onClick;

	public TextMeshProUGUI textInput
	{
		get
		{
			return <textInput>k__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 32;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public bool interactable
	{
		get
		{
			return _interactable;
		}
		set
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_00f7: Expected O, but got I4
			//IL_00b4: Expected O, but got I4
			//IL_0195: Expected O, but got I4
			//IL_01c3: Expected O, but got I4
			//IL_0227: Expected O, but got I4
			//IL_01b5: Expected O, but got I4
			//IL_01df: Expected O, but got I4
			//IL_0249: Expected O, but got I4
			//IL_01d1: Expected O, but got I4
			//IL_01fb: Expected O, but got I4
			//IL_0270: Expected O, but got I
			//IL_0280: Expected O, but got I
			//IL_0290: Expected O, but got I
			//IL_029b: Expected O, but got I4
			//IL_01ed: Expected O, but got I4
			//IL_0217: Expected O, but got I4
			//IL_02c2: Expected O, but got I
			//IL_02ca: Expected I, but got O
			//IL_02da: Expected O, but got I
			//IL_02ea: Expected O, but got I
			//IL_0209: Expected O, but got I4
			object obj = 152989696;
			object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E73D7]");
			object obj3 = (nint)0 & (nint)1;
			UnityEngine.Object obj5;
			UnityEngine.Object obj6;
			if (obj3 != null)
			{
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v7+E4]");
				bool flag = (nint)0 == 0;
				obj5 = button;
				obj6 = button;
				if (!flag)
				{
					goto IL_0091;
				}
			}
			else
			{
				_ = 1;
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v7+E4]");
				bool flag2 = (nint)0 == 0;
				object obj7 = !flag2;
				obj5 = button;
				obj6 = button;
				if (obj7 != null)
				{
					goto IL_0091;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			if ((bool)obj6)
			{
				goto IL_014e;
			}
			goto IL_0162;
			IL_0162:
			_interactable = value;
			TextMeshProUGUI textMeshProUGUI = <textInput>k__BackingField;
			bool flag3 = !value;
			object obj8 = !flag3;
			object obj9 = ~obj8;
			if (obj9 == null)
			{
				object obj10 = 52;
			}
			else
			{
				object obj10 = 68;
			}
			object obj11 = !flag3;
			object obj12 = ~obj11;
			if (obj12 == null)
			{
				object obj13 = 48;
			}
			else
			{
				object obj13 = 64;
			}
			object obj14 = !flag3;
			object obj15 = ~obj14;
			if (obj15 == null)
			{
				object obj16 = 44;
			}
			else
			{
				object obj16 = 60;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (CustomButton)+v170 @ X8_v5]");
			object obj17 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (CustomButton)+v134 @ X9_v3]");
			object obj18 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (CustomButton)+v125 @ X10_v3]");
			object obj19 = 0;
			object obj20 = !flag3;
			object obj21 = ~obj20;
			if (obj21 == null)
			{
				object obj22 = 40;
			}
			else
			{
				object obj22 = 56;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (CustomButton)+v185 @ X8_v6]");
			object obj23 = 0;
			nint num = (nint)textMeshProUGUI;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ X8_v7 (Il2CppClass<TMPro.TextMeshProUGUI>)+2A8]");
			object obj24 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ X8_v7 (Il2CppClass<TMPro.TextMeshProUGUI>)+2B0]");
			object obj25 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v153 @ X2_v3 (should have been resolved before IL gen)");
			/*Error: End of method reached without returning.*/;
			IL_014e:
			button.interactable = value;
			goto IL_0162;
			IL_0091:
			bool flag4 = obj5;
			bool flag5 = !flag4;
			object obj26 = !flag5;
			if (obj26 != null)
			{
				goto IL_014e;
			}
			goto IL_0162;
		}
	}

	public event Action onClick
	{
		add
		{
			//IL_0098: Unknown result type (might be due to invalid IL or missing references)
			//IL_009d: Expected O, but got Unknown
			//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a8: Expected O, but got Unknown
			object obj = typeof(SqlSingle[]) + 2376;
			object obj2 = this + 88;
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
			object obj = typeof(SqlSingle[]) + 2376;
			object obj2 = this + 88;
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
		//IL_0259: Unknown result type (might be due to invalid IL or missing references)
		//IL_025e: Expected O, but got Unknown
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected O, but got Unknown
		//IL_0031: Expected O, but got I
		//IL_0049: Expected I, but got O
		//IL_0063: Expected O, but got I
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected O, but got Unknown
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Expected O, but got Unknown
		//IL_01d5: Expected O, but got I4
		//IL_01ef: Expected O, but got I
		//IL_0118: Expected O, but got I4
		//IL_0234: Expected O, but got I4
		//IL_0146: Expected O, but got I4
		//IL_0288: Expected O, but got I4
		//IL_0138: Expected O, but got I4
		//IL_0162: Expected O, but got I4
		//IL_02aa: Expected O, but got I4
		//IL_0154: Expected O, but got I4
		//IL_017e: Expected O, but got I4
		//IL_02d1: Expected O, but got I
		//IL_02e1: Expected O, but got I
		//IL_02f1: Expected O, but got I
		//IL_02fc: Expected O, but got I4
		//IL_0170: Expected O, but got I4
		//IL_019a: Expected O, but got I4
		//IL_0323: Expected O, but got I
		//IL_033b: Expected O, but got I
		//IL_034b: Expected O, but got I
		//IL_018c: Expected O, but got I4
		object obj = (nint)0 + (nint)3640;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
		object obj2 = this + 72;
		object obj3 = default(object);
		obj2 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj4 = obj2;
		object obj5 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
		object obj6 = (nint)0 + (nint)1560;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction = default(UnityAction);
		unityAction..ctor(this, (IntPtr)obj6);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X8_v3+100]");
		((UnityEvent)0).AddListener(unityAction);
		object obj7 = typeof(MemberAchievementClanFeedData) + 2976;
		button.interactable = _interactable;
		object obj8 = this + 32;
		object obj9 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X8_v5+E4]");
		if ((nint)0 != 0)
		{
			if ((bool)(UnityEngine.Object)obj8)
			{
				goto IL_00ef;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag = (UnityEngine.Object)obj8;
			bool flag2 = !flag;
			object obj10 = !flag2;
			if (obj10 != null)
			{
				goto IL_00ef;
			}
		}
		object obj11 = (nint)0 + (nint)288;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3120C");
		TextMeshProUGUI textMeshProUGUI = default(TextMeshProUGUI);
		<textInput>k__BackingField = textMeshProUGUI;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj12 = obj8;
		bool flag3 = obj8 == null;
		object obj13 = !flag3;
		if (obj13 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_00fc;
		IL_00ef:
		obj12 = obj8;
		goto IL_00fc;
		IL_00fc:
		bool flag4 = !_interactable;
		object obj14 = !flag4;
		object obj15 = ~obj14;
		if (obj15 == null)
		{
			object obj16 = 52;
		}
		else
		{
			object obj16 = 68;
		}
		object obj17 = !flag4;
		object obj18 = ~obj17;
		if (obj18 == null)
		{
			object obj19 = 48;
		}
		else
		{
			object obj19 = 64;
		}
		object obj20 = !flag4;
		object obj21 = ~obj20;
		if (obj21 == null)
		{
			object obj22 = 44;
		}
		else
		{
			object obj22 = 60;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (CustomButton)+v222 @ X8_v11]");
		object obj23 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (CustomButton)+v162 @ X9_v7]");
		object obj24 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (CustomButton)+v124 @ X10_v3]");
		object obj25 = 0;
		object obj26 = !flag4;
		object obj27 = ~obj26;
		if (obj27 == null)
		{
			object obj28 = 40;
		}
		else
		{
			object obj28 = 56;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (CustomButton)+v237 @ X8_v12]");
		object obj29 = 0;
		object obj30 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ X8_v13+2A8]");
		object obj31 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ X8_v13+2B0]");
		object obj32 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v158 @ X2_v5 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}

	private void OnButtonClicked()
	{
		Action action = this.onClick;
		if (this.onClick != null)
		{
			IntPtr invoke_impl = ((Delegate)action).invoke_impl;
			IntPtr method_code = ((Delegate)action).method_code;
			IntPtr method = ((Delegate)action).method;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v3 @ X2_v1 (System.IntPtr) (should have been resolved before IL gen)");
		}
	}

	private void OnInteractableStateChanged()
	{
		//IL_002b: Expected O, but got I4
		//IL_0059: Expected O, but got I4
		//IL_00bd: Expected O, but got I4
		//IL_004b: Expected O, but got I4
		//IL_0075: Expected O, but got I4
		//IL_00df: Expected O, but got I4
		//IL_0067: Expected O, but got I4
		//IL_0091: Expected O, but got I4
		//IL_0106: Expected O, but got I
		//IL_0116: Expected O, but got I
		//IL_0126: Expected O, but got I
		//IL_0131: Expected O, but got I4
		//IL_0083: Expected O, but got I4
		//IL_00ad: Expected O, but got I4
		//IL_0158: Expected O, but got I
		//IL_0160: Expected I, but got O
		//IL_0170: Expected O, but got I
		//IL_0180: Expected O, but got I
		//IL_009f: Expected O, but got I4
		TextMeshProUGUI textMeshProUGUI = <textInput>k__BackingField;
		bool flag = !_interactable;
		object obj = !flag;
		object obj2 = ~obj;
		if (obj2 == null)
		{
			object obj3 = 52;
		}
		else
		{
			object obj3 = 68;
		}
		object obj4 = !flag;
		object obj5 = ~obj4;
		if (obj5 == null)
		{
			object obj6 = 48;
		}
		else
		{
			object obj6 = 64;
		}
		object obj7 = !flag;
		object obj8 = ~obj7;
		if (obj8 == null)
		{
			object obj9 = 44;
		}
		else
		{
			object obj9 = 60;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (CustomButton)+v41 @ X9_v3]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (CustomButton)+v79 @ X10_v3]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (CustomButton)+v70 @ X11_v3]");
		object obj12 = 0;
		object obj13 = !flag;
		object obj14 = ~obj13;
		if (obj14 == null)
		{
			object obj15 = 40;
		}
		else
		{
			object obj15 = 56;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (CustomButton)+v98 @ X9_v4]");
		object obj16 = 0;
		nint num = (nint)textMeshProUGUI;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X8_v2 (Il2CppClass<TMPro.TextMeshProUGUI>)+2A8]");
		object obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X8_v2 (Il2CppClass<TMPro.TextMeshProUGUI>)+2B0]");
		object obj18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v49 @ X2_v1 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}
}
