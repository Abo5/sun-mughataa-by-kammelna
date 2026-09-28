using System;
using System.Buffers.Text;
using Cpp2ILInjected;
using ReportEnums;
using UnityEngine;

public class ReportElementProblemLocation : BaseDropMenu<ProblemAppScreen>, IReportElement<ProblemAppScreen>, IDummyReportElement, IReportElement<object>
{
	private ReportElementType type;

	private bool isRequired;

	private GameObject emphasise;

	public ReportElementType Type => type;

	public bool IsReportElementActive
	{
		get
		{
			//IL_0011: Expected O, but got I
			//IL_001f: Expected I4, but got O
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ReportElementProblemLocation)+34]");
			object obj = ~(nint)0;
			return (byte)(obj >> 31) != 0;
		}
	}

	public bool IsRequired => isRequired;

	object IReportElement<object>.Value
	{
		get
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0025: Expected O, but got I
			object obj = typeof(System.Buffers.Text.ParserHelpers) + 1928;
			object obj2 = (nint)0 + (nint)2472;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3E221D0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
			object result = default(object);
			return result;
		}
	}

	public ProblemAppScreen Value
	{
		get
		{
			//IL_000c: Expected O, but got I
			object obj = (nint)0 + (nint)2472;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3E221D0");
			ProblemAppScreen result = default(ProblemAppScreen);
			return result;
		}
	}

	public void HighlightRequired()
	{
		if (isRequired)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ReportElementProblemLocation)+34]");
			bool active = (byte)((nint)0 >> 31) != 0;
			emphasise.SetActive(active);
		}
	}

	protected override string ItemName(ProblemAppScreen item)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 1928;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		Enum enumeration = default(Enum);
		return EnumExtensions.GetFriendlyName(enumeration);
	}

	public ReportElementProblemLocation()
	{
		//IL_000c: Expected O, but got I
		object obj = (nint)0 + (nint)2464;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3E2356C");
	}
}
