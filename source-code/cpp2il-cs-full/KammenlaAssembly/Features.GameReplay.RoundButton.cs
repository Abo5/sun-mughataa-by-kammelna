using Cpp2ILInjected;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Features.GameReplay;

public class RoundButton : MonoBehaviour
{
	private Button <Button>k__BackingField;

	private TextMeshProUGUI <Text>k__BackingField;

	private ObjectToggler _currentToggler;

	private SpriteToggler _normalSheraToggler;

	private SpriteToggler _currentSheraToggler;

	private ObjectToggler _commentToggler;

	public Button Button
	{
		get
		{
			return <Button>k__BackingField;
		}
		private set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 32;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public TextMeshProUGUI Text
	{
		get
		{
			return <Text>k__BackingField;
		}
		private set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 40;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public void SetCurrentState(bool state)
	{
		bool isON = (byte)((state ? 1u : 0u) ^ 1u) != 0;
		_currentToggler.ToggleManual(isON);
	}

	private void SetNormal()
	{
		_currentToggler.ToggleManual(isON: true);
	}

	private void SetCurrent()
	{
		_currentToggler.ToggleManual(isON: false);
	}

	public void SetSheraState(bool state)
	{
		if (state)
		{
			_normalSheraToggler.ToggleManual(isON: false);
			_currentSheraToggler.ToggleManual(isON: false);
		}
		else
		{
			_normalSheraToggler.ToggleManual(isON: true);
			_currentSheraToggler.ToggleManual(isON: true);
		}
	}

	private void SetSheraNormal()
	{
		_normalSheraToggler.ToggleManual(isON: false);
		_currentSheraToggler.ToggleManual(isON: false);
	}

	private void SetSheraFail()
	{
		_normalSheraToggler.ToggleManual(isON: true);
		_currentSheraToggler.ToggleManual(isON: true);
	}

	public void SetCommentState(bool state)
	{
		bool isON = (byte)((state ? 1u : 0u) ^ 1u) != 0;
		_commentToggler.ToggleManual(isON);
	}

	private void SetComment()
	{
		_commentToggler.ToggleManual(isON: false);
	}

	private void SetNoComment()
	{
		_commentToggler.ToggleManual(isON: true);
	}
}
