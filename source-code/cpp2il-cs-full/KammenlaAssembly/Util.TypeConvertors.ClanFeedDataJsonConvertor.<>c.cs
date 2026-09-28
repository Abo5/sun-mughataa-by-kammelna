using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Cpp2ILInjected;
using HuaweiMobileServices.Location.Location;
using Kammelna.Server.Models.Clans;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Linq.JsonPath;
using UnityEngine;

namespace Util.TypeConvertors;

public class ClanFeedDataJsonConvertor : JsonConverter
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Func<CustomAttributeData, bool> <>9__3_0;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(CardUtils.<>c) + 624;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal bool <HasCustomConvertor>b__3_0(CustomAttributeData attribute)
		{
			//IL_00ba: Expected I4, but got O
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0035: Expected O, but got I4
			//IL_0045: Expected O, but got I
			//IL_0067: Expected O, but got I4
			if (attribute != null)
			{
				object handle = typeof(IAsyncEnumerable<>) + 1176;
				Type attributeType = attribute.AttributeType;
				object obj = 153100288 + 1024;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v4+E0]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v5+E4]");
				bool flag = (nint)0 == 0;
				object obj3 = !flag;
				if (obj3 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)handle);
				return attributeType == typeFromHandle;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	public override bool CanConvert(Type objectType)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Expected O, but got I4
		//IL_0024: Expected O, but got I
		//IL_010e: Expected O, but got I4
		//IL_011e: Expected O, but got I
		//IL_0140: Expected O, but got I4
		//IL_0058: Expected O, but got I4
		//IL_0068: Expected O, but got I
		//IL_01a8: Expected I4, but got O
		//IL_00c7: Expected I, but got O
		//IL_00d7: Expected O, but got I
		//IL_00e7: Expected O, but got I
		//IL_018c: Expected O, but got I4
		object obj = 152993792;
		object obj2 = 147423232 + 1944;
		object obj3 = (nint)0 & (nint)1;
		if (obj3 == null)
		{
			goto IL_00f1;
		}
		RuntimeTypeHandle handle = (RuntimeTypeHandle)obj2;
		object obj4 = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X8_v12+E0]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		RuntimeTypeHandle handle2 = (RuntimeTypeHandle)obj2;
		if (!flag)
		{
			goto IL_0095;
		}
		goto IL_0156;
		IL_019a:
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
		IL_0095:
		Type typeFromHandle = Type.GetTypeFromHandle(handle);
		if ((object)typeFromHandle != null)
		{
			goto IL_00bf;
		}
		goto IL_019a;
		IL_00bf:
		nint num = (nint)typeFromHandle;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X8_v9 (Il2CppClass<System.Type>)+2B8]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X8_v9 (Il2CppClass<System.Type>)+2C0]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v76 @ X3_v1 (should have been resolved before IL gen)");
		goto IL_00f1;
		IL_00f1:
		_ = 1;
		handle = (RuntimeTypeHandle)obj2;
		object obj8 = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X8_v6+E0]");
		obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3+E4]");
		bool flag2 = (nint)0 == 0;
		object obj9 = !flag2;
		handle2 = (RuntimeTypeHandle)obj2;
		if (obj9 != null)
		{
			goto IL_0095;
		}
		goto IL_0156;
		IL_0156:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		typeFromHandle = Type.GetTypeFromHandle(handle2);
		bool flag3 = (object)typeFromHandle == null;
		object obj10 = !flag3;
		if (obj10 != null)
		{
			goto IL_00bf;
		}
		goto IL_019a;
	}

	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_02e8: Expected O, but got I
		//IL_0300: Expected O, but got I
		//IL_0480: Expected O, but got I
		//IL_0490: Expected O, but got I
		//IL_04a6: Expected O, but got I
		//IL_04af: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b4: Expected O, but got Unknown
		//IL_04ce: Expected O, but got I4
		//IL_04de: Expected O, but got I
		//IL_007d: Expected O, but got I
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Expected O, but got Unknown
		//IL_00a4: Expected O, but got I4
		//IL_0335: Expected O, but got I
		//IL_034b: Expected O, but got I
		//IL_0354: Unknown result type (might be due to invalid IL or missing references)
		//IL_0359: Expected O, but got Unknown
		//IL_0378: Expected O, but got I
		//IL_00f8: Expected O, but got I
		//IL_0124: Expected O, but got I4
		//IL_0540: Expected O, but got I
		//IL_0550: Expected O, but got I
		//IL_0566: Expected O, but got I
		//IL_056f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0574: Expected O, but got Unknown
		//IL_058e: Expected O, but got I4
		//IL_059e: Expected O, but got I
		//IL_0518: Expected O, but got I4
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Expected O, but got Unknown
		//IL_042c: Expected O, but got I
		//IL_043c: Expected I, but got O
		//IL_044c: Expected O, but got I
		//IL_045c: Expected O, but got I
		//IL_03bb: Expected O, but got I
		//IL_03cb: Expected O, but got I
		//IL_03e1: Expected O, but got I
		//IL_03ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ef: Expected O, but got Unknown
		//IL_040e: Expected O, but got I
		//IL_014b: Expected O, but got I
		//IL_05d0: Expected O, but got I4
		//IL_018b: Expected O, but got I
		//IL_01cb: Expected O, but got I
		//IL_021c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0221: Expected O, but got Unknown
		//IL_023c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0241: Expected O, but got Unknown
		//IL_025b: Expected O, but got I4
		//IL_060c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0611: Expected O, but got Unknown
		//IL_063b: Expected O, but got I4
		object obj = typeof(System.IOAsyncCallback) + 4088;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		JObject jObject = default(JObject);
		jObject..ctor();
		Type type = value.GetType();
		PropertyInfo[] properties = type.GetProperties();
		bool flag = properties.Length < 1;
		object obj2 = value;
		JsonSerializer jsonSerializer = serializer;
		string text = null;
		if (!flag)
		{
			object obj3 = (nint)0 + (nint)1368;
			object obj4 = properties + 32;
			object obj5 = value;
			JsonSerializer jsonSerializer2 = serializer;
			object obj6 = 0;
			object obj8 = default(object);
			object obj11 = default(object);
			object obj13 = default(object);
			object obj15 = default(object);
			string text2 = default(string);
			bool flag7;
			do
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X28_v4+v110 @ X26_v5*8]");
				object obj7 = 0;
				text = (string)obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D50698");
				bool flag2 = obj8 == null;
				object obj9 = !flag2;
				if (obj9 == null)
				{
					object obj10 = obj7;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v336 @ X8_v32+280]");
					text = (string)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v336 @ X8_v32+278] (should have been resolved before IL gen)");
					if (obj11 != null)
					{
						object obj12 = obj7;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v337 @ X8_v33+290]");
						text = (string)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v337 @ X8_v33+288] (should have been resolved before IL gen)");
						if (obj13 != null)
						{
							object obj14 = obj7;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v338 @ X8_v34+300]");
							jsonSerializer2 = (JsonSerializer)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v338 @ X8_v34+2F8] (should have been resolved before IL gen)");
							bool flag3 = obj15 == null;
							obj5 = null;
							text = (string)value;
							if (!flag3)
							{
								object obj16 = obj7;
								Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v373 @ X8_v35+1B8] (should have been resolved before IL gen)");
								object obj17 = "ThisIsFakeReceiptData" + 2840;
								bool flag4 = text2 == (string)obj17;
								object obj18 = " SDK from working.  If you would like to change it's implementation please override StartVivoxUnity method in " + 3744;
								bool flag5 = !flag4;
								object obj19 = !flag5;
								object obj20 = ~obj19;
								string text3 = (string)((obj20 != null) ? text2 : obj18);
								object obj21 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 80;
								object obj22 = obj21;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v391 @ X0_v39+E4]");
								bool flag6 = (nint)0 == 0;
								object obj23 = !flag6;
								if (obj23 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								JToken jToken = JToken.FromObject(obj15, serializer);
								jObject.Add(text3, jToken);
								obj5 = jToken;
								jsonSerializer2 = null;
								text = text3;
							}
						}
					}
				}
				obj6++;
				flag7 = (nint)obj6 >= properties.Length;
				obj2 = obj5;
				jsonSerializer = jsonSerializer2;
			}
			while (!flag7);
		}
		object obj24 = (nint)0 + (nint)3192;
		object obj25 = obj24;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ X21_v3+38]");
		object obj26 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ X21_v3+38]");
		if ((nint)0 == 0)
		{
			goto IL_0466;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v277 @ X8_v8+10]");
		object obj27 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v277 @ X8_v8+10]");
		object obj28 = (nint)0 + (nint)309;
		object obj29 = obj28 & 1;
		bool flag8 = obj29 == null;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v277 @ X8_v8+10]");
		object obj30 = 0;
		if (!flag8)
		{
			goto IL_0386;
		}
		goto IL_04ec;
		IL_03ab:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ X21_v3+38]");
		object obj31 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v345 @ X8_v24+10]");
		object obj32 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v345 @ X8_v24+10]");
		object obj33 = (nint)0 + (nint)309;
		object obj34 = obj33 & 1;
		bool flag9 = obj34 == null;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v345 @ X8_v24+10]");
		object obj35 = 0;
		if (!flag9)
		{
			goto IL_041c;
		}
		goto IL_05ac;
		IL_0386:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v351 @ X0_v12+E4]");
		if ((nint)0 != 0)
		{
			goto IL_03ab;
		}
		goto IL_0526;
		IL_0466:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CD24");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ X21_v3+38]");
		object obj36 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v305 @ X8_v16+10]");
		obj27 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v305 @ X8_v16+10]");
		object obj37 = (nint)0 + (nint)309;
		object obj38 = obj37 & 1;
		bool flag10 = obj38 == null;
		object obj39 = !flag10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v305 @ X8_v16+10]");
		obj30 = 0;
		if (obj39 != null)
		{
			goto IL_0386;
		}
		goto IL_04ec;
		IL_05ac:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		bool flag11 = jObject == null;
		object obj40 = !flag11;
		if (obj40 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_041c;
		IL_0526:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ X21_v3+38]");
		object obj41 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v363 @ X8_v11+10]");
		obj32 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v363 @ X8_v11+10]");
		object obj42 = (nint)0 + (nint)309;
		object obj43 = obj42 & 1;
		bool flag12 = obj43 == null;
		object obj44 = !flag12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v363 @ X8_v11+10]");
		obj35 = 0;
		if (obj44 != null)
		{
			goto IL_041c;
		}
		goto IL_05ac;
		IL_04ec:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v351 @ X0_v12+E4]");
		bool flag13 = (nint)0 == 0;
		object obj45 = !flag13;
		if (obj45 != null)
		{
			goto IL_03ab;
		}
		goto IL_0526;
		IL_041c:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v368 @ X0_v20+B8]");
		object obj46 = 0;
		object obj47 = obj46;
		nint num = (nint)jObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v227 @ X8_v21 (Il2CppClass<Newtonsoft.Json.Linq.JObject>)+2B8]");
		object obj48 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v227 @ X8_v21 (Il2CppClass<Newtonsoft.Json.Linq.JObject>)+2C0]");
		object obj49 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v192 @ X4_v1 (should have been resolved before IL gen)");
		goto IL_0466;
	}

	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
	{
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Expected O, but got Unknown
		//IL_029f: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a4: Expected O, but got Unknown
		//IL_02c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cc: Expected O, but got Unknown
		//IL_02f4: Expected O, but got I
		//IL_00e9: Expected O, but got I4
		//IL_00f9: Expected O, but got I
		//IL_0145: Expected O, but got I4
		JObject jObject;
		Type feedDataType;
		Type type2 = default(Type);
		Type type3;
		Type type;
		JsonReader jsonReader = default(JsonReader);
		if (jsonReader != null)
		{
			JsonToken tokenType = jsonReader.TokenType;
			if (tokenType == JsonToken.Null)
			{
				return null;
			}
			jObject = JObject.Load(jsonReader);
			bool flag = jObject == null;
			jsonReader = null;
			if (!flag)
			{
				object obj = " SDK from working.  If you would like to change it's implementation please override StartVivoxUnity method in " + 3744;
				JProperty jProperty = jObject.Property((string)obj);
				bool flag2 = jProperty == null;
				type = null;
				jsonReader = (JsonReader)obj;
				if (!flag2)
				{
					JToken value = jProperty.Value;
					int feedType = Newtonsoft.Json.Linq.Extensions.Value<int>(value);
					feedDataType = ClanFeedTypeExtensions.GetFeedDataType((ClanFeedType)feedType);
					object obj2 = 153100288 + 1024;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ X8_v11+E0]");
					object obj3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ X0_v26+E4]");
					if ((nint)0 != 0)
					{
						bool flag3 = feedDataType != type2;
						bool flag4 = !flag3;
						object obj4 = !flag4;
						type3 = null;
						if (obj4 != null)
						{
							goto IL_01a7;
						}
						type2 = null;
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						bool flag5 = feedDataType != type2;
						bool flag6 = !flag5;
						type3 = null;
						type2 = null;
						if (!flag6)
						{
							goto IL_01a7;
						}
					}
					goto IL_0226;
				}
				object obj5 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 960;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj6 = "Complete" + 2280;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
				JsonSerializationException ex = default(JsonSerializationException);
				string message = default(string);
				ex..ctor(message);
				object obj7 = (nint)0 + (nint)992;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
				return new OutOfMemoryException();
			}
		}
		goto IL_027d;
		IL_027d:
		type = type2;
		throw new NullReferenceException();
		IL_0226:
		object obj8 = Activator.CreateInstance(feedDataType);
		JsonReader reader2 = jObject.CreateReader();
		bool flag7 = serializer == null;
		jsonReader = null;
		if (!flag7)
		{
			serializer.Populate(reader2, obj8);
			return obj8;
		}
		goto IL_027d;
		IL_01a7:
		bool flag8 = HasCustomConvertor(feedDataType);
		bool flag9 = !flag8;
		type2 = type3;
		if (flag9)
		{
			goto IL_0226;
		}
		JsonReader reader3 = jObject.CreateReader();
		bool flag10 = serializer == null;
		type2 = type3;
		jsonReader = null;
		if (!flag10)
		{
			return serializer.Deserialize(reader3, feedDataType);
		}
		goto IL_027d;
	}

	private static bool HasCustomConvertor(Type feedDataType)
	{
		//IL_01b5: Expected I4, but got O
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0021: Expected I, but got O
		//IL_00e2: Expected O, but got I
		//IL_00f2: Expected O, but got I
		//IL_0102: Expected O, but got I
		//IL_0124: Expected O, but got I4
		//IL_0067: Expected O, but got I
		//IL_0077: Expected O, but got I
		//IL_0087: Expected O, but got I
		//IL_00a9: Expected O, but got I4
		//IL_015c: Expected O, but got I4
		//IL_01e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e6: Expected O, but got Unknown
		//IL_01fc: Expected O, but got I
		//IL_020d: Expected I, but got O
		//IL_022b: Expected O, but got I
		//IL_018c: Expected O, but got I
		Type type = default(Type);
		object obj;
		IEnumerable<CustomAttributeData> customAttributes;
		object obj4;
		Func<object, bool> predicate;
		object obj6;
		object obj3;
		if ((object)type != null)
		{
			obj = typeof(CardUtils.<>c) + 624;
			nint num = (nint)type;
			customAttributes = type.CustomAttributes;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X0_v8+E4]");
			if ((nint)0 != 0)
			{
				obj3 = (nint)0 + (nint)2560;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X0_v8+B8]");
				obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X8_v7+8]");
				predicate = (Func<object, bool>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X8_v7+8]");
				bool flag = (nint)0 == 0;
				object obj5 = !flag;
				if (obj5 == null)
				{
					obj6 = obj3;
					goto IL_013a;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
				obj6 = (nint)0 + (nint)2560;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X0_v8+B8]");
				obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X8_v7+8]");
				predicate = (Func<object, bool>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X8_v7+8]");
				bool flag2 = (nint)0 == 0;
				object obj7 = !flag2;
				obj3 = obj6;
				if (obj7 == null)
				{
					goto IL_013a;
				}
			}
			goto IL_0191;
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
		IL_0191:
		return Enumerable.Any(customAttributes, predicate);
		IL_013a:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X0_v8+E4]");
		bool flag3 = (nint)0 == 0;
		object obj8 = !flag3;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj9 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X8_v13+B8]");
			obj4 = 0;
		}
		object obj10 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 888;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj11 = (nint)0 + (nint)3520;
		Func<object, bool> func = default(Func<object, bool>);
		func..ctor(obj4, (IntPtr)obj11);
		object obj12 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X8_v12+B8]");
		object obj13 = (nint)0 + (nint)8;
		obj13 = func;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj3 = obj6;
		predicate = func;
		goto IL_0191;
	}
}
