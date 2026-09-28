using Sfs2X.Entities.Data;

public class BaseExtraGameResult
{
	private static class Constants
	{
		public const string MatchWinner = "mw";

		public const string IsFinalMatch = "fm";
	}

	private int <MatchWinner>k__BackingField;

	private bool <IsFinalMatch>k__BackingField;

	public int MatchWinner
	{
		get
		{
			return <MatchWinner>k__BackingField;
		}
		set
		{
			<MatchWinner>k__BackingField = value;
		}
	}

	public bool IsFinalMatch
	{
		get
		{
			return <IsFinalMatch>k__BackingField;
		}
		set
		{
			<IsFinalMatch>k__BackingField = value;
		}
	}

	public BaseExtraGameResult(ISFSObject gameResultData)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		object varName = "m_StencilDeferredPS" + 2816;
		object varName2 = "fetch_products" + 840;
		base..ctor();
		int num = SFSExtensions.Get(gameResultData, (string)varName, 0);
		<MatchWinner>k__BackingField = num;
		bool flag = SFSExtensions.Get(gameResultData, (string)varName2, defaultValue: false);
		<IsFinalMatch>k__BackingField = flag;
	}
}
