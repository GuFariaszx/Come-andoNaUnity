using UnityEngine;

public class Fibonnaci : MonoBehaviour
{
    // Sequência de fibonnaci usando o for 

    [SerializeField] int n;
    [SerializeField] int x=1, y=0, z=0;
    void Start()
    {
        for (int i = 0;i<n; i++)
        {
            z = x + y;
            print(z);
            y = x; x = z;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
