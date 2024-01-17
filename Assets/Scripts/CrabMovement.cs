using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CrabMovement : MonoBehaviour
{
    Rigidbody2D rb;

    public float speed = 5;
    public GameObject objectToSelect;
    int animPlayed = 0;

    public TextMeshProUGUI messagesTxtWin;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();   
    }

    public void Win()
    {
        messagesTxtWin.text = "Congratulations, you are rich!";
        GameManager.instance.StopTime();
    }
    public void PlayCurrentHint()
    {
        GameObject.Find("Hint" + animPlayed).GetComponent<Animator>().enabled = true;
    }

    private void Update()
    {      
        if (transform.position.x > 10.2f)
        {
            Vector3 v = transform.position;
            v.x = 10.2f;
            transform.position = v;
        }
        if (transform.position.x < -10.2f)
        {
            Vector3 v = transform.position;
            v.x = -10.2f;
            transform.position = v;
        }

        if (transform.position.y > 4.5f)
        {
            Vector3 v = transform.position;
            v.y = 4.5f;
            transform.position = v;
        }
        if (transform.position.y < -4.5f)
        {
            Vector3 v = transform.position;
            v.y = -4.5f;
            transform.position = v;
        }
        
        if (animPlayed == 0 && Input.GetButtonDown("Select") && objectToSelect.name == "RightCoconut")
        {
            Debug.Log("select");
                
            GameObject.Find("Ykey1").GetComponent<Ykey>().Animate();
            
            animPlayed++;
            Invoke(nameof(PlayCurrentHint), 2);
        }
        
        else if (animPlayed == 1 && Input.GetButtonDown("Select") && objectToSelect.name == "CenterPalm")
        {
            GameObject.Find("Ykey2").GetComponent<Ykey2>().Animate();

            animPlayed++;
            Invoke(nameof(PlayCurrentHint), 2);
        }

        else if (animPlayed == 2 && Input.GetButtonDown("Select") && objectToSelect.name == "PinkShell")
        {
            GameObject.Find("Ykey3").GetComponent<Ykey3>().Animate();

            animPlayed++;
            Invoke(nameof(Win), 2);
        }

        if (Input.GetButtonDown("Select") && objectToSelect.tag == "false")
        {
            GameManager.instance.MinusTime();
        }
    }

    private void FixedUpdate()
    {
        if (GameManager.instance.myState != GameManager.State.playing) return;

        if (Mathf.Abs(Input.GetAxis("Vertical")) > 0.5f)
        {
            rb.rotation = 90;
        }
        if (Mathf.Abs(Input.GetAxis("Horizontal")) > 0.5f) 
        {
            rb.rotation = 0;
        }

        Vector2 v = rb.velocity;
        v.x = Input.GetAxis("Horizontal") * speed;
        v.y = Input.GetAxis("Vertical") * speed;
        rb.velocity = v;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "correct")
        {
            objectToSelect = collision.gameObject;
            Debug.Log("trigger " + objectToSelect.name);
        }

       else if (collision.gameObject.tag == "false")
        {
            objectToSelect = collision.gameObject;
            Debug.Log("trigger " + objectToSelect.tag);
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "correct")
            objectToSelect = null;
    }
}

