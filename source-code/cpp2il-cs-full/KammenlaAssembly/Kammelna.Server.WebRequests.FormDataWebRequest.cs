using System.Collections.Generic;
using System.Text;
using Cpp2ILInjected;
using UnityEngine.Networking;
using UnityEngine.Purchasing.Telemetry;

namespace Kammelna.Server.WebRequests;

public abstract class FormDataWebRequest<TResponse> : BaseWebRequest<TResponse>
{
	protected abstract List<IMultipartFormSection> FormData { get; }

	public sealed override void Setup()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_003c: Expected I, but got O
		//IL_008d: Expected O, but got I
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected O, but got Unknown
		//IL_00ed: Expected O, but got I
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Expected O, but got Unknown
		//IL_0130: Expected O, but got I
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 4000;
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4290614");
		byte[] array = UnityWebRequest.GenerateBoundary();
		nint num2 = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v95 @ X8_v6 (Il2CppClass<Kammelna.Server.WebRequests.FormDataWebRequest`1<TResponse>>)+288] (should have been resolved before IL gen)");
		List<IMultipartFormSection> multipartFormSections = default(List<IMultipartFormSection>);
		byte[] data = UnityWebRequest.SerializeFormSections(multipartFormSections, array);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UploadHandlerRaw uploadHandlerRaw = default(UploadHandlerRaw);
		uploadHandlerRaw..ctor(data);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Kammelna.Server.WebRequests.FormDataWebRequest`1<TResponse>)+18]");
		((UnityWebRequest)0).uploadHandler = uploadHandlerRaw;
		Encoding uTF = Encoding.UTF8;
		object obj2 = "m_StencilDeferredPS" + 2760;
		string text = uTF.GetString(array, 0, array.Length);
		string text2 = (string)obj2 + text;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Kammelna.Server.WebRequests.FormDataWebRequest`1<TResponse>)+18]");
		UploadHandler uploadHandler = ((UnityWebRequest)0).uploadHandler;
		uploadHandler.contentType = text2;
		object name = "Complete" + 904;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Kammelna.Server.WebRequests.FormDataWebRequest`1<TResponse>)+18]");
		((UnityWebRequest)0).SetRequestHeader((string)name, text2);
	}

	protected FormDataWebRequest()
	{
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4290E84");
	}
}
