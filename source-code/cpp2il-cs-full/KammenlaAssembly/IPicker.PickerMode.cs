using System;

public interface IPicker
{
	public enum PickerMode
	{
		Normal,
		PastOnly,
		FutureOnly
	}

	public delegate void TimeDel(DateTime time);

	event TimeDel OnPickEnded;

	void OpenPicker(DateTime defaultTime, PickerMode mode = PickerMode.Normal);

	void ClosePicker();
}
