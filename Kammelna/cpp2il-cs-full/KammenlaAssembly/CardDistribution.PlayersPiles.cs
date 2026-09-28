using Cpp2ILInjected;
using UnityEngine;

namespace CardDistribution;

public class PlayersPiles : MonoBehaviour
{
	private PlayerPilesStacks[] <PlayersPilesList>k__BackingField;

	public PlayerPilesStacks[] PlayersPilesList
	{
		get
		{
			return <PlayersPilesList>k__BackingField;
		}
		private set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 32;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}
}
