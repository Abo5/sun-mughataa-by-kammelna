using System;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Threading;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using Sfs2X.Entities;
using Sfs2X.Entities.Data;
using Unity.Properties;
using UnityEngine;

public class GameReplayUiControl : MonoBehaviour
{
	private GameEventsChannel _gameEventsChannel;

	private KGame _game;

	public void Awake()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_008b: Expected O, but got I
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected O, but got Unknown
		//IL_00ab: Expected O, but got I
		//IL_00d5: Expected O, but got I4
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_006c: Expected I, but got O
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		object obj2 = (nint)0 + (nint)136;
		object obj3 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2360;
		object obj4 = (nint)0 + (nint)2360;
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE90D8");
		object obj7 = this + 40;
		object obj8 = default(object);
		obj7 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj4);
		((KGame)obj7).OnGameEnd += action;
	}

	private void ShowEndReplay(ISFSObject _)
	{
		//IL_0a3c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a41: Expected O, but got Unknown
		//IL_0a49: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a4e: Expected O, but got Unknown
		//IL_0a57: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a5c: Expected O, but got Unknown
		//IL_0a74: Expected O, but got I
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected I, but got Unknown
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Expected O, but got Unknown
		//IL_00d5: Expected I, but got O
		//IL_00e5: Expected O, but got I
		//IL_0183: Expected O, but got I
		//IL_01a7: Expected O, but got I4
		//IL_0120: Expected O, but got I
		//IL_0258: Expected I, but got O
		//IL_0268: Expected O, but got I
		//IL_0291: Expected O, but got I
		//IL_01d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d9: Expected O, but got Unknown
		//IL_01e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e6: Expected O, but got Unknown
		//IL_01ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f4: Expected I, but got Unknown
		//IL_0204: Expected O, but got I
		//IL_02c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cc: Expected O, but got Unknown
		//IL_02e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ed: Expected I, but got Unknown
		//IL_02fa: Expected O, but got I
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Expected O, but got Unknown
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Expected O, but got Unknown
		//IL_0337: Unknown result type (might be due to invalid IL or missing references)
		//IL_033c: Expected O, but got Unknown
		//IL_0344: Expected I, but got O
		//IL_0354: Expected O, but got I
		//IL_03ea: Expected I, but got O
		//IL_040e: Expected O, but got I4
		//IL_0498: Unknown result type (might be due to invalid IL or missing references)
		//IL_049d: Expected O, but got Unknown
		//IL_04a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ac: Expected O, but got Unknown
		//IL_04c4: Expected O, but got I
		//IL_038f: Expected O, but got I
		//IL_0b4e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b53: Expected O, but got Unknown
		//IL_0b69: Expected O, but got I
		//IL_0b77: Expected I, but got O
		//IL_0b81: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b86: Expected I, but got Unknown
		//IL_0b98: Expected O, but got I
		//IL_04ff: Expected O, but got I
		//IL_0432: Unknown result type (might be due to invalid IL or missing references)
		//IL_0437: Expected O, but got Unknown
		//IL_043f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0444: Expected O, but got Unknown
		//IL_044d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0452: Expected O, but got Unknown
		//IL_045a: Expected I, but got O
		//IL_059f: Expected O, but got I4
		//IL_039d: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a2: Expected O, but got Unknown
		//IL_03ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b0: Expected O, but got Unknown
		//IL_0575: Unknown result type (might be due to invalid IL or missing references)
		//IL_057a: Expected O, but got Unknown
		//IL_05c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c9: Expected O, but got Unknown
		//IL_05e1: Expected O, but got I
		//IL_050d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0512: Expected O, but got Unknown
		//IL_051b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0520: Expected O, but got Unknown
		//IL_0be5: Expected O, but got I
		//IL_0bf3: Expected I, but got O
		//IL_0bfd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c02: Expected I, but got Unknown
		//IL_0c14: Expected O, but got I
		//IL_061c: Expected O, but got I
		//IL_06b4: Expected O, but got I4
		//IL_068a: Unknown result type (might be due to invalid IL or missing references)
		//IL_068f: Expected O, but got Unknown
		//IL_06e2: Expected O, but got I
		//IL_062a: Unknown result type (might be due to invalid IL or missing references)
		//IL_062f: Expected O, but got Unknown
		//IL_0638: Unknown result type (might be due to invalid IL or missing references)
		//IL_063d: Expected O, but got Unknown
		//IL_0778: Expected I, but got O
		//IL_079c: Expected O, but got I4
		//IL_0833: Expected O, but got I
		//IL_071d: Expected O, but got I
		//IL_08e3: Expected O, but got I4
		//IL_07b3: Expected O, but got I4
		//IL_086e: Expected O, but got I
		//IL_07d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_07db: Expected O, but got Unknown
		//IL_07e3: Expected I, but got O
		//IL_080d: Expected O, but got I4
		//IL_0909: Expected I, but got O
		//IL_0919: Expected O, but got I
		//IL_072b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0730: Expected O, but got Unknown
		//IL_0739: Unknown result type (might be due to invalid IL or missing references)
		//IL_073e: Expected O, but got Unknown
		//IL_09b7: Expected O, but got I
		//IL_09ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_09cf: Expected O, but got Unknown
		//IL_09e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ea: Expected I, but got Unknown
		//IL_0a0e: Expected O, but got I4
		//IL_0a17: Expected O, but got I4
		//IL_0954: Expected O, but got I
		//IL_087c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0881: Expected O, but got Unknown
		//IL_088a: Unknown result type (might be due to invalid IL or missing references)
		//IL_088f: Expected O, but got Unknown
		//IL_0c84: Expected O, but got I4
		//IL_0962: Unknown result type (might be due to invalid IL or missing references)
		//IL_0967: Expected O, but got Unknown
		//IL_0970: Unknown result type (might be due to invalid IL or missing references)
		//IL_0975: Expected O, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8A52]");
		nint num = 0;
		IPopupWindowBuilderNeedsTitle popupWindowBuilderNeedsTitle;
		object obj3;
		object obj4 = default(object);
		object obj7 = default(object);
		object[] array = default(object[]);
		if ((object)_game != null)
		{
			if (!_game.IsReplay)
			{
				return;
			}
			popupWindowBuilderNeedsTitle = PopupWindowBuilder.Create(PopupWindow.MessageType.Action);
			num = (nint)(typeof(TypeConverter<ushort, char>) + 3400);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
			if ((object)_game != null)
			{
				Room room = _game.Room;
				if (room != null)
				{
					object obj = typeof(RegisteredWaitHandle) + 1376;
					nint num2 = (nint)room;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v447 @ X8_v11 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
					object obj2 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v447 @ X8_v11 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
					if ((nint)0 == 0)
					{
						goto IL_0169;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v447 @ X8_v11 (Il2CppClass<Sfs2X.Entities.Room>)+B0]");
					obj3 = (nint)0 + (nint)8;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ X10_v14-8]");
						if (0 == (nint)obj)
						{
							break;
						}
						obj4 = obj3 + 16;
						obj2--;
						bool flag = (nint)obj2 != 1;
						obj3 = obj4;
						if (flag)
						{
							continue;
						}
						goto IL_0169;
					}
					object obj5 = obj3 + 1;
					object obj6 = num2 + obj5;
					num = (nint)(obj6 + 312);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v338 @ X8_v3 (Il2CppClass<System.NullReferenceException>)+8]");
					obj7 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v338 @ X8_v3 (Il2CppClass<System.NullReferenceException>)] (should have been resolved before IL gen)");
					bool flag2 = array == null;
					obj4 = obj3;
					if (!flag2)
					{
						goto IL_0233;
					}
				}
			}
		}
		goto IL_0a25;
		IL_03d8:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		object obj8 = default(object);
		num = (nint)obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v538 @ X0_v59] (should have been resolved before IL gen)");
		object obj9 = default(object);
		bool flag3 = obj9 == null;
		object obj10 = !flag3;
		if (obj10 != null)
		{
			goto IL_0489;
		}
		obj4 = obj3;
		goto IL_0a25;
		IL_0489:
		object obj11 = typeof(System.IOAsyncCallback) + 384;
		object obj12 = "DNQUALIFIER" + 3640;
		object obj13 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v580 @ X8_v26+12E]");
		object obj14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v580 @ X8_v26+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0548;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v580 @ X8_v26+B0]");
		object obj15 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v622 @ X10_v32-8]");
			if (0 == (nint)obj11)
			{
				break;
			}
			obj3 = obj15 + 16;
			obj14--;
			bool flag4 = (nint)obj14 != 1;
			obj15 = obj3;
			if (flag4)
			{
				continue;
			}
			goto IL_0548;
		}
		object obj16 = obj13 + obj15;
		object obj17 = obj16 + 312;
		obj3 = obj15;
		goto IL_0b35;
		IL_0a7e:
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		object obj18 = obj7;
		goto IL_0a94;
		IL_08b7:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v807 @ X0_v42 (Il2CppClass<System.NullReferenceException>)] (should have been resolved before IL gen)");
		NullReferenceException ex2 = default(NullReferenceException);
		bool flag5 = ex2 == null;
		object obj19 = 0;
		obj4 = obj3;
		IntPtr intPtr = default(IntPtr);
		num = intPtr;
		if (!flag5)
		{
			goto IL_0901;
		}
		goto IL_0a25;
		IL_0901:
		num = (nint)ex2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v338 @ X8_v3 (Il2CppClass<System.NullReferenceException>)+12E]");
		object obj20 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v338 @ X8_v3 (Il2CppClass<System.NullReferenceException>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0995;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v338 @ X8_v3 (Il2CppClass<System.NullReferenceException>)+B0]");
		obj4 = (nint)0 + (nint)8;
		object obj21;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ X10_v39-8]");
			bool flag6 = 0 == (nint)obj21;
			obj19 = 0;
			if (flag6)
			{
				break;
			}
			obj4 += 16;
			obj20--;
			if ((nint)obj20 != 1)
			{
				continue;
			}
			goto IL_0995;
		}
		goto IL_0a33;
		IL_0b35:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v643 @ X8_v27] (should have been resolved before IL gen)");
		object obj22 = typeof(SqlSingle[]) + 2376;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj23 = (nint)0 + (nint)2352;
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj23);
		num = (nint)("Unsupported map type" + 3680);
		PopupButton popupButton = PopupButton.Positive((string)num, action, dismiss: true);
		object obj24 = default(object);
		bool flag7 = obj24 == null;
		obj19 = 0;
		obj4 = obj3;
		if (flag7)
		{
			goto IL_0a25;
		}
		obj21 = typeof(System.IOAsyncCallback) + 368;
		object obj25 = obj24;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v660 @ X8_v32+12E]");
		object obj26 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v660 @ X8_v32+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0665;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v660 @ X8_v32+B0]");
		object obj27 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v702 @ X10_v27-8]");
			if (0 == (nint)obj21)
			{
				break;
			}
			obj3 = obj27 + 16;
			obj26--;
			bool flag8 = (nint)obj26 != 1;
			obj27 = obj3;
			if (flag8)
			{
				continue;
			}
			goto IL_0665;
		}
		object obj28 = obj25 + obj27;
		object obj29 = obj28 + 312;
		obj3 = obj27;
		goto IL_0bc5;
		IL_0548:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		object obj30 = default(object);
		obj17 = obj30;
		goto IL_0b35;
		IL_0995:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		object obj32 = default(object);
		object obj31 = obj32;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v856 @ X0_v40+8]");
		object obj33 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v381 @ X2_v18 (should have been resolved before IL gen)");
		goto IL_09c1;
		IL_0169:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v467 @ X0_v67 (Il2CppClass<System.NullReferenceException>)+8]");
		obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v467 @ X0_v67 (Il2CppClass<System.NullReferenceException>)] (should have been resolved before IL gen)");
		bool flag9 = array == null;
		object obj34 = !flag9;
		obj3 = obj4;
		if (obj34 != null)
		{
			goto IL_0233;
		}
		IntPtr intPtr2 = default(IntPtr);
		num = intPtr2;
		goto IL_0a25;
		IL_0233:
		object obj35 = default(object);
		if (obj35 != null)
		{
			nint num3 = (nint)array;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v496 @ X8_v58 (Il2CppClass<System.Object[]>)+40]");
			obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
			bool flag10 = ex == null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v496 @ X8_v58 (Il2CppClass<System.Object[]>)+40]");
			obj18 = 0;
			if (flag10)
			{
				goto IL_0a94;
			}
		}
		if (array.Length != 0)
		{
			object obj36 = array + 32;
			obj36 = obj35;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			num = (nint)("startPosition" + 2944);
			LocalizableText localizableText = TextMeshProExtensions.LocalizeArguments((string)num, array);
			bool flag11 = popupWindowBuilderNeedsTitle == null;
			obj4 = obj3;
			if (!flag11)
			{
				object obj37 = typeof(System.IOAsyncCallback) + 392;
				nint num4 = (nint)popupWindowBuilderNeedsTitle;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v520 @ X8_v20 (Il2CppClass<IPopupWindowBuilderNeedsTitle>)+12E]");
				object obj38 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v520 @ X8_v20 (Il2CppClass<IPopupWindowBuilderNeedsTitle>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_03d8;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v520 @ X8_v20 (Il2CppClass<IPopupWindowBuilderNeedsTitle>)+B0]");
				obj4 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ X10_v39-8]");
					if (0 == (nint)obj37)
					{
						break;
					}
					obj3 = obj4 + 16;
					obj38--;
					bool flag12 = (nint)obj38 != 1;
					obj4 = obj3;
					if (flag12)
					{
						continue;
					}
					goto IL_03d8;
				}
				object obj39 = obj4 + 1;
				object obj40 = num4 + obj39;
				object obj41 = obj40 + 312;
				num = (nint)obj41;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v555 @ X0_v62] (should have been resolved before IL gen)");
				bool flag13 = obj9 == null;
				obj3 = obj4;
				if (!flag13)
				{
					goto IL_0489;
				}
			}
			goto IL_0a25;
		}
		goto IL_0a7e;
		IL_0766:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		object obj42 = default(object);
		num = (nint)obj42;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v753 @ X0_v47] (should have been resolved before IL gen)");
		object obj43 = default(object);
		bool flag14 = obj43 == null;
		object obj44 = !flag14;
		if (obj44 != null)
		{
			goto IL_081b;
		}
		obj19 = 0;
		obj4 = obj3;
		goto IL_0a25;
		IL_0a33:
		object obj45 = obj4 + 9;
		object obj46 = num + obj45;
		object obj47 = obj46 + 312;
		object obj48 = obj47;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v346 @ X8_v5+8]");
		object obj49 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v347 @ X2_v2 (should have been resolved before IL gen)");
		goto IL_0a7e;
		IL_081b:
		object obj50 = obj43;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v789 @ X8_v41+12E]");
		object obj51 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v789 @ X8_v41+12E]");
		if ((nint)0 == 0)
		{
			goto IL_08b7;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v789 @ X8_v41+B0]");
		obj4 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ X10_v39-8]");
			if (0 == (nint)obj21)
			{
				break;
			}
			obj3 = obj4 + 16;
			obj51--;
			bool flag15 = (nint)obj51 != 1;
			obj4 = obj3;
			if (flag15)
			{
				continue;
			}
			goto IL_08b7;
		}
		goto IL_09c1;
		IL_09c1:
		object obj52 = obj4 + 3;
		object obj53 = obj50 + obj52;
		num = (nint)(obj53 + 312);
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v338 @ X8_v3 (Il2CppClass<System.NullReferenceException>)] (should have been resolved before IL gen)");
		bool flag16 = ex2 == null;
		object obj54 = !flag16;
		obj19 = 0;
		if (obj54 != null)
		{
			goto IL_0901;
		}
		goto IL_0a25;
		IL_0a25:
		ex2 = new NullReferenceException();
		goto IL_0a33;
		IL_0665:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_0bc5;
		IL_0bc5:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v718 @ X0_v31] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj55 = (nint)0 + (nint)2344;
		Action action2 = default(Action);
		action2..ctor(this, (IntPtr)obj55);
		num = (nint)("Error reading data from socket: " + 1016);
		PopupButton popupButton2 = PopupButton.Neutral((string)num, action2, dismiss: true);
		object obj56 = default(object);
		bool flag17 = obj56 == null;
		obj19 = 0;
		obj4 = obj3;
		if (!flag17)
		{
			object obj57 = obj56;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v735 @ X8_v39+12E]");
			object obj58 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v735 @ X8_v39+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0766;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v735 @ X8_v39+B0]");
			obj4 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ X10_v39-8]");
				if (0 == (nint)obj21)
				{
					break;
				}
				obj3 = obj4 + 16;
				obj58--;
				bool flag18 = (nint)obj58 != 1;
				obj4 = obj3;
				if (flag18)
				{
					continue;
				}
				goto IL_0766;
			}
			object obj59 = obj57 + obj4;
			object obj60 = obj59 + 312;
			num = (nint)obj60;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v769 @ X0_v50] (should have been resolved before IL gen)");
			bool flag19 = obj43 == null;
			obj3 = obj4;
			obj19 = 0;
			if (!flag19)
			{
				goto IL_081b;
			}
		}
		goto IL_0a25;
		IL_0a94:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		throw new OutOfMemoryException();
	}

	private void RestartReplay()
	{
		KGame.RestartGame();
	}

	private void ExitRoom()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_004e: Expected O, but got I4
		//IL_007b: Expected O, but got I4
		object obj = typeof(RegisteredWaitHandle) + 1552;
		_gameEventsChannel.TriggerExitGame();
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		RoutingManager.Route(RoutingCommand.GameReplay, null, (Games?)(object)0);
	}
}
