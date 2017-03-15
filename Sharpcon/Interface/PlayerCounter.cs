namespace Sharpcon.Interface
{
    public static class PlayerCounter
    {
        /// <summary>
        /// Sets the player count at the bottom
        /// </summary>
        public static void SetText(int playerCount)
        {
            Form1.Counter.Text = playerCount.ToString();
        }

        /// <summary>
        /// Resets the player counter to its original value
        /// </summary>
        public static void Reset()
        {
            SetText(0);
        }
    }
}
