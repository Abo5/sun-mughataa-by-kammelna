using Cpp2ILInjected;
using TMPro;
using UnityEngine;

public class PlayerStatisticUI : MonoBehaviour
{
	public AvatarInitializer playerAvatar;

	public TextMeshProUGUI playerScore;

	private KPlayer _player;

	private double _score;

	public unsafe void SetUp(KPlayer player, double score)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_0032: Expected native int or pointer, but got F8
		//IL_0053: Expected O, but got I
		//IL_005c: Expected Ref, but got F8
		object obj = this + 48;
		obj = player;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		double num = (double)this + 56.0;
		((double*)(nint)num)->m_value = score;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X20_v2 (System.Double)-18]");
		((AvatarInitializer)0).Initialize(_player);
		string text = ((double*)num)->ToString();
		playerScore.text = text;
		playerScore.enabled = true;
	}

	private void SetPlayerAvatar()
	{
		playerAvatar.Initialize(_player);
	}

	private unsafe void SetPlayerScore()
	{
		//IL_0016: Expected Ref, but got F8
		double num = (double)this + 56.0;
		string text = ((double*)num)->ToString();
		playerScore.text = text;
		playerScore.enabled = true;
	}

	public void SetHighestStatColor(StatType statType)
	{
		//IL_0029: Expected O, but got I4
		//IL_0060: Expected O, but got I4
		//IL_0052: Expected O, but got I4
		//IL_007c: Expected O, but got I4
		//IL_006e: Expected O, but got I4
		//IL_0098: Expected O, but got I4
		//IL_00e5: Expected I, but got O
		//IL_00f5: Expected O, but got I
		//IL_0105: Expected O, but got I
		//IL_008a: Expected O, but got I4
		TextMeshProUGUI textMeshProUGUI = playerScore;
		bool flag = statType < StatType.NegativeHighest;
		object obj = !flag;
		object obj2 = ~obj;
		object obj3 = ~obj2;
		if (obj3 == null)
		{
			object obj4 = 0;
		}
		else
		{
			object obj4 = 1061734601;
		}
		object obj5 = ~obj;
		object obj6 = ~obj5;
		if (obj6 == null)
		{
			object obj7 = 1057787021;
		}
		else
		{
			object obj7 = 1033937057;
		}
		object obj8 = ~obj;
		object obj9 = ~obj8;
		if (obj9 == null)
		{
			object obj10 = 1042325665;
		}
		else
		{
			object obj10 = 0;
		}
		nint num = (nint)textMeshProUGUI;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X8_v9 (Il2CppClass<TMPro.TextMeshProUGUI>)+2A8]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X8_v9 (Il2CppClass<TMPro.TextMeshProUGUI>)+2B0]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v53 @ X2_v1 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}

	public void ResetStatPlayerUI()
	{
		//IL_000d: Expected O, but got I
		playerScore.color = (Color)0;
		playerScore.enabled = false;
		playerAvatar.Clear();
	}
}
