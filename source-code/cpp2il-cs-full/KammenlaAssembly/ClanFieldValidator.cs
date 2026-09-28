using System;
using Cpp2ILInjected;
using Unity.Properties;
using UnityEngine;
using UnityEngine.Purchasing.Telemetry;

public static class ClanFieldValidator
{
	public const int NameMin = 3;

	public const int NameMax = 30;

	public const int DescriptionMin = 1;

	public const int DescriptionMax = 500;

	public const int RulesMin = 1;

	public const int RulesMax = 2000;

	public unsafe static bool Validate(string name, string description, string rules)
	{
		//IL_0776: Unknown result type (might be due to invalid IL or missing references)
		//IL_077b: Expected O, but got Unknown
		//IL_0049: Expected O, but got I4
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_007c: Expected O, but got I4
		//IL_07f9: Expected O, but got I4
		//IL_07b4: Expected O, but got I4
		//IL_0767: Expected I4, but got O
		//IL_009d: Expected O, but got I4
		//IL_00b7: Expected O, but got I4
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Expected O, but got Unknown
		//IL_012c: Expected O, but got I4
		//IL_0152: Expected O, but got Ref
		//IL_0340: Expected O, but got I4
		//IL_0177: Expected O, but got Ref
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Expected O, but got Unknown
		//IL_0373: Expected O, but got I4
		//IL_018d: Expected I, but got O
		//IL_019d: Expected O, but got I
		//IL_01c6: Expected O, but got I
		//IL_0204: Unknown result type (might be due to invalid IL or missing references)
		//IL_0209: Expected O, but got Unknown
		//IL_0394: Expected O, but got I4
		//IL_03ae: Expected O, but got I4
		//IL_0241: Expected O, but got Ref
		//IL_0405: Unknown result type (might be due to invalid IL or missing references)
		//IL_040a: Expected O, but got Unknown
		//IL_0423: Expected O, but got I4
		//IL_02b2: Expected O, but got I8
		//IL_0449: Expected O, but got Ref
		//IL_0257: Expected I, but got O
		//IL_0267: Expected O, but got I
		//IL_0290: Expected O, but got I
		//IL_0622: Expected O, but got I4
		//IL_02e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e5: Expected O, but got Unknown
		//IL_0301: Unknown result type (might be due to invalid IL or missing references)
		//IL_0306: Expected O, but got Unknown
		//IL_046e: Expected O, but got Ref
		//IL_03ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f1: Expected O, but got Unknown
		//IL_0850: Expected O, but got I4
		//IL_0655: Expected O, but got I4
		//IL_0484: Expected I, but got O
		//IL_0494: Expected O, but got I
		//IL_04bd: Expected O, but got I
		//IL_04fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0500: Expected O, but got Unknown
		//IL_0538: Expected O, but got Ref
		//IL_0684: Unknown result type (might be due to invalid IL or missing references)
		//IL_0689: Expected O, but got Unknown
		//IL_06a2: Expected O, but got I4
		//IL_05a9: Expected O, but got I8
		//IL_06c8: Expected O, but got Ref
		//IL_054e: Expected I, but got O
		//IL_055e: Expected O, but got I
		//IL_0587: Expected O, but got I
		//IL_05d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_05dc: Expected O, but got Unknown
		//IL_05f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_05fd: Expected O, but got Unknown
		//IL_071c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0721: Expected O, but got Unknown
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1240;
		object text;
		if (string.IsNullOrWhiteSpace(name))
		{
			text = "Drop Menu Toggle" + 3208;
			goto IL_07c2;
		}
		bool flag = name == null;
		object obj2 = 0;
		object text6;
		object[] array2;
		IndexOutOfRangeException ex = default(IndexOutOfRangeException);
		if (!flag)
		{
			string text2 = name.Trim();
			bool flag2 = text2 == null;
			obj2 = 0;
			if (!flag2)
			{
				object obj3 = text2._stringLength - 3;
				bool flag3 = (nint)obj3 < 28;
				object obj4 = !flag3;
				object obj9 = default(object);
				object obj17 = default(object);
				if (obj4 == null)
				{
					if (string.IsNullOrWhiteSpace(description))
					{
						text = "Drop Menu Toggle" + 3192;
						goto IL_07c2;
					}
					bool flag4 = description == null;
					obj2 = 0;
					if (!flag4)
					{
						string text3 = description.Trim();
						bool flag5 = text3 == null;
						obj2 = 0;
						if (!flag5)
						{
							object obj5 = text3._stringLength - 1;
							bool flag6 = (nint)obj5 < 500;
							object obj6 = !flag6;
							if (obj6 == null)
							{
								string text4 = default(string);
								if (string.IsNullOrWhiteSpace(text4))
								{
									text = "Drop Menu Toggle" + 3200;
									goto IL_07c2;
								}
								bool flag7 = text4 == null;
								obj2 = 0;
								if (!flag7)
								{
									string text5 = text4.Trim();
									bool flag8 = text5 == null;
									obj2 = 0;
									if (!flag8)
									{
										bool flag9 = true;
										object obj7 = typeof(TypeConverter<ushort, char>) + 3400;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
										object obj8 = 153100288 + 1024;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
										object[] array = default(object[]);
										bool flag10 = array == null;
										obj2 = (object)(&obj9);
										if (!flag10)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C9ABFC");
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C9AC34");
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C9ABFC");
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C9AC34");
											text6 = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 3952;
											array2 = array;
											goto IL_0815;
										}
									}
								}
							}
							else
							{
								object obj10 = typeof(TypeConverter<ushort, char>) + 3400;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
								object obj11 = 153100288 + 1024;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
								object[] array3 = default(object[]);
								bool flag11 = array3 == null;
								obj2 = (object)(&obj9);
								if (!flag11)
								{
									object obj12 = default(object);
									bool flag12 = obj12 == null;
									object obj13 = (object)(&obj9);
									if (!flag12)
									{
										nint num = (nint)array3;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v330 @ X8_v39 (Il2CppClass<System.Object[]>)+40]");
										obj13 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
										bool flag13 = ex == null;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v330 @ X8_v39 (Il2CppClass<System.Object[]>)+40]");
										obj2 = 0;
										if (flag13)
										{
											goto IL_074a;
										}
									}
									bool flag14 = array3.Length == 0;
									obj2 = obj13;
									if (!flag14)
									{
										object obj14 = array3 + 32;
										obj14 = obj12;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
										object obj15 = default(object);
										bool flag15 = obj15 == null;
										object obj16 = (object)(&obj17);
										if (!flag15)
										{
											nint num2 = (nint)array3;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v331 @ X8_v38 (Il2CppClass<System.Object[]>)+40]");
											obj16 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
											bool flag16 = ex == null;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v331 @ X8_v38 (Il2CppClass<System.Object[]>)+40]");
											obj2 = 0;
											if (flag16)
											{
												goto IL_074a;
											}
										}
										object obj18 = array3.Length & 0xFFFFFFFEL;
										bool flag17 = obj18 == null;
										obj2 = obj16;
										if (!flag17)
										{
											object obj19 = array3 + 40;
											obj19 = obj15;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
											text6 = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 3512;
											array2 = array3;
											goto IL_0815;
										}
									}
									goto IL_073c;
								}
							}
						}
					}
				}
				else
				{
					object obj20 = typeof(TypeConverter<ushort, char>) + 3400;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
					object obj21 = 153100288 + 1024;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
					object[] array4 = default(object[]);
					bool flag18 = array4 == null;
					obj2 = (object)(&obj9);
					if (!flag18)
					{
						object obj22 = default(object);
						bool flag19 = obj22 == null;
						object obj23 = (object)(&obj9);
						if (!flag19)
						{
							nint num3 = (nint)array4;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v328 @ X8_v25 (Il2CppClass<System.Object[]>)+40]");
							obj23 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
							bool flag20 = ex == null;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v328 @ X8_v25 (Il2CppClass<System.Object[]>)+40]");
							obj2 = 0;
							if (flag20)
							{
								goto IL_074a;
							}
						}
						bool flag21 = array4.Length == 0;
						obj2 = obj23;
						if (!flag21)
						{
							object obj24 = array4 + 32;
							obj24 = obj22;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
							object obj25 = default(object);
							bool flag22 = obj25 == null;
							object obj26 = (object)(&obj17);
							if (!flag22)
							{
								nint num4 = (nint)array4;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v329 @ X8_v24 (Il2CppClass<System.Object[]>)+40]");
								obj26 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
								bool flag23 = ex == null;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v329 @ X8_v24 (Il2CppClass<System.Object[]>)+40]");
								obj2 = 0;
								if (flag23)
								{
									goto IL_074a;
								}
							}
							object obj27 = array4.Length & 0xFFFFFFFEL;
							bool flag24 = obj27 == null;
							obj2 = obj26;
							if (!flag24)
							{
								object obj28 = array4 + 40;
								obj28 = obj25;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
								text6 = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 3896;
								array2 = array4;
								goto IL_0815;
							}
						}
						goto IL_073c;
					}
				}
			}
		}
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_073c;
		IL_073c:
		ex = new IndexOutOfRangeException();
		goto IL_074a;
		IL_07a1:
		LocalizableText localizableText;
		Toast.Show(localizableText, (Vector2)0, 0f);
		return false;
		IL_0019:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		LocalizableText localizableText2;
		localizableText = localizableText2;
		goto IL_07a1;
		IL_074a:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		OutOfMemoryException ex3 = new OutOfMemoryException();
		return (byte)(int)ex3 != 0;
		IL_0815:
		localizableText = TextMeshProExtensions.LocalizeWith((string)text6, array2);
		object obj29 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ X8_v51+E4]");
		bool flag25 = (nint)0 == 0;
		object obj30 = !flag25;
		object[] array5;
		if (obj30 == null)
		{
			array5 = array2;
			localizableText2 = localizableText;
			goto IL_0019;
		}
		goto IL_07a1;
		IL_07c2:
		localizableText2 = TextMeshProExtensions.Localize((string)text);
		obj29 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ X8_v51+E4]");
		bool flag26 = (nint)0 == 0;
		object obj31 = !flag26;
		array5 = null;
		localizableText = localizableText2;
		if (obj31 == null)
		{
			goto IL_0019;
		}
		goto IL_07a1;
	}

	private static bool InRange(string value, int min, int max)
	{
		//IL_010b: Expected I4, but got O
		//IL_0124: Expected O, but got I4
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Expected I4, but got Unknown
		//IL_007a: Expected O, but got I4
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Expected I4, but got Unknown
		if (value != null)
		{
			string text = value.Trim();
			if (text != null)
			{
				bool flag;
				bool flag2;
				bool flag3;
				if (text._stringLength >= min)
				{
					object obj = text._stringLength - max;
					flag = (nint)obj < 0;
					flag2 = obj == null;
					int num = text._stringLength ^ max;
					int num2 = text._stringLength ^ obj;
					int num3 = num & num2;
					flag3 = num3 < 0;
				}
				else
				{
					flag3 = false;
					flag2 = false;
					flag = false;
				}
				bool flag4 = flag == flag3;
				object obj2 = !flag4;
				return (byte)((obj2 | flag2) ? 1 : 0) != 0;
			}
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}
}
