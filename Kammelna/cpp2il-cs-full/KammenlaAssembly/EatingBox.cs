public class EatingBox : BaseCheatingBox
{
	protected override void SetupBox(int eating)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		object text = "Drop Menu Toggle" + 1888;
		TextMeshProExtensions.Localize(title, (string)text);
		string text2 = title.text;
		int num = default(int);
		string newValue = num.ToString();
		object oldValue = "utf-32" + 1752;
		string text3 = text2.Replace((string)oldValue, newValue);
		title.text = text3;
	}
}
