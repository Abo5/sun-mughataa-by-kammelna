using System;
using System.Collections.Generic;
using System.Threading;
using Cpp2ILInjected;
using Microsoft.Extensions.DependencyInjection.ServiceLookup;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Linq.JsonPath;
using Unity.Services.Authentication.Shared;
using UnityEngine.AdaptivePerformance;
using UnityEngine.Rendering;
using UnityEngine.TextCore;

namespace Features.GameReplay;

public abstract class ReplayEvent
{
	private int <PlayerIndex>k__BackingField;

	private ReplayEventsTypes <ReplayEventType>k__BackingField;

	public int PlayerIndex
	{
		get
		{
			return <PlayerIndex>k__BackingField;
		}
		protected set
		{
			<PlayerIndex>k__BackingField = value;
		}
	}

	public ReplayEventsTypes ReplayEventType
	{
		get
		{
			return <ReplayEventType>k__BackingField;
		}
		protected set
		{
			<ReplayEventType>k__BackingField = value;
		}
	}

	protected ReplayEvent()
	{
	}

	protected ReplayEvent(ReplayEventsTypes replayEventType, int playerIndex = 0)
	{
		<PlayerIndex>k__BackingField = playerIndex;
		<ReplayEventType>k__BackingField = replayEventType;
	}

	public static ReplayEvent Deserialize(JsonSerializer serializer, JsonReader jsonReader, Type type)
	{
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0057: Expected I, but got O
		//IL_0080: Expected O, but got I4
		//IL_00b4: Expected O, but got I
		object obj = Activator.CreateInstance(type);
		if (serializer != null)
		{
			serializer.Populate(jsonReader, obj);
			if (obj == null)
			{
				goto IL_00db;
			}
			object obj2 = typeof(RegisteredWaitHandle) + 600;
			object obj3 = obj2;
			nint num = (nint)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X8_v7 (Il2CppClass<System.Object>)+130]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X1_v5+130]");
			bool flag = num2 < 0;
			object obj4 = !flag;
			object obj5 = ~obj4;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X8_v7 (Il2CppClass<System.Object>)+C8]");
				nint num3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X1_v5+130]");
				object obj6 = num3 + 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ X8_v10-8]");
				if (0 == (nint)obj3)
				{
					goto IL_00db;
				}
			}
			InvalidCastException ex = new InvalidCastException();
		}
		return (ReplayEvent)(object)new NullReferenceException();
		IL_00db:
		return (ReplayEvent)obj;
	}

	public static Type GetType(ReplayEventsTypes replayEventType)
	{
		//IL_0101: Expected O, but got I4
		//IL_010f: Expected O, but got I4
		//IL_0129: Expected O, but got I4
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Expected O, but got Unknown
		//IL_0014: Expected O, but got I4
		//IL_002a: Expected O, but got I
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Expected O, but got Unknown
		//IL_00ca: Expected O, but got I
		ReplayEventsTypes replayEventsTypes = default(ReplayEventsTypes);
		bool flag = replayEventsTypes < ReplayEventsTypes.Kasho;
		object obj = !flag;
		object obj2 = replayEventsTypes - 16;
		bool flag2 = obj2 == null;
		object obj3 = !flag2;
		object obj4 = obj & obj3;
		if (obj4 == null)
		{
			object obj5 = 119877632 + 1280;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X9_v2+v34 @ X0_v1 (Features.GameReplay.ReplayEventsTypes)]");
			object obj6 = (nint)86117168 + (nint)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v57 @ X10_v2 (should have been resolved before IL gen)");
		}
		object obj7 = typeof(RegisteredWaitHandle) + 608;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object obj8 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 656;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj9 = "placementId" + 3336;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		ArgumentOutOfRangeException ex = default(ArgumentOutOfRangeException);
		string paramName = default(string);
		object actualValue = default(object);
		ex..ctor(paramName, actualValue, null);
		object obj10 = (nint)0 + (nint)464;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		return (Type)(object)new OutOfMemoryException();
	}

	public unsafe static List<ReplayEvent> DeserializeObjects(IEnumerable<string> json)
	{
		//IL_0010: Expected O, but got I
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		//IL_0030: Expected O, but got I
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected O, but got Unknown
		//IL_0051: Expected I, but got O
		//IL_0061: Expected O, but got I
		//IL_0100: Expected O, but got I4
		//IL_0913: Expected O, but got I
		//IL_009c: Expected O, but got I
		//IL_0733: Expected O, but got Ref
		//IL_0812: Expected O, but got I4
		//IL_0144: Unknown result type (might be due to invalid IL or missing references)
		//IL_0149: Expected O, but got Unknown
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Expected O, but got Unknown
		//IL_016c: Expected O, but got I4
		//IL_017b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0180: Expected O, but got Unknown
		//IL_018f: Expected O, but got I4
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Expected O, but got Unknown
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Expected O, but got Unknown
		//IL_01ad: Expected O, but got I
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Expected O, but got Unknown
		//IL_00c5: Expected O, but got I
		//IL_024c: Expected O, but got I4
		//IL_0977: Expected O, but got I
		//IL_098a: Unknown result type (might be due to invalid IL or missing references)
		//IL_098f: Expected O, but got Unknown
		//IL_01e8: Expected O, but got I
		//IL_060f: Expected O, but got I4
		//IL_0618: Expected O, but got I4
		//IL_026f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0274: Expected O, but got Unknown
		//IL_0a26: Expected O, but got I4
		//IL_01f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fb: Expected O, but got Unknown
		//IL_0211: Expected O, but got I
		//IL_062c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0631: Expected O, but got Unknown
		//IL_0649: Expected O, but got I
		//IL_02ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b2: Expected O, but got Unknown
		//IL_02ca: Expected O, but got I
		//IL_06e8: Expected O, but got I4
		//IL_0369: Expected O, but got I4
		//IL_0a68: Expected O, but got I
		//IL_0684: Expected O, but got I
		//IL_0305: Expected O, but got I
		//IL_070b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0710: Expected O, but got Unknown
		//IL_03a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ad: Expected O, but got Unknown
		//IL_03cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d2: Expected O, but got Unknown
		//IL_03fc: Expected O, but got I4
		//IL_038c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0391: Expected O, but got Unknown
		//IL_0692: Unknown result type (might be due to invalid IL or missing references)
		//IL_0697: Expected O, but got Unknown
		//IL_06ad: Expected O, but got I
		//IL_0436: Expected O, but got I
		//IL_0458: Expected O, but got I4
		//IL_0313: Unknown result type (might be due to invalid IL or missing references)
		//IL_0318: Expected O, but got Unknown
		//IL_032e: Expected O, but got I
		//IL_0492: Expected O, but got I
		//IL_04a2: Expected O, but got I
		//IL_04c4: Expected O, but got I4
		//IL_076b: Expected O, but got I4
		//IL_051f: Expected I, but got O
		//IL_052f: Expected O, but got I
		//IL_053f: Expected O, but got I
		//IL_078a: Expected O, but got I4
		//IL_059a: Expected O, but got I4
		//IL_05a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a8: Expected O, but got Unknown
		//IL_05c2: Expected O, but got I4
		//IL_079e: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a3: Expected O, but got Unknown
		//IL_07d1: Expected O, but got I
		//IL_05f3: Expected O, but got I
		//IL_07f2: Expected O, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8135]");
		object obj = 0;
		Type type = (Type)(typeof(List<AdaptivePerformanceScaler>) + 3024);
		object obj2 = (nint)0 + (nint)3904;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		string text = (string)obj2;
		List<object> list = default(List<object>);
		list..ctor();
		if (json == null)
		{
			goto IL_08d3;
		}
		object obj3 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 3760;
		nint num = (nint)json;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X8_v15 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.String>>)+12E]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X8_v15 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.String>>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_00ed;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X8_v15 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.String>>)+B0]");
		object obj5 = (nint)0 + (nint)8;
		object obj6;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v258 @ X10_v29-8]");
			if (0 == (nint)obj3)
			{
				break;
			}
			obj6 = obj5 + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X8_v15 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.String>>)+12E]");
			obj4 = -1;
			bool flag = (nint)obj4 != 1;
			obj5 = obj6;
			if (flag)
			{
				continue;
			}
			goto IL_00ed;
		}
		obj4 = obj5;
		object obj7 = num + obj5;
		object obj8 = obj7 + 312;
		obj6 = obj5;
		goto IL_0903;
		IL_07ff:
		object obj10 = default(object);
		object obj9 = obj10;
		object obj11 = 0;
		goto IL_08d3;
		IL_09d0:
		object obj12 = default(object);
		obj = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v704 @ X0_v34] (should have been resolved before IL gen)");
		string json2 = default(string);
		JObject jObject = JObject.Parse(json2);
		object handle;
		object obj21;
		object obj30;
		if (jObject != null)
		{
			object propertyName = "destinationTimeZone" + 1040;
			JToken jToken = jObject.get_Item((string)propertyName);
			object obj13 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 80;
			object obj14 = obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v727 @ X0_v40+E4]");
			bool flag2 = (nint)0 == 0;
			object obj15 = !flag2;
			if (obj15 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			string text2 = (string)jToken;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ X28_v1+E0]");
			object obj16 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v743 @ X0_v44+E4]");
			bool flag3 = (nint)0 == 0;
			object obj17 = !flag3;
			if (obj17 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)handle);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ X28_v1+98]");
			object obj18 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v758 @ X0_v48+E4]");
			obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v758 @ X0_v48+E4]");
			bool flag4 = (nint)0 == 0;
			object obj19 = !flag4;
			if (obj19 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj20 = Enum.Parse(typeFromHandle, text2);
			if (obj20 != null)
			{
				text = (string)obj21;
				nint num2 = (nint)obj20;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v770 @ X8_v35 (Il2CppClass<System.Object>)+40]");
				obj = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X1_v3 (System.String)+40]");
				obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v770 @ X8_v35 (Il2CppClass<System.Object>)+40]");
				nint num3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X1_v3 (System.String)+40]");
				if (num3 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1960");
					object obj22 = default(object);
					obj = obj22;
					bool flag5 = (nint)obj22 < 15;
					object obj23 = !flag5;
					object obj24 = obj22 - 15;
					bool flag6 = obj24 == null;
					object obj25 = !flag6;
					object obj26 = obj23 & obj25;
					if (obj26 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v196 @ X25_v1+v240 @ X8_v4]");
						object obj27 = (nint)86184364 + (nint)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v554 @ X9_v20 (should have been resolved before IL gen)");
						goto IL_05fd;
					}
					object obj28 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 656;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					ArgumentOutOfRangeException ex = default(ArgumentOutOfRangeException);
					ex..ctor();
					object obj29 = (nint)0 + (nint)456;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
					OutOfMemoryException ex2 = new OutOfMemoryException();
					obj30 = 0;
					string text3 = default(string);
					text = text3;
				}
				else
				{
					InvalidCastException ex3 = new InvalidCastException();
					obj30 = 0;
				}
			}
			else
			{
				NullReferenceException ex4 = new NullReferenceException();
				obj30 = 0;
				text = text2;
			}
		}
		else
		{
			NullReferenceException ex5 = new NullReferenceException();
			text = null;
		}
		goto IL_07ff;
		IL_0356:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		obj30 = 0;
		goto IL_09d0;
		IL_08d3:
		throw new NullReferenceException();
		IL_05fd:
		obj9 = obj10;
		obj11 = 0;
		object obj31 = 0;
		object obj38 = default(object);
		while (true)
		{
			if (obj9 == null)
			{
				goto IL_0a0c;
			}
			object obj32 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2344;
			object obj33 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v502 @ X8_v7+12E]");
			obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v502 @ X8_v7+12E]");
			if ((nint)0 == 0)
			{
				goto IL_06d5;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v502 @ X8_v7+B0]");
			object obj34 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v623 @ X10_v7-8]");
				if (0 == (nint)obj32)
				{
					break;
				}
				obj6 = obj34 + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v502 @ X8_v7+12E]");
				obj4 = -1;
				bool flag7 = (nint)obj4 != 1;
				obj34 = obj6;
				if (flag7)
				{
					continue;
				}
				goto IL_06d5;
			}
			obj4 = obj34;
			object obj35 = obj33 + obj34;
			object obj36 = obj35 + 312;
			obj6 = obj34;
			goto IL_0a58;
			IL_0a0c:
			bool flag8 = obj31 == null;
			object obj37 = !flag8;
			if (obj37 == null)
			{
				return (List<ReplayEvent>)(object)list;
			}
			OutOfMemoryException ex6 = new OutOfMemoryException();
			if ((nint)text != 1)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			obj31 = obj38;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			obj11 = obj38;
			continue;
			IL_06d5:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			obj30 = 0;
			goto IL_0a58;
			IL_0a58:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v670 @ X0_v7+8]");
			text = (string)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v670 @ X0_v7] (should have been resolved before IL gen)");
			goto IL_0a0c;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C99C14");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
		List<ReplayEvent> result = default(List<ReplayEvent>);
		return result;
		IL_00ed:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		obj30 = 0;
		goto IL_0903;
		IL_0903:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v289 @ X0_v25+8]");
		text = (string)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v289 @ X0_v25] (should have been resolved before IL gen)");
		object obj45 = default(object);
		if (obj10 != null)
		{
			object obj39 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2528;
			handle = typeof(IAsyncEnumerable<>) + 3256;
			object obj40 = 153100288 + 1024;
			obj21 = typeof(RegisteredWaitHandle) + 608;
			object obj41 = 119877632 + 1312;
			object obj42 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v332 @ X8_v20+12E]");
			obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v332 @ X8_v20+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0239;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v332 @ X8_v20+B0]");
			object obj43 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v455 @ X10_v24-8]");
				if (0 == (nint)obj39)
				{
					break;
				}
				obj6 = obj43 + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v332 @ X8_v20+12E]");
				obj4 = -1;
				bool flag9 = (nint)obj4 != 1;
				obj43 = obj6;
				if (flag9)
				{
					continue;
				}
				goto IL_0239;
			}
			obj4 = obj43;
			object obj44 = obj42 + obj43;
			obj45 = obj44 + 312;
			obj6 = obj43;
			goto IL_095f;
		}
		NullReferenceException ex7 = new NullReferenceException();
		obj = (object)(&obj9);
		goto IL_07ff;
		IL_095f:
		obj = obj45;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v495 @ X0_v30+8]");
		text = (string)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v495 @ X0_v30] (should have been resolved before IL gen)");
		object obj47 = default(object);
		object obj46 = obj47 & 1;
		if (obj46 == null)
		{
			goto IL_05fd;
		}
		if (obj10 != null)
		{
			object obj48 = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 1192;
			object obj49 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v610 @ X8_v25+12E]");
			obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v610 @ X8_v25+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0356;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v610 @ X8_v25+B0]");
			object obj50 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v686 @ X10_v19-8]");
				if (0 == (nint)obj48)
				{
					break;
				}
				obj6 = obj50 + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v610 @ X8_v25+12E]");
				obj4 = -1;
				bool flag10 = (nint)obj4 != 1;
				obj50 = obj6;
				if (flag10)
				{
					continue;
				}
				goto IL_0356;
			}
			obj4 = obj50;
			object obj51 = obj49 + obj50;
			obj12 = obj51 + 312;
			obj6 = obj50;
			goto IL_09d0;
		}
		NullReferenceException ex8 = new NullReferenceException();
		goto IL_07ff;
		IL_0239:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		obj30 = 0;
		goto IL_095f;
	}
}
