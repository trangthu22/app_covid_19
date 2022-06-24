namespace AppCovid19.DTO
{
    public class ResponseDTO<T>
    {
        public bool IsSuccess { get; set; }

        public string Message { get; set; }

        public T Data { get; set; }

        public static ResponseDTO<T> ResponseSuccess(T data, string message) => new ResponseDTO<T>()
        {
            IsSuccess = true,
            Data = data,
            Message = message
        };

        public static ResponseDTO<T> ResponseFailure(string message) => new ResponseDTO<T>()
        {
            IsSuccess = false,
            Message = message
        };
    }
}