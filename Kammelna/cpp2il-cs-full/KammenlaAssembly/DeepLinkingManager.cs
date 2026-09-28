using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Formats.Asn1;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using AdjustSdk;
using Cpp2ILInjected;
using DataTracking;
using Kammelna.Server;
using Kammelna.Server.Models.Clans;
using Newtonsoft.Json.Linq.JsonPath;
using Unity.Services.Authentication.Shared;
using UnityEngine;
using UnityEngine.Device;
using UnityEngine.InputSystem.XR;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.Rendering;
using UnityEngine.TextCore;

public class DeepLinkingManager : MonoBehaviour
{
	private sealed class <>c__DisplayClass14_0
	{
		public RoomInviteData roomInviteData;

		internal void <TryJoinGame>b__0()
		{
			//IL_0009: Expected O, but got I4
			//IL_0013: Unknown result type (might be due to invalid IL or missing references)
			//IL_0018: Expected O, but got Unknown
			//IL_002e: Expected O, but got I
			//IL_013c: Expected O, but got I
			//IL_0152: Expected O, but got I
			//IL_016c: Expected O, but got I4
			//IL_017c: Expected O, but got I
			//IL_0069: Expected O, but got I
			//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cc: Expected O, but got Unknown
			//IL_00f6: Expected O, but got I4
			//IL_01b4: Expected O, but got I4
			object obj = 152989696;
			object obj2 = "SERVICE_DISABLED" + 2256;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7055]");
			object obj3 = (nint)0 & (nint)1;
			string text;
			string text2;
			if (obj3 != null)
			{
				text = (string)obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7054]");
				object obj4 = (nint)0 & (nint)1;
				bool flag = obj4 == null;
				text2 = (string)obj2;
				if (!flag)
				{
					goto IL_008e;
				}
			}
			else
			{
				_ = 1;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7000]");
				text = (string)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7054]");
				object obj5 = (nint)0 & (nint)1;
				bool flag2 = obj5 == null;
				object obj6 = !flag2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7000]");
				text2 = (string)0;
				if (obj6 != null)
				{
					goto IL_008e;
				}
			}
			_ = 1;
			bool isTablet = ScreenUtility.IsTablet;
			bool flag3 = !isTablet;
			object obj7 = !flag3;
			text = text2;
			if (obj7 != null)
			{
				goto IL_00b8;
			}
			goto IL_01ca;
			IL_01d8:
			RoomInviteData roomInviteData = this.roomInviteData;
			SFS.JoinGameRoom(roomInviteData.<RoomId>k__BackingField, 0, roomInviteData.<Password>k__BackingField);
			return;
			IL_00b8:
			object obj8 = typeof(System.Buffers.Text.ParserHelpers) + 1432;
			object obj9 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X0_v17+E4]");
			bool flag4 = (nint)0 == 0;
			object obj10 = !flag4;
			if (obj10 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			PopupWindow.ShowLoading(text);
			goto IL_01d8;
			IL_01ca:
			SplashAnimation.SetStatusMessage(text2);
			goto IL_01d8;
			IL_008e:
			bool isTablet2 = ScreenUtility.IsTablet;
			bool flag5 = !isTablet2;
			text2 = text;
			if (!flag5)
			{
				goto IL_00b8;
			}
			goto IL_01ca;
		}
	}

	private sealed class <>c__DisplayClass15_0
	{
		public RoomInviteData roomInviteData;

		public DeepLinkingManager <>4__this;

		internal void <TryJoinTournament>b__0()
		{
			//IL_0009: Expected O, but got I4
			//IL_0013: Unknown result type (might be due to invalid IL or missing references)
			//IL_0018: Expected O, but got Unknown
			//IL_002e: Expected O, but got I
			//IL_013c: Expected O, but got I
			//IL_0152: Expected O, but got I
			//IL_016c: Expected O, but got I4
			//IL_017c: Expected O, but got I
			//IL_0069: Expected O, but got I
			//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cc: Expected O, but got Unknown
			//IL_00f6: Expected O, but got I4
			//IL_01b4: Expected O, but got I4
			object obj = 152989696;
			object obj2 = "SERVICE_DISABLED" + 2264;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7056]");
			object obj3 = (nint)0 & (nint)1;
			string text;
			string text2;
			if (obj3 != null)
			{
				text = (string)obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7054]");
				object obj4 = (nint)0 & (nint)1;
				bool flag = obj4 == null;
				text2 = (string)obj2;
				if (!flag)
				{
					goto IL_008e;
				}
			}
			else
			{
				_ = 1;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7000]");
				text = (string)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7054]");
				object obj5 = (nint)0 & (nint)1;
				bool flag2 = obj5 == null;
				object obj6 = !flag2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7000]");
				text2 = (string)0;
				if (obj6 != null)
				{
					goto IL_008e;
				}
			}
			_ = 1;
			bool isTablet = ScreenUtility.IsTablet;
			bool flag3 = !isTablet;
			object obj7 = !flag3;
			text = text2;
			if (obj7 != null)
			{
				goto IL_00b8;
			}
			goto IL_01ca;
			IL_01d8:
			RoomInviteData roomInviteData = this.roomInviteData;
			GameObject gameObject = <>4__this.gameObject;
			DeepLinkingManager deepLinkingManager = <>4__this;
			AcceptTournamentInvite.Accept(roomInviteData.<RoomId>k__BackingField, roomInviteData.<Password>k__BackingField, gameObject, deepLinkingManager.tournamentsEventsChannel);
			return;
			IL_00b8:
			object obj8 = typeof(System.Buffers.Text.ParserHelpers) + 1432;
			object obj9 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X0_v20+E4]");
			bool flag4 = (nint)0 == 0;
			object obj10 = !flag4;
			if (obj10 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			PopupWindow.ShowLoading(text);
			goto IL_01d8;
			IL_01ca:
			SplashAnimation.SetStatusMessage(text2);
			goto IL_01d8;
			IL_008e:
			bool isTablet2 = ScreenUtility.IsTablet;
			bool flag5 = !isTablet2;
			text2 = text;
			if (!flag5)
			{
				goto IL_00b8;
			}
			goto IL_01ca;
		}
	}

	private sealed class <>c__DisplayClass16_0
	{
		public FriendInviteData inviteData;

		public DeepLinkingManager <>4__this;

		internal void <TryAddFriend>g__AddFriendAction|0()
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0025: Expected O, but got I
			//IL_0042: Expected I, but got O
			FriendInviteData friendInviteData = inviteData;
			object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 576;
			object obj2 = (nint)0 + (nint)1944;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Action<object> action = default(Action<object>);
			action..ctor((object)<>4__this, (IntPtr)obj2);
			KammelnaRequests.AddFriendVerified(friendInviteData.<UserCode>k__BackingField, friendInviteData.<Token>k__BackingField, action);
		}
	}

	private sealed class <>c__DisplayClass18_0
	{
		public TVCreateGamePopupInviteData inviteData;

		internal void <TryShowTVCreateGamePopup>b__0()
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			TVCreateGamePopupInviteData tVCreateGamePopupInviteData = inviteData;
			object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 3680;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v3+E4]");
			if ((nint)0 != 0)
			{
				TVCreateGameInvitePopup.Show(tVCreateGamePopupInviteData.<TvUserId>k__BackingField);
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			TVCreateGameInvitePopup.Show(tVCreateGamePopupInviteData.<TvUserId>k__BackingField);
		}
	}

	private const string KammelnaLink = "https://kammelna.com";

	private const string PasswordResetPath = "ChangePassword";

	private const string EmailQueryKey = "email";

	private const string ConfirmationCodeQueryKey = "confirmation";

	private TournamentsEventsChannel tournamentsEventsChannel;

	private void Start()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected O, but got Unknown
		//IL_007c: Expected O, but got I
		//IL_00b0: Expected O, but got I4
		//IL_00e7: Expected I, but got O
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		object obj2 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3576;
		object obj3 = (nint)0 + (nint)1952;
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
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj3);
		UnityEngine.Device.Application.deepLinkActivated += action;
		MarketingGrantHandler.RedeemPendingGrant();
		string absoluteURL = UnityEngine.Device.Application.absoluteURL;
		OnDeepLinkActivated(absoluteURL);
	}

	public unsafe static string GenerateInviteLink(IInviteData data)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0035: Expected I, but got O
		//IL_0045: Expected O, but got I
		//IL_0225: Expected O, but got I4
		//IL_0080: Expected O, but got I
		//IL_0120: Expected O, but got Ref
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Expected O, but got Unknown
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Expected O, but got Unknown
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Expected O, but got Unknown
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Expected O, but got Unknown
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Expected O, but got Unknown
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Expected O, but got Unknown
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0164: Expected O, but got Unknown
		if (data == null)
		{
			goto IL_0194;
		}
		object obj = typeof(UnityEngine.TextCore.HorizontalAlignment) + 3336;
		object obj2 = typeof(System.Buffers.Text.ParserHelpers) + 1624;
		nint num = (nint)data;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v6 (Il2CppClass<IInviteData>)+12E]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v6 (Il2CppClass<IInviteData>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_00c1;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v6 (Il2CppClass<IInviteData>)+B0]");
		object obj4 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ X10_v6-8]");
			if (0 == (nint)obj)
			{
				break;
			}
			obj4 += 16;
			obj3--;
			if ((nint)obj3 != 1)
			{
				continue;
			}
			goto IL_00c1;
		}
		object obj5 = obj4 + 1;
		object obj6 = num + obj5;
		object obj7 = obj6 + 312;
		goto IL_01e3;
		IL_01e3:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v219 @ X0_v4] (should have been resolved before IL gen)");
		string data2 = default(string);
		string text = EncodedString(data2);
		object obj8 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v227 @ X0_v8+E4]");
		bool flag = (nint)0 == 0;
		object obj9 = !flag;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Games currentGame = Preferences.CurrentGame;
		object obj10 = default(object);
		string text2 = ((Enum)(&obj10)).ToString();
		if (text2 != null)
		{
			object obj11 = "getSecondRescanTask" + 3888;
			object obj12 = ", stale={0}" + 2968;
			string text3 = text2.ToLower();
			return (string)obj11 + text3 + (string)obj12 + text;
		}
		goto IL_0194;
		IL_0194:
		return (string)(object)new NullReferenceException();
		IL_00c1:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_01e3;
	}

	private unsafe void OnDeepLinkActivated(string link)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00d8: Expected O, but got I4
		//IL_0099: Expected O, but got I4
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Expected O, but got Unknown
		//IL_0186: Expected O, but got I4
		//IL_011c: Expected O, but got I4
		//IL_0125: Expected O, but got I4
		//IL_01d0: Expected O, but got I
		//IL_0271: Unknown result type (might be due to invalid IL or missing references)
		//IL_0276: Expected O, but got Unknown
		//IL_02a0: Expected O, but got I4
		//IL_01fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0201: Expected O, but got Unknown
		//IL_0400: Unknown result type (might be due to invalid IL or missing references)
		//IL_0405: Expected O, but got Unknown
		//IL_0430: Unknown result type (might be due to invalid IL or missing references)
		//IL_0435: Expected O, but got Unknown
		//IL_044b: Expected O, but got I
		//IL_0459: Expected I, but got O
		//IL_034c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0351: Expected O, but got Unknown
		//IL_035d: Expected O, but got I
		//IL_03b6: Expected O, but got I4
		//IL_03be: Expected O, but got Ref
		//IL_03c6: Expected I4, but got O
		//IL_04ba: Expected O, but got I4
		//IL_04d4: Expected O, but got I4
		//IL_04f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04fe: Expected O, but got Unknown
		//IL_050e: Expected I, but got O
		//IL_0537: Expected O, but got I4
		//IL_08ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0904: Expected O, but got Unknown
		//IL_091a: Expected O, but got I
		//IL_03e4: Expected O, but got Ref
		//IL_09c2: Expected O, but got I4
		//IL_057b: Expected O, but got I
		//IL_05d4: Expected O, but got I4
		//IL_05ea: Expected O, but got I
		//IL_0604: Expected O, but got I4
		//IL_0659: Expected O, but got I4
		//IL_0687: Expected O, but got I
		//IL_06a5: Expected O, but got I4
		//IL_06d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d7: Expected O, but got Unknown
		//IL_07cc: Expected O, but got I4
		//IL_0767: Expected O, but got I4
		//IL_0869: Expected O, but got I4
		//IL_0818: Expected O, but got I4
		//IL_0821: Expected O, but got I4
		//IL_08a4: Expected O, but got I
		//IL_08c7: Expected O, but got I4
		//IL_08d0: Expected O, but got I4
		object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 2536;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7052]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v85+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v85+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag2 = StringsExtensions.IsNullOrEmpty(link);
		bool flag3 = !flag2;
		object obj5 = !flag3;
		object obj6 = 0;
		if (obj5 != null)
		{
			return;
		}
		goto IL_0133;
		IL_0742:
		string userDbId;
		bool flag4 = StringsExtensions.IsNullOrEmpty(userDbId);
		bool flag5 = !flag4;
		object obj7 = 0;
		if (flag5)
		{
			goto IL_083f;
		}
		object obj9;
		object obj8 = obj9;
		IInviteData inviteData2;
		IInviteData inviteData = inviteData2;
		goto IL_08e6;
		IL_04ea:
		object obj10 = typeof(RegisteredWaitHandle) + 1400;
		object obj11 = obj10;
		nint num = (nint)inviteData2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v437 @ X9_v2 (Il2CppClass<IInviteData>)+130]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v436 @ X8_v38+130]");
		bool flag6 = num2 < 0;
		object obj12 = !flag6;
		object obj13 = ~obj12;
		obj8 = obj9;
		inviteData = inviteData2;
		object obj22;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v437 @ X9_v2 (Il2CppClass<IInviteData>)+C8]");
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v436 @ X8_v38+130]");
			object obj14 = num3 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v491 @ X9_v4-8]");
			bool flag7 = 0 != (nint)obj11;
			obj8 = obj9;
			inviteData = inviteData2;
			if (!flag7)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ X20_v9 (IInviteData)+10]");
				bool flag8 = (nint)0 < (nint)1;
				object obj15 = !flag8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ X20_v9 (IInviteData)+10]");
				object obj16 = -1;
				bool flag9 = obj16 == null;
				object obj17 = !flag9;
				object obj18 = obj15 & obj17;
				obj8 = obj9;
				inviteData = inviteData2;
				if (obj18 == null)
				{
					object obj19 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v505 @ X0_v53+E4]");
					bool flag10 = (nint)0 == 0;
					object obj20 = !flag10;
					if (obj20 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ X20_v9 (IInviteData)+30]");
					bool flag11 = StringsExtensions.IsNullOrEmpty((string)0);
					bool flag12 = !flag11;
					object obj21 = !flag12;
					obj8 = obj9;
					inviteData = inviteData2;
					if (obj21 == null)
					{
						obj22 = typeof(UsageHint) + 72;
						object obj23 = obj22;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v526 @ X0_v57+E4]");
						string value;
						if ((nint)0 != 0)
						{
							userDbId = UserInfo.UserDbId;
							object obj24 = obj;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v487 @ X8_v44+E4]");
							bool flag13 = (nint)0 == 0;
							value = userDbId;
							if (!flag13)
							{
								goto IL_0742;
							}
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							userDbId = UserInfo.UserDbId;
							object obj24 = obj;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v487 @ X8_v44+E4]");
							bool flag14 = (nint)0 == 0;
							object obj25 = !flag14;
							value = userDbId;
							if (obj25 != null)
							{
								goto IL_0742;
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						bool flag15 = StringsExtensions.IsNullOrEmpty(value);
						bool flag16 = !flag15;
						object obj26 = !flag16;
						obj7 = 0;
						obj8 = obj9;
						inviteData = inviteData2;
						if (obj26 == null)
						{
							goto IL_083f;
						}
					}
				}
			}
		}
		goto IL_08e6;
		IL_02e6:
		WebInterface.CleanLinkSilently();
		return;
		IL_0074:
		bool flag17 = StringsExtensions.IsNullOrEmpty(link);
		bool flag18 = !flag17;
		obj6 = 0;
		if (!flag18)
		{
			return;
		}
		goto IL_0133;
		IL_0133:
		object obj27 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 4024;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Uri uri = default(Uri);
		uri..ctor(link);
		bool flag19 = TryHandleRoutingLink(uri);
		bool flag20 = !flag19;
		object obj28 = !flag20;
		if (obj28 != null || TryHandlePasswordReset(uri))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7053]");
			object obj29 = (nint)0 & (nint)1;
			if (obj29 != null)
			{
				object obj30 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1168;
				object obj31 = obj30;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v367 @ X0_v9+E4]");
				if ((nint)0 != 0)
				{
					goto IL_022e;
				}
			}
			else
			{
				_ = 1;
				object obj32 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1168;
				object obj31 = obj32;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v367 @ X0_v9+E4]");
				bool flag21 = (nint)0 == 0;
				object obj33 = !flag21;
				if (obj33 != null)
				{
					goto IL_022e;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Platform platform = KUtil.GetPlatform();
			if (platform != Platform.Web)
			{
				return;
			}
			goto IL_02e6;
		}
		string query = uri.Query;
		if (query._stringLength > 1)
		{
			string query2 = uri.Query;
			Dictionary<string, string> dictionary = ParseQueryParams(query2);
			object obj34 = "not" + 3664;
			object obj35 = (nint)0 + (nint)768;
			if (((Dictionary<object, object>)(object)dictionary).TryGetValue(obj34, out object value2))
			{
				IInviteData inviteData3 = DecodeInviteData((string)value2);
				bool flag22 = inviteData3 == null;
				object obj36 = !flag22;
				obj9 = (object)(&value2);
				int num4 = (int)obj34;
				inviteData2 = inviteData3;
				if (obj36 != null)
				{
					goto IL_04ea;
				}
				obj8 = (object)(&value2);
				inviteData = inviteData3;
			}
			else
			{
				string query3 = uri.Query;
				string encodedData = query3.Substring(1);
				IInviteData inviteData4 = DecodeInviteData(encodedData);
				bool flag23 = inviteData4 == null;
				obj9 = 0;
				int num4 = 1;
				inviteData2 = inviteData4;
				obj8 = 0;
				inviteData = inviteData4;
				if (!flag23)
				{
					goto IL_04ea;
				}
			}
			goto IL_08e6;
		}
		object obj37 = typeof(SqlSingle[]) + 3096;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		AdjustDeeplink adjustDeeplink = default(AdjustDeeplink);
		adjustDeeplink..ctor(link);
		object obj38 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3576;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj39 = (nint)0 + (nint)1952;
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj39);
		Adjust.ProcessAndResolveDeeplink(adjustDeeplink, action);
		return;
		IL_0a08:
		WebInterface.CleanLinkSilently();
		return;
		IL_083f:
		object obj40 = obj22;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v554 @ X0_v59+E4]");
		bool flag24 = (nint)0 == 0;
		object obj41 = !flag24;
		if (obj41 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		string userDbId2 = UserInfo.UserDbId;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ X20_v9 (IInviteData)+30]");
		bool flag25 = (string)0 != userDbId2;
		bool flag26 = !flag25;
		object obj42 = !flag26;
		obj8 = 0;
		inviteData = inviteData2;
		if (obj42 != null)
		{
			return;
		}
		goto IL_08e6;
		IL_08e6:
		HandleInvite(inviteData);
		object obj43 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1168;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7053]");
		object obj44 = (nint)0 & (nint)1;
		if (obj44 != null)
		{
			object obj45 = obj43;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v513 @ X0_v40+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0964;
			}
		}
		else
		{
			_ = 1;
			object obj45 = obj43;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v513 @ X0_v40+E4]");
			bool flag27 = (nint)0 == 0;
			object obj46 = !flag27;
			if (obj46 != null)
			{
				goto IL_0964;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Platform platform2 = KUtil.GetPlatform();
		if (platform2 != Platform.Web)
		{
			return;
		}
		goto IL_0a08;
		IL_0964:
		Platform platform3 = KUtil.GetPlatform();
		if (platform3 != Platform.Web)
		{
			return;
		}
		goto IL_0a08;
		IL_022e:
		Platform platform4 = KUtil.GetPlatform();
		if (platform4 != Platform.Web)
		{
			return;
		}
		goto IL_02e6;
	}

	private static void CleanLinkIfWeb()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00d3: Expected O, but got I4
		object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1168;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7053]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v2+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Platform platform = KUtil.GetPlatform();
		if (platform != Platform.Web)
		{
			return;
		}
		goto IL_009d;
		IL_009d:
		WebInterface.CleanLinkSilently();
		return;
		IL_0074:
		Platform platform2 = KUtil.GetPlatform();
		if (platform2 == Platform.Web)
		{
			goto IL_009d;
		}
	}

	private unsafe static bool TryHandleRoutingLink(Uri uri)
	{
		//IL_02f5: Expected I4, but got O
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected O, but got Unknown
		//IL_005c: Expected O, but got I
		//IL_0099: Expected O, but got I4
		//IL_00a9: Expected O, but got I
		//IL_00cb: Expected O, but got I4
		//IL_00f4: Expected O, but got I
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Expected O, but got Unknown
		//IL_0126: Expected O, but got I4
		//IL_0321: Unknown result type (might be due to invalid IL or missing references)
		//IL_0326: Expected O, but got Unknown
		//IL_0345: Unknown result type (might be due to invalid IL or missing references)
		//IL_034a: Expected O, but got Unknown
		//IL_0373: Expected O, but got I4
		//IL_037b: Expected O, but got Ref
		//IL_0383: Expected I4, but got O
		//IL_0285: Unknown result type (might be due to invalid IL or missing references)
		//IL_028a: Expected O, but got Unknown
		//IL_02b4: Expected O, but got I4
		//IL_0169: Expected O, but got I
		//IL_018b: Expected O, but got I4
		//IL_01b4: Expected O, but got I
		//IL_01c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cc: Expected O, but got Unknown
		//IL_01e6: Expected O, but got I4
		//IL_01ee: Expected O, but got Ref
		//IL_0250: Expected I4, but got O
		//IL_025c: Expected O, but got I
		//IL_0271: Expected I4, but got O
		//IL_0220: Expected O, but got Ref
		//IL_0229: Expected O, but got I4
		//IL_0232: Expected O, but got I4
		Uri uri2 = default(Uri);
		bool flag;
		int result = default(int);
		object value2 = default(object);
		System.Int32Enum? game;
		if ((object)uri2 != null)
		{
			string query = uri2.Query;
			Dictionary<string, string> dictionary = ParseQueryParams(query);
			if (dictionary != null)
			{
				object key = "com.unity.services.authentication.profile" + 120;
				object obj = (nint)0 + (nint)768;
				flag = ((Dictionary<object, object>)(object)dictionary).TryGetValue(key, out object value);
				if (flag)
				{
					object obj2 = 153100288 + 1024;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X23_v4+98]");
					object obj3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X0_v8+E4]");
					bool flag2 = (nint)0 == 0;
					object obj4 = !flag2;
					if (obj4 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					object obj5 = (nint)0 + (nint)1016;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D7088C");
					object obj7 = default(object);
					object obj6 = obj7 & 1;
					bool flag3 = obj6 == null;
					object obj8 = !flag3;
					object value3 = default(object);
					System.Int32Enum int32Enum;
					object obj10;
					if (obj8 != null || !int.TryParse((string)value, out result))
					{
						object key2 = "not" + 3664;
						bool flag4 = ((Dictionary<object, object>)(object)dictionary).TryGetValue(key2, out value2);
						object obj9 = "fetch_products" + 2352;
						bool flag5 = ((Dictionary<object, object>)(object)dictionary).TryGetValue(obj9, out value3);
						bool flag6 = !flag5;
						game = (System.Int32Enum?)(object)0;
						obj10 = (object)(&value3);
						int32Enum = (System.Int32Enum)obj9;
						if (flag6)
						{
							goto IL_0276;
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X23_v4+98]");
					object obj11 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ X0_v23+E4]");
					bool flag7 = (nint)0 == 0;
					object obj12 = !flag7;
					if (obj12 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					object obj13 = (nint)0 + (nint)992;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D7088C");
					object obj15 = default(object);
					object obj14 = obj15 & 1;
					bool flag8 = obj14 == null;
					object obj16 = !flag8;
					object obj18 = default(object);
					object obj17 = (object)(&obj18);
					if (obj16 == null)
					{
						int result2;
						bool flag9 = int.TryParse((string)value3, out result2);
						bool flag10 = !flag9;
						obj17 = (object)(&result2);
						game = (System.Int32Enum?)(object)0;
						obj10 = 0;
						int32Enum = (System.Int32Enum)(int)(&result2);
						if (flag10)
						{
							goto IL_0276;
						}
					}
					int32Enum = (System.Int32Enum)obj17;
					object obj19 = (nint)0 + (nint)2744;
					obj10 = obj19;
					game = (System.Int32Enum)obj17;
					goto IL_0276;
				}
				goto IL_0312;
			}
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
		IL_0312:
		return flag;
		IL_0276:
		object obj20 = typeof(RegisteredWaitHandle) + 1552;
		object obj21 = obj20;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ X0_v18+E4]");
		bool flag11 = (nint)0 == 0;
		object obj22 = !flag11;
		if (obj22 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		RoutingManager.Route((RoutingCommand)result, (string)value2, (Games?)game);
		goto IL_0312;
	}

	private static bool TryHandlePasswordReset(Uri uri)
	{
		//IL_0205: Expected I4, but got O
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected O, but got Unknown
		//IL_0066: Expected I4, but got I8
		//IL_0080: Expected O, but got I4
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Expected O, but got Unknown
		//IL_00e5: Expected O, but got I
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Expected O, but got Unknown
		//IL_013d: Expected O, but got I4
		//IL_022d: Expected O, but got I4
		//IL_018b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0190: Expected O, but got Unknown
		//IL_01ba: Expected O, but got I4
		if ((object)uri != null)
		{
			string absolutePath = uri.AbsolutePath;
			if (absolutePath != null)
			{
				object value = "Cannot populate JSON object onto type '{0}'." + 2120;
				int num = absolutePath.IndexOf((string)value, StringComparison.OrdinalIgnoreCase);
				int num2 = (int)(num & 0x80000000L);
				bool flag = num2 == 0;
				object obj = !flag;
				if (obj == null)
				{
					string query = uri.Query;
					Dictionary<string, string> dictionary = ParseQueryParams(query);
					if (dictionary == null)
					{
						goto IL_01f7;
					}
					object key = "destinationTimeZone" + 1896;
					object obj2 = (nint)0 + (nint)768;
					object key2 = "com.unity.services.authentication.profile" + 528;
					object value2;
					bool flag2 = ((Dictionary<object, object>)(object)dictionary).TryGetValue(key, out value2);
					object value3;
					bool flag3 = ((Dictionary<object, object>)(object)dictionary).TryGetValue(key2, out value3);
					bool flag4 = !flag2;
					object obj3 = !flag4;
					object obj4 = ~obj3;
					bool flag5 = obj4 != null || !flag3;
					object obj5 = !flag5;
					if (obj5 != null)
					{
						object obj6 = typeof(RegisteredWaitHandle) + 840;
						object obj7 = obj6;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ X8_v11+E4]");
						bool flag6 = (nint)0 == 0;
						object obj8 = !flag6;
						string confirmationCode = (string)value3;
						string email = (string)value2;
						if (obj8 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							confirmationCode = (string)value3;
							email = (string)value2;
						}
						ResetPasswordPopup.Show(email, confirmationCode);
						return true;
					}
				}
				return false;
			}
		}
		goto IL_01f7;
		IL_01f7:
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	private static Dictionary<string, string> ParseQueryParams(string query)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0145: Expected O, but got I4
		//IL_0093: Expected O, but got I
		//IL_00ad: Expected O, but got I4
		//IL_06c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ca: Expected O, but got Unknown
		//IL_06d6: Expected O, but got I
		//IL_06e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ea: Expected O, but got Unknown
		//IL_0714: Expected O, but got I4
		//IL_0173: Expected O, but got I
		//IL_0757: Expected O, but got I
		//IL_0769: Expected I4, but got O
		//IL_077e: Expected O, but got I
		//IL_0786: Expected I, but got O
		//IL_01cb: Expected O, but got I4
		//IL_0645: Unknown result type (might be due to invalid IL or missing references)
		//IL_064a: Expected O, but got Unknown
		//IL_0674: Expected O, but got I4
		//IL_0209: Unknown result type (might be due to invalid IL or missing references)
		//IL_020e: Expected O, but got Unknown
		//IL_02b8: Expected O, but got I4
		//IL_02e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e6: Expected O, but got Unknown
		//IL_0523: Expected O, but got I4
		//IL_053e: Expected O, but got I4
		//IL_0331: Unknown result type (might be due to invalid IL or missing references)
		//IL_0336: Expected O, but got Unknown
		//IL_0342: Expected O, but got I
		//IL_034b: Expected O, but got I4
		//IL_0354: Expected O, but got I4
		//IL_055e: Expected O, but got I
		//IL_057a: Expected O, but got I4
		//IL_0429: Expected O, but got I
		//IL_0445: Expected O, but got I4
		//IL_05b4: Expected O, but got I4
		//IL_0482: Expected O, but got I4
		//IL_05e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ea: Expected O, but got Unknown
		//IL_0603: Expected O, but got I4
		//IL_03c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c8: Expected O, but got Unknown
		//IL_04de: Expected O, but got I4
		//IL_03ad: Expected I4, but got O
		//IL_03b5: Expected I4, but got O
		object obj = 152985600;
		object obj2 = typeof(System.Formats.Asn1.SetOfValueComparer) + 2376;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6FD6]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v47+E4]");
			if ((nint)0 != 0)
			{
				goto IL_007d;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v47+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 != null)
			{
				goto IL_007d;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45C1]");
		object obj6 = (nint)0 & (nint)1;
		if (obj6 == null)
		{
			goto IL_00bb;
		}
		goto IL_06b6;
		IL_0628:
		NullReferenceException ex = new NullReferenceException();
		goto IL_0636;
		IL_0636:
		object obj7 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 4024;
		object obj8 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v376 @ X0_v11+E4]");
		bool flag2 = (nint)0 == 0;
		object obj9 = !flag2;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		string text = Uri.UnescapeDataString((string)(object)((Exception)ex)._innerException);
		return (Dictionary<string, string>)(object)new NullReferenceException();
		IL_01e2:
		Dictionary<object, object> dictionary = default(Dictionary<object, object>);
		string stringToUnescape;
		StringSplitOptions stringSplitOptions;
		if (query != null)
		{
			object value = "<ds.DataTable.OnColumnChanging|INFO> {0}" + 1120;
			bool flag3 = query.StartsWith((string)value);
			bool flag4 = !flag3;
			string text2 = query;
			int num;
			if (!flag4)
			{
				string text3 = query.Substring(1);
				bool flag5 = text3 == null;
				text2 = text3;
				num = 1;
				stringSplitOptions = StringSplitOptions.None;
				if (flag5)
				{
					goto IL_0628;
				}
			}
			string[] array = text2.Split('&');
			bool flag6 = array == null;
			object obj10 = 0;
			num = 38;
			stringSplitOptions = StringSplitOptions.None;
			if (!flag6)
			{
				object obj11 = array + 32;
				if (dictionary != null)
				{
					if (array.Length < 1)
					{
						goto IL_0623;
					}
					object obj12 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 4024;
					object obj13 = (nint)0 + (nint)800;
					object obj14 = 0;
					obj10 = 0;
					num = 38;
					stringSplitOptions = StringSplitOptions.None;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v196 @ X23_v7+v248 @ X24_v8*8]");
						if ((nint)0 == 0)
						{
							break;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v196 @ X23_v7+v248 @ X24_v8*8]");
						string[] array2 = ((string)0).Split('=');
						bool flag7 = array2 == null;
						obj10 = 0;
						num = 61;
						stringSplitOptions = StringSplitOptions.None;
						if (flag7)
						{
							break;
						}
						bool flag8 = array2.Length != 2;
						obj10 = 0;
						num = 61;
						stringSplitOptions = StringSplitOptions.None;
						if (!flag8)
						{
							stringToUnescape = array2[1];
							object obj15 = obj12;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v413 @ X0_v30+E4]");
							bool flag9 = (nint)0 == 0;
							object obj16 = !flag9;
							if (obj16 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							string text4 = Uri.UnescapeDataString(stringToUnescape);
							obj10 = obj13;
							dictionary.set_Item((object)array2[0], (object)text4);
							num = (int)array2[0];
							stringSplitOptions = (StringSplitOptions)text4;
						}
						obj14++;
						if ((nint)obj14 < array.Length)
						{
							continue;
						}
						goto IL_0623;
					}
				}
				else
				{
					if (array.Length < 1)
					{
						goto IL_0623;
					}
					obj10 = 0;
					num = 38;
					stringSplitOptions = StringSplitOptions.None;
					object obj17 = 0;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v196 @ X23_v7+v307 @ X21_v9*8]");
						if ((nint)0 == 0)
						{
							break;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v196 @ X23_v7+v307 @ X21_v9*8]");
						string[] array3 = ((string)0).Split('=');
						bool flag10 = array3 == null;
						obj10 = 0;
						num = 61;
						stringSplitOptions = StringSplitOptions.None;
						if (flag10)
						{
							break;
						}
						bool flag11 = array3.Length == 2;
						obj10 = 0;
						num = 61;
						stringSplitOptions = StringSplitOptions.None;
						ex = (NullReferenceException)(object)array3;
						if (!flag11)
						{
							obj17++;
							bool flag12 = (nint)obj17 < array.Length;
							obj10 = 0;
							num = 61;
							stringSplitOptions = StringSplitOptions.None;
							if (flag12)
							{
								continue;
							}
							goto IL_0623;
						}
						goto IL_0636;
					}
				}
			}
		}
		goto IL_0628;
		IL_007d:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45C1]");
		object obj18 = (nint)0 & (nint)1;
		bool flag13 = obj18 == null;
		object obj19 = !flag13;
		if (obj19 == null)
		{
			goto IL_00bb;
		}
		goto IL_06b6;
		IL_00bb:
		_ = 1;
		goto IL_06b6;
		IL_06b6:
		object obj20 = typeof(ConditionalWeakTable<System.Net.HttpWebRequest, Mono.Http.NtlmSession>.CreateValueCallback) + 2808;
		object obj21 = (nint)0 + (nint)704;
		stringToUnescape = (string)(typeof(System.Formats.Asn1.SetOfValueComparer) + 2536);
		object obj22 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X0_v3+E4]");
		bool flag14 = (nint)0 == 0;
		object obj23 = !flag14;
		if (obj23 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj22 = obj2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X0_v3+B8]");
		object obj24 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		stringSplitOptions = (StringSplitOptions)obj21;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X8_v4+18]");
		dictionary..ctor((IEqualityComparer<object>)0);
		nint num2 = (nint)stringToUnescape;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X0_v6 (Il2CppClass<System.String>)+E4]");
		if ((nint)0 != 0)
		{
			bool flag15 = StringsExtensions.IsNullOrEmpty(query);
			bool flag16 = !flag15;
			int num = 0;
			if (flag16)
			{
				goto IL_01e2;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag17 = StringsExtensions.IsNullOrEmpty(query);
			bool flag18 = !flag17;
			object obj25 = !flag18;
			int num = 0;
			if (obj25 == null)
			{
				goto IL_01e2;
			}
		}
		goto IL_0623;
		IL_0623:
		return (Dictionary<string, string>)(object)dictionary;
	}

	private static IInviteData DecodeInviteLink(Uri uri)
	{
		if ((object)uri != null)
		{
			string query = uri.Query;
			if (query != null)
			{
				string encodedData = query.Substring(1);
				return DecodeInviteData(encodedData);
			}
		}
		return (IInviteData)new NullReferenceException();
	}

	private void HandleInvite(IInviteData inviteData)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_0149: Expected O, but got I4
		//IL_008a: Expected O, but got I
		//IL_01cf: Expected O, but got I4
		//IL_0177: Expected O, but got I
		//IL_0191: Expected O, but got I4
		//IL_00ec: Expected O, but got I
		//IL_0207: Expected O, but got I
		//IL_0258: Unknown result type (might be due to invalid IL or missing references)
		//IL_025d: Expected O, but got Unknown
		//IL_026d: Expected I, but got O
		//IL_0296: Expected O, but got I4
		//IL_02fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0302: Expected O, but got Unknown
		//IL_0333: Expected O, but got I4
		//IL_039a: Unknown result type (might be due to invalid IL or missing references)
		//IL_039f: Expected O, but got Unknown
		//IL_03d0: Expected O, but got I4
		//IL_02ca: Expected O, but got I
		//IL_0437: Unknown result type (might be due to invalid IL or missing references)
		//IL_043c: Expected O, but got Unknown
		//IL_046d: Expected O, but got I4
		//IL_0367: Expected O, but got I
		//IL_0404: Expected O, but got I
		//IL_04a1: Expected O, but got I
		//IL_0519: Expected O, but got I4
		object obj = typeof(RegisteredWaitHandle) + 3136;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6FD7]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v16+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v16+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE4588]");
		object obj5 = (nint)0 & (nint)1;
		bool flag2 = obj5 == null;
		object obj6 = !flag2;
		if (obj6 != null)
		{
			goto IL_00a7;
		}
		goto IL_019f;
		IL_022c:
		if (inviteData == null)
		{
			return;
		}
		object obj7 = typeof(RegisteredWaitHandle) + 1400;
		object obj8 = obj7;
		nint num = (nint)inviteData;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ X8_v6 (Il2CppClass<IInviteData>)+130]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X10_v2+130]");
		bool flag3 = num2 < 0;
		object obj9 = !flag3;
		object obj10 = ~obj9;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ X8_v6 (Il2CppClass<IInviteData>)+C8]");
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X10_v2+130]");
			object obj11 = num3 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v305 @ X11_v13-8]");
			if (0 == (nint)obj8)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [inviteData @ X1 (IInviteData)+10]");
				if ((nint)0 != 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [inviteData @ X1 (IInviteData)+10]");
					bool flag4 = (nint)0 == 0;
					object obj12 = !flag4;
					if (obj12 == null)
					{
						TryJoinGame((RoomInviteData)inviteData);
					}
				}
				else
				{
					TryJoinTournament((RoomInviteData)inviteData);
				}
				return;
			}
		}
		object obj13 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1376;
		object obj14 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ X8_v6 (Il2CppClass<IInviteData>)+130]");
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v238 @ X10_v5+130]");
		bool flag5 = num4 < 0;
		object obj15 = !flag5;
		object obj16 = ~obj15;
		if (obj16 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ X8_v6 (Il2CppClass<IInviteData>)+C8]");
			nint num5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v238 @ X10_v5+130]");
			object obj17 = num5 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v338 @ X11_v11-8]");
			if (0 == (nint)obj14)
			{
				TryAddFriend((FriendInviteData)inviteData);
				return;
			}
		}
		object obj18 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 3816;
		object obj19 = obj18;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ X8_v6 (Il2CppClass<IInviteData>)+130]");
		nint num6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ X10_v8+130]");
		bool flag6 = num6 < 0;
		object obj20 = !flag6;
		object obj21 = ~obj20;
		if (obj21 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ X8_v6 (Il2CppClass<IInviteData>)+C8]");
			nint num7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ X10_v8+130]");
			object obj22 = num7 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v363 @ X11_v9-8]");
			if (0 == (nint)obj19)
			{
				TryJoinMassTournament((MassTournamentInviteData)inviteData);
				return;
			}
		}
		object obj23 = typeof(System.Formats.Asn1.SetOfValueComparer) + 3688;
		object obj24 = obj23;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ X8_v6 (Il2CppClass<IInviteData>)+130]");
		nint num8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X10_v11+130]");
		bool flag7 = num8 < 0;
		object obj25 = !flag7;
		object obj26 = ~obj25;
		if (obj26 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ X8_v6 (Il2CppClass<IInviteData>)+C8]");
			nint num9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X10_v11+130]");
			object obj27 = num9 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v378 @ X8_v8-8]");
			if (0 == (nint)obj24)
			{
				TryShowTVCreateGamePopup((TVCreateGamePopupInviteData)inviteData);
			}
		}
		return;
		IL_00dc:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X0_v34+B8]");
		object obj28 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X8_v22+18]");
		if ((nint)0 == 4)
		{
			return;
		}
		goto IL_022c;
		IL_01e5:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj29 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X0_v10+B8]");
		object obj30 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X8_v12+18]");
		if ((nint)0 != 4)
		{
			goto IL_022c;
		}
		return;
		IL_0074:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE4588]");
		object obj31 = (nint)0 & (nint)1;
		if (obj31 != null)
		{
			goto IL_00a7;
		}
		goto IL_019f;
		IL_019f:
		_ = 1;
		object obj32 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X0_v34+E4]");
		bool flag8 = (nint)0 == 0;
		object obj33 = !flag8;
		object obj34 = obj32;
		if (obj33 != null)
		{
			goto IL_00dc;
		}
		goto IL_01e5;
		IL_00a7:
		obj32 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X0_v34+E4]");
		bool flag9 = (nint)0 == 0;
		obj34 = obj32;
		if (!flag9)
		{
			goto IL_00dc;
		}
		goto IL_01e5;
	}

	private static void TryJoinGame(RoomInviteData roomInviteData)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Expected O, but got Unknown
		//IL_0066: Expected O, but got I
		//IL_0081: Expected I, but got O
		//IL_00a7: Expected O, but got I
		object obj = typeof(DebugUI.BitField) + 392;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = obj2 + 16;
		obj3 = roomInviteData;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj4 = obj3;
		object obj5 = typeof(SqlSingle[]) + 2376;
		object obj6 = (nint)0 + (nint)1896;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(obj2, (IntPtr)obj6);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X8_v4+18]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X8_v4+20]");
		SfsConnectionManager.SwitchGame((string)num, Games.Baloot, action);
	}

	private void TryJoinTournament(RoomInviteData roomInviteData)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected O, but got Unknown
		//IL_0088: Expected O, but got I
		//IL_00a3: Expected I, but got O
		//IL_00c9: Expected O, but got I
		object obj = typeof(DebugUI.BitField) + 400;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = obj2 + 16;
		obj3 = roomInviteData;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj4 = obj2 + 24;
		obj4 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj5 = obj3;
		object obj6 = typeof(SqlSingle[]) + 2376;
		object obj7 = (nint)0 + (nint)1904;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(obj2, (IntPtr)obj7);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X8_v4+18]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X8_v4+20]");
		SfsConnectionManager.SwitchGame((string)num, Games.Baloot, action);
	}

	private void TryAddFriend(FriendInviteData inviteData)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected O, but got Unknown
		//IL_00bb: Expected O, but got I4
		//IL_0244: Unknown result type (might be due to invalid IL or missing references)
		//IL_0249: Expected O, but got Unknown
		//IL_0255: Expected O, but got I
		//IL_0264: Unknown result type (might be due to invalid IL or missing references)
		//IL_0269: Expected O, but got Unknown
		//IL_0284: Expected I, but got O
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Expected O, but got Unknown
		//IL_0147: Expected O, but got I4
		//IL_02b3: Expected O, but got I4
		//IL_0170: Expected O, but got I
		//IL_01d4: Expected O, but got I4
		object obj = typeof(DebugUI.BitField) + 408;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
		object obj4 = obj2 + 16;
		obj4 = inviteData;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj5 = obj2 + 24;
		obj5 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj6 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X0_v12+E4]");
		DeepLinkingManager deepLinkingManager;
		if ((nint)0 != 0)
		{
			bool isInitialized = Config.IsInitialized;
			bool flag = !isInitialized;
			object obj7 = !flag;
			if (obj7 != null)
			{
				goto IL_0109;
			}
			deepLinkingManager = this;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool isInitialized2 = Config.IsInitialized;
			bool flag2 = !isInitialized2;
			deepLinkingManager = this;
			if (!flag2)
			{
				goto IL_0109;
			}
		}
		goto IL_0235;
		IL_0235:
		object obj8 = typeof(SqlSingle[]) + 2376;
		object obj9 = (nint)0 + (nint)1912;
		object obj10 = typeof(RegisteredWaitHandle) + 3136;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(obj2, (IntPtr)obj9);
		object obj11 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X0_v16+E4]");
		bool flag3 = (nint)0 == 0;
		object obj12 = !flag3;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		ScreenManager.WaitForScene(Scenes.Menu, action);
		return;
		IL_0109:
		object obj13 = typeof(Queue<string>) + 848;
		object obj14 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X0_v21+E4]");
		bool flag4 = (nint)0 == 0;
		object obj15 = !flag4;
		if (obj15 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj16 = (nint)0 + (nint)2200;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel = default(SessionModel);
		bool isConnected = sessionModel.IsConnected;
		bool flag5 = !isConnected;
		deepLinkingManager = null;
		if (!flag5)
		{
			object obj17 = obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ X0_v26+E4]");
			bool flag6 = (nint)0 == 0;
			object obj18 = !flag6;
			if (obj18 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			SessionModel sessionModel2 = default(SessionModel);
			bool isInLobby = sessionModel2.IsInLobby;
			bool flag7 = !isInLobby;
			deepLinkingManager = null;
			if (!flag7)
			{
				((<>c__DisplayClass16_0)obj2).<TryAddFriend>g__AddFriendAction|0();
				return;
			}
		}
		goto IL_0235;
	}

	private static void TryJoinMassTournament(MassTournamentInviteData inviteData)
	{
		//IL_0011: Expected O, but got I
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected O, but got Unknown
		//IL_0061: Expected O, but got I4
		object obj = (nint)0 + (nint)2744;
		object obj2 = typeof(RegisteredWaitHandle) + 1552;
		System.Int32Enum? game = (System.Int32Enum)inviteData.<Game>k__BackingField;
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		RoutingManager.Route(RoutingCommand.MassTournamentWithCode, inviteData.<Payload>k__BackingField, (Games?)game);
	}

	private static void TryShowTVCreateGamePopup(TVCreateGamePopupInviteData inviteData)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Expected O, but got Unknown
		//IL_0066: Expected O, but got I
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Expected O, but got Unknown
		//IL_0095: Expected I, but got O
		//IL_00bb: Expected O, but got I
		object obj = typeof(DebugUI.BitField) + 416;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = obj2 + 16;
		obj3 = inviteData;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj4 = obj3;
		object obj5 = typeof(SqlSingle[]) + 2376;
		object obj6 = (nint)0 + (nint)1920;
		object obj7 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(obj2, (IntPtr)obj6);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X8_v4+10]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X8_v4+18]");
		SfsConnectionManager.SwitchGame((string)num, Games.Baloot, action);
		ITrackEvent trackEvent = TrackerLibrary.TVInviteDeepLinkOpened();
		object obj8 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X8_v5+E4]");
		if ((nint)0 != 0)
		{
			Tracker.DesignEvent(trackEvent);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Tracker.DesignEvent(trackEvent);
	}

	private void NotifyAddition(KammelnaResponseModel<PlayerProfileModel> response)
	{
		//IL_004b: Expected O, but got I
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected O, but got Unknown
		//IL_003e: Expected O, but got I4
		bool succeeded = ((KammelnaResponseModel<object>)(object)response).Succeeded;
		if (succeeded)
		{
			((DeepLinkingManager)succeeded).ShowProfile(response.<Model>k__BackingField);
			return;
		}
		object obj = (nint)0 + (nint)1312;
		string errorMessage = ((KammelnaResponseModel<object>)(object)response).ErrorMessage;
		object obj2 = typeof(System.Buffers.Text.ParserHelpers) + 1432;
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X8_v9+E4]");
		if ((nint)0 != 0)
		{
			PopupWindow.ShowError(errorMessage);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		PopupWindow.ShowError(errorMessage);
	}

	private void ShowProfile(PlayerProfileModel userProfileModel)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0162: Expected O, but got I4
		//IL_0094: Expected O, but got I4
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Expected O, but got Unknown
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Expected O, but got Unknown
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Expected O, but got Unknown
		//IL_00fe: Expected O, but got I4
		//IL_01a7: Expected O, but got I4
		//IL_01b0: Expected O, but got I4
		object obj = 152985600;
		object obj2 = typeof(MemberAchievementClanFeedData) + 840;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6FDE]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v3+E4]");
			if ((nint)0 != 0)
			{
				goto IL_007d;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 != null)
			{
				goto IL_007d;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		MiniProfilePopup.Show(userProfileModel, TrackingPlacement.Routing);
		bool flag2 = userProfileModel == null;
		object obj6 = !flag2;
		object obj7 = 0;
		TrackingPlacement trackingPlacement = TrackingPlacement.Routing;
		if (obj6 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_00a2;
		IL_007d:
		MiniProfilePopup.Show(userProfileModel, TrackingPlacement.Routing);
		obj7 = 0;
		trackingPlacement = TrackingPlacement.Routing;
		goto IL_00a2;
		IL_00a2:
		object obj8 = typeof(System.Buffers.Text.ParserHelpers) + 1432;
		object body = "Unsupported map type" + 3648;
		object buttonText = "Network Authentication Required" + 3128;
		object obj9 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X0_v20+E4]");
		bool flag3 = (nint)0 == 0;
		object obj10 = !flag3;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		PopupWindow.ShowInfo(userProfileModel.<userName>k__BackingField, (string)body, (string)buttonText);
	}

	private static void ShowMessage(string message)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		if (ScreenUtility.IsTablet)
		{
			object obj = typeof(System.Buffers.Text.ParserHelpers) + 1432;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v5+E4]");
			if ((nint)0 != 0)
			{
				PopupWindow.ShowLoading(message);
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			PopupWindow.ShowLoading(message);
		}
		else
		{
			SplashAnimation.SetStatusMessage(message);
		}
	}

	private static IInviteData DecodeInviteData(string encodedData)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0105: Expected O, but got I4
		//IL_011d: Expected I, but got O
		//IL_0084: Expected O, but got I4
		//IL_0099: Expected I, but got O
		//IL_01d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01da: Expected O, but got Unknown
		//IL_0208: Expected O, but got I
		string encodedData2 = default(string);
		string text = DecodeString(encodedData2);
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3016;
		string value = text.Substring(0, 1);
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v4+E4]");
		int num;
		object obj3;
		int num3;
		if ((nint)0 != 0)
		{
			num = Convert.ToInt32(value);
			bool flag = num < 2;
			obj3 = !flag;
			bool flag2 = num > 2;
			nint num2 = unchecked((nint)null);
			num3 = num;
			if (!flag2)
			{
				goto IL_00af;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			num = Convert.ToInt32(value);
			bool flag3 = num < 2;
			obj3 = !flag3;
			bool flag4 = num <= 2;
			nint num2 = unchecked((nint)null);
			num3 = num;
			if (flag4)
			{
				goto IL_00af;
			}
		}
		switch (num3)
		{
		case 4:
			return TVCreateGamePopupInviteData.Parse(text);
		case 3:
			return MassTournamentInviteData.Parse(text);
		}
		goto IL_01c6;
		IL_01c6:
		object obj4 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 656;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		ArgumentOutOfRangeException ex = default(ArgumentOutOfRangeException);
		ex..ctor();
		object obj5 = (nint)0 + (nint)1936;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		return (IInviteData)new OutOfMemoryException();
		IL_00af:
		if (obj3 == null)
		{
			return RoomInviteData.Parse(text);
		}
		if (num == 2)
		{
			return FriendInviteData.Parse(text);
		}
		goto IL_01c6;
	}

	private static string EncodedString(string data)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0021: Expected I, but got O
		//IL_005c: Expected O, but got I4
		Encoding uTF = Encoding.UTF8;
		if (uTF != null)
		{
			object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3016;
			nint num = (nint)uTF;
			byte[] bytes = uTF.GetBytes(data);
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v5+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			string text = Convert.ToBase64String(bytes);
			if (text != null)
			{
				int index = text._stringLength - 2;
				char c = text.get_Chars(index);
				if (c == '=')
				{
					int length = text._stringLength - 2;
					return text.Substring(0, length);
				}
				int index2 = text._stringLength - 1;
				char c2 = text.get_Chars(index2);
				if (c2 == '=')
				{
					int length2 = text._stringLength - 1;
					return text.Substring(0, length2);
				}
				return text;
			}
		}
		return (string)(object)new NullReferenceException();
	}

	private static string DecodeString(string encodedData)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0039: Expected O, but got I4
		//IL_0041: Expected I4, but got O
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Expected O, but got Unknown
		//IL_00c7: Expected O, but got I4
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Expected O, but got Unknown
		//IL_0116: Unsupported input type for neg.
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Expected I4, but got Unknown
		//IL_0081: Expected O, but got I4
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Expected O, but got Unknown
		//IL_0286: Expected O, but got I4
		//IL_013a: Expected O, but got I4
		//IL_0256: Expected O, but got I4
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_0157: Expected O, but got Unknown
		//IL_01b1: Expected I, but got O
		//IL_01c1: Expected O, but got I
		//IL_01d1: Expected O, but got I
		if (encodedData == null)
		{
			goto IL_01db;
		}
		object obj = "<ds.DataTable.OnColumnChanging|INFO> {0}" + 1120;
		bool flag = encodedData.StartsWith((string)obj);
		bool flag2 = !flag;
		object obj2 = 0;
		int num = (int)obj;
		string text = encodedData;
		if (!flag2)
		{
			string text2 = encodedData.Substring(1);
			bool flag3 = text2 == null;
			obj2 = 0;
			num = 1;
			text = text2;
			if (flag3)
			{
				goto IL_01db;
			}
		}
		object obj3 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3016;
		object obj4 = -text._stringLength;
		object obj5 = obj4 & 3;
		int num2 = text._stringLength & 3;
		if (0 >= text._stringLength)
		{
			num2 = 0 - obj5;
		}
		object obj6;
		string text3;
		if (num2 != 2)
		{
			bool flag4 = num2 != 3;
			text3 = (string)num;
			if (flag4)
			{
				goto IL_0223;
			}
			obj6 = "<ds.DataTable.OnColumnChanging|INFO> {0}" + 800;
		}
		else
		{
			obj6 = "<ds.DataTable.OnColumnChanging|INFO> {0}" + 816;
		}
		text3 = (string)obj6;
		string text4 = text + (string)obj6;
		obj2 = 0;
		text = text4;
		goto IL_0223;
		IL_01db:
		return (string)(object)new NullReferenceException();
		IL_0223:
		Encoding uTF = Encoding.UTF8;
		object obj7 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ X0_v12+E4]");
		bool flag5 = (nint)0 == 0;
		object obj8 = !flag5;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		byte[] array = Convert.FromBase64String(text);
		if (uTF != null)
		{
			nint num3 = (nint)uTF;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ X8_v12 (Il2CppClass<System.Text.Encoding>)+378]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ X8_v12 (Il2CppClass<System.Text.Encoding>)+380]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v138 @ X3_v1 (should have been resolved before IL gen)");
		}
		goto IL_01db;
	}
}
