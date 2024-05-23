public class SoftLimit
{
    public static float SoftLimit(float x)
    {
        x = Mathf.max(x,0);
        return x/(x+1);
    }
}
