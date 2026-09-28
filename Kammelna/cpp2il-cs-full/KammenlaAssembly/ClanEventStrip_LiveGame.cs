using System;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Threading;
using Cpp2ILInjected;
using Kammelna.Server;
using Kammelna.Server.Models.Clans;
using ListView;
using Sfs2X.Entities;
using UnityEngine;

public class ClanEventStrip_LiveGame : ClanEventStrip
{
	private RoomCard roomCard;

	private Room _room;

	private void OnDisable()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_002c: Expected O, but got I4
		GameObject go = base.gameObject;
		VariableBinderExtensions.Unbind(go);
		object obj = this + 160;
		obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	public override void Setup(ClanFeedEventDataHolder datum, bool firstTime)
	{
		//IL_0131: Expected O, but got I4
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected O, but got Unknown
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Expected O, but got Unknown
		//IL_0196: Expected O, but got I4
		//IL_019f: Expected O, but got I4
		//IL_010b: Expected O, but got I4
		//IL_01c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cb: Expected O, but got Unknown
		//IL_01e6: Expected O, but got I
		//IL_01f4: Expected I, but got O
		//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0203: Expected O, but got Unknown
		//IL_0246: Expected I, but got O
		//IL_0250: Unknown result type (might be due to invalid IL or missing references)
		//IL_0255: Expected O, but got Unknown
		//IL_0298: Expected I, but got O
		//IL_02a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a7: Expected O, but got Unknown
		//IL_02ea: Expected I, but got O
		//IL_02f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f9: Expected O, but got Unknown
		bool firstTime2 = default(bool);
		base.Setup(datum, firstTime2);
		GameObject go = base.gameObject;
		VariableBinderExtensions.Unbind(go);
		Room room;
		if (datum != null)
		{
			room = datum.<GameRoom>k__BackingField;
			bool flag = (object)this == null;
			Room <GameRoom>k__BackingField = datum.<GameRoom>k__BackingField;
			if (!flag)
			{
				goto IL_0056;
			}
		}
		else
		{
			bool flag2 = (object)this == null;
			object obj = !flag2;
			room = null;
			Room <GameRoom>k__BackingField = null;
			if (obj != null)
			{
				goto IL_0056;
			}
		}
		NullReferenceException ex = new NullReferenceException();
		ClanFeedEventDataHolder clanFeedEventDataHolder = datum;
		goto IL_015f;
		IL_015f:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = (UnityEngine.Object)(object)clanFeedEventDataHolder == null;
		bool flag4 = !flag3;
		object obj2 = !flag4;
		object obj3 = 0;
		if (obj2 != null)
		{
			return;
		}
		goto IL_01ad;
		IL_01ad:
		GameObject go2 = base.gameObject;
		object obj4 = typeof(SqlSingle[]) + 2376;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj5 = (nint)0 + (nint)960;
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj5);
		object varName = "startPosition" + 2144;
		VariableBinderExtensions.Bind(go2, _room, (string)varName, action);
		GameObject go3 = base.gameObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action2 = default(Action);
		action2..ctor(this, (IntPtr)obj5);
		object varName2 = "startPosition" + 2160;
		VariableBinderExtensions.Bind(go3, _room, (string)varName2, action2);
		GameObject go4 = base.gameObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action3 = default(Action);
		action3..ctor(this, (IntPtr)obj5);
		object varName3 = "not" + 4000;
		VariableBinderExtensions.Bind(go4, _room, (string)varName3, action3);
		GameObject go5 = base.gameObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action4 = default(Action);
		action4..ctor(this, (IntPtr)obj5);
		object varName4 = "placementId" + 2112;
		VariableBinderExtensions.Bind(go5, _room, (string)varName4, action4);
		return;
		IL_0056:
		object obj6 = this + 160;
		obj6 = room;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		if (obj6 != null)
		{
			object obj7 = typeof(MemberAchievementClanFeedData) + 2976;
			clanFeedEventDataHolder = (ClanFeedEventDataHolder)(object)roomCard;
			ex = (NullReferenceException)obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X0_v26 (System.NullReferenceException)+E4]");
			bool flag5 = (nint)0 == 0;
			Room <GameRoom>k__BackingField = room;
			if (flag5)
			{
				goto IL_015f;
			}
			bool flag6 = roomCard == null;
			bool flag7 = !flag6;
			obj3 = 0;
			if (!flag7)
			{
				return;
			}
			goto IL_01ad;
		}
	}

	private void RefreshCard()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_007e: Expected I, but got O
		//IL_008e: Expected O, but got I
		//IL_009e: Expected O, but got I
		if (_room != null)
		{
			object obj = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2168;
			object obj2 = typeof(RegisteredWaitHandle) + 1384;
			RoomCard roomCard = this.roomCard;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			GameRoomData gameRoomData = default(GameRoomData);
			gameRoomData..ctor(_room);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			RoomDataHolder roomDataHolder = default(RoomDataHolder);
			roomDataHolder..ctor(gameRoomData, 0);
			nint num = (nint)roomCard;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X8_v5 (Il2CppClass<RoomCard>)+308]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X8_v5 (Il2CppClass<RoomCard>)+310]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v66 @ X4_v1 (should have been resolved before IL gen)");
		}
	}

	public ClanEventStrip_LiveGame()
	{
		((ListViewItem<object, int>)(object)this)..ctor();
	}
}
