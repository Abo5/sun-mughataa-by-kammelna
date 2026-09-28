using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2ILInjected;
using UnityEngine;

public class ObjectToggler : BaseToggler
{
	public List<GameObject> objectsToBeDisabled;

	public List<GameObject> objectsToBeEnabled;

	protected override void ToggleOn()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_0096: Expected I, but got O
		//IL_0031: Expected O, but got I
		//IL_003d: Expected O, but got I
		//IL_0069: Expected I, but got O
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2096;
		object obj2 = (nint)0 + (nint)1976;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)null, (IntPtr)obj2);
		object obj3 = (nint)0 + (nint)2560;
		object obj4 = (nint)0 + (nint)1960;
		((List<object>)(object)objectsToBeEnabled).ForEach(action);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action2 = default(Action<object>);
		action2..ctor((object)null, (IntPtr)obj4);
		((List<object>)(object)objectsToBeDisabled).ForEach(action2);
	}

	protected override void ToggleOff()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_0096: Expected I, but got O
		//IL_0031: Expected O, but got I
		//IL_003d: Expected O, but got I
		//IL_0069: Expected I, but got O
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2096;
		object obj2 = (nint)0 + (nint)1960;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)null, (IntPtr)obj2);
		object obj3 = (nint)0 + (nint)2560;
		object obj4 = (nint)0 + (nint)1976;
		((List<object>)(object)objectsToBeEnabled).ForEach(action);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action2 = default(Action<object>);
		action2..ctor((object)null, (IntPtr)obj4);
		((List<object>)(object)objectsToBeDisabled).ForEach(action2);
	}
}
