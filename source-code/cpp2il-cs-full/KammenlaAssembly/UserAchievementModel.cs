using System;
using Cpp2ILInjected;
using Unity.Properties;

public class UserAchievementModel
{
	private string <gameAchievementId>k__BackingField;

	private int <value>k__BackingField;

	private int <levelId>k__BackingField;

	private string <name>k__BackingField;

	private string <description>k__BackingField;

	private string <progress>k__BackingField;

	private DateTime? <lastUpdate>k__BackingField;

	private DateTime? <celebrationUntil>k__BackingField;

	private bool <claimed>k__BackingField;

	private const string MonthlyTrophyID = "monthly_winner";

	private const string SecondMonthlyTrophyID = "monthly_second";

	private const string LeaderBoardMonthlyTrophyID = "monthly_ranker";

	public string gameAchievementId
	{
		get
		{
			return <gameAchievementId>k__BackingField;
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

	public int value
	{
		get
		{
			return <value>k__BackingField;
		}
		set
		{
			<value>k__BackingField = value;
		}
	}

	public int levelId
	{
		get
		{
			return <levelId>k__BackingField;
		}
		set
		{
			<levelId>k__BackingField = value;
		}
	}

	public string name
	{
		get
		{
			return <name>k__BackingField;
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

	public string description
	{
		get
		{
			return <description>k__BackingField;
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

	public string progress
	{
		get
		{
			return <progress>k__BackingField;
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

	public DateTime? lastUpdate
	{
		get
		{
			return <lastUpdate>k__BackingField;
		}
		set
		{
			<lastUpdate>k__BackingField = value;
		}
	}

	public DateTime? celebrationUntil
	{
		get
		{
			return <celebrationUntil>k__BackingField;
		}
		set
		{
			<celebrationUntil>k__BackingField = value;
		}
	}

	public bool claimed
	{
		get
		{
			return <claimed>k__BackingField;
		}
		set
		{
			<claimed>k__BackingField = value;
		}
	}

	public bool isUnlocked
	{
		get
		{
			//IL_006a: Expected O, but got I4
			//IL_0072: Unknown result type (might be due to invalid IL or missing references)
			//IL_0077: Expected I4, but got Unknown
			bool flag = <levelId>k__BackingField < 0;
			bool flag2 = <levelId>k__BackingField == 0;
			int num = <levelId>k__BackingField ^ <levelId>k__BackingField;
			int num2 = <levelId>k__BackingField & num;
			bool flag3 = num2 < 0;
			bool flag4 = flag == flag3;
			object obj = !flag2;
			return (byte)((flag4 & obj) ? 1 : 0) != 0;
		}
	}

	public bool IsCelebrationTrophy()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_00ad: Expected O, but got I4
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected O, but got Unknown
		object obj = "m_StencilDeferredPS" + 2376;
		bool flag = <gameAchievementId>k__BackingField == (string)obj;
		bool flag2 = !flag;
		object obj2 = !flag2;
		if (obj2 == null)
		{
			object obj3 = "m_StencilDeferredPS" + 2352;
			if (!(<gameAchievementId>k__BackingField == (string)obj3))
			{
				object obj4 = "m_StencilDeferredPS" + 2344;
				return <gameAchievementId>k__BackingField == (string)obj4;
			}
		}
		return true;
	}

	public unsafe override string ToString()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0033: Expected O, but got I4
		//IL_0049: Expected I, but got O
		//IL_0059: Expected O, but got I
		//IL_0082: Expected O, but got I
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Expected O, but got Unknown
		//IL_00e1: Expected O, but got I4
		//IL_0107: Expected O, but got Ref
		//IL_0178: Expected O, but got I8
		//IL_011d: Expected I, but got O
		//IL_012d: Expected O, but got I
		//IL_0156: Expected O, but got I
		//IL_019e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a3: Expected O, but got Unknown
		//IL_01dc: Expected O, but got Ref
		//IL_0255: Expected O, but got I4
		//IL_0265: Expected O, but got I4
		//IL_0285: Unknown result type (might be due to invalid IL or missing references)
		//IL_028a: Expected O, but got Unknown
		//IL_01f2: Expected I, but got O
		//IL_0202: Expected O, but got I
		//IL_022b: Expected O, but got I
		//IL_02a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a6: Expected O, but got Unknown
		//IL_02df: Expected O, but got Ref
		//IL_0350: Expected O, but got I8
		//IL_02f5: Expected I, but got O
		//IL_0305: Expected O, but got I
		//IL_032e: Expected O, but got I
		//IL_0377: Unknown result type (might be due to invalid IL or missing references)
		//IL_037c: Expected O, but got Unknown
		//IL_0385: Unknown result type (might be due to invalid IL or missing references)
		//IL_038a: Expected O, but got Unknown
		object obj = typeof(TypeConverter<ushort, char>) + 3400;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		object[] array = default(object[]);
		if (array != null)
		{
			bool flag = <gameAchievementId>k__BackingField == null;
			object obj2 = 4;
			IndexOutOfRangeException ex = default(IndexOutOfRangeException);
			object obj3;
			if (!flag)
			{
				nint num = (nint)array;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X8_v20 (Il2CppClass<System.Object[]>)+40]");
				obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
				bool flag2 = ex == null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X8_v20 (Il2CppClass<System.Object[]>)+40]");
				obj3 = 0;
				if (flag2)
				{
					goto IL_03cd;
				}
			}
			if (array.Length != 0)
			{
				object obj4 = array + 32;
				obj4 = <gameAchievementId>k__BackingField;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				object obj5 = 153100288 + 1024;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
				object obj6 = default(object);
				bool flag3 = obj6 == null;
				int num2 = default(int);
				obj2 = (object)(&num2);
				if (!flag3)
				{
					nint num3 = (nint)array;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ X8_v19 (Il2CppClass<System.Object[]>)+40]");
					obj2 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag4 = ex == null;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ X8_v19 (Il2CppClass<System.Object[]>)+40]");
					obj3 = 0;
					if (flag4)
					{
						goto IL_03cd;
					}
				}
				object obj7 = array.Length & 0xFFFFFFFEL;
				if (obj7 != null)
				{
					object obj8 = array + 40;
					obj8 = obj6;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
					object obj9 = default(object);
					bool flag5 = obj9 == null;
					int num4 = default(int);
					obj2 = (object)(&num4);
					if (!flag5)
					{
						nint num5 = (nint)array;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ X8_v18 (Il2CppClass<System.Object[]>)+40]");
						obj2 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
						bool flag6 = ex == null;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ X8_v18 (Il2CppClass<System.Object[]>)+40]");
						obj3 = 0;
						if (flag6)
						{
							goto IL_03cd;
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
						bool flag10 = default(bool);
						obj2 = (object)(&flag10);
						if (!flag9)
						{
							nint num6 = (nint)array;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ X8_v17 (Il2CppClass<System.Object[]>)+40]");
							obj2 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
							bool flag11 = ex == null;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ X8_v17 (Il2CppClass<System.Object[]>)+40]");
							obj3 = 0;
							if (flag11)
							{
								goto IL_03cd;
							}
						}
						object obj16 = array.Length & 0xFFFFFFFCL;
						if (obj16 != null)
						{
							object format = "WhiteSmoke" + 3776;
							object obj17 = array + 56;
							obj17 = obj15;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							return string.Format((string)format, array);
						}
					}
				}
			}
			ex = new IndexOutOfRangeException();
			obj3 = obj2;
			goto IL_03cd;
		}
		goto IL_03e5;
		IL_03cd:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		OutOfMemoryException ex2 = new OutOfMemoryException();
		goto IL_03e5;
		IL_03e5:
		return (string)(object)new NullReferenceException();
	}
}
