using System;

[Serializable]
public struct GameAiCheatOption
{
	private int _roundIndex;

	private int _playerIndex;

	private AiCheatOption _aiCheatOption;

	public int RoundIndex => _roundIndex;

	public int PlayerIndex => _playerIndex;

	public AiCheatOption AiCheatOption => _aiCheatOption;
}
