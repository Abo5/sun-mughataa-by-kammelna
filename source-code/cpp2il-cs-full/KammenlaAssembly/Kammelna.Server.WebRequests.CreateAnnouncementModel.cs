using System;

namespace Kammelna.Server.WebRequests;

[Serializable]
public class CreateAnnouncementModel
{
	public string Title;

	public string Message;

	public bool PinOnCreate;
}
