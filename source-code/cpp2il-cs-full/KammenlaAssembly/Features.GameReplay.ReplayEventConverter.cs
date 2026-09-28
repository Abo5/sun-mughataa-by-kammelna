using System;
using System.Threading;
using Cpp2ILInjected;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Linq.JsonPath;

namespace Features.GameReplay;

public class ReplayEventConverter : JsonConverter<ReplayEvent>
{
	public override bool CanWrite => false;

	public override void WriteJson(JsonWriter writer, ReplayEvent value, JsonSerializer serializer)
	{
	}

	public override ReplayEvent ReadJson(JsonReader reader, Type objectType, ReplayEvent existingValue, bool hasExistingValue, JsonSerializer serializer)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0063: Expected O, but got I4
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Expected O, but got Unknown
		//IL_00e4: Expected I, but got O
		//IL_010d: Expected O, but got I4
		//IL_0141: Expected O, but got I
		JObject jObject = JObject.Load(reader);
		object propertyName = "destinationTimeZone" + 1040;
		object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 80;
		JToken jToken = jObject.get_Item((string)propertyName);
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X8_v7+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		string s = (string)jToken;
		int replayEventType = int.Parse(s);
		Type type = ReplayEvent.GetType((ReplayEventsTypes)replayEventType);
		JsonReader reader2 = jObject.CreateReader();
		object obj4 = Activator.CreateInstance(type);
		serializer.Populate(reader2, obj4);
		if (obj4 != null)
		{
			object obj5 = typeof(RegisteredWaitHandle) + 600;
			object obj6 = obj5;
			nint num = (nint)obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X8_v13 (Il2CppClass<System.Object>)+130]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X1_v11+130]");
			bool flag2 = num2 < 0;
			object obj7 = !flag2;
			object obj8 = ~obj7;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X8_v13 (Il2CppClass<System.Object>)+C8]");
				nint num3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X1_v11+130]");
				object obj9 = num3 + 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ X8_v15-8]");
				if (0 == (nint)obj6)
				{
					goto IL_0168;
				}
			}
			return (ReplayEvent)(object)new InvalidCastException();
		}
		goto IL_0168;
		IL_0168:
		return (ReplayEvent)obj4;
	}

	public ReplayEventConverter()
	{
		((JsonConverter<object>)(object)this)..ctor();
	}
}
