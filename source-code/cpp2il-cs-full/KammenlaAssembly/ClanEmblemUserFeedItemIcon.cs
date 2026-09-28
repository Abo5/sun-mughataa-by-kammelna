using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using Server.Models;
using UnityEngine.TextCore;

public class ClanEmblemUserFeedItemIcon : UserFeedItemIcon
{
	private ClanEmblemLoader emblemLoader;

	public override void Populate(UserFeedItem feedItem, Action onReady)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected O, but got Unknown
		//IL_0060: Expected O, but got I
		//IL_008a: Expected O, but got I4
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected O, but got Unknown
		//IL_00c7: Expected O, but got I
		//IL_00e9: Expected O, but got I
		//IL_0207: Expected I, but got O
		//IL_0124: Expected O, but got I
		//IL_018f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0194: Expected O, but got Unknown
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Expected O, but got Unknown
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Expected O, but got Unknown
		object obj = typeof(UnityEngine.TextCore.HorizontalAlignment) + 1528;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
		object obj2 = default(object);
		if (obj2 == null)
		{
			goto IL_01b7;
		}
		object obj3 = typeof(Queue<string>) + 728;
		object obj4 = (nint)0 + (nint)1976;
		object obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X0_v8+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj7 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1552;
		object obj8 = (nint)0 + (nint)936;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		object obj9 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ X8_v8+12E]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ X8_v8+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0165;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ X8_v8+B0]");
		object obj11 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v254 @ X10_v7-8]");
			if (0 == (nint)obj)
			{
				break;
			}
			obj11 += 16;
			obj10--;
			if ((nint)obj10 != 1)
			{
				continue;
			}
			goto IL_0165;
		}
		object obj12 = obj9 + obj11;
		object obj13 = obj12 + 312;
		Action action = onReady;
		goto IL_01e5;
		IL_01b7:
		Actions.SafeInvoke(onReady);
		return;
		IL_01e5:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v270 @ X0_v12] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action2 = default(Action<object>);
		action2..ctor((object)this, (IntPtr)obj8);
		ClanServerConnector clanServerConnector = default(ClanServerConnector);
		int id = default(int);
		clanServerConnector.GetClan(id, action2);
		goto IL_01b7;
		IL_0165:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		action = null;
		goto IL_01e5;
	}

	private void <Populate>b__1_0(ClanModel model)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00d8: Expected O, but got I4
		//IL_0116: Expected O, but got I4
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6324]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v2+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag2 = this != null;
		bool flag3 = !flag2;
		object obj5 = !flag3;
		if (obj5 == null)
		{
			return;
		}
		goto IL_0098;
		IL_0098:
		emblemLoader.Load(model);
		return;
		IL_0074:
		if (this != null)
		{
			goto IL_0098;
		}
	}
}
