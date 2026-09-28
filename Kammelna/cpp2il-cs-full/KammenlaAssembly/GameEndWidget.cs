using Cpp2ILInjected;
using DG.Tweening;
using Kammelna.Server.Models.Clans;
using UnityEngine;

public abstract class GameEndWidget : MonoBehaviour
{
	private CardGame _game;

	protected CardGame game
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_001f: Expected O, but got I
			//IL_007d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0082: Expected O, but got Unknown
			//IL_00a4: Expected O, but got I4
			//IL_0042: Unknown result type (might be due to invalid IL or missing references)
			//IL_0047: Expected O, but got Unknown
			//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c6: Expected O, but got Unknown
			//IL_00f0: Expected O, but got I4
			//IL_0119: Expected O, but got I
			object obj = 152985600;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E679E]");
			object obj2 = (nint)0 & (nint)1;
			CardGame result;
			object obj3;
			if (obj2 != null)
			{
				obj3 = this + 32;
				result = (CardGame)obj3;
				if (obj3 != null)
				{
					goto IL_006c;
				}
			}
			else
			{
				_ = 1;
				obj3 = this + 32;
				result = (CardGame)obj3;
				bool flag = obj3 == null;
				object obj4 = !flag;
				if (obj4 != null)
				{
					goto IL_006c;
				}
			}
			object obj5 = typeof(MemberAchievementClanFeedData) + 2976;
			object obj6 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v2+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj8 = (nint)0 + (nint)24;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE90D8");
			CardGame cardGame = default(CardGame);
			obj3 = cardGame;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			return cardGame;
			IL_006c:
			return result;
		}
	}

	public abstract void PrepareAnimation(CardGameEndScores rankReport);

	public abstract void Populate(CardGameEndScores rankReport);

	public abstract Sequence AnimatedPopulate(CardGameEndScores rankReport);

	public abstract bool ShouldShow(CardGameEndScores rankReport);

	public virtual void Disable()
	{
		GameObject gameObject = base.gameObject;
		gameObject.SetActive(value: false);
	}
}
