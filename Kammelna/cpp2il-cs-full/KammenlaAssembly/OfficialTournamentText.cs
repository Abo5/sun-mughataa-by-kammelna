using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using Cpp2ILInjected;
using HuaweiMobileServices.Location.Location;
using Kammelna.Server;
using Mono.Btls;
using Server.Models;
using Sfs2X.Entities;
using TMPro;
using UnityEngine;

public class OfficialTournamentText : MonoBehaviour
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Func<Room, TournamentData> <>9__2_0;

		public static Func<TournamentData, bool> <>9__2_1;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 1472;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal TournamentData <Start>b__2_0(Room tour)
		{
			return SFSKammelnaRoomExtensions.GetTournamentInfo(tour);
		}

		internal bool <Start>b__2_1(TournamentData t)
		{
			//IL_0030: Expected O, but got I4
			if (t != null)
			{
				object obj = t.<Type>k__BackingField - 3;
				return obj == null;
			}
			return false;
		}
	}

	private TextMeshProUGUI aces1;

	private TextMeshProUGUI aces2;

	private void Start()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_00a0: Expected O, but got I
		//IL_00b0: Expected O, but got I
		//IL_00c0: Expected O, but got I
		//IL_00e2: Expected O, but got I4
		//IL_0025: Expected O, but got I
		//IL_0035: Expected O, but got I
		//IL_0045: Expected O, but got I
		//IL_0067: Expected O, but got I4
		//IL_024e: Expected O, but got I
		//IL_025e: Expected O, but got I
		//IL_026e: Expected O, but got I
		//IL_0290: Expected O, but got I4
		//IL_011a: Expected O, but got I4
		//IL_0219: Expected O, but got I4
		//IL_0199: Expected O, but got I
		//IL_01a9: Expected O, but got I
		//IL_01b9: Expected O, but got I
		//IL_0451: Unknown result type (might be due to invalid IL or missing references)
		//IL_0456: Expected O, but got Unknown
		//IL_046c: Expected O, but got I
		//IL_047d: Expected I, but got O
		//IL_049b: Expected O, but got I
		//IL_04b6: Expected O, but got I4
		//IL_0353: Unknown result type (might be due to invalid IL or missing references)
		//IL_0358: Expected O, but got Unknown
		//IL_0382: Expected O, but got I4
		//IL_02c8: Expected O, but got I4
		//IL_014a: Expected O, but got I
		//IL_04da: Unknown result type (might be due to invalid IL or missing references)
		//IL_04df: Expected O, but got Unknown
		//IL_04f5: Expected O, but got I
		//IL_0506: Expected I, but got O
		//IL_0524: Expected O, but got I
		//IL_032e: Expected O, but got I4
		//IL_02f8: Expected O, but got I
		object obj = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 1472;
		IEnumerable<Room> tournamentRooms = SFS.TournamentRooms;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X0_v44+E4]");
		object obj4;
		Func<object, object> selector;
		object obj6;
		object obj3;
		if ((nint)0 != 0)
		{
			obj3 = (nint)0 + (nint)3984;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X0_v44+B8]");
			obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X8_v34+8]");
			selector = (Func<object, object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X8_v34+8]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 == null)
			{
				obj6 = obj3;
				goto IL_00f8;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
			obj6 = (nint)0 + (nint)3984;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X0_v44+B8]");
			obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X8_v34+8]");
			selector = (Func<object, object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X8_v34+8]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj3 = obj6;
			if (obj7 == null)
			{
				goto IL_00f8;
			}
		}
		goto IL_014f;
		IL_01e6:
		object obj9;
		object obj8 = obj9;
		IEnumerable<object> source;
		Func<object, bool> func;
		object obj10 = Enumerable.FirstOrDefault(source, func);
		bool flag3 = obj10 == null;
		object obj11 = !flag3;
		Func<object, bool> func2 = func;
		if (obj11 == null)
		{
			return;
		}
		goto IL_0344;
		IL_0344:
		object obj12 = typeof(RegisteredWaitHandle) + 56;
		object obj13 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ X0_v10+E4]");
		bool flag4 = (nint)0 == 0;
		object obj14 = !flag4;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		RemoteConfigModel current = RemoteConfig.Current;
		int num = default(int);
		string text = num.ToString();
		aces1.text = text;
		RemoteConfigModel current2 = RemoteConfig.Current;
		string text2 = num.ToString();
		aces2.text = text2;
		return;
		IL_014f:
		source = Enumerable.Select(tournamentRooms, selector);
		object obj15 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X0_v27+E4]");
		object obj16;
		object obj17;
		if ((nint)0 != 0)
		{
			obj9 = (nint)0 + (nint)1328;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X0_v27+B8]");
			obj16 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ X8_v20+10]");
			func = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ X8_v20+10]");
			bool flag5 = (nint)0 == 0;
			obj17 = obj9;
			if (!flag5)
			{
				goto IL_01e6;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj15 = obj;
			obj9 = (nint)0 + (nint)1328;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X0_v27+B8]");
			obj16 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ X8_v20+10]");
			func = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ X8_v20+10]");
			bool flag6 = (nint)0 == 0;
			object obj18 = !flag6;
			obj17 = obj9;
			if (obj18 != null)
			{
				goto IL_01e6;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X0_v27+E4]");
		bool flag7 = (nint)0 == 0;
		object obj19 = !flag7;
		if (obj19 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj20 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v223 @ X8_v26+B8]");
			obj16 = 0;
		}
		object obj21 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3888;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj22 = (nint)0 + (nint)3904;
		Func<object, bool> func3 = default(Func<object, bool>);
		func3..ctor(obj16, (IntPtr)obj22);
		object obj23 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ X8_v25+B8]");
		object obj24 = (nint)0 + (nint)16;
		obj24 = func3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj8 = obj17;
		obj10 = Enumerable.FirstOrDefault(source, func3);
		bool flag8 = obj10 == null;
		object obj25 = 0;
		func2 = func3;
		if (flag8)
		{
			return;
		}
		goto IL_0344;
		IL_00f8:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X0_v44+E4]");
		bool flag9 = (nint)0 == 0;
		object obj26 = !flag9;
		if (obj26 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj27 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X8_v40+B8]");
			obj4 = 0;
		}
		object obj28 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3192;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj29 = (nint)0 + (nint)3896;
		Func<object, object> func4 = default(Func<object, object>);
		func4..ctor(obj4, (IntPtr)obj29);
		object obj30 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X8_v39+B8]");
		object obj31 = (nint)0 + (nint)8;
		obj31 = func4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj25 = 0;
		selector = func4;
		obj3 = obj6;
		goto IL_014f;
	}
}
