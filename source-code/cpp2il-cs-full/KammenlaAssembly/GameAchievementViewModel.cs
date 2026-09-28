using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using Cpp2ILInjected;
using Managers.Achievemenets;
using Unity.Properties;

public class GameAchievementViewModel
{
	private string <id>k__BackingField;

	private GameCategory <gameID>k__BackingField;

	private string <name>k__BackingField;

	private AchievementType <type>k__BackingField;

	private string <description>k__BackingField;

	private List<AchievementLevelModel> <achievementLevels>k__BackingField;

	private RoutingCommand <routingCommand>k__BackingField;

	private FileInfoModel <image>k__BackingField;

	public string id
	{
		get
		{
			return <id>k__BackingField;
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

	public GameCategory gameID
	{
		get
		{
			return <gameID>k__BackingField;
		}
		set
		{
			<gameID>k__BackingField = value;
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

	public AchievementType type
	{
		get
		{
			return <type>k__BackingField;
		}
		set
		{
			<type>k__BackingField = value;
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
			object obj = this + 48;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public List<AchievementLevelModel> achievementLevels
	{
		get
		{
			return <achievementLevels>k__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 56;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public RoutingCommand routingCommand
	{
		get
		{
			return <routingCommand>k__BackingField;
		}
		set
		{
			<routingCommand>k__BackingField = value;
		}
	}

	public FileInfoModel image
	{
		get
		{
			return <image>k__BackingField;
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
		//IL_015d: Expected O, but got I8
		//IL_0102: Expected I, but got O
		//IL_0112: Expected O, but got I
		//IL_013b: Expected O, but got I
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		//IL_018e: Expected O, but got Unknown
		//IL_0197: Unknown result type (might be due to invalid IL or missing references)
		//IL_019c: Expected O, but got Unknown
		//IL_01d7: Expected O, but got Ref
		//IL_0250: Expected O, but got I4
		//IL_0260: Expected O, but got I4
		//IL_0280: Unknown result type (might be due to invalid IL or missing references)
		//IL_0285: Expected O, but got Unknown
		//IL_01ed: Expected I, but got O
		//IL_01fd: Expected O, but got I
		//IL_0226: Expected O, but got I
		//IL_029c: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a1: Expected O, but got Unknown
		//IL_033d: Expected O, but got I8
		//IL_02e2: Expected I, but got O
		//IL_02f2: Expected O, but got I
		//IL_031b: Expected O, but got I
		//IL_0364: Unknown result type (might be due to invalid IL or missing references)
		//IL_0369: Expected O, but got Unknown
		//IL_0372: Unknown result type (might be due to invalid IL or missing references)
		//IL_0377: Expected O, but got Unknown
		object obj = typeof(TypeConverter<ushort, char>) + 3400;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		object[] array = default(object[]);
		if (array != null)
		{
			bool flag = <name>k__BackingField == null;
			string text = (string)4;
			IndexOutOfRangeException ex = default(IndexOutOfRangeException);
			string text2;
			if (!flag)
			{
				nint num = (nint)array;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X8_v18 (Il2CppClass<System.Object[]>)+40]");
				text = (string)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
				bool flag2 = ex == null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X8_v18 (Il2CppClass<System.Object[]>)+40]");
				text2 = (string)0;
				if (flag2)
				{
					goto IL_03bc;
				}
			}
			if (array.Length != 0)
			{
				object obj2 = array + 32;
				obj2 = <name>k__BackingField;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				bool flag3 = <id>k__BackingField == null;
				text = <name>k__BackingField;
				if (!flag3)
				{
					nint num2 = (nint)array;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ X8_v17 (Il2CppClass<System.Object[]>)+40]");
					text = (string)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag4 = ex == null;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ X8_v17 (Il2CppClass<System.Object[]>)+40]");
					text2 = (string)0;
					if (flag4)
					{
						goto IL_03bc;
					}
				}
				object obj3 = array.Length & 0xFFFFFFFEL;
				if (obj3 != null)
				{
					object obj4 = typeof(SqlSingle[]) + 2352;
					object obj5 = array + 40;
					obj5 = <id>k__BackingField;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
					string text3 = default(string);
					bool flag5 = text3 == null;
					AchievementType achievementType = default(AchievementType);
					text = (string)(&achievementType);
					if (!flag5)
					{
						nint num3 = (nint)array;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ X8_v16 (Il2CppClass<System.Object[]>)+40]");
						text = (string)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
						bool flag6 = ex == null;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ X8_v16 (Il2CppClass<System.Object[]>)+40]");
						text2 = (string)0;
						if (flag6)
						{
							goto IL_03bc;
						}
					}
					bool flag7 = array.Length < 2;
					object obj6 = !flag7;
					object obj7 = array.Length - 2;
					bool flag8 = obj7 == null;
					object obj8 = ~obj6;
					object obj9 = obj8 | flag8;
					if (obj9 == null)
					{
						object obj10 = array + 48;
						obj10 = text3;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						bool flag9 = <description>k__BackingField == null;
						text = text3;
						if (!flag9)
						{
							nint num4 = (nint)array;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ X8_v15 (Il2CppClass<System.Object[]>)+40]");
							text = (string)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
							bool flag10 = ex == null;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ X8_v15 (Il2CppClass<System.Object[]>)+40]");
							text2 = (string)0;
							if (flag10)
							{
								goto IL_03bc;
							}
						}
						object obj11 = array.Length & 0xFFFFFFFCL;
						if (obj11 != null)
						{
							object format = "<ds.DataTable.OnColumnChanging|INFO> {0}" + 3352;
							object obj12 = array + 56;
							obj12 = <description>k__BackingField;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							return string.Format((string)format, array);
						}
					}
				}
			}
			ex = new IndexOutOfRangeException();
			text2 = text;
			goto IL_03bc;
		}
		goto IL_03d4;
		IL_03bc:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		OutOfMemoryException ex2 = new OutOfMemoryException();
		goto IL_03d4;
		IL_03d4:
		return (string)(object)new NullReferenceException();
	}
}
