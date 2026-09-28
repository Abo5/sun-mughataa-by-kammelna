using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using Cpp2ILInjected;
using Kammelna.Server;
using Sfs2X.Entities;

namespace UI.Conditions;

[Serializable]
public class ActiveTitleCondition : BoolCondition
{
	public override string Name => "HH:mm:ss.ffZ" + 856;

	protected override bool ActualValue
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_00da: Expected O, but got I
			//IL_0104: Expected O, but got I4
			//IL_00b5: Expected O, but got I4
			//IL_005c: Expected O, but got I
			//IL_017c: Expected I4, but got O
			//IL_01b4: Expected O, but got I4
			//IL_0346: Expected I4, but got O
			//IL_0202: Unknown result type (might be due to invalid IL or missing references)
			//IL_0207: Expected O, but got Unknown
			//IL_027a: Expected O, but got I4
			//IL_02ec: Unknown result type (might be due to invalid IL or missing references)
			//IL_02f1: Expected O, but got Unknown
			//IL_031b: Expected O, but got I4
			object obj = 152989696;
			object obj2 = typeof(Queue<string>) + 848;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7DDA]");
			object obj3 = (nint)0 & (nint)1;
			object obj6;
			object obj4;
			if (obj3 != null)
			{
				obj4 = (nint)0 + (nint)2200;
				object obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v27+E4]");
				bool flag = (nint)0 == 0;
				obj6 = obj4;
				if (!flag)
				{
					goto IL_0091;
				}
			}
			else
			{
				_ = 1;
				obj4 = (nint)0 + (nint)2200;
				object obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v27+E4]");
				bool flag2 = (nint)0 == 0;
				object obj7 = !flag2;
				obj6 = obj4;
				if (obj7 != null)
				{
					goto IL_0091;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			SessionModel sessionModel = default(SessionModel);
			bool flag3 = (object)sessionModel == null;
			obj4 = obj6;
			if (!flag3)
			{
				goto IL_0158;
			}
			goto IL_0338;
			IL_0338:
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
			IL_0158:
			User localUser = sessionModel.LocalUser;
			bool flag4 = localUser == null;
			bool flag5 = (byte)(int)localUser != 0;
			if (!flag4)
			{
				object obj8 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X0_v6+E4]");
				bool flag6 = (nint)0 == 0;
				object obj9 = !flag6;
				if (obj9 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
				SessionModel sessionModel2 = default(SessionModel);
				if ((object)sessionModel2 == null)
				{
					goto IL_0338;
				}
				object obj10 = "Material with texture name \"" + 3544;
				User localUser2 = sessionModel2.LocalUser;
				string title = SFSKammelnaUserExtensions.GetTitle(localUser2);
				flag5 = title != (string)obj10;
				if (flag5)
				{
					object obj11 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X0_v13+E4]");
					bool flag7 = (nint)0 == 0;
					object obj12 = !flag7;
					if (obj12 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
					SessionModel sessionModel3 = default(SessionModel);
					if ((object)sessionModel3 == null)
					{
						goto IL_0338;
					}
					User localUser3 = sessionModel3.LocalUser;
					string title2 = SFSKammelnaUserExtensions.GetTitle(localUser3);
					object obj13 = typeof(System.Formats.Asn1.SetOfValueComparer) + 2536;
					object obj14 = obj13;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X8_v9+E4]");
					bool flag8 = (nint)0 == 0;
					object obj15 = !flag8;
					if (obj15 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool flag9 = StringsExtensions.IsNullOrEmpty(title2);
					flag5 = (byte)((flag9 ? 1u : 0u) ^ 1u) != 0;
				}
			}
			return flag5;
			IL_0091:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			bool flag10 = (object)sessionModel == null;
			object obj16 = !flag10;
			if (obj16 != null)
			{
				goto IL_0158;
			}
			goto IL_0338;
		}
	}

	public ActiveTitleCondition()
	{
		isActive = true;
		((object)this)..ctor();
	}
}
