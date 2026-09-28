using System;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using Newtonsoft.Json;

namespace Features.GameReplay;

public class CardConverter : JsonConverter<Card>
{
	public override void WriteJson(JsonWriter writer, Card value, JsonSerializer serializer)
	{
		//IL_001a: Expected I, but got O
		//IL_002a: Expected O, but got I
		//IL_003a: Expected O, but got I
		int num = value.AsInt();
		nint num2 = (nint)writer;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X8_v1 (Il2CppClass<Newtonsoft.Json.JsonWriter>)+6A8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X8_v1 (Il2CppClass<Newtonsoft.Json.JsonWriter>)+6B0]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v39 @ X3_v1 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}

	public override Card ReadJson(JsonReader reader, Type objectType, Card existingValue, bool hasExistingValue, JsonSerializer serializer)
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected O, but got Unknown
		if (reader != null)
		{
			object value = reader.Value;
			if (value != null)
			{
				object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 376;
				string s = value.ToString();
				int intRepresentation = int.Parse(s);
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X8_v6+E4]");
				if ((nint)0 != 0)
				{
					return CardUtils.FromInt(intRepresentation);
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				return CardUtils.FromInt(intRepresentation);
			}
		}
		return (Card)(object)new NullReferenceException();
	}

	public CardConverter()
	{
		((JsonConverter<object>)(object)this)..ctor();
	}
}
