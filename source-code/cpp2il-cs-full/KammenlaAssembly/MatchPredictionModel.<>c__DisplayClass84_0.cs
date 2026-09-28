using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Newtonsoft.Json.Linq.JsonPath;
using PredictAndWinModel;
using Unity.Properties;
using Unity.Services.Authentication.Shared;
using UnityEngine.Rendering;

[Serializable]
public class MatchPredictionModel
{
	[StructLayout((LayoutKind)3)]
	private struct <>c__DisplayClass84_0
	{
		public int scoreValue;
	}

	private int <id>k__BackingField;

	private int <homeTeamScore>k__BackingField;

	private int <awayTeamScore>k__BackingField;

	private DateTime <displayDate>k__BackingField;

	private DateTime <expiryDate>k__BackingField;

	private string <twitterHashtags>k__BackingField;

	private int <sponsorId>k__BackingField;

	private FileInfoModel <sponsorImage>k__BackingField;

	private FileInfoModel <sponsorLogo>k__BackingField;

	private FileInfoModel <leagueLogo>k__BackingField;

	private int <correctScoreSubDays>k__BackingField;

	private int <correctScoreAces>k__BackingField;

	private int <correctWinnerSubDays>k__BackingField;

	private int <correctWinnerAces>k__BackingField;

	private int <participationSubDays>k__BackingField;

	private int <participationAces>k__BackingField;

	private bool <isSeasonMatch>k__BackingField;

	private Tweet <tweetImage>k__BackingField;

	private SportTeam <homeTeam>k__BackingField;

	private SportTeam <awayTeam>k__BackingField;

	private League <league>k__BackingField;

	public int id
	{
		get
		{
			return <id>k__BackingField;
		}
		set
		{
			<id>k__BackingField = value;
		}
	}

	public int homeTeamScore
	{
		get
		{
			return <homeTeamScore>k__BackingField;
		}
		set
		{
			<homeTeamScore>k__BackingField = value;
		}
	}

	public int awayTeamScore
	{
		get
		{
			return <awayTeamScore>k__BackingField;
		}
		set
		{
			<awayTeamScore>k__BackingField = value;
		}
	}

	public DateTime displayDate
	{
		get
		{
			return <displayDate>k__BackingField;
		}
		set
		{
			<displayDate>k__BackingField = value;
		}
	}

	public DateTime expiryDate
	{
		get
		{
			return <expiryDate>k__BackingField;
		}
		set
		{
			<expiryDate>k__BackingField = value;
		}
	}

	public string twitterHashtags
	{
		get
		{
			return <twitterHashtags>k__BackingField;
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

	public int sponsorId
	{
		get
		{
			return <sponsorId>k__BackingField;
		}
		set
		{
			<sponsorId>k__BackingField = value;
		}
	}

	public FileInfoModel sponsorImage
	{
		get
		{
			return <sponsorImage>k__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 64;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public FileInfoModel sponsorLogo
	{
		get
		{
			return <sponsorLogo>k__BackingField;
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

	public FileInfoModel leagueLogo
	{
		get
		{
			return <leagueLogo>k__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 80;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public int correctScoreSubDays
	{
		get
		{
			return <correctScoreSubDays>k__BackingField;
		}
		set
		{
			<correctScoreSubDays>k__BackingField = value;
		}
	}

	public int correctScoreAces
	{
		get
		{
			return <correctScoreAces>k__BackingField;
		}
		set
		{
			<correctScoreAces>k__BackingField = value;
		}
	}

	public int correctWinnerSubDays
	{
		get
		{
			return <correctWinnerSubDays>k__BackingField;
		}
		set
		{
			<correctWinnerSubDays>k__BackingField = value;
		}
	}

	public int correctWinnerAces
	{
		get
		{
			return <correctWinnerAces>k__BackingField;
		}
		set
		{
			<correctWinnerAces>k__BackingField = value;
		}
	}

	public int participationSubDays
	{
		get
		{
			return <participationSubDays>k__BackingField;
		}
		set
		{
			<participationSubDays>k__BackingField = value;
		}
	}

	public int participationAces
	{
		get
		{
			return <participationAces>k__BackingField;
		}
		set
		{
			<participationAces>k__BackingField = value;
		}
	}

	public bool isSeasonMatch
	{
		get
		{
			return <isSeasonMatch>k__BackingField;
		}
		set
		{
			<isSeasonMatch>k__BackingField = value;
		}
	}

	public Tweet tweetImage
	{
		get
		{
			return <tweetImage>k__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 120;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public SportTeam homeTeam
	{
		get
		{
			return <homeTeam>k__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 128;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public SportTeam awayTeam
	{
		get
		{
			return <awayTeam>k__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 136;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public League league
	{
		get
		{
			return <league>k__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 144;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public List<(int, int)> GetValidScores()
	{
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Expected O, but got Unknown
		//IL_00e1: Expected O, but got I
		League league = <league>k__BackingField;
		if (league.<scoreType>k__BackingField != League.Score.Open)
		{
			<>c__DisplayClass84_0 <>c__DisplayClass84_ = default(<>c__DisplayClass84_0);
			if (league.<scoreType>k__BackingField != League.Score.NumberOfGames)
			{
				if (league.<scoreType>k__BackingField == League.Score.BestOf)
				{
					return <GetValidScores>g__GetFirstTo|84_0(ref <>c__DisplayClass84_);
				}
				object obj = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 656;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				ArgumentOutOfRangeException ex = default(ArgumentOutOfRangeException);
				ex..ctor();
				object obj2 = (nint)0 + (nint)3856;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
				return (List<(int, int)>)(object)new OutOfMemoryException();
			}
			return <GetValidScores>g__NumberOfGames|84_1(ref <>c__DisplayClass84_);
		}
		return null;
	}

	public unsafe override string ToString()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0493: Expected O, but got I4
		//IL_04b4: Expected O, but got Ref
		//IL_0030: Expected O, but got Ref
		//IL_0046: Expected I, but got O
		//IL_0056: Expected O, but got I
		//IL_007f: Expected O, but got I
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Expected O, but got Unknown
		//IL_018a: Expected O, but got I8
		//IL_012f: Expected I, but got O
		//IL_013f: Expected O, but got I
		//IL_0168: Expected O, but got I
		//IL_01b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b5: Expected O, but got Unknown
		//IL_029c: Expected O, but got I4
		//IL_02ac: Expected O, but got I4
		//IL_02cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d1: Expected O, but got Unknown
		//IL_0239: Expected I, but got O
		//IL_0249: Expected O, but got I
		//IL_0272: Expected O, but got I
		//IL_02e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ed: Expected O, but got Unknown
		//IL_03cc: Expected O, but got I8
		//IL_0371: Expected I, but got O
		//IL_0381: Expected O, but got I
		//IL_03aa: Expected O, but got I
		//IL_03f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f8: Expected O, but got Unknown
		//IL_0401: Unknown result type (might be due to invalid IL or missing references)
		//IL_0406: Expected O, but got Unknown
		object obj = typeof(TypeConverter<ushort, char>) + 3400;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		object obj2 = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object[] array = default(object[]);
		bool flag = array == null;
		int num = default(int);
		string text = (string)(&num);
		if (flag)
		{
			goto IL_0438;
		}
		string text2 = default(string);
		bool flag2 = text2 == null;
		text = (string)(&num);
		IndexOutOfRangeException ex = default(IndexOutOfRangeException);
		string text3;
		if (!flag2)
		{
			nint num2 = (nint)array;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X8_v23 (Il2CppClass<System.Object[]>)+40]");
			text = (string)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
			bool flag3 = ex == null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X8_v23 (Il2CppClass<System.Object[]>)+40]");
			text3 = (string)0;
			if (flag3)
			{
				goto IL_045c;
			}
		}
		if (array.Length != 0)
		{
			object obj3 = array + 32;
			obj3 = text2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			League league = <league>k__BackingField;
			bool flag4 = <league>k__BackingField == null;
			text = text2;
			if (flag4)
			{
				goto IL_0438;
			}
			bool flag5 = league.<leagueName>k__BackingField == null;
			text = text2;
			if (!flag5)
			{
				nint num3 = (nint)array;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ X8_v22 (Il2CppClass<System.Object[]>)+40]");
				text = (string)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
				bool flag6 = ex == null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ X8_v22 (Il2CppClass<System.Object[]>)+40]");
				text3 = (string)0;
				if (flag6)
				{
					goto IL_045c;
				}
			}
			object obj4 = array.Length & 0xFFFFFFFEL;
			if (obj4 != null)
			{
				object obj5 = array + 40;
				obj5 = league.<leagueName>k__BackingField;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				SportTeam sportTeam = <homeTeam>k__BackingField;
				bool flag7 = <homeTeam>k__BackingField == null;
				text = league.<leagueName>k__BackingField;
				if (flag7)
				{
					goto IL_0438;
				}
				bool flag8 = sportTeam.<name>k__BackingField == null;
				text = league.<leagueName>k__BackingField;
				if (!flag8)
				{
					nint num4 = (nint)array;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ X8_v21 (Il2CppClass<System.Object[]>)+40]");
					text = (string)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag9 = ex == null;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ X8_v21 (Il2CppClass<System.Object[]>)+40]");
					text3 = (string)0;
					if (flag9)
					{
						goto IL_045c;
					}
				}
				bool flag10 = array.Length < 2;
				object obj6 = !flag10;
				object obj7 = array.Length - 2;
				bool flag11 = obj7 == null;
				object obj8 = ~obj6;
				object obj9 = obj8 | flag11;
				if (obj9 == null)
				{
					object obj10 = array + 48;
					obj10 = sportTeam.<name>k__BackingField;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					SportTeam sportTeam2 = <awayTeam>k__BackingField;
					bool flag12 = <awayTeam>k__BackingField == null;
					text = sportTeam.<name>k__BackingField;
					if (flag12)
					{
						goto IL_0438;
					}
					bool flag13 = sportTeam2.<name>k__BackingField == null;
					text = sportTeam.<name>k__BackingField;
					if (!flag13)
					{
						nint num5 = (nint)array;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ X8_v20 (Il2CppClass<System.Object[]>)+40]");
						text = (string)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
						bool flag14 = ex == null;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ X8_v20 (Il2CppClass<System.Object[]>)+40]");
						text3 = (string)0;
						if (flag14)
						{
							goto IL_045c;
						}
					}
					object obj11 = array.Length & 0xFFFFFFFCL;
					if (obj11 != null)
					{
						object format = "https://www.kammelna.com/Home/Terms" + 344;
						object obj12 = array + 56;
						obj12 = sportTeam2.<name>k__BackingField;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						return string.Format((string)format, array);
					}
				}
			}
		}
		goto IL_0446;
		IL_045c:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		return (string)(object)new OutOfMemoryException();
		IL_0446:
		ex = new IndexOutOfRangeException();
		text3 = text;
		goto IL_045c;
		IL_0438:
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_0446;
	}

	internal static List<(int, int)> <GetValidScores>g__GetFirstTo|84_0(ref <>c__DisplayClass84_0 P_0)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_03a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ac: Expected O, but got Unknown
		//IL_03d7: Expected O, but got I4
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_0072: Expected O, but got I4
		//IL_03fe: Expected O, but got I4
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected O, but got Unknown
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Expected O, but got Unknown
		//IL_019f: Expected O, but got I
		//IL_01b4: Expected O, but got I
		//IL_0202: Expected O, but got I4
		//IL_028f: Expected O, but got I
		//IL_02a4: Expected O, but got I
		//IL_0226: Expected O, but got I
		//IL_0248: Expected O, but got I
		//IL_02f2: Expected O, but got I4
		//IL_0316: Expected O, but got I
		//IL_0338: Expected O, but got I
		object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 4000;
		object obj2 = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 3872;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTP not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<(int, int)> list = default(List<(int, int)>);
		list..ctor();
		object obj6 = default(object);
		object obj5 = obj6 - 2139095040;
		bool flag2 = obj5 == null;
		object obj7 = !flag2;
		object obj8 = ~obj7;
		bool flag3;
		bool flag4;
		if (obj8 == null)
		{
			object obj9 = P_0 - 1;
			flag3 = (nint)obj9 < 0;
			object obj10 = P_0 ^ 1;
			object obj11 = (object)P_0 ^ obj9;
			object obj12 = obj10 & obj11;
			flag4 = (nint)obj12 < 0;
		}
		else
		{
			flag4 = false;
			flag3 = true;
		}
		bool flag5 = flag3 == flag4;
		object obj13 = !flag5;
		if (obj13 == null)
		{
			if (list != null)
			{
				int num = 0;
				while (true)
				{
					(int, int) item = (2, num);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v5 (System.Collections.Generic.List`1<System.ValueTuple`2<System.Int32, System.Int32>>)+1C]");
					object obj14 = (nint)0 + (nint)1;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v5 (System.Collections.Generic.List`1<System.ValueTuple`2<System.Int32, System.Int32>>)+10]");
					object obj15 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v5 (System.Collections.Generic.List`1<System.ValueTuple`2<System.Int32, System.Int32>>)+10]");
					if ((nint)0 == 0)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v5 (System.Collections.Generic.List`1<System.ValueTuple`2<System.Int32, System.Int32>>)+18]");
					nint num2 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v284 @ X9_v6+18]");
					bool flag6 = num2 < 0;
					object obj16 = !flag6;
					if (obj16 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v5 (System.Collections.Generic.List`1<System.ValueTuple`2<System.Int32, System.Int32>>)+18]");
						object obj17 = (nint)0 + (nint)1;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v5 (System.Collections.Generic.List`1<System.ValueTuple`2<System.Int32, System.Int32>>)+10]");
						nint num3 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v5 (System.Collections.Generic.List`1<System.ValueTuple`2<System.Int32, System.Int32>>)+18]");
						object obj18 = num3 + 0;
					}
					else
					{
						list.AddWithResize(item);
					}
					(int, int) item2 = (num, 2);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v5 (System.Collections.Generic.List`1<System.ValueTuple`2<System.Int32, System.Int32>>)+1C]");
					object obj19 = (nint)0 + (nint)1;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v5 (System.Collections.Generic.List`1<System.ValueTuple`2<System.Int32, System.Int32>>)+10]");
					object obj20 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v5 (System.Collections.Generic.List`1<System.ValueTuple`2<System.Int32, System.Int32>>)+10]");
					if ((nint)0 == 0)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v5 (System.Collections.Generic.List`1<System.ValueTuple`2<System.Int32, System.Int32>>)+18]");
					nint num4 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X9_v9+18]");
					bool flag7 = num4 < 0;
					object obj21 = !flag7;
					if (obj21 != null)
					{
						list.AddWithResize(item2);
						num++;
						if (num < (nint)P_0)
						{
							continue;
						}
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v5 (System.Collections.Generic.List`1<System.ValueTuple`2<System.Int32, System.Int32>>)+18]");
						object obj22 = (nint)0 + (nint)1;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v5 (System.Collections.Generic.List`1<System.ValueTuple`2<System.Int32, System.Int32>>)+10]");
						nint num5 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v5 (System.Collections.Generic.List`1<System.ValueTuple`2<System.Int32, System.Int32>>)+18]");
						object obj23 = num5 + 0;
						num++;
						if (num < (nint)P_0)
						{
							continue;
						}
					}
					goto IL_036c;
				}
			}
			else
			{
				(int, int) item = (2, 0);
			}
			return (List<(int, int)>)(object)new NullReferenceException();
		}
		goto IL_036c;
		IL_036c:
		return list;
	}

	internal static List<(int, int)> <GetValidScores>g__NumberOfGames|84_1(ref <>c__DisplayClass84_0 P_0)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_037f: Expected I4, but got O
		//IL_0335: Expected I4, but got O
		//IL_034c: Expected I4, but got O
		//IL_0043: Expected O, but got I4
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Expected I4, but got Unknown
		//IL_00e2: Expected I4, but got O
		//IL_0123: Expected O, but got I4
		//IL_03cc: Expected O, but got I4
		//IL_0080: Expected I4, but got O
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Expected O, but got Unknown
		//IL_0148: Expected O, but got I
		//IL_015d: Expected O, but got I
		//IL_0214: Expected O, but got I
		//IL_0229: Expected O, but got I
		//IL_01ad: Expected O, but got I4
		//IL_0277: Expected O, but got I4
		//IL_0306: Expected O, but got I4
		//IL_01d1: Expected O, but got I
		//IL_01f3: Expected O, but got I
		//IL_029b: Expected O, but got I
		//IL_02bd: Expected O, but got I
		object obj = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 3872;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<(int, int)> list = default(List<(int, int)>);
		list..ctor();
		int num = (int)P_0;
		if ((nint)P_0 >= 1)
		{
			if (list != null)
			{
				object obj2 = 0;
				int num2 = 0;
				while (true)
				{
					int item = num + obj2;
					(int, int) item2 = (num2, item);
					int item3 = (int)(obj2 + (object)P_0);
					(int, int) item4 = (item3, num2);
					bool flag = list.Contains(item2);
					bool flag2 = !flag;
					object obj3 = !flag2;
					object obj5;
					if (obj3 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v3 (System.Collections.Generic.List`1<System.ValueTuple`2<System.Int32, System.Int32>>)+1C]");
						object obj4 = (nint)0 + (nint)1;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v3 (System.Collections.Generic.List`1<System.ValueTuple`2<System.Int32, System.Int32>>)+10]");
						obj5 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v3 (System.Collections.Generic.List`1<System.ValueTuple`2<System.Int32, System.Int32>>)+10]");
						if ((nint)0 == 0)
						{
							break;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v3 (System.Collections.Generic.List`1<System.ValueTuple`2<System.Int32, System.Int32>>)+18]");
						nint num3 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X9_v12+18]");
						bool flag3 = num3 < 0;
						object obj6 = !flag3;
						if (obj6 != null)
						{
							list.AddWithResize(item2);
							bool flag4 = list.Contains(item4);
							bool flag5 = !flag4;
							object obj7 = !flag5;
							if (obj7 != null)
							{
								goto IL_0065;
							}
							goto IL_01fd;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v3 (System.Collections.Generic.List`1<System.ValueTuple`2<System.Int32, System.Int32>>)+18]");
						object obj8 = (nint)0 + (nint)1;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v3 (System.Collections.Generic.List`1<System.ValueTuple`2<System.Int32, System.Int32>>)+10]");
						nint num4 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v3 (System.Collections.Generic.List`1<System.ValueTuple`2<System.Int32, System.Int32>>)+18]");
						object obj9 = num4 + 0;
					}
					bool flag6 = list.Contains(item4);
					bool flag7 = !flag6;
					object obj10 = !flag7;
					if (obj10 != null)
					{
						goto IL_0065;
					}
					goto IL_01fd;
					IL_0065:
					num2++;
					num = (int)P_0;
					obj2--;
					if (num2 < (nint)P_0)
					{
						continue;
					}
					goto IL_0319;
					IL_01fd:
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v3 (System.Collections.Generic.List`1<System.ValueTuple`2<System.Int32, System.Int32>>)+1C]");
					object obj11 = (nint)0 + (nint)1;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v3 (System.Collections.Generic.List`1<System.ValueTuple`2<System.Int32, System.Int32>>)+10]");
					obj5 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v3 (System.Collections.Generic.List`1<System.ValueTuple`2<System.Int32, System.Int32>>)+10]");
					if ((nint)0 == 0)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v3 (System.Collections.Generic.List`1<System.ValueTuple`2<System.Int32, System.Int32>>)+18]");
					nint num5 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X9_v12+18]");
					bool flag8 = num5 < 0;
					object obj12 = !flag8;
					if (obj12 != null)
					{
						list.AddWithResize(item4);
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v3 (System.Collections.Generic.List`1<System.ValueTuple`2<System.Int32, System.Int32>>)+18]");
						object obj13 = (nint)0 + (nint)1;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v3 (System.Collections.Generic.List`1<System.ValueTuple`2<System.Int32, System.Int32>>)+10]");
						nint num6 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v3 (System.Collections.Generic.List`1<System.ValueTuple`2<System.Int32, System.Int32>>)+18]");
						object obj14 = num6 + 0;
					}
					goto IL_0065;
				}
			}
			else
			{
				(int, int) item2 = (0, (int)P_0);
				(int, int) item4 = ((int)P_0, 0);
			}
			return (List<(int, int)>)(object)new NullReferenceException();
		}
		goto IL_0319;
		IL_0319:
		return list;
	}
}
