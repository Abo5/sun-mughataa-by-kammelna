using System.Data.SqlTypes;
using Cpp2ILInjected;

public class ProfileGiftModel
{
	public long ID;

	public int Price;

	public string Name;

	public FileInfoModel Image;

	public string AchievementId
	{
		get
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Expected O, but got Unknown
			//IL_0024: Expected O, but got I4
			object format = "Cannot populate JSON object onto type '{0}'." + 3952;
			object obj = 153100288 + 1024;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
			object arg = default(object);
			return string.Format((string)format, arg);
		}
	}

	public GameAchievementViewModel Achievement
	{
		get
		{
			//IL_0023: Unknown result type (might be due to invalid IL or missing references)
			//IL_0028: Expected O, but got Unknown
			//IL_0032: Unknown result type (might be due to invalid IL or missing references)
			//IL_0037: Expected O, but got Unknown
			//IL_005e: Expected O, but got I4
			//IL_00a3: Expected O, but got I4
			object obj = typeof(SqlSingle[]) + 2360;
			object format = "Cannot populate JSON object onto type '{0}'." + 3952;
			object obj2 = 153100288 + 1024;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
			object arg = default(object);
			string achievementId = string.Format((string)format, arg);
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X8_v8+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			return AchievementsManager.GetAchievement(achievementId);
		}
	}

	public ProfileGiftModel(long id, int price, string name)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		object obj = this + 32;
		obj = name;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	public ProfileGiftModel()
	{
	}
}
