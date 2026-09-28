using System;
using System.Data.SqlTypes;
using System.Diagnostics;
using Cpp2ILInjected;
using Kammelna.Server;
using Kammelna.Server.Models.Clans;
using Newtonsoft.Json.Linq.JsonPath;
using Sfs2X.Entities;
using UnityEngine;

public class LeaveRoomPopup : MonoBehaviour
{
	private GameEventsChannel _gameEventsChannel;

	private KGame game;

	private void Awake()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_008d: Expected O, but got I
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Expected O, but got Unknown
		//IL_00ad: Expected O, but got I
		//IL_00d7: Expected O, but got I4
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_006c: Expected I, but got O
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		object obj2 = (nint)0 + (nint)136;
		object obj3 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2552;
		object obj4 = (nint)0 + (nint)648;
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
		Action<System.Int32Enum> action = default(Action<System.Int32Enum>);
		action..ctor((object)this, (IntPtr)obj4);
		_gameEventsChannel.OnLeaveRoom += (Action<LeaveReason>)(object)action;
	}

	private void OnDestroy()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_004d: Expected I, but got O
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2552;
		object obj2 = (nint)0 + (nint)648;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<System.Int32Enum> action = default(Action<System.Int32Enum>);
		action..ctor((object)this, (IntPtr)obj2);
		_gameEventsChannel.OnLeaveRoom -= (Action<LeaveReason>)(object)action;
	}

	private void ShowPopup(LeaveReason leaveReason)
	{
		//IL_002e: Expected O, but got I4
		//IL_022e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0233: Expected O, but got Unknown
		//IL_023d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0242: Expected O, but got Unknown
		//IL_024a: Expected I, but got O
		//IL_025a: Expected O, but got I
		//IL_0073: Expected O, but got I4
		//IL_007c: Expected O, but got I4
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Expected O, but got Unknown
		//IL_0106: Expected O, but got I
		//IL_0114: Expected I, but got O
		//IL_098e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0993: Expected O, but got Unknown
		//IL_0295: Expected O, but got I
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Expected O, but got Unknown
		//IL_0536: Unknown result type (might be due to invalid IL or missing references)
		//IL_053b: Expected O, but got Unknown
		//IL_0553: Expected O, but got I
		//IL_014d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0152: Expected O, but got Unknown
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Expected O, but got Unknown
		//IL_0169: Expected I, but got O
		//IL_0179: Expected O, but got I
		//IL_00c5: Expected O, but got I4
		//IL_00ce: Expected O, but got I4
		//IL_050f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0514: Expected O, but got Unknown
		//IL_051d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0522: Expected O, but got Unknown
		//IL_0a3d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a42: Expected O, but got Unknown
		//IL_0a58: Expected O, but got I
		//IL_0a6b: Expected I, but got O
		//IL_0a75: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a7a: Expected O, but got Unknown
		//IL_058e: Expected O, but got I
		//IL_02a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a8: Expected O, but got Unknown
		//IL_02b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b6: Expected O, but got Unknown
		//IL_0930: Unknown result type (might be due to invalid IL or missing references)
		//IL_0935: Expected O, but got Unknown
		//IL_01b4: Expected O, but got I
		//IL_060d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0612: Expected O, but got Unknown
		//IL_062a: Expected O, but got I
		//IL_031c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0321: Expected O, but got Unknown
		//IL_0339: Expected O, but got I
		//IL_05f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f9: Expected O, but got Unknown
		//IL_03cf: Expected O, but got I
		//IL_03f3: Expected O, but got I4
		//IL_02f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fa: Expected O, but got Unknown
		//IL_0303: Unknown result type (might be due to invalid IL or missing references)
		//IL_0308: Expected O, but got Unknown
		//IL_0ad9: Expected O, but got I
		//IL_0ae7: Expected I, but got O
		//IL_0af1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0af6: Expected O, but got Unknown
		//IL_0665: Expected O, but got I
		//IL_059c: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a1: Expected O, but got Unknown
		//IL_05aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_05af: Expected O, but got Unknown
		//IL_044f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0454: Expected O, but got Unknown
		//IL_0474: Expected O, but got I
		//IL_0494: Expected O, but got I4
		//IL_0374: Expected O, but got I
		//IL_01c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c7: Expected O, but got Unknown
		//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d5: Expected O, but got Unknown
		//IL_06ed: Expected O, but got I
		//IL_0853: Expected O, but got I4
		//IL_0783: Expected O, but got I
		//IL_06cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d0: Expected O, but got Unknown
		//IL_04b8: Expected O, but got I
		//IL_041c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0421: Expected O, but got Unknown
		//IL_0431: Expected O, but got I
		//IL_07b2: Expected O, but got I
		//IL_07d2: Expected O, but got I4
		//IL_0728: Expected O, but got I
		//IL_0673: Unknown result type (might be due to invalid IL or missing references)
		//IL_0678: Expected O, but got Unknown
		//IL_0681: Unknown result type (might be due to invalid IL or missing references)
		//IL_0686: Expected O, but got Unknown
		//IL_09f2: Expected O, but got I4
		//IL_0382: Unknown result type (might be due to invalid IL or missing references)
		//IL_0387: Expected O, but got Unknown
		//IL_0390: Unknown result type (might be due to invalid IL or missing references)
		//IL_0395: Expected O, but got Unknown
		//IL_0869: Unknown result type (might be due to invalid IL or missing references)
		//IL_086e: Expected O, but got Unknown
		//IL_0884: Unknown result type (might be due to invalid IL or missing references)
		//IL_0889: Expected O, but got Unknown
		//IL_07f6: Expected O, but got I
		//IL_08a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_08a9: Expected O, but got Unknown
		//IL_08b9: Expected O, but got I
		//IL_08dd: Expected O, but got I4
		//IL_04c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04cb: Expected O, but got Unknown
		//IL_04d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d9: Expected O, but got Unknown
		//IL_0b54: Expected O, but got I4
		//IL_0736: Unknown result type (might be due to invalid IL or missing references)
		//IL_073b: Expected O, but got Unknown
		//IL_0744: Unknown result type (might be due to invalid IL or missing references)
		//IL_0749: Expected O, but got Unknown
		//IL_0502: Expected O, but got I4
		//IL_0804: Unknown result type (might be due to invalid IL or missing references)
		//IL_0809: Expected O, but got Unknown
		//IL_0812: Unknown result type (might be due to invalid IL or missing references)
		//IL_0817: Expected O, but got Unknown
		//IL_0832: Expected O, but got I4
		bool isReplay = game.IsReplay;
		bool flag = !isReplay;
		object obj = !flag;
		if (obj != null)
		{
			return;
		}
		object obj12;
		if (leaveReason != LeaveReason.TeammateReject)
		{
			bool flag2 = leaveReason == LeaveReason.RoomClosed;
			object obj2 = !flag2;
			object obj3 = 0;
			if (obj2 == null)
			{
				KGame kGame = game;
				bool isGameFinished = kGame.<GamePhase>k__BackingField.IsGameFinished;
				bool flag3 = !isGameFinished;
				object obj4 = !flag3;
				obj3 = 0;
				if (obj4 != null)
				{
					return;
				}
			}
			object obj5 = typeof(SqlSingle[]) + 2376;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj6 = (nint)0 + (nint)640;
			Action action = default(Action);
			action..ctor(this, (IntPtr)obj6);
			object buttonText = "LAK" + 864;
			IPopupWindowBuilderNeedsTitle popupWindowBuilderNeedsTitle = PopupWindowBuilder.CreateInfo(action, (string)buttonText);
			object obj7 = typeof(System.IOAsyncCallback) + 392;
			object obj8 = "LAK" + 944;
			nint num = (nint)popupWindowBuilderNeedsTitle;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v473 @ X8_v58 (Il2CppClass<IPopupWindowBuilderNeedsTitle>)+12E]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v473 @ X8_v58 (Il2CppClass<IPopupWindowBuilderNeedsTitle>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_01f5;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v473 @ X8_v58 (Il2CppClass<IPopupWindowBuilderNeedsTitle>)+B0]");
			object obj10 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v524 @ X10_v48-8]");
				if (0 == (nint)obj7)
				{
					break;
				}
				obj10 += 16;
				obj9--;
				if ((nint)obj9 != 1)
				{
					continue;
				}
				goto IL_01f5;
			}
			object obj11 = num + obj10;
			obj12 = obj11 + 312;
			goto IL_0917;
		}
		IPopupWindowBuilderNeedsTitle popupWindowBuilderNeedsTitle2 = PopupWindowBuilder.Create(PopupWindow.MessageType.Action);
		object obj13 = typeof(System.IOAsyncCallback) + 392;
		object obj14 = "LAK" + 944;
		nint num2 = (nint)popupWindowBuilderNeedsTitle2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v399 @ X8_v15 (Il2CppClass<IPopupWindowBuilderNeedsTitle>)+12E]");
		object obj15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v399 @ X8_v15 (Il2CppClass<IPopupWindowBuilderNeedsTitle>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_02d6;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v399 @ X8_v15 (Il2CppClass<IPopupWindowBuilderNeedsTitle>)+B0]");
		object obj16 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v443 @ X10_v32-8]");
			if (0 == (nint)obj13)
			{
				break;
			}
			obj16 += 16;
			obj15--;
			if ((nint)obj15 != 1)
			{
				continue;
			}
			goto IL_02d6;
		}
		object obj17 = num2 + obj16;
		object obj18 = obj17 + 312;
		goto IL_0975;
		IL_0840:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		object obj19 = 9;
		object obj21 = default(object);
		object obj20 = obj21;
		goto IL_0b62;
		IL_0ab9:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v899 @ X0_v27] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj22 = (nint)0 + (nint)656;
		Action action2 = default(Action);
		action2..ctor(this, (IntPtr)obj22);
		object label = "LAK" + 3968;
		PopupButton popupButton = PopupButton.Neutral((string)label, action2, dismiss: true);
		object obj24 = default(object);
		object obj23 = obj24;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v916 @ X8_v36+12E]");
		object obj25 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v916 @ X8_v36+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0769;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v916 @ X8_v36+B0]");
		object obj26 = (nint)0 + (nint)8;
		object obj27;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X10_v17-8]");
			if (0 == (nint)obj27)
			{
				break;
			}
			obj26 += 16;
			obj25--;
			if ((nint)obj25 != 1)
			{
				continue;
			}
			goto IL_0769;
		}
		object obj28 = obj23 + obj26;
		object obj29 = obj28 + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v949 @ X0_v39+8]");
		obj19 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v949 @ X0_v39] (should have been resolved before IL gen)");
		object obj30 = default(object);
		bool flag4 = obj30 == null;
		object obj31 = !flag4;
		if (obj31 != null)
		{
			goto IL_0792;
		}
		goto IL_08eb;
		IL_0440:
		object obj32 = typeof(System.IOAsyncCallback) + 368;
		object obj33 = obj32;
		object obj34 = obj30;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v862 @ X8_v6+12E]");
		object obj35 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v862 @ X8_v6+12E]");
		bool flag5 = (nint)0 == 0;
		object obj36 = 0;
		if (flag5)
		{
			goto IL_0840;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v862 @ X8_v6+B0]");
		object obj37 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v837 @ X10_v4-8]");
			bool flag6 = 0 == (nint)obj33;
			obj36 = 0;
			if (flag6)
			{
				break;
			}
			obj37 += 16;
			obj35--;
			if ((nint)obj35 != 1)
			{
				continue;
			}
			goto IL_04f9;
		}
		goto IL_0860;
		IL_03b5:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v652 @ X0_v62+8]");
		obj19 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v652 @ X0_v62] (should have been resolved before IL gen)");
		bool flag7 = obj30 == null;
		object obj38 = !flag7;
		if (obj38 != null)
		{
			goto IL_0440;
		}
		goto IL_08eb;
		IL_06a6:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_0ab9;
		IL_0860:
		object obj39 = obj37 + 9;
		object obj40 = obj34 + obj39;
		obj20 = obj40 + 312;
		goto IL_0b62;
		IL_02d6:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		object obj41 = default(object);
		obj18 = obj41;
		goto IL_0975;
		IL_0975:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v483 @ X8_v16] (should have been resolved before IL gen)");
		object obj42 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1832;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		Enum enumeration = default(Enum);
		string friendlyName = EnumExtensions.GetFriendlyName(enumeration);
		object obj43 = typeof(System.IOAsyncCallback) + 384;
		object obj45 = default(object);
		object obj44 = obj45;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v563 @ X8_v22+12E]");
		object obj46 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v563 @ X8_v22+12E]");
		if ((nint)0 == 0)
		{
			goto IL_05cf;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v563 @ X8_v22+B0]");
		object obj47 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v597 @ X10_v27-8]");
			if (0 == (nint)obj43)
			{
				break;
			}
			obj47 += 16;
			obj46--;
			if ((nint)obj46 != 1)
			{
				continue;
			}
			goto IL_05cf;
		}
		object obj48 = obj44 + obj47;
		object obj49 = obj48 + 312;
		goto IL_0a24;
		IL_0b62:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v326 @ X8_v5] (should have been resolved before IL gen)");
		return;
		IL_0769:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v934 @ X0_v36+8]");
		obj19 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v934 @ X0_v36] (should have been resolved before IL gen)");
		goto IL_0792;
		IL_08eb:
		throw new NullReferenceException();
		IL_04f9:
		obj36 = 0;
		goto IL_0840;
		IL_05cf:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_0a24;
		IL_0a24:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v627 @ X0_v20] (should have been resolved before IL gen)");
		object obj50 = typeof(SqlSingle[]) + 2376;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj51 = (nint)0 + (nint)3264;
		Action action3 = default(Action);
		action3..ctor(game, (IntPtr)obj51);
		object label2 = "LAK" + 864;
		PopupButton popupButton2 = PopupButton.Neutral((string)label2, action3, dismiss: true);
		obj27 = typeof(System.IOAsyncCallback) + 368;
		object obj53 = default(object);
		object obj52 = obj53;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v774 @ X8_v29+12E]");
		object obj54 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v774 @ X8_v29+12E]");
		if ((nint)0 == 0)
		{
			goto IL_06a6;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v774 @ X8_v29+B0]");
		object obj55 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v875 @ X10_v22-8]");
			if (0 == (nint)obj27)
			{
				break;
			}
			obj55 += 16;
			obj54--;
			if ((nint)obj54 != 1)
			{
				continue;
			}
			goto IL_06a6;
		}
		object obj56 = obj52 + obj55;
		object obj57 = obj56 + 312;
		goto IL_0ab9;
		IL_01f5:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		object obj58 = default(object);
		obj12 = obj58;
		goto IL_0917;
		IL_0917:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v552 @ X8_v59] (should have been resolved before IL gen)");
		object obj59 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1832;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		Enum enumeration2 = default(Enum);
		string friendlyName2 = EnumExtensions.GetFriendlyName(enumeration2);
		object obj60 = typeof(System.IOAsyncCallback) + 384;
		object obj62 = default(object);
		object obj61 = obj62;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v619 @ X8_v64+12E]");
		object obj63 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v619 @ X8_v64+12E]");
		if ((nint)0 == 0)
		{
			goto IL_03b5;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v619 @ X8_v64+B0]");
		object obj64 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X10_v43-8]");
			if (0 == (nint)obj60)
			{
				break;
			}
			obj64 += 16;
			obj63--;
			if ((nint)obj63 != 1)
			{
				continue;
			}
			goto IL_03b5;
		}
		object obj65 = obj61 + obj64;
		object obj66 = obj65 + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v675 @ X0_v65+8]");
		obj19 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v675 @ X0_v65] (should have been resolved before IL gen)");
		goto IL_0440;
		IL_0792:
		obj33 = obj27;
		obj34 = obj30;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v862 @ X8_v6+12E]");
		object obj67 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v862 @ X8_v6+12E]");
		bool flag8 = (nint)0 == 0;
		obj36 = 0;
		if (flag8)
		{
			goto IL_0840;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v862 @ X8_v6+B0]");
		obj37 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v837 @ X10_v4-8]");
			bool flag9 = 0 == (nint)obj33;
			obj36 = 0;
			if (flag9)
			{
				break;
			}
			obj37 += 16;
			obj67--;
			bool flag10 = (nint)obj67 != 1;
			obj36 = 0;
			if (flag10)
			{
				continue;
			}
			goto IL_0840;
		}
		goto IL_0860;
	}

	private void TryFindGame()
	{
		Room room = game.Room;
		GameType gameType = SFSKammelnaRoomExtensions.GetGameType(room);
		SFS.SendFindMatch(gameType);
	}

	private void <ShowPopup>b__4_0()
	{
		game.ExitGame();
	}
}
