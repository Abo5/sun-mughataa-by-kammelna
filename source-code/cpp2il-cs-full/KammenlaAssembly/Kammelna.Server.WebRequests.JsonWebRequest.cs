using System.Text;
using Cpp2ILInjected;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq.JsonPath;
using UnityEngine.Networking;
using UnityEngine.Purchasing.Telemetry;

namespace Kammelna.Server.WebRequests;

public abstract class JsonWebRequest<TRequest, TResponse> : BaseWebRequest<TResponse>
{
	protected abstract TRequest PostData { get; }

	public sealed override void Setup()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_002e: Expected I, but got O
		//IL_0062: Expected O, but got I4
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Expected O, but got Unknown
		//IL_009b: Expected I, but got O
		//IL_00dd: Expected O, but got I
		//IL_00f3: Expected O, but got I
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Expected O, but got Unknown
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Expected O, but got Unknown
		//IL_0145: Expected O, but got I
		object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 520;
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4290614");
		nint num2 = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v95 @ X8_v6 (Il2CppClass<Kammelna.Server.WebRequests.JsonWebRequest`2<TRequest, TResponse>>)+288] (should have been resolved before IL gen)");
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X8_v7+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object value = default(object);
		string s = JsonConvert.SerializeObject(value);
		Encoding uTF = Encoding.UTF8;
		object obj4 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 4000;
		nint num3 = (nint)uTF;
		byte[] bytes = uTF.GetBytes(s);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UploadHandlerRaw uploadHandlerRaw = default(UploadHandlerRaw);
		uploadHandlerRaw..ctor(bytes);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Kammelna.Server.WebRequests.JsonWebRequest`2<TRequest, TResponse>)+18]");
		((UnityWebRequest)0).uploadHandler = uploadHandlerRaw;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Kammelna.Server.WebRequests.JsonWebRequest`2<TRequest, TResponse>)+18]");
		UploadHandler uploadHandler = ((UnityWebRequest)0).uploadHandler;
		object value2 = (uploadHandler.contentType = "alignContent" + 2104);
		object name = "Complete" + 904;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Kammelna.Server.WebRequests.JsonWebRequest`2<TRequest, TResponse>)+18]");
		((UnityWebRequest)0).SetRequestHeader((string)name, (string)value2);
	}

	protected JsonWebRequest()
	{
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4290E84");
	}
}
