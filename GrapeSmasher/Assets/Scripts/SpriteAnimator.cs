using UnityEngine;

public class SpriteAnimator : MonoBehaviour
{
    public Sprite[] animationFrames; // Array to hold the frames of the animation.
    public int defaultFrame = 0; // The index of the default frame.
    private SpriteRenderer spriteRenderer; // Reference to the SpriteRenderer.

    void Start()
    {
        // Get the SpriteRenderer attached to the GameObject.
        spriteRenderer = GetComponent<SpriteRenderer>();
        if (animationFrames.Length > 0)
        {
            spriteRenderer.sprite = animationFrames[defaultFrame]; // Set the initial sprite to the default frame.
        }
    }

    void Update()
    {
        // Check for key presses and update the sprite accordingly.
        if (Input.GetKey(KeyCode.J))
        {
            SetFrame(2); // Set to the frame corresponding to "J".
        }
        else if (Input.GetKey(KeyCode.L))
        {
            SetFrame(4); // Set to the frame corresponding to "L".
        }
        else
        {
            SetFrame(defaultFrame); // Set to the default frame if no key is pressed.
        }
    }

    void SetFrame(int frameIndex)
    {
        // Ensure the frame index is within bounds.
        if (frameIndex >= 0 && frameIndex < animationFrames.Length)
        {
            spriteRenderer.sprite = animationFrames[frameIndex];
        }
        else
        {
            Debug.LogWarning("Frame index out of bounds: " + frameIndex);
        }
    }
}
