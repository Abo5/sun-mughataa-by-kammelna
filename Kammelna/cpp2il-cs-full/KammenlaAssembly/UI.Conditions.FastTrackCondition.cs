using System;
using System.Collections.Generic;
using System.Runtime.Remoting.Messaging;
using System.Threading;
using Cpp2ILInjected;
using Kammelna.Server;
using Sfs2X.Entities;

namespace UI.Conditions;

[Serializable]
public class FastTrackCondition : BoolCondition
{
	protected override bool ActualValue
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_002a: Expected O, but got I
			//IL_0151: Expected O, but got I4
			//IL_008a: Expected O, but got I
			//IL_01d7: Expected O, but got I4
			//IL_017f: Expected O, but got I
			//IL_0199: Expected O, but got I4
			//IL_00ec: Expected O, but got I
			//IL_010e: Expected O, but got I4
			//IL_0256: Expected O, but got I4
			//IL_020f: Expected O, but got I
			//IL_02d0: Unknown result type (might be due to invalid IL or missing references)
			//IL_02d5: Expected O, but got Unknown
			//IL_02e1: Expected O, but got I
			//IL_030b: Expected O, but got I4
			//IL_0617: Expected I4, but got O
			//IL_0373: Expected I4, but got O
			//IL_03ab: Expected O, but got I4
			//IL_0428: Unknown result type (might be due to invalid IL or missing references)
			//IL_042d: Expected O, but got Unknown
			//IL_0435: Expected I, but got O
			//IL_0445: Expected O, but got I
			//IL_04db: Expected O, but got I
			//IL_0480: Expected O, but got I
			//IL_0528: Expected O, but got I4
			//IL_05a6: Unknown result type (might be due to invalid IL or missing references)
			//IL_05ab: Expected O, but got Unknown
			//IL_05b3: Unknown result type (might be due to invalid IL or missing references)
			//IL_05b8: Expected O, but got Unknown
			//IL_05c1: Unknown result type (might be due to invalid IL or missing references)
			//IL_05c6: Expected O, but got Unknown
			//IL_05d6: Expected O, but got I
			//IL_05f6: Expected O, but got I4
			//IL_048e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0493: Expected O, but got Unknown
			//IL_049c: Unknown result type (might be due to invalid IL or missing references)
			//IL_04a1: Expected O, but got Unknown
			object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7DED]");
			object obj2 = (nint)0 & (nint)1;
			if (obj2 != null)
			{
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v44+E4]");
				if ((nint)0 != 0)
				{
					goto IL_0074;
				}
			}
			else
			{
				_ = 1;
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v44+E4]");
				bool flag = (nint)0 == 0;
				object obj4 = !flag;
				if (obj4 != null)
				{
					goto IL_0074;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45C7]");
			object obj5 = (nint)0 & (nint)1;
			bool flag2 = obj5 == null;
			object obj6 = !flag2;
			if (obj6 != null)
			{
				goto IL_00a7;
			}
			goto IL_01a7;
			IL_02c1:
			object obj7 = typeof(Queue<string>) + 848;
			object obj8 = (nint)0 + (nint)2200;
			object obj9 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X0_v4+E4]");
			bool flag3 = (nint)0 == 0;
			object obj10 = !flag3;
			if (obj10 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			SessionModel sessionModel = default(SessionModel);
			bool flag5;
			object obj19;
			if ((object)sessionModel != null)
			{
				Room currentRoom = sessionModel.CurrentRoom;
				bool flag4 = currentRoom == null;
				flag5 = (byte)(int)currentRoom != 0;
				if (flag4)
				{
					goto IL_0604;
				}
				object obj11 = obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v260 @ X0_v10+E4]");
				bool flag6 = (nint)0 == 0;
				object obj12 = !flag6;
				if (obj12 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
				SessionModel sessionModel2 = default(SessionModel);
				if ((object)sessionModel2 != null)
				{
					Room currentRoom2 = sessionModel2.CurrentRoom;
					if (currentRoom2 != null)
					{
						object obj13 = typeof(RegisteredWaitHandle) + 1376;
						nint num = (nint)currentRoom2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v304 @ X8_v9 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
						object obj14 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v304 @ X8_v9 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
						if ((nint)0 == 0)
						{
							goto IL_04c1;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v304 @ X8_v9 (Il2CppClass<Sfs2X.Entities.Room>)+B0]");
						object obj15 = (nint)0 + (nint)8;
						while (true)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v284 @ X10_v7-8]");
							if (0 == (nint)obj13)
							{
								break;
							}
							obj15 += 16;
							obj14--;
							if ((nint)obj14 != 1)
							{
								continue;
							}
							goto IL_04c1;
						}
						object obj16 = obj15 + 6;
						object obj17 = num + obj16;
						object obj18 = obj17 + 312;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v296 @ X8_v14+8]");
						obj19 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v296 @ X8_v14] (should have been resolved before IL gen)");
						bool flag7 = !flag5;
						object obj20 = !flag7;
						if (obj20 != null)
						{
							goto IL_04fe;
						}
						goto IL_0604;
					}
				}
			}
			goto IL_0609;
			IL_0609:
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
			IL_04fe:
			object obj21 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v342 @ X0_v16+E4]");
			bool flag8 = (nint)0 == 0;
			object obj22 = !flag8;
			if (obj22 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			SessionModel sessionModel3 = default(SessionModel);
			if ((object)sessionModel3 != null)
			{
				Room currentRoom3 = sessionModel3.CurrentRoom;
				GameType gameType = SFSKammelnaRoomExtensions.GetGameType(currentRoom3);
				return GameTypeExtensions.IsFastTrack(gameType);
			}
			goto IL_0609;
			IL_0074:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45C7]");
			object obj23 = (nint)0 & (nint)1;
			if (obj23 != null)
			{
				goto IL_00a7;
			}
			goto IL_01a7;
			IL_01a7:
			_ = 1;
			object obj24 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X0_v30+E4]");
			bool flag9 = (nint)0 == 0;
			object obj25 = !flag9;
			object obj26 = obj24;
			if (obj25 != null)
			{
				goto IL_00dc;
			}
			goto IL_01ed;
			IL_00a7:
			obj24 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X0_v30+E4]");
			bool flag10 = (nint)0 == 0;
			obj26 = obj24;
			if (!flag10)
			{
				goto IL_00dc;
			}
			goto IL_01ed;
			IL_01ed:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj24 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X0_v30+B8]");
			object obj27 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X8_v19+8]");
			if ((nint)0 != 0)
			{
				goto IL_0234;
			}
			goto IL_02c1;
			IL_00dc:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X0_v30+B8]");
			object obj28 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X8_v29+8]");
			bool flag11 = (nint)0 == 0;
			object obj29 = !flag11;
			if (obj29 != null)
			{
				goto IL_0234;
			}
			goto IL_02c1;
			IL_0234:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X0_v30+E4]");
			bool flag12 = (nint)0 == 0;
			object obj30 = !flag12;
			if (obj30 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			SFSConfig currentSFS = Config.CurrentSFS;
			if (currentSFS != null)
			{
				if (currentSFS.<IsFastTrack>k__BackingField)
				{
					return true;
				}
				goto IL_02c1;
			}
			goto IL_0609;
			IL_0604:
			return flag5;
			IL_04c1:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v321 @ X0_v24+8]");
			obj19 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v321 @ X0_v24] (should have been resolved before IL gen)");
			if (flag5)
			{
				goto IL_04fe;
			}
			goto IL_0604;
		}
	}

	public FastTrackCondition()
	{
		isActive = true;
		((object)this)..ctor();
	}
}
