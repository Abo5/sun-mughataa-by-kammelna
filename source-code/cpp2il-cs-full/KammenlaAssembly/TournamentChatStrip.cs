using System;
using System.Buffers.Text;
using Cpp2ILInjected;
using ListView;
using UnityEngine;
using UnityEngine.Purchasing.Telemetry;

public class TournamentChatStrip : ChatMessageStrip, IListViewItemExtra
{
	private TournamentStrip tournamentStrip;

	private float cardHeight = 450f;

	private ListViewItemExtra _extra;

	public ListViewItemExtra Extra => _extra;

	public override void Setup(ChatMessageDataHolder datum, bool firstTime)
	{
		//IL_000c: Expected O, but got I
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected O, but got Unknown
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0144: Unknown result type (might be due to invalid IL or missing references)
		//IL_0149: Expected O, but got Unknown
		//IL_01a0: Expected I, but got O
		object obj = (nint)0 + (nint)1528;
		((ListViewItem<object, int>)(object)this).Setup((object)datum, firstTime);
		if (firstTime)
		{
			GameObject gameObject = base.gameObject;
			if ((object)gameObject == null)
			{
				goto IL_01ab;
			}
			object obj2 = "ThisIsFakeReceiptData" + 1240;
			gameObject.name = (string)obj2;
		}
		Transform transform = base.transform;
		if ((object)transform != null)
		{
			object obj3 = typeof(System.Buffers.Text.ParserHelpers) + 3600;
			if (transform != obj3)
			{
				goto IL_01b9;
			}
			((RectTransform)transform).SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, cardHeight);
			if (datum != null)
			{
				ChatMessageData <message>k__BackingField = datum.<message>k__BackingField;
				if (datum.<message>k__BackingField != null)
				{
					if (<message>k__BackingField.<TournamentRoom>k__BackingField == null)
					{
						return;
					}
					object obj4 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1512;
					TournamentStrip tournamentStrip = this.tournamentStrip;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					TournamentDataHolder tournamentDataHolder = default(TournamentDataHolder);
					tournamentDataHolder..ctor(<message>k__BackingField.<TournamentRoom>k__BackingField, 0);
					if ((object)this.tournamentStrip != null)
					{
						nint num = (nint)tournamentStrip;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: [v191 @ X8_v12 (Il2CppClass<TournamentStrip>)+308] (should have been resolved before IL gen)");
						return;
					}
				}
			}
		}
		goto IL_01ab;
		IL_01b9:
		throw new InvalidCastException();
		IL_01ab:
		NullReferenceException ex = new NullReferenceException();
		goto IL_01b9;
	}

	public override float GetHeightForText(string text)
	{
		return cardHeight;
	}
}
