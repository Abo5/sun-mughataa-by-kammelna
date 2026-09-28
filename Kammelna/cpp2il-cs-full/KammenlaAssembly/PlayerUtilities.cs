using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Threading;
using Cpp2ILInjected;
using Kammelna.Server;
using Kammelna.Server.Models.Clans;
using Sfs2X.Entities;
using UnityEngine;
using UnityEngine.InputSystem.XR;

public static class PlayerUtilities
{
	public static bool IsPlayer()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00fb: Expected O, but got I
		//IL_0125: Expected O, but got I4
		//IL_005c: Expected O, but got I
		//IL_018a: Expected I4, but got O
		//IL_016e: Expected O, but got I4
		object obj = 152985600;
		object obj2 = typeof(Queue<string>) + 848;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6FCF]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = (nint)0 + (nint)2200;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj6 = obj4;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			object obj4 = (nint)0 + (nint)2200;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v3+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			object obj6 = obj4;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel = default(SessionModel);
		bool flag3 = (object)sessionModel == null;
		object obj8 = !flag3;
		if (obj8 != null)
		{
			goto IL_00b8;
		}
		goto IL_017c;
		IL_00b8:
		User localUser = sessionModel.LocalUser;
		string dbId = SFSKammelnaUserExtensions.GetDbId(localUser);
		return IsPlayer(dbId);
		IL_017c:
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
		IL_0091:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		if ((object)sessionModel != null)
		{
			goto IL_00b8;
		}
		goto IL_017c;
	}

	public static bool IsPlayer(string dbId)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00da: Expected O, but got I
		//IL_0104: Expected O, but got I4
		//IL_00b5: Expected O, but got I4
		//IL_005c: Expected O, but got I
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		//IL_018e: Expected O, but got Unknown
		//IL_060f: Expected I4, but got O
		//IL_0220: Expected O, but got I4
		//IL_023d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0242: Expected O, but got Unknown
		//IL_024a: Expected I, but got O
		//IL_025a: Expected O, but got I
		//IL_02f0: Expected O, but got I
		//IL_0314: Expected O, but got I4
		//IL_03a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ab: Expected O, but got Unknown
		//IL_03d5: Expected O, but got I4
		//IL_0295: Expected O, but got I
		//IL_03fe: Expected O, but got I
		//IL_0435: Expected O, but got I4
		//IL_0338: Unknown result type (might be due to invalid IL or missing references)
		//IL_033d: Expected O, but got Unknown
		//IL_0345: Unknown result type (might be due to invalid IL or missing references)
		//IL_034a: Expected O, but got Unknown
		//IL_0353: Unknown result type (might be due to invalid IL or missing references)
		//IL_0358: Expected O, but got Unknown
		//IL_0368: Expected O, but got I
		//IL_02a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a8: Expected O, but got Unknown
		//IL_02b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b6: Expected O, but got Unknown
		//IL_044b: Expected I, but got O
		//IL_045b: Expected O, but got I
		//IL_0505: Expected O, but got I4
		//IL_0496: Expected O, but got I
		//IL_0521: Unknown result type (might be due to invalid IL or missing references)
		//IL_0526: Expected O, but got Unknown
		//IL_052e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0533: Expected O, but got Unknown
		//IL_053c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0541: Expected O, but got Unknown
		//IL_04a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a9: Expected O, but got Unknown
		//IL_04b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b7: Expected O, but got Unknown
		//IL_05bb: Expected O, but got I
		//IL_05e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ec: Expected O, but got Unknown
		object obj = 152985600;
		object obj2 = typeof(Queue<string>) + 848;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6FD0]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = (nint)0 + (nint)2200;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v40+E4]");
			bool flag = (nint)0 == 0;
			object obj6 = obj4;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			object obj4 = (nint)0 + (nint)2200;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v40+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			object obj6 = obj4;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel = default(SessionModel);
		if ((object)sessionModel != null)
		{
			goto IL_0150;
		}
		goto IL_0601;
		IL_0568:
		UnityEngine.Object obj8 = default(UnityEngine.Object);
		if ((object)obj8 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v372 @ X0_v13 (UnityEngine.Object)+40]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v372 @ X0_v13 (UnityEngine.Object)+40]");
				if (((GamePhase)0).IsGameStarted)
				{
					object obj9 = typeof(UsageHint) + 8;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C9DB58");
					bool result = default(bool);
					return result;
				}
				goto IL_05fb;
			}
		}
		goto IL_0601;
		IL_0601:
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
		IL_04d7:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v393 @ X0_v21] (should have been resolved before IL gen)");
		object obj10 = default(object);
		bool flag3 = obj10 == null;
		object obj11 = !flag3;
		if (obj11 != null)
		{
			goto IL_0568;
		}
		goto IL_05fb;
		IL_0091:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		bool flag4 = (object)sessionModel == null;
		object obj12 = !flag4;
		if (obj12 != null)
		{
			goto IL_0150;
		}
		goto IL_0601;
		IL_0150:
		Room currentRoom = sessionModel.CurrentRoom;
		if (currentRoom != null)
		{
			object obj13 = typeof(System.Formats.Asn1.SetOfValueComparer) + 2536;
			object obj14 = obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X0_v7+E4]");
			if ((nint)0 != 0)
			{
				if (!StringsExtensions.IsNullOrEmpty(dbId))
				{
					goto IL_022e;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				bool flag5 = StringsExtensions.IsNullOrEmpty(dbId);
				bool flag6 = !flag5;
				object obj15 = !flag6;
				if (obj15 == null)
				{
					goto IL_022e;
				}
			}
		}
		goto IL_05fb;
		IL_05fb:
		return false;
		IL_0397:
		object obj16 = typeof(MemberAchievementClanFeedData) + 2976;
		object obj17 = obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v364 @ X0_v10+E4]");
		bool flag7 = (nint)0 == 0;
		object obj18 = !flag7;
		if (obj18 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj19 = (nint)0 + (nint)136;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE90D8");
		bool flag8 = obj8 == null;
		bool flag9 = !flag8;
		object obj20 = !flag9;
		object obj23;
		if (obj20 == null)
		{
			nint num = (nint)currentRoom;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v376 @ X8_v15 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
			object obj21 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v376 @ X8_v15 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_04d7;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v376 @ X8_v15 (Il2CppClass<Sfs2X.Entities.Room>)+B0]");
			object obj22 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ X10_v8-8]");
				if (0 == (nint)obj23)
				{
					break;
				}
				obj22 += 16;
				obj21--;
				if ((nint)obj21 != 1)
				{
					continue;
				}
				goto IL_04d7;
			}
			object obj24 = obj22 + 6;
			object obj25 = num + obj24;
			object obj26 = obj25 + 312;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v410 @ X0_v24] (should have been resolved before IL gen)");
			object obj27 = default(object);
			if (obj27 != null)
			{
				goto IL_0568;
			}
		}
		goto IL_05fb;
		IL_02d6:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v338 @ X0_v29+8]");
		object obj28 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v338 @ X0_v29] (should have been resolved before IL gen)");
		object obj29 = default(object);
		bool flag10 = obj29 == null;
		object obj30 = !flag10;
		string text = dbId;
		if (obj30 != null)
		{
			goto IL_0397;
		}
		goto IL_05fb;
		IL_022e:
		obj23 = typeof(RegisteredWaitHandle) + 1376;
		nint num2 = (nint)currentRoom;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X8_v8 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
		object obj31 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X8_v8 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_02d6;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X8_v8 (Il2CppClass<Sfs2X.Entities.Room>)+B0]");
		object obj32 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ X10_v13-8]");
			if (0 == (nint)obj23)
			{
				break;
			}
			obj32 += 16;
			obj31--;
			if ((nint)obj31 != 1)
			{
				continue;
			}
			goto IL_02d6;
		}
		object obj33 = obj32 + 26;
		object obj34 = num2 + obj33;
		object obj35 = obj34 + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v355 @ X0_v32+8]");
		obj28 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v355 @ X0_v32] (should have been resolved before IL gen)");
		bool flag11 = obj29 == null;
		text = dbId;
		if (!flag11)
		{
			goto IL_0397;
		}
		goto IL_05fb;
	}

	public static int GetPlayerTeamID(string playerName)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00da: Expected O, but got I
		//IL_0104: Expected O, but got I4
		//IL_00b5: Expected O, but got I4
		//IL_005c: Expected O, but got I
		//IL_02e7: Expected I4, but got O
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		//IL_018e: Expected O, but got Unknown
		//IL_0196: Expected I, but got O
		//IL_01a6: Expected O, but got I
		//IL_024d: Expected O, but got I4
		//IL_01e1: Expected O, but got I
		//IL_027a: Unknown result type (might be due to invalid IL or missing references)
		//IL_027f: Expected O, but got Unknown
		//IL_0287: Unknown result type (might be due to invalid IL or missing references)
		//IL_028c: Expected O, but got Unknown
		//IL_0295: Unknown result type (might be due to invalid IL or missing references)
		//IL_029a: Expected O, but got Unknown
		//IL_02be: Expected O, but got I4
		//IL_02c6: Expected O, but got I4
		//IL_01ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f4: Expected O, but got Unknown
		//IL_01fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0202: Expected O, but got Unknown
		object obj = 152985600;
		object obj2 = typeof(Queue<string>) + 848;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6FD1]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = (nint)0 + (nint)2200;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v16+E4]");
			bool flag = (nint)0 == 0;
			object obj6 = obj4;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			object obj4 = (nint)0 + (nint)2200;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v16+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			object obj6 = obj4;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel = default(SessionModel);
		if ((object)sessionModel != null)
		{
			goto IL_0150;
		}
		goto IL_02d9;
		IL_025b:
		Room currentRoom;
		User user;
		return SFSKammelnaRoomExtensions.GetPlayerTeamIndex(currentRoom, user);
		IL_02d4:
		int num = default(int);
		return num;
		IL_0222:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v203 @ X0_v10] (should have been resolved before IL gen)");
		bool flag3 = num == 0;
		user = (User)num;
		if (!flag3)
		{
			goto IL_025b;
		}
		goto IL_02d4;
		IL_0091:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		bool flag4 = (object)sessionModel == null;
		object obj8 = !flag4;
		if (obj8 != null)
		{
			goto IL_0150;
		}
		goto IL_02d9;
		IL_0150:
		currentRoom = sessionModel.CurrentRoom;
		if (currentRoom != null)
		{
			object obj9 = typeof(RegisteredWaitHandle) + 1376;
			nint num2 = (nint)currentRoom;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X8_v6 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X8_v6 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0222;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X8_v6 (Il2CppClass<Sfs2X.Entities.Room>)+B0]");
			object obj11 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ X10_v6-8]");
				if (0 == (nint)obj9)
				{
					break;
				}
				obj11 += 16;
				obj10--;
				if ((nint)obj10 != 1)
				{
					continue;
				}
				goto IL_0222;
			}
			object obj12 = obj11 + 26;
			object obj13 = num2 + obj12;
			object obj14 = obj13 + 312;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v235 @ X0_v13] (should have been resolved before IL gen)");
			bool flag5 = num == 0;
			object obj15 = !flag5;
			user = (User)num;
			if (obj15 != null)
			{
				goto IL_025b;
			}
			goto IL_02d4;
		}
		goto IL_02d9;
		IL_02d9:
		NullReferenceException ex = new NullReferenceException();
		return (int)ex;
	}
}
