using ReportEnums;

public interface IReportElement<T>
{
	ReportElementType Type { get; }

	bool IsReportElementActive { get; }

	bool IsRequired { get; }

	T Value { get; }

	void HighlightRequired();
}
