using System;
using System.ComponentModel;
using Cpp2ILInjected;
using Newtonsoft.Json.Linq.JsonPath;
using Unity.Services.Authentication.Shared;
using UnityEngine;

public class RoomInfoSprites : ScriptableObject
{
	private Sprite locked;

	private Sprite unlocked;

	private Sprite cheating;

	private Sprite nonCheating;

	private Sprite ranked;

	private Sprite friendly;

	private Sprite voiceChat;

	private Sprite timer5Sec;

	private Sprite timer10Sec;

	private Sprite timer30Sec;

	private Sprite timerInfinite;

	public Sprite GetLockIcon(bool isLocked)
	{
		//IL_001a: Expected O, but got I4
		//IL_0048: Expected O, but got I4
		//IL_005a: Expected O, but got I
		//IL_003a: Expected O, but got I4
		bool flag = !isLocked;
		object obj = !flag;
		object obj2 = ~obj;
		if (obj2 == null)
		{
			object obj3 = 24;
		}
		else
		{
			object obj3 = 32;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (RoomInfoSprites)+v16 @ X8_v2]");
		return (Sprite)0;
	}

	public Sprite GetCheatingIcon(bool isCheating)
	{
		//IL_001a: Expected O, but got I4
		//IL_0048: Expected O, but got I4
		//IL_005a: Expected O, but got I
		//IL_003a: Expected O, but got I4
		bool flag = !isCheating;
		object obj = !flag;
		object obj2 = ~obj;
		if (obj2 == null)
		{
			object obj3 = 40;
		}
		else
		{
			object obj3 = 48;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (RoomInfoSprites)+v16 @ X8_v2]");
		return (Sprite)0;
	}

	public Sprite GetRoomTypeIcon(GameType gameType, bool isVoiceChatRoom = false)
	{
		//IL_004d: Expected O, but got I4
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Expected O, but got Unknown
		//IL_0026: Expected O, but got I4
		//IL_0033: Expected O, but got I
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Expected O, but got Unknown
		//IL_006a: Expected O, but got I4
		//IL_007a: Expected O, but got I
		//IL_0087: Expected O, but got I
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Expected O, but got Unknown
		//IL_011d: Expected O, but got I
		if (isVoiceChatRoom)
		{
			object obj = 72;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (RoomInfoSprites)+v3 @ X8_v4]");
			return (Sprite)0;
		}
		bool flag = gameType < (GameType)5;
		object obj2 = !flag;
		if (obj2 == null)
		{
			object obj3 = 119873536 + 3440;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X8_v2+gameType @ X1 (GameType)*8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (RoomInfoSprites)+v70 @ X8_v3]");
			return (Sprite)0;
		}
		object obj5 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2216;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object obj6 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 656;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj7 = "fetch_products" + 2424;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		ArgumentOutOfRangeException ex = default(ArgumentOutOfRangeException);
		string paramName = default(string);
		object actualValue = default(object);
		ex..ctor(paramName, actualValue, null);
		object obj8 = (nint)0 + (nint)2920;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		return (Sprite)(object)new OutOfMemoryException();
	}

	public Sprite GetSpeedIcon(int speed)
	{
		//IL_0151: Expected O, but got I4
		//IL_015e: Expected O, but got I
		//IL_0167: Expected O, but got I4
		//IL_0174: Expected O, but got I
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Expected O, but got Unknown
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Expected O, but got Unknown
		//IL_011b: Expected O, but got I4
		//IL_009e: Expected O, but got I4
		//IL_00ab: Expected O, but got I
		//IL_004b: Expected O, but got I4
		//IL_0058: Expected O, but got I
		if (speed > 5)
		{
			switch (speed)
			{
			case 30:
			{
				object obj2 = 96;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (RoomInfoSprites)+v138 @ X8_v12]");
				return (Sprite)0;
			}
			case 10:
			{
				object obj = 88;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (RoomInfoSprites)+v79 @ X8_v11]");
				return (Sprite)0;
			}
			}
		}
		else
		{
			if (speed == 0)
			{
				goto IL_0148;
			}
			if (speed == 5)
			{
				object obj3 = 80;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (RoomInfoSprites)+v170 @ X8_v10]");
				return (Sprite)0;
			}
		}
		int num = default(int);
		string text = num.ToString();
		object obj4 = "UInt16" + 2568;
		string text2 = (string)obj4 + text;
		object obj5 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1144;
		object obj6 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X8_v9+E4]");
		bool flag = (nint)0 == 0;
		object obj7 = !flag;
		object obj8 = text2;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj8 = text2;
		}
		KLogger.LogError(obj8);
		goto IL_0148;
		IL_0148:
		object obj9 = 104;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (RoomInfoSprites)+v130 @ X8_v4]");
		return (Sprite)0;
	}
}
