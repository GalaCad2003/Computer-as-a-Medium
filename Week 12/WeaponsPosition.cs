using UnityEngine;
using UnityEngine.InputSystem;

public class WeaponsPosition : MonoBehaviour
{
    public Rigidbody2D rb;
    public SpriteRenderer spriteRenderer;

    public UnityEngine.Sprite swordup;
    public UnityEngine.Sprite sworddown;
    public UnityEngine.Sprite swordleft;
    public UnityEngine.Sprite swordright;

    public Transform firepointTransform;
   
    private float targetRotationZ = 0f;

    void Start()
    {
       
        
    }

    void Update()
    {
        Position();
    }

    void Position()
    {

        if (Keyboard.current.aKey.isPressed)
        {
            
            spriteRenderer.sprite = swordleft;
            targetRotationZ = 90f;
        }
        else if (Keyboard.current.dKey.isPressed)
        {
           
            spriteRenderer.sprite = swordright;
            targetRotationZ = -90f;
        }
        else if (Keyboard.current.wKey.isPressed)
        {
           
            spriteRenderer.sprite = swordup;
            targetRotationZ = 0f;
        }
        else if (Keyboard.current.sKey.isPressed)
        {
            
            spriteRenderer.sprite = sworddown;
            targetRotationZ = 180f;
        }
       
      

        if (firepointTransform != null)
        {
            firepointTransform.localRotation = Quaternion.Euler(0f, 0f, targetRotationZ);
        }
    }
}
