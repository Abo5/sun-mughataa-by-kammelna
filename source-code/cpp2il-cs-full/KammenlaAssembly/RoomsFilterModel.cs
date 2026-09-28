using System;
using System.Formats.Asn1;
using System.Threading;
using Cpp2ILInjected;
using Sfs2X.Entities.Data;

public class RoomsFilterModel
{
	private readonly string <Text>k__BackingField;

	private readonly GameType? <GameType>k__BackingField;

	private readonly bool? <CheatingAllowed>k__BackingField;

	private readonly int? <PlayingSpeed>k__BackingField;

	private readonly bool? <IsLocked>k__BackingField;

	private readonly bool? <IsVoice>k__BackingField;

	public string Text
	{
		get
		{
			return <Text>k__BackingField;
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

	public GameType? GameType
	{
		get
		{
			return <GameType>k__BackingField;
		}
		set
		{
			<GameType>k__BackingField = value;
		}
	}

	public bool? CheatingAllowed
	{
		get
		{
			return <CheatingAllowed>k__BackingField;
		}
		set
		{
			<CheatingAllowed>k__BackingField = value;
		}
	}

	public int? PlayingSpeed
	{
		get
		{
			return <PlayingSpeed>k__BackingField;
		}
		set
		{
			<PlayingSpeed>k__BackingField = value;
		}
	}

	public bool? IsLocked
	{
		get
		{
			return <IsLocked>k__BackingField;
		}
		set
		{
			<IsLocked>k__BackingField = value;
		}
	}

	public bool? IsVoice
	{
		get
		{
			return <IsVoice>k__BackingField;
		}
		set
		{
			<IsVoice>k__BackingField = value;
		}
	}

	public ISFSObject ToSfsObject()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_01e8: Expected O, but got I4
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected O, but got Unknown
		//IL_0083: Expected O, but got I4
		//IL_0200: Unknown result type (might be due to invalid IL or missing references)
		//IL_0205: Expected O, but got Unknown
		//IL_0223: Unknown result type (might be due to invalid IL or missing references)
		//IL_0228: Expected O, but got Unknown
		//IL_025a: Unknown result type (might be due to invalid IL or missing references)
		//IL_025f: Expected O, but got Unknown
		//IL_026b: Expected O, but got I
		//IL_00a7: Expected O, but got I
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Expected O, but got Unknown
		//IL_00d1: Expected O, but got I4
		//IL_0293: Expected O, but got I
		//IL_029e: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a3: Expected O, but got Unknown
		//IL_02dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e1: Expected O, but got Unknown
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Expected O, but got Unknown
		//IL_011b: Expected O, but got I4
		//IL_030f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0314: Expected O, but got Unknown
		//IL_034e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0353: Expected O, but got Unknown
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Expected O, but got Unknown
		//IL_0165: Expected O, but got I4
		//IL_0381: Unknown result type (might be due to invalid IL or missing references)
		//IL_0386: Expected O, but got Unknown
		//IL_03b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ba: Expected O, but got Unknown
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Expected O, but got Unknown
		//IL_019d: Expected O, but got I4
		//IL_03e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ed: Expected O, but got Unknown
		//IL_0414: Unknown result type (might be due to invalid IL or missing references)
		//IL_0419: Expected O, but got Unknown
		object obj = typeof(RegisteredWaitHandle) + 2040;
		object obj2 = typeof(System.Formats.Asn1.SetOfValueComparer) + 2536;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		SFSObject sFSObject = default(SFSObject);
		sFSObject..ctor();
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v4+E4]");
		if ((nint)0 != 0)
		{
			if (StringsExtensions.IsNullOrEmpty(<Text>k__BackingField))
			{
				goto IL_0059;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag = StringsExtensions.IsNullOrEmpty(<Text>k__BackingField);
			bool flag2 = !flag;
			object obj4 = !flag2;
			if (obj4 != null)
			{
				goto IL_0059;
			}
		}
		object key = "fetch_products" + 1672;
		SFSExtensions.Put(sFSObject, (string)key, <Text>k__BackingField);
		object obj5 = (??)<GameType>k__BackingField & 1;
		bool flag3 = obj5 == null;
		System.Int32Enum? int32Enum = (System.Int32Enum?)<GameType>k__BackingField;
		if (flag3)
		{
			goto IL_009b;
		}
		goto IL_024f;
		IL_01ab:
		return sFSObject;
		IL_040a:
		object key2 = "fetch_products" + 1680;
		SFSExtensions.Put(sFSObject, (string)key2, val: true);
		return sFSObject;
		IL_0173:
		object obj6 = (??)<IsVoice>k__BackingField & 1;
		bool flag4 = obj6 == null;
		object obj7 = !flag4;
		if (obj7 == null)
		{
			goto IL_01ab;
		}
		goto IL_040a;
		IL_0059:
		object obj8 = (??)<GameType>k__BackingField & 1;
		bool flag5 = obj8 == null;
		object obj9 = !flag5;
		int32Enum = (System.Int32Enum?)<GameType>k__BackingField;
		if (obj9 == null)
		{
			goto IL_009b;
		}
		goto IL_024f;
		IL_024f:
		object obj10 = "fetch_products" + 1648;
		object obj11 = (nint)0 + (nint)400;
		System.Int32Enum value = int32Enum.Value;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @301FBB0");
		object obj12 = (nint)0 + (nint)2032;
		object obj13 = (??)<CheatingAllowed>k__BackingField & 1;
		bool flag6 = obj13 == null;
		bool? flag7 = <CheatingAllowed>k__BackingField;
		object obj14 = obj12;
		if (flag6)
		{
			goto IL_00f1;
		}
		goto IL_02d2;
		IL_009b:
		obj12 = (nint)0 + (nint)2032;
		object obj15 = (??)<CheatingAllowed>k__BackingField & 1;
		bool flag8 = obj15 == null;
		object obj16 = !flag8;
		flag7 = <CheatingAllowed>k__BackingField;
		obj14 = obj12;
		if (obj16 == null)
		{
			goto IL_00f1;
		}
		goto IL_02d2;
		IL_02d2:
		object key3 = "fetch_products" + 1640;
		bool value2 = flag7.Value;
		SFSExtensions.Put(sFSObject, (string)key3, value2);
		object obj17 = (??)<PlayingSpeed>k__BackingField & 1;
		bool flag9 = obj17 == null;
		obj12 = obj14;
		int? num = <PlayingSpeed>k__BackingField;
		if (flag9)
		{
			goto IL_013b;
		}
		goto IL_0343;
		IL_00f1:
		object obj18 = (??)<PlayingSpeed>k__BackingField & 1;
		bool flag10 = obj18 == null;
		object obj19 = !flag10;
		num = <PlayingSpeed>k__BackingField;
		obj14 = obj12;
		if (obj19 == null)
		{
			goto IL_013b;
		}
		goto IL_0343;
		IL_0343:
		object key4 = "fetch_products" + 1664;
		int value3 = num.Value;
		SFSExtensions.Put(sFSObject, (string)key4, value3);
		object obj20 = (??)<IsLocked>k__BackingField & 1;
		bool flag11 = obj20 == null;
		obj12 = obj14;
		if (flag11)
		{
			goto IL_0173;
		}
		goto IL_03ab;
		IL_013b:
		object obj21 = (??)<IsLocked>k__BackingField & 1;
		bool flag12 = obj21 == null;
		object obj22 = !flag12;
		if (obj22 == null)
		{
			goto IL_0173;
		}
		goto IL_03ab;
		IL_03ab:
		object key5 = "fetch_products" + 1656;
		bool value4 = flag7.Value;
		SFSExtensions.Put(sFSObject, (string)key5, value4);
		object obj23 = (??)<IsVoice>k__BackingField & 1;
		if (obj23 == null)
		{
			goto IL_01ab;
		}
		goto IL_040a;
	}
}
