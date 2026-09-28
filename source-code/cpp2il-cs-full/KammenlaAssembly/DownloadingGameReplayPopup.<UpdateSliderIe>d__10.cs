using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Networking;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.Rendering;
using UnityEngine.UI;

public class DownloadingGameReplayPopup : MonoBehaviour, IInitializable
{
	private sealed class <UpdateSliderIe>d__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state;

		private object <>2__current;

		public DownloadingGameReplayPopup <>4__this;

		object IEnumerator<object>.Current => <>2__current;

		object IEnumerator.Current => <>2__current;

		public <UpdateSliderIe>d__10(int <>1__state)
		{
			this.<>1__state = <>1__state;
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_001c: Expected O, but got I4
			//IL_0043: Expected I4, but got I8
			//IL_0155: Expected I4, but got O
			//IL_0123: Unknown result type (might be due to invalid IL or missing references)
			//IL_0128: Expected O, but got Unknown
			//IL_0131: Expected O, but got I4
			bool flag = <>1__state < 2;
			object obj = !flag;
			if (obj == null)
			{
				DownloadingGameReplayPopup downloadingGameReplayPopup = <>4__this;
				<>1__state = -1;
				if ((object)<>4__this != null && downloadingGameReplayPopup._unityWebRequestAsyncOperation != null)
				{
					if (downloadingGameReplayPopup._unityWebRequestAsyncOperation.isDone)
					{
						goto IL_00af;
					}
					if (downloadingGameReplayPopup._unityWebRequestAsyncOperation != null)
					{
						float progress = downloadingGameReplayPopup._unityWebRequestAsyncOperation.progress;
						if ((object)downloadingGameReplayPopup._downloadSlider != null)
						{
							downloadingGameReplayPopup._downloadSlider.value = progress;
							object obj2 = this + 24;
							obj2 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							_ = 1;
							return true;
						}
					}
				}
				NullReferenceException ex = new NullReferenceException();
				return (byte)(int)ex != 0;
			}
			goto IL_00af;
			IL_00af:
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0042: Expected O, but got I
			object obj = typeof(MemberAchievementClanFeedData) + 2648;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			NotSupportedException ex = default(NotSupportedException);
			ex..ctor();
			object obj2 = (nint)0 + (nint)2264;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			throw new OutOfMemoryException();
		}
	}

	private PopupUI _popupUI;

	private Button _cancelButton;

	private Slider _downloadSlider;

	private UnityWebRequestAsyncOperation _unityWebRequestAsyncOperation;

	private IEnumerator _updateSliderIe;

	private void Awake()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_003d: Expected I, but got O
		Button cancelButton = _cancelButton;
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
		object obj2 = (nint)0 + (nint)3736;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction = default(UnityAction);
		unityAction..ctor(this, (IntPtr)obj2);
		cancelButton.m_OnClick.AddListener(unityAction);
	}

	private void CancelDownload()
	{
		//IL_0045: Expected I, but got O
		//IL_0055: Expected O, but got I
		//IL_0065: Expected O, but got I
		UnityWebRequestAsyncOperation unityWebRequestAsyncOperation = _unityWebRequestAsyncOperation;
		unityWebRequestAsyncOperation.<webRequest>k__BackingField.Abort();
		StopCoroutine(_updateSliderIe);
		PopupUI popupUI = _popupUI;
		nint num = (nint)popupUI;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X8_v2 (Il2CppClass<PopupUI>)+198]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X8_v2 (Il2CppClass<PopupUI>)+1A0]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v48 @ X2_v3 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}

	public void Initialize()
	{
		//IL_0022: Expected I, but got O
		//IL_0032: Expected O, but got I
		//IL_0042: Expected O, but got I
		_popupUI.Show();
		Slider downloadSlider = _downloadSlider;
		nint num = (nint)downloadSlider;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v3 (Il2CppClass<UnityEngine.UI.Slider>)+428]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v3 (Il2CppClass<UnityEngine.UI.Slider>)+430]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v44 @ X2_v1 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}

	public void Initialize(UnityWebRequestAsyncOperation unityWebRequestAsyncOperation)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Expected O, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		object obj = this + 56;
		obj = unityWebRequestAsyncOperation;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj2 = typeof(DebugUI.BitField) + 984;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj3 = default(object);
		obj3..ctor();
		_ = 0;
		object obj4 = obj3 + 32;
		obj4 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj5 = this + 64;
		obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Coroutine coroutine = StartCoroutine((IEnumerator)obj5);
	}

	private void StartUpdateSlider()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Expected O, but got Unknown
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		object obj = typeof(DebugUI.BitField) + 984;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		_ = 0;
		object obj3 = obj2 + 32;
		obj3 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj4 = this + 64;
		obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Coroutine coroutine = StartCoroutine((IEnumerator)obj4);
	}

	private IEnumerator UpdateSliderIe()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected O, but got Unknown
		object obj = typeof(DebugUI.BitField) + 984;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		_ = 0;
		object obj3 = obj2 + 32;
		obj3 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		return (IEnumerator)obj2;
	}
}
