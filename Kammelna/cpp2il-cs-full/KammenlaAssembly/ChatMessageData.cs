using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Runtime.Remoting.Messaging;
using System.Threading;
using Cpp2ILInjected;
using Kammelna.Server;
using Server.Models;
using Sfs2X.Entities;
using Sfs2X.Entities.Data;
using Unity.Properties;
using UnityEngine.InputSystem.XR;

public class ChatMessageData
{
	private readonly string <UserId>k__BackingField;

	private readonly string <UserName>k__BackingField;

	private readonly string <Message>k__BackingField;

	private readonly bool <IsVerified>k__BackingField;

	private readonly bool <IsGenerated>k__BackingField;

	private readonly DateTime? <AvatarDate>k__BackingField;

	private string <Tag>k__BackingField;

	private ChatInk <Ink>k__BackingField;

	private readonly long <Timestamp>k__BackingField;

	private readonly int <Cardback>k__BackingField;

	private readonly FriendlyChallengeData <ChallengeData>k__BackingField;

	private GameRoomData <RoomData>k__BackingField;

	private Room <TournamentRoom>k__BackingField;

	public string UserId => <UserId>k__BackingField;

	public string UserName => <UserName>k__BackingField;

	public string Message => <Message>k__BackingField;

	public bool IsVerified => <IsVerified>k__BackingField;

	public bool IsGenerated => <IsGenerated>k__BackingField;

	public DateTime? AvatarDate => <AvatarDate>k__BackingField;

	public string Tag
	{
		get
		{
			return <Tag>k__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 64;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public ChatInk Ink
	{
		get
		{
			return <Ink>k__BackingField;
		}
		set
		{
			<Ink>k__BackingField = value;
		}
	}

	public long Timestamp => <Timestamp>k__BackingField;

	public bool IsMyMessage
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_0101: Expected O, but got I
			//IL_012b: Expected O, but got I4
			//IL_005c: Expected O, but got I
			//IL_0190: Expected I4, but got O
			//IL_0174: Expected O, but got I4
			object obj = 152985600;
			object obj2 = typeof(Queue<string>) + 848;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6FC5]");
			object obj3 = (nint)0 & (nint)1;
			if (obj3 != null)
			{
				object obj4 = (nint)0 + (nint)2200;
				object obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v3+E4]");
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
				object obj4 = (nint)0 + (nint)2200;
				object obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v3+E4]");
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
			SessionModel sessionModel = default(SessionModel);
			bool flag3 = (object)sessionModel == null;
			object obj8 = !flag3;
			if (obj8 != null)
			{
				goto IL_00b8;
			}
			goto IL_0182;
			IL_00b8:
			User localUser = sessionModel.LocalUser;
			string dbId = SFSKammelnaUserExtensions.GetDbId(localUser);
			return dbId == <UserId>k__BackingField;
			IL_0182:
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
			IL_0091:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			if ((object)sessionModel != null)
			{
				goto IL_00b8;
			}
			goto IL_0182;
		}
	}

	public bool HasUser
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0074: Expected O, but got I4
			object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 2536;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag2 = StringsExtensions.IsNullOrEmpty(<UserId>k__BackingField);
			return (byte)((flag2 ? 1u : 0u) ^ 1u) != 0;
		}
	}

	public int Cardback => <Cardback>k__BackingField;

	public FriendlyChallengeData ChallengeData => <ChallengeData>k__BackingField;

	public GameRoomData RoomData
	{
		get
		{
			return <RoomData>k__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 104;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public Room TournamentRoom
	{
		get
		{
			return <TournamentRoom>k__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 112;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public unsafe ChatMessageData(string message, string userId, string userName, DateTime? avatarDate, ChatInk inkId = ChatInk.Clean, bool isVerified = false, int cardback = 0, string tag = null)
	{
		//IL_0008: Expected O, but got Ref
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected O, but got Unknown
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Expected O, but got Unknown
		//IL_0127: Expected O, but got I4
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Expected O, but got Unknown
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		//IL_009f: Expected O, but got I
		object obj2 = default(object);
		object obj = (object)(&obj2);
		base..ctor();
		object obj3 = this + 16;
		obj3 = userId;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj4 = typeof(System.Formats.Asn1.SetOfValueComparer) + 2504;
		object obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v6+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		string text = StringUtil.RemoveSurrogate(userName);
		object obj7 = this + 24;
		obj7 = text;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		<IsVerified>k__BackingField = (byte)cardback != 0;
		string text2 = StringUtil.SanitizeChatMessage(message);
		object obj8 = this + 32;
		obj8 = text2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj9 = this + 64;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1+18]");
		obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	public ChatMessageData(string message, User user, ChatInk inkId = ChatInk.Clean, string tag = null)
		: this(message, SFSKammelnaUserExtensions.GetDbId(user), SFSKammelnaUserExtensions.GetUserName(user), SFSKammelnaUserExtensions.GetAvatarDate(user), ChatInk.Clean, (byte)GetInk(user, inkId) != 0, SFSKammelnaUserExtensions.IsVerified(user) ? 1 : 0, (string)SFSKammelnaUserExtensions.GetActiveCardbackID(user))
	{
	}//IL_0088: Expected O, but got I4


	public ChatMessageData(ISFSObject param)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_0044: Expected I, but got O
		//IL_0054: Expected O, but got I
		//IL_008f: Expected O, but got I
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Expected O, but got Unknown
		//IL_0128: Expected O, but got I
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Expected O, but got Unknown
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_0146: Expected O, but got Unknown
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Expected O, but got Unknown
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0164: Expected O, but got Unknown
		//IL_0170: Expected O, but got I
		//IL_0193: Unknown result type (might be due to invalid IL or missing references)
		//IL_0198: Expected O, but got Unknown
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ba: Expected O, but got Unknown
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Expected O, but got Unknown
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Expected O, but got Unknown
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Expected O, but got Unknown
		//IL_0200: Unknown result type (might be due to invalid IL or missing references)
		//IL_0205: Expected O, but got Unknown
		//IL_0238: Expected I8, but got I4
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Expected O, but got Unknown
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected O, but got Unknown
		//IL_0266: Unknown result type (might be due to invalid IL or missing references)
		//IL_026b: Expected O, but got Unknown
		object obj = typeof(System.IOAsyncCallback) + 976;
		object obj2 = "rightCtrl" + 768;
		object obj3 = typeof(System.Buffers.Text.ParserHelpers) + 936;
		nint num = (nint)param;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X8_v6 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X8_v6 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_00d0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X8_v6 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
		object obj5 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ X10_v6-8]");
			if (0 == (nint)obj)
			{
				break;
			}
			obj5 += 16;
			obj4--;
			if ((nint)obj4 != 1)
			{
				continue;
			}
			goto IL_00d0;
		}
		object obj6 = (object)(num + (object)(obj5 + 29)) + 312;
		goto IL_02e1;
		IL_00d0:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_02e1;
		IL_02e1:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v245 @ X0_v5] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		PlayerInfo playerInfo = default(PlayerInfo);
		ISFSObject data = default(ISFSObject);
		playerInfo..ctor(data);
		object varName = "m_StencilDeferredPS" + 2616;
		object defaultValue = (nint)0 + (nint)2000;
		object varName2 = "startPosition" + 2136;
		object varName3 = "startPosition" + 2256;
		object varName4 = "fetch_products" + 1776;
		object obj7 = "https://www.kammelna.com/Home/Terms" + 136;
		object obj8 = (nint)0 + (nint)56;
		<Cardback>k__BackingField = playerInfo.<ActiveCardBack>k__BackingField;
		int num2 = default(int);
		string text = num2.ToString();
		object obj9 = this + 16;
		obj9 = text;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj10 = this + 24;
		obj10 = playerInfo.<Name>k__BackingField;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		<IsVerified>k__BackingField = playerInfo.<IsVerified>k__BackingField;
		string text2 = SFSExtensions.Get(param, (string)varName, (string)defaultValue);
		object obj11 = this + 32;
		obj11 = text2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		<AvatarDate>k__BackingField = playerInfo.<AvatarDate>k__BackingField;
		<Timestamp>k__BackingField = SFSExtensions.Get(param, (string)varName2, 0L);
		string text3 = SFSExtensions.Get(param, (string)varName3, (string)defaultValue);
		object obj12 = this + 64;
		obj12 = text3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		bool flag = SFSExtensions.Get(param, (string)varName4, defaultValue: false);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @301ECBC");
	}

	public ChatMessageData(FriendlyChallengeData challenge)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		object obj = this + 96;
		obj = challenge;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	public ChatMessageData(GameRoomData room)
	{
		//IL_000c: Expected O, but got I
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected O, but got Unknown
		object obj = (nint)0 + (nint)2000;
		base..ctor();
		object obj2 = this + 104;
		obj2 = room;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj3 = this + 32;
		obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	public ChatMessageData(Room tournamentRoom)
	{
		//IL_000c: Expected O, but got I
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected O, but got Unknown
		object obj = (nint)0 + (nint)2000;
		base..ctor();
		object obj2 = this + 112;
		obj2 = tournamentRoom;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj3 = this + 32;
		obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	public ISFSObject ToSFSObject(User user = null)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Expected O, but got Unknown
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected O, but got Unknown
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Expected O, but got Unknown
		//IL_00bc: Expected I, but got O
		//IL_00cc: Expected O, but got I
		//IL_04c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04cc: Expected O, but got Unknown
		//IL_04de: Expected I, but got O
		//IL_04ee: Expected O, but got I
		//IL_0107: Expected O, but got I
		//IL_0541: Unknown result type (might be due to invalid IL or missing references)
		//IL_0546: Expected O, but got Unknown
		//IL_0558: Expected I, but got O
		//IL_0568: Expected O, but got I
		//IL_019b: Expected O, but got I
		//IL_0160: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Expected O, but got Unknown
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Expected O, but got Unknown
		//IL_017b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0180: Expected O, but got Unknown
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Expected O, but got Unknown
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Expected O, but got Unknown
		//IL_05bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c0: Expected O, but got Unknown
		//IL_05d2: Expected I, but got O
		//IL_05e2: Expected O, but got I
		//IL_022f: Expected O, but got I
		//IL_01f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f9: Expected O, but got Unknown
		//IL_0201: Unknown result type (might be due to invalid IL or missing references)
		//IL_0206: Expected O, but got Unknown
		//IL_020f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0214: Expected O, but got Unknown
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ae: Expected O, but got Unknown
		//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bc: Expected O, but got Unknown
		//IL_0635: Unknown result type (might be due to invalid IL or missing references)
		//IL_063a: Expected O, but got Unknown
		//IL_064c: Expected I, but got O
		//IL_065c: Expected O, but got I
		//IL_02c3: Expected O, but got I
		//IL_0288: Unknown result type (might be due to invalid IL or missing references)
		//IL_028d: Expected O, but got Unknown
		//IL_0295: Unknown result type (might be due to invalid IL or missing references)
		//IL_029a: Expected O, but got Unknown
		//IL_02a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a8: Expected O, but got Unknown
		//IL_023d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0242: Expected O, but got Unknown
		//IL_024b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0250: Expected O, but got Unknown
		//IL_06b7: Expected I, but got O
		//IL_06c7: Expected O, but got I
		//IL_0357: Expected O, but got I
		//IL_031c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0321: Expected O, but got Unknown
		//IL_0329: Unknown result type (might be due to invalid IL or missing references)
		//IL_032e: Expected O, but got Unknown
		//IL_0337: Unknown result type (might be due to invalid IL or missing references)
		//IL_033c: Expected O, but got Unknown
		//IL_02d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d6: Expected O, but got Unknown
		//IL_02df: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e4: Expected O, but got Unknown
		//IL_03eb: Expected O, but got I
		//IL_03b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b5: Expected O, but got Unknown
		//IL_03bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c2: Expected O, but got Unknown
		//IL_03cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d0: Expected O, but got Unknown
		//IL_0365: Unknown result type (might be due to invalid IL or missing references)
		//IL_036a: Expected O, but got Unknown
		//IL_0373: Unknown result type (might be due to invalid IL or missing references)
		//IL_0378: Expected O, but got Unknown
		//IL_0444: Unknown result type (might be due to invalid IL or missing references)
		//IL_0449: Expected O, but got Unknown
		//IL_0451: Unknown result type (might be due to invalid IL or missing references)
		//IL_0456: Expected O, but got Unknown
		//IL_045f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0464: Expected O, but got Unknown
		//IL_03f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fe: Expected O, but got Unknown
		//IL_0407: Unknown result type (might be due to invalid IL or missing references)
		//IL_040c: Expected O, but got Unknown
		object obj = typeof(RegisteredWaitHandle) + 2040;
		object obj2 = typeof(System.Buffers.Text.ParserHelpers) + 936;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		SFSObject sFSObject = default(SFSObject);
		sFSObject..ctor();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		PlayerInfo playerInfo = default(PlayerInfo);
		playerInfo..ctor(this, user);
		object obj3;
		if (playerInfo != null)
		{
			ISFSObject iSFSObject = playerInfo.ToSfsObject();
			if (sFSObject != null)
			{
				obj3 = typeof(System.IOAsyncCallback) + 976;
				object obj4 = "rightCtrl" + 768;
				object obj5 = "m_StencilDeferredPS" + 2616;
				nint num = (nint)sFSObject;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+12E]");
				object obj6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_0148;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+B0]");
				object obj7 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ X10_v35-8]");
					if (0 == (nint)obj3)
					{
						break;
					}
					obj7 += 16;
					obj6--;
					if ((nint)obj6 != 1)
					{
						continue;
					}
					goto IL_0148;
				}
				object obj8 = obj7 + 50;
				object obj9 = num + obj8;
				object obj10 = obj9 + 312;
				goto IL_04bd;
			}
		}
		return (ISFSObject)new NullReferenceException();
		IL_01dc:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_0537;
		IL_0398:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_06a5;
		IL_0537:
		object obj11 = "startPosition" + 2256;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v330 @ X0_v13] (should have been resolved before IL gen)");
		nint num2 = (nint)sFSObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v343 @ X8_v11 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+12E]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v343 @ X8_v11 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0270;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v343 @ X8_v11 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+B0]");
		object obj13 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v385 @ X10_v25-8]");
			if (0 == (nint)obj3)
			{
				break;
			}
			obj13 += 16;
			obj12--;
			if ((nint)obj12 != 1)
			{
				continue;
			}
			goto IL_0270;
		}
		object obj14 = obj13 + 36;
		object obj15 = num2 + obj14;
		object obj16 = obj15 + 312;
		goto IL_05b1;
		IL_0710:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v651 @ X0_v25] (should have been resolved before IL gen)");
		return sFSObject;
		IL_0304:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_062b;
		IL_062b:
		object obj17 = "https://www.kammelna.com/Home/Terms" + 136;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v498 @ X0_v19] (should have been resolved before IL gen)");
		nint num3 = (nint)sFSObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v511 @ X8_v17 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+12E]");
		object obj18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v511 @ X8_v17 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0398;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v511 @ X8_v17 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+B0]");
		object obj19 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v553 @ X10_v15-8]");
			if (0 == (nint)obj3)
			{
				break;
			}
			obj19 += 16;
			obj18--;
			if ((nint)obj18 != 1)
			{
				continue;
			}
			goto IL_0398;
		}
		object obj20 = obj19 + 32;
		object obj21 = num3 + obj20;
		object obj22 = obj21 + 312;
		goto IL_06a5;
		IL_042c:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_0710;
		IL_0148:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_04bd;
		IL_04bd:
		object obj23 = "startPosition" + 2136;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v246 @ X0_v10] (should have been resolved before IL gen)");
		nint num4 = (nint)sFSObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v259 @ X8_v8 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+12E]");
		object obj24 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v259 @ X8_v8 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_01dc;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v259 @ X8_v8 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+B0]");
		object obj25 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v301 @ X10_v30-8]");
			if (0 == (nint)obj3)
			{
				break;
			}
			obj25 += 16;
			obj24--;
			if ((nint)obj24 != 1)
			{
				continue;
			}
			goto IL_01dc;
		}
		object obj26 = obj25 + 39;
		object obj27 = num4 + obj26;
		object obj28 = obj27 + 312;
		goto IL_0537;
		IL_06a5:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v582 @ X0_v22] (should have been resolved before IL gen)");
		nint num5 = (nint)sFSObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v593 @ X8_v20 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+12E]");
		object obj29 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v593 @ X8_v20 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_042c;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v593 @ X8_v20 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+B0]");
		object obj30 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v634 @ X10_v10-8]");
			if (0 == (nint)obj3)
			{
				break;
			}
			obj30 += 16;
			obj29--;
			if ((nint)obj29 != 1)
			{
				continue;
			}
			goto IL_042c;
		}
		object obj31 = obj30 + 35;
		object obj32 = num5 + obj31;
		object obj33 = obj32 + 312;
		goto IL_0710;
		IL_0270:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_05b1;
		IL_05b1:
		object obj34 = "fetch_products" + 1776;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v414 @ X0_v16] (should have been resolved before IL gen)");
		nint num6 = (nint)sFSObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v427 @ X8_v14 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+12E]");
		object obj35 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v427 @ X8_v14 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0304;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v427 @ X8_v14 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+B0]");
		object obj36 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v469 @ X10_v20-8]");
			if (0 == (nint)obj3)
			{
				break;
			}
			obj36 += 16;
			obj35--;
			if ((nint)obj35 != 1)
			{
				continue;
			}
			goto IL_0304;
		}
		object obj37 = obj36 + 39;
		object obj38 = num6 + obj37;
		object obj39 = obj38 + 312;
		goto IL_062b;
	}

	public ChatMessageData Copy(string message)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 888;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		string userId = <UserId>k__BackingField;
		string userName = <UserName>k__BackingField;
		DateTime? avatarDate = <AvatarDate>k__BackingField;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ChatMessageData)+38]");
		ChatMessageData chatMessageData = default(ChatMessageData);
		chatMessageData..ctor(message, userId, userName, avatarDate, ChatInk.Clean, (byte)<Ink>k__BackingField != 0, <IsVerified>k__BackingField ? 1 : 0);
		return chatMessageData;
	}

	private static ChatInk GetInk(User user, ChatInk ink)
	{
		//IL_0247: Expected O, but got I4
		//IL_0261: Expected O, but got I4
		//IL_026a: Unknown result type (might be due to invalid IL or missing references)
		//IL_026f: Expected O, but got Unknown
		//IL_0289: Expected O, but got I4
		//IL_0239: Expected I4, but got O
		//IL_0013: Expected O, but got I4
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Expected O, but got Unknown
		//IL_0093: Expected I, but got O
		//IL_00a3: Expected O, but got I
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Expected O, but got Unknown
		//IL_004d: Expected O, but got I4
		//IL_01f9: Expected O, but got I4
		//IL_00de: Expected O, but got I
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Expected O, but got Unknown
		//IL_017a: Unknown result type (might be due to invalid IL or missing references)
		//IL_017f: Expected O, but got Unknown
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_018d: Expected O, but got Unknown
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a5: Expected O, but got Unknown
		//IL_01bf: Expected O, but got I4
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Expected O, but got Unknown
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Expected O, but got Unknown
		object obj = ink - 3;
		bool flag = (nint)obj < 4;
		object obj2 = !flag;
		object obj3 = obj - 4;
		bool flag2 = obj3 == null;
		object obj4 = !flag2;
		object obj5 = obj2 & obj4;
		if (obj5 == null)
		{
			object obj6 = 29 >> (int)obj;
			object obj7 = obj6 & 1;
			if (obj7 != null)
			{
				object obj8 = 119873536 + 3704;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X9_v13+v43 @ X8_v3*4]");
				return ChatInk.Clean;
			}
		}
		if (user != null)
		{
			object obj9 = typeof(UsageHint) + 8;
			nint num = (nint)user;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X8_v6 (Il2CppClass<Sfs2X.Entities.User>)+12E]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X8_v6 (Il2CppClass<Sfs2X.Entities.User>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_011f;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X8_v6 (Il2CppClass<Sfs2X.Entities.User>)+B0]");
			object obj11 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ X10_v6-8]");
				if (0 == (nint)obj9)
				{
					break;
				}
				obj11 += 16;
				obj10--;
				if ((nint)obj10 != 1)
				{
					continue;
				}
				goto IL_011f;
			}
			object obj12 = obj11 + 15;
			object obj13 = num + obj12;
			object obj14 = obj13 + 312;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v213 @ X0_v15] (should have been resolved before IL gen)");
			object obj16 = default(object);
			object obj15 = obj16 & 1;
			bool flag3 = obj15 == null;
			object obj17 = !flag3;
			if (obj17 != null)
			{
				goto IL_015e;
			}
			goto IL_01cd;
		}
		NullReferenceException ex = new NullReferenceException();
		return (ChatInk)ex;
		IL_011f:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v181 @ X0_v12] (should have been resolved before IL gen)");
		object obj19 = default(object);
		object obj18 = obj19 & 1;
		if (obj18 != null)
		{
			goto IL_015e;
		}
		goto IL_01cd;
		IL_015e:
		return ChatInk.Admin;
		IL_01cd:
		bool flag4 = SFSKammelnaUserExtensions.Can(user, UserPermission.HaveChatColor);
		bool flag5 = !flag4;
		object obj20 = !flag5;
		object obj21 = ~obj20;
		if (obj21 == null)
		{
			return ChatInk.Moderator;
		}
		return ink;
	}

	public unsafe override string ToString()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0033: Expected O, but got I4
		//IL_0049: Expected I, but got O
		//IL_0059: Expected O, but got I
		//IL_0082: Expected O, but got I
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Expected O, but got Unknown
		//IL_015d: Expected O, but got I8
		//IL_0102: Expected I, but got O
		//IL_0112: Expected O, but got I
		//IL_013b: Expected O, but got I
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Expected O, but got Unknown
		//IL_0230: Expected O, but got I4
		//IL_0240: Expected O, but got I4
		//IL_0260: Unknown result type (might be due to invalid IL or missing references)
		//IL_0265: Expected O, but got Unknown
		//IL_01cd: Expected I, but got O
		//IL_01dd: Expected O, but got I
		//IL_0206: Expected O, but got I
		//IL_027c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0281: Expected O, but got Unknown
		//IL_02a5: Expected O, but got I4
		//IL_02cb: Expected O, but got Ref
		//IL_033c: Expected O, but got I8
		//IL_02e1: Expected I, but got O
		//IL_02f1: Expected O, but got I
		//IL_031a: Expected O, but got I
		//IL_0363: Unknown result type (might be due to invalid IL or missing references)
		//IL_0368: Expected O, but got Unknown
		//IL_0371: Unknown result type (might be due to invalid IL or missing references)
		//IL_0376: Expected O, but got Unknown
		object obj = typeof(TypeConverter<ushort, char>) + 3400;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		object[] array = default(object[]);
		if (array != null)
		{
			bool flag = <UserId>k__BackingField == null;
			string text = (string)4;
			IndexOutOfRangeException ex = default(IndexOutOfRangeException);
			string text2;
			if (!flag)
			{
				nint num = (nint)array;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X8_v20 (Il2CppClass<System.Object[]>)+40]");
				text = (string)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
				bool flag2 = ex == null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X8_v20 (Il2CppClass<System.Object[]>)+40]");
				text2 = (string)0;
				if (flag2)
				{
					goto IL_03b9;
				}
			}
			if (array.Length != 0)
			{
				object obj2 = array + 32;
				obj2 = <UserId>k__BackingField;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				bool flag3 = <UserName>k__BackingField == null;
				text = <UserId>k__BackingField;
				if (!flag3)
				{
					nint num2 = (nint)array;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ X8_v19 (Il2CppClass<System.Object[]>)+40]");
					text = (string)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag4 = ex == null;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ X8_v19 (Il2CppClass<System.Object[]>)+40]");
					text2 = (string)0;
					if (flag4)
					{
						goto IL_03b9;
					}
				}
				object obj3 = array.Length & 0xFFFFFFFEL;
				if (obj3 != null)
				{
					object obj4 = array + 40;
					obj4 = <UserName>k__BackingField;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					bool flag5 = <Message>k__BackingField == null;
					text = <UserName>k__BackingField;
					if (!flag5)
					{
						nint num3 = (nint)array;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ X8_v18 (Il2CppClass<System.Object[]>)+40]");
						text = (string)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
						bool flag6 = ex == null;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ X8_v18 (Il2CppClass<System.Object[]>)+40]");
						text2 = (string)0;
						if (flag6)
						{
							goto IL_03b9;
						}
					}
					bool flag7 = array.Length < 2;
					object obj5 = !flag7;
					object obj6 = array.Length - 2;
					bool flag8 = obj6 == null;
					object obj7 = ~obj5;
					object obj8 = obj7 | flag8;
					if (obj8 == null)
					{
						object obj9 = array + 48;
						obj9 = <Message>k__BackingField;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						object obj10 = 153100288 + 1024;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
						object obj11 = default(object);
						bool flag9 = obj11 == null;
						int num4 = default(int);
						text = (string)(&num4);
						if (!flag9)
						{
							nint num5 = (nint)array;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ X8_v17 (Il2CppClass<System.Object[]>)+40]");
							text = (string)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
							bool flag10 = ex == null;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ X8_v17 (Il2CppClass<System.Object[]>)+40]");
							text2 = (string)0;
							if (flag10)
							{
								goto IL_03b9;
							}
						}
						object obj12 = array.Length & 0xFFFFFFFCL;
						if (obj12 != null)
						{
							object format = "HH:mm:ss.ffZ" + 2424;
							object obj13 = array + 56;
							obj13 = obj11;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							return string.Format((string)format, array);
						}
					}
				}
			}
			ex = new IndexOutOfRangeException();
			text2 = text;
			goto IL_03b9;
		}
		goto IL_03d1;
		IL_03b9:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		OutOfMemoryException ex2 = new OutOfMemoryException();
		goto IL_03d1;
		IL_03d1:
		return (string)(object)new NullReferenceException();
	}
}
