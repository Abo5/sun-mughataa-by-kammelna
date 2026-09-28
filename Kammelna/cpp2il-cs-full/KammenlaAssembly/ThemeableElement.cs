using System;
using System.Diagnostics;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using UnityEngine;

public abstract class ThemeableElement : MonoBehaviour
{
	private ThemeProvider <currentThemeProvider>k__BackingField;

	protected ThemeProvider currentThemeProvider
	{
		get
		{
			return <currentThemeProvider>k__BackingField;
		}
		private set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 32;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	protected abstract void OnThemeUpdated(IThemeColorProfile colorProfile);

	private void OnEnable()
	{
		TryRefreshTheme();
	}

	private void Start()
	{
		TryRefreshTheme();
	}

	private void OnTransformParentChanged()
	{
		TryRefreshTheme();
	}

	private void OnDestroy()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_014e: Expected O, but got I4
		//IL_00b3: Expected O, but got I4
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Expected O, but got Unknown
		//IL_00e9: Expected I, but got O
		//IL_0199: Expected O, but got I4
		//IL_01a2: Expected O, but got I4
		object obj = 152989696;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7A3F]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj6;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			obj5 = <currentThemeProvider>k__BackingField;
			obj6 = <currentThemeProvider>k__BackingField;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			obj5 = <currentThemeProvider>k__BackingField;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v2+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj6 = <currentThemeProvider>k__BackingField;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = obj6 != null;
		bool flag4 = !flag3;
		object obj8 = !flag4;
		object obj9 = 0;
		UnityEngine.Object obj10 = null;
		if (obj8 == null)
		{
			return;
		}
		goto IL_00c6;
		IL_00c6:
		object obj11 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2368;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		nint num = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X8_v9 (Il2CppClass<ThemeableElement>)+180]");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)0);
		<currentThemeProvider>k__BackingField.OnThemeChanged -= action;
		return;
		IL_0091:
		bool flag5 = obj5 != null;
		bool flag6 = !flag5;
		obj9 = 0;
		obj10 = null;
		if (!flag6)
		{
			goto IL_00c6;
		}
	}

	private void TryRefreshTheme()
	{
		//IL_000c: Expected O, but got I
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		//IL_0096: Expected O, but got I4
		//IL_009f: Expected O, but got I4
		//IL_004b: Expected O, but got I4
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Expected O, but got Unknown
		//IL_016d: Expected O, but got I4
		//IL_0111: Expected O, but got I4
		//IL_011b: Expected O, but got I4
		//IL_022f: Expected O, but got I4
		//IL_023d: Expected O, but got I4
		//IL_01d4: Expected O, but got I4
		//IL_01dd: Expected O, but got I4
		//IL_02c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ce: Expected O, but got Unknown
		//IL_025a: Unknown result type (might be due to invalid IL or missing references)
		//IL_025f: Expected O, but got Unknown
		//IL_026e: Expected I, but got O
		//IL_02e2: Expected I, but got O
		//IL_02a1: Expected O, but got I4
		//IL_01f9: Expected O, but got I4
		object obj = (nint)0 + (nint)544;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D31634");
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v4+E4]");
		UnityEngine.Object obj4 = default(UnityEngine.Object);
		if ((nint)0 != 0)
		{
			bool flag = obj4 == null;
			bool flag2 = !flag;
			object obj5 = 0;
			UnityEngine.Object obj6 = null;
			if (!flag2)
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag3 = obj4 == null;
			bool flag4 = !flag3;
			object obj7 = !flag4;
			object obj5 = 0;
			UnityEngine.Object obj6 = null;
			if (obj7 != null)
			{
				return;
			}
		}
		object obj8 = this + 32;
		object obj9 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X0_v6+E4]");
		if ((nint)0 != 0)
		{
			bool flag5 = obj4 != (UnityEngine.Object)obj8;
			bool flag6 = !flag5;
			object obj10 = !flag6;
			object obj11 = 0;
			UnityEngine.Object obj12 = (UnityEngine.Object)obj8;
			if (obj10 == null)
			{
				goto IL_0131;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag7 = obj4 != (UnityEngine.Object)obj8;
			bool flag8 = !flag7;
			object obj11 = 0;
			UnityEngine.Object obj12 = (UnityEngine.Object)obj8;
			if (flag8)
			{
				goto IL_0131;
			}
		}
		object obj13 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ X0_v8+E4]");
		object obj17;
		if ((nint)0 != 0)
		{
			bool flag9 = (UnityEngine.Object)obj8 != null;
			bool flag10 = !flag9;
			object obj14 = !flag10;
			object obj15 = 0;
			UnityEngine.Object obj16 = null;
			if (obj14 != null)
			{
				goto IL_024b;
			}
			obj17 = 0;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag11 = (UnityEngine.Object)obj8 != null;
			bool flag12 = !flag11;
			object obj15 = 0;
			UnityEngine.Object obj16 = null;
			obj17 = 0;
			if (!flag12)
			{
				goto IL_024b;
			}
		}
		goto IL_02a6;
		IL_02a6:
		<currentThemeProvider>k__BackingField = (ThemeProvider)obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj18 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2368;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		nint num = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X8_v10 (Il2CppClass<ThemeableElement>)+180]");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)0);
		<currentThemeProvider>k__BackingField.OnThemeChanged += action;
		UpdateTheme();
		return;
		IL_0131:
		UpdateTheme();
		return;
		IL_024b:
		object obj19 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2368;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		nint num2 = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ X8_v13 (Il2CppClass<ThemeableElement>)+180]");
		Action<object> action2 = default(Action<object>);
		action2..ctor((object)this, (IntPtr)0);
		<currentThemeProvider>k__BackingField.OnThemeChanged -= action2;
		obj17 = 0;
		goto IL_02a6;
	}

	protected void UpdateTheme()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00f8: Expected O, but got I4
		//IL_00b5: Expected O, but got I4
		//IL_0190: Expected I, but got O
		//IL_01a0: Expected O, but got I
		//IL_01b0: Expected O, but got I
		object obj = 152989696;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7A41]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj6;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v10+E4]");
			bool flag = (nint)0 == 0;
			obj5 = <currentThemeProvider>k__BackingField;
			obj6 = <currentThemeProvider>k__BackingField;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v10+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj5 = <currentThemeProvider>k__BackingField;
			obj6 = <currentThemeProvider>k__BackingField;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		if (obj6 != null)
		{
			goto IL_0150;
		}
		return;
		IL_0150:
		IThemeColorProfile activeProfile = <currentThemeProvider>k__BackingField.ActiveProfile;
		if (activeProfile != null)
		{
			IThemeColorProfile activeProfile2 = <currentThemeProvider>k__BackingField.ActiveProfile;
			nint num = (nint)this;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X8_v4 (Il2CppClass<ThemeableElement>)+178]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X8_v4 (Il2CppClass<ThemeableElement>)+180]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v104 @ X3_v1 (should have been resolved before IL gen)");
		}
		return;
		IL_0091:
		bool flag3 = obj5 != null;
		bool flag4 = !flag3;
		object obj10 = !flag4;
		if (obj10 == null)
		{
			return;
		}
		goto IL_0150;
	}
}
