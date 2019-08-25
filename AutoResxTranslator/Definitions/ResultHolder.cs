namespace AutoResxTranslator.Definitions
{
    public class ResultHolder<T>
    {
        public ResultHolder()
        {
        }

        public ResultHolder(bool success)
        {
            this.Success = success;
        }

        public ResultHolder(bool success, T result)
        {
            this.Success = success;
            this.Result = result;
        }

        public bool Success { get; set; }

        public T Result { get; set; }
    }
}