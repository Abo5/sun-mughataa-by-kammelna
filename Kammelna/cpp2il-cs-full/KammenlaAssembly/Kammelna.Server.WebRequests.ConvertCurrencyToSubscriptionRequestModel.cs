using System;

namespace Kammelna.Server.WebRequests;

[Serializable]
public class ConvertCurrencyToSubscriptionRequestModel
{
	private int <Currency>k__BackingField;

	public int Currency
	{
		get
		{
			return <Currency>k__BackingField;
		}
		set
		{
			<Currency>k__BackingField = value;
		}
	}
}
