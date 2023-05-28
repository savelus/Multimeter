public static class Measures
{
    public static float Voltage { get; set; }
    public static float CurrentStrength { get; set; }
    public static float AlternativeCurrent { get; } = 0.1f;
    public static float Resistance { get; } = 1000.0f;
    public static float Power { get; } = 400.0f;
}