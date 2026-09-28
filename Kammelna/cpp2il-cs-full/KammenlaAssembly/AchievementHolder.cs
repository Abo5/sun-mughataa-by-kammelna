using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using ListView;

public struct AchievementHolder : IGridViewItemData<int>, IListViewItemData<int>
{
	private readonly int <index>k__BackingField;

	private readonly string <template>k__BackingField;

	private readonly GameAchievementViewModel <Model>k__BackingField;

	private readonly UserAchievementModel <UserModel>k__BackingField;

	private readonly bool <IsItMine>k__BackingField;

	public int index => <index>k__BackingField;

	public int columns => 1;

	public string template => <template>k__BackingField;

	public GameAchievementViewModel Model => <Model>k__BackingField;

	public UserAchievementModel UserModel => <UserModel>k__BackingField;

	public bool IsItMine => <IsItMine>k__BackingField;

	public unsafe AchievementHolder(GameAchievementViewModel model, UserAchievementModel userModel, bool isItMine, bool isEdit = false, int index = 0)
	{
		//IL_00fa: Expected O, but got Ref
		//IL_0117: Expected O, but got Ref
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Expected O, but got Unknown
		//IL_0172: Expected O, but got Ref
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Expected O, but got Unknown
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Expected O, but got Unknown
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected O, but got Unknown
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected O, but got Unknown
		//IL_008a: Expected O, but got I4
		object obj = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 16));
		GameAchievementViewModel gameAchievementViewModel = default(GameAchievementViewModel);
		obj = gameAchievementViewModel;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj2 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 24));
		obj2 = userModel;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		<IsItMine>k__BackingField = isItMine;
		<index>k__BackingField = index;
		object obj3 = obj;
		object obj4;
		if (obj != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X8_v3+28]");
			if ((nint)0 != 2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X8_v3+28]");
				if ((nint)0 == 1)
				{
					obj4 = "ThisIsFakeReceiptData" + 376;
					object obj5 = "ThisIsFakeReceiptData" + 368;
					bool flag = !isEdit;
					object obj6 = !flag;
					object obj7 = ~obj6;
					if (obj7 != null)
					{
						obj4 = obj5;
					}
				}
				else
				{
					obj4 = "<ds.DataTable.OnColumnChanging|INFO> {0}" + 3320;
				}
			}
			else
			{
				obj4 = "<ds.DataTable.OnColumnChanging|INFO> {0}" + 3328;
			}
		}
		else
		{
			obj4 = "ThisIsFakeReceiptData" + 376;
		}
		object obj8 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 8));
		obj8 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}
}
