using UnityEngine;

public class RandomEnemyMovement : MonoBehaviour
{ 
    public float moveSpeed = 2f; // enemy movement speed
    public float moveInterval = 2f; // time between each movement

    private float timer;
    private Vector3 targetPosition;

    void Start()
    {
        timer = moveInterval; // Set time interval
        SetNewTargetPosition(); // Target position
    }


    void Update()
    {
        timer -= Time.deltaTime; 
    
        if (timer <= 0f)
        {
            SetNewTargetPosition();
            timer = moveInterval;

        }

        transform.position = Vector3.MoveTowards(transform.position, targetPosition, moveSpeed * Time.deltaTime);
    }

    
    void SetNewTargetPosition()
    {

       float xMove = Random.Range(-1f, 1f);
       float zMove = Random.Range(-1f, 1f);
     
        targetPosition = new Vector3(transform.position.x + xMove, transform.position.z + zMove);
    }
}
