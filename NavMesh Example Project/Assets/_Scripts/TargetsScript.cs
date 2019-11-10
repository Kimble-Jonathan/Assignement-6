using UnityEngine;
using UnityEngine.UI;
public class TargetsScript : MonoBehaviour
{
    public GameObject player;
    public static int targetsDestroyed = 0;
    public Text scoreText;




    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        Debug.Log("playerFound");
        scoreText.text = "Targets destroyed: ";
    }


    private void Update()
    {
        transform.Rotate(new Vector3(0, 0, 45) * Time.deltaTime);
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "LowBody")
        {
            targetsDestroyed += 1;
            Debug.Log("Destroyed");
            scoreText.text = "Targets destroyed: " + targetsDestroyed;
            Destroy(gameObject);
        }
    }
}
