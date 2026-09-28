using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;

public class ParticlesRemoteControl : MonoBehaviour
{
	private int emissionRate;

	private int duration;

	private ParticleSystem _particles;

	private void Start()
	{
		//IL_000c: Expected O, but got I
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		object obj = (nint)0 + (nint)3976;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
		object obj2 = this + 40;
		object obj3 = default(object);
		obj2 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	public unsafe void Rate()
	{
		//IL_0008: Expected O, but got Ref
		//IL_003c: Expected F4, but got I4
		//IL_0053: Expected O, but got Ref
		//IL_0060: Expected O, but got Ref
		//IL_0083: Expected F4, but got I4
		object obj2 = default(object);
		object obj = (object)(&obj2);
		_particles.Clear();
		ParticleSystem.EmissionModule emission = _particles.emission;
		ParticleSystem.MinMaxCurve minMaxCurve = emissionRate;
		ParticleSystem.EmissionModule emissionModule = (ParticleSystem.EmissionModule)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 24));
		ParticleSystem.MainModule mainModule = default(ParticleSystem.MainModule);
		((ParticleSystem.EmissionModule*)emissionModule)->rateOverTime = (ParticleSystem.MinMaxCurve)(&mainModule);
		ParticleSystem.MainModule main = _particles.main;
		mainModule.duration = duration;
		_particles.Play();
	}
}
