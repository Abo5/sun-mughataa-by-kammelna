using System;
using System.Data.SqlTypes;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using UnityEngine;

namespace UI.Pickers;

public class PageScrollButtonsHandler : MonoBehaviour
{
	public GameObject nextButton;

	public GameObject previousButton;

	public UIPicker UiPicker;

	public DiscreteProgressIndicator DiscreteProgressIndicator;

	public void PreviousButtonCheck()
	{
		UiPicker.MoveToPrevious();
		DiscreteProgressIndicator.Previous();
		nextButton.SetActive(value: true);
		UIPicker uiPicker = UiPicker;
		bool flag = uiPicker._currentSelectionIndex == 0;
		bool active = !flag;
		previousButton.SetActive(active);
	}

	public void NextButtonCheck()
	{
		//IL_0061: Expected O, but got I4
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected O, but got Unknown
		UiPicker.MoveToNext();
		DiscreteProgressIndicator.Next();
		previousButton.SetActive(value: true);
		UIPicker uiPicker = UiPicker;
		GameObject[] items = uiPicker.items;
		object obj = items.Length - 1;
		object obj2 = uiPicker._currentSelectionIndex - obj;
		bool flag = obj2 == null;
		bool active = !flag;
		nextButton.SetActive(active);
	}

	public void OpenPageCheck()
	{
		previousButton.SetActive(value: false);
		UIPicker uiPicker = UiPicker;
		GameObject[] items = uiPicker.items;
		if (items.Length >= 2)
		{
			nextButton.SetActive(value: true);
		}
	}

	public void SetDiscreteProgressIndicator()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0073: Expected I, but got O
		//IL_009d: Expected O, but got I4
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)2528;
		object obj3 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Coroutine coroutine = CoroutineDummy.WaitForSeconds(0.4f, action);
	}

	private void SetProgressHelper()
	{
		//IL_0084: Expected O, but got I4
		//IL_01aa: Expected O, but got I4
		UIPicker uiPicker = UiPicker;
		int currentProgress = uiPicker._currentSelectionIndex + 1;
		DiscreteProgressIndicator.CurrentProgress = currentProgress;
		UIPicker uiPicker2 = UiPicker;
		GameObject gameObject;
		if (uiPicker2._currentSelectionIndex != 0)
		{
			GameObject[] items = uiPicker2.items;
			object obj = items.Length - 1;
			if (uiPicker2._currentSelectionIndex == (nint)obj)
			{
				nextButton.SetActive(value: false);
				UIPicker uiPicker3 = UiPicker;
				GameObject[] items2 = uiPicker3.items;
				if (items2.Length < 2)
				{
					return;
				}
			}
			else
			{
				nextButton.SetActive(value: true);
			}
			gameObject = previousButton;
		}
		else
		{
			previousButton.SetActive(value: false);
			UIPicker uiPicker4 = UiPicker;
			GameObject[] items3 = uiPicker4.items;
			if (items3.Length < 2)
			{
				return;
			}
			gameObject = nextButton;
			bool flag = (object)nextButton == null;
			object obj2 = !flag;
			if (obj2 == null)
			{
				throw new NullReferenceException();
			}
		}
		gameObject.SetActive(value: true);
	}

	public void CheckPreviousAndNextButtons()
	{
		//IL_00c6: Expected O, but got I4
		previousButton.SetActive(value: true);
		nextButton.SetActive(value: true);
		DiscreteProgressIndicator discreteProgressIndicator = DiscreteProgressIndicator;
		GameObject gameObject;
		if (discreteProgressIndicator.currentProgress == 1)
		{
			gameObject = previousButton;
		}
		else
		{
			if (discreteProgressIndicator.currentProgress != discreteProgressIndicator.maxProgress)
			{
				return;
			}
			gameObject = nextButton;
			bool flag = (object)nextButton == null;
			object obj = !flag;
			if (obj == null)
			{
				throw new NullReferenceException();
			}
		}
		gameObject.SetActive(value: false);
	}
}
