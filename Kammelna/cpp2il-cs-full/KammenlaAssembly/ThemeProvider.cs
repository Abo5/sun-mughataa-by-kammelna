using System;
using System.ComponentModel;
using System.Diagnostics;
using Cpp2ILInjected;
using UnityEngine;

public class ThemeProvider : MonoBehaviour
{
	private ThemeColorProfile serializedProfile;

	private IThemeColorProfile overrideProfile;

	private Action<IThemeColorProfile> m_OnThemeChanged;

	public IThemeColorProfile ActiveProfile
	{
		get
		{
			//IL_0030: Expected O, but got I4
			//IL_004d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0052: Expected O, but got Unknown
			//IL_011c: Expected O, but got I
			//IL_0136: Expected O, but got I4
			//IL_0095: Expected O, but got I
			//IL_01ac: Expected O, but got I
			//IL_0174: Expected O, but got I4
			//IL_00f7: Expected O, but got I
			IThemeColorProfile result = overrideProfile;
			object obj2;
			object obj7;
			object obj9;
			if (overrideProfile == null)
			{
				result = serializedProfile;
				bool flag = (object)serializedProfile == null;
				object obj = !flag;
				if (obj == null)
				{
					obj2 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2944;
					object obj3 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v4+E4]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45DF]");
						object obj4 = (nint)0 & (nint)1;
						if (obj4 != null)
						{
							goto IL_00b2;
						}
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45DF]");
						object obj5 = (nint)0 & (nint)1;
						bool flag2 = obj5 == null;
						object obj6 = !flag2;
						if (obj6 != null)
						{
							goto IL_00b2;
						}
					}
					_ = 1;
					obj7 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X0_v15+E4]");
					bool flag3 = (nint)0 == 0;
					object obj8 = !flag3;
					obj9 = obj7;
					if (obj8 != null)
					{
						goto IL_00e7;
					}
					goto IL_018a;
				}
			}
			return result;
			IL_018a:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj10 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X0_v7+B8]");
			return (IThemeColorProfile)0;
			IL_00b2:
			obj7 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X0_v15+E4]");
			bool flag4 = (nint)0 == 0;
			obj9 = obj7;
			if (!flag4)
			{
				goto IL_00e7;
			}
			goto IL_018a;
			IL_00e7:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X0_v15+B8]");
			return (IThemeColorProfile)0;
		}
	}

	public event Action<IThemeColorProfile> OnThemeChanged
	{
		add
		{
			//IL_0096: Unknown result type (might be due to invalid IL or missing references)
			//IL_009b: Expected O, but got Unknown
			//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a6: Expected O, but got Unknown
			//IL_000e: Expected O, but got I4
			//IL_0065: Expected O, but got I4
			object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2368;
			object obj2 = this + 48;
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
			object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2368;
			object obj2 = this + 48;
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

	public void UpdateTheme(IThemeColorProfile newProfile)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		object obj = this + 40;
		obj = newProfile;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		TriggerThemeUpdated();
	}

	private void TriggerThemeUpdated()
	{
		//IL_0009: Expected O, but got I4
		//IL_001f: Expected O, but got I
		//IL_0104: Expected O, but got I
		//IL_011e: Expected O, but got I4
		//IL_008f: Expected O, but got I
		//IL_005c: Expected O, but got I
		//IL_01ba: Expected O, but got I4
		//IL_0148: Expected O, but got I
		//IL_016e: Expected O, but got I4
		//IL_01e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ec: Expected O, but got Unknown
		//IL_02bf: Expected O, but got I
		//IL_02d9: Expected O, but got I4
		//IL_022f: Expected O, but got I
		//IL_0317: Expected O, but got I4
		//IL_0291: Expected O, but got I
		object obj = 152989696;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7B6B]");
		object obj2 = (nint)0 & (nint)1;
		Action<IThemeColorProfile> onThemeChanged;
		Action<IThemeColorProfile> onThemeChanged2;
		if (obj2 != null)
		{
			onThemeChanged = this.OnThemeChanged;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7B6A]");
			object obj3 = (nint)0 & (nint)1;
			bool flag = obj3 == null;
			onThemeChanged2 = this.OnThemeChanged;
			if (!flag)
			{
				goto IL_0083;
			}
		}
		else
		{
			_ = 1;
			onThemeChanged = this.OnThemeChanged;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7B6A]");
			object obj4 = (nint)0 & (nint)1;
			bool flag2 = obj4 == null;
			object obj5 = !flag2;
			onThemeChanged2 = this.OnThemeChanged;
			if (obj5 != null)
			{
				goto IL_0083;
			}
		}
		_ = 1;
		object obj6 = (nint)0 + (nint)2176;
		object arg = overrideProfile;
		bool flag3 = overrideProfile == null;
		object obj7 = !flag3;
		Action<object> action = (Action<object>)onThemeChanged2;
		object obj8 = obj6;
		Action<object> action2 = (Action<object>)onThemeChanged2;
		if (obj7 != null)
		{
			goto IL_00d0;
		}
		goto IL_0194;
		IL_032d:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj10;
		object obj9 = obj10;
		goto IL_0281;
		IL_0281:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ X0_v12+B8]");
		object arg2 = 0;
		Actions.SafeInvoke(action2, arg2);
		return;
		IL_00d0:
		Actions.SafeInvoke(action, arg);
		return;
		IL_0083:
		obj6 = (nint)0 + (nint)2176;
		arg = overrideProfile;
		bool flag4 = overrideProfile == null;
		action = (Action<object>)onThemeChanged;
		obj8 = obj6;
		action2 = (Action<object>)onThemeChanged;
		if (!flag4)
		{
			goto IL_00d0;
		}
		goto IL_0194;
		IL_0194:
		arg = serializedProfile;
		bool flag5 = (object)serializedProfile == null;
		object obj11 = !flag5;
		obj6 = obj8;
		action = action2;
		if (obj11 != null)
		{
			goto IL_00d0;
		}
		obj10 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2944;
		object obj12 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X0_v2+E4]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45DF]");
			object obj13 = (nint)0 & (nint)1;
			if (obj13 != null)
			{
				goto IL_024c;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45DF]");
			object obj14 = (nint)0 & (nint)1;
			bool flag6 = obj14 == null;
			object obj15 = !flag6;
			if (obj15 != null)
			{
				goto IL_024c;
			}
		}
		_ = 1;
		obj9 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ X0_v12+E4]");
		bool flag7 = (nint)0 == 0;
		object obj16 = !flag7;
		object obj17 = obj9;
		if (obj16 != null)
		{
			goto IL_0281;
		}
		goto IL_032d;
		IL_024c:
		obj9 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ X0_v12+E4]");
		bool flag8 = (nint)0 == 0;
		obj17 = obj9;
		if (!flag8)
		{
			goto IL_0281;
		}
		goto IL_032d;
	}
}
