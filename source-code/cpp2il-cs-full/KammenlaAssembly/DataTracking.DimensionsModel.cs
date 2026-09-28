using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Data.SqlTypes;
using Cpp2ILInjected;
using Kammelna.Server;
using Mono.Btls;

namespace DataTracking;

public class DimensionsModel
{
	public readonly string[] DimensionArray;

	public unsafe DimensionsModel()
	{
		//IL_000c: Expected O, but got I
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		//IL_0399: Expected O, but got I
		//IL_03d1: Expected O, but got I4
		//IL_042e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0433: Expected O, but got Unknown
		//IL_0442: Unknown result type (might be due to invalid IL or missing references)
		//IL_0447: Expected O, but got Unknown
		//IL_047c: Expected O, but got I4
		//IL_00af: Expected O, but got I4
		//IL_025f: Expected O, but got Ref
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Expected O, but got Unknown
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Expected O, but got Unknown
		//IL_028e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0293: Expected O, but got Unknown
		//IL_014f: Expected O, but got I4
		//IL_02b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b8: Expected O, but got Unknown
		//IL_02ec: Expected O, but got I4
		//IL_0302: Expected O, but got I
		//IL_0322: Unknown result type (might be due to invalid IL or missing references)
		//IL_0327: Expected O, but got Unknown
		//IL_0411: Expected O, but got I4
		//IL_033e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0343: Expected O, but got Unknown
		//IL_035b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0360: Expected O, but got Unknown
		//IL_0201: Unknown result type (might be due to invalid IL or missing references)
		//IL_0206: Expected O, but got Unknown
		object obj = (nint)0 + (nint)2000;
		object obj2 = typeof(Queue<string>) + 848;
		object obj3 = (nint)0 + (nint)2200;
		base..ctor();
		string text = (string)obj;
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel = default(SessionModel);
		string text2;
		if ((object)sessionModel != null)
		{
			if (sessionModel.LocalUser == null)
			{
				text2 = text;
				goto IL_041f;
			}
			object obj6 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ X0_v31+E4]");
			if ((object)((nint)0 != 0) == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			SessionModel sessionModel2 = default(SessionModel);
			if ((object)sessionModel2 != null)
			{
				object obj7 = "SubscribeGroup request Error" + 8;
				object obj8 = "Network Authentication Required" + 1496;
				text2 = (string)((~(object)SFSKammelnaUserExtensions.IsSubscribed(sessionModel2.LocalUser) != null) ? obj8 : obj7);
				object obj9 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v308 @ X0_v37+E4]");
				bool flag2 = (nint)0 == 0;
				object obj10 = !flag2;
				if (obj10 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
				SessionModel sessionModel3 = default(SessionModel);
				if ((object)sessionModel3 != null && SFSKammelnaUserExtensions.GetRank(sessionModel3.LocalUser) != null)
				{
					object obj11 = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 2624;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
					Enum enumeration = default(Enum);
					text = EnumExtensions.GetFriendlyName(enumeration);
					goto IL_041f;
				}
			}
		}
		goto IL_0378;
		IL_0386:
		throw new IndexOutOfRangeException();
		IL_041f:
		object obj12 = typeof(SqlSingle[]) + 32;
		object obj13 = typeof(System.Buffers.Text.ParserHelpers) + 1624;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		object obj14 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v289 @ X0_v15+E4]");
		bool flag3 = (nint)0 == 0;
		object obj15 = !flag3;
		if (obj15 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Games currentGame = Preferences.CurrentGame;
		PlayerRank.Ranks ranks = default(PlayerRank.Ranks);
		string text3 = ((Enum)(&ranks)).ToString();
		object obj16 = default(object);
		if (obj16 == null)
		{
			goto IL_0378;
		}
		object obj17 = obj16 + 32;
		obj17 = text3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj18 = obj16 + 40;
		obj18 = text2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ X23_v10-10]");
		object obj19 = (nint)0 >= (nint)2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ X23_v10-10]");
		if ((object)(~obj19 | ((object)(-2) == null)) == null)
		{
			object obj20 = obj16 + 48;
			obj20 = text;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj21 = this + 16;
			obj21 = obj16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			return;
		}
		goto IL_0386;
		IL_0378:
		NullReferenceException ex = new NullReferenceException();
		goto IL_0386;
	}

	public unsafe DimensionsModel(Games activeGame, bool isSubscribed, PlayerRank playerRank)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0205: Expected O, but got Ref
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_0079: Expected O, but got I8
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected O, but got Unknown
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Expected O, but got Unknown
		//IL_00ce: Expected O, but got I4
		//IL_0217: Unknown result type (might be due to invalid IL or missing references)
		//IL_021c: Expected O, but got Unknown
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Expected O, but got Unknown
		//IL_014a: Expected O, but got I4
		//IL_0160: Expected O, but got I
		//IL_0180: Unknown result type (might be due to invalid IL or missing references)
		//IL_0185: Expected O, but got Unknown
		//IL_019c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a1: Expected O, but got Unknown
		//IL_01be: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c3: Expected O, but got Unknown
		object obj = typeof(SqlSingle[]) + 32;
		base..ctor();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		PlayerRank.Ranks ranks = default(PlayerRank.Ranks);
		string text = ((Enum)(&ranks)).ToString();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v4+18]");
		if ((nint)0 != 0)
		{
			object obj3 = default(object);
			object obj2 = obj3 + 32;
			obj2 = text;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ X23_v5-8]");
			if ((object)(0 & 0xFFFFFFFEL) != null)
			{
				object obj4 = "SubscribeGroup request Error" + 8;
				object obj5 = "Network Authentication Required" + 1496;
				if (~(object)isSubscribed != null)
				{
					obj4 = obj5;
				}
				object obj6 = obj3 + 40;
				obj6 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				object obj7 = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 2624;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
				Enum enumeration = default(Enum);
				string friendlyName = EnumExtensions.GetFriendlyName(enumeration);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v4+18]");
				object obj8 = (nint)0 >= (nint)2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v4+18]");
				if ((object)(~obj8 | ((object)(-2) == null)) == null)
				{
					object obj9 = obj3 + 48;
					obj9 = friendlyName;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					object obj10 = this + 16;
					obj10 = obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					return;
				}
			}
		}
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		throw new NullReferenceException();
	}
}
