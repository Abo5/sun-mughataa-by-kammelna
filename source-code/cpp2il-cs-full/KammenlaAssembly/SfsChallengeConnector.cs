using System;
using System.Buffers.Text;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Threading;
using Cpp2ILInjected;
using Kammelna.Server;
using Server.Models;
using Sfs2X.Entities.Data;
using UnityEngine;

public class SfsChallengeConnector : ChallengeConnector
{
	private long challengerId;

	public override void SendChallengeInvite(int userId, FriendlyChallengeRoomConfig conf)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		object key = "destinationTimeZone" + 3968;
		object command = "destinationTimeZone" + 3976;
		ISFSObject iSFSObject = conf.ToSfsObject();
		SFSExtensions.Put(iSFSObject, (string)key, userId);
		SFS.SendZoneExtensionRequest((string)command, iSFSObject);
	}

	public override void SendChallengeAccept(int challengerId)
	{
		FriendlyChallengeInvitesManager.SendAcceptChallenge(challengerId);
	}

	public override void SendChallengeDecline(int challengerId)
	{
		FriendlyChallengeInvitesManager.SendRejectChallenge(challengerId);
	}

	public override void GetUsersFriendlyChallenges(long userId)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00da: Expected O, but got I4
		//IL_0097: Expected O, but got I4
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a2: Expected O, but got Unknown
		//IL_01cc: Expected O, but got I4
		//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f8: Expected O, but got Unknown
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Expected O, but got Unknown
		//IL_0161: Expected O, but got I
		//IL_016f: Expected I, but got O
		object obj = typeof(RegisteredWaitHandle) + 56;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8A3F]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v12+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v12+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		RemoteConfigModel current = RemoteConfig.Current;
		goto IL_0100;
		IL_0100:
		FriendlyChallengeConfig <FriendlyChallenge>k__BackingField = current.<FriendlyChallenge>k__BackingField;
		if (<FriendlyChallenge>k__BackingField.<Enabled>k__BackingField)
		{
			object obj5 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 456;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj6 = (nint)0 + (nint)3384;
			Action<object> action = default(Action<object>);
			action..ctor((object)this, (IntPtr)obj6);
			KammelnaRequests.GetUserFriendlyChallenges(userId, action);
			return;
		}
		_events.TriggerChallengeDataReceived(null);
		object obj7 = typeof(DataRelation) + 856;
		object obj8 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X0_v5+E4]");
		bool flag2 = (nint)0 == 0;
		object obj9 = !flag2;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object message = "___# Content push apply failed [{0}]: {1}" + 80;
		Debug.LogWarning(message);
		return;
		IL_0074:
		current = RemoteConfig.Current;
		bool flag3 = current == null;
		object obj10 = !flag3;
		if (obj10 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_0100;
	}

	private void UserChallengesReceived(KammelnaResponseModel<FriendlyChallengeEntryModel[]> obj)
	{
		_events.TriggerChallengeDataReceived(obj.<Model>k__BackingField);
	}

	protected override void InviteFailed(FriendlyChallengeInviteError error)
	{
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Expected O, but got Unknown
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Expected O, but got Unknown
		//IL_0149: Expected O, but got I
		//IL_00ea: Expected O, but got I4
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_0069: Expected O, but got I4
		object obj = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1472;
		object obj2 = typeof(System.Buffers.Text.ParserHelpers) + 1432;
		bool flag = error != FriendlyChallengeInviteError.DefenderDeclined;
		IntPtr intPtr = default(IntPtr);
		string text = (string)(nint)intPtr;
		if (!flag)
		{
			object title = "Unsupported map type" + 120;
			object obj3 = "Network Authentication Required" + 3128;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
			Enum enumeration = default(Enum);
			string friendlyName = EnumExtensions.GetFriendlyName(enumeration);
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X0_v13+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			text = (string)obj3;
			PopupWindow.ShowInfo((string)title, friendlyName, (string)obj3);
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		Enum enumeration2 = default(Enum);
		string friendlyName2 = EnumExtensions.GetFriendlyName(enumeration2);
		object obj6 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X8_v4+E4]");
		bool flag3 = (nint)0 == 0;
		object obj7 = !flag3;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		PopupWindow.ShowError(friendlyName2);
	}

	protected override void ResponseFailed(FriendlyChallengeResponseError error)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_007d: Expected O, but got I4
		object obj = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1496;
		object obj2 = typeof(System.Buffers.Text.ParserHelpers) + 1432;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		Enum enumeration = default(Enum);
		string friendlyName = EnumExtensions.GetFriendlyName(enumeration);
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X8_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		PopupWindow.ShowError(friendlyName);
	}

	protected override void ChallengeCancelled(bool isCancelledByCreator)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected O, but got Unknown
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Expected O, but got Unknown
		//IL_00d9: Expected O, but got I4
		//IL_0060: Expected O, but got I4
		object obj = "Cannot populate JSON object onto type '{0}'." + 2048;
		object obj2 = "Cannot populate JSON object onto type '{0}'." + 2032;
		object obj3 = typeof(System.Buffers.Text.ParserHelpers) + 1432;
		object title = "Unsupported map type" + 120;
		object buttonText = "Network Authentication Required" + 3128;
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = !isCancelledByCreator;
		object obj6 = !flag2;
		object obj7 = ~obj6;
		string body = (string)((obj7 != null) ? obj2 : obj);
		PopupWindow.ShowInfo((string)title, body, (string)buttonText);
	}

	protected override void ChallengeWithdrawn()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected O, but got Unknown
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected O, but got Unknown
		//IL_0091: Expected O, but got I4
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 1432;
		object title = "DNQUALIFIER" + 3784;
		object body = "Cannot populate JSON object onto type '{0}'." + 2072;
		object buttonText = "Network Authentication Required" + 3128;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		PopupWindow.ShowInfo((string)title, (string)body, (string)buttonText);
	}
}
