using System;
using System.Buffers.Text;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using Newtonsoft.Json.Linq.JsonPath;
using Unity.Properties;

[Serializable]
public class MassTournamentInviteData : IInviteData
{
	private Games <Game>k__BackingField;

	private string <ServerId>k__BackingField;

	private string <Payload>k__BackingField;

	public InviteType Type => InviteType.MassTournament;

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

	public string Payload
	{
		get
		{
			return <Payload>k__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 32;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public unsafe override string ToString()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_03e2: Expected O, but got I4
		//IL_0030: Expected O, but got Ref
		//IL_0046: Expected I, but got O
		//IL_0056: Expected O, but got I
		//IL_007f: Expected O, but got I
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Expected O, but got Unknown
		//IL_00f3: Expected O, but got Ref
		//IL_0164: Expected O, but got I8
		//IL_0109: Expected I, but got O
		//IL_0119: Expected O, but got I
		//IL_0142: Expected O, but got I
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_018f: Expected O, but got Unknown
		//IL_0233: Expected O, but got I4
		//IL_0243: Expected O, but got I4
		//IL_0263: Unknown result type (might be due to invalid IL or missing references)
		//IL_0268: Expected O, but got Unknown
		//IL_01d0: Expected I, but got O
		//IL_01e0: Expected O, but got I
		//IL_0209: Expected O, but got I
		//IL_027f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0284: Expected O, but got Unknown
		//IL_0324: Expected O, but got I8
		//IL_02c9: Expected I, but got O
		//IL_02d9: Expected O, but got I
		//IL_0302: Expected O, but got I
		//IL_034b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0350: Expected O, but got Unknown
		//IL_0359: Unknown result type (might be due to invalid IL or missing references)
		//IL_035e: Expected O, but got Unknown
		object obj = typeof(TypeConverter<ushort, char>) + 3400;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		object obj2 = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object[] array = default(object[]);
		if (array != null)
		{
			object obj3 = default(object);
			bool flag = obj3 == null;
			object obj4 = default(object);
			string text = (string)(&obj4);
			IndexOutOfRangeException ex = default(IndexOutOfRangeException);
			string text2;
			if (!flag)
			{
				nint num = (nint)array;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X8_v19 (Il2CppClass<System.Object[]>)+40]");
				text = (string)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
				bool flag2 = ex == null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X8_v19 (Il2CppClass<System.Object[]>)+40]");
				text2 = (string)0;
				if (flag2)
				{
					goto IL_03a3;
				}
			}
			if (array.Length != 0)
			{
				object obj5 = array + 32;
				obj5 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
				string text3 = default(string);
				bool flag3 = text3 == null;
				Games games = default(Games);
				text = (string)(&games);
				if (!flag3)
				{
					nint num2 = (nint)array;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ X8_v18 (Il2CppClass<System.Object[]>)+40]");
					text = (string)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag4 = ex == null;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ X8_v18 (Il2CppClass<System.Object[]>)+40]");
					text2 = (string)0;
					if (flag4)
					{
						goto IL_03a3;
					}
				}
				object obj6 = array.Length & 0xFFFFFFFEL;
				if (obj6 != null)
				{
					object obj7 = array + 40;
					obj7 = text3;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					bool flag5 = <ServerId>k__BackingField == null;
					text = text3;
					if (!flag5)
					{
						nint num3 = (nint)array;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ X8_v17 (Il2CppClass<System.Object[]>)+40]");
						text = (string)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
						bool flag6 = ex == null;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ X8_v17 (Il2CppClass<System.Object[]>)+40]");
						text2 = (string)0;
						if (flag6)
						{
							goto IL_03a3;
						}
					}
					bool flag7 = array.Length < 2;
					object obj8 = !flag7;
					object obj9 = array.Length - 2;
					bool flag8 = obj9 == null;
					object obj10 = ~obj8;
					object obj11 = obj10 | flag8;
					if (obj11 == null)
					{
						object obj12 = array + 48;
						obj12 = <ServerId>k__BackingField;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						bool flag9 = <Payload>k__BackingField == null;
						text = <ServerId>k__BackingField;
						if (!flag9)
						{
							nint num4 = (nint)array;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ X8_v16 (Il2CppClass<System.Object[]>)+40]");
							text = (string)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
							bool flag10 = ex == null;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ X8_v16 (Il2CppClass<System.Object[]>)+40]");
							text2 = (string)0;
							if (flag10)
							{
								goto IL_03a3;
							}
						}
						object obj13 = array.Length & 0xFFFFFFFCL;
						if (obj13 != null)
						{
							object format = "{0} color encoding is currently unsupported for outputting to HDR." + 624;
							object obj14 = array + 56;
							obj14 = <Payload>k__BackingField;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							return string.Format((string)format, array);
						}
					}
				}
			}
			ex = new IndexOutOfRangeException();
			text2 = text;
			goto IL_03a3;
		}
		goto IL_03bb;
		IL_03a3:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		OutOfMemoryException ex2 = new OutOfMemoryException();
		goto IL_03bb;
		IL_03bb:
		return (string)(object)new NullReferenceException();
	}

	public static MassTournamentInviteData ForMassTournament(string payload)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0160: Expected O, but got I4
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Expected O, but got Unknown
		//IL_00a5: Expected O, but got I4
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Expected O, but got Unknown
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Expected O, but got Unknown
		object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 3816;
		object obj2 = typeof(System.Buffers.Text.ParserHelpers) + 1624;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj3 = default(object);
		obj3..ctor();
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Games currentGame = Preferences.CurrentGame;
		if (obj3 != null)
		{
			object obj6 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
			object obj7 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v9+E4]");
			bool flag2 = (nint)0 == 0;
			object obj8 = !flag2;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			string serverID = Config.ServerID;
			object obj9 = obj3 + 24;
			obj9 = serverID;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj10 = obj3 + 32;
			obj10 = payload;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			return (MassTournamentInviteData)obj3;
		}
		return (MassTournamentInviteData)(object)new NullReferenceException();
	}

	public static MassTournamentInviteData Parse(string data)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0079: Expected O, but got I8
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected O, but got Unknown
		//IL_00d4: Expected O, but got I4
		//IL_0112: Expected O, but got I4
		//IL_0122: Expected O, but got I4
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Expected O, but got Unknown
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Expected O, but got Unknown
		//IL_0193: Expected O, but got I8
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01be: Expected O, but got Unknown
		string text = default(string);
		if (text != null)
		{
			object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 3816;
			string[] array = text.Split(',');
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			if (array != null)
			{
				object obj3 = array.Length & 0xFFFFFFFEL;
				if (obj3 != null)
				{
					object obj4 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3016;
					object obj5 = obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X8_v8+E4]");
					bool flag = (nint)0 == 0;
					object obj6 = !flag;
					if (obj6 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					int num = Convert.ToInt32(array[1]);
					if (obj2 == null)
					{
						goto IL_01df;
					}
					bool flag2 = array.Length < 2;
					object obj7 = !flag2;
					object obj8 = array.Length - 2;
					bool flag3 = obj8 == null;
					object obj9 = ~obj7;
					object obj10 = obj9 | flag3;
					if (obj10 == null)
					{
						object obj11 = obj2 + 24;
						obj11 = array[2];
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						object obj12 = array.Length & 0xFFFFFFFCL;
						if (obj12 != null)
						{
							object obj13 = obj2 + 32;
							obj13 = array[3];
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							return (MassTournamentInviteData)obj2;
						}
					}
				}
				goto IL_01ed;
			}
		}
		goto IL_01df;
		IL_01df:
		NullReferenceException ex = new NullReferenceException();
		goto IL_01ed;
		IL_01ed:
		return (MassTournamentInviteData)(object)new IndexOutOfRangeException();
	}
}
