using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Newtonsoft.Json.Linq.JsonPath;

namespace Kammelna.Server;

[Serializable]
public class PlatformConfiguration : Dictionary<string, string>
{
	public unsafe string PlatformSpecificValue
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_00cc: Expected O, but got I4
			//IL_003b: Expected O, but got Ref
			//IL_0083: Expected O, but got Ref
			object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1168;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Platform platform = KUtil.GetPlatform();
			object obj4 = default(object);
			string key = ((Enum)(&obj4)).ToString();
			if (((Dictionary<object, object>)(object)this).TryGetValue((object)key, out object value))
			{
				return (string)value;
			}
			string key2 = ((Enum)(&obj4)).ToString();
			return (string)DictionaryExtensions.Get((IDictionary<object, object>)this, key2);
		}
	}

	public PlatformConfiguration()
	{
		((Dictionary<object, object>)(object)this)..ctor();
	}
}
