using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2ILInjected;
using GoogleMobileAds.Api.AdManager;
using HuaweiMobileServices.Location.Location;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Linq.JsonPath;
using Unity.Properties;
using UnityEngine;

namespace Features.GameReplay;

public class BoolArrayConverter : JsonConverter
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Func<string, bool> <>9__2_0;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 3272;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal bool <ReadJson>b__2_0(string s)
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Expected O, but got Unknown
			object obj = ", stale={0}" + 3768;
			return s == (string)obj;
		}
	}

	private const string True = "1";

	public override bool CanWrite => true;

	public override bool CanConvert(Type objectType)
	{
		//IL_01ca: Expected I4, but got O
		//IL_004b: Expected I, but got O
		//IL_0067: Expected O, but got I4
		//IL_0077: Expected O, but got I
		//IL_0099: Expected O, but got I4
		//IL_00cc: Expected O, but got I
		//IL_0122: Expected I, but got O
		//IL_013f: Expected O, but got I
		//IL_0161: Expected O, but got I4
		//IL_0194: Expected O, but got I
		if ((object)objectType != null)
		{
			bool flag = objectType.IsArray;
			if (flag)
			{
				nint num = (nint)objectType;
				Type elementType = objectType.GetElementType();
				object obj = 153100288 + 1024;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X21_v4+E0]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X0_v7+E4]");
				bool flag2 = (nint)0 == 0;
				object obj3 = !flag2;
				if (obj3 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X21_v4+90]");
				RuntimeTypeHandle handle = (RuntimeTypeHandle)((nint)0 + (nint)32);
				Type typeFromHandle = Type.GetTypeFromHandle(handle);
				if (!(elementType == typeFromHandle))
				{
					nint num2 = (nint)objectType;
					Type elementType2 = objectType.GetElementType();
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X21_v4+E0]");
					object obj4 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ X0_v15+E4]");
					bool flag3 = (nint)0 == 0;
					object obj5 = !flag3;
					if (obj5 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X21_v4+48]");
					RuntimeTypeHandle handle2 = (RuntimeTypeHandle)((nint)0 + (nint)32);
					Type typeFromHandle2 = Type.GetTypeFromHandle(handle2);
					return elementType2 == typeFromHandle2;
				}
				flag = true;
			}
			return flag;
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_01cf: Expected O, but got I4
		//IL_00b3: Expected O, but got I
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Expected O, but got Unknown
		//IL_00fb: Expected O, but got I4
		//IL_0213: Expected O, but got I4
		//IL_0241: Expected O, but got I
		//IL_0251: Expected O, but got I
		//IL_0273: Expected O, but got I4
		//IL_0142: Expected O, but got I4
		//IL_0290: Unknown result type (might be due to invalid IL or missing references)
		//IL_0295: Expected O, but got Unknown
		//IL_02ab: Expected O, but got I
		//IL_02bc: Expected I, but got O
		//IL_02da: Expected O, but got I
		//IL_0172: Expected O, but got I
		object obj = 152993792;
		object obj2 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 80;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E80F6]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v3+E4]");
			if ((nint)0 != 0)
			{
				goto IL_007d;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 != null)
			{
				goto IL_007d;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		JToken jToken = JToken.Load(reader);
		bool flag2 = jToken == null;
		object obj6 = !flag2;
		if (obj6 != null)
		{
			goto IL_00a7;
		}
		goto IL_0221;
		IL_00a7:
		object obj7 = (nint)0 + (nint)3920;
		object obj8 = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 3272;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E8ECD8");
		object obj9 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X0_v32+E4]");
		bool flag3 = (nint)0 == 0;
		object obj10 = !flag3;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj9 = obj8;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X0_v32+B8]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ X8_v12+8]");
		Func<object, bool> selector = (Func<object, bool>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ X8_v12+8]");
		bool flag4 = (nint)0 == 0;
		object obj12 = !flag4;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X0_v32+E4]");
			bool flag5 = (nint)0 == 0;
			object obj13 = !flag5;
			if (obj13 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj14 = obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ X8_v18+B8]");
				obj11 = 0;
			}
			object obj15 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3552;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj16 = (nint)0 + (nint)1792;
			Func<object, bool> func = default(Func<object, bool>);
			func..ctor(obj11, (IntPtr)obj16);
			object obj17 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X8_v17+B8]");
			object obj18 = (nint)0 + (nint)8;
			obj18 = func;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			selector = func;
		}
		IEnumerable<object> source2 = default(IEnumerable<object>);
		IEnumerable<bool> source = Enumerable.Select(source2, selector);
		return Enumerable.ToArray(source);
		IL_0221:
		return new NullReferenceException();
		IL_007d:
		jToken = JToken.Load(reader);
		if (jToken != null)
		{
			goto IL_00a7;
		}
		goto IL_0221;
	}

	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
	{
		//IL_00b2: Expected O, but got I4
		//IL_00bb: Expected O, but got I4
		//IL_014a: Expected I, but got O
		//IL_015a: Expected O, but got I
		//IL_016a: Expected O, but got I
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_00c9: Expected O, but got I4
		//IL_00d2: Expected O, but got I4
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected O, but got Unknown
		//IL_0085: Expected O, but got I4
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Expected O, but got Unknown
		//IL_009b: Expected O, but got I4
		//IL_00a4: Expected O, but got I4
		if (value != null)
		{
			object obj = typeof(TypeConverter<ushort, char>) + 1832;
			writer.WriteStartArray();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
			object obj2 = default(object);
			if (obj2 == null)
			{
				throw new InvalidCastException();
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v11+18]");
			if ((nint)0 >= (nint)1)
			{
				object obj3 = obj2 + 32;
				object obj4 = 0;
				object obj5 = default(object);
				obj4 = obj5;
				object obj6;
				do
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X24_v3+v176 @ X23_v4]");
					writer.WriteValue(0);
					obj4++;
					obj6 = obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v11+18]");
				}
				while ((nint)obj6 < 0);
				object obj7 = 1448;
				object obj8 = 1456;
			}
			else
			{
				object obj7 = 1448;
				object obj8 = 1456;
			}
		}
		else
		{
			object obj7 = 1624;
			object obj8 = 1632;
		}
		nint num = (nint)writer;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X8_v4 (Il2CppClass<Newtonsoft.Json.JsonWriter>)+v119 @ X22_v1]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X8_v4 (Il2CppClass<Newtonsoft.Json.JsonWriter>)+v134 @ X20_v2]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v138 @ X2_v2 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}
}
