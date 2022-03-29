using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{

    public float speed;
    public Rigidbody rb;
    private int score = 0;
    public int health = 5;
    public Text scoreText;
    public Text healthText;
    public Image winLose;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
         if (health == 0)
         {
            // Debug.Log("Game Over!");
            Text winLoseText = winLose.gameObject.transform.GetChild(0).gameObject.GetComponent<Text>();
            winLose.color = Color.red;
            winLoseText.color = Color.white;
            winLoseText.text = "Game Over!";
            winLose.gameObject.SetActive(true);
            // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            StartCoroutine(LoadScene(3));
        }
        float xDirection = Input.GetAxis("Horizontal");
        float zDirection = Input.GetAxis("Vertical");
        if (Input.GetKey(KeyCode.Escape))
        {
			SceneManager.LoadScene("menu");
		}

        rb.velocity = new Vector3(xDirection, 0.0f, zDirection) * speed;
        // transform.position += moveDirection * speed;
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Pickup")
        {
            score++;
            // Debug.Log($"Score: {score}");
            SetScoreText();
        }
        if (other.tag == "Trap")
        {
            health--;
            // Debug.Log($"Health: {health}");
            SetHealthText();
        }
        if (other.tag == "Goal")
        {
            // Debug.Log("You win!");
            Text winLoseText = winLose.gameObject.transform.GetChild(0).gameObject.GetComponent<Text>();
            winLoseText.color = Color.black;
            winLose.color = Color.green;
            winLoseText.text = "You Win!";
            winLose.gameObject.SetActive(true);
            StartCoroutine(LoadScene(3));
        }
    }
    IEnumerator LoadScene(float seconds)
    {
        yield return new WaitForSeconds(seconds);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    }
    void SetScoreText() => scoreText.text = $"Score: {score}";
	void SetHealthText() => healthText.text = $"Health: {health}";
}
