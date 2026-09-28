using System.Runtime.CompilerServices;

public class AdCampaignTournamentAddon : TournamentAddonModel
{
	private int <AdCampaignId>k__BackingField;

	public override int Priority => 20;

	public override TournamentAddonType Type => TournamentAddonType.AdCampaign;

	public unsafe override string SerializedData
	{
		get
		{
			//IL_0008: Expected O, but got Ref
			object obj2 = default(object);
			object obj = (object)(&obj2);
			_ = <AdCampaignId>k__BackingField;
			int num = (int)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 4));
			return ((int*)num)->ToString();
		}
	}

	public int AdCampaignId
	{
		get
		{
			return <AdCampaignId>k__BackingField;
		}
		set
		{
			<AdCampaignId>k__BackingField = value;
		}
	}

	public AdCampaignTournamentAddon(string adCampaignId)
	{
		int num = int.Parse(adCampaignId);
		<AdCampaignId>k__BackingField = num;
	}
}
