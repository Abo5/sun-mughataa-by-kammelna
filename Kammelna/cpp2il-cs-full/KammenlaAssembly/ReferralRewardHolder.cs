using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using ListView;

public struct ReferralRewardHolder : IListViewItemData<int>
{
	private readonly int <index>k__BackingField;

	private readonly UserReferralRewardModel <Model>k__BackingField;

	public int index => <index>k__BackingField;

	public string template => "Read object reference Id '{0}' for {1}." + 1024;

	public UserReferralRewardModel Model => <Model>k__BackingField;

	public unsafe ReferralRewardHolder(UserReferralRewardModel model)
	{
		//IL_000b: Expected O, but got Ref
		object obj = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 8));
		obj = model;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		<index>k__BackingField = model.<rewardID>k__BackingField;
	}
}
