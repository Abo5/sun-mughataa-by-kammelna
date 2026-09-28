using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using Cpp2ILInjected;
using Features.GameReplay;
using Microsoft.Extensions.DependencyInjection.ServiceLookup;
using Sfs2X.Entities.Data;
using UnityEngine;

public class GiftBombData
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Func<double, double, Vector2> <>9__52_0;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(GameReplayController.<OnEndRoundEventIe>d__138) + 288;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal Vector2 <.ctor>b__52_0(double x, double y)
		{
			return (Vector2)this;
		}
	}

	private const string BombID = "bi";

	private const string BombCreator = "bc";

	private const string BombMessage = "bm";

	private const string BombDate = "bd";

	private const string BombSize = "bsz";

	private const string BombCount = "bcnt";

	private const string BombCategory = "bt";

	private const string BombUsedUp = "bup";

	private const string BombTotalCost = "btc";

	private const string BombCaptchaX = "bx";

	private const string BombCaptchaY = "by";

	private long <Id>k__BackingField;

	private PlayerInfo <Creator>k__BackingField;

	private string <Message>k__BackingField;

	private DateTime <DateCreated>k__BackingField;

	private int <CurrencyPerShard>k__BackingField;

	private int <NumberOfShards>k__BackingField;

	private GiftBombType <Category>k__BackingField;

	private bool <IsClaimed>k__BackingField;

	private int <TotalCost>k__BackingField;

	private List<Vector2> <CaptchaPath>k__BackingField;

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

	public PlayerInfo Creator
	{
		get
		{
			return <Creator>k__BackingField;
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

	public string Message
	{
		get
		{
			return <Message>k__BackingField;
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

	public int CurrencyPerShard
	{
		get
		{
			return <CurrencyPerShard>k__BackingField;
		}
		set
		{
			<CurrencyPerShard>k__BackingField = value;
		}
	}

	public int NumberOfShards
	{
		get
		{
			return <NumberOfShards>k__BackingField;
		}
		set
		{
			<NumberOfShards>k__BackingField = value;
		}
	}

	public GiftBombType Category
	{
		get
		{
			return <Category>k__BackingField;
		}
		set
		{
			<Category>k__BackingField = value;
		}
	}

	public bool IsClaimed
	{
		get
		{
			return <IsClaimed>k__BackingField;
		}
		set
		{
			<IsClaimed>k__BackingField = value;
		}
	}

	public int TotalCost
	{
		get
		{
			return <TotalCost>k__BackingField;
		}
		set
		{
			<TotalCost>k__BackingField = value;
		}
	}

	public List<Vector2> CaptchaPath
	{
		get
		{
			return <CaptchaPath>k__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 72;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public GiftBombData()
	{
	}

	public GiftBombData(ISFSObject data)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_0698: Expected I8, but got I4
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected O, but got Unknown
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Expected O, but got Unknown
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		//IL_0076: Expected I, but got O
		//IL_0086: Expected O, but got I
		//IL_06da: Unknown result type (might be due to invalid IL or missing references)
		//IL_06df: Expected O, but got Unknown
		//IL_0706: Unknown result type (might be due to invalid IL or missing references)
		//IL_070b: Expected O, but got Unknown
		//IL_00c1: Expected O, but got I
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Expected O, but got Unknown
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Expected O, but got Unknown
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Expected O, but got Unknown
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Expected O, but got Unknown
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Expected O, but got Unknown
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Expected O, but got Unknown
		//IL_072c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0731: Expected O, but got Unknown
		//IL_073b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0740: Expected O, but got Unknown
		//IL_074a: Unknown result type (might be due to invalid IL or missing references)
		//IL_074f: Expected O, but got Unknown
		//IL_075b: Expected O, but got I
		//IL_0765: Unknown result type (might be due to invalid IL or missing references)
		//IL_076a: Expected O, but got Unknown
		//IL_077a: Expected O, but got I
		//IL_078f: Expected O, but got I
		//IL_07b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ba: Expected O, but got Unknown
		//IL_07d4: Expected O, but got I4
		//IL_022f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0234: Expected O, but got Unknown
		//IL_025e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0263: Expected O, but got Unknown
		//IL_01f6: Expected O, but got I4
		//IL_0297: Unknown result type (might be due to invalid IL or missing references)
		//IL_029c: Expected O, but got Unknown
		//IL_02a4: Expected I, but got O
		//IL_02b4: Expected O, but got I
		//IL_084b: Expected O, but got I
		//IL_085b: Expected O, but got I
		//IL_035e: Expected O, but got I4
		//IL_03c9: Expected I, but got O
		//IL_03d9: Expected O, but got I
		//IL_02ef: Expected O, but got I
		//IL_08bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c1: Expected O, but got Unknown
		//IL_08c9: Expected I, but got O
		//IL_08d9: Expected O, but got I
		//IL_0414: Expected O, but got I
		//IL_037a: Unknown result type (might be due to invalid IL or missing references)
		//IL_037f: Expected O, but got Unknown
		//IL_0387: Unknown result type (might be due to invalid IL or missing references)
		//IL_038c: Expected O, but got Unknown
		//IL_0395: Unknown result type (might be due to invalid IL or missing references)
		//IL_039a: Expected O, but got Unknown
		//IL_02fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0302: Expected O, but got Unknown
		//IL_030b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0310: Expected O, but got Unknown
		//IL_093b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0940: Expected O, but got Unknown
		//IL_04a8: Expected O, but got I
		//IL_046d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0472: Expected O, but got Unknown
		//IL_047a: Unknown result type (might be due to invalid IL or missing references)
		//IL_047f: Expected O, but got Unknown
		//IL_0488: Unknown result type (might be due to invalid IL or missing references)
		//IL_048d: Expected O, but got Unknown
		//IL_059d: Expected O, but got I
		//IL_05ad: Expected O, but got I
		//IL_05cf: Expected O, but got I4
		//IL_0422: Unknown result type (might be due to invalid IL or missing references)
		//IL_0427: Expected O, but got Unknown
		//IL_0430: Unknown result type (might be due to invalid IL or missing references)
		//IL_0435: Expected O, but got Unknown
		//IL_0640: Expected O, but got I
		//IL_0536: Expected O, but got I
		//IL_0546: Expected O, but got I
		//IL_0568: Expected O, but got I4
		//IL_0501: Unknown result type (might be due to invalid IL or missing references)
		//IL_0506: Expected O, but got Unknown
		//IL_050e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0513: Expected O, but got Unknown
		//IL_051c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0521: Expected O, but got Unknown
		//IL_0663: Unknown result type (might be due to invalid IL or missing references)
		//IL_0668: Expected O, but got Unknown
		//IL_05ff: Expected O, but got I4
		//IL_04b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04bb: Expected O, but got Unknown
		//IL_04c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c9: Expected O, but got Unknown
		//IL_097c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0981: Expected O, but got Unknown
		//IL_0997: Expected O, but got I
		//IL_09a8: Expected I, but got O
		//IL_09c6: Expected O, but got I
		//IL_062f: Expected O, but got I
		object varName = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 240;
		base..ctor();
		long num = SFSExtensions.Get(data, (string)varName, 0L);
		<Id>k__BackingField = num;
		object obj = typeof(System.IOAsyncCallback) + 976;
		object obj2 = "alignContent" + 4024;
		object obj3 = typeof(System.Buffers.Text.ParserHelpers) + 936;
		object varName2 = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 632;
		object obj4 = typeof(DataRelation) + 712;
		nint num2 = (nint)data;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X8_v6 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X8_v6 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0102;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X8_v6 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
		object obj6 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ X10_v25-8]");
			if (0 == (nint)obj)
			{
				break;
			}
			obj6 += 16;
			obj5--;
			if ((nint)obj5 != 1)
			{
				continue;
			}
			goto IL_0102;
		}
		object obj7 = (object)(num2 + (object)(obj6 + 29)) + 312;
		goto IL_06cf;
		IL_0455:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_08a8;
		IL_03c1:
		nint num3 = (nint)data;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v546 @ X8_v19 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v546 @ X8_v19 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0455;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v546 @ X8_v19 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
		object obj9 = (nint)0 + (nint)8;
		object obj10;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v597 @ X10_v15-8]");
			if (0 == (nint)obj10)
			{
				break;
			}
			obj9 += 16;
			obj8--;
			if ((nint)obj8 != 1)
			{
				continue;
			}
			goto IL_0455;
		}
		object obj11 = (object)(num3 + (object)(obj9 + 26)) + 312;
		goto IL_08a8;
		IL_04e9:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_0922;
		IL_05dd:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v738 @ X0_v51+E4]");
		object obj13;
		object obj14;
		if ((object)((nint)0 != 0) == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj12 = obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v752 @ X8_v40+B8]");
			obj14 = 0;
		}
		object obj15 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 736;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj16 = (nint)0 + (nint)2160;
		Func<double, double, Vector2> func = default(Func<double, double, Vector2>);
		func..ctor(obj14, (IntPtr)obj16);
		object obj17 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v728 @ X8_v39+B8]");
		object obj18 = (nint)0 + (nint)8;
		obj18 = func;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Func<double, double, Vector2> func2 = func;
		goto IL_0634;
		IL_0102:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_06cf;
		IL_06cf:
		object obj19 = "alignContent" + 4040;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v305 @ X0_v7] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		PlayerInfo playerInfo = default(PlayerInfo);
		ISFSObject data2 = default(ISFSObject);
		playerInfo..ctor(data2);
		object obj20 = this + 24;
		obj20 = playerInfo;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		string text = SFSExtensions.Get(data, (string)varName2, (string)null);
		object obj21 = this + 32;
		obj21 = text;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj22 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v362 @ X0_v21+E4]");
		object obj23;
		if ((nint)0 != 0)
		{
			obj23 = obj4;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj22 = obj4;
			obj23 = obj4;
		}
		object varName3 = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 1480;
		object varName4 = "alignContent" + 4032;
		object obj24 = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 1488;
		object obj25 = (nint)0 + (nint)104;
		object obj26 = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 1888;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v362 @ X0_v21+B8]");
		object obj27 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v371 @ X8_v10+10]");
		DateTime? defaultValue = (DateTime)0;
		string text2 = (string)obj19;
		DateTime? dateTime = SFSExtensions.Get(data, (string)obj19, defaultValue);
		object obj28 = (??)dateTime & 1;
		bool flag = obj28 == null;
		object obj29 = !flag;
		if (obj29 == null)
		{
			object obj30 = obj23;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v400 @ X0_v75+E4]");
			if ((object)((nint)0 != 0) == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj30 = obj23;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v400 @ X0_v75+B8]");
			object obj31 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v403 @ X8_v50+10]");
			text2 = (string)0;
		}
		<DateCreated>k__BackingField = (DateTime)text2;
		int num4 = SFSExtensions.Get(data, (string)varName3, 0);
		<CurrencyPerShard>k__BackingField = num4;
		int num5 = SFSExtensions.Get(data, (string)varName4, 0);
		<NumberOfShards>k__BackingField = num5;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @301ECBC");
		GiftBombType giftBombType = default(GiftBombType);
		<Category>k__BackingField = giftBombType;
		<IsClaimed>k__BackingField = SFSExtensions.Get(data, "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 1760, defaultValue: false);
		<TotalCost>k__BackingField = SFSExtensions.Get(data, "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 1496, 0);
		obj10 = typeof(System.IOAsyncCallback) + 976;
		nint num6 = (nint)data;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v454 @ X8_v16 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		object obj32 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v454 @ X8_v16 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0330;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v454 @ X8_v16 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
		object obj33 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v498 @ X10_v20-8]");
			if (0 == (nint)obj10)
			{
				break;
			}
			obj33 += 16;
			obj32--;
			if ((nint)obj32 != 1)
			{
				continue;
			}
			goto IL_0330;
		}
		object obj34 = (object)(num6 + (object)(obj33 + 1)) + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v520 @ X0_v71] (should have been resolved before IL gen)");
		object obj35 = default(object);
		if (obj35 != null)
		{
			goto IL_03c1;
		}
		return;
		IL_0922:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v697 @ X0_v41] (should have been resolved before IL gen)");
		obj13 = typeof(GameReplayController.<OnEndRoundEventIe>d__138) + 288;
		object obj36 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v738 @ X0_v51+E4]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v738 @ X0_v51+B8]");
			obj14 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v746 @ X8_v34+8]");
			func2 = (Func<double, double, Vector2>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v746 @ X8_v34+8]");
			if ((object)((nint)0 != 0) == null)
			{
				goto IL_05dd;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj36 = obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v738 @ X0_v51+B8]");
			obj14 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v746 @ X8_v34+8]");
			func2 = (Func<double, double, Vector2>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v746 @ X8_v34+8]");
			if ((object)((nint)0 != 0) == null)
			{
				goto IL_05dd;
			}
		}
		goto IL_0634;
		IL_0634:
		object obj37 = (nint)0 + (nint)3952;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2DEDA70");
		IEnumerable<Vector2> source = default(IEnumerable<Vector2>);
		List<Vector2> list = Enumerable.ToList(source);
		object obj38 = this + 72;
		obj38 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		return;
		IL_08a8:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v626 @ X0_v38] (should have been resolved before IL gen)");
		object obj39 = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 1896;
		nint num7 = (nint)data;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v637 @ X8_v24 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		object obj40 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v637 @ X8_v24 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_04e9;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v637 @ X8_v24 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
		object obj41 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v679 @ X10_v10-8]");
			if (0 == (nint)obj10)
			{
				break;
			}
			obj41 += 16;
			obj40--;
			if ((nint)obj40 != 1)
			{
				continue;
			}
			goto IL_04e9;
		}
		object obj42 = (object)(num7 + (object)(obj41 + 26)) + 312;
		goto IL_0922;
		IL_0330:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v487 @ X0_v68] (should have been resolved before IL gen)");
		object obj43 = default(object);
		if ((object)(obj43 != null) == null)
		{
			return;
		}
		goto IL_03c1;
	}

	public static GiftBombData FromSfsObject(ISFSObject data)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		object obj = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2848;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		GiftBombData giftBombData = default(GiftBombData);
		giftBombData..ctor(data);
		return giftBombData;
	}
}
