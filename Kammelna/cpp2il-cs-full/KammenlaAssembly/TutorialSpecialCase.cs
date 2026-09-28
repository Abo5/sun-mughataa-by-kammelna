using System;

[Serializable]
public struct TutorialSpecialCase
{
	private string _errorString;

	private IsEqual _isEqual;

	private CardData _cardDataCase;

	public string ErrorString => _errorString;

	public IsEqual Equal => _isEqual;

	public CardData CardDataCase => _cardDataCase;
}
