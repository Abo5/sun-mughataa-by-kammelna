using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Sfs2X;
using Sfs2X.Entities;

namespace Kammelna.Server;

public class SessionModel : Singleton<SessionModel>
{
	public const string RoomOwner = "O";

	public const string OnlineUsersCount = "ouc";

	public const string UserName = "n";

	public User LocalUser => SFS.MySelf;

	public Room CurrentRoom => SFS.LastJoinedRoom;

	public bool IsLoggedIn
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_013b: Expected O, but got I
			//IL_0165: Expected O, but got I4
			//IL_005c: Expected O, but got I
			//IL_01ca: Expected I4, but got O
			//IL_01ae: Expected O, but got I4
			//IL_00fe: Expected O, but got I
			object obj = 152993792;
			object obj2 = typeof(Queue<string>) + 824;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8325]");
			object obj3 = (nint)0 & (nint)1;
			if (obj3 != null)
			{
				object obj4 = (nint)0 + (nint)2152;
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
				object obj4 = (nint)0 + (nint)2152;
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
			object obj8 = default(object);
			bool flag3 = obj8 == null;
			object obj9 = !flag3;
			if (obj9 != null)
			{
				goto IL_00b8;
			}
			goto IL_01bc;
			IL_00b8:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X0_v14+20]");
			bool flag4 = (nint)0 == 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X0_v14+20]");
			bool result = false;
			if (!flag4)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X0_v14+20]");
				User mySelf = ((SmartFox)0).MySelf;
				bool flag5 = mySelf == null;
				bool flag6 = !flag5;
				result = flag6;
			}
			return result;
			IL_01bc:
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
			IL_0091:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			if (obj8 != null)
			{
				goto IL_00b8;
			}
			goto IL_01bc;
		}
	}

	public bool IsConnected
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_0119: Expected O, but got I
			//IL_0143: Expected O, but got I4
			//IL_005c: Expected O, but got I
			//IL_01ab: Expected I4, but got O
			//IL_018c: Expected O, but got I4
			//IL_00fe: Expected O, but got I
			object obj = 152993792;
			object obj2 = typeof(Queue<string>) + 824;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8391]");
			object obj3 = (nint)0 & (nint)1;
			if (obj3 != null)
			{
				object obj4 = (nint)0 + (nint)2152;
				object obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v4+E4]");
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
				object obj4 = (nint)0 + (nint)2152;
				object obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v4+E4]");
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
			object obj8 = default(object);
			bool flag3 = obj8 == null;
			object obj9 = !flag3;
			if (obj9 != null)
			{
				goto IL_00b8;
			}
			goto IL_019a;
			IL_01b0:
			bool result;
			return result;
			IL_00b8:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X0_v15+20]");
			bool flag4 = (nint)0 == 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X0_v15+20]");
			result = false;
			if (!flag4)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X0_v15+20]");
				return ((SmartFox)0).IsConnected;
			}
			goto IL_01b0;
			IL_019a:
			NullReferenceException ex = new NullReferenceException();
			result = (byte)(int)ex != 0;
			goto IL_01b0;
			IL_0091:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			if (obj8 != null)
			{
				goto IL_00b8;
			}
			goto IL_019a;
		}
	}

	public bool IsInLobby
	{
		get
		{
			Room lastJoinedRoom = SFS.LastJoinedRoom;
			return SFSKammelnaRoomExtensions.IsLobby(lastJoinedRoom);
		}
	}

	public event Action<User> OnUserJoinedRoom
	{
		add
		{
			SFS.OnUserJoinRoom += value;
		}
		remove
		{
			SFS.OnUserJoinRoom -= value;
		}
	}

	public event Action<User> OnUserLeftRoom
	{
		add
		{
			SFS.OnUserLeaveRoom += value;
		}
		remove
		{
			SFS.OnUserLeaveRoom -= value;
		}
	}

	public User GetOnlineUser(string userDbId)
	{
		return SFS.GetOnlineUser(userDbId);
	}

	public SessionModel()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00ae: Expected O, but got I
		//IL_00d8: Expected O, but got I4
		//IL_005c: Expected O, but got I
		object obj = 152993792;
		object obj2 = typeof(Queue<string>) + 848;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E82E4]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = (nint)0 + (nint)2192;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v1+E4]");
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
			object obj4 = (nint)0 + (nint)2192;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v1+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			object obj6 = obj4;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CECC90");
		return;
		IL_0091:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CECC90");
	}
}
