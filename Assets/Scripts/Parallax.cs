using UnityEngine;

public class Parallax : MonoBehaviour
{
    private MeshRenderer meshRenderer;
    public float animationSpeeed = 1f;

    private void Awake()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }
  
    
    private void Update()
    {
        meshRenderer.material.mainTextureOffset += new Vector2(animationSpeeed * Time.deltaTime, 0);
    }
}
