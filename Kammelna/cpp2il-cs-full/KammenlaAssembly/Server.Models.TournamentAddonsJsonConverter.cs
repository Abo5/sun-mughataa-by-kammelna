using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Microsoft.Extensions.DependencyInjection.ServiceLookup;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.Rendering;
using UnityEngine.TextCore;

namespace Server.Models;

public class TournamentAddonsJsonConverter : JsonConverter<TournamentAddonConfig>
{
	public unsafe override TournamentAddonConfig ReadJson(JsonReader reader, Type objectType, TournamentAddonConfig existingValue, bool hasExistingValue, JsonSerializer serializer)
	{
		//IL_104a: Expected O, but got I4
		//IL_105b: Expected O, but got I4
		//IL_000d: Expected I, but got O
		//IL_0044: Expected O, but got I4
		//IL_0052: Expected O, but got I4
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Expected O, but got Unknown
		//IL_00fb: Expected O, but got I
		//IL_012d: Expected O, but got I4
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected O, but got Unknown
		//IL_0179: Expected O, but got I4
		//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b0: Expected O, but got Unknown
		//IL_01b8: Expected I, but got O
		//IL_01c8: Expected O, but got I
		//IL_02aa: Expected I, but got O
		//IL_02ba: Expected O, but got I
		//IL_02de: Expected O, but got I4
		//IL_02e6: Expected O, but got Ref
		//IL_03e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e7: Expected O, but got Unknown
		//IL_03f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fb: Expected O, but got Unknown
		//IL_040a: Expected O, but got I4
		//IL_0416: Expected O, but got I
		//IL_0425: Unknown result type (might be due to invalid IL or missing references)
		//IL_042a: Expected O, but got Unknown
		//IL_0436: Expected O, but got I
		//IL_0203: Expected O, but got I
		//IL_0317: Expected O, but got Ref
		//IL_1081: Expected O, but got I
		//IL_10a2: Expected O, but got I4
		//IL_10b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_10b7: Expected O, but got Unknown
		//IL_0336: Unknown result type (might be due to invalid IL or missing references)
		//IL_033b: Expected O, but got Unknown
		//IL_0344: Unknown result type (might be due to invalid IL or missing references)
		//IL_0349: Expected O, but got Unknown
		//IL_0351: Expected I, but got O
		//IL_0361: Expected O, but got I
		//IL_0382: Expected O, but got Ref
		//IL_03a7: Expected O, but got I
		//IL_03b8: Expected O, but got Ref
		//IL_115f: Expected O, but got I
		//IL_1172: Unknown result type (might be due to invalid IL or missing references)
		//IL_1177: Expected O, but got Unknown
		//IL_0514: Expected O, but got I
		//IL_0219: Unknown result type (might be due to invalid IL or missing references)
		//IL_021e: Expected O, but got Unknown
		//IL_0227: Unknown result type (might be due to invalid IL or missing references)
		//IL_022c: Expected O, but got Unknown
		//IL_0246: Expected O, but got I4
		//IL_024f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0254: Expected O, but got Unknown
		//IL_0b50: Expected O, but got I4
		//IL_0ba6: Expected O, but got I4
		//IL_10f0: Expected O, but got I
		//IL_1111: Expected O, but got I4
		//IL_1121: Unknown result type (might be due to invalid IL or missing references)
		//IL_1126: Expected O, but got Unknown
		//IL_1254: Expected O, but got I4
		//IL_05cd: Expected I, but got O
		//IL_05e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e8: Expected O, but got Unknown
		//IL_0be8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bed: Expected O, but got Unknown
		//IL_052a: Unknown result type (might be due to invalid IL or missing references)
		//IL_052f: Expected O, but got Unknown
		//IL_055f: Expected O, but got I4
		//IL_056d: Expected O, but got I
		//IL_0f5c: Expected O, but got I4
		//IL_0f6d: Expected O, but got I4
		//IL_0d31: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d36: Expected O, but got Unknown
		//IL_12fe: Expected O, but got I
		//IL_0c40: Expected O, but got I
		//IL_0d14: Expected O, but got I4
		//IL_12ca: Expected O, but got I
		//IL_1213: Expected O, but got I
		//IL_066d: Expected O, but got I
		//IL_0fc4: Expected O, but got I4
		//IL_0cad: Expected I, but got O
		//IL_0cc3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cc8: Expected O, but got Unknown
		//IL_11a4: Expected O, but got I
		//IL_11c5: Expected O, but got I4
		//IL_11d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_11da: Expected O, but got Unknown
		//IL_0ddd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0de2: Expected O, but got Unknown
		//IL_0c4e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c53: Expected O, but got Unknown
		//IL_0773: Expected O, but got I
		//IL_0795: Expected O, but got I4
		//IL_0726: Expected I, but got O
		//IL_073c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0741: Expected O, but got Unknown
		//IL_07cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d2: Expected O, but got Unknown
		//IL_07e9: Expected O, but got Ref
		//IL_0683: Unknown result type (might be due to invalid IL or missing references)
		//IL_0688: Expected O, but got Unknown
		//IL_06b8: Expected O, but got I4
		//IL_06c6: Expected O, but got I
		//IL_04b3: Expected O, but got I4
		//IL_0824: Expected O, but got Ref
		//IL_084b: Expected I, but got O
		//IL_085b: Expected O, but got I
		//IL_086b: Expected O, but got I
		//IL_0894: Expected O, but got I4
		//IL_08b1: Expected O, but got I
		//IL_08ce: Expected I4, but got O
		//IL_08d6: Expected O, but got Ref
		//IL_090a: Expected O, but got I
		//IL_093b: Expected O, but got I4
		//IL_094b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0950: Expected O, but got Unknown
		//IL_0985: Expected O, but got Ref
		//IL_09b6: Expected O, but got I4
		//IL_09c4: Expected O, but got I4
		//IL_0a00: Expected O, but got I4
		//IL_0a0e: Expected O, but got I4
		bool flag = reader == null;
		System.Int32Enum int32Enum = (System.Int32Enum)0;
		object obj = 0;
		Dictionary<TournamentAddonType, TournamentAddonConfig.AddonConfig> dictionary = (Dictionary<TournamentAddonType, TournamentAddonConfig.AddonConfig>)(object)reader;
		Dictionary<System.Int32Enum, object> dictionary2 = (Dictionary<System.Int32Enum, object>)152989696;
		JsonReader jsonReader = reader;
		bool flag4;
		TournamentAddonConfig tournamentAddonConfig2;
		JObject jObject;
		Dictionary<System.Int32Enum, object> dictionary3 = default(Dictionary<System.Int32Enum, object>);
		object obj9;
		object obj14 = default(object);
		object obj15;
		object obj16;
		object obj18;
		object obj10 = default(object);
		object obj17;
		object obj11 = default(object);
		nint num2;
		TournamentAddonConfig tournamentAddonConfig3;
		Type type = default(Type);
		if (!flag)
		{
			nint num = (nint)reader;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X8_v18 (Il2CppClass<Newtonsoft.Json.JsonReader>)+238]");
			num2 = 0;
			JsonToken tokenType = reader.TokenType;
			bool flag2 = tokenType < JsonToken.Null;
			object obj2 = !flag2;
			object obj3 = tokenType - 11;
			bool flag3 = obj3 == null;
			flag4 = tokenType != JsonToken.Null;
			if (!flag4)
			{
				object obj4 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1456;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				TournamentAddonConfig tournamentAddonConfig = default(TournamentAddonConfig);
				tournamentAddonConfig..ctor();
				tournamentAddonConfig2 = tournamentAddonConfig;
				goto IL_0e01;
			}
			jObject = JObject.Load(reader);
			object obj5 = typeof(ConditionalWeakTable<System.Net.HttpWebRequest, Mono.Http.NtlmSession>.CreateValueCallback) + 3120;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj6 = (nint)0 + (nint)2360;
			dictionary = (Dictionary<TournamentAddonType, TournamentAddonConfig.AddonConfig>)obj6;
			dictionary3..ctor();
			bool flag5 = jObject == null;
			int32Enum = (System.Int32Enum)0;
			obj = 0;
			dictionary2 = dictionary3;
			jsonReader = (JsonReader)(object)jObject;
			if (!flag5)
			{
				IEnumerable<JProperty> enumerable = jObject.Properties();
				bool flag6 = enumerable == null;
				int32Enum = (System.Int32Enum)0;
				obj = 0;
				dictionary = null;
				dictionary2 = dictionary3;
				jsonReader = (JsonReader)(object)jObject;
				if (!flag6)
				{
					object obj7 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 3384;
					nint num3 = (nint)enumerable;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v485 @ X8_v25 (Il2CppClass<System.Collections.Generic.IEnumerable`1<Newtonsoft.Json.Linq.JProperty>>)+12E]");
					object obj8 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v485 @ X8_v25 (Il2CppClass<System.Collections.Generic.IEnumerable`1<Newtonsoft.Json.Linq.JProperty>>)+12E]");
					if ((nint)0 == 0)
					{
						goto IL_0298;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v485 @ X8_v25 (Il2CppClass<System.Collections.Generic.IEnumerable`1<Newtonsoft.Json.Linq.JProperty>>)+B0]");
					obj9 = (nint)0 + (nint)8;
					bool flag7 = flag4;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v345 @ X10_v13-8]");
						obj10 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v345 @ X10_v13-8]");
						bool flag8 = 0 < (nint)obj7;
						obj2 = !flag8;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v345 @ X10_v13-8]");
						obj3 = 0 - obj7;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v345 @ X10_v13-8]");
						if (0 == (nint)obj7)
						{
							break;
						}
						obj11 = obj9 + 16;
						obj8--;
						bool flag9 = (nint)obj8 < 1;
						obj2 = !flag9;
						obj3 = obj8 - 1;
						flag3 = obj3 == null;
						flag4 = (nint)obj8 != 1;
						obj9 = obj11;
						flag7 = flag4;
						if (flag4)
						{
							continue;
						}
						goto IL_0298;
					}
					object obj12 = num3 + obj9;
					object obj13 = obj12 + 312;
					num2 = (nint)obj13;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v607 @ X8_v43+8]");
					dictionary = (Dictionary<TournamentAddonType, TournamentAddonConfig.AddonConfig>)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v607 @ X8_v43] (should have been resolved before IL gen)");
					bool flag10 = obj14 == null;
					obj15 = (object)(&obj);
					tournamentAddonConfig3 = null;
					obj11 = obj9;
					flag4 = flag7;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v345 @ X10_v13-8]");
					obj16 = 0;
					int32Enum = (System.Int32Enum)0;
					obj17 = (object)(&obj);
					tournamentAddonConfig3 = null;
					obj18 = type;
					if (!flag10)
					{
						goto IL_03d3;
					}
					goto IL_0e06;
				}
			}
		}
		goto IL_0eb0;
		IL_0e06:
		NullReferenceException ex = new NullReferenceException();
		obj10 = obj16;
		obj11 = obj9;
		dictionary2 = dictionary3;
		jsonReader = (JsonReader)(object)jObject;
		goto IL_0f01;
		IL_12ee:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v790 @ X0_v27+8]");
		dictionary = (Dictionary<TournamentAddonType, TournamentAddonConfig.AddonConfig>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v790 @ X0_v27] (should have been resolved before IL gen)");
		object obj19 = obj10;
		TournamentAddonConfig tournamentAddonConfig5 = default(TournamentAddonConfig);
		TournamentAddonConfig tournamentAddonConfig4 = tournamentAddonConfig5;
		string text2 = default(string);
		string text = text2;
		object obj21 = default(object);
		object obj20 = obj21;
		object obj23 = default(object);
		object obj22 = obj23;
		object obj25 = default(object);
		object obj24 = obj25;
		object obj27 = default(object);
		object obj26 = obj27;
		object obj29;
		object obj28 = obj29;
		obj15 = obj17;
		object obj30 = obj11;
		TournamentAddonConfig tournamentAddonConfig6;
		tournamentAddonConfig2 = tournamentAddonConfig6;
		Dictionary<System.Int32Enum, object> dictionary4 = dictionary2;
		JsonReader jsonReader2 = jsonReader;
		goto IL_123a;
		IL_0bd9:
		object obj31 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2344;
		object obj33;
		object obj32 = obj33;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v601 @ X8_v14+12E]");
		num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v601 @ X8_v14+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0c91;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v601 @ X8_v14+B0]");
		object obj34 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v733 @ X10_v11-8]");
			obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v733 @ X10_v11-8]");
			if (0 == (nint)obj31)
			{
				break;
			}
			obj11 = obj34 + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v601 @ X8_v14+12E]");
			num2 = -1;
			bool flag11 = num2 != 1;
			obj34 = obj11;
			if (flag11)
			{
				continue;
			}
			goto IL_0c91;
		}
		num2 = (nint)obj34;
		object obj35 = obj32 + obj34;
		object obj36 = obj35 + 312;
		type = (Type)obj18;
		obj11 = obj34;
		goto IL_12ee;
		IL_0e01:
		return tournamentAddonConfig2;
		IL_123a:
		bool flag12 = tournamentAddonConfig2 == null;
		object obj37 = !flag12;
		obj10 = obj19;
		tournamentAddonConfig5 = tournamentAddonConfig4;
		text2 = text;
		obj21 = obj20;
		obj23 = obj22;
		obj25 = obj24;
		obj27 = obj26;
		obj17 = obj15;
		obj11 = obj30;
		dictionary2 = dictionary4;
		jsonReader = jsonReader2;
		if (obj37 == null)
		{
			if ((nint)obj28 != 9)
			{
				bool flag13 = obj28 == null;
				object obj38 = !flag13;
				if (obj38 != null)
				{
					goto IL_0e01;
				}
			}
			object obj39 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1456;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			TournamentAddonConfig tournamentAddonConfig7 = default(TournamentAddonConfig);
			tournamentAddonConfig7..ctor((Dictionary<TournamentAddonType, TournamentAddonConfig.AddonConfig>)(object)dictionary4);
			bool flag14 = tournamentAddonConfig7 == null;
			obj10 = obj19;
			tournamentAddonConfig5 = tournamentAddonConfig4;
			text2 = text;
			obj21 = obj20;
			obj23 = obj22;
			obj25 = obj24;
			obj27 = obj26;
			obj17 = obj15;
			type = null;
			obj11 = obj30;
			dictionary = (Dictionary<TournamentAddonType, TournamentAddonConfig.AddonConfig>)(object)dictionary4;
			dictionary2 = dictionary4;
			jsonReader = jsonReader2;
			if (!flag14)
			{
				object obj40 = tournamentAddonConfig7 + 24;
				obj40 = jsonReader2;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				tournamentAddonConfig2 = tournamentAddonConfig7;
				goto IL_0e01;
			}
			goto IL_0eb0;
		}
		throw new OutOfMemoryException();
		IL_0e72:
		ex = new NullReferenceException();
		tournamentAddonConfig5 = tournamentAddonConfig4;
		text2 = text;
		obj17 = obj15;
		object obj41;
		obj18 = obj41;
		dictionary2 = dictionary3;
		jsonReader = (JsonReader)(object)jObject;
		goto IL_0f01;
		IL_0e34:
		ex = new NullReferenceException();
		tournamentAddonConfig5 = tournamentAddonConfig4;
		text2 = text;
		obj17 = obj15;
		obj18 = obj41;
		dictionary2 = dictionary3;
		jsonReader = (JsonReader)(object)jObject;
		goto IL_0f01;
		IL_0ae2:
		ex = new NullReferenceException();
		tournamentAddonConfig5 = tournamentAddonConfig4;
		text2 = text;
		obj17 = obj15;
		TournamentAddonConfig.SimpleConfig simpleConfig;
		obj18 = simpleConfig;
		dictionary2 = dictionary3;
		jsonReader = (JsonReader)(object)jObject;
		goto IL_0f01;
		IL_0298:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		object obj42 = default(object);
		num2 = (nint)obj42;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v523 @ X0_v73+8]");
		dictionary = (Dictionary<TournamentAddonType, TournamentAddonConfig.AddonConfig>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v523 @ X0_v73] (should have been resolved before IL gen)");
		bool flag15 = obj14 == null;
		object obj43 = !flag15;
		obj15 = (object)(&obj);
		tournamentAddonConfig3 = null;
		type = null;
		if (obj43 != null)
		{
			goto IL_03d3;
		}
		obj16 = obj10;
		int32Enum = (System.Int32Enum)0;
		obj17 = (object)(&obj);
		tournamentAddonConfig3 = null;
		obj18 = null;
		obj9 = obj11;
		goto IL_0e06;
		IL_03d3:
		obj27 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2528;
		obj25 = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 792;
		obj23 = 153100288 + 1024;
		obj21 = (nint)0 + (nint)1032;
		object obj44 = typeof(System.IOAsyncCallback) + 4088;
		object obj45 = (nint)0 + (nint)2384;
		int32Enum = (System.Int32Enum)0;
		tournamentAddonConfig4 = tournamentAddonConfig5;
		text = text2;
		object obj46 = obj14;
		obj41 = type;
		object obj52 = default(object);
		JProperty jProperty = default(JProperty);
		object obj60 = default(object);
		while (true)
		{
			object obj47 = obj46;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v728 @ X8_v29+12E]");
			num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v728 @ X8_v29+12E]");
			if ((nint)0 == 0)
			{
				goto IL_05b1;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v728 @ X8_v29+B0]");
			object obj48 = (nint)0 + (nint)8;
			bool flag16 = flag4;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v794 @ X10_v28-8]");
				obj10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v794 @ X10_v28-8]");
				bool flag17 = 0 < (nint)obj27;
				object obj2 = !flag17;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v794 @ X10_v28-8]");
				object obj3 = 0 - obj27;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v794 @ X10_v28-8]");
				if (0 == (nint)obj27)
				{
					break;
				}
				obj11 = obj48 + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v728 @ X8_v29+12E]");
				num2 = -1;
				bool flag18 = num2 < 1;
				obj2 = !flag18;
				obj3 = num2 - 1;
				bool flag3 = obj3 == null;
				flag4 = num2 != 1;
				obj48 = obj11;
				flag16 = flag4;
				if (flag4)
				{
					continue;
				}
				goto IL_05b1;
			}
			num2 = (nint)obj48;
			object obj49 = obj47 + obj48;
			object obj50 = obj49 + 312;
			obj11 = obj48;
			flag4 = flag16;
			goto IL_114f;
			IL_114f:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v818 @ X0_v45+8]");
			dictionary = (Dictionary<TournamentAddonType, TournamentAddonConfig.AddonConfig>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v818 @ X0_v45] (should have been resolved before IL gen)");
			object obj51 = obj52 & 1;
			if (obj51 == null)
			{
				break;
			}
			if (obj == null)
			{
				goto IL_0e72;
			}
			object obj53 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v826 @ X8_v32+12E]");
			num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v826 @ X8_v32+12E]");
			if ((nint)0 == 0)
			{
				goto IL_070a;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v826 @ X8_v32+B0]");
			object obj54 = (nint)0 + (nint)8;
			bool flag19 = flag4;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v859 @ X10_v23-8]");
				obj10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v859 @ X10_v23-8]");
				bool flag20 = 0 < (nint)obj25;
				object obj2 = !flag20;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v859 @ X10_v23-8]");
				object obj3 = 0 - obj25;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v859 @ X10_v23-8]");
				if (0 == (nint)obj25)
				{
					break;
				}
				obj11 = obj54 + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v826 @ X8_v32+12E]");
				num2 = -1;
				bool flag21 = num2 < 1;
				obj2 = !flag21;
				obj3 = num2 - 1;
				bool flag3 = obj3 == null;
				flag4 = num2 != 1;
				obj54 = obj11;
				flag19 = flag4;
				if (flag4)
				{
					continue;
				}
				goto IL_070a;
			}
			num2 = (nint)obj54;
			object obj55 = obj53 + obj54;
			object obj56 = obj55 + 312;
			obj11 = obj54;
			flag4 = flag19;
			goto IL_1203;
			IL_1203:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v883 @ X0_v49+8]");
			dictionary = (Dictionary<TournamentAddonType, TournamentAddonConfig.AddonConfig>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v883 @ X0_v49] (should have been resolved before IL gen)");
			if (jProperty != null)
			{
				text = jProperty._name;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v568 @ X27_v7+98]");
				object obj57 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v887 @ X0_v53+E4]");
				bool flag22 = (nint)0 == 0;
				object obj58 = !flag22;
				if (obj58 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				tournamentAddonConfig4 = (TournamentAddonConfig)obj21;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D70990");
				object obj59 = obj60 & 1;
				bool flag23 = obj59 == null;
				obj41 = (object)(&int32Enum);
				System.Int32Enum int32Enum2 = (System.Int32Enum)1;
				if (!flag23)
				{
					JToken value = jProperty.Value;
					bool flag24 = value == null;
					obj41 = (object)(&int32Enum);
					int32Enum2 = (System.Int32Enum)0;
					if (!flag24)
					{
						object obj61 = obj44;
						num2 = (nint)value;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v704 @ X9_v26 (Il2CppClass<Newtonsoft.Json.Linq.JToken>)+130]");
						obj10 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v417 @ X8_v36+130]");
						obj11 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v704 @ X9_v26 (Il2CppClass<Newtonsoft.Json.Linq.JToken>)+130]");
						nint num4 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v417 @ X8_v36+130]");
						bool flag25 = num4 < 0;
						object obj2 = !flag25;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v704 @ X9_v26 (Il2CppClass<Newtonsoft.Json.Linq.JToken>)+130]");
						nint num5 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v417 @ X8_v36+130]");
						object obj3 = num5 - 0;
						bool flag3 = obj3 == null;
						flag4 = (byte)(int)(~obj2) != 0;
						obj41 = (object)(&int32Enum);
						int32Enum2 = (System.Int32Enum)0;
						if (!flag4)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v704 @ X9_v26 (Il2CppClass<Newtonsoft.Json.Linq.JToken>)+C8]");
							nint num6 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v417 @ X8_v36+130]");
							object obj62 = num6 + 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v929 @ X9_v24-8]");
							num2 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v929 @ X9_v24-8]");
							bool flag26 = 0 < (nint)obj61;
							obj2 = !flag26;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v929 @ X9_v24-8]");
							obj3 = 0 - obj61;
							flag3 = obj3 == null;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v929 @ X9_v24-8]");
							flag4 = 0 != (nint)obj61;
							obj41 = (object)(&int32Enum);
							int32Enum2 = (System.Int32Enum)0;
							if (!flag4)
							{
								bool flag27 = int32Enum < (System.Int32Enum)4;
								obj2 = !flag27;
								obj3 = int32Enum - 4;
								if (int32Enum != (System.Int32Enum)4)
								{
									bool flag28 = int32Enum < (System.Int32Enum)5;
									obj2 = !flag28;
									obj3 = int32Enum - 5;
									flag3 = obj3 == null;
									flag4 = int32Enum != (System.Int32Enum)5;
									if (!flag4)
									{
										TournamentAddonConfig.ChampionshipConfig championshipConfig = TournamentAddonConfig.ChampionshipConfig.FromJson((JObject)value);
										dictionary = null;
										simpleConfig = (TournamentAddonConfig.SimpleConfig)(object)championshipConfig;
									}
									else
									{
										simpleConfig = TournamentAddonConfig.SimpleConfig.FromJson((JObject)value);
										dictionary = null;
									}
								}
								else
								{
									TournamentAddonConfig.TitleRestrictionConfig titleRestrictionConfig = TournamentAddonConfig.TitleRestrictionConfig.FromJson((JObject)value);
									dictionary = null;
									simpleConfig = (TournamentAddonConfig.SimpleConfig)(object)titleRestrictionConfig;
								}
								if (dictionary3 == null)
								{
									goto IL_0ae2;
								}
								tournamentAddonConfig4 = (TournamentAddonConfig)obj45;
								dictionary3.set_Item(int32Enum, (object)simpleConfig);
								obj41 = simpleConfig;
								int32Enum2 = int32Enum;
							}
						}
					}
				}
				bool flag29 = obj == null;
				obj46 = obj;
				obj16 = obj10;
				tournamentAddonConfig5 = tournamentAddonConfig4;
				text2 = text;
				obj17 = obj15;
				obj18 = obj41;
				obj9 = obj11;
				dictionary = (Dictionary<TournamentAddonType, TournamentAddonConfig.AddonConfig>)int32Enum2;
				if (!flag29)
				{
					continue;
				}
				goto IL_0e06;
			}
			goto IL_0e34;
			IL_070a:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			obj41 = null;
			goto IL_1203;
			IL_05b1:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			obj41 = null;
			goto IL_114f;
		}
		bool flag30 = obj == null;
		tournamentAddonConfig5 = tournamentAddonConfig4;
		text2 = text;
		obj33 = obj;
		obj29 = 9;
		obj17 = obj15;
		obj18 = obj41;
		tournamentAddonConfig6 = null;
		dictionary2 = dictionary3;
		jsonReader = (JsonReader)(object)jObject;
		obj19 = obj10;
		obj20 = obj21;
		obj22 = obj23;
		obj24 = obj25;
		obj26 = obj27;
		obj28 = 9;
		type = (Type)obj41;
		obj30 = obj11;
		tournamentAddonConfig2 = null;
		dictionary4 = dictionary3;
		jsonReader2 = (JsonReader)(object)jObject;
		if (!flag30)
		{
			goto IL_0bd9;
		}
		goto IL_123a;
		IL_0c91:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		type = null;
		goto IL_12ee;
		IL_0eb0:
		throw new NullReferenceException();
		IL_0f01:
		if ((nint)dictionary == 1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			object obj63 = default(object);
			tournamentAddonConfig6 = (TournamentAddonConfig)obj63;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			bool flag31 = obj == null;
			object obj64 = !flag31;
			obj33 = obj;
			obj29 = 0;
			tournamentAddonConfig3 = (TournamentAddonConfig)obj63;
			if (obj64 != null)
			{
				goto IL_0bd9;
			}
			obj19 = obj10;
			tournamentAddonConfig4 = tournamentAddonConfig5;
			text = text2;
			obj20 = obj21;
			obj22 = obj23;
			obj24 = obj25;
			obj26 = obj27;
			obj28 = 0;
			obj15 = obj17;
			tournamentAddonConfig3 = (TournamentAddonConfig)obj63;
			type = (Type)obj18;
			obj30 = obj11;
			tournamentAddonConfig2 = (TournamentAddonConfig)obj63;
			dictionary4 = dictionary2;
			jsonReader2 = jsonReader;
			goto IL_123a;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C99C14");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
		TournamentAddonConfig result = default(TournamentAddonConfig);
		return result;
	}

	public override void WriteJson(JsonWriter writer, TournamentAddonConfig value, JsonSerializer serializer)
	{
		//IL_0478: Expected O, but got I
		//IL_021e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0223: Expected O, but got Unknown
		//IL_0253: Expected O, but got I
		//IL_0275: Expected O, but got I4
		//IL_00a6: Expected O, but got I
		//IL_00bc: Expected O, but got I
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Expected O, but got Unknown
		//IL_00f1: Expected O, but got I
		//IL_036f: Expected O, but got I4
		//IL_02bf: Expected O, but got I
		//IL_02cf: Expected O, but got I
		//IL_02e5: Expected O, but got I
		//IL_02ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f3: Expected O, but got Unknown
		//IL_030d: Expected O, but got I4
		//IL_0335: Expected O, but got I
		//IL_004c: Expected O, but got I
		//IL_015c: Expected O, but got I
		//IL_016c: Expected O, but got I
		//IL_0182: Expected O, but got I
		//IL_018b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0190: Expected O, but got Unknown
		//IL_01af: Expected O, but got I
		//IL_044f: Expected O, but got I4
		//IL_03af: Expected O, but got I
		//IL_03bf: Expected O, but got I
		//IL_03d5: Expected O, but got I
		//IL_03de: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e3: Expected O, but got Unknown
		//IL_03fd: Expected O, but got I4
		//IL_041d: Expected O, but got I
		//IL_01d5: Expected O, but got I
		//IL_01e5: Expected I, but got O
		//IL_01f5: Expected O, but got I
		//IL_0205: Expected O, but got I
		object obj = (nint)0 + (nint)3192;
		JObject jObject;
		JsonWriter jsonWriter2;
		JObject jObject2;
		object obj4;
		object obj3;
		JsonWriter jsonWriter;
		object obj2;
		if (value != null)
		{
			jObject = value.<RawJson>k__BackingField;
			if (value.<RawJson>k__BackingField != null)
			{
				obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ X21_v13+38]");
				obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ X21_v13+38]");
				bool flag = (nint)0 == 0;
				jsonWriter = writer;
				jsonWriter2 = writer;
				obj4 = obj2;
				jObject2 = value.<RawJson>k__BackingField;
				if (!flag)
				{
					goto IL_0096;
				}
				goto IL_02a5;
			}
		}
		goto IL_020f;
		IL_0395:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X21_v6+38]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X8_v6+10]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X8_v6+10]");
		object obj7 = (nint)0 + (nint)309;
		object obj8 = obj7 & 1;
		bool flag2 = obj8 == null;
		object obj9 = !flag2;
		jObject = jObject2;
		jsonWriter = jsonWriter2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X8_v6+10]");
		object obj10 = 0;
		if (obj9 != null)
		{
			goto IL_01c5;
		}
		goto IL_042b;
		IL_042b:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		bool flag3 = jObject2 == null;
		object obj11 = !flag3;
		jObject = jObject2;
		if (obj11 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_01c5;
		IL_0096:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X8_v28+10]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X8_v28+10]");
		object obj13 = (nint)0 + (nint)309;
		object obj14 = obj13 & 1;
		bool flag4 = obj14 == null;
		jsonWriter2 = jsonWriter;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X8_v28+10]");
		object obj15 = 0;
		obj4 = obj2;
		jObject2 = jObject;
		if (!flag4)
		{
			goto IL_010f;
		}
		goto IL_0343;
		IL_010f:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X0_v6+E4]");
		bool flag5 = (nint)0 == 0;
		jsonWriter2 = jsonWriter;
		obj4 = obj2;
		jObject2 = jObject;
		if (!flag5)
		{
			goto IL_014c;
		}
		goto IL_0395;
		IL_014c:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ X21_v13+38]");
		object obj16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X8_v23+10]");
		obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X8_v23+10]");
		object obj17 = (nint)0 + (nint)309;
		object obj18 = obj17 & 1;
		bool flag6 = obj18 == null;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X8_v23+10]");
		obj10 = 0;
		jObject2 = jObject;
		if (!flag6)
		{
			goto IL_01c5;
		}
		goto IL_042b;
		IL_01c5:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ X0_v17+B8]");
		object obj19 = 0;
		object obj20 = obj19;
		nint num = (nint)jObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ X8_v20 (Il2CppClass<Newtonsoft.Json.Linq.JObject>)+2B8]");
		object obj21 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ X8_v20 (Il2CppClass<Newtonsoft.Json.Linq.JObject>)+2C0]");
		object obj22 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v160 @ X4_v1 (should have been resolved before IL gen)");
		goto IL_020f;
		IL_020f:
		object obj23 = typeof(System.IOAsyncCallback) + 4088;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		JObject jObject3 = default(JObject);
		jObject3..ctor();
		obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ X21_v13+38]");
		obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ X21_v13+38]");
		bool flag7 = (nint)0 == 0;
		object obj24 = !flag7;
		jsonWriter = null;
		jObject = jObject3;
		jsonWriter2 = null;
		obj4 = obj2;
		jObject2 = jObject3;
		if (obj24 != null)
		{
			goto IL_0096;
		}
		goto IL_02a5;
		IL_02a5:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CD24");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X21_v6+38]");
		object obj25 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X8_v12+10]");
		obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X8_v12+10]");
		object obj26 = (nint)0 + (nint)309;
		object obj27 = obj26 & 1;
		bool flag8 = obj27 == null;
		object obj28 = !flag8;
		jsonWriter = jsonWriter2;
		obj2 = obj4;
		jObject = jObject2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X8_v12+10]");
		obj15 = 0;
		if (obj28 != null)
		{
			goto IL_010f;
		}
		goto IL_0343;
		IL_0343:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X0_v6+E4]");
		bool flag9 = (nint)0 == 0;
		object obj29 = !flag9;
		jsonWriter = jsonWriter2;
		obj2 = obj4;
		jObject = jObject2;
		if (obj29 != null)
		{
			goto IL_014c;
		}
		goto IL_0395;
	}

	public TournamentAddonsJsonConverter()
	{
		((JsonConverter<object>)(object)this)..ctor();
	}
}
