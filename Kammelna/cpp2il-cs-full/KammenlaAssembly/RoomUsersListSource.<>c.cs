using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading;
using Cpp2ILInjected;
using Kammelna.Server;
using Microsoft.Extensions.DependencyInjection.ServiceLookup;
using Sfs2X.Entities;
using UnityEngine.InputSystem.XR;

public class RoomUsersListSource : IUsersListSource
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Func<User, PlayerInfo> <>9__0_0;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(RankedPlayManager.<>c__DisplayClass36_0) + 2144;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal PlayerInfo <GetUsersList>b__0_0(User user)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(System.Buffers.Text.ParserHelpers) + 936;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			PlayerInfo playerInfo = default(PlayerInfo);
			playerInfo..ctor(user);
			return playerInfo;
		}
	}

	public void GetUsersList(Action<UsersListModel> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0741: Expected O, but got I4
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected O, but got Unknown
		//IL_006a: Expected O, but got I
		//IL_0099: Expected O, but got I4
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Expected O, but got Unknown
		//IL_00f3: Expected I, but got O
		//IL_0103: Expected O, but got I
		//IL_01c1: Expected O, but got I4
		//IL_013e: Expected O, but got I
		//IL_023e: Expected I, but got O
		//IL_024e: Expected O, but got I
		//IL_01e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01eb: Expected O, but got Unknown
		//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f8: Expected O, but got Unknown
		//IL_0201: Unknown result type (might be due to invalid IL or missing references)
		//IL_0206: Expected O, but got Unknown
		//IL_02f8: Expected O, but got I4
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Expected O, but got Unknown
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_015f: Expected O, but got Unknown
		//IL_0289: Expected O, but got I
		//IL_0389: Unknown result type (might be due to invalid IL or missing references)
		//IL_038e: Expected O, but got Unknown
		//IL_0396: Expected I, but got O
		//IL_03a6: Expected O, but got I
		//IL_031d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0322: Expected O, but got Unknown
		//IL_032a: Unknown result type (might be due to invalid IL or missing references)
		//IL_032f: Expected O, but got Unknown
		//IL_0338: Unknown result type (might be due to invalid IL or missing references)
		//IL_033d: Expected O, but got Unknown
		//IL_043c: Expected O, but got I
		//IL_0297: Unknown result type (might be due to invalid IL or missing references)
		//IL_029c: Expected O, but got Unknown
		//IL_02a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02aa: Expected O, but got Unknown
		//IL_05df: Expected O, but got I
		//IL_05ef: Expected O, but got I
		//IL_05ff: Expected O, but got I
		//IL_0621: Expected O, but got I4
		//IL_0641: Expected O, but got I
		//IL_03e1: Expected O, but got I
		//IL_07d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_07da: Expected O, but got Unknown
		//IL_04a9: Expected O, but got I
		//IL_04b9: Expected O, but got I
		//IL_04c9: Expected O, but got I
		//IL_04eb: Expected O, but got I4
		//IL_06d3: Expected O, but got I
		//IL_06e3: Expected O, but got I
		//IL_06f3: Expected O, but got I
		//IL_0671: Expected O, but got I4
		//IL_052f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0534: Expected O, but got Unknown
		//IL_053c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0541: Expected O, but got Unknown
		//IL_054a: Unknown result type (might be due to invalid IL or missing references)
		//IL_054f: Expected O, but got Unknown
		//IL_055f: Expected O, but got I
		//IL_0593: Expected O, but got I4
		//IL_0800: Unknown result type (might be due to invalid IL or missing references)
		//IL_0805: Expected O, but got Unknown
		//IL_081b: Expected O, but got I
		//IL_082c: Expected I, but got O
		//IL_084a: Expected O, but got I
		//IL_0521: Expected O, but got I
		//IL_03ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f4: Expected O, but got Unknown
		//IL_03fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0402: Expected O, but got Unknown
		//IL_06a1: Expected O, but got I
		object obj = typeof(UsageHint) + 168;
		object obj2 = typeof(DataRelation) + 712;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj3 = default(object);
		obj3..ctor();
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		DateTime now = DateTime.Now;
		object obj6 = typeof(Queue<string>) + 848;
		object obj7 = (nint)0 + (nint)2200;
		object obj8 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X0_v10+E4]");
		bool flag2 = (nint)0 == 0;
		object obj9 = !flag2;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel = default(SessionModel);
		Room currentRoom = sessionModel.CurrentRoom;
		object obj10 = typeof(RegisteredWaitHandle) + 1376;
		nint num = (nint)currentRoom;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v321 @ X8_v8 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v321 @ X8_v8 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_017f;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v321 @ X8_v8 (Il2CppClass<Sfs2X.Entities.Room>)+B0]");
		object obj12 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v196 @ X10_v21-8]");
			if (0 == (nint)obj10)
			{
				break;
			}
			obj12 += 16;
			obj11--;
			if ((nint)obj11 != 1)
			{
				continue;
			}
			goto IL_017f;
		}
		object obj13 = obj12 + 14;
		object obj14 = num + obj13;
		object obj15 = obj14 + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v256 @ X8_v38] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		goto IL_0224;
		IL_049d:
		object obj16 = (nint)0 + (nint)176;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v566 @ X0_v28+B8]");
		object obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v575 @ X8_v16+8]");
		Func<object, object> selector = (Func<object, object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v575 @ X8_v16+8]");
		bool flag3 = (nint)0 == 0;
		object obj18 = !flag3;
		IEnumerable<object> enumerable;
		IEnumerable<object> enumerable2;
		nint num3 = default(nint);
		object obj19;
		Func<object, object> func;
		nint num2;
		if (obj18 == null)
		{
			enumerable = enumerable2;
			num2 = num3;
			obj19 = obj16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v575 @ X8_v16+8]");
			func = (Func<object, object>)0;
			goto IL_064f;
		}
		goto IL_07bb;
		IL_05c1:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj21;
		object obj20 = obj21;
		obj19 = (nint)0 + (nint)176;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v566 @ X0_v28+B8]");
		obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v575 @ X8_v16+8]");
		func = (Func<object, object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v575 @ X8_v16+8]");
		bool flag4 = (nint)0 == 0;
		object obj22 = !flag4;
		enumerable2 = enumerable;
		obj16 = obj19;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v575 @ X8_v16+8]");
		selector = (Func<object, object>)0;
		if (obj22 == null)
		{
			goto IL_064f;
		}
		goto IL_07bb;
		IL_07bb:
		IEnumerable<object> enumerable3 = Enumerable.Select(enumerable2, selector);
		object obj23 = obj3 + 32;
		obj23 = enumerable3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [callback @ X1 (System.Action`1<UsersListModel>)+18]");
		object obj24 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [callback @ X1 (System.Action`1<UsersListModel>)+40]");
		object obj25 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [callback @ X1 (System.Action`1<UsersListModel>)+28]");
		object obj26 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v280 @ X3_v3 (should have been resolved before IL gen)");
		goto IL_06fd;
		IL_06fd:
		throw new NullReferenceException();
		IL_02ca:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v381 @ X0_v46] (should have been resolved before IL gen)");
		object obj27 = default(object);
		bool flag5 = obj27 == null;
		object obj28 = !flag5;
		num3 = 29;
		if (obj28 != null)
		{
			goto IL_034c;
		}
		goto IL_06fd;
		IL_034c:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v399 @ X0_v17+18]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel2 = default(SessionModel);
		Room currentRoom2 = sessionModel2.CurrentRoom;
		obj21 = typeof(RankedPlayManager.<>c__DisplayClass36_0) + 2144;
		nint num4 = (nint)currentRoom2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v405 @ X8_v13 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
		object obj29 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v405 @ X8_v13 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0422;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v405 @ X8_v13 (Il2CppClass<Sfs2X.Entities.Room>)+B0]");
		object obj30 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v447 @ X10_v11-8]");
			if (0 == (nint)obj10)
			{
				break;
			}
			obj30 += 16;
			obj29--;
			if ((nint)obj29 != 1)
			{
				continue;
			}
			goto IL_0422;
		}
		object obj31 = obj30 + 28;
		object obj32 = num4 + obj31;
		object obj33 = obj32 + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v471 @ X8_v31+8]");
		object obj34 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v471 @ X8_v31] (should have been resolved before IL gen)");
		obj20 = obj21;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v566 @ X0_v28+E4]");
		bool flag6 = (nint)0 == 0;
		object obj35 = !flag6;
		IEnumerable<object> enumerable4 = default(IEnumerable<object>);
		enumerable2 = enumerable4;
		enumerable = enumerable4;
		num2 = num3;
		object obj36 = obj20;
		if (obj35 != null)
		{
			goto IL_049d;
		}
		goto IL_05c1;
		IL_0422:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v436 @ X0_v40+8]");
		obj34 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v436 @ X0_v40] (should have been resolved before IL gen)");
		obj20 = obj21;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v566 @ X0_v28+E4]");
		bool flag7 = (nint)0 == 0;
		IEnumerable<object> enumerable5 = default(IEnumerable<object>);
		enumerable2 = enumerable5;
		num3 = 28;
		enumerable = enumerable5;
		num2 = 28;
		obj36 = obj20;
		if (!flag7)
		{
			goto IL_049d;
		}
		goto IL_05c1;
		IL_064f:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v566 @ X0_v28+E4]");
		bool flag8 = (nint)0 == 0;
		object obj37 = !flag8;
		if (obj37 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj38 = obj21;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v581 @ X8_v22+B8]");
			obj17 = 0;
		}
		object obj39 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 64;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj40 = (nint)0 + (nint)920;
		Func<object, object> func2 = default(Func<object, object>);
		func2..ctor(obj17, (IntPtr)obj40);
		object obj41 = obj21;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v556 @ X8_v21+B8]");
		object obj42 = (nint)0 + (nint)8;
		obj42 = func2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		enumerable2 = enumerable;
		obj16 = obj19;
		selector = func2;
		goto IL_07bb;
		IL_017f:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v338 @ X0_v50] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel3 = default(SessionModel);
		bool flag9 = (object)sessionModel3 == null;
		object obj43 = !flag9;
		num3 = 14;
		if (obj43 != null)
		{
			goto IL_0224;
		}
		goto IL_06fd;
		IL_0224:
		Room currentRoom3 = sessionModel3.CurrentRoom;
		nint num5 = (nint)currentRoom3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v364 @ X8_v10 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
		object obj44 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v364 @ X8_v10 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_02ca;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v364 @ X8_v10 (Il2CppClass<Sfs2X.Entities.Room>)+B0]");
		object obj45 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ X10_v16-8]");
			if (0 == (nint)obj10)
			{
				break;
			}
			obj45 += 16;
			obj44--;
			if ((nint)obj44 != 1)
			{
				continue;
			}
			goto IL_02ca;
		}
		object obj46 = obj45 + 29;
		object obj47 = num5 + obj46;
		object obj48 = obj47 + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v259 @ X8_v35] (should have been resolved before IL gen)");
		goto IL_034c;
	}
}
