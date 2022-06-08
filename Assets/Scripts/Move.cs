using UnityEngine;

public class Move : MonoBehaviour
{
    public float moveSpeed;
    
    private void Update()
    {
        Vector3 dir = new Vector3
        {
            x = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime,
            z = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime
        };
        transform.Translate(dir);
    }
}