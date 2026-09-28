using System;
using System.Threading;
using Cpp2ILInjected;
using Server.Models;
using TMPro;
using UnityEngine;

public class SwitchGiftToEidiah : MonoBehaviour
{
	private bool IsEid
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_002a: Expected O, but got I
			//IL_00da: Expected O, but got I4
			//IL_0097: Expected O, but got I4
			//IL_0164: Expected I4, but got O
			object obj = typeof(RegisteredWaitHandle) + 56;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E89E2]");
			object obj2 = (nint)0 & (nint)1;
			if (obj2 != null)
			{
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v5+E4]");
				if ((nint)0 != 0)
				{
					goto IL_0074;
				}
			}
			else
			{
				_ = 1;
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v5+E4]");
				bool flag = (nint)0 == 0;
				object obj4 = !flag;
				if (obj4 != null)
				{
					goto IL_0074;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			RemoteConfigModel current = RemoteConfig.Current;
			if (current != null)
			{
				goto IL_011d;
			}
			goto IL_0156;
			IL_0156:
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
			IL_011d:
			VisualsConfig <Visuals>k__BackingField = current.<Visuals>k__BackingField;
			if (current.<Visuals>k__BackingField != null)
			{
				return <Visuals>k__BackingField.<IsEid>k__BackingField;
			}
			goto IL_0156;
			IL_0074:
			current = RemoteConfig.Current;
			bool flag2 = current == null;
			object obj5 = !flag2;
			if (obj5 != null)
			{
				goto IL_011d;
			}
			goto IL_0156;
		}
	}

	private void Start()
	{
		//IL_0016: Expected O, but got I
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Expected O, but got Unknown
		//IL_0115: Expected O, but got I
		//IL_012f: Expected O, but got I4
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_005d: Expected O, but got I
		//IL_0175: Expected O, but got I4
		//IL_00d2: Expected O, but got I4
		//IL_01de: Expected O, but got I
		//IL_01f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f7: Expected O, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E89E3]");
		object obj = (nint)0 & (nint)1;
		object obj2;
		object obj4;
		if (obj != null)
		{
			obj2 = typeof(RegisteredWaitHandle) + 56;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E89E2]");
			object obj3 = (nint)0 & (nint)1;
			bool flag = obj3 == null;
			obj4 = obj2;
			if (!flag)
			{
				goto IL_0082;
			}
		}
		else
		{
			_ = 1;
			obj2 = typeof(RegisteredWaitHandle) + 56;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E89E2]");
			object obj5 = (nint)0 & (nint)1;
			bool flag2 = obj5 == null;
			object obj6 = !flag2;
			obj4 = obj2;
			if (obj6 != null)
			{
				goto IL_0082;
			}
		}
		_ = 1;
		object obj7 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X0_v6+E4]");
		bool flag3 = (nint)0 == 0;
		object obj8 = !flag3;
		if (obj8 != null)
		{
			goto IL_00af;
		}
		goto IL_0183;
		IL_019b:
		RemoteConfigModel current;
		VisualsConfig <Visuals>k__BackingField = current.<Visuals>k__BackingField;
		if (<Visuals>k__BackingField.<IsEid>k__BackingField)
		{
			object obj9 = (nint)0 + (nint)152;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
			object text = "Drop Menu Toggle" + 1960;
			TextMeshProUGUI textMesh = default(TextMeshProUGUI);
			TextMeshProExtensions.Localize(textMesh, (string)text);
		}
		return;
		IL_00af:
		current = RemoteConfig.Current;
		bool flag4 = current == null;
		object obj10 = !flag4;
		if (obj10 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_019b;
		IL_0183:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		current = RemoteConfig.Current;
		goto IL_019b;
		IL_0082:
		obj7 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X0_v6+E4]");
		if ((nint)0 != 0)
		{
			goto IL_00af;
		}
		goto IL_0183;
	}
}
