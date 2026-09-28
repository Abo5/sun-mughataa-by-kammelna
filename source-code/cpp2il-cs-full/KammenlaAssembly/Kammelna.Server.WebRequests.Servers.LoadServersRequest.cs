using Cpp2ILInjected;

namespace Kammelna.Server.WebRequests.Servers;

public class LoadServersRequest : BaseWebRequest<ConfigsModel>
{
	private readonly string _backendURL;

	protected override HttpMethod Method => HttpMethod.GET;

	public override string EndPoint
	{
		get
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Expected O, but got Unknown
			object obj = "alignContent" + 1608;
			return _backendURL + (string)obj;
		}
	}

	public LoadServersRequest(string backendURL)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected O, but got Unknown
		((BaseWebRequest<object>)(object)this)..ctor();
		object obj = this + 48;
		obj = backendURL;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}
}
