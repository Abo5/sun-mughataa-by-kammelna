using System;
using System.Buffers.Text;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using Newtonsoft.Json.Linq.JsonPath;
using Server.Models;
using Unity.Services.Authentication.Shared;
using UnityEngine;
using UnityEngine.InputSystem.XR;
using UnityEngine.TextCore;

public class UserFeedItemIconManager : MonoBehaviour
{
	private RectTransform container;

	private GameObject avatarPrefab;

	private GameObject avatarFriendPrefab;

	private GameObject avatarLikePrefab;

	private GameObject avatarGiftPrefab;

	private GameObject achievementPrefab;

	private GameObject reportPrefab;

	private GameObject progressionReportPrefab;

	private GameObject wonTournamentCoinsPrefab;

	private GameObject wonTournamentTrophyPrefab;

	private GameObject wonTournamentPointsPrefab;

	private GameObject wonTournamentMonthlyPrefab;

	private GameObject massEventPrefab;

	private GameObject massEventStagePrefab;

	private GameObject rankUpPrefab;

	private GameObject rankDownPrefab;

	private GameObject predictionLogoPrefab;

	private GameObject predictionSeasonTopPlacePrefab;

	private GameObject miniGameLogoPrefab;

	private GameObject kammelnaLogoPrefab;

	private GameObject losePointsPrefab;

	private GameObject refundPrefab;

	private GameObject reminderPrefab;

	private GameObject receivedProfileGiftPrefab;

	private GameObject clanEmblemPrefab;

	public void Populate(UserFeedItem feedItem, Action onReady)
	{
		//IL_000c: Expected O, but got I
		//IL_02f5: Expected O, but got I
		//IL_021a: Expected O, but got I
		//IL_022a: Expected O, but got I
		//IL_0240: Expected O, but got I
		//IL_0249: Unknown result type (might be due to invalid IL or missing references)
		//IL_024e: Expected O, but got Unknown
		//IL_0268: Expected O, but got I4
		//IL_0278: Expected O, but got I
		//IL_0021: Expected O, but got I
		//IL_0037: Expected O, but got I
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected O, but got Unknown
		//IL_0064: Expected O, but got I
		//IL_02b2: Expected O, but got I4
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Expected O, but got Unknown
		//IL_00bb: Expected O, but got I
		//IL_00cb: Expected O, but got I
		//IL_00e1: Expected O, but got I
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Expected O, but got Unknown
		//IL_0109: Expected O, but got I4
		//IL_0132: Expected O, but got I
		//IL_0142: Expected O, but got I
		//IL_017b: Expected O, but got I4
		//IL_01b3: Expected O, but got I
		object obj = (nint)0 + (nint)3120;
		GameObject template = GetTemplate(feedItem);
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X24_v3+38]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X24_v3+38]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X8_v3+10]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X8_v3+10]");
			object obj5 = (nint)0 + (nint)309;
			object obj6 = obj5 & 1;
			bool flag = obj6 == null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X8_v3+10]");
			object obj7 = 0;
			if (!flag)
			{
				goto IL_0072;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CD24");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X24_v3+38]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X8_v7+10]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X8_v7+10]");
			object obj9 = (nint)0 + (nint)309;
			object obj10 = obj9 & 1;
			bool flag2 = obj10 == null;
			object obj11 = !flag2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X8_v7+10]");
			object obj7 = 0;
			if (obj11 != null)
			{
				goto IL_0072;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X0_v4+E4]");
		bool flag3 = (nint)0 == 0;
		object obj12 = !flag3;
		if (obj12 != null)
		{
			goto IL_0097;
		}
		goto IL_02c0;
		IL_0097:
		object obj13 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X24_v3+38]");
		object obj14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X8_v11+10]");
		object obj15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X8_v11+10]");
		object obj16 = (nint)0 + (nint)309;
		object obj17 = obj16 & 1;
		bool flag4 = obj17 == null;
		object obj18 = !flag4;
		if (obj18 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		}
		object obj19 = (nint)0 + (nint)920;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X0_v13+B8]");
		object except = 0;
		UIExtensions.DestroyAllChildren(container, (GameObject[])except);
		object obj20 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X0_v15+E4]");
		bool flag5 = (nint)0 == 0;
		object obj21 = !flag5;
		if (obj21 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE9DE4");
		object obj22 = (nint)0 + (nint)1896;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E3438C");
		object obj23 = default(object);
		if (obj23 != null)
		{
			object obj25 = default(object);
			object obj24 = obj25;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v189 @ X8_v20+178] (should have been resolved before IL gen)");
		}
		else
		{
			Actions.SafeInvoke(onReady);
		}
		return;
		IL_02c0:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		goto IL_0097;
		IL_0072:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X0_v4+E4]");
		if ((nint)0 != 0)
		{
			goto IL_0097;
		}
		goto IL_02c0;
	}

	private GameObject GetTemplate(UserFeedItem feedItem)
	{
		//IL_0ab8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0abd: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_0058: Expected I, but got O
		//IL_0081: Expected O, but got I4
		//IL_0e03: Expected O, but got I4
		//IL_0e1d: Expected O, but got I4
		//IL_0aed: Expected O, but got I4
		//IL_0afa: Expected O, but got I
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Expected O, but got Unknown
		//IL_011e: Expected O, but got I4
		//IL_0e4b: Expected O, but got I4
		//IL_0b41: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b46: Expected O, but got Unknown
		//IL_0b56: Expected I, but got O
		//IL_0b7f: Expected O, but got I4
		//IL_0185: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Expected O, but got Unknown
		//IL_01bb: Expected O, but got I4
		//IL_00b5: Expected O, but got I
		//IL_0e3d: Expected O, but got I4
		//IL_0be6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0beb: Expected O, but got Unknown
		//IL_0c1c: Expected O, but got I4
		//IL_0222: Unknown result type (might be due to invalid IL or missing references)
		//IL_0227: Expected O, but got Unknown
		//IL_0258: Expected O, but got I4
		//IL_0152: Expected O, but got I
		//IL_0b03: Expected O, but got I4
		//IL_0b10: Expected O, but got I
		//IL_0c83: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c88: Expected O, but got Unknown
		//IL_0cb9: Expected O, but got I4
		//IL_0bb3: Expected O, but got I
		//IL_02bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c4: Expected O, but got Unknown
		//IL_02f5: Expected O, but got I4
		//IL_01ef: Expected O, but got I
		//IL_0dcd: Expected O, but got I4
		//IL_0dda: Expected O, but got I
		//IL_0e59: Expected O, but got I4
		//IL_0d20: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d25: Expected O, but got Unknown
		//IL_0d56: Expected O, but got I4
		//IL_0c50: Expected O, but got I
		//IL_0f53: Expected O, but got I4
		//IL_0f60: Expected O, but got I
		//IL_035c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0361: Expected O, but got Unknown
		//IL_0392: Expected O, but got I4
		//IL_028c: Expected O, but got I
		//IL_1178: Expected O, but got I
		//IL_0e67: Expected O, but got I4
		//IL_0db7: Expected O, but got I4
		//IL_0dc4: Expected O, but got I
		//IL_0ced: Expected O, but got I
		//IL_1091: Expected O, but got I4
		//IL_109e: Expected O, but got I
		//IL_03f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fe: Expected O, but got Unknown
		//IL_042f: Expected O, but got I4
		//IL_0329: Expected O, but got I
		//IL_0de3: Expected O, but got I4
		//IL_0df0: Expected O, but got I
		//IL_0d8a: Expected O, but got I
		//IL_10bd: Expected O, but got I4
		//IL_10ca: Expected O, but got I
		//IL_0496: Unknown result type (might be due to invalid IL or missing references)
		//IL_049b: Expected O, but got Unknown
		//IL_04cc: Expected O, but got I4
		//IL_03c6: Expected O, but got I
		//IL_10d3: Expected O, but got I4
		//IL_10e0: Expected O, but got I
		//IL_0533: Unknown result type (might be due to invalid IL or missing references)
		//IL_0538: Expected O, but got Unknown
		//IL_0569: Expected O, but got I4
		//IL_0463: Expected O, but got I
		//IL_0ee5: Expected O, but got I4
		//IL_0ef2: Expected O, but got I
		//IL_0f69: Expected O, but got I4
		//IL_0f76: Expected O, but got I
		//IL_05d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d5: Expected O, but got Unknown
		//IL_0606: Expected O, but got I4
		//IL_0500: Expected O, but got I
		//IL_0efb: Expected O, but got I4
		//IL_0f08: Expected O, but got I
		//IL_066d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0672: Expected O, but got Unknown
		//IL_06a3: Expected O, but got I4
		//IL_059d: Expected O, but got I
		//IL_0f11: Expected O, but got I4
		//IL_0f1e: Expected O, but got I
		//IL_070a: Unknown result type (might be due to invalid IL or missing references)
		//IL_070f: Expected O, but got Unknown
		//IL_0740: Expected O, but got I4
		//IL_063a: Expected O, but got I
		//IL_0f27: Expected O, but got I4
		//IL_0f34: Expected O, but got I
		//IL_0fb5: Expected O, but got I4
		//IL_0ecf: Expected O, but got I4
		//IL_0edc: Expected O, but got I
		//IL_07a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ac: Expected O, but got Unknown
		//IL_07dd: Expected O, but got I4
		//IL_06d7: Expected O, but got I
		//IL_0f3d: Expected O, but got I4
		//IL_0f4a: Expected O, but got I
		//IL_1185: Expected O, but got I
		//IL_0fa7: Expected O, but got I4
		//IL_0844: Unknown result type (might be due to invalid IL or missing references)
		//IL_0849: Expected O, but got Unknown
		//IL_087a: Expected O, but got I4
		//IL_0774: Expected O, but got I
		//IL_0fe6: Expected O, but got I
		//IL_100b: Expected O, but got I
		//IL_101b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1020: Expected O, but got Unknown
		//IL_1055: Expected O, but got I4
		//IL_08e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_08e6: Expected O, but got Unknown
		//IL_0917: Expected O, but got I4
		//IL_0811: Expected O, but got I
		//IL_10a7: Expected O, but got I4
		//IL_10b4: Expected O, but got I
		//IL_1083: Expected O, but got I4
		//IL_097e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0983: Expected O, but got Unknown
		//IL_09b4: Expected O, but got I4
		//IL_08ae: Expected O, but got I
		//IL_1192: Expected O, but got I
		//IL_1075: Expected O, but got I4
		//IL_0a1b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a20: Expected O, but got Unknown
		//IL_0a51: Expected O, but got I4
		//IL_094b: Expected O, but got I
		//IL_10e9: Expected O, but got I4
		//IL_10f6: Expected O, but got I
		//IL_09e8: Expected O, but got I
		//IL_0fc3: Expected O, but got I4
		//IL_0fd0: Expected O, but got I
		//IL_0a85: Expected O, but got I
		if (feedItem != null)
		{
			UserFeedData <Data>k__BackingField = feedItem.<Data>k__BackingField;
			if (feedItem.<Data>k__BackingField != null)
			{
				object obj = typeof(System.Buffers.Text.ParserHelpers) + 3448;
				object obj2 = obj;
				nint num = (nint)<Data>k__BackingField;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X8_v25 (Il2CppClass<Server.Models.UserFeedData>)+130]");
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X10_v20+130]");
				bool flag = num2 < 0;
				object obj3 = !flag;
				object obj4 = ~obj3;
				if (obj4 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X8_v25 (Il2CppClass<Server.Models.UserFeedData>)+C8]");
					nint num3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X10_v20+130]");
					object obj5 = num3 + 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X11_v82-8]");
					if (0 == (nint)obj2)
					{
						goto IL_0afa;
					}
				}
				object obj6 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2104;
				object obj7 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X8_v25 (Il2CppClass<Server.Models.UserFeedData>)+130]");
				nint num4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ X10_v24+130]");
				bool flag2 = num4 < 0;
				object obj8 = !flag2;
				object obj9 = ~obj8;
				if (obj9 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X8_v25 (Il2CppClass<Server.Models.UserFeedData>)+C8]");
					nint num5 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ X10_v24+130]");
					object obj10 = num5 + 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v632 @ X11_v80-8]");
					if (0 == (nint)obj7)
					{
						object obj11 = 56;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (UserFeedItemIconManager)+v506 @ X8_v53]");
						return (GameObject)0;
					}
				}
				object obj12 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 3144;
				object obj13 = obj12;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X8_v25 (Il2CppClass<Server.Models.UserFeedData>)+130]");
				nint num6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v631 @ X10_v27+130]");
				bool flag3 = num6 < 0;
				object obj14 = !flag3;
				object obj15 = ~obj14;
				if (obj15 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X8_v25 (Il2CppClass<Server.Models.UserFeedData>)+C8]");
					nint num7 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v631 @ X10_v27+130]");
					object obj16 = num7 + 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v659 @ X11_v78-8]");
					if (0 == (nint)obj13)
					{
						goto IL_0afa;
					}
				}
				object obj17 = typeof(SqlSingle[]) + 2368;
				object obj18 = obj17;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X8_v25 (Il2CppClass<Server.Models.UserFeedData>)+130]");
				nint num8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v460 @ X10_v30+130]");
				bool flag4 = num8 < 0;
				object obj19 = !flag4;
				object obj20 = ~obj19;
				if (obj20 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X8_v25 (Il2CppClass<Server.Models.UserFeedData>)+C8]");
					nint num9 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v460 @ X10_v30+130]");
					object obj21 = num9 + 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v711 @ X11_v76-8]");
					if (0 == (nint)obj18)
					{
						object obj22 = 72;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (UserFeedItemIconManager)+v507 @ X8_v52]");
						return (GameObject)0;
					}
				}
				object obj23 = typeof(UsageHint) + 2208;
				object obj24 = obj23;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X8_v25 (Il2CppClass<Server.Models.UserFeedData>)+130]");
				nint num10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v462 @ X10_v33+130]");
				bool flag5 = num10 < 0;
				object obj25 = !flag5;
				object obj26 = ~obj25;
				if (obj26 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X8_v25 (Il2CppClass<Server.Models.UserFeedData>)+C8]");
					nint num11 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v462 @ X10_v33+130]");
					object obj27 = num11 + 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v764 @ X11_v74-8]");
					if (0 == (nint)obj24)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X21_v2 (Server.Models.UserFeedData)+20]");
						if ((nint)0 != 9)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X21_v2 (Server.Models.UserFeedData)+20]");
							if ((nint)0 == 10)
							{
								object obj28 = 120;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (UserFeedItemIconManager)+v509 @ X8_v51]");
								return (GameObject)0;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X21_v2 (Server.Models.UserFeedData)+28]");
							if ((nint)0 == 0)
							{
								object obj29 = 96;
							}
							else
							{
								object obj29 = 104;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (UserFeedItemIconManager)+v517 @ X8_v48]");
							return (GameObject)0;
						}
						object obj30 = 112;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (UserFeedItemIconManager)+v516 @ X8_v45]");
						return (GameObject)0;
					}
				}
				object obj31 = typeof(UsageHint) + 2200;
				object obj32 = obj31;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X8_v25 (Il2CppClass<Server.Models.UserFeedData>)+130]");
				nint num12 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v463 @ X10_v36+130]");
				bool flag6 = num12 < 0;
				object obj33 = !flag6;
				object obj34 = ~obj33;
				if (obj34 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X8_v25 (Il2CppClass<Server.Models.UserFeedData>)+C8]");
					nint num13 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v463 @ X10_v36+130]");
					object obj35 = num13 + 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v836 @ X11_v72-8]");
					if (0 == (nint)obj32)
					{
						object obj36 = 128;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (UserFeedItemIconManager)+v510 @ X8_v43]");
						return (GameObject)0;
					}
				}
				object obj37 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 3752;
				object obj38 = obj37;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X8_v25 (Il2CppClass<Server.Models.UserFeedData>)+130]");
				nint num14 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v464 @ X10_v39+130]");
				bool flag7 = num14 < 0;
				object obj39 = !flag7;
				object obj40 = ~obj39;
				if (obj40 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X8_v25 (Il2CppClass<Server.Models.UserFeedData>)+C8]");
					nint num15 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v464 @ X10_v39+130]");
					object obj41 = num15 + 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v888 @ X11_v70-8]");
					if (0 == (nint)obj38)
					{
						object obj42 = 136;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (UserFeedItemIconManager)+v511 @ X8_v42]");
						return (GameObject)0;
					}
				}
				object obj43 = typeof(System.Buffers.Text.ParserHelpers) + 3160;
				object obj44 = obj43;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X8_v25 (Il2CppClass<Server.Models.UserFeedData>)+130]");
				nint num16 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v465 @ X10_v42+130]");
				bool flag8 = num16 < 0;
				object obj45 = !flag8;
				object obj46 = ~obj45;
				if (obj46 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X8_v25 (Il2CppClass<Server.Models.UserFeedData>)+C8]");
					nint num17 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v465 @ X10_v42+130]");
					object obj47 = num17 + 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v937 @ X11_v68-8]");
					if (0 == (nint)obj44)
					{
						object obj48 = 144;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (UserFeedItemIconManager)+v512 @ X8_v41]");
						return (GameObject)0;
					}
				}
				object obj49 = typeof(System.Buffers.Text.ParserHelpers) + 3144;
				object obj50 = obj49;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X8_v25 (Il2CppClass<Server.Models.UserFeedData>)+130]");
				nint num18 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v466 @ X10_v45+130]");
				bool flag9 = num18 < 0;
				object obj51 = !flag9;
				object obj52 = ~obj51;
				if (obj52 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X8_v25 (Il2CppClass<Server.Models.UserFeedData>)+C8]");
					nint num19 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v466 @ X10_v45+130]");
					object obj53 = num19 + 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v968 @ X11_v66-8]");
					if (0 == (nint)obj50)
					{
						object obj54 = 152;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (UserFeedItemIconManager)+v513 @ X8_v40]");
						return (GameObject)0;
					}
				}
				object obj55 = typeof(System.Buffers.Text.ParserHelpers) + 1576;
				object obj56 = obj55;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X8_v25 (Il2CppClass<Server.Models.UserFeedData>)+130]");
				nint num20 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v467 @ X10_v48+130]");
				bool flag10 = num20 < 0;
				object obj57 = !flag10;
				object obj58 = ~obj57;
				if (obj58 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X8_v25 (Il2CppClass<Server.Models.UserFeedData>)+C8]");
					nint num21 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v467 @ X10_v48+130]");
					object obj59 = num21 + 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v995 @ X11_v64-8]");
					if (0 == (nint)obj56)
					{
						object obj60 = 160;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (UserFeedItemIconManager)+v514 @ X8_v39]");
						return (GameObject)0;
					}
				}
				object obj61 = typeof(System.Buffers.Text.ParserHelpers) + 1592;
				object obj62 = obj61;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X8_v25 (Il2CppClass<Server.Models.UserFeedData>)+130]");
				nint num22 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v470 @ X10_v51+130]");
				bool flag11 = num22 < 0;
				object obj63 = !flag11;
				object obj64 = ~obj63;
				if (obj64 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X8_v25 (Il2CppClass<Server.Models.UserFeedData>)+C8]");
					nint num23 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v470 @ X10_v51+130]");
					object obj65 = num23 + 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1023 @ X11_v62-8]");
					if (0 == (nint)obj62)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X21_v2 (Server.Models.UserFeedData)+14]");
						object obj66 = -4;
						bool flag12 = (nint)obj66 < 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X21_v2 (Server.Models.UserFeedData)+14]");
						object obj67 = (nint)0 ^ (nint)4;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X21_v2 (Server.Models.UserFeedData)+14]");
						object obj68 = 0 ^ obj66;
						object obj69 = obj67 & obj68;
						bool flag13 = (nint)obj69 < 0;
						bool flag14 = flag12 == flag13;
						object obj70 = !flag14;
						object obj71 = ~obj70;
						if (obj71 == null)
						{
							object obj72 = 168;
						}
						else
						{
							object obj72 = 160;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (UserFeedItemIconManager)+v519 @ X8_v36]");
						return (GameObject)0;
					}
				}
				object obj73 = typeof(MemberAchievementClanFeedData) + 792;
				object obj74 = obj73;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X8_v25 (Il2CppClass<Server.Models.UserFeedData>)+130]");
				nint num24 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v472 @ X10_v54+130]");
				bool flag15 = num24 < 0;
				object obj75 = !flag15;
				object obj76 = ~obj75;
				if (obj76 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X8_v25 (Il2CppClass<Server.Models.UserFeedData>)+C8]");
					nint num25 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v472 @ X10_v54+130]");
					object obj77 = num25 + 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1062 @ X11_v60-8]");
					if (0 == (nint)obj74)
					{
						object obj78 = 176;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (UserFeedItemIconManager)+v521 @ X8_v33]");
						return (GameObject)0;
					}
				}
				object obj79 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3744;
				object obj80 = obj79;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X8_v25 (Il2CppClass<Server.Models.UserFeedData>)+130]");
				nint num26 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v927 @ X10_v57+130]");
				bool flag16 = num26 < 0;
				object obj81 = !flag16;
				object obj82 = ~obj81;
				if (obj82 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X8_v25 (Il2CppClass<Server.Models.UserFeedData>)+C8]");
					nint num27 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v927 @ X10_v57+130]");
					object obj83 = num27 + 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1091 @ X11_v58-8]");
					if (0 == (nint)obj80)
					{
						goto IL_0dae;
					}
				}
				object obj84 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1200;
				object obj85 = obj84;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X8_v25 (Il2CppClass<Server.Models.UserFeedData>)+130]");
				nint num28 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v475 @ X10_v60+130]");
				bool flag17 = num28 < 0;
				object obj86 = !flag17;
				object obj87 = ~obj86;
				if (obj87 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X8_v25 (Il2CppClass<Server.Models.UserFeedData>)+C8]");
					nint num29 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v475 @ X10_v60+130]");
					object obj88 = num29 + 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1118 @ X11_v56-8]");
					if (0 == (nint)obj85)
					{
						object obj89 = 192;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (UserFeedItemIconManager)+v524 @ X8_v32]");
						return (GameObject)0;
					}
				}
				object obj90 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1432;
				object obj91 = obj90;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X8_v25 (Il2CppClass<Server.Models.UserFeedData>)+130]");
				nint num30 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1132 @ X10_v63+130]");
				bool flag18 = num30 < 0;
				object obj92 = !flag18;
				object obj93 = ~obj92;
				if (obj93 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X8_v25 (Il2CppClass<Server.Models.UserFeedData>)+C8]");
					nint num31 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1132 @ X10_v63+130]");
					object obj94 = num31 + 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1148 @ X11_v54-8]");
					if (0 == (nint)obj91)
					{
						goto IL_0fba;
					}
				}
				object obj95 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 1240;
				object obj96 = obj95;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X8_v25 (Il2CppClass<Server.Models.UserFeedData>)+130]");
				nint num32 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1171 @ X10_v67+130]");
				bool flag19 = num32 < 0;
				object obj97 = !flag19;
				object obj98 = ~obj97;
				if (obj98 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X8_v25 (Il2CppClass<Server.Models.UserFeedData>)+C8]");
					nint num33 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1171 @ X10_v67+130]");
					object obj99 = num33 + 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1197 @ X11_v52-8]");
					if (0 == (nint)obj96)
					{
						goto IL_0fba;
					}
				}
				object obj100 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 1216;
				object obj101 = obj100;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X8_v25 (Il2CppClass<Server.Models.UserFeedData>)+130]");
				nint num34 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X10_v70+130]");
				bool flag20 = num34 < 0;
				object obj102 = !flag20;
				object obj103 = ~obj102;
				if (obj103 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X8_v25 (Il2CppClass<Server.Models.UserFeedData>)+C8]");
					nint num35 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X10_v70+130]");
					object obj104 = num35 + 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1215 @ X8_v30-8]");
					if (0 == (nint)obj101)
					{
						goto IL_0fba;
					}
				}
			}
			object obj105 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 1528;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
			object obj106 = default(object);
			if (obj106 != null)
			{
				object obj107 = 224;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (UserFeedItemIconManager)+v503 @ X8_v22]");
				return (GameObject)0;
			}
			if (feedItem.<Data>k__BackingField != null)
			{
				object obj108 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3656;
				object obj109 = obj108;
				nint num36 = (nint)<Data>k__BackingField;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v685 @ X8_v14 (Il2CppClass<Server.Models.UserFeedData>)+130]");
				nint num37 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v468 @ X10_v10+130]");
				bool flag21 = num37 < 0;
				object obj110 = !flag21;
				object obj111 = ~obj110;
				if (obj111 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v685 @ X8_v14 (Il2CppClass<Server.Models.UserFeedData>)+C8]");
					nint num38 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v468 @ X10_v10+130]");
					object obj112 = num38 + 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v735 @ X11_v15-8]");
					if (0 == (nint)obj109)
					{
						object obj113 = 200;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (UserFeedItemIconManager)+v515 @ X8_v21]");
						return (GameObject)0;
					}
				}
				object obj114 = typeof(System.Buffers.Text.ParserHelpers) + 2680;
				object obj115 = obj114;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v685 @ X8_v14 (Il2CppClass<Server.Models.UserFeedData>)+130]");
				nint num39 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v471 @ X10_v13+130]");
				bool flag22 = num39 < 0;
				object obj116 = !flag22;
				object obj117 = ~obj116;
				if (obj117 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v685 @ X8_v14 (Il2CppClass<Server.Models.UserFeedData>)+C8]");
					nint num40 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v471 @ X10_v13+130]");
					object obj118 = num40 + 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v796 @ X11_v13-8]");
					if (0 == (nint)obj115)
					{
						object obj119 = 208;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (UserFeedItemIconManager)+v520 @ X8_v20]");
						return (GameObject)0;
					}
				}
				object obj120 = typeof(System.Buffers.Text.ParserHelpers) + 3456;
				object obj121 = obj120;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v685 @ X8_v14 (Il2CppClass<Server.Models.UserFeedData>)+130]");
				nint num41 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v473 @ X10_v16+130]");
				bool flag23 = num41 < 0;
				object obj122 = !flag23;
				object obj123 = ~obj122;
				if (obj123 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v685 @ X8_v14 (Il2CppClass<Server.Models.UserFeedData>)+C8]");
					nint num42 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v473 @ X10_v16+130]");
					object obj124 = num42 + 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v860 @ X11_v11-8]");
					if (0 == (nint)obj121)
					{
						object obj125 = 216;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (UserFeedItemIconManager)+v522 @ X8_v19]");
						return (GameObject)0;
					}
				}
				object obj126 = typeof(MemberAchievementClanFeedData) + 1488;
				object obj127 = obj126;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v685 @ X8_v14 (Il2CppClass<Server.Models.UserFeedData>)+130]");
				nint num43 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v474 @ X10_v19+130]");
				bool flag24 = num43 < 0;
				object obj128 = !flag24;
				object obj129 = ~obj128;
				if (obj129 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v685 @ X8_v14 (Il2CppClass<Server.Models.UserFeedData>)+C8]");
					nint num44 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v474 @ X10_v19+130]");
					object obj130 = num44 + 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v913 @ X8_v16-8]");
					if (0 == (nint)obj127)
					{
						object obj131 = 88;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (UserFeedItemIconManager)+v523 @ X8_v18]");
						return (GameObject)0;
					}
				}
				goto IL_0dae;
			}
			object obj132 = feedItem.<Type>k__BackingField - 13;
			bool flag25 = obj132 == null;
			object obj133 = !flag25;
			object obj134 = ~obj133;
			object obj135 = ((obj134 != null) ? ((object)160) : ((object)184));
			if (feedItem.<Type>k__BackingField == UserFeedType.UserReportReceived)
			{
				obj135 = 80;
			}
			if (feedItem.<Type>k__BackingField == UserFeedType.UserReportProcessed)
			{
				object obj136 = 80;
			}
			else
			{
				object obj136 = obj135;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (UserFeedItemIconManager)+v508 @ X8_v9]");
			return (GameObject)0;
		}
		return (GameObject)(object)new NullReferenceException();
		IL_0afa:
		object obj137 = 64;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (UserFeedItemIconManager)+v504 @ X8_v26]");
		return (GameObject)0;
		IL_0dae:
		object obj138 = 184;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (UserFeedItemIconManager)+v505 @ X8_v4]");
		return (GameObject)0;
		IL_0fba:
		object obj139 = 48;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (UserFeedItemIconManager)+v518 @ X8_v28]");
		return (GameObject)0;
	}
}
