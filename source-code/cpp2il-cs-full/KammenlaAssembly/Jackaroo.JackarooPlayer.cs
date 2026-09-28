using System;
using Cpp2ILInjected;

namespace Jackaroo;

public class JackarooPlayer : CardGamePlayer
{
	private readonly JackarooGame _jackarooGame;

	public JackarooPlayer GetNextPlayer
	{
		get
		{
			if ((object)_jackarooGame != null)
			{
				return _jackarooGame.GetNextPlayer(this);
			}
			return (JackarooPlayer)(object)new NullReferenceException();
		}
	}

	public int GetNextPlayerIndex
	{
		get
		{
			//IL_0064: Expected I4, but got O
			if ((object)_jackarooGame != null)
			{
				JackarooPlayer nextPlayer = _jackarooGame.GetNextPlayer(this);
				if (nextPlayer != null)
				{
					return ((KPlayer)nextPlayer).<Index>k__BackingField;
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
		}
	}

	public JackarooPlayer(JackarooGame game)
		: base(game)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		object obj = this + 112;
		obj = game;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}
}
