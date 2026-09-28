using System;
using System.Data;
using System.Data.SqlTypes;
using System.Threading;
using Cpp2ILInjected;
using Kammelna.Server;
using Kammelna.Server.Models.Clans;
using Newtonsoft.Json.Linq.JsonPath;
using Server.Models;
using Sfs2X.Core;
using Sfs2X.Entities.Data;
using Unity.Properties;
using UnityEngine;

public class LockedRoomListener : MonoBehaviour
{
	private const string LockedRoomPopupTitle = "locked_room_popup_title";

	private const string LockedRoomMessage = "locked_room_message";

	private const string ReturnToGameLabel = "Back to play";

	private const string ForfeitLabel = "Forfeit";

	private void Awake()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected O, but got Unknown
		//IL_005a: Expected O, but got I
		//IL_008e: Expected O, but got I4
		//IL_00c5: Expected I, but got O
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		object obj2 = typeof(DataRelation) + 3728;
		object obj3 = (nint)0 + (nint)1680;
		GameObject gameObject = base.gameObject;
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X8_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		UnityEngine.Object target = gameObject;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			target = gameObject;
		}
		UnityEngine.Object.DontDestroyOnLoad(target);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		EventListenerDelegate eventListenerDelegate = default(EventListenerDelegate);
		eventListenerDelegate..ctor(this, (IntPtr)obj3);
		SFS.OnExtensionResponse += eventListenerDelegate;
	}

	private void OnExtensionResponse(BaseEvent evt)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_0b26: Expected O, but got I4
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Expected O, but got Unknown
		//IL_0068: Expected O, but got I
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Expected O, but got Unknown
		//IL_00c9: Expected O, but got I4
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Expected O, but got Unknown
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Expected O, but got Unknown
		//IL_0116: Expected O, but got I
		//IL_0154: Expected O, but got I4
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Expected O, but got Unknown
		//IL_018b: Expected I, but got O
		//IL_01ad: Expected O, but got I4
		//IL_091e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0923: Expected O, but got Unknown
		//IL_092b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0930: Expected O, but got Unknown
		//IL_0939: Unknown result type (might be due to invalid IL or missing references)
		//IL_093e: Expected O, but got Unknown
		//IL_01d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01de: Expected O, but got Unknown
		//IL_01e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ed: Expected O, but got Unknown
		//IL_01f5: Expected I, but got O
		//IL_0205: Expected O, but got I
		//IL_0d6c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d71: Expected O, but got Unknown
		//IL_0d9b: Expected O, but got I4
		//IL_096b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0970: Expected O, but got Unknown
		//IL_099a: Expected O, but got I4
		//IL_0bc2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bc7: Expected I, but got Unknown
		//IL_0240: Expected O, but got I
		//IL_09c3: Expected O, but got I
		//IL_09e5: Expected O, but got I4
		//IL_02e0: Expected O, but got I4
		//IL_02a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ad: Expected O, but got Unknown
		//IL_02b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bb: Expected O, but got Unknown
		//IL_0a8a: Expected O, but got I
		//IL_0a05: Expected O, but got I4
		//IL_024e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0253: Expected O, but got Unknown
		//IL_025c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0261: Expected O, but got Unknown
		//IL_0ab3: Expected O, but got I4
		//IL_0a43: Expected O, but got I
		//IL_02f6: Expected I, but got O
		//IL_0306: Expected O, but got I
		//IL_032f: Expected O, but got I
		//IL_0365: Unknown result type (might be due to invalid IL or missing references)
		//IL_036a: Expected O, but got Unknown
		//IL_0404: Expected O, but got I8
		//IL_03a9: Expected I, but got O
		//IL_03b9: Expected O, but got I
		//IL_03e2: Expected O, but got I
		//IL_042a: Unknown result type (might be due to invalid IL or missing references)
		//IL_042f: Expected O, but got Unknown
		//IL_044b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0450: Expected I, but got Unknown
		//IL_045d: Expected O, but got I
		//IL_049b: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a0: Expected O, but got Unknown
		//IL_04b8: Expected O, but got I
		//IL_0c2b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c30: Expected O, but got Unknown
		//IL_0c46: Expected O, but got I
		//IL_0c54: Expected I, but got O
		//IL_0c5e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c63: Expected I, but got Unknown
		//IL_0c75: Expected O, but got I
		//IL_04f3: Expected O, but got I
		//IL_0599: Expected O, but got I4
		//IL_0554: Unknown result type (might be due to invalid IL or missing references)
		//IL_0559: Expected O, but got Unknown
		//IL_056f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0574: Expected O, but got Unknown
		//IL_05bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c4: Expected O, but got Unknown
		//IL_05dc: Expected O, but got I
		//IL_0501: Unknown result type (might be due to invalid IL or missing references)
		//IL_0506: Expected O, but got Unknown
		//IL_050f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0514: Expected O, but got Unknown
		//IL_0cc2: Expected O, but got I
		//IL_0cd0: Expected I, but got O
		//IL_0cda: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cdf: Expected I, but got Unknown
		//IL_0cf1: Expected O, but got I
		//IL_0617: Expected O, but got I
		//IL_06af: Expected O, but got I4
		//IL_0685: Unknown result type (might be due to invalid IL or missing references)
		//IL_068a: Expected O, but got Unknown
		//IL_06de: Expected O, but got I
		//IL_0625: Unknown result type (might be due to invalid IL or missing references)
		//IL_062a: Expected O, but got Unknown
		//IL_0633: Unknown result type (might be due to invalid IL or missing references)
		//IL_0638: Expected O, but got Unknown
		//IL_0774: Expected I, but got O
		//IL_07a6: Expected O, but got I4
		//IL_0719: Expected O, but got I
		//IL_07cc: Expected I, but got O
		//IL_07dc: Expected O, but got I
		//IL_086b: Expected O, but got I4
		//IL_0897: Unknown result type (might be due to invalid IL or missing references)
		//IL_089c: Expected O, but got Unknown
		//IL_08a4: Expected I, but got O
		//IL_08d8: Expected O, but got I4
		//IL_08e9: Expected O, but got I4
		//IL_0817: Expected O, but got I
		//IL_0727: Unknown result type (might be due to invalid IL or missing references)
		//IL_072c: Expected O, but got Unknown
		//IL_0735: Unknown result type (might be due to invalid IL or missing references)
		//IL_073a: Expected O, but got Unknown
		//IL_0d3d: Expected O, but got I4
		//IL_0825: Unknown result type (might be due to invalid IL or missing references)
		//IL_082a: Expected O, but got Unknown
		//IL_0833: Unknown result type (might be due to invalid IL or missing references)
		//IL_0838: Expected O, but got Unknown
		object obj = "m_StencilDeferredPS" + 2136;
		string command = SFSExtensions.GetCommand(evt);
		bool flag = command == (string)obj;
		bool flag2 = !flag;
		object obj2 = !flag2;
		if (obj2 == null)
		{
			object obj3 = "placementId" + 1504;
			if (!(command == (string)obj3))
			{
				return;
			}
		}
		object varName = "destinationTimeZone" + 2696;
		object defaultValue = (nint)0 + (nint)2000;
		object obj4 = "tournament_participate_warning_body_with_tickets_warning_daily" + 4024;
		ISFSObject responseParams = SFSExtensions.GetResponseParams(evt);
		string text = SFSExtensions.Get(responseParams, (string)varName, (string)defaultValue);
		bool flag3 = text != (string)obj4;
		bool flag4 = !flag3;
		object obj5 = !flag4;
		if (obj5 != null)
		{
			return;
		}
		object varName2 = "java.io.FileOutputStream" + 3456;
		string text2 = SFSExtensions.Get(responseParams, (string)varName2, (string)defaultValue);
		object obj6 = "java.io.FileOutputStream" + 3464;
		object obj7 = (nint)0 + (nint)88;
		object obj8 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @301ECBC");
		GameType gameType = default(GameType);
		bool flag5 = GameTypeExtensions.IsFastTrack(gameType);
		bool flag6 = !flag5;
		object obj9 = !flag6;
		if (obj9 != null)
		{
			return;
		}
		string localizableName = GameTypeExtensions.GetLocalizableName(gameType);
		object obj10 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2656;
		nint num = (nint)obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v503 @ X8_v27 (Il2CppClass<System.NullReferenceException>)+E4]");
		bool flag7 = (nint)0 == 0;
		object obj11 = !flag7;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		string text3 = LocalizationUtil.Localize(localizableName);
		IPopupWindowBuilderNeedsTitle popupWindowBuilderNeedsTitle = PopupWindowBuilder.Create(PopupWindow.MessageType.Action);
		bool flag8 = popupWindowBuilderNeedsTitle == null;
		bool flag9 = false;
		if (flag8)
		{
			goto IL_0907;
		}
		object obj12 = typeof(System.IOAsyncCallback) + 392;
		object obj13 = "java.io.FileOutputStream" + 3152;
		nint num2 = (nint)popupWindowBuilderNeedsTitle;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v315 @ X8_v35 (Il2CppClass<IPopupWindowBuilderNeedsTitle>)+12E]");
		object obj14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v315 @ X8_v35 (Il2CppClass<IPopupWindowBuilderNeedsTitle>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0289;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v315 @ X8_v35 (Il2CppClass<IPopupWindowBuilderNeedsTitle>)+B0]");
		object obj15 = (nint)0 + (nint)8;
		object obj16 = default(object);
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v524 @ X10_v32-8]");
			if (0 == (nint)obj12)
			{
				break;
			}
			obj16 = obj15 + 16;
			obj14--;
			bool flag10 = (nint)obj14 != 1;
			obj15 = obj16;
			if (flag10)
			{
				continue;
			}
			goto IL_0289;
		}
		object obj17 = num2 + obj15;
		object obj18 = obj17 + 312;
		obj16 = obj15;
		goto IL_0b99;
		IL_0660:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_0ca2;
		IL_0762:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		object obj19 = default(object);
		num = (nint)obj19;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v841 @ X0_v80+8]");
		bool flag11 = false;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v841 @ X0_v80] (should have been resolved before IL gen)");
		NullReferenceException ex = default(NullReferenceException);
		bool flag12 = ex == null;
		obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v841 @ X0_v80+8]");
		flag9 = false;
		if (!flag12)
		{
			goto IL_07c4;
		}
		goto IL_0907;
		IL_07c4:
		num = (nint)ex;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v503 @ X8_v27 (Il2CppClass<System.NullReferenceException>)+12E]");
		object obj20 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v503 @ X8_v27 (Il2CppClass<System.NullReferenceException>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0858;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v503 @ X8_v27 (Il2CppClass<System.NullReferenceException>)+B0]");
		obj16 = (nint)0 + (nint)8;
		object obj21;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v380 @ X10_v14-8]");
			bool flag13 = 0 == (nint)obj21;
			obj8 = 0;
			flag9 = flag11;
			if (flag13)
			{
				break;
			}
			obj16 += 16;
			obj20--;
			if ((nint)obj20 != 1)
			{
				continue;
			}
			goto IL_0858;
		}
		goto IL_0915;
		IL_053c:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_0c12;
		IL_0c12:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v728 @ X0_v62] (should have been resolved before IL gen)");
		object obj22 = typeof(SqlSingle[]) + 2376;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj23 = (nint)0 + (nint)1688;
		Action action = default(Action);
		action..ctor(null, (IntPtr)obj23);
		num = (nint)("AvailableVoices" + 776);
		PopupButton popupButton = PopupButton.Positive((string)num, action, dismiss: true);
		object obj24 = default(object);
		bool flag14 = obj24 == null;
		obj8 = 0;
		flag9 = true;
		if (flag14)
		{
			goto IL_0907;
		}
		obj21 = typeof(System.IOAsyncCallback) + 368;
		object obj25 = obj24;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v748 @ X8_v56+12E]");
		object obj26 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v748 @ X8_v56+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0660;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v748 @ X8_v56+B0]");
		object obj27 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v790 @ X10_v22-8]");
			if (0 == (nint)obj21)
			{
				break;
			}
			obj16 = obj27 + 16;
			obj26--;
			bool flag15 = (nint)obj26 != 1;
			obj27 = obj16;
			if (flag15)
			{
				continue;
			}
			goto IL_0660;
		}
		object obj28 = obj25 + obj27;
		object obj29 = obj28 + 312;
		obj16 = obj27;
		goto IL_0ca2;
		IL_0ca2:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v806 @ X0_v69] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj30 = (nint)0 + (nint)1672;
		Action action2 = default(Action);
		action2..ctor(null, (IntPtr)obj30);
		num = (nint)("FilterFunction '{0}' expects {1} parameters but only {2} were provided. Missing parameters will be set to their default values." + 816);
		PopupButton popupButton2 = PopupButton.Negative((string)num, action2, dismiss: true);
		object obj31 = default(object);
		bool flag16 = obj31 == null;
		obj8 = 0;
		flag9 = true;
		if (!flag16)
		{
			object obj32 = obj31;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v823 @ X8_v63+12E]");
			object obj33 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v823 @ X8_v63+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0762;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v823 @ X8_v63+B0]");
			object obj34 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v377 @ X10_v17-8]");
				if (0 == (nint)obj21)
				{
					break;
				}
				obj16 = obj34 + 16;
				obj33--;
				bool flag17 = (nint)obj33 != 1;
				obj34 = obj16;
				if (flag17)
				{
					continue;
				}
				goto IL_0762;
			}
			object obj35 = obj32 + obj34;
			object obj36 = obj35 + 312;
			num = (nint)obj36;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v856 @ X0_v83+8]");
			flag11 = false;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v856 @ X0_v83] (should have been resolved before IL gen)");
			bool flag18 = ex == null;
			object obj37 = !flag18;
			obj16 = obj34;
			obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v856 @ X0_v83+8]");
			flag9 = false;
			if (obj37 != null)
			{
				goto IL_07c4;
			}
		}
		goto IL_0907;
		IL_0d53:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v555 @ X8_v14] (should have been resolved before IL gen)");
		object obj38 = typeof(RegisteredWaitHandle) + 3136;
		object obj39 = obj38;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v563 @ X0_v24+E4]");
		bool flag19 = (nint)0 == 0;
		object obj40 = !flag19;
		if (obj40 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		ScreenManager.AnimateTransitionIn();
		object obj41 = typeof(MemberAchievementClanFeedData) + 2976;
		object obj42 = obj41;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v590 @ X0_v27+E4]");
		bool flag20 = (nint)0 == 0;
		object obj43 = !flag20;
		if (obj43 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj44 = (nint)0 + (nint)104;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE90D8");
		HintsPopup hintsPopup = default(HintsPopup);
		bool flag21 = (object)hintsPopup == null;
		object obj45 = 0;
		if (!flag21)
		{
			hintsPopup.Close();
			obj45 = 0;
		}
		object obj46 = obj41;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v639 @ X0_v31+E4]");
		RankedPlayManager rankedPlayManager = default(RankedPlayManager);
		if ((nint)0 != 0)
		{
			object obj47 = (nint)0 + (nint)200;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE90D8");
			if ((object)rankedPlayManager == null)
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj48 = (nint)0 + (nint)200;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE90D8");
			bool flag22 = (object)rankedPlayManager == null;
			object obj49 = !flag22;
			if (obj49 == null)
			{
				return;
			}
		}
		rankedPlayManager.EnablePlayButton();
		return;
		IL_0ad8:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		throw new OutOfMemoryException();
		IL_0907:
		ex = new NullReferenceException();
		goto IL_0915;
		IL_0858:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		obj8 = 0;
		flag9 = true;
		object obj51 = default(object);
		object obj50 = obj51;
		goto IL_0d53;
		IL_0915:
		object obj52 = obj16 + 9;
		object obj53 = num + obj52;
		obj50 = obj53 + 312;
		goto IL_0d53;
		IL_0289:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		object obj54 = default(object);
		obj18 = obj54;
		goto IL_0b99;
		IL_0b99:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v577 @ X8_v36+8]");
		flag9 = false;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v577 @ X8_v36] (should have been resolved before IL gen)");
		num = (nint)(typeof(TypeConverter<ushort, char>) + 3400);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		object[] array = default(object[]);
		if (array == null)
		{
			goto IL_0907;
		}
		bool flag23 = text2 == null;
		string text4 = (string)2;
		IndexOutOfRangeException ex2 = default(IndexOutOfRangeException);
		string text5;
		if (!flag23)
		{
			nint num3 = (nint)array;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v607 @ X8_v73 (Il2CppClass<System.Object[]>)+40]");
			text4 = (string)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
			bool flag24 = ex2 == null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v607 @ X8_v73 (Il2CppClass<System.Object[]>)+40]");
			text5 = (string)0;
			if (flag24)
			{
				goto IL_0ad8;
			}
		}
		if (array.Length != 0)
		{
			object obj55 = array + 32;
			obj55 = text2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			bool flag25 = text3 == null;
			text4 = text2;
			if (!flag25)
			{
				nint num4 = (nint)array;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v647 @ X8_v72 (Il2CppClass<System.Object[]>)+40]");
				text4 = (string)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
				bool flag26 = ex2 == null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v647 @ X8_v72 (Il2CppClass<System.Object[]>)+40]");
				text5 = (string)0;
				if (flag26)
				{
					goto IL_0ad8;
				}
			}
			object obj56 = array.Length & 0xFFFFFFFEL;
			if (obj56 != null)
			{
				object obj57 = array + 40;
				obj57 = text3;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				num = (nint)("java.io.FileOutputStream" + 3144);
				LocalizableText localizableText = TextMeshProExtensions.LocalizeWith((string)num, array);
				object obj58 = default(object);
				bool flag27 = obj58 == null;
				flag9 = false;
				if (flag27)
				{
					goto IL_0907;
				}
				object obj59 = typeof(System.IOAsyncCallback) + 384;
				object obj60 = obj58;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v669 @ X8_v49+12E]");
				object obj61 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v669 @ X8_v49+12E]");
				if ((nint)0 == 0)
				{
					goto IL_053c;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v669 @ X8_v49+B0]");
				object obj62 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v711 @ X10_v27-8]");
					if (0 == (nint)obj59)
					{
						break;
					}
					obj16 = obj62 + 16;
					obj61--;
					bool flag28 = (nint)obj61 != 1;
					obj62 = obj16;
					if (flag28)
					{
						continue;
					}
					goto IL_053c;
				}
				object obj63 = obj62 + 1;
				object obj64 = obj60 + obj63;
				object obj65 = obj64 + 312;
				obj16 = obj62;
				goto IL_0c12;
			}
		}
		ex2 = new IndexOutOfRangeException();
		text5 = text4;
		goto IL_0ad8;
	}

	private static void ReturnToGame()
	{
		SFS.SendLockedRoomRequest(LockedRoomRequestSubCommand.Return);
	}

	private static void Forfeit()
	{
		SFS.SendLockedRoomRequest(LockedRoomRequestSubCommand.Forfeit);
	}
}
