using System;
using Cpp2ILInjected;
using Newtonsoft.Json;

namespace Features.GameReplay;

public class BoolConverter : JsonConverter<bool>
{
	public override void WriteJson(JsonWriter writer, bool value, JsonSerializer serializer)
	{
		//IL_0008: Expected I, but got O
		//IL_0018: Expected O, but got I
		//IL_0028: Expected O, but got I
		nint num = (nint)writer;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2 @ X8_v1 (Il2CppClass<Newtonsoft.Json.JsonWriter>)+6A8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2 @ X8_v1 (Il2CppClass<Newtonsoft.Json.JsonWriter>)+6B0]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v3 @ X3_v1 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}

	public override bool ReadJson(JsonReader reader, Type objectType, bool existingValue, bool hasExistingValue, JsonSerializer serializer)
	{
		//IL_0092: Expected I4, but got O
		//IL_0070: Expected O, but got I4
		if (reader != null)
		{
			object value = reader.Value;
			if (value != null)
			{
				string s = value.ToString();
				int num = int.Parse(s);
				object obj = num - 1;
				return obj == null;
			}
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}
}
