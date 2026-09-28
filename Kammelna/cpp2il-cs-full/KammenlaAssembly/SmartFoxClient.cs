using System.ComponentModel;
using Cpp2ILInjected;
using Sfs2X;
using Sfs2X.Entities;
using Sfs2X.Entities.Data;
using Sfs2X.Requests;
using Sfs2X.Util;

public class SmartFoxClient : SmartFox
{
	public SmartFoxClient()
	{
	}

	public SmartFoxClient(UseWebSocket useWebSocket)
		: base(useWebSocket)
	{
	}

	public virtual void Send(string command, ISFSObject param, Room room)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		object obj = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 64;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		ExtensionRequest extensionRequest = default(ExtensionRequest);
		extensionRequest..ctor(command, param, room);
		Send(extensionRequest);
	}

	public new virtual void ProcessEvents()
	{
		base.ProcessEvents();
	}
}
