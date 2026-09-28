using Cpp2ILInjected;
using DG.Tweening;
using UnityEngine;

namespace CardDistribution;

public class CardDistributorSO : ScriptableObject
{
	private float <FirstDealDelay>k__BackingField;

	private float <CardFlightDuration>k__BackingField;

	private Ease <CardFlightEase>k__BackingField;

	private float <DelayBetweenCards>k__BackingField;

	private bool <GroundCardsGoToPile>k__BackingField;

	public float FirstDealDelay
	{
		get
		{
			return <FirstDealDelay>k__BackingField;
		}
		private set
		{
			<FirstDealDelay>k__BackingField = value;
		}
	}

	public float CardFlightDuration
	{
		get
		{
			return <CardFlightDuration>k__BackingField;
		}
		private set
		{
			<CardFlightDuration>k__BackingField = value;
		}
	}

	public Ease CardFlightEase
	{
		get
		{
			return <CardFlightEase>k__BackingField;
		}
		private set
		{
			<CardFlightEase>k__BackingField = value;
		}
	}

	public float DelayBetweenCards
	{
		get
		{
			return <DelayBetweenCards>k__BackingField;
		}
		private set
		{
			<DelayBetweenCards>k__BackingField = value;
		}
	}

	public bool GroundCardsGoToPile
	{
		get
		{
			return <GroundCardsGoToPile>k__BackingField;
		}
		private set
		{
			<GroundCardsGoToPile>k__BackingField = value;
		}
	}

	public CardDistributorSO()
	{
		//IL_0012: Expected F4, but got I
		//IL_0021: Expected I4, but got I8
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [7253278]");
		<FirstDealDelay>k__BackingField = 0f;
		<CardFlightEase>k__BackingField = Ease.OutQuart;
		<GroundCardsGoToPile>k__BackingField = true;
		base..ctor();
	}
}
