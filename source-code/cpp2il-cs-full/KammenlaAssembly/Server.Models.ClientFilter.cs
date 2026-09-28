using System;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using UI.Conditions;

namespace Server.Models;

[Serializable]
public class ClientFilter
{
	private ClientOnlyFilterType <Type>k__BackingField;

	private ComparisonOperator <Operation>k__BackingField;

	private string <Value>k__BackingField;

	public ClientOnlyFilterType Type
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

	public ComparisonOperator Operation
	{
		get
		{
			return <Operation>k__BackingField;
		}
		set
		{
			<Operation>k__BackingField = value;
		}
	}

	public string Value
	{
		get
		{
			return <Value>k__BackingField;
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

	public unsafe bool Check(FilterableClientModel filterModel)
	{
		//IL_0339: Expected O, but got I4
		//IL_0349: Expected O, but got I
		//IL_036b: Expected O, but got I4
		//IL_0422: Unknown result type (might be due to invalid IL or missing references)
		//IL_0427: Expected O, but got Unknown
		//IL_03cb: Expected O, but got Ref
		//IL_03d0: Expected I, but got O
		//IL_0455: Expected O, but got I
		//IL_018c: Expected O, but got I4
		//IL_019c: Expected O, but got I
		//IL_01be: Expected O, but got I4
		//IL_0472: Expected I4, but got O
		//IL_01e7: Expected O, but got I
		//IL_01ef: Expected I, but got O
		//IL_0055: Expected O, but got I4
		//IL_0065: Expected O, but got I
		//IL_0087: Expected O, but got I4
		//IL_03e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ed: Expected O, but got Unknown
		//IL_03f9: Expected O, but got I
		//IL_00b0: Expected O, but got I
		//IL_00b8: Expected I, but got O
		//IL_0229: Expected O, but got Ref
		//IL_02ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0304: Expected O, but got Unknown
		//IL_00f2: Expected O, but got Ref
		//IL_0258: Unknown result type (might be due to invalid IL or missing references)
		//IL_025d: Expected O, but got Unknown
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_0126: Expected O, but got Unknown
		bool flag2 = default(bool);
		FilterableClientModel filterableClientModel = default(FilterableClientModel);
		ComparisonOperator op;
		System.Int32Enum userValue;
		string caller;
		System.Int32Enum filterValue;
		if (<Type>k__BackingField <= ClientOnlyFilterType.Platform)
		{
			if (<Type>k__BackingField != ClientOnlyFilterType.AppVersion)
			{
				if (<Type>k__BackingField != ClientOnlyFilterType.Platform)
				{
					goto IL_0413;
				}
				object obj = 153100288 + 1024;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ X8_v29+98]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X0_v36+E4]");
				bool flag = (nint)0 == 0;
				object obj3 = !flag;
				if (obj3 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj4 = (nint)0 + (nint)1008;
				nint num = (nint)obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D7088C");
				if (!flag2)
				{
					goto IL_0273;
				}
				bool flag3 = filterableClientModel == null;
				System.Int32Enum int32Enum = default(System.Int32Enum);
				FilterableClientModel filterableClientModel2 = (FilterableClientModel)(&int32Enum);
				if (!flag3)
				{
					op = <Operation>k__BackingField;
					userValue = (System.Int32Enum)filterableClientModel.<Platform>k__BackingField;
					object obj5 = "Cannot populate JSON object onto type '{0}'." + 2408;
					caller = (string)obj5;
					filterValue = int32Enum;
					goto IL_0491;
				}
			}
			else
			{
				bool flag4 = filterableClientModel == null;
				FilterableClientModel filterableClientModel2 = filterableClientModel;
				if (!flag4)
				{
					flag2 = filterableClientModel.<AppVersion>k__BackingField != null;
					if (flag2)
					{
						flag2 = Version.TryParse(<Value>k__BackingField, out var result);
						if (flag2)
						{
							object caller2 = "Cannot populate JSON object onto type '{0}'." + 2408;
							return ComparisonOperatorExtensions.Apply<object>(<Operation>k__BackingField, (object)filterableClientModel.<AppVersion>k__BackingField, (object)result, (string)caller2);
						}
					}
					goto IL_0273;
				}
			}
		}
		else if (<Type>k__BackingField != ClientOnlyFilterType.IsEligibleForAppStoreIntroOffer)
		{
			if (<Type>k__BackingField != ClientOnlyFilterType.Game)
			{
				goto IL_0413;
			}
			object obj6 = 153100288 + 1024;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X8_v16+98]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ X0_v24+E4]");
			bool flag5 = (nint)0 == 0;
			object obj8 = !flag5;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj9 = (nint)0 + (nint)992;
			nint num = (nint)obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D7088C");
			if (!flag2)
			{
				goto IL_0273;
			}
			bool flag6 = filterableClientModel == null;
			System.Int32Enum int32Enum2 = default(System.Int32Enum);
			FilterableClientModel filterableClientModel2 = (FilterableClientModel)(&int32Enum2);
			if (!flag6)
			{
				op = <Operation>k__BackingField;
				userValue = (System.Int32Enum)filterableClientModel.<Game>k__BackingField;
				object obj10 = "Cannot populate JSON object onto type '{0}'." + 2408;
				caller = (string)obj10;
				filterValue = int32Enum2;
				goto IL_0491;
			}
		}
		else
		{
			object obj11 = 153100288 + 1024;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X8_v9+28]");
			object obj12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X0_v17+E4]");
			bool flag7 = (nint)0 == 0;
			object obj13 = !flag7;
			if (obj13 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			flag2 = bool.TryParse(<Value>k__BackingField, out var result2);
			if (!flag2)
			{
				goto IL_0273;
			}
			bool flag8 = filterableClientModel == null;
			FilterableClientModel filterableClientModel2 = (FilterableClientModel)(&result2);
			nint num = unchecked((nint)null);
			if (!flag8)
			{
				object obj14 = "Cannot populate JSON object onto type '{0}'." + 2408;
				object obj15 = (nint)0 + (nint)3464;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D2F318");
				bool result3 = default(bool);
				return result3;
			}
		}
		throw new NullReferenceException();
		IL_0273:
		return flag2;
		IL_0413:
		object obj16 = typeof(MemberAchievementClanFeedData) + 2632;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		NotImplementedException ex = default(NotImplementedException);
		ex..ctor();
		object obj17 = (nint)0 + (nint)1936;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		OutOfMemoryException ex2 = new OutOfMemoryException();
		return (byte)(int)ex2 != 0;
		IL_0491:
		flag2 = ComparisonOperatorExtensions.Apply(op, userValue, filterValue, caller);
		goto IL_0273;
	}
}
