using System;

namespace Kammelna.Server.WebRequests;

[Serializable]
public class ChangeNickNameErrorModel
{
	private long <NextAllowedChangeTime>k__BackingField;

	public long NextAllowedChangeTime
	{
		get
		{
			return <NextAllowedChangeTime>k__BackingField;
		}
		set
		{
			<NextAllowedChangeTime>k__BackingField = value;
		}
	}
}
