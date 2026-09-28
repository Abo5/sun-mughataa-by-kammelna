using System;
using System.Formats.Asn1;
using System.IO;
using Cpp2ILInjected;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq.JsonPath;
using UnityEngine.TextCore;

namespace Features.GameReplay;

public static class GameReplayUtils
{
	public static bool IsAllowedVersion(string gameReplayJsonString)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_001b: Expected O, but got I
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected O, but got Unknown
		object obj = "utf-32" + 168;
		object obj2 = (nint)0 + (nint)2368;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E354B8");
		object obj4 = default(object);
		object obj3 = obj4 - 1;
		return obj3 == null;
	}

	private unsafe static T GetFirstInstance<T>(string json, string propertyName)
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected O, but got Unknown
		//IL_008d: Expected I, but got O
		//IL_0660: Expected I, but got O
		//IL_0665: Expected I, but got O
		//IL_00ba: Expected O, but got I4
		//IL_00bf: Expected I, but got O
		//IL_00f9: Expected I, but got O
		//IL_0109: Expected O, but got I
		//IL_0119: Expected O, but got I
		//IL_0a39: Expected O, but got Ref
		//IL_03cb: Expected I, but got O
		//IL_03d0: Expected I, but got O
		//IL_03d5: Expected I, but got O
		//IL_07a1: Expected I, but got O
		//IL_0a4f: Expected O, but got Ref
		//IL_07bf: Expected I, but got O
		//IL_0899: Expected O, but got I4
		//IL_0678: Expected I, but got O
		//IL_067d: Expected I, but got O
		//IL_03e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ee: Expected O, but got Unknown
		//IL_03f6: Expected I, but got O
		//IL_0406: Expected O, but got I
		//IL_0168: Expected I, but got O
		//IL_0178: Expected O, but got I
		//IL_0188: Expected O, but got I
		//IL_0803: Expected O, but got I
		//IL_081d: Expected O, but got I4
		//IL_0835: Expected I, but got O
		//IL_083d: Expected I, but got O
		//IL_04f5: Expected O, but got I
		//IL_04a8: Expected I, but got O
		//IL_0551: Unknown result type (might be due to invalid IL or missing references)
		//IL_0556: Expected O, but got Unknown
		//IL_055e: Expected I, but got O
		//IL_056e: Expected O, but got I
		//IL_093c: Expected O, but got I4
		//IL_08e3: Expected I, but got O
		//IL_08f3: Expected O, but got I
		//IL_0441: Expected O, but got I
		//IL_0610: Expected I, but got O
		//IL_0858: Expected I, but got O
		//IL_0870: Expected I, but got O
		//IL_08b7: Expected O, but got I
		//IL_0698: Expected I, but got O
		//IL_069d: Expected I, but got O
		//IL_098e: Expected O, but got I
		//IL_05a9: Expected O, but got I
		//IL_04bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c2: Expected O, but got Unknown
		//IL_04cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d0: Expected O, but got Unknown
		//IL_01da: Expected I, but got O
		//IL_01ea: Expected O, but got I
		//IL_095a: Expected O, but got I
		//IL_044f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0454: Expected O, but got Unknown
		//IL_046a: Expected O, but got I
		//IL_0278: Expected I, but got O
		//IL_0625: Unknown result type (might be due to invalid IL or missing references)
		//IL_062a: Expected O, but got Unknown
		//IL_0633: Unknown result type (might be due to invalid IL or missing references)
		//IL_0638: Expected O, but got Unknown
		//IL_0224: Expected O, but got I
		//IL_022c: Expected I, but got O
		//IL_05b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_05bc: Expected O, but got Unknown
		//IL_05d2: Expected O, but got I
		//IL_06b8: Expected I, but got O
		//IL_06bd: Expected I, but got O
		//IL_0729: Expected I, but got O
		//IL_072e: Expected I, but got O
		//IL_0733: Expected I, but got O
		//IL_02b3: Expected I, but got O
		//IL_02c3: Expected O, but got I
		//IL_02df: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e4: Expected I, but got Unknown
		//IL_02f9: Expected O, but got I
		//IL_02f9: Expected O, but got I
		//IL_074e: Expected I, but got O
		//IL_0753: Expected I, but got O
		//IL_0758: Expected I, but got O
		//IL_0353: Expected O, but got I4
		//IL_0358: Expected I, but got O
		//IL_035d: Expected I, but got O
		//IL_0370: Expected I, but got O
		//IL_039b: Expected I, but got O
		//IL_03a0: Expected I, but got O
		//IL_03b9: Expected I, but got O
		object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 2448;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		StringReader stringReader = default(StringReader);
		stringReader..ctor(json);
		object obj2 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1040;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		JsonTextReader jsonTextReader = default(JsonTextReader);
		jsonTextReader..ctor(stringReader);
		bool flag = jsonTextReader == null;
		nint num = unchecked((nint)null);
		TextReader textReader = stringReader;
		JsonTextReader jsonTextReader2 = default(JsonTextReader);
		nint num2 = (nint)(&jsonTextReader2);
		if (flag)
		{
			goto IL_0652;
		}
		object obj3 = 153100288 + 1024;
		nint num3 = unchecked((nint)null);
		object obj4;
		while (true)
		{
			num2 = (nint)jsonTextReader;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ X8_v15 (Il2CppClass<Newtonsoft.Json.JsonTextReader>)+288]");
			obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ X8_v15 (Il2CppClass<Newtonsoft.Json.JsonTextReader>)+290]");
			textReader = (TextReader)0;
			if (!jsonTextReader.Read())
			{
				break;
			}
			if (jsonTextReader2 != null)
			{
				num2 = (nint)jsonTextReader2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ X8_v15 (Il2CppClass<Newtonsoft.Json.JsonTextReader>)+238]");
				obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ X8_v15 (Il2CppClass<Newtonsoft.Json.JsonTextReader>)+240]");
				textReader = (TextReader)0;
				JsonToken tokenType = jsonTextReader2.TokenType;
				if (tokenType == JsonToken.PropertyName)
				{
					if (jsonTextReader2 == null)
					{
						goto IL_068a;
					}
					num2 = (nint)jsonTextReader2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ X8_v15 (Il2CppClass<Newtonsoft.Json.JsonTextReader>)+248]");
					obj4 = 0;
					string value = (string)jsonTextReader2.Value;
					if (value != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X21_v17+90]");
						textReader = (TextReader)0;
						num2 = (nint)value;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X21_v17+90]");
						if (value != null)
						{
							goto IL_06aa;
						}
					}
					bool flag2 = value == propertyName;
					bool flag3 = !flag2;
					num3 = unchecked((nint)null);
					textReader = (TextReader)(object)propertyName;
					if (!flag3)
					{
						goto IL_028e;
					}
				}
				bool flag4 = jsonTextReader2 == null;
				jsonTextReader = jsonTextReader2;
				num = num3;
				if (!flag4)
				{
					continue;
				}
				goto IL_0652;
			}
			goto IL_066a;
		}
		nint num4 = unchecked((nint)null);
		nint num5 = unchecked((nint)null);
		nint num6 = unchecked((nint)null);
		goto IL_09dd;
		IL_0768:
		NullReferenceException ex;
		if ((nint)textReader == 1)
		{
			T val = ((JsonSerializer)(object)ex).Deserialize<T>((JsonReader)(object)textReader);
			num6 = (nint)val;
			T val2 = ((JsonSerializer)val).Deserialize<T>((JsonReader)(object)textReader);
			num4 = (nint)val;
			num3 = num;
			goto IL_09dd;
		}
		T val3 = ((JsonSerializer)(&num4)).Deserialize<T>((JsonReader)(object)textReader);
		StringReader stringReader2 = default(StringReader);
		JsonSerializer jsonSerializer;
		object obj7 = default(object);
		object obj9 = default(object);
		nint num8;
		T val6;
		nint num9;
		nint num10;
		T result;
		object obj6;
		object obj8;
		if ((nint)textReader == 1)
		{
			T val4 = ((JsonSerializer)(object)ex).Deserialize<T>((JsonReader)(object)textReader);
			T val5 = ((JsonSerializer)val4).Deserialize<T>((JsonReader)(object)textReader);
			nint num7 = (nint)(&stringReader2);
			jsonSerializer = (JsonSerializer)num7;
			bool flag5 = num7 == 0;
			object obj5 = !flag5;
			obj6 = obj7;
			obj8 = obj9;
			num5 = (nint)val4;
			num8 = (nint)val4;
			val6 = (T)null;
			if (obj5 != null)
			{
				goto IL_0542;
			}
			num5 = (nint)val4;
			num9 = num;
			num2 = (nint)(&stringReader2);
			num10 = (nint)val4;
			result = (T)null;
			goto IL_0922;
		}
		T val7 = ((JsonSerializer)(&num5)).Deserialize<T>((JsonReader)(object)textReader);
		T val8 = ((JsonSerializer)(object)ex).Deserialize<T>((JsonReader)(object)textReader);
		return ((JsonSerializer)val8).Deserialize<T>((JsonReader)(object)textReader);
		IL_087f:
		bool flag6 = num8 == 0;
		object obj10 = !flag6;
		if (obj10 == null)
		{
			nint num11 = (nint)(&stringReader2);
			jsonSerializer = (JsonSerializer)num11;
			bool flag7 = num11 == 0;
			obj7 = obj6;
			obj9 = obj8;
			num9 = num;
			num2 = (nint)(&stringReader2);
			num10 = num8;
			result = val6;
			if (!flag7)
			{
				goto IL_0542;
			}
			goto IL_0922;
		}
		OutOfMemoryException ex2 = new OutOfMemoryException();
		obj7 = obj6;
		obj9 = obj8;
		ex = (NullReferenceException)(object)ex2;
		goto IL_0768;
		IL_09dd:
		bool flag8 = jsonTextReader2 == null;
		JsonTextReader jsonTextReader3 = jsonTextReader2;
		T val9 = (T)null;
		obj6 = obj7;
		obj8 = obj9;
		num = num3;
		num8 = num6;
		val6 = (T)null;
		if (!flag8)
		{
			goto IL_03da;
		}
		goto IL_087f;
		IL_0922:
		bool flag9 = num10 == 0;
		object obj11 = !flag9;
		if (obj11 == null)
		{
			return result;
		}
		obj6 = obj7;
		obj8 = obj9;
		num = num9;
		throw new OutOfMemoryException();
		IL_066a:
		ex = new NullReferenceException();
		num4 = unchecked((nint)null);
		num5 = unchecked((nint)null);
		num = num3;
		goto IL_0768;
		IL_097e:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v625 @ X0_v33 (T)+8]");
		textReader = (TextReader)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v625 @ X0_v33 (T)] (should have been resolved before IL gen)");
		obj7 = obj6;
		obj9 = obj8;
		num10 = num8;
		result = val6;
		goto IL_0922;
		IL_05fa:
		object obj12;
		T val10 = jsonSerializer.Deserialize<T>((JsonReader)obj12);
		num9 = unchecked((nint)null);
		goto IL_097e;
		IL_068a:
		ex = new NullReferenceException();
		num4 = unchecked((nint)null);
		num5 = unchecked((nint)null);
		num = num3;
		goto IL_0768;
		IL_03da:
		object obj13 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2344;
		nint num12 = (nint)jsonTextReader3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v324 @ X8_v27 (Il2CppClass<Newtonsoft.Json.JsonTextReader>)+12E]");
		obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v324 @ X8_v27 (Il2CppClass<Newtonsoft.Json.JsonTextReader>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0492;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v324 @ X8_v27 (Il2CppClass<Newtonsoft.Json.JsonTextReader>)+B0]");
		object obj14 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v434 @ X10_v18-8]");
			obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v434 @ X10_v18-8]");
			if (0 == (nint)obj13)
			{
				break;
			}
			obj9 = obj14 + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v324 @ X8_v27 (Il2CppClass<Newtonsoft.Json.JsonTextReader>)+12E]");
			obj4 = -1;
			bool flag10 = (nint)obj4 != 1;
			obj14 = obj9;
			if (flag10)
			{
				continue;
			}
			goto IL_0492;
		}
		obj4 = obj14;
		object obj15 = num12 + obj14;
		T val11 = (T)(obj15 + 312);
		obj9 = obj14;
		num = num3;
		goto IL_08db;
		IL_08db:
		num2 = (nint)val11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v522 @ X0_v40 (T)+8]");
		textReader = (TextReader)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v522 @ X0_v40 (T)] (should have been resolved before IL gen)");
		obj6 = obj7;
		obj8 = obj9;
		num8 = num6;
		val6 = val9;
		goto IL_087f;
		IL_06aa:
		InvalidCastException ex3 = new InvalidCastException();
		num4 = unchecked((nint)null);
		num5 = unchecked((nint)null);
		num = num3;
		ex = (NullReferenceException)(object)ex3;
		goto IL_0768;
		IL_0492:
		val11 = ((JsonSerializer)(object)jsonTextReader3).Deserialize<T>((JsonReader)obj13);
		num = unchecked((nint)null);
		goto IL_08db;
		IL_0542:
		obj12 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2344;
		nint num13 = (nint)jsonSerializer;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v495 @ X8_v20 (Il2CppClass<Newtonsoft.Json.JsonSerializer>)+12E]");
		obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v495 @ X8_v20 (Il2CppClass<Newtonsoft.Json.JsonSerializer>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_05fa;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v495 @ X8_v20 (Il2CppClass<Newtonsoft.Json.JsonSerializer>)+B0]");
		object obj16 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v565 @ X10_v11-8]");
			obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v565 @ X10_v11-8]");
			if (0 == (nint)obj12)
			{
				break;
			}
			obj8 = obj16 + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v495 @ X8_v20 (Il2CppClass<Newtonsoft.Json.JsonSerializer>)+12E]");
			obj4 = -1;
			bool flag11 = (nint)obj4 != 1;
			obj16 = obj8;
			if (flag11)
			{
				continue;
			}
			goto IL_05fa;
		}
		obj4 = obj16;
		object obj17 = num13 + obj16;
		val10 = (T)(obj17 + 312);
		obj8 = obj16;
		num9 = num;
		goto IL_097e;
		IL_0652:
		ex = new NullReferenceException();
		num4 = unchecked((nint)null);
		num5 = unchecked((nint)null);
		goto IL_0768;
		IL_028e:
		if (jsonTextReader2 != null)
		{
			nint num14 = (nint)jsonTextReader2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v615 @ X8_v36 (Il2CppClass<Newtonsoft.Json.JsonTextReader>)+288]");
			obj4 = 0;
			bool flag12 = jsonTextReader2.Read();
			num2 = (nint)(typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 968);
			nint intPtr = num2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v615 @ X8_v36 (Il2CppClass<Newtonsoft.Json.JsonTextReader>)+290]");
			JsonSerializer jsonSerializer2 = (JsonSerializer)((JsonSerializer)intPtr).Deserialize<T>((JsonReader)0);
			jsonSerializer2..ctor();
			if (jsonSerializer2 != null)
			{
				T val12 = jsonSerializer2.Deserialize<T>(jsonTextReader2);
				bool flag13 = jsonTextReader2 == null;
				object obj18 = !flag13;
				num4 = unchecked((nint)null);
				num5 = unchecked((nint)null);
				num3 = 0;
				jsonTextReader3 = jsonTextReader2;
				num6 = unchecked((nint)null);
				val9 = val12;
				if (obj18 != null)
				{
					goto IL_03da;
				}
				obj6 = obj7;
				obj8 = obj9;
				num4 = unchecked((nint)null);
				num5 = unchecked((nint)null);
				num = 0;
				textReader = (TextReader)(object)jsonTextReader2;
				num2 = 0;
				num8 = unchecked((nint)null);
				val6 = val12;
				goto IL_087f;
			}
			ex = new NullReferenceException();
			num4 = unchecked((nint)null);
			num5 = unchecked((nint)null);
			num = unchecked((nint)null);
			textReader = null;
		}
		else
		{
			ex = new NullReferenceException();
			num4 = unchecked((nint)null);
			num5 = unchecked((nint)null);
			num = unchecked((nint)null);
			textReader = (TextReader)(object)propertyName;
		}
		goto IL_0768;
	}
}
