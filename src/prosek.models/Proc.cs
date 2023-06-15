namespace prosek.models
{
    public class Proc
    {
        /// <summary>
        /// Gets or sets Process Name.
        /// </summary>
        /// <value>
        /// The Process Name.
        /// </value>
        public string? Name { get; set; }

        /// <summary>
        /// Gets or sets Process Id.
        /// </summary>
        /// <value>
        /// The Process Id.
        /// </value>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets Process Path.
        /// </summary>
        /// <value>
        /// The Process Path.
        /// </value>
        public string? Path { get; set; }
    }
}