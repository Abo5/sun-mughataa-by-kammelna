using System;
using System.Buffers.Text;
using System.ComponentModel;
using System.Diagnostics;
using System.Formats.Asn1;
using System.Runtime.Remoting.Messaging;
using System.Threading;
using Cpp2ILInjected;
using Kammelna.Server;
using Kammelna.Server.Models.Clans;
using Sfs2X.Entities.Data;
using UnityEngine;
using UnityEngine.Rendering;
using Util;

public class FriendlyChallengeInvitesManager : MonoBehaviour
{
	private sealed class <>c__DisplayClass10_0
	{
		public int playerId;

		internal void <OnCreateChallengeClick>b__0(CreateChallengePopup popup)
		{
			popup.Popup(playerId);
		}
	}

	private sealed class <>c__DisplayClass9_0
	{
		public Action<ChallengeStatusData, FriendlyChallengeInviteError?> callback;

		internal void <SendCheckChallengeStatus>b__0(ISFSObject data)
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0023: Unknown result type (might be due to invalid IL or missing references)
			//IL_0028: Expected O, but got Unknown
			//IL_0030: Expected I, but got O
			//IL_0040: Expected O, but got I
			//IL_00d6: Expected O, but got I
			//IL_022a: Unknown result type (might be due to invalid IL or missing references)
			//IL_022f: Expected O, but got Unknown
			//IL_0243: Unknown result type (might be due to invalid IL or missing references)
			//IL_0248: Expected O, but got Unknown
			//IL_0252: Unknown result type (might be due to invalid IL or missing references)
			//IL_0257: Expected O, but got Unknown
			//IL_007b: Expected O, but got I
			//IL_010d: Expected I, but got O
			//IL_011d: Expected O, but got I
			//IL_01b1: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b6: Expected O, but got Unknown
			//IL_01be: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c3: Expected O, but got Unknown
			//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d1: Expected O, but got Unknown
			//IL_01e1: Expected O, but got I
			//IL_0205: Expected O, but got I4
			//IL_0280: Expected O, but got I
			//IL_0290: Expected O, but got I
			//IL_02a0: Expected O, but got I
			//IL_0158: Expected O, but got I
			//IL_0089: Unknown result type (might be due to invalid IL or missing references)
			//IL_008e: Expected O, but got Unknown
			//IL_0097: Unknown result type (might be due to invalid IL or missing references)
			//IL_009c: Expected O, but got Unknown
			//IL_02b3: Unknown result type (might be due to invalid IL or missing references)
			//IL_02b8: Expected O, but got Unknown
			//IL_02c0: Unknown result type (might be due to invalid IL or missing references)
			//IL_02c5: Expected O, but got Unknown
			//IL_02ce: Unknown result type (might be due to invalid IL or missing references)
			//IL_02d3: Expected O, but got Unknown
			//IL_0166: Unknown result type (might be due to invalid IL or missing references)
			//IL_016b: Expected O, but got Unknown
			//IL_0174: Unknown result type (might be due to invalid IL or missing references)
			//IL_0179: Expected O, but got Unknown
			object obj = typeof(System.IOAsyncCallback) + 976;
			object obj2 = "destinationTimeZone" + 2696;
			nint num = (nint)data;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X8_v4 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X8_v4 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_00bc;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X8_v4 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
			object obj4 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ X10_v13-8]");
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
				goto IL_00bc;
			}
			object obj5 = obj4 + 1;
			object obj6 = num + obj5;
			object obj7 = obj6 + 312;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v260 @ X0_v35+8]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v260 @ X0_v35] (should have been resolved before IL gen)");
			object obj9 = default(object);
			bool flag = obj9 == null;
			object obj10 = !flag;
			object obj11 = obj2;
			if (obj10 != null)
			{
				goto IL_0105;
			}
			goto IL_021b;
			IL_0105:
			nint num2 = (nint)data;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v286 @ X8_v13 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
			object obj12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v286 @ X8_v13 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0199;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v286 @ X8_v13 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
			object obj13 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v343 @ X10_v8-8]");
				if (0 == (nint)obj)
				{
					break;
				}
				obj13 += 16;
				obj12--;
				if ((nint)obj12 != 1)
				{
					continue;
				}
				goto IL_0199;
			}
			goto IL_02aa;
			IL_02aa:
			object obj14 = obj13 + 18;
			object obj15 = num2 + obj14;
			object obj16 = obj15 + 312;
			goto IL_032b;
			IL_032b:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v369 @ X0_v21] (should have been resolved before IL gen)");
			string errorString = default(string);
			FriendlyChallengeInviteError value = ParseInviteError(errorString);
			Action<ChallengeStatusData, FriendlyChallengeInviteError?> action = callback;
			System.Int32Enum? int32Enum = (System.Int32Enum)value;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v139 @ X19_v4 (System.Action`2<ChallengeStatusData, System.Nullable`1<FriendlyChallengeInviteError>>)+18] (should have been resolved before IL gen)");
			return;
			IL_0199:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			goto IL_032b;
			IL_00bc:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ X0_v32+8]");
			obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v172 @ X0_v32] (should have been resolved before IL gen)");
			object obj17 = default(object);
			bool flag2 = obj17 == null;
			obj11 = obj2;
			if (!flag2)
			{
				goto IL_0105;
			}
			goto IL_021b;
			IL_021b:
			object obj18 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 568;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object varName = "destinationTimeZone" + 3992;
			object varName2 = "destinationTimeZone" + 4048;
			object obj19 = default(object);
			obj19..ctor();
			int num3 = SFSExtensions.Get(data, (string)varName, 0);
			bool flag3 = SFSExtensions.Get(data, (string)varName2, defaultValue: false);
			Action<ChallengeStatusData, FriendlyChallengeInviteError?> action2 = callback;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X8_v10 (System.Action`2<ChallengeStatusData, System.Nullable`1<FriendlyChallengeInviteError>>)+18]");
			object obj20 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X8_v10 (System.Action`2<ChallengeStatusData, System.Nullable`1<FriendlyChallengeInviteError>>)+40]");
			object obj21 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X8_v10 (System.Action`2<ChallengeStatusData, System.Nullable`1<FriendlyChallengeInviteError>>)+28]");
			object obj22 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v208 @ X4_v1 (should have been resolved before IL gen)");
			goto IL_02aa;
		}
	}

	private static FriendlyChallengeInvitesManager _instance;

	private ChallengeEventsChannel eventsChannel;

	private ComponentReference<CreateChallengePopup> createChallengeRef;

	private void Awake()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_01fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0200: Expected O, but got Unknown
		//IL_020f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0214: Expected O, but got Unknown
		//IL_0220: Expected O, but got I
		//IL_022f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0234: Expected O, but got Unknown
		//IL_0268: Expected O, but got I4
		//IL_0288: Unknown result type (might be due to invalid IL or missing references)
		//IL_028d: Expected O, but got Unknown
		//IL_0299: Expected O, but got I
		//IL_02a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a8: Expected O, but got Unknown
		//IL_02b4: Expected O, but got I
		//IL_0048: Expected I, but got O
		//IL_0077: Expected O, but got I4
		//IL_00d1: Expected I, but got O
		//IL_0113: Expected I, but got O
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Expected O, but got Unknown
		//IL_0162: Expected O, but got I
		//IL_0170: Expected I, but got O
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0184: Expected O, but got Unknown
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ae: Expected O, but got Unknown
		//IL_01c9: Expected O, but got I
		//IL_01d7: Expected I, but got O
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		object obj2 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1488;
		object obj3 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2360;
		object obj4 = (nint)0 + (nint)2624;
		object obj5 = typeof(System.Formats.Asn1.SetOfValueComparer) + 72;
		GameObject gameObject = base.gameObject;
		object obj6 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X8_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj7 = !flag;
		UnityEngine.Object target = gameObject;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			target = gameObject;
		}
		object command = "destinationTimeZone" + 3976;
		object obj8 = (nint)0 + (nint)2632;
		object command2 = "destinationTimeZone" + 4016;
		object obj9 = (nint)0 + (nint)2616;
		UnityEngine.Object.DontDestroyOnLoad(target);
		object obj10 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		GameObject go = base.gameObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj4);
		object obj11 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X0_v11+E4]");
		bool flag2 = (nint)0 == 0;
		object obj12 = !flag2;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		SfsRequestListener.AddListener(go, (string)command, onlyOnce: false, action);
		GameObject go2 = base.gameObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action2 = default(Action<object>);
		action2..ctor((object)this, (IntPtr)obj8);
		SfsRequestListener.AddListener(go2, (string)command2, onlyOnce: false, action2);
		GameObject go3 = base.gameObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action3 = default(Action<object>);
		action3..ctor((object)this, (IntPtr)obj9);
		object command3 = "destinationTimeZone" + 3920;
		SfsRequestListener.AddListener(go3, (string)command3, onlyOnce: false, action3);
		GameObject go4 = base.gameObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj13 = (nint)0 + (nint)2608;
		Action<object> action4 = default(Action<object>);
		action4..ctor((object)this, (IntPtr)obj13);
		object command4 = "destinationTimeZone" + 3944;
		SfsRequestListener.AddListener(go4, (string)command4, onlyOnce: false, action4);
		object obj14 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2416;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj15 = (nint)0 + (nint)2600;
		Action<int> action5 = default(Action<int>);
		action5..ctor((object)this, (IntPtr)obj15);
		eventsChannel.OnChallengeCreateStarted += action5;
	}

	private void OnDestroy()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_004d: Expected I, but got O
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2416;
		object obj2 = (nint)0 + (nint)2600;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<int> action = default(Action<int>);
		action..ctor((object)this, (IntPtr)obj2);
		eventsChannel.OnChallengeCreateStarted -= action;
	}

	public static void SendChallengeInvite(int userId, FriendlyChallengeRoomConfig config)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		object key = "destinationTimeZone" + 3968;
		object command = "destinationTimeZone" + 3976;
		ISFSObject iSFSObject = config.ToSfsObject();
		SFSExtensions.Put(iSFSObject, (string)key, userId);
		SFS.SendZoneExtensionRequest((string)command, iSFSObject);
	}

	public static void SendAcceptChallenge(int challengerId)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		object obj = typeof(RegisteredWaitHandle) + 2040;
		object key = "destinationTimeZone" + 3936;
		object key2 = "___# Content push apply failed [{0}]: {1}" + 3000;
		object command = "destinationTimeZone" + 4016;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		SFSObject sFSObject = default(SFSObject);
		sFSObject..ctor();
		SFSExtensions.Put(sFSObject, (string)key, challengerId);
		SFSExtensions.Put(sFSObject, (string)key2, val: true);
		SFS.SendZoneExtensionRequest((string)command, sFSObject);
	}

	public static void SendRejectChallenge(int challengerId)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		object obj = typeof(RegisteredWaitHandle) + 2040;
		object key = "destinationTimeZone" + 3936;
		object key2 = "___# Content push apply failed [{0}]: {1}" + 3000;
		object command = "destinationTimeZone" + 4016;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		SFSObject sFSObject = default(SFSObject);
		sFSObject..ctor();
		SFSExtensions.Put(sFSObject, (string)key, challengerId);
		SFSExtensions.Put(sFSObject, (string)key2, val: false);
		SFS.SendZoneExtensionRequest((string)command, sFSObject);
	}

	public static void SendCancelChallenge()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object command = "destinationTimeZone" + 3944;
		SFS.SendZoneExtensionRequest((string)command);
	}

	public static void SendCheckChallengeStatus(int defenderId, Action<ChallengeStatusData, FriendlyChallengeInviteError?> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected O, but got Unknown
		//IL_00b6: Expected O, but got I
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Expected O, but got Unknown
		//IL_00db: Expected O, but got I
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Expected O, but got Unknown
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Expected O, but got Unknown
		//IL_012b: Expected I, but got O
		//IL_0155: Expected O, but got I4
		object obj = typeof(DebugUI.BitField) + 3168;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(RegisteredWaitHandle) + 2040;
		object key = "destinationTimeZone" + 3968;
		object obj4 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1488;
		object obj5 = obj2 + 16;
		obj5 = callback;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		SFSObject sFSObject = default(SFSObject);
		sFSObject..ctor();
		SFSExtensions.Put(sFSObject, (string)key, defenderId);
		object obj6 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X8_v4+B8]");
		object obj7 = 0;
		object obj8 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2360;
		object obj9 = (nint)0 + (nint)720;
		object obj10 = typeof(System.Formats.Asn1.SetOfValueComparer) + 72;
		object command = "destinationTimeZone" + 4040;
		GameObject go = ((UnityEngine.Component)obj7).gameObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor(obj2, (IntPtr)obj9);
		object obj11 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ X0_v16+E4]");
		bool flag = (nint)0 == 0;
		object obj12 = !flag;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		SfsRequestListener.SendZoneRequest(go, (string)command, sFSObject, keepListening: false, action);
	}

	private void OnCreateChallengeClick(int playerId)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_0059: Expected O, but got I
		//IL_0079: Expected I, but got O
		//IL_00a8: Expected O, but got I4
		object obj = typeof(DebugUI.BitField) + 3160;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1736;
		object obj4 = (nint)0 + (nint)712;
		object obj5 = typeof(System.Buffers.Text.ParserHelpers) + 1616;
		object obj6 = (nint)0 + (nint)2000;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor(obj2, (IntPtr)obj4);
		object obj7 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X0_v7+E4]");
		bool flag = (nint)0 == 0;
		object obj8 = !flag;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2F80CF4");
	}

	private void ProcessInviteCallback(ISFSObject data)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0030: Expected I, but got O
		//IL_0040: Expected O, but got I
		//IL_007b: Expected O, but got I
		//IL_00f5: Expected I, but got O
		//IL_0105: Expected O, but got I
		//IL_0199: Unknown result type (might be due to invalid IL or missing references)
		//IL_019e: Expected O, but got Unknown
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ab: Expected O, but got Unknown
		//IL_01b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b9: Expected O, but got Unknown
		//IL_01dd: Expected O, but got I4
		//IL_0140: Expected O, but got I
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Expected O, but got Unknown
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected O, but got Unknown
		//IL_01f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fa: Expected O, but got Unknown
		//IL_0202: Unknown result type (might be due to invalid IL or missing references)
		//IL_0207: Expected O, but got Unknown
		//IL_0210: Unknown result type (might be due to invalid IL or missing references)
		//IL_0215: Expected O, but got Unknown
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Expected O, but got Unknown
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Expected O, but got Unknown
		object obj = typeof(System.IOAsyncCallback) + 976;
		object obj2 = "destinationTimeZone" + 2696;
		nint num = (nint)data;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X8_v4 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X8_v4 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_00bc;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X8_v4 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
		object obj4 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ X10_v13-8]");
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
			goto IL_00bc;
		}
		object obj5 = obj4 + 1;
		object obj6 = num + obj5;
		object obj7 = obj6 + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v230 @ X0_v18] (should have been resolved before IL gen)");
		object obj8 = default(object);
		bool flag = obj8 == null;
		object obj9 = !flag;
		if (obj9 == null)
		{
			return;
		}
		goto IL_00ed;
		IL_00bc:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v139 @ X0_v15] (should have been resolved before IL gen)");
		object obj10 = default(object);
		if (obj10 != null)
		{
			goto IL_00ed;
		}
		return;
		IL_00ed:
		nint num2 = (nint)data;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v256 @ X8_v7 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v256 @ X8_v7 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0181;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v256 @ X8_v7 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
		object obj12 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v298 @ X10_v8-8]");
			if (0 == (nint)obj)
			{
				break;
			}
			obj12 += 16;
			obj11--;
			if ((nint)obj11 != 1)
			{
				continue;
			}
			goto IL_0181;
		}
		object obj13 = obj12 + 18;
		object obj14 = num2 + obj13;
		object obj15 = obj14 + 312;
		goto IL_0272;
		IL_0272:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v315 @ X0_v6] (should have been resolved before IL gen)");
		string errorString = default(string);
		FriendlyChallengeInviteError error = ParseInviteError(errorString);
		eventsChannel.TriggerInviteError(error);
		return;
		IL_0181:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_0272;
	}

	private void ProcessResponseCallback(ISFSObject data)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0030: Expected I, but got O
		//IL_0040: Expected O, but got I
		//IL_00d6: Expected O, but got I
		//IL_022a: Unknown result type (might be due to invalid IL or missing references)
		//IL_022f: Expected O, but got Unknown
		//IL_007b: Expected O, but got I
		//IL_010d: Expected I, but got O
		//IL_011d: Expected O, but got I
		//IL_01b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b6: Expected O, but got Unknown
		//IL_01be: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c3: Expected O, but got Unknown
		//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d1: Expected O, but got Unknown
		//IL_01e1: Expected O, but got I
		//IL_0205: Expected O, but got I4
		//IL_02f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fa: Expected O, but got Unknown
		//IL_0158: Expected O, but got I
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Expected O, but got Unknown
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected O, but got Unknown
		//IL_0264: Unknown result type (might be due to invalid IL or missing references)
		//IL_0269: Expected O, but got Unknown
		//IL_0271: Unknown result type (might be due to invalid IL or missing references)
		//IL_0276: Expected O, but got Unknown
		//IL_027f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0284: Expected O, but got Unknown
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Expected O, but got Unknown
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_0179: Expected O, but got Unknown
		object obj = typeof(System.IOAsyncCallback) + 976;
		object obj2 = "destinationTimeZone" + 2696;
		nint num = (nint)data;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X8_v4 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X8_v4 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_00bc;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X8_v4 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
		object obj4 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ X10_v13-8]");
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
			goto IL_00bc;
		}
		object obj5 = obj4 + 1;
		object obj6 = num + obj5;
		object obj7 = obj6 + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ X0_v25+8]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v239 @ X0_v25] (should have been resolved before IL gen)");
		object obj9 = default(object);
		bool flag = obj9 == null;
		object obj10 = !flag;
		object obj11 = obj2;
		if (obj10 != null)
		{
			goto IL_0105;
		}
		goto IL_021b;
		IL_021b:
		object obj12 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1480;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		FriendlyChallengeInviteModel friendlyChallengeInviteModel = default(FriendlyChallengeInviteModel);
		friendlyChallengeInviteModel..ctor(data);
		eventsChannel.TriggerOnInviteReceived(friendlyChallengeInviteModel);
		return;
		IL_0105:
		nint num2 = (nint)data;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ X8_v9 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		object obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ X8_v9 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0199;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ X8_v9 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
		object obj14 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v315 @ X10_v8-8]");
			if (0 == (nint)obj)
			{
				break;
			}
			obj14 += 16;
			obj13--;
			if ((nint)obj13 != 1)
			{
				continue;
			}
			goto IL_0199;
		}
		object obj15 = obj14 + 18;
		object obj16 = num2 + obj15;
		object obj17 = obj16 + 312;
		goto IL_02e1;
		IL_02e1:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v332 @ X0_v9] (should have been resolved before IL gen)");
		object obj18 = "https://www.kammelna.com/Home/Terms" + 2272;
		string text = default(string);
		bool error = text == (string)obj18;
		eventsChannel.TriggerResponseEError(error ? FriendlyChallengeResponseError.InvalidInvite : FriendlyChallengeResponseError.Unknown);
		return;
		IL_0199:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_02e1;
		IL_00bc:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X0_v22+8]");
		obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v163 @ X0_v22] (should have been resolved before IL gen)");
		object obj19 = default(object);
		bool flag2 = obj19 == null;
		obj11 = obj2;
		if (!flag2)
		{
			goto IL_0105;
		}
		goto IL_021b;
	}

	private void ProcessChatAnnouncementCallback(ISFSObject data)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		object obj = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1448;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		FriendlyChallengeData friendlyChallengeData = default(FriendlyChallengeData);
		friendlyChallengeData..ctor(data);
		eventsChannel.TriggerChallengeActivity(friendlyChallengeData);
	}

	private void ProcessCancelChallengeCallback(ISFSObject data)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0030: Expected I, but got O
		//IL_0040: Expected O, but got I
		//IL_007b: Expected O, but got I
		//IL_00f5: Expected I, but got O
		//IL_0105: Expected O, but got I
		//IL_0199: Unknown result type (might be due to invalid IL or missing references)
		//IL_019e: Expected O, but got Unknown
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ab: Expected O, but got Unknown
		//IL_01b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b9: Expected O, but got Unknown
		//IL_01dd: Expected O, but got I4
		//IL_02a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a8: Expected O, but got Unknown
		//IL_0140: Expected O, but got I
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Expected O, but got Unknown
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected O, but got Unknown
		//IL_0205: Unknown result type (might be due to invalid IL or missing references)
		//IL_020a: Expected O, but got Unknown
		//IL_0212: Unknown result type (might be due to invalid IL or missing references)
		//IL_0217: Expected O, but got Unknown
		//IL_0220: Unknown result type (might be due to invalid IL or missing references)
		//IL_0225: Expected O, but got Unknown
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Expected O, but got Unknown
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Expected O, but got Unknown
		object obj = typeof(System.IOAsyncCallback) + 976;
		object obj2 = "destinationTimeZone" + 2696;
		nint num = (nint)data;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X8_v4 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X8_v4 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_00bc;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X8_v4 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
		object obj4 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ X10_v13-8]");
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
			goto IL_00bc;
		}
		object obj5 = obj4 + 1;
		object obj6 = num + obj5;
		object obj7 = obj6 + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v246 @ X0_v19] (should have been resolved before IL gen)");
		object obj8 = default(object);
		bool flag = obj8 == null;
		object obj9 = !flag;
		if (obj9 != null)
		{
			goto IL_00ed;
		}
		goto IL_01eb;
		IL_01eb:
		eventsChannel.TriggerChallengeCancelled(success: true);
		return;
		IL_00ed:
		nint num2 = (nint)data;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v272 @ X8_v7 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v272 @ X8_v7 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0181;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v272 @ X8_v7 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
		object obj11 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v316 @ X10_v8-8]");
			if (0 == (nint)obj)
			{
				break;
			}
			obj11 += 16;
			obj10--;
			if ((nint)obj10 != 1)
			{
				continue;
			}
			goto IL_0181;
		}
		object obj12 = obj11 + 18;
		object obj13 = num2 + obj12;
		object obj14 = obj13 + 312;
		goto IL_028f;
		IL_0181:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_028f;
		IL_028f:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v333 @ X0_v7] (should have been resolved before IL gen)");
		object obj15 = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 2800;
		string text = default(string);
		if (text == (string)obj15)
		{
			eventsChannel.TriggerChallengeWithdrawn();
		}
		else
		{
			eventsChannel.TriggerChallengeCancelled(success: false);
		}
		return;
		IL_00bc:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v160 @ X0_v16] (should have been resolved before IL gen)");
		object obj16 = default(object);
		if (obj16 != null)
		{
			goto IL_00ed;
		}
		goto IL_01eb;
	}

	private static FriendlyChallengeInviteError ParseInviteError(string errorString)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected O, but got Unknown
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Expected O, but got Unknown
		//IL_00da: Expected O, but got I4
		object obj = "tournament_participate_warning_body_with_tickets_warning_daily" + 4032;
		if (errorString == (string)obj)
		{
			return FriendlyChallengeInviteError.DefenderNotOnline;
		}
		object obj2 = "tournament_participate_warning_body_with_tickets_warning_daily" + 4008;
		if (errorString == (string)obj2)
		{
			return FriendlyChallengeInviteError.DefenderBusy;
		}
		object obj3 = "m_StencilDeferredPS" + 912;
		if (errorString == (string)obj3)
		{
			return FriendlyChallengeInviteError.ExceededMaxScore;
		}
		object obj4 = "https://www.kammelna.com/Home/Terms" + 2264;
		bool flag = errorString == (string)obj4;
		bool flag2 = !flag;
		object obj5 = !flag2;
		object obj6 = ~obj5;
		if (obj6 == null)
		{
			return FriendlyChallengeInviteError.DefenderDeclined;
		}
		return FriendlyChallengeInviteError.Unknown;
	}

	private static FriendlyChallengeResponseError ParseResponseError(string errorString)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object obj = "https://www.kammelna.com/Home/Terms" + 2272;
		string text = default(string);
		return (text == (string)obj) ? FriendlyChallengeResponseError.InvalidInvite : FriendlyChallengeResponseError.Unknown;
	}
}
