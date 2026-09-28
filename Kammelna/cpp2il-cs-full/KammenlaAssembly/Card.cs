using System;
using System.Buffers.Text;
using System.Formats.Asn1;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;

public class Card
{
	private readonly Rank <Rank>k__BackingField;

	private readonly Suit <Suit>k__BackingField;

	public Rank Rank => <Rank>k__BackingField;

	public Suit Suit => <Suit>k__BackingField;

	public Card(Rank rank, Suit suit)
	{
		<Rank>k__BackingField = rank;
		<Suit>k__BackingField = suit;
	}

	public Card(Card card)
	{
		<Rank>k__BackingField = card.<Rank>k__BackingField;
	}

	public int AsInt()
	{
		//IL_0010: Expected O, but got I4
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected I4, but got Unknown
		object obj = (int)<Suit>k__BackingField * 13;
		return (int)(<Rank>k__BackingField + obj);
	}

	public override string ToString()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 3136;
		object obj2 = typeof(System.Buffers.Text.ParserHelpers) + 3136;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		Enum enumeration = default(Enum);
		string friendlyName = EnumExtensions.GetFriendlyName(enumeration);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		Enum enumeration2 = default(Enum);
		string friendlyName2 = EnumExtensions.GetFriendlyName(enumeration2);
		return friendlyName + friendlyName2;
	}

	public unsafe override bool Equals(object obj)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0029: Expected I, but got O
		//IL_0052: Expected O, but got I4
		//IL_008b: Expected O, but got I
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Expected O, but got Unknown
		//IL_00e2: Expected O, but got Ref
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Expected O, but got Unknown
		//IL_0131: Expected O, but got Ref
		if (obj != null)
		{
			object obj2 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 304;
			object obj3 = obj2;
			nint num = (nint)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X9_v2 (Il2CppClass<System.Object>)+130]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X8_v6+130]");
			bool flag = num2 < 0;
			object obj4 = !flag;
			bool flag2;
			if (obj4 == null)
			{
				flag2 = false;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X9_v2 (Il2CppClass<System.Object>)+C8]");
				nint num3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X8_v6+130]");
				object obj5 = num3 + 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X9_v5-8]");
				if (0 != (nint)obj3)
				{
					goto IL_00af;
				}
				object obj6 = typeof(System.Buffers.Text.ParserHelpers) + 3136;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
				object obj7 = default(object);
				object obj8 = default(object);
				flag2 = ((Enum)(&obj7)).Equals(obj8);
				if (flag2)
				{
					object obj9 = typeof(System.Formats.Asn1.SetOfValueComparer) + 3136;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
					object obj10 = default(object);
					return ((Enum)(&obj7)).Equals(obj10);
				}
			}
			return flag2;
		}
		goto IL_00af;
		IL_00af:
		return false;
	}

	public override int GetHashCode()
	{
		int num = default(int);
		int hashCode = num.GetHashCode();
		int num2 = default(int);
		int hashCode2 = num2.GetHashCode();
		return hashCode2 ^ hashCode;
	}
}
