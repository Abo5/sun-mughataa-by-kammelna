using Cpp2ILInjected;
using UnityEngine;

namespace Jackaroo;

public class JackarooTheme : ScriptableObject
{
	private JackarooThemeData <ThemeData>k__BackingField;

	public JackarooThemeData ThemeData
	{
		get
		{
			return <ThemeData>k__BackingField;
		}
		private set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 24;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}
}
