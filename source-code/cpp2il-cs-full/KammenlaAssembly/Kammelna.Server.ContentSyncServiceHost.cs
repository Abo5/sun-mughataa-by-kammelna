using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using UnityEngine;

namespace Kammelna.Server;

public class ContentSyncServiceHost : MonoBehaviour
{
	private void Awake()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_021d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0222: Expected O, but got Unknown
		//IL_0139: Expected O, but got I4
		//IL_0142: Expected O, but got I4
		//IL_014b: Expected O, but got I4
		//IL_004a: Expected O, but got I4
		//IL_0053: Expected O, but got I4
		//IL_0077: Expected O, but got I
		//IL_0179: Expected O, but got I
		//IL_0193: Expected O, but got I4
		//IL_01d9: Expected O, but got I4
		//IL_00e7: Expected O, but got I
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		object obj2 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2872;
		GameObject target = base.gameObject;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v3+E4]");
		object obj6;
		object obj5;
		if ((nint)0 != 0)
		{
			Object.DontDestroyOnLoad(target);
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X0_v12+E4]");
			bool flag = (nint)0 == 0;
			obj5 = 0;
			obj6 = 0;
			if (!flag)
			{
				goto IL_0061;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Object.DontDestroyOnLoad(target);
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X0_v12+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj5 = 0;
			obj6 = 0;
			if (obj7 != null)
			{
				goto IL_0061;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45F1]");
		object obj8 = (nint)0 & (nint)1;
		bool flag3 = obj8 == null;
		object obj9 = !flag3;
		obj5 = obj6;
		if (obj9 != null)
		{
			goto IL_009c;
		}
		goto IL_01a9;
		IL_00d1:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X0_v18+B8]");
		object obj10 = (nint)0 + (nint)8;
		obj10 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		return;
		IL_01f7:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj11 = obj2;
		goto IL_00d1;
		IL_009c:
		obj11 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X0_v18+E4]");
		bool flag4 = (nint)0 == 0;
		object obj12 = obj11;
		if (!flag4)
		{
			goto IL_00d1;
		}
		goto IL_01f7;
		IL_0061:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45F1]");
		object obj13 = (nint)0 & (nint)1;
		bool flag5 = obj13 == null;
		obj6 = obj5;
		if (!flag5)
		{
			goto IL_009c;
		}
		goto IL_01a9;
		IL_01a9:
		_ = 1;
		obj11 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X0_v18+E4]");
		bool flag6 = (nint)0 == 0;
		object obj14 = !flag6;
		obj5 = obj6;
		obj12 = obj11;
		if (obj14 != null)
		{
			goto IL_00d1;
		}
		goto IL_01f7;
	}
}
