using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Linq;
using Cpp2ILInjected;
using Features.GameReplay;
using HuaweiMobileServices.Location.Location;
using Mono.Btls;
using TMPro;
using Unity.Properties;
using UnityEngine;
using UnityEngine.UI;

public class PredictAndWinTweetPreview : MonoBehaviour
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Func<string, string> <>9__18_0;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 3096;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal string <GenerateTweetText>b__18_0(string hash)
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Expected O, but got Unknown
			object obj = " SDK from working.  If you would like to change it's implementation please override StartVivoxUnity method in " + 2912;
			string text = default(string);
			return (string)obj + text;
		}
	}

	private const string KammelnaMention = "@Kammelna";

	private PredictAndWinEventsChannel eventsChannel;

	private RawImage tweetPreview;

	private TextMeshProUGUI tweetText;

	private InputFieldTMProUGUI customTweet;

	private TweeterCharactersCounter counter;

	private UserMatchPredictionModel _userMatchPredictionModel;

	private PredictAndWinScreenshot _screenshotManager;

	private string[] _hashes;

	private void Start()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Expected O, but got Unknown
		//IL_0145: Expected O, but got I
		//IL_015d: Expected I, but got O
		//IL_0187: Expected O, but got I4
		//IL_006e: Expected I, but got O
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected O, but got Unknown
		//IL_0093: Expected O, but got I
		//IL_00bf: Expected I, but got O
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Expected O, but got Unknown
		//IL_00e4: Expected O, but got I
		//IL_0110: Expected I, but got O
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)1680;
		object obj3 = typeof(System.Buffers.Text.ParserHelpers) + 1544;
		object obj4 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3960;
		object obj5 = (nint)0 + (nint)1656;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		object obj6 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj7 = !flag;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		PredictAndWinManager.OnSendAvatarWithScreenshotChanged += action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action2 = default(Action<object>);
		action2..ctor((object)this, (IntPtr)obj5);
		object obj8 = typeof(GameReplayController.<OnEndRoundEventIe>d__138) + 3456;
		object obj9 = (nint)0 + (nint)1664;
		eventsChannel.OnPredictionSubmitted += action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		InputField.OnValidateInput onValidateInput = default(InputField.OnValidateInput);
		onValidateInput..ctor(this, (IntPtr)obj9);
		object obj10 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3576;
		object obj11 = (nint)0 + (nint)1672;
		customTweet.OnValidateInput += onValidateInput;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action3 = default(Action<object>);
		action3..ctor((object)this, (IntPtr)obj11);
		customTweet.OnValueChanged += action3;
	}

	private void OnDestroy()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Expected O, but got Unknown
		//IL_00a3: Expected O, but got I
		//IL_00bb: Expected I, but got O
		//IL_00e5: Expected O, but got I4
		//IL_006e: Expected I, but got O
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)1680;
		object obj3 = typeof(System.Buffers.Text.ParserHelpers) + 1544;
		object obj4 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3960;
		object obj5 = (nint)0 + (nint)1656;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		object obj6 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj7 = !flag;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		PredictAndWinManager.OnSendAvatarWithScreenshotChanged -= action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action2 = default(Action<object>);
		action2..ctor((object)this, (IntPtr)obj5);
		eventsChannel.OnPredictionSubmitted -= action2;
	}

	private char OnValidateInput(string text, int charindex, char addedchar)
	{
		if (addedchar == '#')
		{
			return '\0';
		}
		return addedchar;
	}

	private void OnValueChanged(string text)
	{
		string text2 = GenerateTweetText();
		counter.UpdateCount(text2._stringLength);
	}

	public void Open(UserMatchPredictionModel userMatchPredictionModel, PredictAndWinScreenshot screenshot)
	{
		//IL_02e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e7: Expected O, but got Unknown
		//IL_02ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0304: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Expected O, but got Unknown
		//IL_012f: Expected O, but got I
		//IL_01e8: Expected O, but got I4
		//IL_01f8: Expected O, but got I
		//IL_0208: Expected O, but got I
		//IL_027d: Expected O, but got I
		object obj = this + 72;
		obj = userMatchPredictionModel;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj2 = this + 80;
		obj2 = screenshot;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		if (userMatchPredictionModel != null)
		{
			MatchPredictionModel <predictionMatch>k__BackingField = userMatchPredictionModel.<predictionMatch>k__BackingField;
			if (userMatchPredictionModel.<predictionMatch>k__BackingField != null)
			{
				object obj3 = typeof(TypeConverter<ushort, char>) + 1952;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
				char[] array = default(char[]);
				if (array != null)
				{
					array[0] = ',';
					array[1] = '،';
					if (<predictionMatch>k__BackingField.<twitterHashtags>k__BackingField != null)
					{
						string[] array2 = <predictionMatch>k__BackingField.<twitterHashtags>k__BackingField.Split(array);
						object obj4 = this + 88;
						obj4 = array2;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X21_v6-8]");
						if ((nint)0 != 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X21_v6-8]");
							((PredictAndWinScreenshot)0).Init(userMatchPredictionModel, null);
							PredictAndWinScreenshot screenshotManager = _screenshotManager;
							if ((object)_screenshotManager != null && (object)screenshotManager.screenshotCamera != null)
							{
								RenderTexture previewTexture = screenshotManager.screenshotCamera.previewTexture;
								if ((object)tweetPreview != null)
								{
									tweetPreview.texture = previewTexture;
									if ((object)customTweet != null)
									{
										object obj5 = 153100288 + 1024;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X8_v10+90]");
										object obj6 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v190 @ X8_v11+B8]");
										object text = 0;
										customTweet.Text = (string)text;
										string text2 = GenerateTweetText();
										TextMeshProExtensions.FixArabic(tweetText, text2);
										if (text2 != null && (object)counter != null)
										{
											object obj7 = (nint)0 + (nint)4008;
											counter.UpdateUserLimit(text2._stringLength);
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
											PopupUI popupUI = default(PopupUI);
											if ((object)popupUI != null)
											{
												popupUI.PopFromCenter();
												return;
											}
										}
									}
								}
							}
						}
					}
				}
			}
		}
		NullReferenceException ex = new NullReferenceException();
		throw new IndexOutOfRangeException();
	}

	public void Close()
	{
		//IL_000c: Expected O, but got I
		object obj = (nint)0 + (nint)4008;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
		PopupUI popupUI = default(PopupUI);
		popupUI.ShrinkToParent();
	}

	private void ToggleUserAvatar()
	{
		_screenshotManager.UpdateUserAvatar();
		PredictAndWinScreenshot screenshotManager = _screenshotManager;
		RenderTexture previewTexture = screenshotManager.screenshotCamera.previewTexture;
		tweetPreview.texture = previewTexture;
	}

	public void OnTweetButtonClicked()
	{
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Expected O, but got Unknown
		string text = customTweet.Text;
		string text2 = text.Trim();
		if (text2._stringLength > 4)
		{
			string text3 = GenerateTweetText();
			eventsChannel.TriggerSubmitPrediction(text3, _userMatchPredictionModel);
			return;
		}
		RectTransform rect = UIExtensions.rectTransform(customTweet);
		object obj = typeof(SqlSingle[]) + 3912;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X8_v7+E4]");
		if ((nint)0 != 0)
		{
			AnimationExtensions.ErrorFeedback(rect);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		AnimationExtensions.ErrorFeedback(rect);
	}

	private void OnPredictionSubmitted(UserMatchPredictionModel model)
	{
		//IL_006b: Expected O, but got I4
		//IL_007b: Expected O, but got I
		//IL_008b: Expected O, but got I
		//IL_00a6: Expected O, but got I
		MatchPredictionModel <predictionMatch>k__BackingField = model.<predictionMatch>k__BackingField;
		UserMatchPredictionModel userMatchPredictionModel = _userMatchPredictionModel;
		MatchPredictionModel <predictionMatch>k__BackingField2 = userMatchPredictionModel.<predictionMatch>k__BackingField;
		if (<predictionMatch>k__BackingField.<id>k__BackingField == <predictionMatch>k__BackingField2.<id>k__BackingField)
		{
			object obj = 153100288 + 1024;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X8_v5+90]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X8_v6+B8]");
			object text = 0;
			customTweet.Text = (string)text;
			object obj3 = (nint)0 + (nint)4008;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
			PopupUI popupUI = default(PopupUI);
			popupUI.ShrinkToParent();
		}
	}

	private string GenerateTweetText()
	{
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected O, but got Unknown
		//IL_0051: Expected O, but got I
		//IL_005d: Expected O, but got I
		//IL_0094: Expected O, but got I4
		//IL_0191: Expected O, but got I
		//IL_01a1: Expected O, but got I
		//IL_01c3: Expected O, but got I4
		//IL_00db: Expected O, but got I4
		//IL_01e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e5: Expected O, but got Unknown
		//IL_01fb: Expected O, but got I
		//IL_020c: Expected I, but got O
		//IL_022a: Expected O, but got I
		//IL_010b: Expected O, but got I
		if ((object)customTweet != null)
		{
			string text = customTweet.Text;
			if (text != null)
			{
				object obj = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 3096;
				object separator = (nint)0 + (nint)3072;
				object obj2 = (nint)0 + (nint)2520;
				string text2 = text.Trim();
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X0_v8+E4]");
				bool flag = (nint)0 == 0;
				object obj4 = !flag;
				if (obj4 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj3 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X0_v8+B8]");
				object obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X8_v6+8]");
				Func<object, object> selector = (Func<object, object>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X8_v6+8]");
				bool flag2 = (nint)0 == 0;
				object obj6 = !flag2;
				if (obj6 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X0_v8+E4]");
					bool flag3 = (nint)0 == 0;
					object obj7 = !flag3;
					if (obj7 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						object obj8 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ X8_v12+B8]");
						obj5 = 0;
					}
					object obj9 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3640;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					object obj10 = (nint)0 + (nint)1704;
					Func<object, object> func = default(Func<object, object>);
					func..ctor(obj5, (IntPtr)obj10);
					object obj11 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ X8_v11+B8]");
					object obj12 = (nint)0 + (nint)8;
					obj12 = func;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					selector = func;
				}
				IEnumerable<object> values = Enumerable.Select(_hashes, selector);
				string text3 = string.Join((string)separator, (IEnumerable<string>)values);
				return text2 + (string)obj2 + text3;
			}
		}
		return (string)(object)new NullReferenceException();
	}
}
