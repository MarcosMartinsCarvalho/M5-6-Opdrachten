using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    public GameObject prefab; 
    private float elapsedTime = 0f;

    void Start()
    {
        for (int i = 0; i < 100; i++)
        {
            Color color = RandomColor();
            Vector3 position = RandomPosition(-10f, 10f);
            CreateBall(color, position);
        }
    }

    void Update()
    {
        elapsedTime += Time.deltaTime;
        if (elapsedTime > 1f)
        {
            Color color = RandomColor();
            Vector3 position = RandomPosition(-10f, 10f);
            GameObject ball = CreateBall(color, position);
            DestroyBall(ball);
            elapsedTime = 0f;
        }
    }

    private GameObject CreateBall(Color c, Vector3 position)
    {
        GameObject ball = Instantiate(prefab, position, Quaternion.identity);
        Material material = ball.GetComponent<MeshRenderer>().material;

        
        if (material.shader.name == "Universal Render Pipeline/Lit")
        {
            material.SetColor("_BaseColor", c);
        }
        else
        {
            material.SetColor("_Color", c);
        }

        return ball;
    }

    private void DestroyBall(GameObject ball)
    {
        Destroy(ball, 3f);
    }

    private Color RandomColor()
    {
        float r = Random.Range(0f, 1f);
        float g = Random.Range(0f, 1f);
        float b = Random.Range(0f, 1f);
        return new Color(r, g, b, 1f);
    }

    private Vector3 RandomPosition(float min, float max)
    {
        float x = Random.Range(min, max);
        float y = Random.Range(min, max);
        float z = Random.Range(min, max);
        return new Vector3(x, y, z);
    }
}
