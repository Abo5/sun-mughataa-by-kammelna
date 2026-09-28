public interface IPopupWindowBuilderNeedsTitle
{
	IPopupWindowBuilderNeedsBody Titled(string title);

	IPopupWindowBuilderNeedsBody Titled(LocalizableText title);
}
