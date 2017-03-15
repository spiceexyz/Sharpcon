namespace Sharpcon.Interface
{
    public static class ConnectStatus
    {
        /// <summary>
        /// Sets the status text at the bottom of the application
        /// </summary>
        /// <param name="text"></param>
        public static void SetText(string text)
        {
            Form1.Status.Text = text;
        }
    }
}
