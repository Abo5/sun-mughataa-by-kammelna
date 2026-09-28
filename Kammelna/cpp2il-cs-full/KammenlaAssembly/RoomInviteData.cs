using System;
using System.Buffers.Text;
using System.Runtime.Remoting.Messaging;
using System.Threading;
using Cpp2ILInjected;
using Unity.Properties;

[Serializable]
public class RoomInviteData : IInviteData
{
	private InviteType <Type>k__BackingField;

	private string <ServerId>k__BackingField;

	private Games <Game>k__BackingField;

	private int <RoomId>k__BackingField;

	private string <Password>k__BackingField;

	private string <InviteeId>k__BackingField;

	public InviteType Type
	{
		get
		{
			return <Type>k__BackingField;
		}
		set
		{
			<Type>k__BackingField = value;
		}
	}

	public string ServerId
	{
		get
		{
			return <ServerId>k__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 24;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public Games Game
	{
		get
		{
			return <Game>k__BackingField;
		}
		set
		{
			<Game>k__BackingField = value;
		}
	}

	public int RoomId
	{
		get
		{
			return <RoomId>k__BackingField;
		}
		set
		{
			<RoomId>k__BackingField = value;
		}
	}

	public string Password
	{
		get
		{
			return <Password>k__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 40;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public string InviteeId
	{
		get
		{
			return <InviteeId>k__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 48;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public unsafe override string ToString()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_04e4: Expected O, but got I4
		//IL_0030: Expected O, but got Ref
		//IL_0046: Expected I, but got O
		//IL_0056: Expected O, but got I
		//IL_007f: Expected O, but got I
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Expected O, but got Unknown
		//IL_0156: Expected O, but got I8
		//IL_00fb: Expected I, but got O
		//IL_010b: Expected O, but got I
		//IL_0134: Expected O, but got I
		//IL_017c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Expected O, but got Unknown
		//IL_01bc: Expected O, but got Ref
		//IL_0235: Expected O, but got I4
		//IL_0245: Expected O, but got I4
		//IL_0265: Unknown result type (might be due to invalid IL or missing references)
		//IL_026a: Expected O, but got Unknown
		//IL_01d2: Expected I, but got O
		//IL_01e2: Expected O, but got I
		//IL_020b: Expected O, but got I
		//IL_0281: Unknown result type (might be due to invalid IL or missing references)
		//IL_0286: Expected O, but got Unknown
		//IL_02bf: Expected O, but got Ref
		//IL_0330: Expected O, but got I8
		//IL_02d5: Expected I, but got O
		//IL_02e5: Expected O, but got I
		//IL_030e: Expected O, but got I
		//IL_0356: Unknown result type (might be due to invalid IL or missing references)
		//IL_035b: Expected O, but got Unknown
		//IL_03ff: Expected O, but got I4
		//IL_040f: Expected O, but got I4
		//IL_042f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0434: Expected O, but got Unknown
		//IL_039c: Expected I, but got O
		//IL_03ac: Expected O, but got I
		//IL_03d5: Expected O, but got I
		//IL_044c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0451: Expected O, but got Unknown
		//IL_045a: Unknown result type (might be due to invalid IL or missing references)
		//IL_045f: Expected O, but got Unknown
		object obj = typeof(TypeConverter<ushort, char>) + 3400;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		object obj2 = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object[] array = default(object[]);
		if (array != null)
		{
			object obj3 = default(object);
			bool flag = obj3 == null;
			InviteType inviteType = default(InviteType);
			object obj4 = (object)(&inviteType);
			IndexOutOfRangeException ex = default(IndexOutOfRangeException);
			object obj5;
			if (!flag)
			{
				nint num = (nint)array;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X8_v23 (Il2CppClass<System.Object[]>)+40]");
				obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
				bool flag2 = ex == null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X8_v23 (Il2CppClass<System.Object[]>)+40]");
				obj5 = 0;
				if (flag2)
				{
					goto IL_04a4;
				}
			}
			if (array.Length != 0)
			{
				object obj6 = array + 32;
				obj6 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				bool flag3 = <ServerId>k__BackingField == null;
				obj4 = obj3;
				if (!flag3)
				{
					nint num2 = (nint)array;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v233 @ X8_v22 (Il2CppClass<System.Object[]>)+40]");
					obj4 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag4 = ex == null;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v233 @ X8_v22 (Il2CppClass<System.Object[]>)+40]");
					obj5 = 0;
					if (flag4)
					{
						goto IL_04a4;
					}
				}
				object obj7 = array.Length & 0xFFFFFFFEL;
				if (obj7 != null)
				{
					object obj8 = array + 40;
					obj8 = <ServerId>k__BackingField;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
					object obj9 = default(object);
					bool flag5 = obj9 == null;
					Games games = default(Games);
					obj4 = (object)(&games);
					if (!flag5)
					{
						nint num3 = (nint)array;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ X8_v21 (Il2CppClass<System.Object[]>)+40]");
						obj4 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
						bool flag6 = ex == null;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ X8_v21 (Il2CppClass<System.Object[]>)+40]");
						obj5 = 0;
						if (flag6)
						{
							goto IL_04a4;
						}
					}
					bool flag7 = array.Length < 2;
					object obj10 = !flag7;
					object obj11 = array.Length - 2;
					bool flag8 = obj11 == null;
					object obj12 = ~obj10;
					object obj13 = obj12 | flag8;
					if (obj13 == null)
					{
						object obj14 = array + 48;
						obj14 = obj9;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
						object obj15 = default(object);
						bool flag9 = obj15 == null;
						int num4 = default(int);
						obj4 = (object)(&num4);
						if (!flag9)
						{
							nint num5 = (nint)array;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ X8_v20 (Il2CppClass<System.Object[]>)+40]");
							obj4 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
							bool flag10 = ex == null;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ X8_v20 (Il2CppClass<System.Object[]>)+40]");
							obj5 = 0;
							if (flag10)
							{
								goto IL_04a4;
							}
						}
						object obj16 = array.Length & 0xFFFFFFFCL;
						if (obj16 != null)
						{
							object obj17 = array + 56;
							obj17 = obj15;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							bool flag11 = <Password>k__BackingField == null;
							obj4 = obj15;
							if (!flag11)
							{
								nint num6 = (nint)array;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ X8_v19 (Il2CppClass<System.Object[]>)+40]");
								obj4 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
								bool flag12 = ex == null;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ X8_v19 (Il2CppClass<System.Object[]>)+40]");
								obj5 = 0;
								if (flag12)
								{
									goto IL_04a4;
								}
							}
							bool flag13 = array.Length < 4;
							object obj18 = !flag13;
							object obj19 = array.Length - 4;
							bool flag14 = obj19 == null;
							object obj20 = ~obj18;
							object obj21 = obj20 | flag14;
							if (obj21 == null)
							{
								object format = "{0} color encoding is currently unsupported for outputting to HDR." + 632;
								object obj22 = array + 64;
								obj22 = <Password>k__BackingField;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
								return string.Format((string)format, array);
							}
						}
					}
				}
			}
			ex = new IndexOutOfRangeException();
			obj5 = obj4;
			goto IL_04a4;
		}
		goto IL_04bc;
		IL_04bc:
		return (string)(object)new NullReferenceException();
		IL_04a4:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		OutOfMemoryException ex2 = new OutOfMemoryException();
		goto IL_04bc;
	}

	public static RoomInviteData ForGame(int roomId, string password = null)
	{
		return ForRoom(InviteType.Game, roomId, password);
	}

	public static RoomInviteData ForTournament(int roomId, string password = null)
	{
		return ForRoom(InviteType.Tournament, roomId, password);
	}

	private static RoomInviteData ForRoom(InviteType type, int roomId, string password)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		//IL_014d: Expected O, but got I4
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Expected O, but got Unknown
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Expected O, but got Unknown
		object obj = typeof(RegisteredWaitHandle) + 1400;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		if (obj2 != null)
		{
			object obj3 = typeof(System.Buffers.Text.ParserHelpers) + 1624;
			object obj4 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
			object obj5 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v5+E4]");
			if ((nint)0 != 0)
			{
				Games currentGame = Preferences.CurrentGame;
				object obj6 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X0_v6+E4]");
				if ((nint)0 != 0)
				{
					goto IL_00ae;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				Games currentGame2 = Preferences.CurrentGame;
				object obj6 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X0_v6+E4]");
				bool flag = (nint)0 == 0;
				object obj7 = !flag;
				if (obj7 != null)
				{
					goto IL_00ae;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			goto IL_00ae;
		}
		return (RoomInviteData)(object)new NullReferenceException();
		IL_00ae:
		string serverID = Config.ServerID;
		object obj8 = obj2 + 24;
		obj8 = serverID;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj9 = obj2 + 40;
		obj9 = password;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		return (RoomInviteData)obj2;
	}

	public static RoomInviteData Parse(string data)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Expected O, but got Unknown
		//IL_00c2: Expected O, but got I4
		//IL_00f8: Expected O, but got I8
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Expected O, but got Unknown
		//IL_015b: Expected O, but got I4
		//IL_016b: Expected O, but got I4
		//IL_018b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0190: Expected O, but got Unknown
		//IL_01ce: Expected O, but got I8
		//IL_0223: Expected O, but got I4
		//IL_0233: Expected O, but got I4
		//IL_0253: Unknown result type (might be due to invalid IL or missing references)
		//IL_0258: Expected O, but got Unknown
		//IL_026f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0274: Expected O, but got Unknown
		//IL_02b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bd: Expected O, but got Unknown
		string text = default(string);
		if (text != null)
		{
			object obj = typeof(RegisteredWaitHandle) + 1400;
			string[] array = text.Split(',');
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			if (array != null)
			{
				if (array.Length != 0)
				{
					object obj3 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3016;
					object obj4 = obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X8_v8+E4]");
					bool flag = (nint)0 == 0;
					object obj5 = !flag;
					if (obj5 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					int num = Convert.ToInt32(array[0]);
					if (obj2 == null)
					{
						goto IL_02f1;
					}
					object obj6 = array.Length & 0xFFFFFFFEL;
					if (obj6 != null)
					{
						object obj7 = obj2 + 24;
						obj7 = array[1];
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						bool flag2 = array.Length < 2;
						object obj8 = !flag2;
						object obj9 = array.Length - 2;
						bool flag3 = obj9 == null;
						object obj10 = ~obj8;
						object obj11 = obj10 | flag3;
						if (obj11 == null)
						{
							int num2 = Convert.ToInt32(array[2]);
							object obj12 = array.Length & 0xFFFFFFFCL;
							if (obj12 != null)
							{
								int num3 = Convert.ToInt32(array[3]);
								bool flag4 = array.Length < 4;
								object obj13 = !flag4;
								object obj14 = array.Length - 4;
								bool flag5 = obj14 == null;
								object obj15 = ~obj13;
								object obj16 = obj15 | flag5;
								if (obj16 == null)
								{
									object obj17 = obj2 + 40;
									obj17 = array[4];
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
									if (array.Length >= 6)
									{
										object obj18 = obj2 + 48;
										obj18 = array[5];
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
									}
									return (RoomInviteData)obj2;
								}
							}
						}
					}
				}
				IndexOutOfRangeException ex = new IndexOutOfRangeException();
			}
		}
		goto IL_02f1;
		IL_02f1:
		return (RoomInviteData)(object)new NullReferenceException();
	}
}
