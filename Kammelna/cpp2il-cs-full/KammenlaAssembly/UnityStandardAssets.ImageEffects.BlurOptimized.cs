using UnityEngine;

namespace UnityStandardAssets.ImageEffects;

public class BlurOptimized : MonoBehaviour
{
	public enum BlurType
	{
		StandardGauss,
		SgxGauss
	}

	public int downsample = 1;

	public float blurSize;

	public int blurIterations = 2;

	public BlurType blurType;

	public Shader blurShader;

	protected virtual void Start()
	{
	}

	public virtual void OnDisable()
	{
	}
}
