using TMPro;
using UnityEngine;

public class ProfileGiftsSenderUIItem : MonoBehaviour
{
	private TextMeshProUGUI indexText;

	private AvatarInitializer avatar;

	private ProfileGiftsDisplayer displayer;

	private long <UserId>k__BackingField;

	public long UserId
	{
		get
		{
			return <UserId>k__BackingField;
		}
		private set
		{
			<UserId>k__BackingField = value;
		}
	}

	public void Populate(ProfileGiftsSenderModel model, int index)
	{
		displayer.Populate(model.<SentGifts>k__BackingField, (byte)index != 0);
		<UserId>k__BackingField = model.<UserId>k__BackingField;
		int num = default(int);
		string text = num.ToString();
		indexText.text = text;
		AvatarData data = model;
		avatar.Initialize(data);
	}
}
