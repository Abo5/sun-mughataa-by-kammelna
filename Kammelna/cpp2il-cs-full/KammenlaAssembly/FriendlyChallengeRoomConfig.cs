using System.Threading;
using Cpp2ILInjected;
using Sfs2X.Entities.Data;

public class FriendlyChallengeRoomConfig
{
	private int <PrizeAmount>k__BackingField;

	private bool <CheatingAllowed>k__BackingField;

	private int <PlayingSpeed>k__BackingField;

	public int PrizeAmount
	{
		get
		{
			return <PrizeAmount>k__BackingField;
		}
		set
		{
			<PrizeAmount>k__BackingField = value;
		}
	}

	public bool CheatingAllowed
	{
		get
		{
			return <CheatingAllowed>k__BackingField;
		}
		set
		{
			<CheatingAllowed>k__BackingField = value;
		}
	}

	public int PlayingSpeed
	{
		get
		{
			return <PlayingSpeed>k__BackingField;
		}
		set
		{
			<PlayingSpeed>k__BackingField = value;
		}
	}

	public FriendlyChallengeRoomConfig()
	{
	}

	public FriendlyChallengeRoomConfig(int prizeAmount, bool cheatingAllowed, int playingSpeed)
	{
		<PrizeAmount>k__BackingField = prizeAmount;
		<CheatingAllowed>k__BackingField = cheatingAllowed;
		<PlayingSpeed>k__BackingField = playingSpeed;
	}

	public ISFSObject ToSfsObject()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		object obj = typeof(RegisteredWaitHandle) + 2040;
		object key = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 2728;
		object key2 = "startPosition" + 3280;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		SFSObject sFSObject = default(SFSObject);
		sFSObject..ctor();
		if (<PrizeAmount>k__BackingField >= 1)
		{
			object key3 = "destinationTimeZone" + 4008;
			SFSExtensions.Put(sFSObject, (string)key3, <PrizeAmount>k__BackingField);
		}
		SFSExtensions.Put(sFSObject, (string)key, <CheatingAllowed>k__BackingField);
		SFSExtensions.Put(sFSObject, (string)key2, <PlayingSpeed>k__BackingField);
		return sFSObject;
	}
}
