using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Linq;
using System.Threading;
using Cpp2ILInjected;
using HuaweiMobileServices.Location.Location;
using Kammelna.Server;
using ListView;
using Sfs2X.Entities;
using UnityEngine;

public class RoomCardChatStrip : ChatMessageStrip
{
	private sealed class <>c__DisplayClass3_0
	{
		public GameRoomData snapshot;

		internal bool <Setup>b__0(Room r)
		{
			//IL_0177: Expected I4, but got O
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0021: Expected I, but got O
			//IL_0031: Expected O, but got I
			//IL_006c: Expected O, but got I
			//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fc: Expected O, but got Unknown
			//IL_0118: Unknown result type (might be due to invalid IL or missing references)
			//IL_011d: Expected O, but got Unknown
			//IL_0126: Unknown result type (might be due to invalid IL or missing references)
			//IL_012b: Expected O, but got Unknown
			//IL_015b: Expected O, but got I4
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected O, but got Unknown
			//IL_0088: Unknown result type (might be due to invalid IL or missing references)
			//IL_008d: Expected O, but got Unknown
			GameRoomData gameRoomData;
			if (r != null)
			{
				object obj = typeof(RegisteredWaitHandle) + 1376;
				nint num = (nint)r;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v6 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v6 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_00ad;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v6 (Il2CppClass<Sfs2X.Entities.Room>)+B0]");
				object obj3 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X10_v6-8]");
					if (0 == (nint)obj)
					{
						break;
					}
					obj3 += 16;
					obj2--;
					if ((nint)obj2 != 1)
					{
						continue;
					}
					goto IL_00ad;
				}
				object obj4 = num + obj3;
				object obj5 = obj4 + 312;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v189 @ X0_v10] (should have been resolved before IL gen)");
				gameRoomData = snapshot;
				bool flag = snapshot == null;
				object obj6 = !flag;
				if (obj6 != null)
				{
					goto IL_00ea;
				}
			}
			goto IL_0169;
			IL_0169:
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
			IL_00ea:
			object obj8 = default(object);
			object obj7 = obj8 - gameRoomData.Id;
			return obj7 == null;
			IL_00ad:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v127 @ X0_v7] (should have been resolved before IL gen)");
			gameRoomData = snapshot;
			if (snapshot != null)
			{
				goto IL_00ea;
			}
			goto IL_0169;
		}
	}

	private RoomCard roomCard;

	private float cardHeight = 380f;

	private Room _room;

	public override void Setup(ChatMessageDataHolder datum, bool firstTime)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Expected O, but got Unknown
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected O, but got Unknown
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Expected O, but got Unknown
		//IL_01c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cb: Expected O, but got Unknown
		//IL_01d7: Expected O, but got I
		//IL_01e3: Expected O, but got I
		//IL_020c: Expected I, but got O
		//IL_0228: Unknown result type (might be due to invalid IL or missing references)
		//IL_022d: Expected O, but got Unknown
		//IL_03df: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e4: Expected O, but got Unknown
		//IL_0275: Unknown result type (might be due to invalid IL or missing references)
		//IL_027a: Expected O, but got Unknown
		//IL_0295: Expected O, but got I
		//IL_02a3: Expected I, but got O
		//IL_02ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b2: Expected O, but got Unknown
		//IL_042c: Expected I, but got O
		//IL_02f5: Expected I, but got O
		//IL_02ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0304: Expected O, but got Unknown
		//IL_0347: Expected I, but got O
		//IL_0351: Unknown result type (might be due to invalid IL or missing references)
		//IL_0356: Expected O, but got Unknown
		//IL_0399: Expected I, but got O
		//IL_03a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a8: Expected O, but got Unknown
		object obj = typeof(RankedPlayManager.<>c__DisplayClass36_0) + 2096;
		object obj2 = (nint)0 + (nint)1528;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj3 = default(object);
		obj3..ctor();
		((ListViewItem<object, int>)(object)this).Setup((object)datum, firstTime);
		if (firstTime)
		{
			GameObject gameObject = base.gameObject;
			if ((object)gameObject == null)
			{
				goto IL_0436;
			}
			object obj4 = "Read object reference Id '{0}' for {1}." + 3360;
			gameObject.name = (string)obj4;
		}
		Transform transform = base.transform;
		if ((object)transform != null)
		{
			object obj5 = typeof(System.Buffers.Text.ParserHelpers) + 3600;
			if (transform != obj5)
			{
				goto IL_0444;
			}
			((RectTransform)transform).SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, cardHeight);
			GameObject go = base.gameObject;
			VariableBinderExtensions.Unbind(go);
			if (datum != null)
			{
				ChatMessageData <message>k__BackingField = datum.<message>k__BackingField;
				if (datum.<message>k__BackingField != null && obj3 != null)
				{
					object obj6 = obj3 + 16;
					obj6 = <message>k__BackingField.<RoomData>k__BackingField;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					if (obj6 == null)
					{
						return;
					}
					object obj7 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3160;
					object obj8 = (nint)0 + (nint)880;
					object obj9 = (nint)0 + (nint)1168;
					List<Room> roomList = SFS.RoomList;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					Func<object, bool> func = default(Func<object, bool>);
					func..ctor(obj3, (IntPtr)obj8);
					object obj10 = Enumerable.FirstOrDefault(roomList, func);
					object obj11 = this + 144;
					obj11 = obj10;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					if (obj11 != null)
					{
						GameObject go2 = base.gameObject;
						object obj12 = typeof(SqlSingle[]) + 2376;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
						object obj13 = (nint)0 + (nint)2896;
						Action action = default(Action);
						action..ctor(this, (IntPtr)obj13);
						object varName = "startPosition" + 2144;
						VariableBinderExtensions.Bind(go2, _room, (string)varName, action);
						GameObject go3 = base.gameObject;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
						Action action2 = default(Action);
						action2..ctor(this, (IntPtr)obj13);
						object varName2 = "startPosition" + 2160;
						VariableBinderExtensions.Bind(go3, _room, (string)varName2, action2);
						GameObject go4 = base.gameObject;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
						Action action3 = default(Action);
						action3..ctor(this, (IntPtr)obj13);
						object varName3 = "not" + 4000;
						VariableBinderExtensions.Bind(go4, _room, (string)varName3, action3);
						GameObject go5 = base.gameObject;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
						Action action4 = default(Action);
						action4..ctor(this, (IntPtr)obj13);
						object varName4 = "placementId" + 2112;
						VariableBinderExtensions.Bind(go5, _room, (string)varName4, action4);
						return;
					}
					RoomCard roomCard = this.roomCard;
					object obj14 = typeof(RegisteredWaitHandle) + 1384;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					RoomDataHolder roomDataHolder = default(RoomDataHolder);
					roomDataHolder..ctor((GameRoomData)obj6, 0);
					if ((object)this.roomCard != null)
					{
						nint num = (nint)roomCard;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: [v258 @ X8_v14 (Il2CppClass<RoomCard>)+308] (should have been resolved before IL gen)");
					}
				}
			}
		}
		goto IL_0436;
		IL_0444:
		throw new InvalidCastException();
		IL_0436:
		NullReferenceException ex = new NullReferenceException();
		goto IL_0444;
	}

	public override float GetHeightForText(string text)
	{
		return cardHeight;
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
}
