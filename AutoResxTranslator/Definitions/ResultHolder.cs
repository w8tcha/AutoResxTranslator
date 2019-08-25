namespace AutoResxTranslator.Definitions
{
    /// <summary>
    /// The result holder.
    /// </summary>
    /// <typeparam name="T">
    /// </typeparam>
    public class ResultHolder<T>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResultHolder{T}"/> class.
        /// </summary>
        public ResultHolder()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResultHolder{T}"/> class.
        /// </summary>
        /// <param name="success">
        /// The success.
        /// </param>
        public ResultHolder(bool success)
        {
            this.Success = success;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResultHolder{T}"/> class.
        /// </summary>
        /// <param name="success">
        /// The success.
        /// </param>
        /// <param name="result">
        /// The result.
        /// </param>
        public ResultHolder(bool success, T result)
        {
            this.Success = success;
            this.Result = result;
        }

        /// <summary>
        /// Gets or sets a value indicating whether success.
        /// </summary>
        public bool Success { get; set; }

        /// <summary>
        /// Gets or sets the result.
        /// </summary>
        public T Result { get; set; }
    }
}