using System.Formats.Asn1;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;

namespace Kammelna.Server.WebRequests;

public class UnlinkSocialPlatformRequest : BaseWebRequest<bool>
{
	private readonly SocialPlatform <SocialPlatform>k__BackingField;

	protected override HttpMethod Method => HttpMethod.DELETE;

	public override string EndPoint
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_007c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0081: Expected O, but got Unknown
			//IL_008b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0090: Expected O, but got Unknown
			//IL_00ba: Expected O, but got I4
			object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
			object obj2 = typeof(System.Formats.Asn1.SetOfValueComparer) + 824;
			object format = "alignContent" + 1808;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			string backendURL = Config.BackendURL;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
			object arg = default(object);
			string text = string.Format((string)format, arg);
			return backendURL + text;
		}
	}

	public SocialPlatform SocialPlatform => <SocialPlatform>k__BackingField;

	public UnlinkSocialPlatformRequest(SocialPlatform socialPlatform)
	{
		<SocialPlatform>k__BackingField = socialPlatform;
	}
}
