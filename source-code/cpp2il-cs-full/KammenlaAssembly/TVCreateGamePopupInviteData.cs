using System;
using System.Buffers.Text;
using System.Formats.Asn1;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using Unity.Properties;

[Serializable]
public class TVCreateGamePopupInviteData : IInviteData
{
	private string <ServerId>k__BackingField;

	private Games <Game>k__BackingField;

	private int <TvUserId>k__BackingField;

	public InviteType Type => InviteType.TVCreateGamePopup;

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
			object obj = this + 16;
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

	public int TvUserId
	{
		get
		{
			return <TvUserId>k__BackingField;
		}
		set
		{
			<TvUserId>k__BackingField = value;
		}
	}

	public unsafe override string ToString()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_03ec: Expected O, but got I4
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
		//IL_0357: Unknown result type (might be due to invalid IL or missing references)
		//IL_035c: Expected O, but got Unknown
		//IL_0365: Unknown result type (might be due to invalid IL or missing references)
		//IL_036a: Expected O, but got Unknown
		object obj = typeof(TypeConverter<ushort, char>) + 3400;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		object obj2 = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object[] array = default(object[]);
		if (array != null)
		{
			object obj3 = default(object);
			bool flag = obj3 == null;
			object obj5 = default(object);
			object obj4 = (object)(&obj5);
			IndexOutOfRangeException ex = default(IndexOutOfRangeException);
			object obj6;
			if (!flag)
			{
				nint num = (nint)array;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X8_v19 (Il2CppClass<System.Object[]>)+40]");
				obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
				bool flag2 = ex == null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X8_v19 (Il2CppClass<System.Object[]>)+40]");
				obj6 = 0;
				if (flag2)
				{
					goto IL_03ad;
				}
			}
			if (array.Length != 0)
			{
				object obj7 = array + 32;
				obj7 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				bool flag3 = <ServerId>k__BackingField == null;
				obj4 = obj3;
				if (!flag3)
				{
					nint num2 = (nint)array;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ X8_v18 (Il2CppClass<System.Object[]>)+40]");
					obj4 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag4 = ex == null;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ X8_v18 (Il2CppClass<System.Object[]>)+40]");
					obj6 = 0;
					if (flag4)
					{
						goto IL_03ad;
					}
				}
				object obj8 = array.Length & 0xFFFFFFFEL;
				if (obj8 != null)
				{
					object obj9 = array + 40;
					obj9 = <ServerId>k__BackingField;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
					object obj10 = default(object);
					bool flag5 = obj10 == null;
					Games games = default(Games);
					obj4 = (object)(&games);
					if (!flag5)
					{
						nint num3 = (nint)array;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ X8_v17 (Il2CppClass<System.Object[]>)+40]");
						obj4 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
						bool flag6 = ex == null;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ X8_v17 (Il2CppClass<System.Object[]>)+40]");
						obj6 = 0;
						if (flag6)
						{
							goto IL_03ad;
						}
					}
					bool flag7 = array.Length < 2;
					object obj11 = !flag7;
					object obj12 = array.Length - 2;
					bool flag8 = obj12 == null;
					object obj13 = ~obj11;
					object obj14 = obj13 | flag8;
					if (obj14 == null)
					{
						object obj15 = array + 48;
						obj15 = obj10;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
						object obj16 = default(object);
						bool flag9 = obj16 == null;
						int num4 = default(int);
						obj4 = (object)(&num4);
						if (!flag9)
						{
							nint num5 = (nint)array;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ X8_v16 (Il2CppClass<System.Object[]>)+40]");
							obj4 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
							bool flag10 = ex == null;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ X8_v16 (Il2CppClass<System.Object[]>)+40]");
							obj6 = 0;
							if (flag10)
							{
								goto IL_03ad;
							}
						}
						object obj17 = array.Length & 0xFFFFFFFCL;
						if (obj17 != null)
						{
							object format = "{0} color encoding is currently unsupported for outputting to HDR." + 624;
							object obj18 = array + 56;
							obj18 = obj16;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							return string.Format((string)format, array);
						}
					}
				}
			}
			ex = new IndexOutOfRangeException();
			obj6 = obj4;
			goto IL_03ad;
		}
		goto IL_03c5;
		IL_03ad:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		OutOfMemoryException ex2 = new OutOfMemoryException();
		goto IL_03c5;
		IL_03c5:
		return (string)(object)new NullReferenceException();
	}

	public static TVCreateGamePopupInviteData Create(int tvUserId)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0145: Expected O, but got I4
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Expected O, but got Unknown
		//IL_00a5: Expected O, but got I4
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Expected O, but got Unknown
		object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 3688;
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
			object obj9 = obj3 + 16;
			obj9 = serverID;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			return (TVCreateGamePopupInviteData)obj3;
		}
		return (TVCreateGamePopupInviteData)(object)new NullReferenceException();
	}

	public static TVCreateGamePopupInviteData Parse(string data)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0079: Expected O, but got I8
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Expected O, but got Unknown
		//IL_00f9: Expected O, but got I4
		//IL_0109: Expected O, but got I4
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Expected O, but got Unknown
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Expected O, but got Unknown
		//IL_017a: Expected O, but got I4
		//IL_0221: Expected O, but got I8
		string text = default(string);
		if (text != null)
		{
			object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 3688;
			string[] array = text.Split(',');
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			if (array != null)
			{
				object obj3 = array.Length & 0xFFFFFFFEL;
				if (obj3 != null)
				{
					if (obj2 == null)
					{
						goto IL_01b8;
					}
					object obj4 = obj2 + 16;
					obj4 = array[1];
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					bool flag = array.Length < 2;
					object obj5 = !flag;
					object obj6 = array.Length - 2;
					bool flag2 = obj6 == null;
					object obj7 = ~obj5;
					object obj8 = obj7 | flag2;
					if (obj8 == null)
					{
						object obj9 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3016;
						object obj10 = obj9;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ X8_v9+E4]");
						bool flag3 = (nint)0 == 0;
						object obj11 = !flag3;
						if (obj11 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						int num = Convert.ToInt32(array[2]);
						object obj12 = array.Length & 0xFFFFFFFCL;
						if (obj12 != null)
						{
							int num2 = Convert.ToInt32(array[3]);
							return (TVCreateGamePopupInviteData)obj2;
						}
					}
				}
				goto IL_01c6;
			}
		}
		goto IL_01b8;
		IL_01c6:
		return (TVCreateGamePopupInviteData)(object)new IndexOutOfRangeException();
		IL_01b8:
		NullReferenceException ex = new NullReferenceException();
		goto IL_01c6;
	}
}
