using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using ListView;

public class VaultTransactionDataHolder : IListViewItemData<int>
{
	public const string TEMPLATE = "Vault transaction strip";

	private readonly int <index>k__BackingField;

	private readonly ClanVaultTransactionModel <Model>k__BackingField;

	private readonly ClanVaultSupporterModel <Supporter>k__BackingField;

	public int index => <index>k__BackingField;

	public ClanVaultTransactionModel Model => <Model>k__BackingField;

	public ClanVaultSupporterModel Supporter => <Supporter>k__BackingField;

	public string template => "Unsupported map type" + 2408;

	public VaultTransactionDataHolder(int index, ClanVaultTransactionModel model)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		object obj = this + 24;
		obj = model;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	public VaultTransactionDataHolder(int index, ClanVaultSupporterModel supporter)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		object obj = this + 32;
		obj = supporter;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}
}
