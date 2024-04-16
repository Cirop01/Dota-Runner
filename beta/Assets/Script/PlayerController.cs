using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerController : MonoBehaviour
{
    private CharacterController controller;
    private Vector3 dir;
    [SerializeField] private int speed;
    private int lineToMove = 1;
    public float lineDistance = 4;
    private float maxSpeed = 90;
    private int coins;
    private Animator _animator;
    public static int coins_all;
    //public static int coins_all = PlayerPrefs.GetInt("coins_all");
    [SerializeField] private GameObject losePanel;
    [SerializeField] private TMP_Text coinsText;
    [SerializeField] private TMP_Text coinsResult;
    [SerializeField] private float jumpForce;
    [SerializeField] private float gravity;
    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
        StartCoroutine(SpeedIncrease());
        Time.timeScale = 1;
        coins = PlayerPrefs.GetInt("coins");
        _animator.SetBool("jump", false);
        
    }

    void UpdateRunes()
    {

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
        if (SwipeController.swipeUp)
        {

            if (controller.isGrounded)
                Jump();
                
                
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

    private void Jump()
    {
        dir.y = jumpForce;
        _animator.SetBool("jump", false);
    }



    // Update is called once per frame
    void FixedUpdate()
    {
        dir.z = speed;
        dir.y += gravity * Time.fixedDeltaTime;
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
            coinsResult.text = coins.ToString();
            Destroy(other.gameObject);
            PlayerPrefs.SetInt("coins", coins);
            coins_all += 1;
            PlayerPrefs.SetInt("coins_all", coins_all);
            //coins_all += 1;

        }

    }

    private IEnumerator SpeedIncrease()
    {
        yield return new WaitForSeconds(4);
        if (speed < maxSpeed)
        {
            speed += 1;
            StartCoroutine(SpeedIncrease());            
        }
        else
        {
            speed += 0;
        }

    }
}
