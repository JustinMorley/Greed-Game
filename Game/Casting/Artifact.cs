namespace Unit04.Game.Casting{
        /// <summary>
        /// <para>An item of cultural or historical interest.</para>
        /// <para>
        /// The responsibility of an Artifact is to provide a message about itself.
        /// </para>
        /// </summary>
    class Artifact : Actor{
        private string _artifact;
        private int _cellSize = 15;
        /// <summary>
        /// Constructs a new instance of Artifact.
        /// </summary>
        public Artifact(){
            _artifact = "artifact";
        }

        /// <summary>
        /// Gets the artifact's message.
        /// </summary>
        /// <returns>The message as a string.</returns>
        public string GetMessage(){
            return _artifact;
        }
        
        /// <summary>
        /// Sets the artifact's message to the given value.
        /// </summary>
        /// <param name="message">The given message.</param>
        public void SetMessage(string message){
            _artifact = message;
        }
        public Point ArtifactDirection()
        {
            int dx = 1;
            int dy = 0;
            Point direction = new Point(dx, dy);
            direction = direction.Scale(_cellSize);

            return direction;
        }

    }
}
