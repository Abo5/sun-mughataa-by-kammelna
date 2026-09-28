using System;
using Cpp2ILInjected;
using Unity.Properties;

public static class TournamentUtil
{
	public unsafe static LocalizableText GetTournamentRoundName(int round, int totalRounds)
	{
		//IL_0209: Expected O, but got I4
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected O, but got Unknown
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected O, but got Unknown
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Expected O, but got Unknown
		//IL_00aa: Expected O, but got I4
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected O, but got Unknown
		//IL_01c4: Expected O, but got Ref
		//IL_00ed: Expected O, but got Ref
		//IL_0103: Expected I, but got O
		//IL_0113: Expected O, but got I
		//IL_013c: Expected O, but got I
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Expected O, but got Unknown
		//IL_0193: Unknown result type (might be due to invalid IL or missing references)
		//IL_0198: Expected O, but got Unknown
		object obj = totalRounds - round;
		object text2;
		if ((nint)obj != 2)
		{
			if ((nint)obj != 1)
			{
				if (totalRounds != round)
				{
					object obj2 = typeof(TypeConverter<ushort, char>) + 3400;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
					object obj3 = 153100288 + 1024;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
					object[] array = default(object[]);
					object obj5;
					int num = default(int);
					IndexOutOfRangeException ex = default(IndexOutOfRangeException);
					object obj6;
					if (array != null)
					{
						object obj4 = default(object);
						bool flag = obj4 == null;
						obj5 = (object)(&num);
						if (!flag)
						{
							nint num2 = (nint)array;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X8_v19 (Il2CppClass<System.Object[]>)+40]");
							obj5 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
							bool flag2 = ex == null;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X8_v19 (Il2CppClass<System.Object[]>)+40]");
							obj6 = 0;
							if (flag2)
							{
								goto IL_01df;
							}
						}
						if (array.Length != 0)
						{
							object obj7 = array + 32;
							obj7 = obj4;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							object text = "Read object reference Id '{0}' for {1}." + 3592;
							return TextMeshProExtensions.LocalizeWith((string)text, array);
						}
					}
					else
					{
						NullReferenceException ex2 = new NullReferenceException();
						obj5 = (object)(&num);
					}
					ex = new IndexOutOfRangeException();
					obj6 = obj5;
					goto IL_01df;
				}
				text2 = "FilterFunction '{0}' expects {1} parameters but only {2} were provided. Missing parameters will be set to their default values." + 32;
			}
			else
			{
				text2 = "SERVICE_DISABLED" + 2712;
			}
		}
		else
		{
			text2 = "Picking audio files is not supported on iOS" + 3072;
		}
		return TextMeshProExtensions.Localize((string)text2);
		IL_01df:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		return (LocalizableText)(object)new OutOfMemoryException();
	}

	public unsafe static LocalizableText GetActiveClusterName(int subTournamentsCount)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0158: Expected O, but got I4
		//IL_0107: Expected O, but got Ref
		//IL_0030: Expected O, but got Ref
		//IL_0046: Expected I, but got O
		//IL_0056: Expected O, but got I
		//IL_007f: Expected O, but got I
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected O, but got Unknown
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Expected O, but got Unknown
		object obj = typeof(TypeConverter<ushort, char>) + 3400;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		object obj2 = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object[] array = default(object[]);
		object obj4;
		int num = default(int);
		IndexOutOfRangeException ex = default(IndexOutOfRangeException);
		object obj5;
		if (array != null)
		{
			object obj3 = default(object);
			bool flag = obj3 == null;
			obj4 = (object)(&num);
			if (!flag)
			{
				nint num2 = (nint)array;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X8_v9 (Il2CppClass<System.Object[]>)+40]");
				obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
				bool flag2 = ex == null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X8_v9 (Il2CppClass<System.Object[]>)+40]");
				obj5 = 0;
				if (flag2)
				{
					goto IL_0122;
				}
			}
			if (array.Length != 0)
			{
				object text = "ThisIsFakeReceiptData" + 1512;
				object obj6 = array + 32;
				obj6 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				return TextMeshProExtensions.LocalizeWith((string)text, array);
			}
		}
		else
		{
			NullReferenceException ex2 = new NullReferenceException();
			obj4 = (object)(&num);
		}
		ex = new IndexOutOfRangeException();
		obj5 = obj4;
		goto IL_0122;
		IL_0122:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		return (LocalizableText)(object)new OutOfMemoryException();
	}
}
