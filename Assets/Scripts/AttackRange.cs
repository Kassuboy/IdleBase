using UnityEngine;

public class AttackRange : MonoBehaviour
{
    int steps = 200;

    LineRenderer lindRenderer;
    BulletSpawner bulletSpawner;

    private void Awake()
    {
        lindRenderer = GetComponent<LineRenderer>();
        bulletSpawner = GameObject.FindGameObjectWithTag("GameManager").GetComponent<BulletSpawner>();
    }

    private void Update()
    {
        DrawCircle();
    }

    void DrawCircle()
    {
        lindRenderer.positionCount = steps;

        for(int currentStep = 0; currentStep < steps; currentStep++)
        {
            float circumferenceProgress = (float)currentStep / steps;

            float currentRadian = circumferenceProgress * 2 * Mathf.PI;

            float xScaled = Mathf.Cos(currentRadian);
            float yScaled = Mathf.Sin(currentRadian);

            float x = xScaled * bulletSpawner.lengthCheak;
            float y = yScaled * bulletSpawner.lengthCheak;

            Vector3 currentPosition = new Vector3(x, y + 9.31f, 0f);

            lindRenderer.SetPosition(currentStep, currentPosition);
        }
    }
}
