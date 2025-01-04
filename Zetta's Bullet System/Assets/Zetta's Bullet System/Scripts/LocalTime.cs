using UnityEngine;

/// <summary>
/// Class that contain a local time variable that works independently of Unity's Time class.
/// </summary>
public static class LocalTime
{
    private static float _timeScale = 1.0f;

    /// <summary>
    /// Value of local time scale. Clamped between 0 and 1.
    /// </summary>
    public static float TimeScale
    {
        get => _timeScale;
        set => _timeScale = Mathf.Clamp(value, 0.0f, 1.0f);
    }
}