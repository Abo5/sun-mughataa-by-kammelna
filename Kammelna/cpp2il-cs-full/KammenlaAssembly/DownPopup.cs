using System;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using Kammelna.Server;
using TMPro;
using UnityEngine;

public class DownPopup : MonoBehaviour, IInitializable
{
	private PopupUI popup;

	private TextMeshProUGUI body;

	public void Initialize()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0198: Expected O, but got I4
		//IL_00a7: Expected O, but got I
		//IL_0230: Expected O, but got I4
		//IL_01d0: Expected O, but got I
		//IL_01ea: Expected O, but got I4
		//IL_0119: Expected O, but got I
		//IL_0129: Expected O, but got I
		//IL_014b: Expected O, but got I4
		//IL_0270: Expected O, but got I
		//IL_0280: Expected O, but got I
		//IL_02c3: Expected I, but got O
		//IL_02d3: Expected O, but got I
		//IL_02e3: Expected O, but got I
		object obj = 152989696;
		object obj2 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E76FA]");
		object obj3 = (nint)0 & (nint)1;
		TextMeshProUGUI textMeshProUGUI;
		TextMeshProUGUI textMeshProUGUI2;
		if (obj3 != null)
		{
			textMeshProUGUI = body;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v16+E4]");
			bool flag = (nint)0 == 0;
			textMeshProUGUI2 = body;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			textMeshProUGUI = body;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v16+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			textMeshProUGUI2 = body;
			if (obj5 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45C8]");
		object obj6 = (nint)0 & (nint)1;
		bool flag3 = obj6 == null;
		object obj7 = !flag3;
		textMeshProUGUI = textMeshProUGUI2;
		if (obj7 != null)
		{
			goto IL_00cc;
		}
		goto IL_0200;
		IL_02ed:
		throw new NullReferenceException();
		IL_028d:
		PlatformConfiguration platformConfiguration;
		string platformSpecificValue = platformConfiguration.PlatformSpecificValue;
		TextMeshProExtensions.FixArabic(textMeshProUGUI, platformSpecificValue);
		PopupUI popupUI = popup;
		nint num = (nint)popupUI;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X8_v4 (Il2CppClass<PopupUI>)+188]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X8_v4 (Il2CppClass<PopupUI>)+190]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v131 @ X2_v3 (should have been resolved before IL gen)");
		goto IL_02ed;
		IL_0109:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X0_v22+B8]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X8_v15+20]");
		platformConfiguration = (PlatformConfiguration)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X8_v15+20]");
		bool flag4 = (nint)0 == 0;
		object obj11 = !flag4;
		if (obj11 != null)
		{
			goto IL_028d;
		}
		goto IL_02ed;
		IL_0091:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45C8]");
		object obj12 = (nint)0 & (nint)1;
		bool flag5 = obj12 == null;
		textMeshProUGUI2 = textMeshProUGUI;
		if (!flag5)
		{
			goto IL_00cc;
		}
		goto IL_0200;
		IL_0200:
		_ = 1;
		object obj13 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X0_v22+E4]");
		bool flag6 = (nint)0 == 0;
		object obj14 = !flag6;
		textMeshProUGUI = textMeshProUGUI2;
		object obj15 = obj13;
		if (obj14 != null)
		{
			goto IL_0109;
		}
		goto IL_024e;
		IL_00cc:
		obj13 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X0_v22+E4]");
		bool flag7 = (nint)0 == 0;
		obj15 = obj13;
		textMeshProUGUI2 = textMeshProUGUI;
		if (!flag7)
		{
			goto IL_0109;
		}
		goto IL_024e;
		IL_024e:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj16 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X0_v9+B8]");
		object obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X8_v6+20]");
		platformConfiguration = (PlatformConfiguration)0;
		textMeshProUGUI = textMeshProUGUI2;
		goto IL_028d;
	}
}
