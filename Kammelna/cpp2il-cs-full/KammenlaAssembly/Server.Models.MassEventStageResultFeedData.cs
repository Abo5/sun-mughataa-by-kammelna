using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Newtonsoft.Json.Linq.JsonPath;
using Unity.Properties;
using Unity.Services.Authentication.Shared;

namespace Server.Models;

[Serializable]
public class MassEventStageResultFeedData : UserFeedData
{
	private string <EventName>k__BackingField;

	private long <EventId>k__BackingField;

	private int <StageId>k__BackingField;

	private int <Rank>k__BackingField;

	private int <Points>k__BackingField;

	private MassEventNextStageEligibility <Status>k__BackingField;

	public string EventName
	{
		get
		{
			return <EventName>k__BackingField;
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

	public long EventId
	{
		get
		{
			return <EventId>k__BackingField;
		}
		set
		{
			<EventId>k__BackingField = value;
		}
	}

	public int StageId
	{
		get
		{
			return <StageId>k__BackingField;
		}
		set
		{
			<StageId>k__BackingField = value;
		}
	}

	public int Rank
	{
		get
		{
			return <Rank>k__BackingField;
		}
		set
		{
			<Rank>k__BackingField = value;
		}
	}

	public int Points
	{
		get
		{
			return <Points>k__BackingField;
		}
		set
		{
			<Points>k__BackingField = value;
		}
	}

	public MassEventNextStageEligibility Status
	{
		get
		{
			return <Status>k__BackingField;
		}
		set
		{
			<Status>k__BackingField = value;
		}
	}

	public override bool HasPreview => true;

	public override bool ForcedPreview => true;

	public override LocalizableText GetTitle()
	{
		return TextMeshProExtensions.FixOnly(<EventName>k__BackingField);
	}

	public unsafe override LocalizableText GetDetails()
	{
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Expected O, but got Unknown
		//IL_00c9: Expected O, but got I
		//IL_00da: Expected O, but got I4
		//IL_00e2: Expected O, but got Ref
		//IL_0313: Expected native int or pointer, but got O
		//IL_0327: Unknown result type (might be due to invalid IL or missing references)
		//IL_032c: Expected O, but got Unknown
		//IL_0336: Unknown result type (might be due to invalid IL or missing references)
		//IL_033b: Expected O, but got Unknown
		//IL_034a: Unknown result type (might be due to invalid IL or missing references)
		//IL_034f: Expected O, but got Unknown
		//IL_0379: Expected O, but got I4
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Expected I4, but got Unknown
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Expected O, but got Unknown
		//IL_0097: Expected O, but got I4
		//IL_02e4: Expected O, but got I
		//IL_0302: Expected O, but got Ref
		//IL_0040: Expected O, but got I4
		//IL_0222: Expected O, but got I4
		//IL_0261: Unknown result type (might be due to invalid IL or missing references)
		//IL_0266: Expected O, but got Unknown
		//IL_0159: Expected O, but got I4
		//IL_0294: Expected O, but got I
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected O, but got Unknown
		//IL_0070: Expected O, but got I4
		//IL_016f: Expected I, but got O
		//IL_017f: Expected O, but got I
		//IL_01a8: Expected O, but got I
		//IL_01de: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e3: Expected O, but got Unknown
		object obj5;
		object item;
		int item2;
		(object, int) tuple;
		string text = default(string);
		if (<Status>k__BackingField != MassEventNextStageEligibility.EligibleToReserve)
		{
			int num;
			object obj4;
			if (<Status>k__BackingField != MassEventNextStageEligibility.Eligible)
			{
				bool flag = <Status>k__BackingField == MassEventNextStageEligibility.NotEligible;
				object obj = !flag;
				if (obj != null)
				{
					object obj2 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 656;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					ArgumentOutOfRangeException ex = default(ArgumentOutOfRangeException);
					ex..ctor();
					object obj3 = (nint)0 + (nint)3072;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
					return (LocalizableText)(object)new OutOfMemoryException();
				}
				num = <StageId>k__BackingField;
				obj4 = "SERVICE_DISABLED" + 640;
				obj5 = 0;
			}
			else
			{
				num = <StageId>k__BackingField;
				obj4 = "SERVICE_DISABLED" + 656;
				obj5 = 0;
			}
			item = obj4;
			object obj6 = (nint)0 + (nint)3928;
			object obj7 = obj6;
			item2 = num + 1;
			tuple = ((object, int))(&text);
		}
		else
		{
			item2 = <StageId>k__BackingField;
			object obj8 = "SERVICE_DISABLED" + 648;
			item = obj8;
			object obj9 = (nint)0 + (nint)3928;
			object obj7 = obj9;
			obj5 = 0;
			tuple = ((object, int))(&text);
		}
		System.Runtime.CompilerServices.Unsafe.Write((void*)(nint)tuple, (item, item2));
		object obj10 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2648;
		object key = "Network Authentication Required" + 3304;
		object obj11 = typeof(TypeConverter<ushort, char>) + 3400;
		object obj12 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ X0_v3+E4]");
		bool flag2 = (nint)0 == 0;
		object obj13 = !flag2;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		int n = obj5 + 1;
		string ordinalText = LocalizationText.GetOrdinalText((string)key, n);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		object[] array = default(object[]);
		object obj14;
		IndexOutOfRangeException ex2 = default(IndexOutOfRangeException);
		object obj15;
		if (array != null)
		{
			bool flag3 = ordinalText == null;
			obj14 = 1;
			if (!flag3)
			{
				nint num2 = (nint)array;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ X8_v12 (Il2CppClass<System.Object[]>)+40]");
				obj14 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
				bool flag4 = ex2 == null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ X8_v12 (Il2CppClass<System.Object[]>)+40]");
				obj15 = 0;
				if (flag4)
				{
					goto IL_023d;
				}
			}
			if (array.Length != 0)
			{
				object obj16 = array + 32;
				obj16 = ordinalText;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				return TextMeshProExtensions.LocalizeWith(text, array);
			}
		}
		else
		{
			NullReferenceException ex3 = new NullReferenceException();
			obj14 = 1;
		}
		ex2 = new IndexOutOfRangeException();
		obj15 = obj14;
		goto IL_023d;
		IL_023d:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		throw new OutOfMemoryException();
	}

	public override void ShowPreview(Action markSeen)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00f8: Expected O, but got I4
		//IL_0135: Expected O, but got I4
		object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 3784;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7BE8]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 == null)
		{
			goto IL_00c8;
		}
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v2+E4]");
		if ((nint)0 != 0)
		{
			goto IL_0074;
		}
		goto IL_0106;
		IL_0106:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		MassStageProgressPopup.Show(this);
		bool flag = markSeen == null;
		object obj4 = !flag;
		if (obj4 == null)
		{
			return;
		}
		goto IL_0097;
		IL_0074:
		MassStageProgressPopup.Show(this);
		if (markSeen != null)
		{
			goto IL_0097;
		}
		return;
		IL_0097:
		IntPtr invoke_impl = ((Delegate)markSeen).invoke_impl;
		IntPtr method_code = ((Delegate)markSeen).method_code;
		IntPtr method = ((Delegate)markSeen).method;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v66 @ X2_v1 (System.IntPtr) (should have been resolved before IL gen)");
		goto IL_00c8;
		IL_00c8:
		_ = 1;
		obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v2+E4]");
		bool flag2 = (nint)0 == 0;
		object obj5 = !flag2;
		if (obj5 != null)
		{
			goto IL_0074;
		}
		goto IL_0106;
	}
}
