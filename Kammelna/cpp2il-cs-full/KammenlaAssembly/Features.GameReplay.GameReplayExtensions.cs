using Cpp2ILInjected;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq.JsonPath;

namespace Features.GameReplay;

public static class GameReplayExtensions
{
	public static string Serialize(GameReplay gameReplay, JsonSerializerSettings serializerSettings)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0068: Expected O, but got I4
		object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 520;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		return JsonConvert.SerializeObject(gameReplay, serializerSettings);
	}
}
