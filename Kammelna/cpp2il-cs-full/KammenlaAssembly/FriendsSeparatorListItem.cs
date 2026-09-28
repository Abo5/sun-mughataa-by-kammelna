using System;
using System.ComponentModel;
using Cpp2ILInjected;
using ListView;
using TMPro;

public class FriendsSeparatorListItem : ListViewItem<IListViewItemData<int>, int>
{
	private TextMeshProUGUI numberTextField;

	public override void Setup(IListViewItemData<int> datum, bool firstTime)
	{
		bool firstTime2 = default(bool);
		((ListViewItem<object, int>)(object)this).Setup((object)datum, firstTime2);
		Initialize();
	}

	private void Initialize()
	{
		//IL_00c9: Expected O, but got I
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (FriendsSeparatorListItem)+40]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (FriendsSeparatorListItem)+40]");
		if ((nint)0 != 0)
		{
			object obj2 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1408;
			object obj3 = obj2;
			object obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X8_v7+40]");
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X1_v3+40]");
			if (num != 0)
			{
				goto IL_00b2;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1960");
			int num2 = default(int);
			string text = num2.ToString();
			if ((object)numberTextField != null)
			{
				numberTextField.text = text;
				return;
			}
		}
		NullReferenceException ex = new NullReferenceException();
		goto IL_00b2;
		IL_00b2:
		throw new InvalidCastException();
	}

	public FriendsSeparatorListItem()
	{
		((ListViewItem<object, int>)(object)this)..ctor();
	}
}
