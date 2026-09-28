using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Formats.Asn1;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using Mono.Btls;
using Newtonsoft.Json.Linq.JsonPath;
using Unity.Services.Authentication.Shared;
using UnityEngine;
using UnityEngine.Device;
using UnityEngine.InputSystem.XR;
using UnityEngine.Purchasing.Telemetry;

public class KMediaPicker : Singleton<KMediaPicker>
{
	private enum MediaType
	{
		Gallery,
		Camera
	}

	private sealed class <WebcamShotRoutine>d__28 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state;

		private object <>2__current;

		public MediaType mediaType;

		private float <requestTime>5__2;

		private WebCamTexture <cameraTexture>5__3;

		object IEnumerator<object>.Current => <>2__current;

		object IEnumerator.Current => <>2__current;

		public <WebcamShotRoutine>d__28(int <>1__state)
		{
			this.<>1__state = <>1__state;
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0178: Expected I4, but got I8
			//IL_03a8: Unknown result type (might be due to invalid IL or missing references)
			//IL_03ad: Expected O, but got Unknown
			//IL_0383: Expected I4, but got O
			//IL_00ad: Expected I4, but got I8
			//IL_00cf: Expected O, but got I4
			//IL_01a4: Expected O, but got I4
			//IL_02f6: Unknown result type (might be due to invalid IL or missing references)
			//IL_02fb: Expected O, but got Unknown
			//IL_0325: Expected O, but got I4
			//IL_0040: Expected O, but got I4
			//IL_0357: Unknown result type (might be due to invalid IL or missing references)
			//IL_035c: Expected O, but got Unknown
			//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
			//IL_0104: Expected O, but got Unknown
			//IL_0122: Unknown result type (might be due to invalid IL or missing references)
			//IL_0127: Expected O, but got Unknown
			//IL_005d: Expected I4, but got I8
			//IL_0071: Unknown result type (might be due to invalid IL or missing references)
			//IL_0076: Expected O, but got Unknown
			//IL_02cf: Expected O, but got I4
			//IL_02e2: Expected O, but got I4
			//IL_01f6: Unknown result type (might be due to invalid IL or missing references)
			//IL_01fb: Expected O, but got Unknown
			//IL_0204: Expected O, but got I4
			//IL_026c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0271: Expected O, but got Unknown
			//IL_029b: Expected O, but got I4
			//IL_03da: Expected O, but got I
			//IL_03f0: Expected O, but got I
			if (<>1__state != 2)
			{
				if (<>1__state != 1)
				{
					bool flag = <>1__state == 0;
					object obj = !flag;
					if (obj == null)
					{
						<>1__state = -1;
						AsyncOperation asyncOperation = UnityEngine.Device.Application.RequestUserAuthorization(UserAuthorization.WebCam);
						object obj2 = this + 24;
						obj2 = asyncOperation;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						<>1__state = 1;
						return true;
					}
					goto IL_02c0;
				}
				<>1__state = -1;
				bool flag2 = UnityEngine.Device.Application.HasUserAuthorization(UserAuthorization.WebCam);
				bool flag3 = !flag2;
				object obj3 = 0;
				if (flag3)
				{
					goto IL_02e7;
				}
				float time = Time.time;
				<requestTime>5__2 = time;
				object obj4 = typeof(UsageHint) + 1736;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				WebCamTexture webCamTexture = default(WebCamTexture);
				webCamTexture..ctor();
				object obj5 = this + 40;
				obj5 = webCamTexture;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				if (obj5 == null)
				{
					goto IL_0375;
				}
				((WebCamTexture)obj5).Play();
			}
			else
			{
				<>1__state = -1;
			}
			object obj6 = this + 40;
			if (obj6 != null)
			{
				bool didUpdateThisFrame = ((WebCamTexture)obj6).didUpdateThisFrame;
				bool flag4 = !didUpdateThisFrame;
				object obj7 = !flag4;
				if (obj7 == null)
				{
					float time2 = Time.time;
					float time = time2 - <requestTime>5__2;
					if ((double)time < 10.0)
					{
						object obj8 = this + 24;
						obj8 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						_ = 2;
						return true;
					}
				}
				if (obj6 != null)
				{
					if (((WebCamTexture)obj6).didUpdateThisFrame)
					{
						object obj9 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1152;
						object obj10 = obj9;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v296 @ X0_v11+E4]");
						bool flag5 = (nint)0 == 0;
						object obj11 = !flag5;
						if (obj11 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							obj10 = obj9;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v296 @ X0_v11+B8]");
						object obj12 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v298 @ X8_v6+10]");
						Actions.SafeInvoke((Action<object>)0, obj6);
						goto IL_02c0;
					}
					obj6 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					object obj3 = 0;
					goto IL_02e7;
				}
			}
			goto IL_0375;
			IL_0375:
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
			IL_02c0:
			return false;
			IL_02e7:
			object obj13 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1152;
			object obj14 = obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ X0_v22+E4]");
			bool flag6 = (nint)0 == 0;
			object obj15 = !flag6;
			if (obj15 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			FailCallback(mediaType);
			object permissionMessage = "COORDINATE_TYPE_GCJ_02" + 2016;
			ShowPermissionError((string)permissionMessage, canOpenSettings: false);
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
			object obj2 = (nint)0 + (nint)3128;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			throw new OutOfMemoryException();
		}
	}

	private const string ChoosePictureMessage = "Choose a picture";

	private const string GalleryPermissionMessage = "Cannot access the gallery, please grant permission from settings.";

	private const string CameraPermissionMessage = "Cannot access the camera, please grant permission from settings.";

	public static event Action<Texture2D> OnSelectFromNativeGallery
	{
		add
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_01fb: Expected O, but got I4
			//IL_0218: Unknown result type (might be due to invalid IL or missing references)
			//IL_021d: Expected O, but got Unknown
			//IL_022d: Expected O, but got I
			//IL_015a: Expected O, but got I4
			//IL_0163: Expected O, but got I4
			//IL_016c: Expected O, but got I4
			//IL_00e5: Expected O, but got I4
			object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1152;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			object obj4 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3688;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v3+B8]");
			object obj5 = 0;
			Delegate obj6 = (Delegate)obj5;
			Delegate obj8 = default(Delegate);
			object obj9 = default(object);
			Delegate obj13 = default(Delegate);
			Delegate obj20 = default(Delegate);
			while (true)
			{
				Delegate obj7 = Delegate.Combine(obj6, value);
				object obj14;
				Delegate obj15;
				Delegate obj16;
				object obj10;
				object obj12;
				if ((object)obj7 != null)
				{
					obj8 = (Delegate)obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					if (obj9 == null)
					{
						break;
					}
					obj10 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v15+E4]");
					bool flag2 = (nint)0 == 0;
					object obj11 = !flag2;
					obj12 = obj9;
					obj13 = obj7;
					if (obj11 != null)
					{
						goto IL_0030;
					}
					obj14 = obj9;
					obj15 = obj7;
					obj16 = (Delegate)obj4;
					Delegate obj17 = (Delegate)obj4;
					object obj18 = obj10;
				}
				else
				{
					obj10 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v15+E4]");
					bool flag3 = (nint)0 == 0;
					object obj19 = !flag3;
					obj12 = 0;
					obj14 = 0;
					obj15 = obj13;
					obj16 = obj8;
					Delegate obj17 = value;
					object obj18 = obj10;
					if (obj19 != null)
					{
						goto IL_0030;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj10 = obj;
				obj12 = obj14;
				obj13 = obj15;
				obj8 = obj16;
				goto IL_0030;
				IL_0030:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				bool flag4 = (object)obj20 == obj6;
				obj6 = obj20;
				if (!flag4)
				{
					continue;
				}
				return;
			}
			throw new InvalidCastException();
		}
		remove
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_01fb: Expected O, but got I4
			//IL_0218: Unknown result type (might be due to invalid IL or missing references)
			//IL_021d: Expected O, but got Unknown
			//IL_022d: Expected O, but got I
			//IL_015a: Expected O, but got I4
			//IL_0163: Expected O, but got I4
			//IL_016c: Expected O, but got I4
			//IL_00e5: Expected O, but got I4
			object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1152;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			object obj4 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3688;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v3+B8]");
			object obj5 = 0;
			Delegate obj6 = (Delegate)obj5;
			Delegate obj8 = default(Delegate);
			object obj9 = default(object);
			Delegate obj13 = default(Delegate);
			Delegate obj20 = default(Delegate);
			while (true)
			{
				Delegate obj7 = Delegate.Remove(obj6, value);
				object obj14;
				Delegate obj15;
				Delegate obj16;
				object obj10;
				object obj12;
				if ((object)obj7 != null)
				{
					obj8 = (Delegate)obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					if (obj9 == null)
					{
						break;
					}
					obj10 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v15+E4]");
					bool flag2 = (nint)0 == 0;
					object obj11 = !flag2;
					obj12 = obj9;
					obj13 = obj7;
					if (obj11 != null)
					{
						goto IL_0030;
					}
					obj14 = obj9;
					obj15 = obj7;
					obj16 = (Delegate)obj4;
					Delegate obj17 = (Delegate)obj4;
					object obj18 = obj10;
				}
				else
				{
					obj10 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v15+E4]");
					bool flag3 = (nint)0 == 0;
					object obj19 = !flag3;
					obj12 = 0;
					obj14 = 0;
					obj15 = obj13;
					obj16 = obj8;
					Delegate obj17 = value;
					object obj18 = obj10;
					if (obj19 != null)
					{
						goto IL_0030;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj10 = obj;
				obj12 = obj14;
				obj13 = obj15;
				obj8 = obj16;
				goto IL_0030;
				IL_0030:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				bool flag4 = (object)obj20 == obj6;
				obj6 = obj20;
				if (!flag4)
				{
					continue;
				}
				return;
			}
			throw new InvalidCastException();
		}
	}

	public static event Action<Texture2D> OnSelectFromNativeCamera
	{
		add
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0211: Expected O, but got I4
			//IL_022e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0233: Expected O, but got Unknown
			//IL_0243: Expected O, but got I
			//IL_0253: Expected O, but got I
			//IL_0170: Expected O, but got I4
			//IL_0179: Expected O, but got I4
			//IL_0182: Expected O, but got I4
			//IL_0046: Expected O, but got I
			//IL_00fb: Expected O, but got I4
			object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1152;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			object obj4 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3688;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v3+B8]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X8_v4+8]");
			Delegate obj6 = (Delegate)0;
			Delegate obj8 = default(Delegate);
			object obj9 = default(object);
			Delegate obj13 = default(Delegate);
			Delegate obj21 = default(Delegate);
			while (true)
			{
				Delegate obj7 = Delegate.Combine(obj6, value);
				object obj14;
				Delegate obj15;
				Delegate obj16;
				object obj10;
				object obj12;
				if ((object)obj7 != null)
				{
					obj8 = (Delegate)obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					if (obj9 == null)
					{
						break;
					}
					obj10 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v15+E4]");
					bool flag2 = (nint)0 == 0;
					object obj11 = !flag2;
					obj12 = obj9;
					obj13 = obj7;
					if (obj11 != null)
					{
						goto IL_0030;
					}
					obj14 = obj9;
					obj15 = obj7;
					obj16 = (Delegate)obj4;
					Delegate obj17 = (Delegate)obj4;
					object obj18 = obj10;
				}
				else
				{
					obj10 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v15+E4]");
					bool flag3 = (nint)0 == 0;
					object obj19 = !flag3;
					obj12 = 0;
					obj14 = 0;
					obj15 = obj13;
					obj16 = obj8;
					Delegate obj17 = value;
					object obj18 = obj10;
					if (obj19 != null)
					{
						goto IL_0030;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj10 = obj;
				obj12 = obj14;
				obj13 = obj15;
				obj8 = obj16;
				goto IL_0030;
				IL_0030:
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v15+B8]");
				object obj20 = (nint)0 + (nint)8;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				bool flag4 = (object)obj21 == obj6;
				obj6 = obj21;
				if (!flag4)
				{
					continue;
				}
				return;
			}
			throw new InvalidCastException();
		}
		remove
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0211: Expected O, but got I4
			//IL_022e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0233: Expected O, but got Unknown
			//IL_0243: Expected O, but got I
			//IL_0253: Expected O, but got I
			//IL_0170: Expected O, but got I4
			//IL_0179: Expected O, but got I4
			//IL_0182: Expected O, but got I4
			//IL_0046: Expected O, but got I
			//IL_00fb: Expected O, but got I4
			object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1152;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			object obj4 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3688;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v3+B8]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X8_v4+8]");
			Delegate obj6 = (Delegate)0;
			Delegate obj8 = default(Delegate);
			object obj9 = default(object);
			Delegate obj13 = default(Delegate);
			Delegate obj21 = default(Delegate);
			while (true)
			{
				Delegate obj7 = Delegate.Remove(obj6, value);
				object obj14;
				Delegate obj15;
				Delegate obj16;
				object obj10;
				object obj12;
				if ((object)obj7 != null)
				{
					obj8 = (Delegate)obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					if (obj9 == null)
					{
						break;
					}
					obj10 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v15+E4]");
					bool flag2 = (nint)0 == 0;
					object obj11 = !flag2;
					obj12 = obj9;
					obj13 = obj7;
					if (obj11 != null)
					{
						goto IL_0030;
					}
					obj14 = obj9;
					obj15 = obj7;
					obj16 = (Delegate)obj4;
					Delegate obj17 = (Delegate)obj4;
					object obj18 = obj10;
				}
				else
				{
					obj10 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v15+E4]");
					bool flag3 = (nint)0 == 0;
					object obj19 = !flag3;
					obj12 = 0;
					obj14 = 0;
					obj15 = obj13;
					obj16 = obj8;
					Delegate obj17 = value;
					object obj18 = obj10;
					if (obj19 != null)
					{
						goto IL_0030;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj10 = obj;
				obj12 = obj14;
				obj13 = obj15;
				obj8 = obj16;
				goto IL_0030;
				IL_0030:
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v15+B8]");
				object obj20 = (nint)0 + (nint)8;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				bool flag4 = (object)obj21 == obj6;
				obj6 = obj21;
				if (!flag4)
				{
					continue;
				}
				return;
			}
			throw new InvalidCastException();
		}
	}

	public static event Action<WebCamTexture> OnWebCamFeedReady
	{
		add
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0211: Expected O, but got I4
			//IL_022e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0233: Expected O, but got Unknown
			//IL_0243: Expected O, but got I
			//IL_0253: Expected O, but got I
			//IL_0170: Expected O, but got I4
			//IL_0179: Expected O, but got I4
			//IL_0182: Expected O, but got I4
			//IL_0046: Expected O, but got I
			//IL_00fb: Expected O, but got I4
			object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1152;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			object obj4 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 4032;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v3+B8]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X8_v4+10]");
			Delegate obj6 = (Delegate)0;
			Delegate obj8 = default(Delegate);
			object obj9 = default(object);
			Delegate obj13 = default(Delegate);
			Delegate obj21 = default(Delegate);
			while (true)
			{
				Delegate obj7 = Delegate.Combine(obj6, value);
				object obj14;
				Delegate obj15;
				Delegate obj16;
				object obj10;
				object obj12;
				if ((object)obj7 != null)
				{
					obj8 = (Delegate)obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					if (obj9 == null)
					{
						break;
					}
					obj10 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v15+E4]");
					bool flag2 = (nint)0 == 0;
					object obj11 = !flag2;
					obj12 = obj9;
					obj13 = obj7;
					if (obj11 != null)
					{
						goto IL_0030;
					}
					obj14 = obj9;
					obj15 = obj7;
					obj16 = (Delegate)obj4;
					Delegate obj17 = (Delegate)obj4;
					object obj18 = obj10;
				}
				else
				{
					obj10 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v15+E4]");
					bool flag3 = (nint)0 == 0;
					object obj19 = !flag3;
					obj12 = 0;
					obj14 = 0;
					obj15 = obj13;
					obj16 = obj8;
					Delegate obj17 = value;
					object obj18 = obj10;
					if (obj19 != null)
					{
						goto IL_0030;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj10 = obj;
				obj12 = obj14;
				obj13 = obj15;
				obj8 = obj16;
				goto IL_0030;
				IL_0030:
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v15+B8]");
				object obj20 = (nint)0 + (nint)16;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				bool flag4 = (object)obj21 == obj6;
				obj6 = obj21;
				if (!flag4)
				{
					continue;
				}
				return;
			}
			throw new InvalidCastException();
		}
		remove
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0211: Expected O, but got I4
			//IL_022e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0233: Expected O, but got Unknown
			//IL_0243: Expected O, but got I
			//IL_0253: Expected O, but got I
			//IL_0170: Expected O, but got I4
			//IL_0179: Expected O, but got I4
			//IL_0182: Expected O, but got I4
			//IL_0046: Expected O, but got I
			//IL_00fb: Expected O, but got I4
			object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1152;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			object obj4 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 4032;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v3+B8]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X8_v4+10]");
			Delegate obj6 = (Delegate)0;
			Delegate obj8 = default(Delegate);
			object obj9 = default(object);
			Delegate obj13 = default(Delegate);
			Delegate obj21 = default(Delegate);
			while (true)
			{
				Delegate obj7 = Delegate.Remove(obj6, value);
				object obj14;
				Delegate obj15;
				Delegate obj16;
				object obj10;
				object obj12;
				if ((object)obj7 != null)
				{
					obj8 = (Delegate)obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					if (obj9 == null)
					{
						break;
					}
					obj10 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v15+E4]");
					bool flag2 = (nint)0 == 0;
					object obj11 = !flag2;
					obj12 = obj9;
					obj13 = obj7;
					if (obj11 != null)
					{
						goto IL_0030;
					}
					obj14 = obj9;
					obj15 = obj7;
					obj16 = (Delegate)obj4;
					Delegate obj17 = (Delegate)obj4;
					object obj18 = obj10;
				}
				else
				{
					obj10 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v15+E4]");
					bool flag3 = (nint)0 == 0;
					object obj19 = !flag3;
					obj12 = 0;
					obj14 = 0;
					obj15 = obj13;
					obj16 = obj8;
					Delegate obj17 = value;
					object obj18 = obj10;
					if (obj19 != null)
					{
						goto IL_0030;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj10 = obj;
				obj12 = obj14;
				obj13 = obj15;
				obj8 = obj16;
				goto IL_0030;
				IL_0030:
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v15+B8]");
				object obj20 = (nint)0 + (nint)16;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				bool flag4 = (object)obj21 == obj6;
				obj6 = obj21;
				if (!flag4)
				{
					continue;
				}
				return;
			}
			throw new InvalidCastException();
		}
	}

	static KMediaPicker()
	{
		Initialize();
	}

	private static void Initialize()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0100: Expected O, but got I
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Expected O, but got Unknown
		//IL_0120: Expected O, but got I
		//IL_012c: Expected O, but got I
		//IL_0144: Expected I, but got O
		//IL_016e: Expected O, but got I4
		//IL_006e: Expected I, but got O
		//IL_0094: Expected I, but got O
		//IL_00bf: Expected I, but got O
		//IL_00e5: Expected I, but got O
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3576;
		object obj2 = (nint)0 + (nint)3352;
		object obj3 = typeof(SqlSingle[]) + 3560;
		object obj4 = (nint)0 + (nint)3336;
		object obj5 = typeof(SqlSingle[]) + 2376;
		object obj6 = (nint)0 + (nint)3360;
		object obj7 = (nint)0 + (nint)3344;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)null, (IntPtr)obj2);
		object obj8 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj9 = !flag;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		AndroidInterface.OnGalleryPickDone += action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action2 = default(Action<object>);
		action2..ctor((object)null, (IntPtr)obj4);
		AndroidInterface.OnCameraTakeDone += action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action3 = default(Action);
		action3..ctor(null, (IntPtr)obj6);
		AndroidInterface.OnGalleryCancel += action3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action4 = default(Action);
		action4..ctor(null, (IntPtr)obj7);
		AndroidInterface.OnCameraCancel += action4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action5 = default(Action);
		action5..ctor(null, (IntPtr)obj7);
		AndroidInterface.OnCameraPermissionDenied += action5;
	}

	public static void OpenCamera()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_03bc: Expected O, but got I4
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_0090: Expected O, but got I
		//IL_00ba: Expected O, but got I4
		//IL_0330: Unknown result type (might be due to invalid IL or missing references)
		//IL_0335: Expected O, but got Unknown
		//IL_00ef: Expected O, but got I4
		//IL_0105: Expected O, but got I
		//IL_027a: Expected O, but got I4
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Expected O, but got Unknown
		//IL_0179: Expected O, but got I
		//IL_0193: Expected O, but got I4
		//IL_02a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a6: Expected O, but got Unknown
		//IL_02bc: Expected O, but got I
		object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1168;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj4 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1152;
		Platform platform = KUtil.GetPlatform();
		if (!UnityEngine.Device.Application.isEditor)
		{
			switch (platform)
			{
			case Platform.Web:
				break;
			case Platform.IOS:
			{
				object obj7 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ X0_v12+E4]");
				if ((nint)0 != 0)
				{
					TakePhotoFromCamera();
					return;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				TakePhotoFromCamera();
				return;
			}
			default:
				return;
			case Platform.Android:
			case Platform.Huawei:
			{
				object obj5 = typeof(SqlSingle[]) + 3560;
				object obj6 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ X0_v8+E4]");
				if ((nint)0 != 0)
				{
					AndroidInterface.TakePhotoFromCamera();
					return;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				AndroidInterface.TakePhotoFromCamera();
				return;
			}
			}
		}
		object obj8 = typeof(Queue<string>) + 776;
		object obj9 = (nint)0 + (nint)2072;
		object obj10 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X0_v14+E4]");
		bool flag2 = (nint)0 == 0;
		object obj11 = !flag2;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		object obj12 = 152989696;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7636]");
		object obj13 = (nint)0 & (nint)1;
		if (obj13 != null)
		{
			object obj14 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v268 @ X0_v24+E4]");
			if ((nint)0 != 0)
			{
				goto IL_014f;
			}
		}
		else
		{
			_ = 1;
			object obj14 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v268 @ X0_v24+E4]");
			bool flag3 = (nint)0 == 0;
			object obj15 = !flag3;
			if (obj15 != null)
			{
				goto IL_014f;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj16 = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 1232;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7637]");
		object obj17 = (nint)0 & (nint)1;
		if (obj17 == null)
		{
			goto IL_01a9;
		}
		object obj18 = obj16;
		goto IL_03ca;
		IL_014f:
		obj16 = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 1232;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7637]");
		object obj19 = (nint)0 & (nint)1;
		bool flag4 = obj19 == null;
		object obj20 = !flag4;
		obj18 = obj16;
		if (obj20 == null)
		{
			goto IL_01a9;
		}
		goto IL_03ca;
		IL_03ca:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj21 = default(object);
		obj21..ctor();
		_ = 0;
		_ = 1;
		MonoBehaviour monoBehaviour = default(MonoBehaviour);
		Coroutine coroutine = monoBehaviour.StartCoroutine((IEnumerator)obj21);
		return;
		IL_01a9:
		_ = 1;
		obj18 = obj16;
		goto IL_03ca;
	}

	public static void PickFromGallery()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d1: Expected O, but got Unknown
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected O, but got Unknown
		//IL_0185: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Expected O, but got Unknown
		if (UnityEngine.Device.Application.isEditor)
		{
			return;
		}
		object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1168;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X0_v4+E4]");
		Platform platform;
		Platform platform2;
		if ((nint)0 != 0)
		{
			platform = KUtil.GetPlatform();
			bool flag = platform > Platform.IOS;
			platform2 = platform;
			if (!flag)
			{
				goto IL_0075;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			platform = KUtil.GetPlatform();
			bool flag2 = platform <= Platform.IOS;
			platform2 = platform;
			if (flag2)
			{
				goto IL_0075;
			}
		}
		switch (platform2)
		{
		default:
			return;
		case Platform.Web:
		{
			object obj3 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1152;
			object obj4 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X0_v11+E4]");
			if ((nint)0 != 0)
			{
				FileChooser();
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			FileChooser();
			return;
		}
		case Platform.Huawei:
			break;
		}
		goto IL_01bd;
		IL_0075:
		switch (platform)
		{
		default:
			return;
		case Platform.IOS:
		{
			object obj5 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1152;
			object obj6 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v17+E4]");
			if ((nint)0 != 0)
			{
				PickPhotoFromGallery();
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			PickPhotoFromGallery();
			return;
		}
		case Platform.Android:
			break;
		}
		goto IL_01bd;
		IL_01bd:
		object obj7 = typeof(SqlSingle[]) + 3560;
		object obj8 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v233 @ X0_v6+E4]");
		if ((nint)0 != 0)
		{
			AndroidInterface.PickPhotoFromGallery();
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		AndroidInterface.PickPhotoFromGallery();
	}

	private static void OnGalleryPick(string path)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_01d6: Expected O, but got I4
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Expected O, but got Unknown
		//IL_00b6: Expected O, but got I4
		//IL_026e: Expected I4, but got I8
		//IL_01fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0202: Expected O, but got Unknown
		//IL_045d: Expected O, but got I
		//IL_0477: Expected O, but got I4
		//IL_022e: Expected O, but got I4
		//IL_0237: Expected O, but got I4
		//IL_02b5: Expected O, but got I
		//IL_037e: Expected O, but got I
		//IL_0398: Expected O, but got I4
		//IL_04ed: Expected O, but got I
		//IL_050d: Expected O, but got I4
		//IL_04b5: Expected O, but got I4
		//IL_010f: Expected O, but got I
		//IL_0317: Expected O, but got I
		//IL_0339: Expected O, but got I4
		//IL_0342: Expected O, but got I4
		//IL_040e: Expected O, but got I
		//IL_03d6: Expected O, but got I4
		//IL_0534: Expected O, but got I
		//IL_0544: Expected O, but got I
		//IL_0554: Expected O, but got I
		//IL_0171: Expected O, but got I
		//IL_0193: Expected O, but got I4
		object obj = 152989696;
		object obj2 = typeof(System.Formats.Asn1.SetOfValueComparer) + 2536;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E762D]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v20+E4]");
			if ((nint)0 != 0)
			{
				goto IL_007d;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v20+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 != null)
			{
				goto IL_007d;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj6 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1152;
		bool flag2 = StringsExtensions.IsNullOrEmpty(path);
		bool flag3 = !flag2;
		object obj7 = !flag3;
		object obj8 = 0;
		object obj9 = obj6;
		if (obj7 != null)
		{
			goto IL_00cc;
		}
		goto IL_024d;
		IL_012c:
		object obj10 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X0_v43+E4]");
		bool flag4 = (nint)0 == 0;
		object obj11 = obj10;
		if (!flag4)
		{
			goto IL_0161;
		}
		goto IL_03ec;
		IL_03ec:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj12 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ X0_v36+B8]");
		object obj13 = 0;
		object obj14 = obj13;
		if (obj13 != null)
		{
			goto IL_0433;
		}
		return;
		IL_00cc:
		object obj15 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X0_v32+E4]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7631]");
			object obj16 = (nint)0 & (nint)1;
			if (obj16 != null)
			{
				goto IL_012c;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7631]");
			object obj17 = (nint)0 & (nint)1;
			bool flag5 = obj17 == null;
			object obj18 = !flag5;
			if (obj18 != null)
			{
				goto IL_012c;
			}
		}
		_ = 1;
		obj10 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X0_v43+E4]");
		bool flag6 = (nint)0 == 0;
		object obj19 = !flag6;
		obj11 = obj10;
		if (obj19 != null)
		{
			goto IL_0161;
		}
		goto IL_03ec;
		IL_007d:
		obj6 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1152;
		bool flag7 = StringsExtensions.IsNullOrEmpty(path);
		bool flag8 = !flag7;
		obj8 = 0;
		obj9 = obj6;
		if (!flag8)
		{
			goto IL_00cc;
		}
		goto IL_024d;
		IL_024d:
		Texture2D texture2D = NativeGallery.LoadImageAtPath(path, -1, markTextureNonReadable: false, generateMipmaps: false);
		object obj20 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X0_v7+E4]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E762F]");
			object obj21 = (nint)0 & (nint)1;
			if (obj21 != null)
			{
				goto IL_02d2;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E762F]");
			object obj22 = (nint)0 & (nint)1;
			bool flag9 = obj22 == null;
			object obj23 = !flag9;
			if (obj23 != null)
			{
				goto IL_02d2;
			}
		}
		_ = 1;
		object obj24 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ X0_v17+E4]");
		bool flag10 = (nint)0 == 0;
		object obj25 = !flag10;
		object obj26 = obj24;
		if (obj25 != null)
		{
			goto IL_0307;
		}
		goto IL_04cb;
		IL_0524:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ X8_v3+18]");
		object obj27 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ X8_v3+40]");
		object obj28 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ X8_v3+28]");
		object obj29 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v221 @ X3_v3 (should have been resolved before IL gen)");
		return;
		IL_0433:
		Texture2D texture2D2 = null;
		goto IL_0524;
		IL_0161:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X0_v43+B8]");
		object obj30 = 0;
		obj14 = obj30;
		bool flag11 = obj30 == null;
		object obj31 = !flag11;
		if (obj31 == null)
		{
			return;
		}
		goto IL_0433;
		IL_02d2:
		obj24 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ X0_v17+E4]");
		bool flag12 = (nint)0 == 0;
		obj26 = obj24;
		if (!flag12)
		{
			goto IL_0307;
		}
		goto IL_04cb;
		IL_04cb:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj32 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v196 @ X0_v10+B8]");
		object obj33 = 0;
		obj14 = obj33;
		bool flag13 = obj33 == null;
		object obj34 = 0;
		bool flag14 = false;
		if (!flag13)
		{
			goto IL_0524;
		}
		return;
		IL_0307:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ X0_v17+B8]");
		object obj35 = 0;
		obj14 = obj35;
		bool flag15 = obj35 == null;
		object obj36 = !flag15;
		obj34 = 0;
		flag14 = false;
		if (obj36 == null)
		{
			return;
		}
		goto IL_0524;
	}

	private static void OnCameraTake(string path)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_01e6: Expected O, but got I4
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Expected O, but got Unknown
		//IL_00b6: Expected O, but got I4
		//IL_027e: Expected I4, but got I8
		//IL_020d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0212: Expected O, but got Unknown
		//IL_048d: Expected O, but got I
		//IL_04a7: Expected O, but got I4
		//IL_023e: Expected O, but got I4
		//IL_0247: Expected O, but got I4
		//IL_02c5: Expected O, but got I
		//IL_039e: Expected O, but got I
		//IL_03b8: Expected O, but got I4
		//IL_051d: Expected O, but got I
		//IL_052d: Expected O, but got I
		//IL_054d: Expected O, but got I4
		//IL_04e5: Expected O, but got I4
		//IL_010f: Expected O, but got I
		//IL_0327: Expected O, but got I
		//IL_0337: Expected O, but got I
		//IL_0359: Expected O, but got I4
		//IL_0362: Expected O, but got I4
		//IL_042e: Expected O, but got I
		//IL_043e: Expected O, but got I
		//IL_03f6: Expected O, but got I4
		//IL_0574: Expected O, but got I
		//IL_0584: Expected O, but got I
		//IL_0594: Expected O, but got I
		//IL_0171: Expected O, but got I
		//IL_0181: Expected O, but got I
		//IL_01a3: Expected O, but got I4
		object obj = 152989696;
		object obj2 = typeof(System.Formats.Asn1.SetOfValueComparer) + 2536;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E762E]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v20+E4]");
			if ((nint)0 != 0)
			{
				goto IL_007d;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v20+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 != null)
			{
				goto IL_007d;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj6 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1152;
		bool flag2 = StringsExtensions.IsNullOrEmpty(path);
		bool flag3 = !flag2;
		object obj7 = !flag3;
		object obj8 = 0;
		object obj9 = obj6;
		if (obj7 != null)
		{
			goto IL_00cc;
		}
		goto IL_025d;
		IL_012c:
		object obj10 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X0_v43+E4]");
		bool flag4 = (nint)0 == 0;
		object obj11 = obj10;
		if (!flag4)
		{
			goto IL_0161;
		}
		goto IL_040c;
		IL_040c:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj12 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ X0_v36+B8]");
		object obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ X8_v26+8]");
		object obj14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ X8_v26+8]");
		if ((nint)0 != 0)
		{
			goto IL_0463;
		}
		return;
		IL_00cc:
		object obj15 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X0_v32+E4]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7632]");
			object obj16 = (nint)0 & (nint)1;
			if (obj16 != null)
			{
				goto IL_012c;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7632]");
			object obj17 = (nint)0 & (nint)1;
			bool flag5 = obj17 == null;
			object obj18 = !flag5;
			if (obj18 != null)
			{
				goto IL_012c;
			}
		}
		_ = 1;
		obj10 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X0_v43+E4]");
		bool flag6 = (nint)0 == 0;
		object obj19 = !flag6;
		obj11 = obj10;
		if (obj19 != null)
		{
			goto IL_0161;
		}
		goto IL_040c;
		IL_007d:
		obj6 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1152;
		bool flag7 = StringsExtensions.IsNullOrEmpty(path);
		bool flag8 = !flag7;
		obj8 = 0;
		obj9 = obj6;
		if (!flag8)
		{
			goto IL_00cc;
		}
		goto IL_025d;
		IL_025d:
		Texture2D texture2D = NativeCamera.LoadImageAtPath(path, -1, markTextureNonReadable: false, generateMipmaps: false);
		object obj20 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X0_v7+E4]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7630]");
			object obj21 = (nint)0 & (nint)1;
			if (obj21 != null)
			{
				goto IL_02e2;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7630]");
			object obj22 = (nint)0 & (nint)1;
			bool flag9 = obj22 == null;
			object obj23 = !flag9;
			if (obj23 != null)
			{
				goto IL_02e2;
			}
		}
		_ = 1;
		object obj24 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ X0_v17+E4]");
		bool flag10 = (nint)0 == 0;
		object obj25 = !flag10;
		object obj26 = obj24;
		if (obj25 != null)
		{
			goto IL_0317;
		}
		goto IL_04fb;
		IL_0564:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ X8_v3+18]");
		object obj27 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ X8_v3+40]");
		object obj28 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ X8_v3+28]");
		object obj29 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v221 @ X3_v3 (should have been resolved before IL gen)");
		return;
		IL_0463:
		Texture2D texture2D2 = null;
		goto IL_0564;
		IL_0161:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X0_v43+B8]");
		object obj30 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X8_v33+8]");
		obj14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X8_v33+8]");
		bool flag11 = (nint)0 == 0;
		object obj31 = !flag11;
		if (obj31 == null)
		{
			return;
		}
		goto IL_0463;
		IL_02e2:
		obj24 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ X0_v17+E4]");
		bool flag12 = (nint)0 == 0;
		obj26 = obj24;
		if (!flag12)
		{
			goto IL_0317;
		}
		goto IL_04fb;
		IL_04fb:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj32 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v196 @ X0_v10+B8]");
		object obj33 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ X8_v7+8]");
		obj14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ X8_v7+8]");
		bool flag13 = (nint)0 == 0;
		object obj34 = 0;
		bool flag14 = false;
		if (!flag13)
		{
			goto IL_0564;
		}
		return;
		IL_0317:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ X0_v17+B8]");
		object obj35 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ X8_v14+8]");
		obj14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ X8_v14+8]");
		bool flag15 = (nint)0 == 0;
		object obj36 = !flag15;
		obj34 = 0;
		flag14 = false;
		if (obj36 == null)
		{
			return;
		}
		goto IL_0564;
	}

	private static void OnGalleryPickSuccess(Texture2D texture2D)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_011b: Expected O, but got I4
		//IL_008c: Expected O, but got I
		//IL_0153: Expected O, but got I
		//IL_0175: Expected O, but got I4
		//IL_00c1: Expected O, but got I
		//IL_00d1: Expected O, but got I
		//IL_00e1: Expected O, but got I
		object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1152;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E762F]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 == null)
		{
			goto IL_00eb;
		}
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v11+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = obj3;
		if (!flag)
		{
			goto IL_007c;
		}
		goto IL_0131;
		IL_0131:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v4+B8]");
		object obj6 = 0;
		object obj7 = obj6;
		bool flag2 = obj6 == null;
		object obj8 = !flag2;
		if (obj8 == null)
		{
			return;
		}
		goto IL_00b1;
		IL_007c:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v11+B8]");
		object obj9 = 0;
		obj7 = obj9;
		if (obj9 != null)
		{
			goto IL_00b1;
		}
		return;
		IL_00b1:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X8_v8+18]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X8_v8+40]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X8_v8+28]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v64 @ X3_v1 (should have been resolved before IL gen)");
		goto IL_00eb;
		IL_00eb:
		_ = 1;
		obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v11+E4]");
		bool flag3 = (nint)0 == 0;
		object obj13 = !flag3;
		obj4 = obj3;
		if (obj13 != null)
		{
			goto IL_007c;
		}
		goto IL_0131;
	}

	private static void OnCameraTakeSuccess(Texture2D texture2D)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_012b: Expected O, but got I4
		//IL_008c: Expected O, but got I
		//IL_009c: Expected O, but got I
		//IL_0163: Expected O, but got I
		//IL_0173: Expected O, but got I
		//IL_0195: Expected O, but got I4
		//IL_00d1: Expected O, but got I
		//IL_00e1: Expected O, but got I
		//IL_00f1: Expected O, but got I
		object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1152;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7630]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 == null)
		{
			goto IL_00fb;
		}
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v11+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = obj3;
		if (!flag)
		{
			goto IL_007c;
		}
		goto IL_0141;
		IL_0141:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v4+B8]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X8_v4+8]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X8_v4+8]");
		bool flag2 = (nint)0 == 0;
		object obj8 = !flag2;
		if (obj8 == null)
		{
			return;
		}
		goto IL_00c1;
		IL_007c:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v11+B8]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X8_v10+8]");
		obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X8_v10+8]");
		if ((nint)0 != 0)
		{
			goto IL_00c1;
		}
		return;
		IL_00c1:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X8_v8+18]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X8_v8+40]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X8_v8+28]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v64 @ X3_v1 (should have been resolved before IL gen)");
		goto IL_00fb;
		IL_00fb:
		_ = 1;
		obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v11+E4]");
		bool flag3 = (nint)0 == 0;
		object obj13 = !flag3;
		obj4 = obj3;
		if (obj13 != null)
		{
			goto IL_007c;
		}
		goto IL_0141;
	}

	private static void OnGalleryPickFailed()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0124: Expected O, but got I4
		//IL_0095: Expected O, but got I
		//IL_015c: Expected O, but got I
		//IL_017e: Expected O, but got I4
		//IL_00ca: Expected O, but got I
		//IL_00da: Expected O, but got I
		//IL_00ea: Expected O, but got I
		object obj = 152989696;
		object obj2 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1152;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7631]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 == null)
		{
			goto IL_00f4;
		}
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v11+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = obj4;
		if (!flag)
		{
			goto IL_0085;
		}
		goto IL_013a;
		IL_013a:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj6 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v4+B8]");
		object obj7 = 0;
		object obj8 = obj7;
		bool flag2 = obj7 == null;
		object obj9 = !flag2;
		if (obj9 == null)
		{
			return;
		}
		goto IL_00ba;
		IL_0085:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v11+B8]");
		object obj10 = 0;
		obj8 = obj10;
		if (obj10 != null)
		{
			goto IL_00ba;
		}
		return;
		IL_00ba:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X8_v8+18]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X8_v8+40]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X8_v8+28]");
		object obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v58 @ X3_v1 (should have been resolved before IL gen)");
		goto IL_00f4;
		IL_00f4:
		_ = 1;
		obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v11+E4]");
		bool flag3 = (nint)0 == 0;
		object obj14 = !flag3;
		obj5 = obj4;
		if (obj14 != null)
		{
			goto IL_0085;
		}
		goto IL_013a;
	}

	private static void OnCameraTakeFailed()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0134: Expected O, but got I4
		//IL_0095: Expected O, but got I
		//IL_00a5: Expected O, but got I
		//IL_016c: Expected O, but got I
		//IL_017c: Expected O, but got I
		//IL_019e: Expected O, but got I4
		//IL_00da: Expected O, but got I
		//IL_00ea: Expected O, but got I
		//IL_00fa: Expected O, but got I
		object obj = 152989696;
		object obj2 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1152;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7632]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 == null)
		{
			goto IL_0104;
		}
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v11+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = obj4;
		if (!flag)
		{
			goto IL_0085;
		}
		goto IL_014a;
		IL_014a:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj6 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v4+B8]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X8_v4+8]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X8_v4+8]");
		bool flag2 = (nint)0 == 0;
		object obj9 = !flag2;
		if (obj9 == null)
		{
			return;
		}
		goto IL_00ca;
		IL_0085:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v11+B8]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v10+8]");
		obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v10+8]");
		if ((nint)0 != 0)
		{
			goto IL_00ca;
		}
		return;
		IL_00ca:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X8_v8+18]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X8_v8+40]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X8_v8+28]");
		object obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v58 @ X3_v1 (should have been resolved before IL gen)");
		goto IL_0104;
		IL_0104:
		_ = 1;
		obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v11+E4]");
		bool flag3 = (nint)0 == 0;
		object obj14 = !flag3;
		obj5 = obj4;
		if (obj14 != null)
		{
			goto IL_0085;
		}
		goto IL_014a;
	}

	private static void PickPhotoFromGallery()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0281: Unknown result type (might be due to invalid IL or missing references)
		//IL_0286: Expected O, but got Unknown
		//IL_0290: Unknown result type (might be due to invalid IL or missing references)
		//IL_0295: Expected O, but got Unknown
		//IL_02ad: Expected I, but got O
		//IL_02d7: Expected O, but got I4
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Expected O, but got Unknown
		//IL_01b2: Expected O, but got I
		//IL_01cc: Expected O, but got I4
		//IL_00ec: Expected O, but got I
		//IL_0242: Expected O, but got I
		//IL_0264: Expected O, but got I4
		//IL_020a: Expected O, but got I4
		//IL_0183: Expected O, but got I
		//IL_014e: Expected O, but got I
		//IL_02f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fd: Expected O, but got Unknown
		object obj = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 544;
		object obj2 = (nint)0 + (nint)3352;
		object obj3 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2656;
		object input = "Cannot populate JSON object onto type '{0}'." + 2664;
		object obj4 = "https://www.kammelna.com/Home/Terms" + 632;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		NativeGallery.MediaPickCallback mediaPickCallback = default(NativeGallery.MediaPickCallback);
		mediaPickCallback..ctor(null, (IntPtr)obj2);
		object obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		string title = LocalizationUtil.Localize((string)input);
		string text = (string)obj4;
		if (NativeGallery.GetImageFromGallery(mediaPickCallback, title, (string)obj4) != NativeGallery.Permission.Denied)
		{
			return;
		}
		object obj7 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1152;
		object obj8 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X0_v10+E4]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7631]");
			object obj9 = (nint)0 & (nint)1;
			if (obj9 != null)
			{
				goto IL_0109;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7631]");
			object obj10 = (nint)0 & (nint)1;
			bool flag2 = obj10 == null;
			object obj11 = !flag2;
			if (obj11 != null)
			{
				goto IL_0109;
			}
		}
		_ = 1;
		object obj12 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ X0_v27+E4]");
		bool flag3 = (nint)0 == 0;
		object obj13 = !flag3;
		object obj14 = obj12;
		if (obj13 != null)
		{
			goto IL_013e;
		}
		goto IL_0220;
		IL_0109:
		obj12 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ X0_v27+E4]");
		bool flag4 = (nint)0 == 0;
		obj14 = obj12;
		if (!flag4)
		{
			goto IL_013e;
		}
		goto IL_0220;
		IL_013e:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ X0_v27+B8]");
		object obj15 = 0;
		object obj16 = obj15;
		if (obj15 != null)
		{
			goto IL_0173;
		}
		goto IL_02e5;
		IL_0220:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj17 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X0_v17+B8]");
		object obj18 = 0;
		obj16 = obj18;
		bool flag5 = obj18 == null;
		object obj19 = !flag5;
		if (obj19 != null)
		{
			goto IL_0173;
		}
		goto IL_02e5;
		IL_02e5:
		bool canOpenSettings = NativeGallery.CanOpenSettings();
		object permissionMessage = "COORDINATE_TYPE_GCJ_02" + 2032;
		ShowPermissionError((string)permissionMessage, canOpenSettings);
		return;
		IL_0173:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ X8_v15+28]");
		text = (string)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v182 @ X8_v15+18] (should have been resolved before IL gen)");
		goto IL_02e5;
	}

	private static void TakePhotoFromCamera()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_0250: Expected I, but got O
		//IL_0270: Expected I4, but got I8
		//IL_0270: Expected I4, but got I8
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected O, but got Unknown
		//IL_0162: Expected O, but got I
		//IL_017c: Expected O, but got I4
		//IL_009a: Expected O, but got I
		//IL_01f2: Expected O, but got I
		//IL_0202: Expected O, but got I
		//IL_0224: Expected O, but got I4
		//IL_01ba: Expected O, but got I4
		//IL_00fc: Expected O, but got I
		//IL_010c: Expected O, but got I
		//IL_028c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0291: Expected O, but got Unknown
		object obj = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 536;
		object obj2 = (nint)0 + (nint)3336;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		NativeCamera.CameraCallback cameraCallback = default(NativeCamera.CameraCallback);
		cameraCallback..ctor(null, (IntPtr)obj2);
		if (NativeCamera.TakePicture(cameraCallback, -1, saveAsJPEG: true, NativeCamera.PreferredCamera.Default) != NativeCamera.Permission.Denied)
		{
			return;
		}
		object obj3 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1152;
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X0_v6+E4]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7632]");
			object obj5 = (nint)0 & (nint)1;
			if (obj5 != null)
			{
				goto IL_00b7;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7632]");
			object obj6 = (nint)0 & (nint)1;
			bool flag = obj6 == null;
			object obj7 = !flag;
			if (obj7 != null)
			{
				goto IL_00b7;
			}
		}
		_ = 1;
		object obj8 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X0_v23+E4]");
		bool flag2 = (nint)0 == 0;
		object obj9 = !flag2;
		object obj10 = obj8;
		if (obj9 != null)
		{
			goto IL_00ec;
		}
		goto IL_01d0;
		IL_01d0:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj11 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X0_v13+B8]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X8_v8+8]");
		object obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X8_v8+8]");
		bool flag3 = (nint)0 == 0;
		object obj14 = !flag3;
		if (obj14 != null)
		{
			goto IL_0132;
		}
		goto IL_0279;
		IL_0279:
		bool canOpenSettings = NativeGallery.CanOpenSettings();
		object permissionMessage = "COORDINATE_TYPE_GCJ_02" + 2016;
		ShowPermissionError((string)permissionMessage, canOpenSettings);
		return;
		IL_0132:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v149 @ X8_v14+18] (should have been resolved before IL gen)");
		goto IL_0279;
		IL_00ec:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X0_v23+B8]");
		object obj15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X8_v16+8]");
		obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X8_v16+8]");
		if ((nint)0 != 0)
		{
			goto IL_0132;
		}
		goto IL_0279;
		IL_00b7:
		obj8 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X0_v23+E4]");
		bool flag4 = (nint)0 == 0;
		obj10 = obj8;
		if (!flag4)
		{
			goto IL_00ec;
		}
		goto IL_01d0;
	}

	private static void FileChooser()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00da: Expected O, but got I
		//IL_0104: Expected O, but got I4
		//IL_00b5: Expected O, but got I4
		//IL_005c: Expected O, but got I
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0154: Expected O, but got Unknown
		object obj = 152989696;
		object obj2 = typeof(Queue<string>) + 776;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E759C]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = (nint)0 + (nint)2072;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v6+E4]");
			bool flag = (nint)0 == 0;
			object obj6 = obj4;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			object obj4 = (nint)0 + (nint)2072;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v6+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			object obj6 = obj4;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		goto IL_0133;
		IL_0133:
		Component component = default(Component);
		GameObject gameObject = component.gameObject;
		object callbackFuncName = "Read object reference Id '{0}' for {1}." + 272;
		string objectName = gameObject.name;
		GetImage.GetImageFromUserAsync(objectName, (string)callbackFuncName);
		return;
		IL_0091:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		bool flag3 = (object)component == null;
		object obj8 = !flag3;
		if (obj8 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_0133;
	}

	private void ReceiveImage(string dataUrl)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_01d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01de: Expected O, but got Unknown
		//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0203: Expected O, but got Unknown
		//IL_022d: Expected O, but got I4
		//IL_0236: Expected O, but got I4
		//IL_05ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f3: Expected O, but got Unknown
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected O, but got Unknown
		//IL_009a: Expected O, but got I4
		//IL_03b9: Expected O, but got I
		//IL_03d3: Expected O, but got I4
		//IL_025f: Expected O, but got I4
		//IL_0575: Unknown result type (might be due to invalid IL or missing references)
		//IL_057a: Expected O, but got Unknown
		//IL_0302: Expected O, but got I
		//IL_0449: Expected O, but got I
		//IL_0411: Expected O, but got I4
		//IL_027b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0280: Expected O, but got Unknown
		//IL_02aa: Expected O, but got I4
		//IL_0364: Expected O, but got I
		//IL_0386: Expected O, but got I4
		//IL_02d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d6: Expected O, but got Unknown
		//IL_02e7: Expected O, but got I4
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Expected O, but got Unknown
		//IL_0498: Expected O, but got I
		//IL_04b2: Expected O, but got I4
		//IL_05ac: Expected O, but got I
		//IL_05bc: Expected O, but got I
		//IL_05cc: Expected O, but got I
		//IL_0138: Expected O, but got I
		//IL_0528: Expected O, but got I
		//IL_054a: Expected O, but got I4
		//IL_04f0: Expected O, but got I4
		//IL_019a: Expected O, but got I
		//IL_01bc: Expected O, but got I4
		object obj = "com.unity.services.authentication.profile" + 3096;
		string text = (string)obj;
		object obj6;
		object obj18 = default(object);
		object obj11;
		object obj13;
		if (dataUrl.StartsWith((string)obj))
		{
			string s = dataUrl.Substring(text._stringLength);
			object obj2 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3016;
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X8_v31+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			byte[] data = Convert.FromBase64String(s);
			object obj5 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 656;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Texture2D texture2D = default(Texture2D);
			texture2D..ctor(1, 1);
			if (ImageConversion.LoadImage(texture2D, data))
			{
				obj6 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1152;
				object obj7 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ X0_v41+E4]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E762F]");
					object obj8 = (nint)0 & (nint)1;
					if (obj8 != null)
					{
						goto IL_0155;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E762F]");
					object obj9 = (nint)0 & (nint)1;
					bool flag2 = obj9 == null;
					object obj10 = !flag2;
					if (obj10 != null)
					{
						goto IL_0155;
					}
				}
				_ = 1;
				obj11 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ X0_v51+E4]");
				bool flag3 = (nint)0 == 0;
				object obj12 = !flag3;
				obj13 = obj11;
				if (obj12 != null)
				{
					goto IL_018a;
				}
				goto IL_0506;
			}
			object obj14 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1144;
			object obj15 = obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v241 @ X0_v37+E4]");
			bool flag4 = (nint)0 == 0;
			object obj16 = !flag4;
			if (obj16 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj17 = "Complete" + 2152;
			obj18 = obj17;
			object obj19 = 0;
		}
		else
		{
			object obj20 = "Drop Menu Toggle" + 3744;
			string text2 = (string)obj20 + dataUrl;
			object obj21 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1144;
			object obj22 = obj21;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X8_v28+E4]");
			bool flag5 = (nint)0 == 0;
			object obj23 = !flag5;
			object obj19 = 0;
			obj18 = text2;
			if (obj23 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj19 = 0;
				obj18 = text2;
			}
		}
		goto IL_05d6;
		IL_05d6:
		KLogger.LogError(obj18);
		object obj24 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1152;
		object obj25 = obj24;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ X0_v7+E4]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7631]");
			object obj26 = (nint)0 & (nint)1;
			if (obj26 != null)
			{
				goto IL_031f;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7631]");
			object obj27 = (nint)0 & (nint)1;
			bool flag6 = obj27 == null;
			object obj28 = !flag6;
			if (obj28 != null)
			{
				goto IL_031f;
			}
		}
		_ = 1;
		object obj29 = obj24;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ X0_v18+E4]");
		bool flag7 = (nint)0 == 0;
		object obj30 = !flag7;
		object obj31 = obj29;
		if (obj30 != null)
		{
			goto IL_0354;
		}
		goto IL_0427;
		IL_031f:
		obj29 = obj24;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ X0_v18+E4]");
		bool flag8 = (nint)0 == 0;
		obj31 = obj29;
		if (!flag8)
		{
			goto IL_0354;
		}
		goto IL_0427;
		IL_046e:
		Texture2D texture2D2 = null;
		goto IL_059c;
		IL_0155:
		obj11 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ X0_v51+E4]");
		bool flag9 = (nint)0 == 0;
		obj13 = obj11;
		if (!flag9)
		{
			goto IL_018a;
		}
		goto IL_0506;
		IL_059c:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X8_v22+18]");
		object obj32 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X8_v22+40]");
		object obj33 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X8_v22+28]");
		object obj34 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v85 @ X3_v3 (should have been resolved before IL gen)");
		goto IL_05d6;
		IL_018a:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ X0_v51+B8]");
		object obj35 = 0;
		object obj36 = obj35;
		bool flag10 = obj35 == null;
		object obj37 = !flag10;
		if (obj37 == null)
		{
			return;
		}
		goto IL_059c;
		IL_0427:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj38 = obj24;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v226 @ X0_v11+B8]");
		object obj39 = 0;
		obj36 = obj39;
		if (obj39 != null)
		{
			goto IL_046e;
		}
		return;
		IL_0354:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ X0_v18+B8]");
		object obj40 = 0;
		obj36 = obj40;
		bool flag11 = obj40 == null;
		object obj41 = !flag11;
		if (obj41 == null)
		{
			return;
		}
		goto IL_046e;
		IL_0506:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj42 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v247 @ X0_v44+B8]");
		object obj43 = 0;
		obj36 = obj43;
		bool flag12 = obj43 == null;
		object obj44 = !flag12;
		if (obj44 == null)
		{
			return;
		}
		goto IL_059c;
	}

	private void WebcamShot(MediaType mediaType)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_011b: Expected O, but got I4
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Expected O, but got Unknown
		//IL_00a7: Expected O, but got I
		//IL_00c1: Expected O, but got I4
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Expected O, but got Unknown
		//IL_015d: Expected O, but got I
		object obj = 152989696;
		object obj2 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1152;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7636]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v6+E4]");
			if ((nint)0 != 0)
			{
				goto IL_007d;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v6+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 != null)
			{
				goto IL_007d;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj6 = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 1232;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7637]");
		object obj7 = (nint)0 & (nint)1;
		if (obj7 == null)
		{
			goto IL_00d7;
		}
		object obj8 = obj6;
		goto IL_0187;
		IL_00d7:
		_ = 1;
		obj8 = obj6;
		goto IL_0187;
		IL_007d:
		obj6 = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 1232;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7637]");
		object obj9 = (nint)0 & (nint)1;
		bool flag2 = obj9 == null;
		object obj10 = !flag2;
		obj8 = obj6;
		if (obj10 == null)
		{
			goto IL_00d7;
		}
		goto IL_0187;
		IL_0187:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj11 = default(object);
		obj11..ctor();
		_ = 0;
		Coroutine coroutine = StartCoroutine((IEnumerator)obj11);
	}

	private static IEnumerator WebcamShotRoutine(MediaType mediaType)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 1232;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		_ = 0;
		return (IEnumerator)obj2;
	}

	private static void FailCallback(MediaType mediaType)
	{
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Expected O, but got Unknown
		//IL_025f: Expected O, but got I
		//IL_0279: Expected O, but got I4
		//IL_001f: Expected O, but got I4
		//IL_016e: Expected O, but got I
		//IL_0428: Unknown result type (might be due to invalid IL or missing references)
		//IL_042d: Expected O, but got Unknown
		//IL_02ef: Expected O, but got I
		//IL_02ff: Expected O, but got I
		//IL_0321: Expected O, but got I4
		//IL_02b7: Expected O, but got I4
		//IL_0455: Unknown result type (might be due to invalid IL or missing references)
		//IL_045a: Expected O, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		//IL_0215: Expected O, but got I
		//IL_0225: Expected O, but got I
		//IL_0235: Expected O, but got I
		//IL_01d0: Expected O, but got I
		//IL_01e0: Expected O, but got I
		//IL_047d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0482: Expected O, but got Unknown
		//IL_0354: Expected O, but got I
		//IL_036e: Expected O, but got I4
		//IL_04af: Expected O, but got I
		//IL_0084: Expected O, but got I
		//IL_03e4: Expected O, but got I
		//IL_0406: Expected O, but got I4
		//IL_03ac: Expected O, but got I4
		//IL_00e6: Expected O, but got I
		//IL_0108: Expected O, but got I4
		object obj2;
		object obj7;
		object obj9;
		if (mediaType != MediaType.Camera)
		{
			bool flag = mediaType == MediaType.Gallery;
			object obj = !flag;
			if (obj == null)
			{
				obj2 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1152;
				object obj3 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v35+E4]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7631]");
					object obj4 = (nint)0 & (nint)1;
					if (obj4 != null)
					{
						goto IL_00a1;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7631]");
					object obj5 = (nint)0 & (nint)1;
					bool flag2 = obj5 == null;
					object obj6 = !flag2;
					if (obj6 != null)
					{
						goto IL_00a1;
					}
				}
				_ = 1;
				obj7 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X0_v45+E4]");
				bool flag3 = (nint)0 == 0;
				object obj8 = !flag3;
				obj9 = obj7;
				if (obj8 != null)
				{
					goto IL_00d6;
				}
				goto IL_03c2;
			}
			object obj10 = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 1240;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
			object obj11 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 656;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj12 = "m_StencilDeferredPS" + 1056;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			ArgumentOutOfRangeException ex = default(ArgumentOutOfRangeException);
			string paramName = default(string);
			object actualValue = default(object);
			ex..ctor(paramName, actualValue, null);
			object obj13 = (nint)0 + (nint)3328;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			throw new OutOfMemoryException();
		}
		object obj14 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1152;
		object obj15 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v4+E4]");
		if ((nint)0 == 0)
		{
			goto IL_023f;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7632]");
		object obj16 = (nint)0 & (nint)1;
		if (obj16 != null)
		{
			goto IL_018b;
		}
		goto IL_0287;
		IL_00d6:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X0_v45+B8]");
		object obj17 = 0;
		object obj18 = obj17;
		bool flag4 = obj17 == null;
		object obj19 = !flag4;
		if (obj19 == null)
		{
			return;
		}
		goto IL_0205;
		IL_02cd:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj20 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X0_v7+B8]");
		object obj21 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ X8_v6+8]");
		obj18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ X8_v6+8]");
		bool flag5 = (nint)0 == 0;
		object obj22 = !flag5;
		if (obj22 == null)
		{
			return;
		}
		goto IL_0205;
		IL_03c2:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj23 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X0_v38+B8]");
		object obj24 = 0;
		obj18 = obj24;
		bool flag6 = obj24 == null;
		object obj25 = !flag6;
		if (obj25 == null)
		{
			return;
		}
		goto IL_0205;
		IL_023f:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7632]");
		object obj26 = (nint)0 & (nint)1;
		bool flag7 = obj26 == null;
		object obj27 = !flag7;
		if (obj27 != null)
		{
			goto IL_018b;
		}
		goto IL_0287;
		IL_0205:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ X8_v3+18]");
		object obj28 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ X8_v3+40]");
		object obj29 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ X8_v3+28]");
		object obj30 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v164 @ X3_v1 (should have been resolved before IL gen)");
		goto IL_023f;
		IL_01c0:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X0_v14+B8]");
		object obj31 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X8_v13+8]");
		obj18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X8_v13+8]");
		if ((nint)0 == 0)
		{
			return;
		}
		goto IL_0205;
		IL_0287:
		_ = 1;
		object obj32 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X0_v14+E4]");
		bool flag8 = (nint)0 == 0;
		object obj33 = !flag8;
		object obj34 = obj32;
		if (obj33 != null)
		{
			goto IL_01c0;
		}
		goto IL_02cd;
		IL_018b:
		obj32 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X0_v14+E4]");
		bool flag9 = (nint)0 == 0;
		obj34 = obj32;
		if (!flag9)
		{
			goto IL_01c0;
		}
		goto IL_02cd;
		IL_00a1:
		obj7 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X0_v45+E4]");
		bool flag10 = (nint)0 == 0;
		obj9 = obj7;
		if (!flag10)
		{
			goto IL_00d6;
		}
		goto IL_03c2;
	}

	private static void ShowPermissionError(string permissionMessage, bool canOpenSettings)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0030: Expected I, but got O
		//IL_0040: Expected O, but got I
		//IL_00ea: Expected O, but got I4
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Expected O, but got Unknown
		//IL_0153: Expected O, but got I
		//IL_007b: Expected O, but got I
		//IL_05c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c8: Expected O, but got Unknown
		//IL_018e: Expected O, but got I
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Expected O, but got Unknown
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Expected O, but got Unknown
		//IL_031a: Unknown result type (might be due to invalid IL or missing references)
		//IL_031f: Expected O, but got Unknown
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Expected O, but got Unknown
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected O, but got Unknown
		//IL_0357: Expected O, but got I
		//IL_0379: Expected O, but got I4
		//IL_0382: Expected O, but got I4
		//IL_0215: Unknown result type (might be due to invalid IL or missing references)
		//IL_021a: Expected O, but got Unknown
		//IL_0230: Expected O, but got I
		//IL_023e: Expected I, but got O
		//IL_01fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0201: Expected O, but got Unknown
		//IL_03ec: Expected O, but got I
		//IL_024d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0252: Expected O, but got Unknown
		//IL_019c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a1: Expected O, but got Unknown
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01af: Expected O, but got Unknown
		//IL_03a1: Expected O, but got I4
		//IL_0285: Expected O, but got I
		//IL_046a: Unknown result type (might be due to invalid IL or missing references)
		//IL_046f: Expected O, but got Unknown
		//IL_06f0: Expected O, but got I
		//IL_03fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ff: Expected O, but got Unknown
		//IL_0408: Unknown result type (might be due to invalid IL or missing references)
		//IL_040d: Expected O, but got Unknown
		//IL_0623: Unknown result type (might be due to invalid IL or missing references)
		//IL_0628: Expected O, but got Unknown
		//IL_065b: Expected O, but got I
		//IL_067b: Expected O, but got I4
		//IL_068c: Expected O, but got I4
		//IL_02c0: Expected O, but got I
		//IL_04fd: Expected O, but got I
		//IL_0510: Unknown result type (might be due to invalid IL or missing references)
		//IL_0515: Expected O, but got Unknown
		//IL_052b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0530: Expected O, but got Unknown
		//IL_0548: Expected O, but got I
		//IL_049a: Expected O, but got I
		//IL_03cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d1: Expected O, but got Unknown
		//IL_02ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d3: Expected O, but got Unknown
		//IL_02dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e1: Expected O, but got Unknown
		//IL_04a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ad: Expected O, but got Unknown
		//IL_04b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04bb: Expected O, but got Unknown
		IPopupWindowBuilderNeedsTitle popupWindowBuilderNeedsTitle = PopupWindowBuilder.Create(PopupWindow.MessageType.Error);
		object obj = typeof(System.IOAsyncCallback) + 392;
		object obj2 = "Drop Menu Toggle" + 3600;
		nint num = (nint)popupWindowBuilderNeedsTitle;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X8_v6 (Il2CppClass<IPopupWindowBuilderNeedsTitle>)+12E]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X8_v6 (Il2CppClass<IPopupWindowBuilderNeedsTitle>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_00bc;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X8_v6 (Il2CppClass<IPopupWindowBuilderNeedsTitle>)+B0]");
		object obj4 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X10_v30-8]");
			if (0 == (nint)obj)
			{
				break;
			}
			obj4 += 16;
			obj3--;
			if ((nint)obj3 != 1)
			{
				continue;
			}
			goto IL_00bc;
		}
		object obj5 = num + obj4;
		object obj6 = obj5 + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v151 @ X8_v40] (should have been resolved before IL gen)");
		goto IL_0127;
		IL_0301:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_060f;
		IL_0445:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_06ce;
		IL_04db:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		object obj8 = default(object);
		object obj7 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v599 @ X0_v13+8]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v205 @ X2_v8 (should have been resolved before IL gen)");
		goto IL_0507;
		IL_06ce:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v556 @ X0_v9] (should have been resolved before IL gen)");
		object obj11 = default(object);
		object obj10 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v252 @ X8_v14+12E]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v252 @ X8_v14+12E]");
		if ((nint)0 == 0)
		{
			goto IL_04db;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v252 @ X8_v14+B0]");
		object obj13 = (nint)0 + (nint)8;
		object obj14;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ X10_v8-8]");
			if (0 == (nint)obj14)
			{
				break;
			}
			obj13 += 16;
			obj12--;
			if ((nint)obj12 != 1)
			{
				continue;
			}
			goto IL_04db;
		}
		goto IL_0507;
		IL_00bc:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v179 @ X0_v38] (should have been resolved before IL gen)");
		object obj15 = default(object);
		bool flag = obj15 == null;
		object obj16 = !flag;
		if (obj16 != null)
		{
			goto IL_0127;
		}
		goto IL_0552;
		IL_0127:
		object obj17 = typeof(System.IOAsyncCallback) + 384;
		object obj18 = obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v292 @ X8_v10+12E]");
		object obj19 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v292 @ X8_v10+12E]");
		if ((nint)0 == 0)
		{
			goto IL_01cf;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v292 @ X8_v10+B0]");
		object obj20 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v340 @ X10_v25-8]");
			if (0 == (nint)obj17)
			{
				break;
			}
			obj20 += 16;
			obj19--;
			if ((nint)obj19 != 1)
			{
				continue;
			}
			goto IL_01cf;
		}
		object obj21 = obj18 + obj20;
		object obj22 = obj21 + 312;
		goto IL_05b4;
		IL_060f:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v573 @ X0_v28] (should have been resolved before IL gen)");
		object label = "COORDINATE_TYPE_GCJ_02" + 1864;
		PopupButton popupButton = PopupButton.Neutral((string)label, null, dismiss: true);
		object obj23 = obj14;
		object obj24 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v422 @ X8_v17+12E]");
		object obj25 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v422 @ X8_v17+12E]");
		bool flag2 = (nint)0 == 0;
		object obj26 = 0;
		PopupButton popupButton2 = popupButton;
		object obj27 = 0;
		object obj28 = obj14;
		PopupButton popupButton3 = popupButton;
		if (!flag2)
		{
			goto IL_03d6;
		}
		goto IL_0445;
		IL_03d6:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v422 @ X8_v17+B0]");
		object obj29 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v477 @ X10_v14-8]");
			if (0 == (nint)obj23)
			{
				break;
			}
			obj29 += 16;
			obj25--;
			bool flag3 = (nint)obj25 != 1;
			obj27 = obj26;
			obj28 = obj23;
			popupButton3 = popupButton2;
			if (flag3)
			{
				continue;
			}
			goto IL_0445;
		}
		object obj30 = obj24 + obj29;
		object obj31 = obj30 + 312;
		obj27 = obj26;
		popupButton3 = popupButton2;
		goto IL_06ce;
		IL_0507:
		object obj32 = obj13 + 9;
		object obj33 = obj10 + obj32;
		object obj34 = obj33 + 312;
		object obj35 = obj34;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v613 @ X0_v15+8]");
		object obj36 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v206 @ X2_v9 (should have been resolved before IL gen)");
		goto IL_0552;
		IL_0552:
		throw new NullReferenceException();
		IL_01cf:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		object obj37 = default(object);
		obj22 = obj37;
		goto IL_05b4;
		IL_05b4:
		obj14 = typeof(System.IOAsyncCallback) + 368;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v362 @ X8_v11] (should have been resolved before IL gen)");
		if (canOpenSettings)
		{
			object obj38 = typeof(SqlSingle[]) + 2376;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj39 = (nint)0 + (nint)1888;
			Action action = default(Action);
			action..ctor(null, (IntPtr)obj39);
			object label2 = "FilterFunction '{0}' expects {1} parameters but only {2} were provided. Missing parameters will be set to their default values." + 3216;
			PopupButton popupButton4 = PopupButton.Positive((string)label2, action, dismiss: true);
			object obj40 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v430 @ X8_v28+12E]");
			object obj41 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v430 @ X8_v28+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0301;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v430 @ X8_v28+B0]");
			object obj42 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v531 @ X10_v20-8]");
				if (0 == (nint)obj14)
				{
					break;
				}
				obj42 += 16;
				obj41--;
				if ((nint)obj41 != 1)
				{
					continue;
				}
				goto IL_0301;
			}
			object obj43 = obj40 + obj42;
			object obj44 = obj43 + 312;
			goto IL_060f;
		}
		object label3 = "Network Authentication Required" + 3128;
		PopupButton popupButton5 = PopupButton.Neutral((string)label3, null, dismiss: true);
		obj23 = obj14;
		obj24 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v422 @ X8_v17+12E]");
		obj25 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v422 @ X8_v17+12E]");
		bool flag4 = (nint)0 == 0;
		object obj45 = !flag4;
		obj26 = 0;
		popupButton2 = popupButton5;
		if (obj45 != null)
		{
			goto IL_03d6;
		}
		obj27 = 0;
		obj28 = obj14;
		popupButton3 = popupButton5;
		goto IL_0445;
	}

	public KMediaPicker()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00ae: Expected O, but got I
		//IL_00d8: Expected O, but got I4
		//IL_005c: Expected O, but got I
		object obj = 152989696;
		object obj2 = typeof(Queue<string>) + 776;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E759E]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = (nint)0 + (nint)2064;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v1+E4]");
			bool flag = (nint)0 == 0;
			object obj6 = obj4;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			object obj4 = (nint)0 + (nint)2064;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v1+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			object obj6 = obj4;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CECC90");
		return;
		IL_0091:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CECC90");
	}
}
