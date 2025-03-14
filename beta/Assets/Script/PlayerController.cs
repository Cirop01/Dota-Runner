using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using YG;
using PlayerPrefs = RedefineYG.PlayerPrefs;
public class PlayerController : MonoBehaviour
{
    private CharacterController controller;
    private Vector3 dir;
    //private Animator animate;
    [SerializeField] private int speed;
    [SerializeField] private Text Coins_counter1;
    [SerializeField] private Text Coins_counter2;
    private int lineToMove = 1;
    public float lineDistance = 4;
    private float maxSpeed = 90;
    public static int coins = 0;


    [SerializeField] private GameObject losePanel;
    [SerializeField] private float jumpForce;
    [SerializeField] private float gravity;
    // Start is called before the first frame update
    void Start()
    {
        coins = 0;
        //    animate = GetComponent<Animator>();
        controller = GetComponent<CharacterController>();
        StartCoroutine(SpeedIncrease());
        Time.timeScale = 1;

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
            {
                //animate.SetBool("Running", false);
                AnimatorController.Running_false();
                Jump();
            }
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
        //animate.SetBool("Jumping", true);
        AnimatorController.Jumping_true();
    }



    // Update is called once per frame
    private void FixedUpdate()
    {
        dir.z = speed;
        dir.y += gravity * Time.fixedDeltaTime;
        controller.Move(dir * Time.fixedDeltaTime);

        // Проверяем, является ли персонаж приземленным
        if (controller.isGrounded && AnimatorController._animator.GetBool("Jumping"))
        {
            // Отключаем анимацию прыжка
            //animate.SetBool("Jumping", false);
            AnimatorController.Jumping_false();
            // Включаем анимацию бега
            //animate.SetBool("Running", true);
            AnimatorController.Running_true();
        }
    }

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.gameObject.tag == "obstacle")
        {
            losePanel.SetActive(true);
            Time.timeScale = 0;
            YG2.InterstitialAdvShow();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Coin")
        {
            coins += 1;
            PlayerPrefs.SetInt("coins_while", coins);
            PlayerPrefs.Save();
            Coins_counter1.text = coins.ToString();
            Coins_counter2.text = coins.ToString();
            Destroy(other.gameObject);
        }

    }



    private IEnumerator SpeedIncrease()
    {
        yield return new WaitForSeconds(9);
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


    private void OnFullscreenStart() => Debug.Log("ON FULLSCREEN START");

    private void OnFullscreenClose(bool success) => Debug.Log("ON FULLSCREEN CLOSE");
}
