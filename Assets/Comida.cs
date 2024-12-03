using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
public class Comida : MonoBehaviour
{
    public Collider2D gridArea;
    private Cobra cobra;

    private void Awake()
    {
        cobra = FindObjectOfType<Cobra>();
    }

    private void Start()
    {
        RandomizePosition();
    }

    public void RandomizePosition()
    {
        Bounds bounds = gridArea.bounds;

        //Escolhe uma posição aleatória dentro dos limites
        // Arredonda os valores para garantir que estejam alinhados com a grade
        int x = Mathf.RoundToInt(Random.Range(bounds.min.x, bounds.max.x));
        int y = Mathf.RoundToInt(Random.Range(bounds.min.y, bounds.max.y));

        // Evita que a comida spawne na posição da cobra
        while (cobra.Occupies(x, y))
        {
            x++;

            if (x > bounds.max.x)
            {
                x = Mathf.RoundToInt(bounds.min.x);
                y++;

                if (y > bounds.max.y)
                {
                    y = Mathf.RoundToInt(bounds.min.y);
                }
            }
        }

        transform.position = new Vector2(x, y);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        RandomizePosition();
    }

}