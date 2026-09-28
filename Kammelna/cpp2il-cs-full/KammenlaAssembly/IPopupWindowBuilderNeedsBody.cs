public interface IPopupWindowBuilderNeedsBody
{
	IPopupWindowBuilderAttributes WithContent(string body);

	IPopupWindowBuilderAttributes WithContent(LocalizableText body);
}
