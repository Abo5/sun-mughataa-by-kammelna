using System;
using System.Data;
using System.IO;
using Cpp2ILInjected;
using Newtonsoft.Json.Linq.JsonPath;
using Sfs2X.Entities.Data;
using Unity.Services.Authentication.Shared;

namespace Server.Models;

[Serializable]
public class UserFeedItem
{
	private static class Constants
	{
		public const string Type = "uft";

		public const string DateExpires = "ufe";

		public const string Data = "ufd";
	}

	private long <Id>k__BackingField;

	private UserFeedType <Type>k__BackingField;

	private DateTime <DateCreated>k__BackingField;

	private DateTime <DateExpires>k__BackingField;

	private UserFeedData <Data>k__BackingField;

	private bool <IsSeen>k__BackingField;

	public long Id
	{
		get
		{
			return <Id>k__BackingField;
		}
		set
		{
			<Id>k__BackingField = value;
		}
	}

	public UserFeedType Type
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

	public DateTime DateCreated
	{
		get
		{
			return <DateCreated>k__BackingField;
		}
		set
		{
			<DateCreated>k__BackingField = value;
		}
	}

	public DateTime DateExpires
	{
		get
		{
			return <DateExpires>k__BackingField;
		}
		set
		{
			<DateExpires>k__BackingField = value;
		}
	}

	public UserFeedData Data
	{
		get
		{
			return <Data>k__BackingField;
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

	public bool IsSeen
	{
		get
		{
			return <IsSeen>k__BackingField;
		}
		set
		{
			<IsSeen>k__BackingField = value;
		}
	}

	public unsafe bool HasPreview
	{
		get
		{
			//IL_000a: Expected I4, but got O
			//IL_0015: Expected I4, but got O
			//IL_0041: Expected I4, but got O
			bool flag = (byte)(int)<Data>k__BackingField != 0;
			if ((int)(~<Data>k__BackingField) == 0)
			{
				bool value = ((bool*)(flag ? 1 : 0))->m_value;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: [v3 @ X8_v1 (System.Boolean)+178] (should have been resolved before IL gen)");
			}
			return (byte)(int)<Data>k__BackingField != 0;
		}
	}

	public bool ForcedPreview
	{
		get
		{
			//IL_0096: Expected I4, but got O
			//IL_0078: Expected I, but got O
			if (<Data>k__BackingField != null && <Data>k__BackingField.HasPreview)
			{
				UserFeedData userFeedData = <Data>k__BackingField;
				if (<Data>k__BackingField == null)
				{
					NullReferenceException ex = new NullReferenceException();
					return (byte)(int)ex != 0;
				}
				nint num = (nint)userFeedData;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: [v58 @ X8_v3 (Il2CppClass<Server.Models.UserFeedData>)+188] (should have been resolved before IL gen)");
			}
			return false;
		}
	}

	public UserFeedItem()
	{
	}

	public UserFeedItem(ISFSObject data)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_001b: Expected O, but got I
		//IL_0027: Expected O, but got I
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected O, but got Unknown
		//IL_05b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_05bb: Expected O, but got Unknown
		//IL_05ef: Expected O, but got I4
		//IL_0603: Unknown result type (might be due to invalid IL or missing references)
		//IL_0608: Expected O, but got Unknown
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected O, but got Unknown
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected O, but got Unknown
		//IL_00b6: Expected O, but got I4
		//IL_0637: Unknown result type (might be due to invalid IL or missing references)
		//IL_063c: Expected O, but got Unknown
		//IL_0673: Expected O, but got I
		//IL_0569: Unknown result type (might be due to invalid IL or missing references)
		//IL_056e: Expected O, but got Unknown
		//IL_0576: Unknown result type (might be due to invalid IL or missing references)
		//IL_057b: Expected O, but got Unknown
		//IL_0584: Unknown result type (might be due to invalid IL or missing references)
		//IL_0589: Expected O, but got Unknown
		//IL_0169: Unknown result type (might be due to invalid IL or missing references)
		//IL_016e: Expected O, but got Unknown
		//IL_0178: Unknown result type (might be due to invalid IL or missing references)
		//IL_017d: Expected O, but got Unknown
		//IL_0185: Expected I, but got O
		//IL_0195: Expected O, but got I
		//IL_073f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0744: Expected O, but got Unknown
		//IL_076e: Expected O, but got I4
		//IL_0233: Expected O, but got I
		//IL_0257: Expected O, but got I4
		//IL_0788: Expected O, but got I
		//IL_0798: Unknown result type (might be due to invalid IL or missing references)
		//IL_079d: Expected O, but got Unknown
		//IL_07d9: Expected O, but got I4
		//IL_0326: Expected I, but got O
		//IL_0336: Expected O, but got I
		//IL_01d0: Expected O, but got I
		//IL_03cc: Expected I, but got O
		//IL_03dc: Expected O, but got I
		//IL_0405: Expected O, but got I
		//IL_0371: Expected O, but got I
		//IL_02b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bc: Expected O, but got Unknown
		//IL_02c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c9: Expected O, but got Unknown
		//IL_02d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d7: Expected O, but got Unknown
		//IL_02e7: Expected O, but got I
		//IL_041b: Expected I, but got O
		//IL_042b: Expected O, but got I
		//IL_01de: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e3: Expected O, but got Unknown
		//IL_01ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f1: Expected O, but got Unknown
		//IL_04ba: Expected O, but got I4
		//IL_04d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d5: Expected O, but got Unknown
		//IL_04dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e2: Expected O, but got Unknown
		//IL_04eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f0: Expected O, but got Unknown
		//IL_04f8: Expected I, but got O
		//IL_0508: Expected O, but got I
		//IL_052c: Expected O, but got I4
		//IL_0544: Expected O, but got I
		//IL_0466: Expected O, but got I
		//IL_037f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0384: Expected O, but got Unknown
		//IL_038d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0392: Expected O, but got Unknown
		//IL_0474: Unknown result type (might be due to invalid IL or missing references)
		//IL_0479: Expected O, but got Unknown
		//IL_0482: Unknown result type (might be due to invalid IL or missing references)
		//IL_0487: Expected O, but got Unknown
		object obj = "tournament_participate_warning_body_with_tickets_warning_daily" + 1248;
		object obj2 = (nint)0 + (nint)232;
		object obj3 = (nint)0 + (nint)1560;
		base..ctor();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @301ECBC");
		UserFeedType userFeedType = default(UserFeedType);
		<Type>k__BackingField = userFeedType;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D70F1C");
		object obj4 = default(object);
		object obj5;
		nint num;
		object obj7;
		object obj8;
		object obj11 = default(object);
		object obj14;
		DateTime? dateTime5;
		if ((object)(obj4 & 1) != null)
		{
			obj5 = typeof(DataRelation) + 712;
			object varName = "tournament_participate_warning_body_with_tickets_warning_daily" + 1240;
			object obj6 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X0_v26+E4]");
			num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X0_v26+E4]");
			if ((object)((nint)0 != 0) == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			DateTime today = DateTime.Today;
			DateTime dateTime2 = default(DateTime);
			DateTime? dateTime = dateTime2.AddDays(2.0000000002328306);
			DateTime? dateTime3 = SFSExtensions.Get(data, (string)varName, dateTime);
			DateTime? dateTime4 = default(DateTime?);
			<DateExpires>k__BackingField = dateTime4.Value;
			bool flag = data == null;
			dateTime5 = dateTime;
			if (!flag)
			{
				obj7 = typeof(System.IOAsyncCallback) + 976;
				obj8 = "tournament_participate_warning_body_with_tickets_warning_daily" + 1232;
				nint num2 = (nint)data;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ X8_v19 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
				object obj9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ X8_v19 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_0219;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ X8_v19 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
				object obj10 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v322 @ X10_v22-8]");
					if (0 == (nint)obj7)
					{
						break;
					}
					obj11 = obj10 + 16;
					obj9--;
					bool flag2 = (nint)obj9 != 1;
					obj10 = obj11;
					if (flag2)
					{
						continue;
					}
					goto IL_0219;
				}
				object obj12 = (object)(num2 + (object)(obj10 + 1)) + 312;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v393 @ X0_v73+8]");
				dateTime5 = (DateTime?)(object)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v393 @ X0_v73] (should have been resolved before IL gen)");
				object obj13 = default(object);
				bool flag3 = obj13 == null;
				obj14 = obj8;
				obj11 = obj10;
				if (flag3)
				{
					goto IL_026d;
				}
				goto IL_031e;
			}
			goto IL_0552;
		}
		object obj15 = "tournament_participate_warning_body_with_tickets_warning_daily" + 1248;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		string varName2 = default(string);
		int num3 = SFSExtensions.Get(data, varName2, 0);
		object obj16 = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object obj17 = "Unsupported map type" + 616;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		string format = default(string);
		object arg = default(object);
		string message = string.Format(format, arg);
		object obj18 = typeof(System.IOAsyncCallback) + 3720;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		InvalidDataException ex = default(InvalidDataException);
		ex..ctor(message);
		object obj19 = (nint)0 + (nint)3936;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		throw new OutOfMemoryException();
		IL_0560:
		object obj20 = (object)(num + (object)(obj11 + 6)) + 312;
		goto IL_0726;
		IL_0726:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v372 @ X8_v6] (should have been resolved before IL gen)");
		object obj21 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 520;
		object obj22 = obj21;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v382 @ X8_v9+E4]");
		bool flag4 = (nint)0 == 0;
		object obj23 = !flag4;
		if (obj23 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj24 = (nint)0 + (nint)24;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E906D8");
		object obj25 = this + 48;
		object obj26 = default(object);
		obj25 = obj26;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj27 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v499 @ X0_v48+E4]");
		bool flag5 = (nint)0 == 0;
		object obj28 = !flag5;
		obj14 = obj26;
		if (obj28 != null)
		{
			goto IL_029a;
		}
		goto IL_059d;
		IL_059d:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		goto IL_029a;
		IL_029a:
		<DateCreated>k__BackingField = DateTime.Now;
		return;
		IL_03ba:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		object obj29 = default(object);
		num = (nint)obj29;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v515 @ X0_v61+8]");
		DateTime? dateTime6 = (DateTime?)(object)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v515 @ X0_v61] (should have been resolved before IL gen)");
		NullReferenceException ex2 = default(NullReferenceException);
		bool flag6 = ex2 == null;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v515 @ X0_v61+8]");
		dateTime5 = (DateTime?)(object)0;
		if (!flag6)
		{
			goto IL_0413;
		}
		goto IL_0552;
		IL_0552:
		ex2 = new NullReferenceException();
		goto IL_0560;
		IL_0413:
		num = (nint)ex2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v302 @ X8_v14 (Il2CppClass<System.NullReferenceException>)+12E]");
		object obj30 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v302 @ X8_v14 (Il2CppClass<System.NullReferenceException>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_04a7;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v302 @ X8_v14 (Il2CppClass<System.NullReferenceException>)+B0]");
		obj11 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ X10_v13-8]");
			bool flag7 = 0 == (nint)obj7;
			dateTime5 = dateTime6;
			if (flag7)
			{
				break;
			}
			obj11 += 16;
			obj30--;
			if ((nint)obj30 != 1)
			{
				continue;
			}
			goto IL_04a7;
		}
		goto IL_0560;
		IL_04a7:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		dateTime5 = (DateTime?)(object)6;
		object obj31 = default(object);
		obj20 = obj31;
		goto IL_0726;
		IL_026d:
		obj27 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v499 @ X0_v48+E4]");
		if ((nint)0 != 0)
		{
			goto IL_029a;
		}
		goto IL_059d;
		IL_0219:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v267 @ X0_v70+8]");
		dateTime5 = (DateTime?)(object)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v267 @ X0_v70] (should have been resolved before IL gen)");
		object obj33 = default(object);
		object obj32 = obj33 != null;
		obj14 = obj8;
		if (obj32 == null)
		{
			goto IL_026d;
		}
		goto IL_031e;
		IL_031e:
		nint num4 = (nint)data;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v438 @ X8_v21 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		object obj34 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v438 @ X8_v21 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_03ba;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v438 @ X8_v21 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
		object obj35 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ X10_v16-8]");
			if (0 == (nint)obj7)
			{
				break;
			}
			obj11 = obj35 + 16;
			obj34--;
			bool flag8 = (nint)obj34 != 1;
			obj35 = obj11;
			if (flag8)
			{
				continue;
			}
			goto IL_03ba;
		}
		num = (nint)(object)((object)(num4 + (object)(obj35 + 29)) + 312);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v580 @ X0_v64+8]");
		dateTime6 = (DateTime?)(object)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v580 @ X0_v64] (should have been resolved before IL gen)");
		object obj36 = ex2 != null;
		obj11 = obj35;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v580 @ X0_v64+8]");
		dateTime5 = (DateTime?)(object)0;
		if (obj36 != null)
		{
			goto IL_0413;
		}
		goto IL_0552;
	}

	public LocalizableText GetTitle()
	{
		//IL_000d: Expected I, but got O
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Expected O, but got Unknown
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Expected O, but got Unknown
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Expected O, but got Unknown
		//IL_0181: Expected O, but got I
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Expected O, but got Unknown
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected O, but got Unknown
		UserFeedData userFeedData = <Data>k__BackingField;
		if (<Data>k__BackingField != null)
		{
			nint num = (nint)userFeedData;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: [v44 @ X8_v12 (Il2CppClass<Server.Models.UserFeedData>)+198] (should have been resolved before IL gen)");
		}
		if (<Type>k__BackingField > UserFeedType.UserReportProcessed)
		{
			if (<Type>k__BackingField == UserFeedType.PredictionWarning)
			{
				object text = "Picking audio files is not supported on iOS" + 1248;
				return TextMeshProExtensions.Localize((string)text);
			}
			if (<Type>k__BackingField == UserFeedType.UserReportReceived)
			{
				object text2 = "Read object reference Id '{0}' for {1}." + 2304;
				return TextMeshProExtensions.Localize((string)text2);
			}
		}
		else
		{
			if (<Type>k__BackingField == UserFeedType.UpgradedAchievement)
			{
				object text3 = "<ds.DataTable.OnColumnChanging|INFO> {0}" + 3360;
				return TextMeshProExtensions.Localize((string)text3);
			}
			if (<Type>k__BackingField == UserFeedType.UserReportProcessed)
			{
				object text4 = "Read object reference Id '{0}' for {1}." + 2296;
				return TextMeshProExtensions.Localize((string)text4);
			}
		}
		object obj = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 656;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		ArgumentOutOfRangeException ex = default(ArgumentOutOfRangeException);
		ex..ctor();
		object obj2 = (nint)0 + (nint)3952;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		return (LocalizableText)(object)new OutOfMemoryException();
	}

	public LocalizableText GetDetails()
	{
		//IL_000d: Expected I, but got O
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Expected O, but got Unknown
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Expected O, but got Unknown
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Expected O, but got Unknown
		//IL_0181: Expected O, but got I
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Expected O, but got Unknown
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected O, but got Unknown
		UserFeedData userFeedData = <Data>k__BackingField;
		if (<Data>k__BackingField != null)
		{
			nint num = (nint)userFeedData;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: [v44 @ X8_v12 (Il2CppClass<Server.Models.UserFeedData>)+1A8] (should have been resolved before IL gen)");
		}
		if (<Type>k__BackingField > UserFeedType.UserReportProcessed)
		{
			if (<Type>k__BackingField == UserFeedType.PredictionWarning)
			{
				object text = "placementId" + 664;
				return TextMeshProExtensions.Localize((string)text);
			}
			if (<Type>k__BackingField == UserFeedType.UserReportReceived)
			{
				object text2 = "placementId" + 3368;
				return TextMeshProExtensions.Localize((string)text2);
			}
		}
		else
		{
			if (<Type>k__BackingField == UserFeedType.UpgradedAchievement)
			{
				object text3 = "<ds.DataTable.OnColumnChanging|INFO> {0}" + 3360;
				return TextMeshProExtensions.Localize((string)text3);
			}
			if (<Type>k__BackingField == UserFeedType.UserReportProcessed)
			{
				object text4 = "placementId" + 3360;
				return TextMeshProExtensions.Localize((string)text4);
			}
		}
		object obj = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 656;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		ArgumentOutOfRangeException ex = default(ArgumentOutOfRangeException);
		ex..ctor();
		object obj2 = (nint)0 + (nint)3944;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		return (LocalizableText)(object)new OutOfMemoryException();
	}

	public void ShowPreview(Action markSeen)
	{
		//IL_0017: Expected I, but got O
		//IL_0027: Expected O, but got I
		//IL_0037: Expected O, but got I
		UserFeedData userFeedData = <Data>k__BackingField;
		nint num = (nint)userFeedData;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ X8_v1 (Il2CppClass<Server.Models.UserFeedData>)+1B8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ X8_v1 (Il2CppClass<Server.Models.UserFeedData>)+1C0]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v4 @ X3_v1 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}
}
