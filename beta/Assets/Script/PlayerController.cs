using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerController : MonoBehaviour
{
    private CharacterController controller;
    private Vector3 dir;
    [SerializeField] private int speed;
    public float gravity;
    private int lineToMove = 1;
    public float lineDistance = 4;
    private float maxSpeed = 70;
    private int coins;
    [SerializeField] private GameObject losePanel;
    [SerializeField] private TMP_Text coinsText;

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
        StartCoroutine(SpeedIncrease());
        Time.timeScale = 1;
    }

    private void Update()
    {
        if (SwipeController.swipeRight)
        {
            if (lineToMove < 2)
                lineToMove++;
        }

        if (SwipeController.swipeLeft)
        {
            if (lineToMove > 0)
                lineToMove--;
        }

        Vector3 targetPosition = transform.position.z * transform.forward + transform.position.y * transform.up;
        if (lineToMove == 0)
            targetPosition += Vector3.left * lineDistance;
        else if (lineToMove == 2)
            targetPosition += Vector3.right * lineDistance;

        if (transform.position == targetPosition)
            return;
        Vector3 diff = targetPosition - transform.position;
        Vector3 moveDir = diff.normalized * 25 * Time.deltaTime;
        if (moveDir.sqrMagnitude < diff.sqrMagnitude)
            controller.Move(moveDir);
        else
            controller.Move(diff);

    }



    // Update is called once per frame
    void FixedUpdate()
    {
        dir.z = speed;
        controller.Move(dir * Time.fixedDeltaTime);
    }

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.gameObject.tag == "obstacle")
        {
            losePanel.SetActive(true);
            Time.timeScale = 0;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Coin")
        {
            coins++;
            coinsText.text = coins.ToString();
            Destroy(other.gameObject);
        }
    }

    private IEnumerator SpeedIncrease()
    {
        yield return new WaitForSeconds(4);
        if (speed < maxSpeed)
        {
            speed += 3;
            StartCoroutine(SpeedIncrease());            
        }
        else
        {
            speed += 0;
        }

    }
}
