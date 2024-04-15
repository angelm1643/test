using UnityEngine;

namespace course
{
    public class validate : MonoBehaviour  // el onvalidate sirve para que los cambios de un script se actualizen automaticamente sin que nosotros tengamos que estar configuirandolo
    {
        [SerializeField] private Sprite sprite;
        [SerializeField] private SpriteRenderer spriterenderer;

        private void OnValidate()
        {
            if (!spriterenderer)
            {
                spriterenderer = GetComponent<SpriteRenderer>(); 
            }
            if (!sprite)
            {
                Debug.Log("Missing sprite");
                return;
            }
            spriterenderer.sprite = sprite;
        }
    }
}
