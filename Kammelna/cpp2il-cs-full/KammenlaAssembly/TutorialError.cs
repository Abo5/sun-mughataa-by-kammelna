using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;

[Serializable]
public struct TutorialError
{
	private string _errorMessage;

	private bool _useSpecialCase;

	private TutorialSpecialCase _tutorialSpecialCase;

	public string ErrorMessage => _errorMessage;

	public bool UseSpecialCase => _useSpecialCase;

	public unsafe TutorialSpecialCase TutorialSpecialCase
	{
		get
		{
			//IL_000a: Expected native int or pointer, but got O
			//IL_001e: Expected O, but got Ref
			TutorialSpecialCase tutorialSpecialCase = default(TutorialSpecialCase);
			System.Runtime.CompilerServices.Unsafe.Write(&((TutorialSpecialCase*)(nint)tutorialSpecialCase)->_errorString, (string)_tutorialSpecialCase);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (TutorialError)+20]");
			_ = 0;
			return (TutorialSpecialCase)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this);
		}
	}
}
