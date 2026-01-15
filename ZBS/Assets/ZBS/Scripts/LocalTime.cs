using UnityEngine;

namespace ZettaGames.ZBS
{
    /// <summary>
    /// A class that provides a time scale that can be controlled locally, independent from Unity's global time scale.
    /// </summary>
    public static class Localtime
    {
        private static float _timeScale = 1f;

        /// <summary>
        /// Value that represents the time scale. Clamped between 0 and 1.
        /// </summary>
        public static float TimeScale
        {
            get { return _timeScale; }
            set { _timeScale = Mathf.Clamp01(value); }
        }
    }
}